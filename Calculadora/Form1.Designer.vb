<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)

        save()

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
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tab1 = New System.Windows.Forms.TabPage()
        Me.point = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.num0 = New System.Windows.Forms.Button()
        Me.num3 = New System.Windows.Forms.Button()
        Me.num6 = New System.Windows.Forms.Button()
        Me.num9 = New System.Windows.Forms.Button()
        Me.num2 = New System.Windows.Forms.Button()
        Me.num5 = New System.Windows.Forms.Button()
        Me.num8 = New System.Windows.Forms.Button()
        Me.num1 = New System.Windows.Forms.Button()
        Me.num4 = New System.Windows.Forms.Button()
        Me.num7 = New System.Windows.Forms.Button()
        Me.tx1 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lista = New System.Windows.Forms.ListBox()
        Me.Form1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.tab1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Form1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tab1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(148, 205)
        Me.TabControl1.TabIndex = 0
        '
        'tab1
        '
        Me.tab1.Controls.Add(Me.point)
        Me.tab1.Controls.Add(Me.Button7)
        Me.tab1.Controls.Add(Me.Button6)
        Me.tab1.Controls.Add(Me.Button5)
        Me.tab1.Controls.Add(Me.num0)
        Me.tab1.Controls.Add(Me.num3)
        Me.tab1.Controls.Add(Me.num6)
        Me.tab1.Controls.Add(Me.num9)
        Me.tab1.Controls.Add(Me.num2)
        Me.tab1.Controls.Add(Me.num5)
        Me.tab1.Controls.Add(Me.num8)
        Me.tab1.Controls.Add(Me.num1)
        Me.tab1.Controls.Add(Me.num4)
        Me.tab1.Controls.Add(Me.num7)
        Me.tab1.Controls.Add(Me.tx1)
        Me.tab1.Controls.Add(Me.Button4)
        Me.tab1.Controls.Add(Me.Button3)
        Me.tab1.Controls.Add(Me.Button2)
        Me.tab1.Controls.Add(Me.Button1)
        Me.tab1.Location = New System.Drawing.Point(4, 22)
        Me.tab1.Name = "tab1"
        Me.tab1.Padding = New System.Windows.Forms.Padding(3)
        Me.tab1.Size = New System.Drawing.Size(140, 179)
        Me.tab1.TabIndex = 0
        Me.tab1.Text = "Calculadora"
        Me.tab1.UseVisualStyleBackColor = True
        '
        'point
        '
        Me.point.Location = New System.Drawing.Point(7, 151)
        Me.point.Name = "point"
        Me.point.Size = New System.Drawing.Size(28, 23)
        Me.point.TabIndex = 24
        Me.point.Text = ","
        Me.point.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(41, 151)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(93, 23)
        Me.Button7.TabIndex = 22
        Me.Button7.Text = "="
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(75, 121)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(28, 23)
        Me.Button6.TabIndex = 21
        Me.Button6.Text = "CE"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(41, 121)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(28, 23)
        Me.Button5.TabIndex = 20
        Me.Button5.Text = "B"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'num0
        '
        Me.num0.Location = New System.Drawing.Point(7, 121)
        Me.num0.Name = "num0"
        Me.num0.Size = New System.Drawing.Size(28, 23)
        Me.num0.TabIndex = 19
        Me.num0.Text = "0"
        Me.num0.UseVisualStyleBackColor = True
        '
        'num3
        '
        Me.num3.Location = New System.Drawing.Point(75, 93)
        Me.num3.Name = "num3"
        Me.num3.Size = New System.Drawing.Size(28, 23)
        Me.num3.TabIndex = 18
        Me.num3.Text = "3"
        Me.num3.UseVisualStyleBackColor = True
        '
        'num6
        '
        Me.num6.Location = New System.Drawing.Point(75, 63)
        Me.num6.Name = "num6"
        Me.num6.Size = New System.Drawing.Size(28, 23)
        Me.num6.TabIndex = 17
        Me.num6.Text = "6"
        Me.num6.UseVisualStyleBackColor = True
        '
        'num9
        '
        Me.num9.Location = New System.Drawing.Point(75, 33)
        Me.num9.Name = "num9"
        Me.num9.Size = New System.Drawing.Size(28, 23)
        Me.num9.TabIndex = 16
        Me.num9.Text = "9"
        Me.num9.UseVisualStyleBackColor = True
        '
        'num2
        '
        Me.num2.Location = New System.Drawing.Point(41, 92)
        Me.num2.Name = "num2"
        Me.num2.Size = New System.Drawing.Size(28, 23)
        Me.num2.TabIndex = 15
        Me.num2.Text = "2"
        Me.num2.UseVisualStyleBackColor = True
        '
        'num5
        '
        Me.num5.Location = New System.Drawing.Point(41, 62)
        Me.num5.Name = "num5"
        Me.num5.Size = New System.Drawing.Size(28, 23)
        Me.num5.TabIndex = 14
        Me.num5.Text = "5"
        Me.num5.UseVisualStyleBackColor = True
        '
        'num8
        '
        Me.num8.Location = New System.Drawing.Point(41, 32)
        Me.num8.Name = "num8"
        Me.num8.Size = New System.Drawing.Size(28, 23)
        Me.num8.TabIndex = 13
        Me.num8.Text = "8"
        Me.num8.UseVisualStyleBackColor = True
        '
        'num1
        '
        Me.num1.Location = New System.Drawing.Point(7, 92)
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(28, 23)
        Me.num1.TabIndex = 12
        Me.num1.Text = "1"
        Me.num1.UseVisualStyleBackColor = True
        '
        'num4
        '
        Me.num4.Location = New System.Drawing.Point(7, 62)
        Me.num4.Name = "num4"
        Me.num4.Size = New System.Drawing.Size(28, 23)
        Me.num4.TabIndex = 11
        Me.num4.Text = "4"
        Me.num4.UseVisualStyleBackColor = True
        '
        'num7
        '
        Me.num7.Location = New System.Drawing.Point(7, 32)
        Me.num7.Name = "num7"
        Me.num7.Size = New System.Drawing.Size(28, 23)
        Me.num7.TabIndex = 10
        Me.num7.Text = "7"
        Me.num7.UseVisualStyleBackColor = True
        '
        'tx1
        '
        Me.tx1.Location = New System.Drawing.Point(8, 6)
        Me.tx1.Name = "tx1"
        Me.tx1.Size = New System.Drawing.Size(126, 20)
        Me.tx1.TabIndex = 8
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(109, 63)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(25, 23)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "+"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(109, 93)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(25, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "-"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(109, 33)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "/"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(109, 121)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lista)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(140, 179)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Historial"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lista
        '
        Me.lista.FormattingEnabled = True
        Me.lista.Location = New System.Drawing.Point(0, 0)
        Me.lista.Name = "lista"
        Me.lista.Size = New System.Drawing.Size(140, 186)
        Me.lista.TabIndex = 0
        '
        'Form1BindingSource
        '
        Me.Form1BindingSource.DataSource = GetType(WindowsApplication1.Form1)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(148, 205)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.tab1.ResumeLayout(False)
        Me.tab1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Form1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tab1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tx1 As System.Windows.Forms.TextBox
    Friend WithEvents num0 As System.Windows.Forms.Button
    Friend WithEvents num3 As System.Windows.Forms.Button
    Friend WithEvents num6 As System.Windows.Forms.Button
    Friend WithEvents num9 As System.Windows.Forms.Button
    Friend WithEvents num2 As System.Windows.Forms.Button
    Friend WithEvents num5 As System.Windows.Forms.Button
    Friend WithEvents num8 As System.Windows.Forms.Button
    Friend WithEvents num1 As System.Windows.Forms.Button
    Friend WithEvents num4 As System.Windows.Forms.Button
    Friend WithEvents num7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents point As System.Windows.Forms.Button
    Friend WithEvents lista As System.Windows.Forms.ListBox
    Friend WithEvents Form1BindingSource As System.Windows.Forms.BindingSource

End Class
