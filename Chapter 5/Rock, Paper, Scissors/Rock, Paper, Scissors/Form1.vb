Public Class Form1
    Dim RockTotal As Integer
    Dim PaperTotal As Integer
    Dim ScissorTotal As Integer

    Private Sub btnShoot_Click(sender As Object, e As EventArgs) Handles btnShoot.Click
        Dim intShoot As Integer
        Dim rand As New Random
        intShoot = rand.Next(3)
        If intShoot = 0 Then
            picboxPaper.Visible = True
            picboxRock.Visible = False
            picboxScissors.Visible = False
            PaperTotal = 1 + PaperTotal

        ElseIf intShoot = 1 Then
            picboxRock.Visible = True
            picboxPaper.Visible = False
            picboxScissors.Visible = False
            RockTotal = 1 + RockTotal

        ElseIf intShoot = 2 Then
            picboxScissors.Visible = True
            picboxPaper.Visible = False
            picboxRock.Visible = False
            ScissorTotal = 1 + ScissorTotal
        End If
        lblPaperTotal.Text = PaperTotal.ToString
        lblRockTotal.Text = RockTotal.ToString
        lblScissorTotal.Text = ScissorTotal.ToString
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
