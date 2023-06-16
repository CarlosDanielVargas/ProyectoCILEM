Imports DOM
Imports BL

Public Class frmRepresentativeList
    Private representatives As List(Of Representative)
    Private Sub frmRepresentativeList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim representativeManager As New RepresentativeManager()
        representatives = representativeManager.loadAllFromDB()

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

        dgvRepresentatives.Columns.Add(btnDetallesColumn)
        dgvRepresentatives.Columns.Add(btnDeleteColumn)
        dgvRepresentatives.Columns.Add(btnEditColumn)

        For Each column As DataGridViewColumn In dgvRepresentatives.Columns
            column.ReadOnly = True ' Set individual columns to read-only
        Next

        For Each representative As Representative In representatives
            Dim rowIndex As Integer = dgvRepresentatives.Rows.Add()

            dgvRepresentatives.Rows(rowIndex).Cells("Nombre").Value = representative.Name
            dgvRepresentatives.Rows(rowIndex).Cells("Cédula").Value = representative.RepresentativeID
            dgvRepresentatives.Rows(rowIndex).Cells("Correo").Value = representative.Mail
            dgvRepresentatives.Rows(rowIndex).Cells("Teléfono").Value = representative.Phone
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
            Dim form As New frmUpdateRepresentative(representative)
            form.MdiParent = Me.MdiParent
            form.Show()
        End If
    End Sub
End Class