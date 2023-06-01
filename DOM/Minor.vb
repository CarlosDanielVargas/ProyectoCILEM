Public Class Minor

    Property MinorID As String
    Property Name As String
    Property BirthDate As Date
    Property EnteredDate As Date
    Property GraduationDate As Date
    Property Residency As String
    Property Gender As Char
    Property RecommendationMethod As String

    Public Sub New()
    End Sub

    Public Sub New(ByVal minorID As String, ByVal name As String, ByVal birthDate As Date, ByVal enteredDate As Date, ByVal graduationDate As Date, ByVal residency As String, ByVal gender As Char, ByVal recommendationMethod As String)
        Me.MinorID = minorID
        Me.Name = name
        Me.BirthDate = birthDate
        Me.EnteredDate = enteredDate
        Me.GraduationDate = graduationDate
        Me.Residency = residency
        Me.Gender = gender
        Me.RecommendationMethod = recommendationMethod
    End Sub



End Class
