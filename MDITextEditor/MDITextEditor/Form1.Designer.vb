<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDITextEditorForm
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
        Me.toolTipTextEditor = New System.Windows.Forms.ToolTip(Me.components)
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditorOptions = New System.Windows.Forms.MenuStrip()
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtEditText = New System.Windows.Forms.RichTextBox()
        Me.mnuEditorOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(125, 26)
        Me.mnuAbout.Text = "&About"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(53, 24)
        Me.mnuHelp.Text = "&Help"
        '
        'mnuPaste
        '
        Me.mnuPaste.Name = "mnuPaste"
        Me.mnuPaste.Size = New System.Drawing.Size(192, 26)
        Me.mnuPaste.Text = "&Paste        Ctrl+V"
        '
        'mnuCut
        '
        Me.mnuCut.Name = "mnuCut"
        Me.mnuCut.Size = New System.Drawing.Size(192, 26)
        Me.mnuCut.Text = "Cu&t        Ctrl+X"
        '
        'mnuCopy
        '
        Me.mnuCopy.Name = "mnuCopy"
        Me.mnuCopy.Size = New System.Drawing.Size(192, 26)
        Me.mnuCopy.Text = "&Copy        Ctrl+C"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCopy, Me.mnuCut, Me.mnuPaste})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(47, 24)
        Me.mnuEdit.Text = "&Edit"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(196, 26)
        Me.mnuExit.Text = "E&xit"
        '
        'mnuSaveAs
        '
        Me.mnuSaveAs.Name = "mnuSaveAs"
        Me.mnuSaveAs.Size = New System.Drawing.Size(196, 26)
        Me.mnuSaveAs.Text = "Save &As"
        '
        'mnuSave
        '
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.Size = New System.Drawing.Size(196, 26)
        Me.mnuSave.Text = "&Save        Ctrl+S"
        '
        'mnuOpen
        '
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.Size = New System.Drawing.Size(196, 26)
        Me.mnuOpen.Text = "&Open        Ctrl+O"
        '
        'mnuNew
        '
        Me.mnuNew.Name = "mnuNew"
        Me.mnuNew.Size = New System.Drawing.Size(196, 26)
        Me.mnuNew.Text = "&New        Ctrl+N"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNew, Me.mnuOpen, Me.mnuSave, Me.mnuSaveAs, Me.mnuClose, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(44, 24)
        Me.mnuFile.Text = "&File"
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(196, 26)
        Me.mnuClose.Text = "&Close"
        '
        'mnuEditorOptions
        '
        Me.mnuEditorOptions.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuEditorOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuHelp})
        Me.mnuEditorOptions.Location = New System.Drawing.Point(0, 0)
        Me.mnuEditorOptions.Name = "mnuEditorOptions"
        Me.mnuEditorOptions.Size = New System.Drawing.Size(800, 28)
        Me.mnuEditorOptions.TabIndex = 3
        Me.mnuEditorOptions.Text = "MenuStrip1"
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(61, 4)
        '
        'txtEditText
        '
        Me.txtEditText.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.txtEditText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEditText.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditText.ForeColor = System.Drawing.Color.White
        Me.txtEditText.Location = New System.Drawing.Point(0, 28)
        Me.txtEditText.Name = "txtEditText"
        Me.txtEditText.Size = New System.Drawing.Size(800, 422)
        Me.txtEditText.TabIndex = 6
        Me.txtEditText.Text = ""
        '
        'MDITextEditorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtEditText)
        Me.Controls.Add(Me.mnuEditorOptions)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuEditorOptions
        Me.Name = "MDITextEditorForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MDI Text Editor"
        Me.mnuEditorOptions.ResumeLayout(False)
        Me.mnuEditorOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents toolTipTextEditor As ToolTip
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuPaste As ToolStripMenuItem
    Friend WithEvents mnuCut As ToolStripMenuItem
    Friend WithEvents mnuCopy As ToolStripMenuItem
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuSaveAs As ToolStripMenuItem
    Friend WithEvents mnuSave As ToolStripMenuItem
    Friend WithEvents mnuOpen As ToolStripMenuItem
    Friend WithEvents mnuNew As ToolStripMenuItem
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuClose As ToolStripMenuItem
    Friend WithEvents mnuEditorOptions As MenuStrip
    Friend WithEvents ContextMenuStrip As ContextMenuStrip
    Friend WithEvents txtEditText As RichTextBox
End Class
