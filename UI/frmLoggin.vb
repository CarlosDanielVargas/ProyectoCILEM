Imports BL
Imports DOM

Public Class frmLoggin
    ' This method is triggered when the "Log In" button is clicked.
    ' It handles the authentication process for the user.
    Private Sub btnLoggin_Click(sender As Object, e As EventArgs) Handles btnLoggin.Click
        Dim user As User = New User
        user.Password = tbPassword.Text.Trim
        Dim userManager As New UserManager
        Dim password As String = user.EncryptPassword()
        user = userManager.AuthenticateUser(tbIDCard.Text.Trim, password)
        If user IsNot Nothing Then
            ' User has been authenticated
            Globals.current_user = user
            ' Create an instance of the MDI form and display it
            Dim frmMain As New MdiMain
            ' Disable the Log In Form
            Me.Enabled = False
            MessageBox.Show("Bienvenido " & user.Name)
            If user.HasChangedPassword = 0 Then
                MessageBox.Show("Debe cambiar su contraseña, dentro de la sección Mi cuenta")
            End If
            ' Display the MDI form
            frmMain.TopLevel = True
            Me.WindowState = FormWindowState.Minimized
            frmMain.ShowDialog()
            ' Log out the user
            userManager.LogoutUser(user.UserID)
            ' Closes the Log In Form and the application
            Me.Close()
        Else
            ' User has not been authenticated
            MessageBox.Show("Usuario o contraseña incorrectos")
        End If
    End Sub
End Class