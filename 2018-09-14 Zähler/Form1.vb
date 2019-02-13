Public Class Form1
    Private Sub cmdZähler_Click(sender As Object, e As EventArgs) Handles cmdZähler.Click
        Dim mA As Integer
        For mA = 1 To 4 Step 1
            MsgBox(mA)
        Next
        MsgBox("Ende")
    End Sub
End Class
