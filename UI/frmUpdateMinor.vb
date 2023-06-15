Imports System.Net
Imports BL
Imports DOM

Public Class frmUpdateMinor

    Dim minorManager As New MinorManager
    Dim MinorList As New List(Of Minor)

    Private Sub frmUpdateMinor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MinorList = minorManager.MinorList

        cboId.DataSource = MinorList
        cboId.DisplayMember = "MinorID"
        cboId.ValueMember = "MinorID"

        cboxGender.DataSource = [Enum].GetValues(GetType(Representative.GenderEnum))
        cboxGender.SelectedIndex = 0
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If (cboId.SelectedValue <> "") Then

            Dim newMinor As New Minor

            newMinor.MinorID = cboId.SelectedValue
            newMinor.Name = tbName.Text.Trim
            newMinor.BirthDate = dtPickBirth.Value.Date
            newMinor.EnteredDate = dtPickIn.Value.Date
            newMinor.GraduationDate = dtPickOut.Value.Date
            newMinor.Residency = tbResidency.Text.Trim
            newMinor.Gender = cboxGender.SelectedValue

            Dim rm As New MinorManager
            rm.updateToDB(newMinor)
            Me.Close()

        End If
    End Sub

    Private Sub cboId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboId.SelectedIndexChanged
        If (cboId.SelectedValue <> "") Then

            Dim selectedMinor As New Minor

            selectedMinor = MinorList.Find(Function(r) r.MinorID = cboId.SelectedValue)

            tbName.Text = selectedMinor.Name
            dtPickBirth.Value = selectedMinor.BirthDate
            dtPickIn.Value = selectedMinor.EnteredDate
            dtPickOut.Value = selectedMinor.GraduationDate
            tbResidency.Text = selectedMinor.Residency
            cboxGender.Text = selectedMinor.Gender

        End If
    End Sub
End Class