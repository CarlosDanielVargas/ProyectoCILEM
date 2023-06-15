Imports BL
Imports DOM

Public Class frmMinorDetails
    Private minor As Minor


    ' Constructor para recibir los datos del niño y el encargado legal
    Public Sub New(minor As Minor)
        InitializeComponent()

        ' Asignar los valores recibidos a las propiedades correspondientes
        Me.minor = minor
    End Sub

    Private Sub frmMinorDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mostrar los datos del niño en los controles correspondientes
        txtNombreCompleto.Text = minor.Name
        txtFechaEgreso.Text = minor.GraduationDate.ToString("dd/MM/yyyy")
        txtFechaIngreso.Text = minor.EnteredDate.ToString("dd/MM/yyyy")
        txtFechaNacimiento.Text = minor.BirthDate.ToString("dd/MM/yyyy")
        txtResidencia.Text = minor.Residency
        txtNivel.Text = minor.Level.Name
        txtGenero.Text = minor.Gender
        txtBeca.Text = minor.HasSchoolarship
        txtPago.Text = minor.CurrentPayment
        txtCedulaMenor.Text = minor.MinorID

        ' Mostrar los datos del encargado legal en los controles correspondientes
        Dim representativeManager As New RepresentativeManager()
        Dim representatives As List(Of Representative) = representativeManager.searchByMinorID(minor.MinorID)
        lboxRepresentatives.DataSource = representatives
        lboxRepresentatives.DisplayMember = "IDAndNameAndRelationship"
        lboxRepresentatives.SelectedIndex = -1
    End Sub

End Class
