Public Class Dashboard

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Dim log = New Login
        log.Show()
    End Sub
End Class