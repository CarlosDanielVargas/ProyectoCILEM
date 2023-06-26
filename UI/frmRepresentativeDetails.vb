Imports BL
Imports DOM

Public Class frmRepresentativeDetails

    Property representative As Representative
    Private minors As List(Of Minor)

    ' Constructor para recibir los datos del representante
    Public Sub New(representative As Representative)
        InitializeComponent()

        ' Asignar los valores recibidos a las propiedades correspondientes
        Me.representative = representative
    End Sub

    Private Sub frmRepresentativeDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load data
        txtGenero.Text = representative.Gender.ToString()
        txtOcupacion.Text = representative.Occupation
        txtEstadoCivil.Text = representative.MaritalStatus.ToString()
        txtTelefono.Text = representative.Phone
        txtLugarTrabajo.Text = representative.WorkPlace
        txtResidencia.Text = representative.Residency
        txtCorreoElectronico.Text = representative.Mail
        txtNombre.Text = representative.Name
        txtCedula.Text = representative.RepresentativeID

        'Load minors
        Dim minorManager As New MinorManager()
        minors = minorManager.searchByRepresentativeID(representative.RepresentativeID)

        ' Add the columns to the DataGridView
        dgvMinors.Columns.Add("Nombre", "Nombre")
        dgvMinors.Columns.Add("Cédula", "Cédula")
        dgvMinors.Columns.Add("Nivel", "Nivel")
        dgvMinors.Columns.Add("Vínculo", "Vínculo")

        ' Add the buttons column to the DataGridView
        ' This columns will contain the "Detalles", "Eliminar" and "Editar" buttons
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

            dgvMinors.Columns.Add(btnDeleteColumn)
            dgvMinors.Columns.Add(btnEditColumn)
        End If

        dgvMinors.Columns.Add(btnDetallesColumn)

        ' Add the minors to the DataGridView
        For Each column As DataGridViewColumn In dgvMinors.Columns
            column.ReadOnly = True ' Set individual columns to read-only
        Next

        ' Refresh the minors list
        refreshMinorList()
    End Sub

    Public Sub refreshMinorList()

        dgvMinors.Rows.Clear()

        ' Add the relationship of the buttons to the Minor object
        For Each minor As Minor In minors
            Dim rowIndex As Integer = dgvMinors.Rows.Add()

            dgvMinors.Rows(rowIndex).Cells("Nombre").Value = minor.Name
            dgvMinors.Rows(rowIndex).Cells("Cédula").Value = minor.MinorID
            dgvMinors.Rows(rowIndex).Cells("Nivel").Value = minor.Level.Name
            dgvMinors.Rows(rowIndex).Cells("Vínculo").Value = minor.RecommendationMethod

        Next
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        ExcelUtility.ExportRepresentativeDetailsToExcel(Me)
    End Sub
End Class
