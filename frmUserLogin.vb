Public Class frmUserLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUserName.Text = "Administrator" AndAlso txtPassword.Text = 123456 Then
            Dim mainForm As New frmParent()
            mainForm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
