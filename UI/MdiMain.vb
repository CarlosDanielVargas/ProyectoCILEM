Imports System.Windows.Forms
Imports DOM

Public Class MdiMain

    Private Sub menuItemShowStudents_Click(sender As Object, e As EventArgs) Handles menuItemShowStudents.Click
        Dim form As New frmMinorList
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub menuItemAddRepresentative_Click(sender As Object, e As EventArgs) Handles menuItemAddRepresentative.Click
        Dim form As New frmInsertUpdateRepresentative
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub menuItemManageLevels_Click(sender As Object, e As EventArgs) Handles menuItemManageLevels.Click
        Dim form As New frmManageLevels
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub menuItemShowRepresentatives_Click(sender As Object, e As EventArgs) Handles menuItemShowRepresentatives.Click
        Dim form As New frmRepresentativeList
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub menuItemAddMinor_Click(sender As Object, e As EventArgs) Handles menuItemAddMinor.Click
        Dim form As New frmInsertUpdateMinor
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub menuItemAddUser_Click(sender As Object, e As EventArgs) Handles menuItemAddUser.Click
        Dim form As New frmInsertUpdateUser
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub menuItemShowUsers(sender As Object, e As EventArgs) Handles menuItemListUsers.Click
        Dim form As New frmUserList
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub MdiMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Globals.current_user.Role = 1) Then
            NivelesToolStripMenuItem.Visible = False
            menuItemAddUser.Visible = False
            menuItemAddUser.Visible = False
            menuItemAddMinor.Visible = False
            menuItemAddRepresentative.Visible = False
        Else
            NivelesToolStripMenuItem.Visible = True
            menuItemAddUser.Visible = True
            menuItemAddUser.Visible = True
            menuItemAddMinor.Visible = True
            menuItemAddRepresentative.Visible = True
        End If
    End Sub

    Private Sub menuItemMyAccount_Click(sender As Object, e As EventArgs) Handles menuItemMyAccount.Click
        Dim user As User = Globals.current_user
        Dim form As New frmInsertUpdateUser(user)
        form.MdiParent = Me
        form.Show()
    End Sub
End Class
