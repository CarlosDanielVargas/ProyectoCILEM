Public Class Level

    'Properties
    Property LevelID As Integer
    Property Name As String

    'Constructors

    'Empty constructor
    Public Sub New()
    End Sub

    'Constructor with all the parameters
    Public Sub New(ByVal levelID As Integer, ByVal name As String)
        Me.LevelID = levelID
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

End Class
