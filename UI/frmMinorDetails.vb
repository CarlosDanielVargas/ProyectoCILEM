Public Class frmMinorDetails
	' Propiedades para almacenar los datos del niño y el encargado legal
	Private Property Genero As String
	Private Property FechaEgreso As DateTime
	Private Property FechaIngreso As DateTime
	Private Property CedulaMenor As String
	Private Property NombreCompleto As String
	Private Property FechaNacimiento As DateTime
	Private Property Residencia As String
	Private Property EncargadoLegal As String

	' Constructor para recibir los datos del niño y el encargado legal
	Public Sub New(genero As String, fechaEgreso As DateTime, fechaIngreso As DateTime, cedulaMenor As String, nombreCompleto As String, fechaNacimiento As DateTime, residencia As String, encargadoLegal As String)
		InitializeComponent()

		' Asignar los valores recibidos a las propiedades correspondientes
		Me.Genero = genero
		Me.FechaEgreso = fechaEgreso
		Me.FechaIngreso = fechaIngreso
		Me.CedulaMenor = cedulaMenor
		Me.NombreCompleto = nombreCompleto
		Me.FechaNacimiento = fechaNacimiento
		Me.Residencia = residencia
		Me.EncargadoLegal = encargadoLegal
	End Sub

	Private Sub frmMinorDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		' Mostrar los datos del niño en los controles correspondientes
		txtNombreCompleto.Text = Genero
		txtFechaEgreso.Text = FechaEgreso.ToString("dd/MM/yyyy")
		txtFechaIngreso.Text = FechaIngreso.ToString("dd/MM/yyyy")
		txtCedulaMenor.Text = CedulaMenor
		txtNombreCompleto.Text = NombreCompleto
		txtFechaNacimiento.Text = FechaNacimiento.ToString("dd/MM/yyyy")
		txtResidencia.Text = Residencia
		txtEncargadoLegal.Text = EncargadoLegal
	End Sub
End Class
