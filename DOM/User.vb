Imports System.ComponentModel

Public Class User
    Property UserId As Integer
    Property Name As String
    Property Password As String
    Property PasswordConfirm As String
    Property Role As String
    Property IsLogged As Integer
    Property IsActive As Integer
    Property HasChangedPassword As Integer

    Public Sub New()
        UserId = 0
        Name = ""
        Password = ""
        PasswordConfirm = ""
        Role = ""
        IsLogged = 0
        IsActive = 1
        HasChangedPassword = 0
    End Sub

    'Enums
    Public Enum Roles
        Admin
        User
    End Enum

    Public Enum IsLoggedIn
        Sí = 1
        No = 0
    End Enum

    Public Enum IsActived
        Activo = 1
        Desactivado = 0
    End Enum

    Public Enum ChangedPassword
        Sí = 1
        No = 0
    End Enum

    'Validations

    'Validate passwords
    Public Function ValidatePasswords() As Boolean
        If Password = PasswordConfirm Then
            Return True
        Else
            Return False
        End If
    End Function

    'Validate password length
    Public Function ValidatePasswordLength() As Boolean
        If Password.Length >= 8 Then
            Return True
        Else
            Return False
        End If
    End Function

    'Validate password complexity
    Public Function ValidatePasswordComplexity() As Boolean
        Dim regex As New System.Text.RegularExpressions.Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).+$")
        If regex.IsMatch(Password) Then
            Return True
        Else
            Return False
        End If
    End Function

    'Methods

    'Encrypt password
    Public Function EncryptPassword() As String
        Dim sha1Obj As New Security.Cryptography.SHA1CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(Password)
        bytesToHash = sha1Obj.ComputeHash(bytesToHash)
        Dim strResult As String = ""
        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next
        Return strResult
    End Function

    'Validate all and return message with errors
    Public Function ValidateAllChangePassword() As String
        Dim message As String = ""
        If Not ValidatePasswords() Then
            message += "Las contraseñas no coinciden. "
        End If
        If Not ValidatePasswordLength() Then
            message += "La contraseña debe tener al menos 8 caracteres. "
        End If
        If Not ValidatePasswordComplexity() Then
            message += "La contraseña debe tener al menos una letra mayúscula, una minúscula, un número y un caracter especial. "
        End If
        Return message
    End Function

    'Generate first random password
    Public Function GenerateRandomPassword() As String
        Dim chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789.,"
        Dim random = New Random()
        Dim result = New String(Enumerable.Repeat(chars, 8).[Select](Function(s) s(random.[Next](s.Length))).ToArray())
        Return result
    End Function

End Class
