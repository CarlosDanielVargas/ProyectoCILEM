Imports BL
Imports DOM

Public Class frmUpdateRepresentative

    Dim representativeManager As New RepresentativeManager
    Dim RepresentativeList As New List(Of Representative)

    Private Sub cboProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboId.SelectedIndexChanged

        If (cboId.SelectedValue <> "") Then

            Dim selectedRepresentative As New Representative

            selectedRepresentative = RepresentativeList.Find(Function(r) r.RepresentativeID = cboId.SelectedValue)

            tbName.Text = selectedRepresentative.Name
            tbPhone.Text = selectedRepresentative.Phone
            tbMail.Text = selectedRepresentative.Mail
            cboxMaritalStatus.Text = selectedRepresentative.MaritalStatus
            tbOccupation.Text = selectedRepresentative.Occupation
            tbResidency.Text = selectedRepresentative.Residency
            tbWorkPlace.Text = selectedRepresentative.WorkPlace
            cboxGender.Text = selectedRepresentative.Gender

        End If
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If (cboId.SelectedValue <> "") Then

            Dim newRepresentative As New Representative

            newRepresentative.RepresentativeID = cboId.SelectedValue
            newRepresentative.Name = tbName.Text.Trim
            newRepresentative.Phone = tbPhone.Text.Trim
            newRepresentative.Mail = tbMail.Text.Trim
            newRepresentative.MaritalStatus = cboxMaritalStatus.SelectedValue
            newRepresentative.Occupation = tbOccupation.Text.Trim
            newRepresentative.Residency = tbResidency.Text.Trim
            newRepresentative.WorkPlace = tbWorkPlace.Text.Trim
            newRepresentative.Gender = cboxGender.SelectedValue

            Dim rm As New RepresentativeManager
            rm.updateToDB(newRepresentative)
            Me.Close()

        End If

    End Sub

    Private Sub frmUpdateRepresentative_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RepresentativeList = representativeManager.RepresentativeList

        cboId.DataSource = RepresentativeList
        cboId.DisplayMember = "RepresentativeID"
        cboId.ValueMember = "RepresentativeID"

        cboxGender.DataSource = [Enum].GetValues(GetType(Representative.GenderEnum))
        cboxGender.SelectedIndex = 0
        cboxMaritalStatus.DataSource = [Enum].GetValues(GetType(Representative.MaritalStatusEnum))
        cboxMaritalStatus.SelectedIndex = 0

    End Sub
End Class