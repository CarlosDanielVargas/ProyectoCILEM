Imports DOM
Imports BL
Public Class frmMinorList
    ' This form is used to display a list of minors
    Private minors As List(Of Minor)
    Private levels As List(Of Level)

    ' This event handler is called when the form is loaded
    Private Sub frmMinorList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Load the levels from the database
        Dim levelManager As New LevelManager()
        levels = levelManager.loadAllFromDB()
        cboxLevel.DataSource = levels
        cboxLevel.DisplayMember = "Name"
        cboxLevel.ValueMember = "LevelID"
        cboxLevel.SelectedIndex = 0

        ' Load genders
        cboxGender.DataSource = [Enum].GetValues(GetType(Minor.GenderEnum))
        cboxGender.SelectedIndex = 0


        dgvMinors.ReadOnly = True ' Set the DataGridView to read-only
        dgvMinors.AllowUserToAddRows = False ' Disable the ability to add new rows
        dgvMinors.AllowUserToDeleteRows = False ' Disable the ability to delete rows

        ' Add the columns to the DataGridView
        dgvMinors.Columns.Add("Nombre", "Nombre")
        dgvMinors.Columns.Add("Cédula", "Cédula")
        dgvMinors.Columns.Add("Nivel", "Nivel")

        ' Add the buttons column to the DataGridView
        ' This columns will contain the "Detalles", "Eliminar" and "Editar" buttons
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

        dgvMinors.Columns.Add(btnDetallesColumn)
        dgvMinors.Columns.Add(btnDeleteColumn)
        dgvMinors.Columns.Add(btnEditColumn)

        ' Add the minors to the DataGridView
        For Each column As DataGridViewColumn In dgvMinors.Columns
            column.ReadOnly = True ' Set individual columns to read-only
        Next

        ' Refresh the minors list
        refreshMinorList()

        ' Set message of filter label
        lbCurrentFilter.Text = "Se muestran todos los menores, un total de " & minors.Count & " menor(es)"

    End Sub

    Private Sub dgvMinors_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMinors.CellContentClick
        ' Check if the clicked cell is a button cell and the corresponding column index
        If e.ColumnIndex = dgvMinors.Columns("Detalles").Index AndAlso e.RowIndex >= 0 Then
            ' "Detalles" button clicked
            ' Get the row index of the clicked cell
            Dim rowIndex As Integer = e.RowIndex
            ' Get the Minor object from the list of minors using the row index
            Dim minor As Minor = minors(rowIndex)
            ' Open the form for displaying the minor details using the minor object
            Dim form As New frmMinorDetails(minor)
            form.MdiParent = Me.MdiParent
            form.Show()
        ElseIf e.ColumnIndex = dgvMinors.Columns("Eliminar").Index AndAlso e.RowIndex >= 0 Then
            ' "Eliminar" button clicked
            Dim rowIndex As Integer = e.RowIndex
            Dim minor As Minor = minors(rowIndex)
            ' Perform delete action using the minor object
            Try
                Dim minorManager As New MinorManager()
                minorManager.deleteFromDB(minor)
                MessageBox.Show("Se eliminó el menor", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("No se pudo eliminar el menor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            ' Refresh the minors list
            refreshMinorList()
        ElseIf e.ColumnIndex = dgvMinors.Columns("Editar").Index AndAlso e.RowIndex >= 0 Then
            ' "Editar" button clicked
            ' Get the row index of the clicked cell
            Dim rowIndex As Integer = e.RowIndex
            ' Get the Minor object from the list of minors using the row index
            Dim minor As Minor = minors(rowIndex)
            ' Open the form for editing the minor details using the minor object
            Dim frm As New frmInsertUpdateMinor(minor, Me)
            frm.MdiParent = Me.MdiParent
            frm.Show()
        End If
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Dim filteredMinors As New List(Of Minor)

        Dim IDFilter As String = tbIDCard.Text
        Dim levelFilter As Integer = cboxLevel.SelectedValue
        Dim genderFilter As String = cboxGender.SelectedValue?.ToString()

        ' Filter by ID
        If Not String.IsNullOrEmpty(IDFilter) Then
            filteredMinors = filteredMinors.FindAll(Function(minor) minor.MinorID <> IDFilter)
        End If

        ' Filter by level
        If levelFilter <> 0 Then
            filteredMinors = minors.FindAll(Function(minor) minor.Level.LevelID = levelFilter)
        End If

        ' Filter by gender
        If Not String.IsNullOrEmpty(genderFilter) Then
            filteredMinors = filteredMinors.FindAll(Function(minor) minor.Gender = genderFilter)
        End If

        dgvMinors.Rows.Clear()

        ' Add the relationship of the buttons to the Minor object
        For Each minor As Minor In filteredMinors
            Dim rowIndex As Integer = dgvMinors.Rows.Add()

            dgvMinors.Rows(rowIndex).Cells("Nombre").Value = minor.Name
            dgvMinors.Rows(rowIndex).Cells("Cédula").Value = minor.MinorID
            dgvMinors.Rows(rowIndex).Cells("Nivel").Value = minor.Level.Name
        Next

        ' Add the minors to the DataGridView
        For Each column As DataGridViewColumn In dgvMinors.Columns
            column.ReadOnly = True ' Set individual columns to read-only
        Next

        ' Change the filter message
        Dim filterMessage As String = "Filtrado por: "

        If Not String.IsNullOrEmpty(IDFilter) Then
            filterMessage += "Cédula: " + IDFilter + ", "
        End If

        If levelFilter <> 0 Then
            Dim selectedLevel As Level = levels.FirstOrDefault(Function(l) l.LevelID = levelFilter)
            If selectedLevel IsNot Nothing Then
                filterMessage += "Nivel: " + selectedLevel.Name + ", "
            End If
        End If

        If Not String.IsNullOrEmpty(genderFilter) Then
            filterMessage += "Género: " + genderFilter + ", "
        End If

        If filterMessage.EndsWith(", ") Then
            filterMessage = filterMessage.Substring(0, filterMessage.Length - 2) ' Remove the last comma and space
        End If

        lbCurrentFilter.Text = filterMessage
    End Sub

    Private Sub btnClearFilters_Click(sender As Object, e As EventArgs) Handles btnClearFilters.Click
        ' Clear the filter values and reset the DataGridView

        ' Clear the filter text boxes
        tbIDCard.Text = String.Empty
        cboxLevel.SelectedIndex = -1
        cboxGender.SelectedIndex = -1

        ' Clear the filter message
        lbCurrentFilter.Text = "Se muestran todos los menores, un total de " & minors.Count & " menor(es)"

        ' Refresh the DataGridView to show all minors
        dgvMinors.Rows.Clear()

        For Each minor As Minor In minors
            Dim rowIndex As Integer = dgvMinors.Rows.Add()

            dgvMinors.Rows(rowIndex).Cells("Nombre").Value = minor.Name
            dgvMinors.Rows(rowIndex).Cells("Cédula").Value = minor.MinorID
            dgvMinors.Rows(rowIndex).Cells("Nivel").Value = minor.Level.Name
        Next

        ' Set all columns to read-only
        For Each column As DataGridViewColumn In dgvMinors.Columns
            column.ReadOnly = True
        Next
    End Sub

    Public Sub refreshMinorList()
        ' Load all minors from the database
        Dim minorManager As New MinorManager()
        minors = minorManager.loadAllFromDB()

        dgvMinors.Rows.Clear()

        ' Add the relationship of the buttons to the Minor object
        For Each minor As Minor In minors
            Dim rowIndex As Integer = dgvMinors.Rows.Add()

            dgvMinors.Rows(rowIndex).Cells("Nombre").Value = minor.Name
            dgvMinors.Rows(rowIndex).Cells("Cédula").Value = minor.MinorID
            dgvMinors.Rows(rowIndex).Cells("Nivel").Value = minor.Level.Name
        Next
    End Sub
End Class
