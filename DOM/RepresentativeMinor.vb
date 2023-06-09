﻿Public Class RepresentativeMinor

    'Properties
    Property RepresentativeID As String
    Property MinorID As String
    Property Relationship As String

    'Constructors

    'Empty constructor
    Public Sub New()
    End Sub

    'Constructor with all the parameters
    Public Sub New(ByVal representativeID As String, ByVal minorID As String, ByVal relationship As String)
        Me.RepresentativeID = representativeID
        Me.MinorID = minorID
        Me.Relationship = relationship
    End Sub

    'Constructor with only the representativeID and minorID
    Public Sub New(ByVal representativeID As String, ByVal minorID As String)
        Me.RepresentativeID = representativeID
        Me.MinorID = minorID
    End Sub

    'Validations

    'Validate if the relationship is not empty
    Public Function ValidateRelationship() As Boolean
        If Me.Relationship <> "" Then
            Return True
        Else
            Return False
        End If
    End Function

    'Validate all the properties and returns a error message
    Public Function Validate() As String
        Dim message As String = ""

        If Not ValidateRelationship() Then
            message += "La relación no puede estar vacía." & vbCrLf
        End If

        Return message
    End Function
End Class
