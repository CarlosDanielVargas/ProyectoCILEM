Imports System.Text.RegularExpressions

Public Class Representative

    'Properties
    Property RepresentativeID As String
    Property Name As String
    Property Mail As String
    Property Phone As String
    Property MaritalStatus As String
    Property Residency As String
    Property Gender As String
    Property Occupation As String
    Property WorkPlace As String
    Property Relationship As String
    Property Minors As List(Of Minor)
    Property RepresentativeMinors As List(Of RepresentativeMinor)

    Public ReadOnly Property IDAndName As String
        Get
            Return $"{RepresentativeID} - {Name}"
        End Get
    End Property

    Public ReadOnly Property IDAndNameAndRelationship As String
        Get
            Return $"{RepresentativeID} - {Name} - {Relationship}"
        End Get
    End Property

    'Enums

    'Relationship with the minor
    Enum RelationshipEnum
        Padre
        Madre
        Tutor
        Tío
        Tía
        Abuelo
        Abuela
        Otro
    End Enum

    'Marital status
    Enum MaritalStatusEnum
        Soltero
        Casado
        Divorciado
        Viudo
    End Enum

    'Gender
    Enum GenderEnum
        Masculino
        Femenino
    End Enum

    'Constructors

    'Empty constructor
    Public Sub New()
    End Sub

    'Constructor with all the parameters
    Public Sub New(ByVal representativeID As Integer, ByVal name As String, ByVal mail As String, ByVal phone As String, ByVal maritalStatus As String, ByVal residency As String, ByVal gender As Char, ByVal occupation As String, ByVal workPlace As String, ByVal relationship As String)
        Me.RepresentativeID = representativeID
        Me.Name = name
        Me.Mail = mail
        Me.Phone = phone
        Me.MaritalStatus = maritalStatus
        Me.Residency = residency
        Me.Gender = gender
        Me.Occupation = occupation
        Me.WorkPlace = workPlace
        Me.Relationship = relationship
    End Sub

    'Constructor with only the representativeID and name
    Public Sub New(ByVal representativeID As Integer, ByVal name As String)
        Me.RepresentativeID = representativeID
        Me.Name = name
    End Sub

    'Validations

    'Validate if the name is not empty
    Public Function ValidateName() As Boolean
        If Me.Name <> "" Then
            Return True
        Else
            Return False
        End If
    End Function

    'Validate if the mail is not empty
    Public Function ValidateMail() As Boolean
        If Me.Mail <> "" Then
            Return True
        Else
            Return False
        End If
    End Function

    'Validate if the phone is not empty
    Public Function ValidatePhone() As Boolean
        If Me.Phone <> "" Then
            Return True
        Else
            Return False
        End If
    End Function

    'Validate if the marital status is not empty
    Public Function ValidateMaritalStatus() As Boolean
        If Me.MaritalStatus <> "" Then
            Return True
        Else
            Return False
        End If
    End Function

    'Validate if the residency is not empty
    Public Function ValidateResidency() As Boolean
        If Me.Residency <> "" Then
            Return True
        Else
            Return False
        End If
    End Function

    'Validate if the occupation is not empty
    Public Function ValidateOccupation() As Boolean
        If Me.Occupation <> "" Then
            Return True
        Else
            Return False
        End If
    End Function

    'Validate if the work place is not empty
    Public Function ValidateWorkPlace() As Boolean
        If Me.WorkPlace <> "" Then
            Return True
        Else
            Return False
        End If
    End Function

    'Validate if RepresentativeID is not empty
    Public Function ValidateRepresentativeID() As Boolean
        If Me.RepresentativeID <> "" Then
            Return True
        Else
            Return False
        End If
    End Function

    'Validate if mail is valid
    Public Function ValidateMailFormat() As Boolean
        Dim mailRegex As Regex = New Regex("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")
        If mailRegex.IsMatch(Me.Mail) Then
            Return True
        Else
            Return False
        End If
    End Function

    'Methods

    'Validate if the representative is valid and creates the error message
    Public Function ValidateAll()
        Dim errorMessage As String = ""
        If Not ValidateName() Then
            errorMessage += "El nombre no puede estar vacío." + vbCrLf
        End If
        If Not ValidateMail() Then
            errorMessage += "El correo no puede estar vacío." + vbCrLf
        End If
        If Not ValidatePhone() Then
            errorMessage += "El teléfono no puede estar vacío." + vbCrLf
        End If
        If Not ValidateMaritalStatus() Then
            errorMessage += "El estado civil no puede estar vacío." + vbCrLf
        End If
        If Not ValidateResidency() Then
            errorMessage += "La residencia no puede estar vacía." + vbCrLf
        End If
        If Not ValidateOccupation() Then
            errorMessage += "La ocupación no puede estar vacía." + vbCrLf
        End If
        If Not ValidateWorkPlace() Then
            errorMessage += "El lugar de trabajo no puede estar vacío." + vbCrLf
        End If
        If Not ValidateRepresentativeID() Then
            errorMessage += "El ID del representante no puede estar vacío." + vbCrLf
        End If
        If Not ValidateMailFormat() Then
            errorMessage += "El correo no tiene un formato válido." + vbCrLf
        End If
        If errorMessage <> "" Then
            Throw New Exception(errorMessage)
        End If
    End Function



End Class
