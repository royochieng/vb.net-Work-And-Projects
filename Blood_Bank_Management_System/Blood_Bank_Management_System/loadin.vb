Imports System.Data.SqlClient

Public Class loadin


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

  
    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Try
            If UnameTb.Text = "" Or PasswordTb.Text = "" Then
                MsgBox("Enter Both Username and Password")
            ElseIf UnameTb.Text = "Student" And PasswordTb.Text = "Password" Then
                Dim Obj As New Patient()
                Obj.Show()
                Me.Hide()
            Else
                MsgBox("Wrong Username and Password")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        UnameTb.Text = ""
        PasswordTb.Text = ""
    End Sub
End Class