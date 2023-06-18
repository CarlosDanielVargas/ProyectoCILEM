Imports DOM
Imports BL

Public Class frmRepresentativeList
    Private representatives As List(Of Representative)
    Private filteredRepresentatives As List(Of Representative)

    Private Sub frmRepresentativeList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvRepresentatives.ReadOnly = True ' Set the DataGridView to read-only
        dgvRepresentatives.AllowUserToAddRows = False ' Disable the ability to add new rows
        dgvRepresentatives.AllowUserToDeleteRows = False ' Disable the ability to delete rows

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

        refreshDataGridView() ' Update the DataGridView with all representatives

        For Each column As DataGridViewColumn In dgvRepresentatives.Columns
            column.ReadOnly = True ' Set individual columns to read-only
        Next

        cboxGender.DataSource = [Enum].GetValues(GetType(Representative.GenderEnum))
        cboxGender.SelectedIndex = 0

        cboxMaritalStatus.DataSource = [Enum].GetValues(GetType(Representative.MaritalStatusEnum))
        cboxMaritalStatus.SelectedIndex = 0

        refreshDataGridView() ' Update the DataGridView with all representatives
    End Sub

    Private Sub dgvRepresentatives_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRepresentatives.CellContentClick
        ' Check if the clicked cell is a button cell and the corresponding column index
        If e.ColumnIndex = dgvRepresentatives.Columns("Detalles").Index AndAlso e.RowIndex >= 0 Then
            ' "Detalles" button clicked
            Dim rowIndex As Integer = e.RowIndex
            Dim representative As Representative = filteredRepresentatives(rowIndex)
            Dim form As New frmRepresentativeDetails(representative)
            form.MdiParent = Me.MdiParent
            form.Show()
        ElseIf e.ColumnIndex = dgvRepresentatives.Columns("Eliminar").Index AndAlso e.RowIndex >= 0 Then
            ' "Eliminar" button clicked
            Dim rowIndex As Integer = e.RowIndex
            Dim representative As Representative = filteredRepresentatives(rowIndex)
            ' Perform delete action using the representative object
            Dim representativeManager As New RepresentativeManager()
            Try
                representativeManager.deleteFromDB(representative)
                MessageBox.Show("Representante eliminado exitosamente", "Representante eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("No se pudo eliminar el representante", "Error al eliminar representante", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            representatives = representativeManager.loadAllFromDB()
            filteredRepresentatives = representatives ' Initialize the filtered list with all representatives
            refreshDataGridView() ' Update the DataGridView with the filtered representatives


        ElseIf e.ColumnIndex = dgvRepresentatives.Columns("Editar").Index AndAlso e.RowIndex >= 0 Then
            ' "Editar" button clicked
            Dim rowIndex As Integer = e.RowIndex
            Dim representative As Representative = filteredRepresentatives(rowIndex)
            Dim form As New frmInsertUpdateRepresentative(representative, Me)
            form.MdiParent = Me.MdiParent
            form.Show()
        End If
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        ' Filters
        Dim IDCard As String = tbIDCard.Text
        Dim gender As String = If(cboxGender.SelectedItem IsNot Nothing, cboxGender.SelectedItem.ToString(), "")
        Dim maritalStatus As String = If(cboxMaritalStatus.SelectedItem IsNot Nothing, cboxMaritalStatus.SelectedItem.ToString(), "")

        ' Apply filters
        filteredRepresentatives = representatives.Where(Function(r) r.RepresentativeID <> IDCard AndAlso r.Gender = gender AndAlso r.MaritalStatus = maritalStatus).ToList()

        refreshDataGridView() ' Update the DataGridView with the filtered representatives
    End Sub

    Private Sub btnClearFilters_Click(sender As Object, e As EventArgs) Handles btnClearFilters.Click
        ' Clear filters and show all representatives
        filteredRepresentatives = representatives

        tbIDCard.Text = String.Empty
        cboxGender.SelectedIndex = 0
        cboxMaritalStatus.SelectedIndex = 0

        refreshDataGridView() ' Update the DataGridView with all representatives
    End Sub

    Public Sub refreshDataGridView()
        Dim representativeManager As New RepresentativeManager()
        representatives = representativeManager.loadAllFromDB()
        filteredRepresentatives = representatives ' Initialize the filtered list with all representatives
        dgvRepresentatives.Rows.Clear() ' Clear existing rows

        For Each representative As Representative In filteredRepresentatives
            Dim rowIndex As Integer = dgvRepresentatives.Rows.Add()

            dgvRepresentatives.Rows(rowIndex).Cells("Nombre").Value = representative.Name
            dgvRepresentatives.Rows(rowIndex).Cells("Cédula").Value = representative.RepresentativeID
            dgvRepresentatives.Rows(rowIndex).Cells("Correo").Value = representative.Mail
            dgvRepresentatives.Rows(rowIndex).Cells("Teléfono").Value = representative.Phone
        Next
    End Sub
End Class