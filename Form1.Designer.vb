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
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Lbl2 = New System.Windows.Forms.Label()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.Lbl3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Btn4 = New System.Windows.Forms.Button()
        Me.Lbl4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn1
        '
        Me.Btn1.Location = New System.Drawing.Point(31, 46)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(75, 23)
        Me.Btn1.TabIndex = 0
        Me.Btn1.Text = "Click"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.Location = New System.Drawing.Point(40, 96)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(51, 17)
        Me.Lbl1.TabIndex = 1
        Me.Lbl1.Text = "Label1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(158, 46)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 2
        '
        'Btn2
        '
        Me.Btn2.Location = New System.Drawing.Point(172, 90)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(75, 23)
        Me.Btn2.TabIndex = 3
        Me.Btn2.Text = "Click"
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'Lbl2
        '
        Me.Lbl2.AutoSize = True
        Me.Lbl2.Location = New System.Drawing.Point(183, 122)
        Me.Lbl2.Name = "Lbl2"
        Me.Lbl2.Size = New System.Drawing.Size(51, 17)
        Me.Lbl2.TabIndex = 4
        Me.Lbl2.Text = "Label2"
        '
        'Btn3
        '
        Me.Btn3.Location = New System.Drawing.Point(311, 44)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(75, 23)
        Me.Btn3.TabIndex = 5
        Me.Btn3.Text = "Click"
        Me.Btn3.UseVisualStyleBackColor = True
        '
        'Lbl3
        '
        Me.Lbl3.AutoSize = True
        Me.Lbl3.Location = New System.Drawing.Point(322, 90)
        Me.Lbl3.Name = "Lbl3"
        Me.Lbl3.Size = New System.Drawing.Size(51, 17)
        Me.Lbl3.TabIndex = 6
        Me.Lbl3.Text = "Label3"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(431, 47)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 7
        '
        'Btn4
        '
        Me.Btn4.Location = New System.Drawing.Point(441, 87)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(75, 23)
        Me.Btn4.TabIndex = 8
        Me.Btn4.Text = "Click"
        Me.Btn4.UseVisualStyleBackColor = True
        '
        'Lbl4
        '
        Me.Lbl4.AutoSize = True
        Me.Lbl4.Location = New System.Drawing.Point(450, 122)
        Me.Lbl4.Name = "Lbl4"
        Me.Lbl4.Size = New System.Drawing.Size(51, 17)
        Me.Lbl4.TabIndex = 9
        Me.Lbl4.Text = "Label4"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 296)
        Me.Controls.Add(Me.Lbl4)
        Me.Controls.Add(Me.Btn4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Lbl3)
        Me.Controls.Add(Me.Btn3)
        Me.Controls.Add(Me.Lbl2)
        Me.Controls.Add(Me.Btn2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Lbl1)
        Me.Controls.Add(Me.Btn1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn1 As Button
    Friend WithEvents Lbl1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Btn2 As Button
    Friend WithEvents Lbl2 As Label
    Friend WithEvents Btn3 As Button
    Friend WithEvents Lbl3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Btn4 As Button
    Friend WithEvents Lbl4 As Label
End Class
