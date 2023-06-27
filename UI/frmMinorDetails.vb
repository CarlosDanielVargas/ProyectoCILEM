Imports BL
Imports DOM

Public Class frmMinorDetails
    Property minor As Minor
    Private representatives As List(Of Representative)
    Private payments As List(Of MonthlyPayment)


    ' Constructor para recibir los datos del niño y el encargado legal
    Public Sub New(minor As Minor)
        InitializeComponent()

        ' Asignar los valores recibidos a las propiedades correspondientes
        Me.minor = minor
    End Sub

    Private Sub frmMinorDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mostrar los datos del niño en los controles correspondientes
        txtNombreCompleto.Text = minor.Name
        txtFechaEgreso.Text = minor.GraduationDate.ToString("dd/MM/yyyy")
        txtFechaIngreso.Text = minor.EnteredDate.ToString("dd/MM/yyyy")
        txtFechaNacimiento.Text = minor.BirthDate.ToString("dd/MM/yyyy")
        txtResidencia.Text = minor.Residency
        txtNivel.Text = minor.Level.Name
        txtGenero.Text = minor.Gender
        txtBeca.Text = minor.HasSchoolarship
        txtMetodoRecomendacion.Text = minor.RecommendationMethod.ToString().Replace("_", " ")
        txtCedulaMenor.Text = minor.MinorID
        txtJornada.Text = minor.WorkingDay.ToString().Replace("_", " ")

        lbPayments.Visible = False
        dgvPayments.Visible = False


        Dim representativeManager As New RepresentativeManager()
        representatives = representativeManager.searchByMinorID(minor.MinorID)

        payments = minor.Payments

        ' Poblate the DataGridView with the representatives
        dgvRepresentatives.ReadOnly = True ' Set the DataGridView to read-only
        dgvRepresentatives.AllowUserToAddRows = False ' Disable the ability to add new rows


        dgvRepresentatives.Columns.Add("Nombre", "Nombre")
        dgvRepresentatives.Columns.Add("Cédula", "Cédula")
        dgvRepresentatives.Columns.Add("Correo", "Correo")
        dgvRepresentatives.Columns.Add("Teléfono", "Teléfono")

        Dim btnDetallesColumn As New DataGridViewButtonColumn()
        btnDetallesColumn.HeaderText = "Detalles"
        btnDetallesColumn.Name = "Detalles"
        btnDetallesColumn.Text = "Detalles"
        btnDetallesColumn.UseColumnTextForButtonValue = True

        If (Globals.current_user.Role = 0) Then

            Dim btnDeleteColumn As New DataGridViewButtonColumn()
            btnDeleteColumn.HeaderText = "Eliminar"
            btnDeleteColumn.Name = "Eliminar"
            btnDeleteColumn.Text = "Eliminar"
            btnDeleteColumn.UseColumnTextForButtonValue = True

            Dim btnEditColumn As New DataGridViewButtonColumn()
            btnEditColumn.HeaderText = "Editar"
            btnEditColumn.Name = "Editar"
            btnEditColumn.Text = "Editar"
            btnEditColumn.UseColumnTextForButtonValue = True

            dgvRepresentatives.Columns.Add(btnDeleteColumn)
            dgvRepresentatives.Columns.Add(btnEditColumn)

            lbPayments.Visible = True
            dgvPayments.Visible = True

            ' Poblate the DataGridView with the payments
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

            For Each payment As MonthlyPayment In payments
                dgvPayments.Rows.Add(payment.PaymentDate, payment.Value, payment.Month, payment.Observation, payment.DepositNumber)
            Next
        Else
            Me.Height = 400
        End If

        dgvRepresentatives.Columns.Add(btnDetallesColumn)

        ' Add the representatives to the DataGridView
        For Each representative As Representative In representatives
            dgvRepresentatives.Rows.Add(representative.Name, representative.RepresentativeID, representative.Mail, representative.Phone)
        Next

    End Sub

    Private Sub dgvRepresentatives_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRepresentatives.CellContentClick
        ' Check if the clicked cell is a button cell and the corresponding column index
        If e.ColumnIndex = dgvRepresentatives.Columns("Detalles").Index AndAlso e.RowIndex >= 0 Then
            ' "Detalles" button clicked
            Dim rowIndex As Integer = e.RowIndex
            Dim representative As Representative = representatives(rowIndex)
            Dim form As New frmRepresentativeDetails(representative)
            form.MdiParent = Me.MdiParent
            form.Show()
        ElseIf e.ColumnIndex = dgvRepresentatives.Columns("Eliminar").Index AndAlso e.RowIndex >= 0 Then
            ' "Eliminar" button clicked
            Dim rowIndex As Integer = e.RowIndex
            Dim representative As Representative = representatives(rowIndex)
            ' Perform delete action using the representative object
            ' Example:
            ' representativeManager.deleteFromDB(representative.RepresentativeID)
            ' Reload the DataGridView data after deletion

        ElseIf e.ColumnIndex = dgvRepresentatives.Columns("Editar").Index AndAlso e.RowIndex >= 0 Then
            ' "Editar" button clicked
            Dim rowIndex As Integer = e.RowIndex
            Dim representative As Representative = representatives(rowIndex)
            Dim form As New frmInsertUpdateRepresentative(representative)
            form.MdiParent = Me.MdiParent
            form.Show()
        End If
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        ExcelUtility.ExportMinorDetailsToExcel(Me)
    End Sub
End Class
