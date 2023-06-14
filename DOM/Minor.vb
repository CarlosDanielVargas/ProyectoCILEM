Public Class Minor

    'Properties
    Property MinorID As String
    Property Name As String
    Property BirthDate As Date
    Property EnteredDate As Date
    Property GraduationDate As Date
    Property Residency As String
    Property Gender As Char
    Property RecommendationMethod As String
    Property LevelID As Integer

    'Constructors

    'Empty constructor
    Public Sub New()
    End Sub

    'Constructor with all the parameters
    Public Sub New(ByVal minorID As String, ByVal name As String, ByVal birthDate As Date, ByVal enteredDate As Date, ByVal graduationDate As Date, ByVal residency As String, ByVal gender As Char, ByVal recommendationMethod As String, ByVal level As Integer)
        Me.MinorID = minorID
        Me.Name = name
        Me.BirthDate = birthDate
        Me.EnteredDate = enteredDate
        Me.GraduationDate = graduationDate
        Me.Residency = residency
        Me.Gender = gender
        Me.RecommendationMethod = recommendationMethod
        Me.LevelID = level
    End Sub

    'Constructor with only the minorID and name
    Public Sub New(ByVal minorID As String, ByVal name As String)
        Me.MinorID = minorID
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

    'Validate if the residency is not empty
    Public Function ValidateResidency() As Boolean
        If Me.Residency <> "" Then
            Return True
        Else
            Return False
        End If
    End Function

    'Validate if the recommendation method is not empty
    Public Function ValidateRecommendationMethod() As Boolean
        If Me.RecommendationMethod <> "" Then
            Return True
        Else
            Return False
        End If
    End Function

    'Validate if the level is not empty
    Public Function ValidateLevel() As Boolean
        If Me.LevelID <> 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    'Validate if the birth date is not empty
    Public Function ValidateBirthDate() As Boolean
        If Me.BirthDate <> Nothing Then
            Return True
        Else
            Return False
        End If
    End Function

    'Validate if the entered date is not empty
    Public Function ValidateEnteredDate() As Boolean
        If Me.EnteredDate <> Nothing Then
            Return True
        Else
            Return False
        End If
    End Function

    'Validate if the graduation date is not empty
    Public Function ValidateGraduationDate() As Boolean
        If Me.GraduationDate <> Nothing Then
            Return True
        Else
            Return False
        End If
    End Function

    'Validate if MinorID is not empty
    Public Function ValidateMinorID() As Boolean
        If Me.MinorID <> "" Then
            Return True
        Else
            Return False
        End If
    End Function

    'Validate if Gender is not empty
    Public Function ValidateGender() As Boolean
        If Me.Gender <> "" Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
