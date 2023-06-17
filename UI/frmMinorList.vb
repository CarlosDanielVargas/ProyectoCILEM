Imports DOM
Imports BL
Public Class frmMinorList
	' This form is used to display a list of minors
	Private minors As List(Of Minor)

	' This event handler is called when the form is loaded
	Private Sub frmMinorList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		' Load the minors from the database
		Dim minorManager As New MinorManager()
		minors = minorManager.loadAllFromDB()


		dgvMinors.ReadOnly = True ' Set the DataGridView to read-only
		dgvMinors.AllowUserToAddRows = False ' Disable the ability to add new rows

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

		' Add the relationship of the buttons to the Minor object
		For Each minor As Minor In minors
			Dim rowIndex As Integer = dgvMinors.Rows.Add()

			dgvMinors.Rows(rowIndex).Cells("Nombre").Value = minor.Name
			dgvMinors.Rows(rowIndex).Cells("Cédula").Value = minor.MinorID
			dgvMinors.Rows(rowIndex).Cells("Nivel").Value = minor.Level.Name
		Next
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
			' Example:
			' minorManager.deleteFromDB(minor.MinorID)
			' Reload the DataGridView data after deletion

		ElseIf e.ColumnIndex = dgvMinors.Columns("Editar").Index AndAlso e.RowIndex >= 0 Then
			' "Editar" button clicked
			' Get the row index of the clicked cell
			Dim rowIndex As Integer = e.RowIndex
			' Get the Minor object from the list of minors using the row index
			Dim minor As Minor = minors(rowIndex)
			' Open the form for editing the minor details using the minor object
			Dim frm As New frmInsertUpdateMinor(minor)
			frm.MdiParent = Me.MdiParent
			frm.Show()
		End If
	End Sub
End Class
