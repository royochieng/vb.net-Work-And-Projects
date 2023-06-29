Imports System.Data.SqlClient
Public Class Salary

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
                EmpPoslbl.Text = dr(3).ToString()
                EmpNamelbl.Visible = True
                EmpPoslbl.Visible = True
               
            Next
            Con.Close()
        End If

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        Dim Main = New MainForm
        Main.Show()
    End Sub

    Private Sub Salary_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FetchEmployeeData()
    End Sub
    Dim DailyPay
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        If EmpPoslbl.Text = "" Then
            MsgBox("Select Employee")
        ElseIf WorkedTb.Text = "" Or Convert.ToInt32(WorkedTb.Text) > 28 Then
            MsgBox("Enter a Valid Number of Days")
        ElseIf EmpPoslbl.Text = "Manager" Then
            DailyPay = 1200
        ElseIf EmpPoslbl.Text = "Accountant" Then
            DailyPay = 1200
        ElseIf EmpPoslbl.Text = "Security" Then
            DailyPay = 850
        ElseIf EmpPoslbl.Text = "Cleaner" Then
            DailyPay = 600
        ElseIf EmpPoslbl.Text = "IT chairman" Then
            DailyPay = 1100
        ElseIf EmpPoslbl.Text = "IT Assistant" Then
            DailyPay = 1000
        ElseIf EmpPoslbl.Text = "An Intern (Attachment Student)" Then
            DailyPay = 500
        Else
            DailyPay = 300
        End If

        Dim total = DailyPay * Convert.ToInt32(WorkedTb.Text)

        SalaryTb.Text = "Payment Receipt" + vbCrLf + "_________________________________________________" + vbCrLf + "Employee Id:           " + EmpIdTb.Text + vbCrLf + "Employee Name:         " + EmpNamelbl.Text + vbCrLf + "Employee Possition: " + EmpPoslbl.Text + vbCrLf + "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~" + vbCrLf + "Days Worked:         " + WorkedTb.Text + vbCrLf + "Daily Salary Rs:      " + Convert.ToString(DailyPay) + vbCrLf + "Total Amount Rs:     " + Convert.ToString(total) + vbCrLf
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Employee Management System", New Font("Century Gothic", 25), Brushes.DarkGreen, 180, 40)
        e.Graphics.DrawString("****PAYSLIP****", New Font("Arial", 20), Brushes.Crimson, 300, 100)
        e.Graphics.DrawString(SalaryTb.Text, New Font("Century Gothic", 20), Brushes.Black, 150, 190)

        e.Graphics.DrawString("---------Thank You for Your Services----------", New Font("Century Gothic", 15), Brushes.Black, 150, 500)


    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Show()
    End Sub

   
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub
End Class