Imports System.Data.SqlClient
Public Class UpdateDetails
    Dim Con As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mr. Roy Jabundani\Documents\EmployeeVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub UpdateDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub

    Private Sub backLoginBt_Click(sender As Object, e As EventArgs) Handles backLoginBt.Click
        Me.Hide()
        Dim UpDet = New Login
        UpDet.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BackRegistrationBt.Click
        Me.Hide()
        Dim regi = New register
        regi.Show()
    End Sub

    Private Sub Populate()
        Con.Open()
        Dim sql = "select * from UserAccountTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        UserAccountDVG.DataSource = ds.Tables(0)

        Con.Close()
    End Sub

    Private Sub editBt_Click(sender As Object, e As EventArgs) Handles editBt.Click
        If UserNameTb.Text = "" Or UserPhoneTb.Text = "" Or UserPassTb.Text = "" Or FullNameTb.Text = "" Or UserLevelCb.Text = "" Then
            MsgBox("Missing Some Information")
        Else
            Con.Open()
            Dim Query As String
            Query = "Update UserAccountTbl set UserName = '" & UserNameTb.Text & "',UserPhone = '" & UserPhoneTb.Text & "',UserLevel = '" & UserLevelCb.SelectedItem.ToString() & "',FullName = '" & FullNameTb.Text & "',UserPass = '" & UserPassTb.Text & "' where Id = " & Key & " "
            Dim cmd As New SqlCommand(Query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("User Account Details Updated Successfully")
            Con.Close()
            Populate()
        End If
    End Sub

    Dim Key = 0
    Private Sub Clear()
        UserNameTb.Clear()
        UserLevelCb.Text = ""
        UserPhoneTb.Text = ""
        UserPassTb.Text = ""
        Key = 0
        FullNameTb.Clear()

    End Sub

    Private Sub deletBt_Click(sender As Object, e As EventArgs) Handles deletBt.Click
        If Key = 0 Then
            MsgBox("Select the User Details to be deleted")
        Else
            Try
                Con.Open()
                Dim Query As String
                Query = "Delete from UseraccountTbl where Id = " & Key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(Query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("User Account Successfully Removed")
                Con.Close()
                Populate()
                Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub UserAccountDVG_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UserAccountDVG.CellContentClick
        Dim row As DataGridViewRow = UserAccountDVG.Rows(e.RowIndex)
        Key = Convert.ToInt32(row.Cells(0).Value.ToString())
        UserNameTb.Text = row.Cells(1).Value.ToString()
        UserPhoneTb.Text = row.Cells(2).Value.ToString()
        UserLevelCb.SelectedItem = row.Cells(3).Value.ToString()
        FullNameTb.Text = row.Cells(4).Value.ToString()
        UserPassTb.Text = row.Cells(5).Value.ToString()
    End Sub
End Class