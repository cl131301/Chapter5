Public Class Form1

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim strInput As String
        Dim IntCount As Integer = 0
        Dim IntInput As Integer
        Dim IntNumScore As Integer

        strInput = InputBox("Enter a positive interger value.", "Input Needed", "10")

        If Integer.TryParse(strInput, IntInput) And IsNumeric(strInput) And IntNumScore >= 0 Then
            For IntCounter As Integer = 1 To IntNumScore
                IntCount += IntCounter
            Next
            MessageBox.Show("The sum of the numbers 1 through " & IntInput & " is " & IntNumScore)
        ElseIf Integer.TryParse(strInput, IntInput) Then
            If IntInput < 0 Then
                MessageBox.Show("Please input positive number.")
            Else
                Do Until IntCount = IntInput
                    strInput += 1
                    IntNumScore += IntCount
                Loop
                MessageBox.Show("Please input a valid number.")
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
