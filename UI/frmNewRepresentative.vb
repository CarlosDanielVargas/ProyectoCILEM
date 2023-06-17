Imports DOM
Imports BL
Public Class frmNewRepresentative
    Private Sub frmNewRepresentative_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rep As Representative = New Representative()
        cboxGender.DataSource = [Enum].GetValues(GetType(Representative.GenderEnum))
        cboxGender.SelectedIndex = 0
        cboxMaritalStatus.DataSource = [Enum].GetValues(GetType(Representative.MaritalStatusEnum))
        cboxMaritalStatus.SelectedIndex = 0
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim repManager As New RepresentativeManager()
            Dim rep As Representative = New Representative()
            rep.Name = tbName.Text
            rep.Mail = tbMail.Text
            rep.Phone = tbPhone.Text
            rep.MaritalStatus = cboxMaritalStatus.SelectedItem.ToString()
            rep.RepresentativeID = tbIDCard.Text
            rep.WorkPlace = tbWorkPlace.Text
            rep.Occupation = tbOccupation.Text
            rep.Gender = cboxGender.SelectedItem.ToString()
            rep.Residency = tbResidency.Text
            rep.ValidateAll()
            repManager.saveToDB(rep)
            MessageBox.Show("Representante guardado con éxito")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub
End Class