Imports System.Data.SqlClient
Public Class Transfers
    Dim Con As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Jabundani ROY Ochi\onedrive\documents\visual studio 2012\Projects\Blood_Bank_Management_System\Blood_Bank_Management_System\BloodBMSvbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub FetchPatient()
        Con.Open()
        Dim Sql = "select * from PatientTbl"
        Dim cmd As New SqlCommand(Sql, Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        PatIdCb.DataSource = Tbl
        PatIdCb.DisplayMember = "PId"
        PatIdCb.ValueMember = "PId"

        Con.Close()
    End Sub
    Private Sub Transfers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchPatient()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub GetData()
        Con.Open()
        Dim query = "select * from PatientTbl where PId = " & PatIdCb.SelectedValue.ToString() & " "
        Dim cmd As New SqlCommand(query, Con)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            PatNameTb.Text = reader(1).ToString()
            BGroupTb.Text = reader(5).ToString()
        End While
        Con.Close()
    End Sub
    Private Sub PatIdCb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles PatIdCb.SelectionChangeCommitted
        GetData()
        FetchQty()
        If AvailableStock = 0 Then
            AvailableLbl.Text = "No Blood Available"
            AvailableLbl.Visible = True
        Else
            AvailableLbl.Text = AvailableStock
            AvailableLbl.Visible = True
            TransferBtn.Visible = True
        End If
    End Sub
    Dim AvailableStock As Integer
    Private Sub FetchQty()
        Con.Open()
        Dim query = "select * from BStockTbl where Blood_Group = '" & BGroupTb.Text & "' "
        Dim cmd As New SqlCommand(query, Con)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            AvailableStock = Convert.ToInt32(reader(2))
        End While
        Con.Close()
    End Sub
    Private Sub UpdateBlood()
        FetchQty()
        Dim NewStock As Integer

        NewStock = AvailableStock - 1
        Con.Open()
        Dim query = "update BStockTbl set Blood_Stock=" & NewStock & " where Blood_Group= '" & BGroupTb.Text & "' "
        Dim cmd As New SqlCommand(query, Con)
        cmd.ExecuteNonQuery()
        

        Con.Close()
        If NewStock = 0 Then
            TransferBtn.Visible = False
        Else
            TransferBtn.Visible = True
        End If
    End Sub
    Private Sub TransferBtn_Click(sender As Object, e As EventArgs) Handles TransferBtn.Click

        Try
            Con.Open()
            Dim query = "insert into TransferTbl(Tpat,TBGroup) values (@TrPat,@TrBGroup)"
            Dim cmd As New SqlCommand(query, Con)
            cmd.Parameters.AddWithValue("TrPat", PatNameTb.Text)
            cmd.Parameters.AddWithValue("TrBGroup", BGroupTb.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Blood Transfered")
            Con.Close()
            FetchQty()
            UpdateBlood()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim Obj As New Dashboard()
        Obj.Show()
        Me.Hide()
    End Sub
End Class