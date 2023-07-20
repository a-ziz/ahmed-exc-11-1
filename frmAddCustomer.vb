Public Class frmAddCustomer

    Public Customer As Customer

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If IsValid() Then
            Customer = New Customer(txtFirstName.Text, txtLastName.Text, txtEmail.Text)
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Function IsValid() As Boolean
        Return Validator.IsPresent(txtFirstName) AndAlso
         Validator.IsPresent(txtLastName) AndAlso
         Validator.IsPresent(txtEmail) AndAlso
         Validator.IsValidEmail(txtEmail)
    End Function

    Private Sub frmAddCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class