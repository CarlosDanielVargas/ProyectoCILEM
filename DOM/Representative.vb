Public Class Representative

    Property RepresentativeID As Integer
    Property Name As String
    Property Mail As String
    Property Phone As String
    Property MaritalStatus As String
    Property Residency As String
    Property Gender As Char
    Property Occupation As String
    Property WorkPlace As String

    Enum RelationshipEnum
        Padre
        Madre
        Tutor
    End Enum

    Enum MaritalStatusEnum
        Soltero
        Casado
        Divorciado
        Viudo
    End Enum

    Enum GenderEnum
        Masculino
        Femenino
    End Enum

    Public Sub New()
    End Sub

    Public Sub New(ByVal representativeID As Integer, ByVal name As String, ByVal mail As String, ByVal phone As String, ByVal maritalStatus As String, ByVal residency As String, ByVal gender As Char, ByVal occupation As String, ByVal workPlace As String)
        Me.RepresentativeID = representativeID
        Me.Name = name
        Me.Mail = mail
        Me.Phone = phone
        Me.MaritalStatus = maritalStatus
        Me.Residency = residency
        Me.Gender = gender
        Me.Occupation = occupation
        Me.WorkPlace = workPlace
    End Sub

End Class
