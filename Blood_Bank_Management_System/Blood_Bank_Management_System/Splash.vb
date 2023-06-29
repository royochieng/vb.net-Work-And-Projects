Public Class Splash

    
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            MyProgressBar.Increment(1)
            Dim Percentage
            Percentage = MyProgressBar.Value.ToString()
            Dim Per As String
            Per = Percentage + "%"
            PercentageLbl.Text = Per
            If MyProgressBar.Value = 100 Then
                Me.Hide()
                Dim Obj As New loadin
                Obj.Show()
                Timer1.Enabled = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
