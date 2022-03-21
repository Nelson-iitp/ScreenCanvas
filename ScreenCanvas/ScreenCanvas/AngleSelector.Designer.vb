<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AngleSelector
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.text_inputAngle = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'text_inputAngle
        '
        Me.text_inputAngle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.text_inputAngle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_inputAngle.Location = New System.Drawing.Point(2, 2)
        Me.text_inputAngle.Margin = New System.Windows.Forms.Padding(0)
        Me.text_inputAngle.Name = "text_inputAngle"
        Me.text_inputAngle.Size = New System.Drawing.Size(146, 13)
        Me.text_inputAngle.TabIndex = 0
        Me.text_inputAngle.TabStop = False
        Me.text_inputAngle.Visible = False
        '
        'AngleSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.text_inputAngle)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "AngleSelector"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents text_inputAngle As System.Windows.Forms.TextBox

End Class
