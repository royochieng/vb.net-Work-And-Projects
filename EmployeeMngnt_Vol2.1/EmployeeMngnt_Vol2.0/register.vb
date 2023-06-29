Imports System.Data.SqlClient
Public Class register
    Dim Con As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mr. Roy Jabundani\Documents\EmployeeVbDb.mdf;Integrated Security=True;Connect Timeout=30")
   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim UpDet = New UpdateDetails
        UpDet.Show()
    End Sub
    
    
    Private Sub registerBt_Click(sender As Object, e As EventArgs) Handles registerBt.Click
        Con.Open()

        Dim Query As String
        Query = "insert into UserAccountTbl values('" & UserNameTb.Text & "','" & UserPhoneTb.Text & "','" & UserLevelCb.SelectedItem.ToString() & "','" & FullNameTb.Text & "','" & UserPassTb.Text & "')"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(Query, Con)
        cmd.ExecuteNonQuery()
        MsgBox("User Added successfully")

        Con.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Dim log = New Login
        log.Show()
    End Sub
End Class