Imports System.Data.SqlClient
Public Class Login
    Dim Con As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mr. Roy Jabundani\Documents\EmployeeVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UidTb.Clear()
        PassTb.Clear()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If UidTb.Text = "" Or PassTb.Text = "" Then
            MessageBox.Show("Enter your User Name and User Password !")
        ElseIf UidTb.Text = "User" And PassTb.Text = "Password" Then
            Dim Main = New MainForm
            Main.Show()
            Me.Hide()
        Else
            MessageBox.Show("You entered a wrong User name or User password")
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click


        Me.Hide()
        Dim AdSec = New AdminSecurity
        AdSec.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles DashBt.Click
        Me.Hide()
        Dim Dash = New Dashboard
        Dash.Show()
    End Sub
End Class