Public Class Form1
    'This is now the code for ISBN 13 project
    Private Sub displayButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click
        Dim isbn12, isbn13 As String
        Dim sum, checksum As Integer
        isbn12 = isbn9TextBox.Text
        For i As Integer = 1 To 12
            If i Mod 2 = 0 Then
                sum += 3 * CInt(isbn12.Substring(i - 1, 1))
            Else
                sum += CInt(isbn12.Substring(i - 1, 1))
            End If
        Next
        checksum = 10 - sum Mod 10
        lblSum.Text = CStr(sum)
        lblCheckSum.Text = CStr(checksum)
        If checksum = 10 Then
            isbn13 = isbn12 + "0"
        Else
            isbn13 = isbn12 + CStr(checksum)
        End If
        isbn10Label.Text = isbn13
    End Sub

    Private Sub resetButton_Click(sender As Object, e As EventArgs) Handles resetButton.Click
        isbn9TextBox.Text = ""
        lblSum.Text = ""
        lblCheckSum.Text = ""
        isbn10Label.Text = ""
    End Sub
End Class
