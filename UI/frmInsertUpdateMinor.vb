﻿Imports BL
Imports DOM

Public Class frmInsertUpdateMinor
    Private selectedRepresentative As Representative
    Private representativeMinors As List(Of RepresentativeMinor)
    Private filteredRepresentatives As List(Of Representative)
    Private representatives As List(Of Representative)
    Private minor As Minor
    Private isNew As Boolean

    Private Sub frmNewMinor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the form controls and data
        Dim levelManager As New LevelManager()
        cboxGender.DataSource = [Enum].GetValues(GetType(Minor.GenderEnum))
        cboxGender.SelectedIndex = 0
        cboxSchoolarship.DataSource = [Enum].GetValues(GetType(Minor.HasSchoolarshipEnum))
        cboxSchoolarship.SelectedIndex = 0
        cbRelationship.DataSource = [Enum].GetValues(GetType(Representative.RelationshipEnum))
        cbRelationship.SelectedIndex = 0
        cboxLevels.DataSource = levelManager.loadAllFromDB()
        cboxLevels.DisplayMember = "Name"
        cboxLevels.ValueMember = "LevelID"

        ' Populate the form with the existing minor data if available
        If minor IsNot Nothing Then
            isNew = False
            cboxLevels.SelectedValue = minor.LevelID
            lboxAssociatedRepresentatives.DataSource = minor.Representatives
            lboxAssociatedRepresentatives.DisplayMember = "IDAndName"
            lboxAssociatedRepresentatives.SelectedIndex = -1
            tbIDCard.Text = minor.MinorID
            tbName.Text = minor.Name
            tbResidency.Text = minor.Residency
            tbRecommendationMethod.Text = minor.RecommendationMethod
            tbCurrentPayment.Text = minor.CurrentPayment
            dtpBirthDate.Value = minor.BirthDate
            dtpEnterDate.Value = minor.EnteredDate
            dtpLeaveDate.Value = minor.GraduationDate
            btnSave.Text = "Actualizar"
            Me.Text = "Actualizar menor"

            ' Set the value of cboxGender to match the minor's gender
            Dim gender As Minor.GenderEnum = [Enum].Parse(GetType(Minor.GenderEnum), minor.Gender)
            cboxGender.SelectedItem = gender

            ' Set the value of cboxSchoolarship to match the minor's schoolarship status
            Dim schoolarship As Minor.HasSchoolarshipEnum = [Enum].Parse(GetType(Minor.HasSchoolarshipEnum), minor.HasSchoolarship)
            cboxSchoolarship.SelectedItem = schoolarship
        End If

        ' Create a new Minor object if none exists
        If minor Is Nothing Then
            minor = New Minor()
            isNew = True
        End If
        btnAddRepresentativeMinor.Enabled = False
    End Sub

    Public Sub New(minor As Minor)
        ' Required method for the designer.
        InitializeComponent()

        Me.minor = minor
    End Sub

    Public Sub New()
        ' Required method for the designer.
        InitializeComponent()
    End Sub

    Private Sub btnSearchRepresentative_Click(sender As Object, e As EventArgs) Handles btnSearchRepresentative.Click
        ' Search for representatives by name
        Dim representativeManager As New RepresentativeManager()
        Dim representatives As List(Of Representative) = representativeManager.searchByName(tbRepresentativeName.Text)

        ' Filter out the representatives already associated with minors
        filteredRepresentatives = If(representativeMinors Is Nothing, representatives, representatives.Where(Function(rep) Not representativeMinors.Any(Function(minor) minor.RepresentativeID = rep.RepresentativeID)).ToList())

        lboxFoundRepresentants.DataSource = Nothing
        lboxFoundRepresentants.Items.Clear()
        lboxFoundRepresentants.DataSource = filteredRepresentatives
        lboxFoundRepresentants.DisplayMember = "IDAndName"
    End Sub

    Private Sub lboxFoundRepresentants_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lboxFoundRepresentants.SelectedIndexChanged
        ' Event handler when an item is selected in the lboxFoundRepresentants ListBox
        If lboxFoundRepresentants.SelectedItem IsNot Nothing Then
            Dim rep As Representative = lboxFoundRepresentants.SelectedItem
            tbSelectedRepresentative.Text = rep.Name
            selectedRepresentative = rep
            btnAddRepresentativeMinor.Enabled = True
            cbRelationship.DataSource = [Enum].GetValues(GetType(Representative.RelationshipEnum))
        End If
    End Sub

    Private Sub btnAddRepresentativeMinor_Click(sender As Object, e As EventArgs) Handles btnAddRepresentativeMinor.Click
        ' Event handler when the Add button for representative-minor association is clicked
        Dim minorManager As New MinorManager()
        Dim representativeMinor As RepresentativeMinor = New RepresentativeMinor()
        representativeMinor.MinorID = tbIDCard.Text
        representativeMinor.RepresentativeID = selectedRepresentative.RepresentativeID
        representativeMinor.Relationship = cbRelationship.SelectedItem.ToString()

        lboxAssociatedRepresentatives.Items.Add(selectedRepresentative)

        ' Add the representative-minor association to the list
        If representativeMinors Is Nothing Then
            representativeMinors = New List(Of RepresentativeMinor)
        End If
        representativeMinors.Add(representativeMinor)

        ' Add the selected representative to the list of representatives
        If representatives Is Nothing Then
            representatives = New List(Of Representative)
        End If
        representatives.Add(selectedRepresentative)

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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Event handler when the Save button is clicked
        Try
            Dim minorManager As New MinorManager()
            Dim minor As Minor = New Minor()

            ' Set the properties of the Minor object based on the form inputs
            minor.Name = tbName.Text
            minor.MinorID = tbIDCard.Text
            minor.BirthDate = dtpBirthDate.Value
            minor.EnteredDate = dtpEnterDate.Value
            minor.GraduationDate = dtpLeaveDate.Value
            minor.HasSchoolarship = cboxSchoolarship.SelectedItem.ToString()
            minor.RecommendationMethod = tbRecommendationMethod.Text
            minor.Residency = tbResidency.Text
            minor.Gender = cboxGender.SelectedItem.ToString()
            minor.CurrentPayment = Double.Parse(tbCurrentPayment.Text)
            minor.RepresentativeMinors = representativeMinors
            minor.Representatives = representatives
            minor.LevelID = cboxLevels.SelectedItem.LevelID

            ' Validate the minor object
            minor.ValidateAll()

            ' Save or update the minor data in the database
            If isNew Then
                minorManager.saveToDB(minor)
                MessageBox.Show(Me.MdiParent, "Se ha creado correctamente el estudiante")
            Else
                minorManager.updateToDB(minor)
                MessageBox.Show(Me.MdiParent, "Se ha actualizado correctamente la información del estudiante")
            End If

            ' Close the form after successful save/update
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub lbName_Click(sender As Object, e As EventArgs) Handles lbName.Click

    End Sub

    Private Sub tbName_TextChanged(sender As Object, e As EventArgs) Handles tbName.TextChanged

    End Sub

    Private Sub lbIDCard_Click(sender As Object, e As EventArgs) Handles lbIDCard.Click

    End Sub

    Private Sub tbIDCard_TextChanged(sender As Object, e As EventArgs) Handles tbIDCard.TextChanged

    End Sub

    Private Sub lbEnterDate_Click(sender As Object, e As EventArgs) Handles lbEnterDate.Click

    End Sub

    Private Sub cboxGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxGender.SelectedIndexChanged

    End Sub

    Private Sub lbGender_Click(sender As Object, e As EventArgs) Handles lbGender.Click

    End Sub

    Private Sub lbSchoolarship_Click(sender As Object, e As EventArgs) Handles lbSchoolarship.Click

    End Sub

    Private Sub tbResidency_TextChanged(sender As Object, e As EventArgs) Handles tbResidency.TextChanged

    End Sub

    Private Sub lbResidency_Click(sender As Object, e As EventArgs) Handles lbResidency.Click

    End Sub

    Private Sub tbCurrentPayment_TextChanged(sender As Object, e As EventArgs) Handles tbCurrentPayment.TextChanged

    End Sub

    Private Sub lbCurrentPayment_Click(sender As Object, e As EventArgs) Handles lbCurrentPayment.Click

    End Sub

    Private Sub lbLeaveDate_Click(sender As Object, e As EventArgs) Handles lbLeaveDate.Click

    End Sub

    Private Sub lbBirthDate_Click(sender As Object, e As EventArgs) Handles lbBirthDate.Click

    End Sub

    Private Sub dtpBirthDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpBirthDate.ValueChanged

    End Sub

    Private Sub dtpEnterDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpEnterDate.ValueChanged

    End Sub

    Private Sub dtpLeaveDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpLeaveDate.ValueChanged

    End Sub

    Private Sub cboxSchoolarship_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxSchoolarship.SelectedIndexChanged

    End Sub

    Private Sub lbRepresentatives_Click(sender As Object, e As EventArgs) Handles lbRepresentatives.Click

    End Sub

    Private Sub tbRepresentativeName_TextChanged(sender As Object, e As EventArgs) Handles tbRepresentativeName.TextChanged

    End Sub

    Private Sub lbRepresentativeName_Click(sender As Object, e As EventArgs) Handles lbRepresentativeName.Click

    End Sub

    Private Sub lbFoundRepresentatives_Click(sender As Object, e As EventArgs) Handles lbFoundRepresentatives.Click

    End Sub

    Private Sub lbSelectedRepresentantText_Click(sender As Object, e As EventArgs) Handles lbSelectedRepresentantText.Click

    End Sub

    Private Sub tbSelectedRepresentative_TextChanged(sender As Object, e As EventArgs) Handles tbSelectedRepresentative.TextChanged

    End Sub

    Private Sub cbRelationship_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRelationship.SelectedIndexChanged

    End Sub

    Private Sub lboxAssociatedRepresentatives_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lboxAssociatedRepresentatives.SelectedIndexChanged

    End Sub

    Private Sub lbAssociatedRepresentatives_Click(sender As Object, e As EventArgs) Handles lbAssociatedRepresentatives.Click

    End Sub

    Private Sub lbRelation_Click(sender As Object, e As EventArgs) Handles lbRelation.Click

    End Sub

    Private Sub tbRecommendationMethod_TextChanged(sender As Object, e As EventArgs) Handles tbRecommendationMethod.TextChanged

    End Sub

    Private Sub lbRecommendationMethod_Click(sender As Object, e As EventArgs) Handles lbRecommendationMethod.Click

    End Sub

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs) Handles BindingSource1.CurrentChanged

    End Sub

    Private Sub BindingSource2_CurrentChanged(sender As Object, e As EventArgs) Handles BindingSource2.CurrentChanged

    End Sub

    Private Sub lbLevel_Click(sender As Object, e As EventArgs) Handles lbLevel.Click

    End Sub

    Private Sub cboxLevels_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxLevels.SelectedIndexChanged

    End Sub
End Class