Public Class AdminSecurity

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AllowBt.Click
        If UserNameTbl.Text = "" Or PassTbl.Text = "" Then
            MsgBox("Enter The User Id and Password")
        ElseIf UserNameTbl.Text = "Administrator" And PassTbl.Text = "admin123" Then
            MsgBox("Access granted")
            Me.Hide()
            Dim regi = New register
            regi.Show()

        Else
            MsgBox("Wrong User Name or Password")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CancelBt.Click
        Me.Hide()
        Dim UpDet = New Login
        UpDet.Show()
    End Sub


End Class