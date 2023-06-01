Imports System.Windows.Forms

Public Class MdiMain

    Private Sub menuItemAddMinor_Click(sender As Object, e As EventArgs) Handles menuItemAddMinor.Click
        Dim form As New frmNewMinor
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub menuItemAddRepresentative_Click(sender As Object, e As EventArgs) Handles menuItemAddRepresentative.Click
        Dim form As New frmNewRepresentative
        form.MdiParent = Me
        form.Show()
    End Sub
End Class
