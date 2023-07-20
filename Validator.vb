Public Class Validator

    Public Shared Property Title As String = "Entry Error"

    Public Shared Function IsPresent(textBox As TextBox) _
            As Boolean
        If textBox.Text = "" Then
            MessageBox.Show(textBox.Tag.ToString & " is a required field.", Title)
            textBox.Select()
            Return False
        Else
            Return True
        End If
    End Function

    Public Shared Function IsDecimal(textBox As TextBox) _
            As Boolean
        Dim number As Decimal = 0
        If Decimal.TryParse(textBox.Text, number) Then
            Return True
        Else
            MessageBox.Show(textBox.Tag.ToString & " must be a decimal value.", Title)
            textBox.Select()
            textBox.SelectAll()
            Return False
        End If

    End Function

    Public Shared Function IsInt32(textBox As TextBox) _
            As Boolean
        Dim number As Integer = 0
        If Int32.TryParse(textBox.Text, number) Then
            Return True
        Else
            MessageBox.Show(textBox.Tag.ToString & " must be an integer value.", Title)
            textBox.Select()
            textBox.SelectAll()
            Return False
        End If
    End Function

    Public Shared Function IsWithinRange(textBox As TextBox,
            min As Decimal, max As Decimal) As Boolean
        Dim number As Decimal = CDec(textBox.Text)
        If number < min OrElse number > max Then
            MessageBox.Show(textBox.Tag.ToString & " must be between " &
                min & " and " & max & ".", Title)
            textBox.Select()
            textBox.SelectAll()
            Return False
        Else
            Return True
        End If
    End Function

    Public Shared Function IsValidEmail(textBox As TextBox) As Boolean
        If textBox.Text.IndexOf("@") = -1 OrElse _
                textBox.Text.IndexOf(".") = -1 Then
            MessageBox.Show(textBox.Tag.ToString & " must be a valid email address",
                Title)
            textBox.Select()
            textBox.SelectAll()
            Return False
        Else
            Return True
        End If
    End Function
End Class
