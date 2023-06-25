Public Class MonthlyPayments
    ' Attributes
    Public Property MonthlyPaymentID As Integer
    Public Property Value As Double
    Public Property PaymentDate As Date
    Public Property Month As String
    Public Property Description As String
    Public Property MinorID As String
    Public Property Minor As Minor
    Public Property TransferNumber As String

    ' Constructor
    Public Sub New()
        Me.MonthlyPaymentID = 0
        Me.Value = 0
        Me.PaymentDate = Date.Now
        Me.Month = ""
        Me.Description = ""
        Me.MinorID = ""
        Me.Minor = New Minor()
        Me.TransferNumber = ""
    End Sub

    ' Validations
    Public Function ValidateValue() As Boolean
        If Me.Value > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ValidatePaymentDate() As Boolean
        If Me.PaymentDate <> Date.Now Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ValidateMonth() As Boolean
        If Me.Month <> "" Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ValidateMinorID() As Boolean
        If Me.MinorID <> "" Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ValidateTransferNumber() As Boolean
        If Me.TransferNumber <> "" Then
            Return True
        Else
            Return False
        End If
    End Function

    ' Methods
    ' Validate all the properties and returns a error message
    Public Function Validate() As String
        Dim message As String = ""

        If Not ValidateValue() Then
            message += "El valor no puede ser menor o igual a 0." & vbCrLf
        End If

        If Not ValidatePaymentDate() Then
            message += "La fecha de pago no puede estar vacía." & vbCrLf
        End If

        If Not ValidateMonth() Then
            message += "El mes no puede estar vacío." & vbCrLf
        End If

        If Not ValidateMinorID() Then
            message += "El ID del menor no puede estar vacío." & vbCrLf
        End If

        If Not ValidateTransferNumber() Then
            message += "El número de transferencia no puede estar vacío." & vbCrLf
        End If

        Return message
    End Function



End Class
