<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.UBulb1 = New Lightbulb.UBulb()
        Me.UBulb2 = New Lightbulb.UBulb()
        Me.UCtrlButton1 = New onoffbutton.UCtrlButton()
        Me.SuspendLayout()
        '
        'UBulb1
        '
        Me.UBulb1.Location = New System.Drawing.Point(0, 0)
        Me.UBulb1.Name = "UBulb1"
        Me.UBulb1.Size = New System.Drawing.Size(800, 450)
        Me.UBulb1.TabIndex = 0
        '
        'UBulb2
        '
        Me.UBulb2.Location = New System.Drawing.Point(32, 20)
        Me.UBulb2.Name = "UBulb2"
        Me.UBulb2.Size = New System.Drawing.Size(506, 519)
        Me.UBulb2.TabIndex = 1
        '
        'UCtrlButton1
        '
        Me.UCtrlButton1.Location = New System.Drawing.Point(607, 181)
        Me.UCtrlButton1.Name = "UCtrlButton1"
        Me.UCtrlButton1.Size = New System.Drawing.Size(273, 196)
        Me.UCtrlButton1.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 551)
        Me.Controls.Add(Me.UCtrlButton1)
        Me.Controls.Add(Me.UBulb2)
        Me.Controls.Add(Me.UBulb1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UBulb1 As Lightbulb.UBulb
    Friend WithEvents UBulb2 As Lightbulb.UBulb
    Friend WithEvents UCtrlButton1 As onoffbutton.UCtrlButton
End Class
