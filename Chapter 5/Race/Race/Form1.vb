Public Class Form1
    Dim ChristineResult As Integer
    Dim FallonResult As Integer
    Dim KaleyResult As Integer

    Private Sub btnRace_Click(sender As Object, e As EventArgs) Handles btnRace.Click
        Dim intWinner As Integer
        Dim intCount, intCount1, intCount2 As Integer
        Dim rand As New Random
        intWinner = rand.Next(3)

        For intCount = 93 To 430
            picboxChristine1.Left = intCount
            '    ChristineResult = ChristineResult + 1
        Next
        For intCount2 = 93 To rand.Next(50) + 300
            picboxFallon1.Left = intCount
            '    FallonResult = FallonResult + 1
        Next
        For intCount1 = 93 To rand.Next(50) + 300
            picboxKaley1.Left = intCount1
            '   KaleyResult = KaleyResult + 1
        Next
        PictureBox1.Visible = True
        PictureBox2.Visible = False
        If intCount > intCount1 And intCount2 Then
            ChristineResult = ChristineResult + 1
        ElseIf intCount1 > intCount And intCount2 Then
            KaleyResult = KaleyResult + 1
        ElseIf intCount2 > intCount And intCount1 Then
            FallonResult = FallonResult + 1
        End If
        lblChristineResult.Text = ChristineResult.ToString
        lblFallonResult.Text = FallonResult.ToString
        lblKaleyResult.Text = KaleyResult.ToString
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
