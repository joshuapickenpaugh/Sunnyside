Option Strict On

Public Class SunnysideCalculator

    Private _decUnitsOrdered As Decimal
    Private _bolWholeSaler As Boolean
    Private _bolRetailer As Boolean

    Public Property UnitsOrdered As Decimal
        Get
            Return _decUnitsOrdered
        End Get
        Set(value As Decimal)
            If value > 0 Then
                _decUnitsOrdered = value
            Else
                _decUnitsOrdered = 0
            End If
        End Set
    End Property

    Public Property WholeSaler As Boolean
        Get
            Return _bolWholeSaler
        End Get
        Set(value As Boolean)
            If value = True Then
                _bolWholeSaler = value
            Else
                _bolWholeSaler = False
            End If
        End Set
    End Property

    Public Property Retailer As Boolean
        Get
            Return _bolRetailer
        End Get
        Set(value As Boolean)
            If value = True Then
                _bolRetailer = value
            Else
                _bolRetailer = False
            End If
        End Set
    End Property

    Public Sub New()

        _decUnitsOrdered = 0
        _bolWholeSaler = False
        _bolRetailer = False

    End Sub

    Public Sub Clear()

        _decUnitsOrdered = 0
        _bolWholeSaler = False
        _bolRetailer = False

    End Sub

    Public Function GetTotal() As Decimal

        Dim ttl As Decimal

        If _bolWholeSaler = True Then
            Select Case _decUnitsOrdered
                Case 1 To 10
                    ttl = 20 * _decUnitsOrdered
                Case >= 11
                    ttl = 15 * _decUnitsOrdered
            End Select
        ElseIf _bolRetailer = True Then
            Select Case _decUnitsOrdered
                Case 1 To 5
                    ttl = 30 * _decUnitsOrdered
                Case 6 - 15
                    ttl = 28 * _decUnitsOrdered
                Case >= 16
                    ttl = 25 * _decUnitsOrdered
            End Select
        End If

        Return ttl

    End Function

End Class
