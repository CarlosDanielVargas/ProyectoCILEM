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
        End If

        dgvRepresentatives.Columns.Add(btnDetallesColumn)

        refreshDataGridView() ' Update the DataGridView with all representatives

        For Each column As DataGridViewColumn In dgvRepresentatives.Columns
            column.ReadOnly = True ' Set individual columns to read-only
        Next

        ' Load genders
        Dim genders As Array = [Enum].GetValues(GetType(Minor.GenderEnum))

        ' Create a list to store gender options
        Dim genderOptions As New List(Of String)()

        ' Add "Todos" option to the list
        genderOptions.Add("Todos")

        ' Add enum values to the list as strings
        For Each gender As Minor.GenderEnum In genders
            genderOptions.Add(gender.ToString())
        Next

        ' Set the data source for the combobox
        cboxGender.DataSource = genderOptions
        cboxGender.SelectedIndex = 0

        lbCurrentFilter.Text = "Filtrado por: Ninguno"

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
        Dim nameFilter As String = tbName.Text.Trim()
        Dim IDFilter As String = tbIDCard.Text.Trim()
        Dim genderFilter As String = cboxGender.SelectedValue?.ToString()

        ' Filter by Name
        If Not String.IsNullOrEmpty(nameFilter) Then
            Me.filteredRepresentatives = Me.filteredRepresentatives.FindAll(Function(representative) representative.Name.Contains(nameFilter))
        End If

        ' Filter by ID
        If Not String.IsNullOrEmpty(IDFilter) Then
            Me.filteredRepresentatives = Me.filteredRepresentatives.FindAll(Function(representative) representative.RepresentativeID.Contains(IDFilter))
        End If

        ' Filter by gender
        If Not String.IsNullOrEmpty(genderFilter) AndAlso genderFilter <> "Todos" Then
            Me.filteredRepresentatives = Me.filteredRepresentatives.FindAll(Function(representative) representative.Gender.ToString() = genderFilter)
        End If

        Me.dgvRepresentatives.Rows.Clear()


        ' Add the relationship of the buttons to the representative object
        For Each representative As Representative In filteredRepresentatives
            Dim rowIndex As Integer = dgvRepresentatives.Rows.Add()

            dgvRepresentatives.Rows(rowIndex).Cells("Nombre").Value = representative.Name
            dgvRepresentatives.Rows(rowIndex).Cells("Cédula").Value = representative.RepresentativeID
            dgvRepresentatives.Rows(rowIndex).Cells("Correo").Value = representative.Mail
            dgvRepresentatives.Rows(rowIndex).Cells("Teléfono").Value = representative.Phone
        Next

        ' Add the representative to the DataGridView
        For Each column As DataGridViewColumn In dgvRepresentatives.Columns
            column.ReadOnly = True ' Set individual columns to read-only
        Next

        ' Change the filter message
        Dim filterMessage As String = "Filtrado por: "

        If Not String.IsNullOrEmpty(nameFilter) Then
            filterMessage += "Nombre: " + nameFilter + ", "
        End If

        If Not String.IsNullOrEmpty(IDFilter) Then
            filterMessage += "Cédula: " + IDFilter + ", "
        End If

        If Not String.IsNullOrEmpty(genderFilter) AndAlso genderFilter <> "Todos" Then
            filterMessage += "Género: " + genderFilter + ", "
        End If

        If filterMessage.EndsWith(", ") Then
            filterMessage = filterMessage.Substring(0, filterMessage.Length - 2) ' Remove the last comma and space
        End If

        lbCurrentFilter.Text = filterMessage
    End Sub

    Private Sub btnClearFilters_Click(sender As Object, e As EventArgs) Handles btnClearFilters.Click
        ' Clear filters and show all representatives
        filteredRepresentatives = representatives

        tbIDCard.Text = String.Empty
        cboxGender.SelectedIndex = 0
        tbName.Text = String.Empty


        ' Clear the filter message
        lbCurrentFilter.Text = "Se muestran todos los representantes, un total de " & representatives.Count & " representante(s)"

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

    Private Sub btnExportToExcel_Click(sender As Object, e As EventArgs) Handles btnExportToExcel.Click
         ExcelUtility.ExportDataGridViewToExcel(dgvRepresentatives, "Representantes")
    End Sub
End Class