Public Class frmBuildingPlansConversion
    Private Sub frmBuildingPlansConversion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblConverted.Text = ""
        txtConversion.Focus()
        radInchesToMeters.Checked = True
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim decConversionInput As Decimal
        Dim decConvertedNumber As Decimal
        Dim decMeter As Decimal = 39.3700787D
        Dim decInches As Decimal = 0.0254D
        If IsNumeric(txtConversion.Text) Then
            decConversionInput = Convert.ToInt32(txtConversion.Text)
            If decConversionInput > 0 Then
                If radInchesToMeters.Checked Then
                    decConvertedNumber = (decConversionInput * decInches)
                    lblConverted.Text = (decConversionInput.ToString("N0") + " inches is " + decConvertedNumber.ToString("N3") + " meters.")
                ElseIf radMetersToInches.Checked Then
                    decConvertedNumber = (decConversionInput * decMeter)
                    lblConverted.Text = (decConversionInput.ToString("N0") + " meters is " + decConvertedNumber.ToString("N3") + " inches.")
                End If
            Else
                MsgBox("Enter a positive number", , "Invalid Number Error")
            End If
        Else
            MsgBox("Enter a positive number", , "Invalid Entry Error")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblConverted.Text = ""
        txtConversion.Text = ""
        radInchesToMeters.Checked = True
        txtConversion.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
