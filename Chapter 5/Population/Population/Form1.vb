Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dblTotal As Double
        Dim intCount As Integer

        lstOutput.Items.Add("Day   Approximate Population")
        lstOutput.Items.Add("-----------------------------------")
        dblTotal = 2
        intCount = 1
        Dim intCount1 As Integer = 0

        cboxOrganisims.Items.Add(intCount.ToString + " " + dblTotal.ToString)

        For intCount = intCount + 1 To cboxDays.Text

            dblTotal = (CDbl(txtIncreasePercent.Text * dblTotal) / 100) + dblTotal
            lstOutput.Items.Add(intCount.ToString + "        " + dblTotal.ToString)
        Next

    End Sub

    Private Function tOutput() As Object
        Throw New NotImplementedException
    End Function

End Class
