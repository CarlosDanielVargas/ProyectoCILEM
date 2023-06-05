Imports DOM
Imports BL
Public Class frmMinorList
	Private Sub frmMinorList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		' Agregar columnas al control ListView
		UserList.Columns.Add("Nombre", 150)
		UserList.Columns.Add("Cédula", 100)
		UserList.Columns.Add("Detalles", 80)

		' Poblar el control ListView con los datos de los usuarios
		Dim listaUsuarios As New List(Of Minor)()
		listaUsuarios.Add(New Minor("Juan Pérez", "209340373"))
		listaUsuarios.Add(New Minor("María Gómez", "203890312"))

		For Each usuario As Minor In listaUsuarios
			Dim item As New ListViewItem(usuario.Name)
			item.SubItems.Add(usuario.MinorID)

			' Agregar botón en la columna de "Detalles"
			Dim btnDetalles As New Button()
			btnDetalles.Text = "Detalles"
			btnDetalles.Size = New Size(75, 23)
			btnDetalles.Tag = usuario ' Almacenar el objeto Usuario en la propiedad Tag del botón
			AddHandler btnDetalles.Click, AddressOf btnDetalles_Click

			Dim subItem As New ListViewItem.ListViewSubItem(item, "")
			subItem.Tag = btnDetalles ' Almacenar el botón en la propiedad Tag del subítem
			item.SubItems.Add(subItem)

			UserList.Items.Add(item)
		Next
	End Sub

	Private Sub btnDetalles_Click(sender As Object, e As EventArgs)
		' Obtener el botón y el objeto Usuario asociados al evento Click
		Dim btnDetalles As Button = CType(sender, Button)
		Dim usuario As Minor = CType(btnDetalles.Tag, Minor)

		' Mostrar los detalles del usuario en una nueva ventana o realizar cualquier otra acción necesaria
		Dim minorDetails As New frmMinorDetails(usuario.MinorID, usuario.Name)
		minorDetails.Show()
	End Sub

End Class
