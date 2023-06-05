Public Class frmRepresentativeDetails
	' Propiedades para almacenar los datos del niño
	Private Property Genero As String
	Private Property Relacion As String
	Private Property Ocupacion As String
	Private Property EstadoCivil As String
	Private Property Telefono As String
	Private Property LugarTrabajo As String
	Private Property Residencia As String
	Private Property CorreoElectronico As String
	Private Property Nombre As String
	Private Property Cedula As String

	' Constructor para recibir los datos del niño
	Public Sub New(genero As String, relacion As String, ocupacion As String, estadoCivil As String, telefono As String, lugarTrabajo As String, residencia As String, correoElectronico As String, nombre As String, cedula As String)
		InitializeComponent()

		' Asignar los valores recibidos a las propiedades correspondientes
		Me.Genero = genero
		Me.Relacion = relacion
		Me.Ocupacion = ocupacion
		Me.EstadoCivil = estadoCivil
		Me.Telefono = telefono
		Me.LugarTrabajo = lugarTrabajo
		Me.Residencia = residencia
		Me.CorreoElectronico = correoElectronico
		Me.Nombre = nombre
		Me.Cedula = cedula
	End Sub

	Private Sub frmRepresentativeDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		' Mostrar los datos del niño en los controles correspondientes
		txtGenero.Text = Genero
		txtRelacion.Text = Relacion
		txtOcupacion.Text = Ocupacion
		txtEstadoCivil.Text = EstadoCivil
		txtTelefono.Text = Telefono
		txtLugarTrabajo.Text = LugarTrabajo
		txtResidencia.Text = Residencia
		txtCorreoElectronico.Text = CorreoElectronico
		txtNombre.Text = Nombre
		txtCedula.Text = Cedula
	End Sub

End Class
