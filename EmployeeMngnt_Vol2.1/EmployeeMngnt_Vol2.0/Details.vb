Imports System.Data.SqlClient
Public Class Details
    Dim Con As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mr. Roy Jabundani\Documents\EmployeeVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub FetchEmployeeData()

        If EmpIdTb.Text = "" Then
            MsgBox("Enter The Employees Id")
        Else
            Con.Open()
            Dim Query = " select * from EmployeeTbl where EmpId = " & EmpIdTb.Text & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(Query, Con)
            Dim dt As DataTable
            dt = New DataTable
            Dim sda As SqlDataAdapter
            sda = New SqlDataAdapter(cmd)
            sda.Fill(dt)
            For Each dr As DataRow In dt.Rows()
                EmpNamelbl.Text = dr(1).ToString()
                EmpAddlbl.Text = dr(2).ToString()
                EmpPoslbl.Text = dr(3).ToString()
                EmpDOBlbl.Text = dr(4).ToString()
                EmpPhonelbl.Text = dr(5).ToString()
                EmpEdulbl.Text = dr(6).ToString()
                EmpGendlbl.Text = dr(7).ToString()
                EmpNamelbl.Visible = True
                EmpAddlbl.Visible = True
                EmpPoslbl.Visible = True
                EmpDOBlbl.Visible = True
                EmpPhonelbl.Visible = True
                EmpEdulbl.Visible = True
                EmpGendlbl.Visible = True
            Next
            Con.Close()
        End If
        
    End Sub
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        Dim Main = New MainForm
        Main.Show()
    End Sub

    Private Sub Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles FetchDatabtn.Click
        FetchEmployeeData()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Employee Management System", New Font("Century Gothic", 25), Brushes.DarkGreen, 180, 40)
        e.Graphics.DrawString("**** EMPLOYEE SUMMERY****", New Font("Arial", 20), Brushes.Crimson, 250, 100)
        e.Graphics.DrawString("Name:    " + EmpNamelbl.Text + vbTab + "Address:     " + EmpAddlbl.Text, New Font("Century Gothic", 22), Brushes.DarkGreen, 140, 205)
        e.Graphics.DrawString("Possition:   " + EmpPoslbl.Text + vbTab + "Education:     " + EmpEdulbl.Text, New Font("Century Gothic", 22), Brushes.DarkGreen, 140, 260)
        e.Graphics.DrawString("Phone:   " + EmpPhonelbl.Text + vbTab + "Gender:     " + EmpGendlbl.Text, New Font("Century Gothic", 22), Brushes.DarkGreen, 140, 325)
        e.Graphics.DrawString("DOB:     " + EmpEdulbl.Text + vbTab, New Font("Century Gothic", 22), Brushes.DarkGreen, 200, 385)
        e.Graphics.DrawString("__________--EmpSoft V2.1 Jabu_Basecode--__________", New Font("Century Gothic", 15), Brushes.DarkGreen, 150, 550)

    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        PrintPreviewDialog1.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub
End Class