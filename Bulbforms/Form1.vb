Imports onoffbutton
Imports Lightbulb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        UBulb2.setMood("off")
    End Sub

    Private Sub btnOn_Click(sender As Object, e As EventArgs)
        UBulb2.setMood("on")
    End Sub

    Private Sub btnTest2_Click(sender As Object, e As EventArgs)
        UCtrlButton1.setMood("off")
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs)
        UCtrlButton1.setMood("on")
    End Sub

    Private Sub UCtrlButton1_Click() Handles UCtrlButton1.Pressed
        If (intChange = 0) Then
            UBulb2.setMood("on")
            intChange = 1
        ElseIf (intChange = 1) Then
            UBulb2.setMood("off")
            intChange = 0
        End If
    End Sub





End Class
