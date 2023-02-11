Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOff.Click
        UBulb2.setMood("off")
    End Sub

    Private Sub btnOn_Click(sender As Object, e As EventArgs) Handles btnOn.Click
        UBulb2.setMood("on")
    End Sub

    Private Sub btnTest2_Click(sender As Object, e As EventArgs) Handles btnTest2.Click
        UCtrlButton1.setMood("off")
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        UCtrlButton1.setMood("on")
    End Sub
End Class
