Public Class Form1
    Dim headsTotal As Integer
    Dim tailTotal As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFlip.Click
        Dim intSideUp As Integer
        Dim rand As New Random
        intSideUp = rand.Next(2)
        If intSideUp = 0 Then
            PictureBoxTails.Visible = True
            PictureBoxHeads.Visible = False
            tailTotal = 1 + tailTotal
        Else
            PictureBoxHeads.Visible = True
            PictureBoxTails.Visible = False
            headsTotal = 1 + headsTotal

        End If
        lblHeadTotal.Text = headsTotal.ToString
        lblTailTotal.Text = tailTotal.ToString
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
