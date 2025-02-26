Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClickme.Click
        Timer1.Enabled = True
        btnClickme.Text = btnClickme.Text + 1
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Lblcount.Text = Lblcount.Text - 1
        If Lblcount.Text = 0 Then
            Timer1.Enabled = False
            btnClickme.Enabled = False
            RestartToolStripMenuItem.Enabled = True
        End If

    End Sub

    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        btnClickme.Enabled = True
        btnClickme.Text = "0"
        Lblcount.Text = "5"
        RestartToolStripMenuItem.Enabled = False
    End Sub

End Class
