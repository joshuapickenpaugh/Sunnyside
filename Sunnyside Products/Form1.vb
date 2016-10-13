'Joshua Pickenpaugh
'October 13th, 2016
'Sunnyside Retailer or Wholesaler calculator

Option Strict On

Public Class frmMain

    Dim sscalc As New SunnysideCalculator()

    Private Sub txtUnitsOrdered_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnitsOrdered.KeyPress

        'Allows only numbers, ".", and the backspace key in the text boxes:
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> "." AndAlso
                e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Closes the app:
        Me.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clears the object used for calculation:
        sscalc.Clear()

        'Clears the text boxes and labels:
        txtUnitsOrdered.Text = String.Empty
        lblTotal.Text = String.Empty

        rdoWholesale.Focus()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Decimal.TryParse(txtUnitsOrdered.Text, sscalc.UnitsOrdered)

        If rdoWholesale.Checked Then
            sscalc.WholeSaler = True
        Else
            sscalc.WholeSaler = False
        End If

        If rdoRetailer.Checked Then
            sscalc.Retailer = True
        Else
            sscalc.Retailer = False
        End If

        lblTotal.Text = sscalc.GetTotal().ToString("C2")

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Show()
        txtUnitsOrdered.Focus()

    End Sub
End Class
