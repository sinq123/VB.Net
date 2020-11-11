<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class firFile
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnMove = New System.Windows.Forms.Button()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.lblDestiation = New System.Windows.Forms.Label()
        Me.lblSource = New System.Windows.Forms.Label()
        Me.txtSource = New System.Windows.Forms.TextBox()
        Me.txtDestination = New System.Windows.Forms.TextBox()
        Me.OpenDiglog = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(262, 125)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 0
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnMove
        '
        Me.btnMove.Location = New System.Drawing.Point(155, 125)
        Me.btnMove.Name = "btnMove"
        Me.btnMove.Size = New System.Drawing.Size(75, 23)
        Me.btnMove.TabIndex = 1
        Me.btnMove.Text = "Move"
        Me.btnMove.UseVisualStyleBackColor = True
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(48, 125)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(75, 23)
        Me.btnCopy.TabIndex = 2
        Me.btnCopy.Text = "Copy"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'lblDestiation
        '
        Me.lblDestiation.AutoSize = True
        Me.lblDestiation.Location = New System.Drawing.Point(56, 51)
        Me.lblDestiation.Name = "lblDestiation"
        Me.lblDestiation.Size = New System.Drawing.Size(65, 12)
        Me.lblDestiation.TabIndex = 3
        Me.lblDestiation.Text = "Destiation"
        '
        'lblSource
        '
        Me.lblSource.AutoSize = True
        Me.lblSource.Location = New System.Drawing.Point(56, 20)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Size = New System.Drawing.Size(41, 12)
        Me.lblSource.TabIndex = 4
        Me.lblSource.Text = "Source"
        '
        'txtSource
        '
        Me.txtSource.Location = New System.Drawing.Point(130, 11)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(100, 21)
        Me.txtSource.TabIndex = 5
        Me.txtSource.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtDestination
        '
        Me.txtDestination.Location = New System.Drawing.Point(130, 48)
        Me.txtDestination.Name = "txtDestination"
        Me.txtDestination.Size = New System.Drawing.Size(100, 21)
        Me.txtDestination.TabIndex = 6
        '
        'OpenDiglog
        '
        Me.OpenDiglog.Location = New System.Drawing.Point(262, 69)
        Me.OpenDiglog.Name = "OpenDiglog"
        Me.OpenDiglog.Size = New System.Drawing.Size(88, 25)
        Me.OpenDiglog.TabIndex = 7
        Me.OpenDiglog.Text = "OpendigLog"
        Me.OpenDiglog.UseVisualStyleBackColor = True
        '
        'firFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 170)
        Me.Controls.Add(Me.OpenDiglog)
        Me.Controls.Add(Me.txtDestination)
        Me.Controls.Add(Me.txtSource)
        Me.Controls.Add(Me.lblSource)
        Me.Controls.Add(Me.lblDestiation)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.btnMove)
        Me.Controls.Add(Me.btnDelete)
        Me.Name = "firFile"
        Me.Text = "11111111"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDelete As Button
    Friend WithEvents btnMove As Button
    Friend WithEvents btnCopy As Button
    Friend WithEvents lblDestiation As Label
    Friend WithEvents lblSource As Label
    Friend WithEvents txtSource As TextBox
    Friend WithEvents txtDestination As TextBox
    Friend WithEvents OpenDiglog As Button
End Class
