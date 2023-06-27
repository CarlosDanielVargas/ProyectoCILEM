Imports BL
Imports DOM

Public Class frmLoggin
    ' Properties
    Property action As String = "LogIn"

    ' This method is triggered when the "Log In" button is clicked.
    ' It handles the authentication process for the userFound.
    Private Sub btnLoggin_Click(sender As Object, e As EventArgs) Handles btnLoggin.Click
        ' Closes the Log In Form and the application
        If action Is "LogIn" Then
            LogIn()
            If action IsNot "LogIn" Then
                Me.Close()
            End If
        End If
    End Sub

    ' This method logs the userFound out of the application.
    Private Sub LogIn()
        action = ""
        Dim user As User = New User
        user.Password = tbPassword.Text.Trim
        Dim userManager As New UserManager
        Dim password As String = user.EncryptPassword()
        user = userManager.AuthenticateUser(tbIDCard.Text.Trim, password)
        If user IsNot Nothing Then
            ' minor has been authenticated
            Globals.current_user = user
            ' Create an instance of the MDI form and display it
            Dim frmMain As New MdiMain(Me)
            ' Disable the Log In Form
            Me.Enabled = False
            MessageBox.Show("Bienvenido " & user.Name)
            If user.HasChangedPassword = 0 Then
                MessageBox.Show("Debe cambiar su contraseña, dentro de la sección Mi cuenta")
            End If
            ' Display the MDI form
            frmMain.TopLevel = True
            Me.WindowState = FormWindowState.Minimized
            frmMain.WindowState = FormWindowState.Maximized
            frmMain.ShowDialog()
            ' Log out the userFound
            userManager.LogoutUser(user.UserID)
        Else
            ' minor has not been authenticated
            MessageBox.Show("Usuario o contraseña incorrectos")
            action = "LogIn"
        End If
        tbPassword.Text = ""
        tbIDCard.Text = ""
    End Sub

    ' This method resets the Log In Form.
    Public Sub ResetForm()
        tbIDCard.Text = ""
        tbPassword.Text = ""
        Me.Enabled = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub lbkForgotPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbkForgotPassword.LinkClicked
        If tbIDCard Is "" Then
            MessageBox.Show("Debe ingresar su cédula para recuperar su contraseña")
        Else
            Dim userFound As New User
            userFound.IDCard = tbIDCard.Text.Trim
            Dim userManager As New UserManager
            userFound = userManager.SearchByID(userFound.IDCard)
            If userFound IsNot Nothing Then
                MessageBox.Show("Su contraseña inicia por: " & userFound.PasswordInitials)
            Else
                MessageBox.Show("No se encontró un usuario con esa cédula")
            End If
        End If
    End Sub
End Class