Imports System.ComponentModel

Public Class User
    Property UserID As Integer
    Property Name As String
    Property Password As String
    Property PasswordConfirm As String
    Property Role As Integer
    Property IsLogged As Integer
    Property IsActive As Integer
    Property HasChangedPassword As Integer
    Property IDCard As String
    Property PasswordInitials As String

    Public Sub New()
        UserId = 0
        Name = ""
        Password = ""
        PasswordConfirm = ""
        IDCard = ""
        Role = 0
        IsLogged = 0
        IsActive = 1
        HasChangedPassword = 0
        PasswordInitials = ""
    End Sub

    'Enums
    Public Enum Roles
        Administrador = 0
        Usuario = 1
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
            PasswordInitials = Password.Substring(0, 4)
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

    'Validate name
    Public Function ValidateName() As Boolean
        If Name.Length > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    'Validate ID card
    Public Function ValidateIDCard() As Boolean
        If IDCard.Length > 0 Then
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
    Public Sub ValidateAll()
        Dim message As String = ""
        If Not ValidateName() Then
            message += "El nombre no puede estar vacío. "
        End If
        If Not ValidateIDCard() Then
            message += "El número de cédula no puede estar vacío. "
        End If
        If message = "" Then
            Password = EncryptPassword()
        Else
            Throw New Exception(message)
        End If
    End Sub

    'Validate all and return message with errors
    Public Sub ValidateAllChangePassword()
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
        If message = "" Then
            Password = EncryptPassword()
        Else
            Throw New Exception(message)
        End If
    End Sub

    'Generate first random password
    Public Sub GenerateRandomPassword()
        Dim result As String = "Contra" + IDCard
        ' Take first 4 characters
        PasswordInitials = result.Substring(0, 4)
        ' Set password
        Password = result
        ' Encrypt password
        Password = EncryptPassword()
    End Sub

End Class
