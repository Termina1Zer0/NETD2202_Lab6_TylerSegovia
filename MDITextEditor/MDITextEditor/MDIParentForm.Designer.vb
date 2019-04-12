<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MDIParentForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIParentForm))
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
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditorOptions = New System.Windows.Forms.MenuStrip()
        Me.mnuWindows = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCascade = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTileVertical = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTileHorizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuAverageUnitsShipped = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuParentContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.toolStripParent = New System.Windows.Forms.ToolStrip()
        Me.toolStripNew = New System.Windows.Forms.ToolStripButton()
        Me.toolStripOpen = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSave = New System.Windows.Forms.ToolStripButton()
        Me.toolStripAverageUnitsShipped = New System.Windows.Forms.ToolStripButton()
        Me.mnuEditorOptions.SuspendLayout()
        Me.toolStripParent.SuspendLayout()
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
        Me.mnuAbout.ToolTipText = "Info about the application"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(53, 24)
        Me.mnuHelp.Text = "&Help"
        Me.mnuHelp.ToolTipText = "See all Help options"
        '
        'mnuPaste
        '
        Me.mnuPaste.Name = "mnuPaste"
        Me.mnuPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuPaste.Size = New System.Drawing.Size(169, 26)
        Me.mnuPaste.Text = "&Paste"
        Me.mnuPaste.ToolTipText = "Paste highlighted text"
        '
        'mnuCut
        '
        Me.mnuCut.Name = "mnuCut"
        Me.mnuCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuCut.Size = New System.Drawing.Size(169, 26)
        Me.mnuCut.Text = "Cu&t"
        Me.mnuCut.ToolTipText = "Cut highlighted text"
        '
        'mnuCopy
        '
        Me.mnuCopy.Name = "mnuCopy"
        Me.mnuCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuCopy.Size = New System.Drawing.Size(169, 26)
        Me.mnuCopy.Text = "&Copy"
        Me.mnuCopy.ToolTipText = "Copy highlighted text"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCopy, Me.mnuCut, Me.mnuPaste})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(47, 24)
        Me.mnuEdit.Text = "&Edit"
        Me.mnuEdit.ToolTipText = "See all Edit options"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(216, 26)
        Me.mnuExit.Text = "E&xit"
        Me.mnuExit.ToolTipText = "Close the application"
        '
        'mnuSaveAs
        '
        Me.mnuSaveAs.Name = "mnuSaveAs"
        Me.mnuSaveAs.Size = New System.Drawing.Size(216, 26)
        Me.mnuSaveAs.Text = "Save &As"
        Me.mnuSaveAs.ToolTipText = "Save and name the current file"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNew, Me.mnuOpen, Me.ToolStripMenuItem1, Me.mnuSave, Me.mnuSaveAs, Me.ToolStripMenuItem2, Me.mnuClose, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(44, 24)
        Me.mnuFile.Text = "&File"
        Me.mnuFile.ToolTipText = "See all File options"
        '
        'mnuNew
        '
        Me.mnuNew.Image = Global.MDITextEditor.My.Resources.Resources._new
        Me.mnuNew.Name = "mnuNew"
        Me.mnuNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuNew.Size = New System.Drawing.Size(216, 26)
        Me.mnuNew.Text = "&New"
        Me.mnuNew.ToolTipText = "Create a new file"
        '
        'mnuOpen
        '
        Me.mnuOpen.Image = Global.MDITextEditor.My.Resources.Resources._open
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuOpen.Size = New System.Drawing.Size(216, 26)
        Me.mnuOpen.Text = "&Open"
        Me.mnuOpen.ToolTipText = "Open an existing file"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(213, 6)
        '
        'mnuSave
        '
        Me.mnuSave.Image = Global.MDITextEditor.My.Resources.Resources._save
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSave.Size = New System.Drawing.Size(216, 26)
        Me.mnuSave.Text = "&Save"
        Me.mnuSave.ToolTipText = "Save the current file "
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(213, 6)
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(216, 26)
        Me.mnuClose.Text = "&Close"
        Me.mnuClose.ToolTipText = "Close the current file"
        '
        'mnuEditorOptions
        '
        Me.mnuEditorOptions.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuEditorOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuWindows, Me.mnuHelp})
        Me.mnuEditorOptions.Location = New System.Drawing.Point(0, 0)
        Me.mnuEditorOptions.MdiWindowListItem = Me.mnuWindows
        Me.mnuEditorOptions.Name = "mnuEditorOptions"
        Me.mnuEditorOptions.Size = New System.Drawing.Size(1030, 28)
        Me.mnuEditorOptions.TabIndex = 0
        Me.mnuEditorOptions.Text = "mnuParentFormMenu"
        '
        'mnuWindows
        '
        Me.mnuWindows.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCascade, Me.mnuTileVertical, Me.mnuTileHorizontal, Me.ToolStripMenuItem3, Me.mnuAverageUnitsShipped, Me.ToolStripMenuItem4})
        Me.mnuWindows.Name = "mnuWindows"
        Me.mnuWindows.Size = New System.Drawing.Size(82, 24)
        Me.mnuWindows.Text = "&Windows"
        Me.mnuWindows.ToolTipText = "See all Windows options"
        '
        'mnuCascade
        '
        Me.mnuCascade.Name = "mnuCascade"
        Me.mnuCascade.Size = New System.Drawing.Size(235, 26)
        Me.mnuCascade.Text = "&Cascade"
        Me.mnuCascade.ToolTipText = "Layout open files in cascade mode"
        '
        'mnuTileVertical
        '
        Me.mnuTileVertical.Name = "mnuTileVertical"
        Me.mnuTileVertical.Size = New System.Drawing.Size(235, 26)
        Me.mnuTileVertical.Text = "Tile &Vertical"
        Me.mnuTileVertical.ToolTipText = "Layout open files in tile vertical mode"
        '
        'mnuTileHorizontal
        '
        Me.mnuTileHorizontal.Name = "mnuTileHorizontal"
        Me.mnuTileHorizontal.Size = New System.Drawing.Size(235, 26)
        Me.mnuTileHorizontal.Text = "Tile &Horizontal"
        Me.mnuTileHorizontal.ToolTipText = "Layout all open files in tile horizontal mode"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(232, 6)
        '
        'mnuAverageUnitsShipped
        '
        Me.mnuAverageUnitsShipped.Name = "mnuAverageUnitsShipped"
        Me.mnuAverageUnitsShipped.Size = New System.Drawing.Size(235, 26)
        Me.mnuAverageUnitsShipped.Text = "Average &Units Shipped"
        Me.mnuAverageUnitsShipped.ToolTipText = "Open the Average Units Shipped calculator"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(232, 6)
        '
        'mnuParentContextMenu
        '
        Me.mnuParentContextMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuParentContextMenu.Name = "ContextMenuStrip1"
        Me.mnuParentContextMenu.Size = New System.Drawing.Size(61, 4)
        '
        'toolStripParent
        '
        Me.toolStripParent.ContextMenuStrip = Me.mnuParentContextMenu
        Me.toolStripParent.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolStripParent.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripNew, Me.toolStripOpen, Me.toolStripSave, Me.toolStripAverageUnitsShipped})
        Me.toolStripParent.Location = New System.Drawing.Point(0, 28)
        Me.toolStripParent.Name = "toolStripParent"
        Me.toolStripParent.Size = New System.Drawing.Size(1030, 27)
        Me.toolStripParent.TabIndex = 1
        Me.toolStripParent.Text = "ToolStrip1"
        '
        'toolStripNew
        '
        Me.toolStripNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStripNew.Image = Global.MDITextEditor.My.Resources.Resources._new
        Me.toolStripNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripNew.Name = "toolStripNew"
        Me.toolStripNew.Size = New System.Drawing.Size(24, 24)
        Me.toolStripNew.Text = "ToolStripButton1"
        Me.toolStripNew.ToolTipText = "Create a new file"
        '
        'toolStripOpen
        '
        Me.toolStripOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStripOpen.Image = Global.MDITextEditor.My.Resources.Resources._open
        Me.toolStripOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripOpen.Name = "toolStripOpen"
        Me.toolStripOpen.Size = New System.Drawing.Size(24, 24)
        Me.toolStripOpen.Text = "ToolStripButton2"
        Me.toolStripOpen.ToolTipText = "Open an existing file"
        '
        'toolStripSave
        '
        Me.toolStripSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStripSave.Image = Global.MDITextEditor.My.Resources.Resources._save
        Me.toolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripSave.Name = "toolStripSave"
        Me.toolStripSave.Size = New System.Drawing.Size(24, 24)
        Me.toolStripSave.Text = "ToolStripButton3"
        Me.toolStripSave.ToolTipText = "Save the current file"
        '
        'toolStripAverageUnitsShipped
        '
        Me.toolStripAverageUnitsShipped.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStripAverageUnitsShipped.Image = Global.MDITextEditor.My.Resources.Resources._calc
        Me.toolStripAverageUnitsShipped.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripAverageUnitsShipped.Name = "toolStripAverageUnitsShipped"
        Me.toolStripAverageUnitsShipped.Size = New System.Drawing.Size(24, 24)
        Me.toolStripAverageUnitsShipped.Text = "ToolStripButton4"
        Me.toolStripAverageUnitsShipped.ToolTipText = "Open the Average Units Shipped Calculator"
        '
        'MDIParentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 597)
        Me.Controls.Add(Me.toolStripParent)
        Me.Controls.Add(Me.mnuEditorOptions)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuEditorOptions
        Me.Name = "MDIParentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MDI Text Editor"
        Me.mnuEditorOptions.ResumeLayout(False)
        Me.mnuEditorOptions.PerformLayout()
        Me.toolStripParent.ResumeLayout(False)
        Me.toolStripParent.PerformLayout()
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
    Friend WithEvents mnuParentContextMenu As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents mnuWindows As ToolStripMenuItem
    Friend WithEvents mnuCascade As ToolStripMenuItem
    Friend WithEvents mnuTileVertical As ToolStripMenuItem
    Friend WithEvents mnuTileHorizontal As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents mnuAverageUnitsShipped As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents toolStripParent As ToolStrip
    Friend WithEvents toolStripNew As ToolStripButton
    Friend WithEvents toolStripOpen As ToolStripButton
    Friend WithEvents toolStripSave As ToolStripButton
    Friend WithEvents toolStripAverageUnitsShipped As ToolStripButton
End Class
