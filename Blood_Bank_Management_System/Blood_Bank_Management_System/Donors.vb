Imports System.Data.SqlClient


Public Class Donors

    Dim Con As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Jabundani ROY Ochi\onedrive\documents\visual studio 2012\Projects\Blood_Bank_Management_System\Blood_Bank_Management_System\BloodBMSvbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub DisplayDonors()
        Try
            Con.Open()

            Dim query = "select * from DonorTbl"
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
    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Try
            Con.Open()
            Dim query = "insert into DonorTbl(DName,DAge,DGen,DTell,DBGroup,DAddress) values (@DonName,@DonAge,@DonGen,@DonTell,@DonBGroup,@DonAddress)"
            Dim cmd As New SqlCommand(query, Con)
            cmd.Parameters.AddWithValue("DonName", DNameTb.Text)
            cmd.Parameters.AddWithValue("DonAge", DAgeTb.Text)
            cmd.Parameters.AddWithValue("DonGen", DGenCb.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("DonTell", DTellTb.Text)
            cmd.Parameters.AddWithValue("DonBGroup", DBGroupCb.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("DonAddress", DAddressTb.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Donor Added to list (Blood Saved)")

            Con.Close()
            DisplayDonors()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Donors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayDonors()
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Try
            If key = 0 Then
                MsgBox("Select the Donor to be Deleted")
            Else
                Con.Open()
                Dim cmd As SqlCommand
                Dim query = "delete from DonorTbl where DId = " & key & ""
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Donor Deleted Successfully")
                Con.Close()
                DisplayDonors()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Dim key As Integer
    Private Sub DonorsDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DonorsDGV.CellMouseClick
        Dim row As DataGridViewRow = DonorsDGV.Rows(e.RowIndex)
        DNameTb.Text = row.Cells(1).Value.ToString
        DAgeTb.Text = row.Cells(2).Value.ToString
        DGenCb.SelectedItem = row.Cells(3).Value.ToString
        DTellTb.Text = row.Cells(4).Value.ToString
        DBGroupCb.SelectedItem = row.Cells(5).Value.ToString
        DAddressTb.Text = row.Cells(6).Value.ToString

        If DNameTb.Text = "Donor Name" Or DNameTb.Text = "" Then
            key = 0
        Else
            key = row.Cells(0).Value.ToString
        End If
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        Try
            If key = 0 Or DNameTb.Text = "" Or DAgeTb.Text = "" Or DTellTb.Text = "" Or DAddressTb.Text = "" Then
                MsgBox("Incomplite Information")
            Else
                Con.Open()
                Dim query = "update DonorTbl set DName='" & DNameTb.Text & "',DAge='" & DAgeTb.Text & "',DGen='" & DGenCb.SelectedItem.ToString & "',DTell='" & DTellTb.Text & "',DBGroup='" & DBGroupCb.SelectedItem.ToString & "',DAddress='" & DAddressTb.Text & "' where DId=" & key & " "
                Dim cmd As New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Donor Updated Successfully")
                Con.Close()
                DisplayDonors()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim Obj As New Donors()
        Obj.Show()

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
        Me.Hide()
    End Sub
End Class