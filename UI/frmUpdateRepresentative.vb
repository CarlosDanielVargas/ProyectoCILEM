Imports BL
Imports DOM

Public Class frmUpdateRepresentative

    Private Property representative As Representative

    ' Constructor para recibir los datos del representante
    Public Sub New(representative As Representative)
        InitializeComponent()

        ' Asignar los valores recibidos a las propiedades correspondientes
        Me.representative = representative
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Dim newRepresentative As New Representative

            newRepresentative.RepresentativeID = tbIDCard.Text.Trim
            newRepresentative.Name = tbName.Text.Trim
            newRepresentative.Phone = tbPhone.Text.Trim
            newRepresentative.Mail = tbMail.Text.Trim
            newRepresentative.MaritalStatus = cboxMaritalStatus.SelectedValue
            newRepresentative.Occupation = tbOccupation.Text.Trim
            newRepresentative.Residency = tbResidency.Text.Trim
            newRepresentative.WorkPlace = tbWorkPlace.Text.Trim
            newRepresentative.Gender = cboxGender.SelectedValue
            newRepresentative.ValidateAll()
            Dim rm As New RepresentativeManager
            rm.updateToDB(newRepresentative)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub frmUpdateRepresentative_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim representativeManager As New RepresentativeManager
        representative = representativeManager.searchByID(representative.RepresentativeID)

        tbIDCard.Text = representative.RepresentativeID
        tbName.Text = representative.Name
        tbPhone.Text = representative.Phone
        tbMail.Text = representative.Mail
        cboxGender.DataSource = [Enum].GetValues(GetType(Representative.GenderEnum))
        cboxGender.SelectedIndex = 0
        cboxMaritalStatus.DataSource = [Enum].GetValues(GetType(Representative.MaritalStatusEnum))
        cboxMaritalStatus.SelectedIndex = 0
        tbOccupation.Text = representative.Occupation
        tbResidency.Text = representative.Residency
        tbWorkPlace.Text = representative.WorkPlace




    End Sub
End Class