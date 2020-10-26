<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BTNADD = New System.Windows.Forms.Button()
        Me.TextFirValue = New System.Windows.Forms.TextBox()
        Me.TextSecValue = New System.Windows.Forms.TextBox()
        Me.TextResult = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BTNADD
        '
        Me.BTNADD.Location = New System.Drawing.Point(153, 110)
        Me.BTNADD.Name = "BTNADD"
        Me.BTNADD.Size = New System.Drawing.Size(95, 28)
        Me.BTNADD.TabIndex = 0
        Me.BTNADD.Text = "Add"
        Me.BTNADD.UseVisualStyleBackColor = True
        '
        'TextFirValue
        '
        Me.TextFirValue.Location = New System.Drawing.Point(32, 32)
        Me.TextFirValue.Name = "TextFirValue"
        Me.TextFirValue.Size = New System.Drawing.Size(96, 21)
        Me.TextFirValue.TabIndex = 1
        '
        'TextSecValue
        '
        Me.TextSecValue.Location = New System.Drawing.Point(32, 70)
        Me.TextSecValue.Name = "TextSecValue"
        Me.TextSecValue.Size = New System.Drawing.Size(96, 21)
        Me.TextSecValue.TabIndex = 2
        '
        'TextResult
        '
        Me.TextResult.Location = New System.Drawing.Point(32, 110)
        Me.TextResult.Name = "TextResult"
        Me.TextResult.Size = New System.Drawing.Size(95, 21)
        Me.TextResult.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 177)
        Me.Controls.Add(Me.TextResult)
        Me.Controls.Add(Me.TextSecValue)
        Me.Controls.Add(Me.TextFirValue)
        Me.Controls.Add(Me.BTNADD)
        Me.Name = "Form1"
        Me.Text = "第二章"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNADD As System.Windows.Forms.Button
    Friend WithEvents TextFirValue As System.Windows.Forms.TextBox
    Friend WithEvents TextSecValue As System.Windows.Forms.TextBox
    Friend WithEvents TextResult As System.Windows.Forms.TextBox

End Class
