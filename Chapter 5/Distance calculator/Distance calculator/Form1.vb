Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblDistanceTraveled As Double
        Dim dblX As Double

        dblX = 0
        Do While dblX < CDbl(txtHours.Text)
            dblX = dblX + 1
            dblDistanceTraveled = (txtSpeed.Text) * dblX
            listResults.Items.Add(dblX.ToString + "        " + dblDistanceTraveled.ToString)
        Loop
        listResults.Items.Add("Total Distance: " + dblDistanceTraveled.ToString)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
