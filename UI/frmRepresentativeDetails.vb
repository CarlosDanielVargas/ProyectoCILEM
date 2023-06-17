Imports BL
Imports DOM

Public Class frmRepresentativeDetails

    Private Property representative As Representative

    ' Constructor para recibir los datos del representante
    Public Sub New(representative As Representative)
        InitializeComponent()

        ' Asignar los valores recibidos a las propiedades correspondientes
        Me.representative = representative
    End Sub

    Private Sub frmRepresentativeDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load data
        txtGenero.Text = representative.Gender.ToString()
        txtOcupacion.Text = representative.Occupation
        txtEstadoCivil.Text = representative.MaritalStatus.ToString()
        txtTelefono.Text = representative.Phone
        txtLugarTrabajo.Text = representative.WorkPlace
        txtResidencia.Text = representative.Residency
        txtCorreoElectronico.Text = representative.Mail
        txtNombre.Text = representative.Name
        txtCedula.Text = representative.RepresentativeID

        'Load minors
        Dim minorManager As New MinorManager()
        Dim minors As List(Of Minor) = minorManager.searchByRepresentativeID(representative.RepresentativeID)
        lboxMinors.DataSource = minors
        lboxMinors.DisplayMember = "IdAndNameAndRelationship"
        lboxMinors.SelectedIndex = -1
    End Sub
End Class
