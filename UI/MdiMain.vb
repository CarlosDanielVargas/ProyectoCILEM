Imports System.Windows.Forms

Public Class MdiMain

    Private Sub menuItemAddMinor_Click(sender As Object, e As EventArgs) Handles menuItemAddMinor.Click
        Dim form As New frmNewMinor
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub menuItemShowStudents_Click(sender As Object, e As EventArgs) Handles menuItemShowStudents.Click
        Dim form As New frmMinorList
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub menuItemAddRepresentative_Click(sender As Object, e As EventArgs) Handles menuItemAddRepresentative.Click
        Dim form As New frmNewRepresentative
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub updateRepresentative_Click(sender As Object, e As EventArgs) Handles updateRepresentative.Click
        Dim form As New frmUpdateRepresentative
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub AgregarNivelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarNivelToolStripMenuItem.Click
        Dim form As New frmNewLevel
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub menuItemShowRepresentatives_Click(sender As Object, e As EventArgs) Handles menuItemShowRepresentatives.Click
        Dim form As New frmRepresentativeList
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub menuItemShowStudents_Click(sender As Object, e As EventArgs) Handles menuItemShowStudents.Click
        Dim form As New frmMinorList
        form.MdiParent = Me
        form.Show()
    End Sub
End Class
