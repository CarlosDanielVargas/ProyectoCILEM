Imports BL
Imports DOM

Public Class frmNewMinor
    Private selectedRepresentative As Representative
    Private representativeMinors As List(Of RepresentativeMinor)
    Private filteredRepresentatives As List(Of Representative)

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

        ' Filter out the representatives already associated with minors
        filteredRepresentatives = If(representativeMinors Is Nothing, representatives, representatives.Where(Function(rep) Not representativeMinors.Any(Function(minor) minor.RepresentativeID = rep.RepresentativeID)).ToList())

        lboxFoundRepresentants.DataSource = Nothing
        lboxFoundRepresentants.Items.Clear()
        lboxFoundRepresentants.DataSource = filteredRepresentatives
        lboxFoundRepresentants.DisplayMember = "IDAndName" ' Set the DisplayMember property to IDAndName
    End Sub

    Private Sub lboxFoundRepresentants_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lboxFoundRepresentants.SelectedIndexChanged
        If lboxFoundRepresentants.SelectedItem IsNot Nothing Then
            Dim rep As Representative = lboxFoundRepresentants.SelectedItem
            tbSelectedRepresentative.Text = rep.Name
            selectedRepresentative = rep
            btnAddRepresentativeMinor.Enabled = True
            cbRelationship.DataSource = [Enum].GetValues(GetType(Representative.RelationshipEnum))
        End If
    End Sub

    Private Sub btnAddRepresentativeMinor_Click(sender As Object, e As EventArgs) Handles btnAddRepresentativeMinor.Click
        Dim minorManager As New MinorManager()
        Dim representativeMinor As RepresentativeMinor = New RepresentativeMinor()
        representativeMinor.MinorID = tbIDCard.Text
        representativeMinor.RepresentativeID = selectedRepresentative.RepresentativeID

        lboxAssociatedRepresentatives.Items.Add(selectedRepresentative)

        If representativeMinors Is Nothing Then
            representativeMinors = New List(Of RepresentativeMinor)
        End If
        representativeMinors.Add(representativeMinor)

        ' Remove the selected representative from the filtered list
        filteredRepresentatives.Remove(selectedRepresentative)
        lboxFoundRepresentants.DataSource = Nothing
        lboxFoundRepresentants.Items.Clear()
        lboxFoundRepresentants.DataSource = filteredRepresentatives
        lboxFoundRepresentants.DisplayMember = "IDandName"

        btnAddRepresentativeMinor.Enabled = False
        tbSelectedRepresentative.Text = ""
        lboxAssociatedRepresentatives.SelectedIndex = -1
        lboxAssociatedRepresentatives.DisplayMember = "IDandName"
    End Sub

End Class