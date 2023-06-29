Imports System.Data.SqlClient
Public Class Employee

    Dim Con As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mr. Roy Jabundani\Documents\EmployeeVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub
    Private Sub Populate()
        Con.Open()
        Dim sql = "select * from EmployeeTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        EmployeeDGV.DataSource = ds.Tables(0)

        Con.Close()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Con.Open()

        Dim Query As String
        Query = "insert into EmployeeTbl values('" & EmpNameTb.Text & "','" & EmpAdd.Text & "','" & PosCb.SelectedItem.ToString() & "','" & EmpDOB.Value & "','" & EmpPhoneTb.Text & "','" & EduCb.SelectedItem.ToString() & "','" & GendCb.SelectedItem.ToString() & "')"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(Query, Con)
        cmd.ExecuteNonQuery()
        MsgBox("Added and Employee Just Now")


        Con.Close()
    End Sub
    Dim Key = 0
    Private Sub Clear()
        EmpNameTb.Clear()
        PosCb.Text = ""
        GendCb.Text = ""
        EmpAdd.Text = ""
        Key = 0
        EduCb.Text = ""
        EmpPhoneTb.Text = ""
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Key = 0 Then
            MsgBox("Select the Employee to be deleted")
        Else
            Try
                Con.Open()
                Dim Query As String
                Query = "Delete from EmployeeTbl where EmpId = " & Key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(Query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Employee Successfuly Removed From Database")
                Con.Close()
                Populate()
                Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
           
        End If
    End Sub

    Private Sub EmployeeDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles EmployeeDGV.CellMouseClick
        Dim row As DataGridViewRow = EmployeeDGV.Rows(e.RowIndex)
        Key = Convert.ToInt32(row.Cells(0).Value.ToString())
        EmpNameTb.Text = row.Cells(1).Value.ToString()
        EmpAdd.Text = row.Cells(2).Value.ToString()
        PosCb.SelectedItem = row.Cells(3).Value.ToString()
        EmpDOB.Value = row.Cells(4).Value.ToString()
        EmpPhoneTb.Text = row.Cells(5).Value.ToString()
        EduCb.SelectedItem = row.Cells(6).Value.ToString()
        GendCb.SelectedItem = row.Cells(7).Value.ToString()

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        Dim MnF = New MainForm
        MnF.Show()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If EmpNameTb.Text = "" Or EmpPhoneTb.Text = "" Or EmpAdd.Text = "" Then
            MsgBox("Missing Information")
        Else
            Con.Open()
            Dim Query As String
            Query = "Update EmployeeTbl set EmpName = '" & EmpNameTb.Text & "',EmpAdd = '" & EmpAdd.Text & "',EmpPos = '" & PosCb.SelectedItem.ToString() & "',EmpDob = '" & EmpDOB.Value & "',EmpPhone = '" & EmpPhoneTb.Text & "', EmpEdu = '" & EduCb.SelectedItem.ToString() & "',EmpGend = '" & GendCb.SelectedItem.ToString() & "' where EmpId = " & Key & " "
            Dim cmd As New SqlCommand(Query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Employee Updated well")
            Con.Close()
            Populate()
        End If
    End Sub
  
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub EmpPhoneTb_TextChanged(sender As Object, e As EventArgs) Handles EmpPhoneTb.TextChanged

    End Sub
  

End Class