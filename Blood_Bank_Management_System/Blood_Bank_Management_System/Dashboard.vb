Imports System.Data.SqlClient
Public Class Dashboard
    Dim Con As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Jabundani ROY Ochi\onedrive\documents\visual studio 2012\Projects\Blood_Bank_Management_System\Blood_Bank_Management_System\BloodBMSvbDb.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub
    Private Sub CountPatients()
        Try
            Dim PatNum As Integer
            Con.Open()
            Dim sql = "select COUNT(*) from PatientTbl"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(sql, Con)
            PatNum = cmd.ExecuteScalar
            PatNumLbl.Text = PatNum
            Con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CountDonor()
        Try
            Dim DonNum As Integer
            Con.Open()
            Dim sql = "select COUNT(*) from DonorTbl"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(sql, Con)
            DonNum = cmd.ExecuteScalar
            DonNumLbl.Text = DonNum
            Con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub CountTransfers()
        Try
            Dim TrNum As Integer
            Con.Open()
            Dim sql = "select COUNT(*) from TransferTbl"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(sql, Con)
            TrNum = cmd.ExecuteScalar
            TrNumLbl.Text = TrNum
            Con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CountPatients()
        CountDonor()
        CountTransfers()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim Obj As New Donors()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim Obj As New Patient()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim Obj As New Donates()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim Obj As New Transfers()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim Obj As New Dashboard()
        Obj.Show()

    End Sub
End Class