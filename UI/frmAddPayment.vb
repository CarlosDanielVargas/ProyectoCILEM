Imports BL
Imports DOM

Public Class frmAddPayment
    Private minor As Minor

    Private preexistingPayments As List(Of MonthlyPayment)
    Private payments As List(Of MonthlyPayment)
    Private preexistingRepresentatives As List(Of Representative)
    Private representatives As List(Of Representative)
    Private preexistingRepresentativeMinors As List(Of RepresentativeMinor)
    Private representativeMinors As List(Of RepresentativeMinor)

    ' Constructor for adding a new payment
    Public Sub New(user As Minor)
        InitializeComponent()
        Me.minor = user
    End Sub

    ' Load the frmAddPayment form
    Private Sub frmAddPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtStudent.Text = minor.Name + " - " + minor.MinorID
        preexistingPayments = New List(Of MonthlyPayment)
        preexistingRepresentatives = New List(Of Representative)
        preexistingRepresentativeMinors = New List(Of RepresentativeMinor)
        payments = minor.Payments
        representatives = minor.Representatives
        representativeMinors = minor.RepresentativeMinors
        If representativeMinors IsNot Nothing Then
            preexistingRepresentativeMinors.AddRange(minor.RepresentativeMinors)
        End If
        If minor.Payments IsNot Nothing Then
            preexistingPayments.AddRange(minor.Payments)
        End If
        If minor.Payments IsNot Nothing Then
            preexistingPayments.AddRange(minor.Payments)
        End If

        PoblatePaymentDataGridView()

    End Sub

    ' Method to populate the DataGridView with the payments
    Private Sub PoblatePaymentDataGridView()
        dgvPayments.Columns.Clear()
        dgvPayments.ReadOnly = True ' Set the DataGridView to read-only
        dgvPayments.AllowUserToAddRows = False ' Disable the ability to add new rows

        dgvPayments.Columns.Add("Fecha", "Fecha")
        dgvPayments.Columns.Add("Monto", "Monto")
        dgvPayments.Columns.Add("Mes cancelado", "Mes cancelado")
        dgvPayments.Columns.Add("Observaciones", "Observaciones")
        dgvPayments.Columns.Add("Nº Depósito", "Nº Depósito")

        For Each column As DataGridViewColumn In dgvPayments.Columns
            column.ReadOnly = True ' Set individual columns to read-only
        Next

        dgvPayments.Rows.Clear()

        For Each payment As MonthlyPayment In payments
            dgvPayments.Rows.Add(payment.PaymentDate, payment.Value, payment.Month, payment.Observation, payment.DepositNumber)
        Next
    End Sub

    ' Method to add a new payment to the list
    Private Sub btnAddPayment_Click(sender As Object, e As EventArgs) Handles btnAddPayment.Click
        Dim minorManager As MinorManager = New MinorManager()
        ' Insertion of the new payment in the list
        Try
            ' Ask if the user wants to add a new payment because this is an irreversible action
            Dim result As DialogResult = MessageBox.Show("¿Estás seguro de que deseas agregar un nuevo pago? Estos registros no pueden eliminarse o editarse", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Dim montlyPayment As MonthlyPayment = New MonthlyPayment()
            montlyPayment.PaymentDate = dtpDayPaid.Value
            montlyPayment.Value = tbValue.Text
            montlyPayment.Month = tbMonth.Text
            montlyPayment.Observation = tbObservation.Text
            montlyPayment.DepositNumber = tbDepositNumber.Text
            montlyPayment.Validate()

            If result = DialogResult.Yes Then
                ' Add the payment to the list
                payments.Add(montlyPayment)

                ' Reload the DataGridView data after addition
                PoblatePaymentDataGridView()

                ' Clear the textboxes
                tbValue.Text = "0"
                tbMonth.Text = ""
                tbObservation.Text = ""
                tbDepositNumber.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        ' Update minor's payments
        Try
            minor.Representatives = representatives.Except(preexistingRepresentatives).ToList()
            minor.RepresentativeMinors = representativeMinors.Except(preexistingRepresentativeMinors).ToList()
            minor.Payments = payments.Except(preexistingPayments).ToList()
            minorManager.updateToDB(minor)
            MessageBox.Show(Me.MdiParent, "Se ha actualizado correctamente la información del estudiante")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class