Imports System.Windows.Forms
Imports DOM

Public Class MdiMain
    Property parent As frmLoggin

    ' Constructor
    Public Sub New(parent As frmLoggin)
        InitializeComponent()
        Me.parent = parent
    End Sub

    ' This method is triggered when the "Show Students" menu item is clicked.
    ' It creates an instance of frmMinorList and displays it as a child window within this MDI form.
    Private Sub menuItemShowStudents_Click(sender As Object, e As EventArgs) Handles menuItemShowStudents.Click
        Dim form As New frmMinorList
        form.MdiParent = Me
        form.Show()
    End Sub

    ' This method is triggered when the "Add Representative" menu item is clicked.
    ' It creates an instance of frmInsertUpdateRepresentative and displays it as a child window within this MDI form.
    Private Sub menuItemAddRepresentative_Click(sender As Object, e As EventArgs) Handles menuItemAddRepresentative.Click
        Dim form As New frmInsertUpdateRepresentative
        form.MdiParent = Me
        form.Show()
    End Sub

    ' This method is triggered when the "Manage Levels" menu item is clicked.
    ' It creates an instance of frmManageLevels and displays it as a child window within this MDI form.
    Private Sub menuItemManageLevels_Click(sender As Object, e As EventArgs) Handles menuItemManageLevels.Click
        Dim form As New frmManageLevels
        form.MdiParent = Me
        form.Show()
    End Sub

    ' This method is triggered when the "Show Representatives" menu item is clicked.
    ' It creates an instance of frmRepresentativeList and displays it as a child window within this MDI form.
    Private Sub menuItemShowRepresentatives_Click(sender As Object, e As EventArgs) Handles menuItemShowRepresentatives.Click
        Dim form As New frmRepresentativeList
        form.MdiParent = Me
        form.Show()
    End Sub

    ' This method is triggered when the "Add Minor" menu item is clicked.
    ' It creates an instance of frmInsertUpdateMinor and displays it as a child window within this MDI form.
    Private Sub menuItemAddMinor_Click(sender As Object, e As EventArgs) Handles menuItemAddMinor.Click
        Dim form As New frmInsertUpdateMinor
        form.MdiParent = Me
        form.Size = New Size(1500, 500)
        form.Show()
    End Sub

    ' This method is triggered when the "Add minor" menu item is clicked.
    ' It creates an instance of frmInsertUpdateUser and displays it as a child window within this MDI form.
    Private Sub menuItemAddUser_Click(sender As Object, e As EventArgs) Handles menuItemAddUser.Click
        Dim form As New frmInsertUpdateUser
        form.MdiParent = Me
        form.Show()
    End Sub

    ' This method is triggered when the "List Users" menu item is clicked.
    ' It creates an instance of frmUserList and displays it as a child window within this MDI form.
    Private Sub menuItemShowUsers(sender As Object, e As EventArgs) Handles menuItemListUsers.Click
        Dim form As New frmUserList
        form.MdiParent = Me
        form.Show()
    End Sub

    ' This method is triggered when the MdiMain form is loaded.
    ' It sets the window state to maximized and brings it to the front.
    ' It also controls the visibility of menu items based on the current user's role.
    Private Sub MdiMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.BringToFront()

        If (Globals.current_user.Role = 1) Then
            NivelesToolStripMenuItem.Visible = False
            menuItemAddUser.Visible = False
            menuItemAddUser.Visible = False
            menuItemAddMinor.Visible = False
            menuItemAddRepresentative.Visible = False
            menuItemListUsers.Visible = False
            UsuariosToolStripMenuItem.Visible = False

        Else
            NivelesToolStripMenuItem.Visible = True
            menuItemAddUser.Visible = True
            menuItemAddUser.Visible = True
            menuItemAddMinor.Visible = True
            menuItemAddRepresentative.Visible = True
        End If
    End Sub

    ' This method is triggered when the "My Account" menu item is clicked.
    ' It creates an instance of frmInsertUpdateUser using the current user's information and displays it as a child window within this MDI form.
    Private Sub menuItemMyAccount_Click(sender As Object, e As EventArgs) Handles menuItemMyAccount.Click
        Dim user As User = Globals.current_user
        Dim form As New frmInsertUpdateUser(user)
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        parent.action = "LogIn"
        parent.ResetForm()
        Me.Close()
    End Sub
End Class