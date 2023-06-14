Imports DOM
Imports BL

Public Class frmRepresentativeList
	Private Sub frmRepresentativeList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		' Agregar columnas al control ListView
		UserList.Columns.Add("Nombre", 150)
		UserList.Columns.Add("Cédula", 100)
		UserList.Columns.Add("Correo", 150)
		UserList.Columns.Add("Teléfono", 100)
		UserList.Columns.Add("Detalles", 80)

		' Poblar el control ListView con los datos de los encargados legales
		Dim listaRepresentatives As New List(Of Representative)()
		listaRepresentatives.Add(New Representative("John Doe", "123456789", "john.doe@example.com", "555-1234"))
		listaRepresentatives.Add(New Representative("Jane Smith", "987654321", "jane.smith@example.com", "555-5678"))

		For Each representative As Representative In listaRepresentatives
			Dim item As New ListViewItem(representative.Name)
			item.SubItems.Add(representative.RepresentativeID)
			item.SubItems.Add(representative.Mail)
			item.SubItems.Add(representative.Phone)

			' Agregar botón en la columna de "Detalles"
			Dim btnDetalles As New Button()
			btnDetalles.Text = "Detalles"
			btnDetalles.Size = New Size(75, 23)
			btnDetalles.Tag = representative ' Almacenar el objeto Representative en la propiedad Tag del botón
			AddHandler btnDetalles.Click, AddressOf btnDetalles_Click

			Dim subItem As New ListViewItem.ListViewSubItem(item, "")
			subItem.Tag = btnDetalles ' Almacenar el botón en la propiedad Tag del subítem
			item.SubItems.Add(subItem)

			UserList.Items.Add(item)
		Next
	End Sub

	Private Sub btnDetalles_Click(sender As Object, e As EventArgs)
		' Obtener el botón y el objeto Representative asociados al evento Click
		Dim btnDetalles As Button = CType(sender, Button)
		Dim representative As Representative = CType(btnDetalles.Tag, Representative)

		' Mostrar los detalles del encargado legal en una nueva ventana o realizar cualquier otra acción necesaria
		Dim representativeDetails As New frmRepresentativeDetails(representative.RepresentativeID, representative.Name)
		representativeDetails.Show()
	End Sub
End Class