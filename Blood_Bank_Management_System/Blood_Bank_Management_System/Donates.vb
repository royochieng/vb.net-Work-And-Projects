Imports System.Data.SqlClient
Public Class Donates

    Dim Con As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Jabundani ROY Ochi\onedrive\documents\visual studio 2012\Projects\Blood_Bank_Management_System\Blood_Bank_Management_System\BloodBMSvbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub DisplayDonors()
        Try
            Con.Open()
            Dim query = "select DName, DBGroup from DonorTbl"
            Dim adapter As SqlDataAdapter
            adapter = New SqlDataAdapter(query, Con)
            Dim builder = New SqlCommandBuilder(adapter)
            Dim ds As DataSet
            ds = New DataSet
            adapter.Fill(ds)
            DonorsDGV.DataSource = ds.Tables(0)
            Con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DisplayBlood()
        Try
            Con.Open()
            Dim query = "select Blood_Group, Blood_Stock from BStockTbl"
            Dim adapter As SqlDataAdapter
            adapter = New SqlDataAdapter(query, Con)
            Dim builder = New SqlCommandBuilder(adapter)
            Dim ds As DataSet
            ds = New DataSet
            adapter.Fill(ds)
            BloodDGV.DataSource = ds.Tables(0)
            Con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub Donates_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayDonors()
        DisplayBlood()
    End Sub
    Dim key As Integer
    Private Sub DonorsDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DonorsDGV.CellMouseClick
        Dim row As DataGridViewRow = DonorsDGV.Rows(e.RowIndex)
        DNameTb.Text = row.Cells(0).Value.ToString
        DBGroupTb.Text = row.Cells(1).Value.ToString

    End Sub

    Dim OldStock
    Private Sub FetchQty()
        Con.Open()
        Dim query = "select * from BStockTbl where Blood_Group = '" & DBGroupTb.Text & "' "
        Dim cmd As New SqlCommand(query, Con)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            OldStock = Convert.ToInt32(reader(2))
        End While
        Con.Close()
    End Sub
    Private Sub DonateBtn_Click(sender As Object, e As EventArgs) Handles DonateBtn.Click
        Try
            If DNameTb.Text = "" Or DBGroupTb.Text = "" Then 
                MsgBox("Select a Donor from Donors List ")
            Else
                FetchQty()
                Dim NewStock As Integer

                NewStock = OldStock + 1
                Con.Open()
                Dim query = "update BStockTbl set Blood_Stock=" & NewStock & " where Blood_Group= '" & DBGroupTb.Text & "' "
                Dim cmd As New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Blood Updated Successfully")
                Con.Close()
                DisplayBlood()
            End If
        Catch ex As Exception

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

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim Obj As New Transfers()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim Obj As New Dashboard()
        Obj.Show()
        Me.Hide()
    End Sub
End Class