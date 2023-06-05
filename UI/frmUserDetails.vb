Public Class frmUserDetails
	' Propiedades para almacenar los datos del usuario
	Private Property Contrasena As String
	Private Property Nombre As String
	Private Property Correo As String
	Private Property Rol As String
	Private Property Cedula As String

	' Constructor para recibir los datos del usuario
	Public Sub New(nombre As String, correo As String, rol As String, cedula As String)
		InitializeComponent()

		' Asignar los valores recibidos a las propiedades correspondientes
		Me.Nombre = nombre
		Me.Correo = correo
		Me.Rol = rol
		Me.Cedula = cedula
	End Sub

	Private Sub frmUserDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		' Mostrar los datos del usuario en los controles correspondientes
		txtNombre.Text = Nombre
		txtCorreo.Text = Correo
		txtRol.Text = Rol
		txtCedula.Text = Cedula
	End Sub

	Private Sub lbNombreCompleto_Click(sender As Object, e As EventArgs) Handles lbNombreCompleto.Click

	End Sub
End Class
