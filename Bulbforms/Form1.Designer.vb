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
        Me.btnOff = New System.Windows.Forms.Button()
        Me.btnOn = New System.Windows.Forms.Button()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.btnTest2 = New System.Windows.Forms.Button()
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
        'btnOff
        '
        Me.btnOff.Location = New System.Drawing.Point(607, 34)
        Me.btnOff.Name = "btnOff"
        Me.btnOff.Size = New System.Drawing.Size(75, 23)
        Me.btnOff.TabIndex = 2
        Me.btnOff.Text = "Off"
        Me.btnOff.UseVisualStyleBackColor = True
        '
        'btnOn
        '
        Me.btnOn.Location = New System.Drawing.Point(607, 92)
        Me.btnOn.Name = "btnOn"
        Me.btnOn.Size = New System.Drawing.Size(75, 23)
        Me.btnOn.TabIndex = 3
        Me.btnOn.Text = "On"
        Me.btnOn.UseVisualStyleBackColor = True
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(805, 484)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(75, 23)
        Me.btnTest.TabIndex = 5
        Me.btnTest.Text = "On"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'btnTest2
        '
        Me.btnTest2.Location = New System.Drawing.Point(805, 438)
        Me.btnTest2.Name = "btnTest2"
        Me.btnTest2.Size = New System.Drawing.Size(75, 23)
        Me.btnTest2.TabIndex = 6
        Me.btnTest2.Text = "Off"
        Me.btnTest2.UseVisualStyleBackColor = True
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
        Me.Controls.Add(Me.btnTest2)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.UCtrlButton1)
        Me.Controls.Add(Me.btnOn)
        Me.Controls.Add(Me.btnOff)
        Me.Controls.Add(Me.UBulb2)
        Me.Controls.Add(Me.UBulb1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UBulb1 As Lightbulb.UBulb
    Friend WithEvents UBulb2 As Lightbulb.UBulb
    Friend WithEvents btnOff As Button
    Friend WithEvents btnOn As Button
    Friend WithEvents UCtrlButton1 As onoffbutton.UCtrlButton
    Friend WithEvents btnTest As Button
    Friend WithEvents btnTest2 As Button
End Class
