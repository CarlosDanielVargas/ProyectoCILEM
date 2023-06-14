Imports BL
Imports DOM

Public Class frmNewMinor
    Private selectedRepresentative As Representative
    Private representativeMinors As List(Of RepresentativeMinor)

    Private Sub frmNewMinor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim minor As Minor = New Minor()
        cboxGender.DataSource = [Enum].GetValues(GetType(Minor.GenderEnum))
        cboxGender.SelectedIndex = 0
        cboxSchoolarship.DataSource = [Enum].GetValues(GetType(Minor.HasSchoolarshipEnum))
        cboxSchoolarship.SelectedIndex = 0
        btnAddRepresentativeMinor.Enabled = False
    End Sub

    Private Sub btnSearchRepresentative_Click(sender As Object, e As EventArgs) Handles btnSearchRepresentative.Click
        Dim representativeManager As New RepresentativeManager()
        Dim representatives As List(Of Representative) = representativeManager.searchByName(tbRepresentativeName.Text)
        lboxFoundRepresentants.DataSource = representatives
        lboxFoundRepresentants.DisplayMember = "Name"

        ' Clear the associated representatives list
        lboxAssociatedRepresentatives.Items.Clear()
    End Sub

    Private Sub lboxFoundRepresentants_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lboxFoundRepresentants.SelectedIndexChanged
        If lboxFoundRepresentants.SelectedItem IsNot Nothing Then
            Dim rep As Representative = DirectCast(lboxFoundRepresentants.SelectedItem, Representative)
            tbSelectedRepresentative.Text = rep.Name
            selectedRepresentative = rep
            btnAddRepresentativeMinor.Enabled = True
            cbRelationship.DataSource = [Enum].GetValues(GetType(Representative.RelationshipEnum))
        End If
    End Sub

    Private Sub btnAddRepresentativeMinor_Click(sender As Object, e As EventArgs) Handles btnAddRepresentativeMinor.Click
        If selectedRepresentative IsNot Nothing Then
            Dim minorManager As New MinorManager()
            Dim representativeMinor As RepresentativeMinor = New RepresentativeMinor()
            representativeMinor.MinorID = tbIDCard.Text
            representativeMinor.RepresentativeID = selectedRepresentative.RepresentativeID

            ' Remove the selected representative from the found representatives list
            lboxFoundRepresentants.Items.Remove(selectedRepresentative)

            lboxAssociatedRepresentatives.Items.Add(selectedRepresentative)
            If representativeMinors Is Nothing Then
                representativeMinors = New List(Of RepresentativeMinor)
            End If
            representativeMinors.Add(representativeMinor)
            btnAddRepresentativeMinor.Enabled = False
            tbSelectedRepresentative.Text = ""
            lboxAssociatedRepresentatives.SelectedIndex = -1
            lboxAssociatedRepresentatives.DisplayMember = "Name"
        End If
    End Sub

End Class