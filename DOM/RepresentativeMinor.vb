Public Class RepresentativeMinor

    'Properties
    Property RepresentativeID As String
    Property MinorID As String

    'Constructors

    'Empty constructor
    Public Sub New()
    End Sub

    'Constructor with all the parameters
    Public Sub New(ByVal representativeID As String, ByVal minorID As String)
        Me.RepresentativeID = representativeID
        Me.MinorID = minorID
    End Sub
End Class
