Imports System.Text.RegularExpressions

Public Class Representative

    'Properties
    Property RepresentativeID As String
    Property Name As String
    Property Mail As String
    Property Phone As String
    Property MaritalStatus As String
    Property Residency As String
    Property Gender As Char
    Property Occupation As String
    Property WorkPlace As String
    Property Relationship As String

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

    Public Sub New(v1 As String, v2 As String, v3 As String, v4 As String)
        Me.v1 = v1
        Me.v2 = v2
        Me.v3 = v3
        Me.v4 = v4
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


End Class
