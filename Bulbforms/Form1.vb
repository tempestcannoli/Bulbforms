Imports onoffbutton
Imports Lightbulb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

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

    'Private Sub UCtrlButton1_Click(sender As Object, e As EventArgs) Handles UCtrlButton1.Click
    'ei tööta
    '    If (intChange = 0) Then
    '        UBulb2.setMood("off")
    '        intChange = 1
    '    ElseIf (intChange = 1) Then
    '        UBulb2.setMood("on")
    '        intChange = 0
    '    End If
    'End Sub





End Class
