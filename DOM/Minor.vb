﻿Public Class Minor

    'Properties
    Property MinorID As String
    Property Name As String
    Property BirthDate As Date
    Property EnteredDate As Date
    Property GraduationDate As Date
    Property Residency As String
    Property Gender As String
    Property RecommendationMethod As String
    Property LevelID As Integer
    Property HasSchoolarship As String
    Property Relationship As String
    Property WorkingDay As String
    Property Payments As List(Of MonthlyPayment)
    Property Representatives As List(Of Representative)
    Property RepresentativeMinors As List(Of RepresentativeMinor)
    Property Level As Level

    'Enums
    Enum WorkingDayEnum
        Medio_Tiempo
        Tiempo_Completo
    End Enum
    Enum HasSchoolarshipEnum
        Sí
        No
    End Enum

    Enum GenderEnum
        Masculino
        Femenino
    End Enum

    Enum RecommendationMethodEnum
        UCR_Administativo
        UCR_Profesor
        UCR_Estudiante
        Comunidad
        Otro
    End Enum

    'Constructors

    'Empty constructor
    Public Sub New()
        Me.Representatives = New List(Of Representative)
        Me.RepresentativeMinors = New List(Of RepresentativeMinor)
        Me.Payments = New List(Of MonthlyPayment)
    End Sub

    'Constructor with all the parameters
    Public Sub New(ByVal minorID As String, ByVal name As String, ByVal birthDate As Date, ByVal enteredDate As Date, ByVal graduationDate As Date, ByVal residency As String, ByVal gender As Char, ByVal recommendationMethod As String, ByVal level As Integer, ByVal hasSchoolarship As String, ByVal representatives As List(Of Representative))
        Me.MinorID = minorID
        Me.Name = name
        Me.BirthDate = birthDate
        Me.EnteredDate = enteredDate
        Me.GraduationDate = graduationDate
        Me.Residency = residency
        Me.Gender = gender
        Me.RecommendationMethod = recommendationMethod
        Me.LevelID = level
        Me.HasSchoolarship = hasSchoolarship
        Me.Representatives = representatives
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

    'Validate if the minor has schoolarship
    Public Function ValidateHasSchoolarship() As Boolean
        If Me.HasSchoolarship <> "" Then
            Return True
        Else
            Return False
        End If
    End Function

    'Validate if the list of representatives is not empty
    Public Function ValidateRepresentatives() As Boolean
        If Me.Representatives.Count <> 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    'Validate if the list of representatives is not empty
    Public Function ValidateRepresentativesCount() As Boolean
        If Me.Representatives.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    'Methods

    'Execute all validations, raises exceptions depending on the validation
    Public Sub ValidateAll()
        Dim exceptionError As String = ""
        If ValidateMinorID() = False Then
            exceptionError += "El ID del menor no puede estar vacío." + vbNewLine
        End If
        If ValidateName() = False Then
            exceptionError += "El nombre del menor no puede estar vacío." + vbNewLine
        End If
        If ValidateBirthDate() = False Then
            exceptionError += "La fecha de nacimiento del menor no puede estar vacía." + vbNewLine
        End If
        If ValidateEnteredDate() = False Then
            exceptionError += "La fecha de ingreso del menor no puede estar vacía." + vbNewLine
        End If
        If ValidateGraduationDate() = False Then
            exceptionError += "La fecha de graduación del menor no puede estar vacía." + vbNewLine
        End If
        If ValidateResidency() = False Then
            exceptionError += "La residencia del menor no puede estar vacía." + vbNewLine
        End If
        If ValidateGender() = False Then
            exceptionError += "El género del menor no puede estar vacío." + vbNewLine
        End If
        If ValidateRecommendationMethod() = False Then
            exceptionError += "El método de recomendación del menor no puede estar vacío." + vbNewLine
        End If
        If ValidateLevel() = False Then
            exceptionError += "El nivel del menor no puede estar vacío." + vbNewLine
        End If
        If ValidateHasSchoolarship() = False Then
            exceptionError += "El menor debe tener o no beca." + vbNewLine
        End If
        If ValidateRepresentatives() = False Then
            exceptionError += "El menor debe tener al menos un representante." + vbNewLine
        End If
        If exceptionError <> "" Then
            Throw New Exception(exceptionError)
        End If
    End Sub


End Class
