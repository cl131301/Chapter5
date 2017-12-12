Public Class Form1
    Dim counter As Integer
    Dim compGen As Integer
    Dim CorrectGuess As Integer
    Dim UncorrectGuess As Integer

    Private Sub GuessNum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Number As New Random
        compGen = Number.Next(100) + 1
        counter = 0
        txtUserGuess.Text = ("")
    End Sub

    Private Sub btnGuess_Click(sender As Object, e As EventArgs) Handles btnGuess.Click
        Dim UserGuess As Integer
        UserGuess = CInt(txtUserGuess.Text)
        counter = counter + 1
        Try
            If UserGuess = compGen Then
                MessageBox.Show("Well done! You guessed my number.")
                CorrectGuess = CorrectGuess + 1
            ElseIf UserGuess < compGen Then
                MessageBox.Show("Sorry your number is too low.")
                UncorrectGuess = UncorrectGuess + 1
            ElseIf UserGuess > compGen Then
                MessageBox.Show("Sorry your number is too high.")
                UncorrectGuess = UncorrectGuess + 1
            End If
        Catch ex As Exception
            MessageBox.Show("Please enter a valid number and try again.")
        End Try
        lblCorrect.Text = CorrectGuess.ToString
        lblUncorrect.Text = UncorrectGuess.ToString

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
