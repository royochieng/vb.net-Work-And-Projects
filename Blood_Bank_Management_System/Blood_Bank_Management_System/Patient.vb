Imports System.Data.SqlClient

Public Class Patient

    Dim Con As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Jabundani ROY Ochi\onedrive\documents\visual studio 2012\Projects\Blood_Bank_Management_System\Blood_Bank_Management_System\BloodBMSvbDb.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub DisplayPatients()
        Try
            Con.Open()

            Dim query = "select * from PatientTbl"
            Dim adapter As SqlDataAdapter
            adapter = New SqlDataAdapter(query, Con)
            Dim builder = New SqlCommandBuilder(adapter)
            Dim ds As DataSet
            ds = New DataSet
            adapter.Fill(ds)
            PatientDGV.DataSource = ds.Tables(0)

            Con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Try
            Con.Open()
            Dim query = "insert into PatientTbl(PName,PAge,PGen,PTell,PBGroup,PAddress) values (@PatName,@PatAge,@PatGen,@PatTell,@PatBGroup,@PatAddress)"
            Dim cmd As New SqlCommand(query, Con)
            cmd.Parameters.AddWithValue("PatName", PNameTb.Text)
            cmd.Parameters.AddWithValue("PatAge", PAgeTb.Text)
            cmd.Parameters.AddWithValue("PatGen", PGenCb.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("PatTell", PTellTb.Text)
            cmd.Parameters.AddWithValue("PatBGroup", PBGroupCb.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("PatAddress", PAddressTb.Text)
            cmd.ExecuteNonQuery()
            MsgBox("PatientAdded to list (Saved)")

            Con.Close()
            DisplayPatients()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayPatients()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub
    Dim key As Integer
    Private Sub PatientDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PatientDGV.CellContentClick
        Dim row As DataGridViewRow = PatientDGV.Rows(e.RowIndex)
        PNameTb.Text = row.Cells(1).Value.ToString
        PAgeTb.Text = row.Cells(2).Value.ToString
        PGenCb.SelectedItem = row.Cells(3).Value.ToString
        PTellTb.Text = row.Cells(4).Value.ToString
        PBGroupCb.SelectedItem = row.Cells(5).Value.ToString
        PAddressTb.Text = row.Cells(6).Value.ToString

        If PNameTb.Text = "Patient Name" Or PNameTb.Text = "" Then
            key = 0
        Else
            key = row.Cells(0).Value.ToString
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Try
            If key = 0 Then
                MsgBox("Select the Patient to be Deleted")
            Else
                Con.Open()
                Dim cmd As SqlCommand
                Dim query = "delete from PatientTbl where DId = " & key & ""
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Patient Deleted Successfully")
                Con.Close()
                DisplayPatients()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        Try
            If key = 0 Or PNameTb.Text = "" Or PAgeTb.Text = "" Or PTellTb.Text = "" Or PAddressTb.Text = "" Then
                MsgBox("Incomplite Information")
            Else
                Con.Open()
                Dim query = "update DonorTbl set DName='" & PNameTb.Text & "',PAge='" & PAgeTb.Text & "',PGen='" & PGenCb.SelectedItem.ToString & "',PTell='" & PTellTb.Text & "',PBGroup='" & PBGroupCb.SelectedItem.ToString & "',PAddress='" & PAddressTb.Text & "' "
                Dim cmd As New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Patient Deleted Successfully")
                Con.Close()
                DisplayPatients()
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
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim Obj As New Patient()
        Obj.Show()

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