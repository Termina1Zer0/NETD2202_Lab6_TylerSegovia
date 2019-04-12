<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TextEditorForm
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
        Me.components = New System.ComponentModel.Container()
        Me.tbEditText = New System.Windows.Forms.RichTextBox()
        Me.toolTipTextEditor = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'tbEditText
        '
        Me.tbEditText.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tbEditText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbEditText.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEditText.ForeColor = System.Drawing.Color.White
        Me.tbEditText.Location = New System.Drawing.Point(0, 0)
        Me.tbEditText.Name = "tbEditText"
        Me.tbEditText.Size = New System.Drawing.Size(800, 450)
        Me.tbEditText.TabIndex = 5
        Me.tbEditText.Text = ""
        Me.toolTipTextEditor.SetToolTip(Me.tbEditText, "Edit text here")
        '
        'TextEditorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tbEditText)
        Me.Name = "TextEditorForm"
        Me.Text = "New Text File"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbEditText As RichTextBox
    Friend WithEvents toolTipTextEditor As ToolTip
End Class
