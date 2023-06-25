Imports BL
Imports DOM

Public Class frmLoggin
    Private Sub btnLoggin_Click(sender As Object, e As EventArgs) Handles btnLoggin.Click
        Dim user As User = New User
        user.Password = tbPassword.Text.Trim
        Dim userManager As New UserManager
        Dim password As String = user.EncryptPassword()
        user = userManager.AuthenticateUser(tbIDCard.Text.Trim, password)
        If user IsNot Nothing Then
            Globals.current_user = user
            Dim frmMain As New MdiMain
            Me.Enabled = False
            MessageBox.Show("Bienvenido " & user.Name)
            If user.HasChangedPassword = 0 Then
                MessageBox.Show("Debe cambiar su contraseña, dentro de la sección Mi cuenta")
            End If
            frmMain.TopMost = True ' Mostrar por encima de las demás ventanas
            Me.WindowState = FormWindowState.Minimized
            frmMain.ShowDialog()
            userManager.LogoutUser(user.UserID)
            Me.Close()
        Else
            MessageBox.Show("Usuario o contraseña incorrectos")
        End If
    End Sub

    Private Sub frmLoggin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
