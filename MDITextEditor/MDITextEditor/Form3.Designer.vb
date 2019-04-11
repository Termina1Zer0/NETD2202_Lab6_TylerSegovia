<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AverageUnitsShippedForm
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
        Me.lblTotalAverage = New System.Windows.Forms.Label()
        Me.lblEmployee3Average = New System.Windows.Forms.Label()
        Me.lblEmployee2Average = New System.Windows.Forms.Label()
        Me.lblEmployee1Average = New System.Windows.Forms.Label()
        Me.txtEmployee3Display = New System.Windows.Forms.TextBox()
        Me.txtEmployee2Display = New System.Windows.Forms.TextBox()
        Me.txtEmployee1Display = New System.Windows.Forms.TextBox()
        Me.lblEmployee3Display = New System.Windows.Forms.Label()
        Me.lblEmployee2Display = New System.Windows.Forms.Label()
        Me.lblEmployee1Display = New System.Windows.Forms.Label()
        Me.txtUnitsInput = New System.Windows.Forms.TextBox()
        Me.lblUnitsInput = New System.Windows.Forms.Label()
        Me.lblDayCounter = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTotalAverage
        '
        Me.lblTotalAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalAverage.Location = New System.Drawing.Point(36, 327)
        Me.lblTotalAverage.Name = "lblTotalAverage"
        Me.lblTotalAverage.Size = New System.Drawing.Size(437, 23)
        Me.lblTotalAverage.TabIndex = 28
        Me.lblTotalAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployee3Average
        '
        Me.lblEmployee3Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployee3Average.Location = New System.Drawing.Point(338, 286)
        Me.lblEmployee3Average.Name = "lblEmployee3Average"
        Me.lblEmployee3Average.Size = New System.Drawing.Size(135, 23)
        Me.lblEmployee3Average.TabIndex = 27
        Me.lblEmployee3Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployee2Average
        '
        Me.lblEmployee2Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployee2Average.Location = New System.Drawing.Point(187, 286)
        Me.lblEmployee2Average.Name = "lblEmployee2Average"
        Me.lblEmployee2Average.Size = New System.Drawing.Size(135, 23)
        Me.lblEmployee2Average.TabIndex = 24
        Me.lblEmployee2Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployee1Average
        '
        Me.lblEmployee1Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployee1Average.Location = New System.Drawing.Point(36, 286)
        Me.lblEmployee1Average.Name = "lblEmployee1Average"
        Me.lblEmployee1Average.Size = New System.Drawing.Size(135, 23)
        Me.lblEmployee1Average.TabIndex = 21
        Me.lblEmployee1Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEmployee3Display
        '
        Me.txtEmployee3Display.Location = New System.Drawing.Point(338, 125)
        Me.txtEmployee3Display.Multiline = True
        Me.txtEmployee3Display.Name = "txtEmployee3Display"
        Me.txtEmployee3Display.ReadOnly = True
        Me.txtEmployee3Display.Size = New System.Drawing.Size(135, 148)
        Me.txtEmployee3Display.TabIndex = 26
        '
        'txtEmployee2Display
        '
        Me.txtEmployee2Display.Location = New System.Drawing.Point(187, 125)
        Me.txtEmployee2Display.Multiline = True
        Me.txtEmployee2Display.Name = "txtEmployee2Display"
        Me.txtEmployee2Display.ReadOnly = True
        Me.txtEmployee2Display.Size = New System.Drawing.Size(135, 148)
        Me.txtEmployee2Display.TabIndex = 23
        '
        'txtEmployee1Display
        '
        Me.txtEmployee1Display.Location = New System.Drawing.Point(36, 125)
        Me.txtEmployee1Display.Multiline = True
        Me.txtEmployee1Display.Name = "txtEmployee1Display"
        Me.txtEmployee1Display.ReadOnly = True
        Me.txtEmployee1Display.Size = New System.Drawing.Size(135, 148)
        Me.txtEmployee1Display.TabIndex = 20
        '
        'lblEmployee3Display
        '
        Me.lblEmployee3Display.Location = New System.Drawing.Point(338, 99)
        Me.lblEmployee3Display.Name = "lblEmployee3Display"
        Me.lblEmployee3Display.Size = New System.Drawing.Size(135, 23)
        Me.lblEmployee3Display.TabIndex = 25
        Me.lblEmployee3Display.Text = "Employee 3"
        Me.lblEmployee3Display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployee2Display
        '
        Me.lblEmployee2Display.Location = New System.Drawing.Point(187, 99)
        Me.lblEmployee2Display.Name = "lblEmployee2Display"
        Me.lblEmployee2Display.Size = New System.Drawing.Size(135, 23)
        Me.lblEmployee2Display.TabIndex = 22
        Me.lblEmployee2Display.Text = "Employee 2"
        Me.lblEmployee2Display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployee1Display
        '
        Me.lblEmployee1Display.Location = New System.Drawing.Point(36, 99)
        Me.lblEmployee1Display.Name = "lblEmployee1Display"
        Me.lblEmployee1Display.Size = New System.Drawing.Size(135, 23)
        Me.lblEmployee1Display.TabIndex = 19
        Me.lblEmployee1Display.Text = "Employee 1"
        Me.lblEmployee1Display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUnitsInput
        '
        Me.txtUnitsInput.Location = New System.Drawing.Point(92, 54)
        Me.txtUnitsInput.Name = "txtUnitsInput"
        Me.txtUnitsInput.Size = New System.Drawing.Size(65, 22)
        Me.txtUnitsInput.TabIndex = 18
        '
        'lblUnitsInput
        '
        Me.lblUnitsInput.Location = New System.Drawing.Point(20, 54)
        Me.lblUnitsInput.Name = "lblUnitsInput"
        Me.lblUnitsInput.Size = New System.Drawing.Size(57, 23)
        Me.lblUnitsInput.TabIndex = 17
        Me.lblUnitsInput.Text = "&Units:"
        Me.lblUnitsInput.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDayCounter
        '
        Me.lblDayCounter.Location = New System.Drawing.Point(21, 22)
        Me.lblDayCounter.Name = "lblDayCounter"
        Me.lblDayCounter.Size = New System.Drawing.Size(57, 23)
        Me.lblDayCounter.TabIndex = 16
        Me.lblDayCounter.Text = "Day 1"
        Me.lblDayCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(338, 372)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(135, 46)
        Me.btnExit.TabIndex = 31
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Yellow
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(187, 372)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(135, 46)
        Me.btnReset.TabIndex = 30
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.Aqua
        Me.btnEnter.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEnter.Location = New System.Drawing.Point(36, 372)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(135, 46)
        Me.btnEnter.TabIndex = 29
        Me.btnEnter.Text = "&Enter"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'AverageUnitsShippedForm
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(510, 450)
        Me.Controls.Add(Me.lblTotalAverage)
        Me.Controls.Add(Me.lblEmployee3Average)
        Me.Controls.Add(Me.lblEmployee2Average)
        Me.Controls.Add(Me.lblEmployee1Average)
        Me.Controls.Add(Me.txtEmployee3Display)
        Me.Controls.Add(Me.txtEmployee2Display)
        Me.Controls.Add(Me.txtEmployee1Display)
        Me.Controls.Add(Me.lblEmployee3Display)
        Me.Controls.Add(Me.lblEmployee2Display)
        Me.Controls.Add(Me.lblEmployee1Display)
        Me.Controls.Add(Me.txtUnitsInput)
        Me.Controls.Add(Me.lblUnitsInput)
        Me.Controls.Add(Me.lblDayCounter)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(528, 497)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(528, 497)
        Me.Name = "AverageUnitsShippedForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped By Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTotalAverage As Label
    Friend WithEvents lblEmployee3Average As Label
    Friend WithEvents lblEmployee2Average As Label
    Friend WithEvents lblEmployee1Average As Label
    Friend WithEvents txtEmployee3Display As TextBox
    Friend WithEvents txtEmployee2Display As TextBox
    Friend WithEvents txtEmployee1Display As TextBox
    Friend WithEvents lblEmployee3Display As Label
    Friend WithEvents lblEmployee2Display As Label
    Friend WithEvents lblEmployee1Display As Label
    Friend WithEvents txtUnitsInput As TextBox
    Friend WithEvents lblUnitsInput As Label
    Friend WithEvents lblDayCounter As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnEnter As Button
End Class
