Public Class Form1

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim intPick As Integer
        Dim intFinal As Integer
        intPick = InputBox("Enter number.")
        For i As Integer = 0 To intPick
            intFinal += i
        Next
        MessageBox.Show("The summ of the number 1 through 10 is " & intFinal.ToString())
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
