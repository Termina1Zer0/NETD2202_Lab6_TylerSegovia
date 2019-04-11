Option Strict On
Imports System.IO

Public Class MDIParentForm

#Region "Variable and Constant Declaration"

#End Region

#Region "Functions and Subs"
    ''' <summary>
    '''     Prompts the SaveFileDialog box to save a new file
    ''' </summary>
    Private Sub SaveAs()
        Dim activeForm As TextEditorForm = DirectCast(Me.ActiveMdiChild, TextEditorForm)
        SaveFileDialog.Filter = "TXT Files (*.txt)|*.txt"
        If SaveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                Dim writer As New StreamWriter(SaveFileDialog.FileName)
                writer.Write(activeForm.txtEditText.Text())
                activeForm.Text = SaveFileDialog.FileName
                writer.Close()
            Catch ex As Exception
                Console.WriteLine(ex.ToString())
            End Try
        End If
    End Sub

    ''' <summary>
    '''     Overwrites the existing file with text
    ''' </summary>
    Private Sub Save()
        Dim activeForm As TextEditorForm = DirectCast(Me.ActiveMdiChild, TextEditorForm)
        My.Computer.FileSystem.WriteAllText(activeForm.Text, activeForm.txtEditText.Text, False)
    End Sub

    ''' <summary>
    '''     Copies selected text to clipboard
    ''' </summary>
    Private Sub Copy()
        Dim activeForm As TextEditorForm = DirectCast(Me.ActiveMdiChild, TextEditorForm)
        Try
            My.Computer.Clipboard.SetText(activeForm.txtEditText.SelectedText)
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
    End Sub

    ''' <summary>
    '''     Copies selected text to clipboard and deletes it from textbox
    ''' </summary>
    Private Sub Cut()
        Dim activeForm As TextEditorForm = DirectCast(Me.ActiveMdiChild, TextEditorForm)
        Try
            My.Computer.Clipboard.SetText(activeForm.txtEditText.SelectedText)
            activeForm.txtEditText.SelectedText = ""
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
    End Sub

    ''' <summary>
    '''     Retrieves text from clipboard and adds it to textbox
    ''' </summary>
    Private Sub Paste()
        Dim activeForm As TextEditorForm = DirectCast(Me.ActiveMdiChild, TextEditorForm)
        Try
            activeForm.txtEditText.SelectedText = My.Computer.Clipboard.GetText()
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
    End Sub
#End Region

#Region "Event Handlers"
    Private Sub mnuNew_Click(sender As Object, e As EventArgs) Handles mnuNew.Click
        Dim newTextEditor As New TextEditorForm
        newTextEditor.MdiParent = Me
        newTextEditor.Show()
    End Sub

    Private Sub mnuOpen_Click(sender As Object, e As EventArgs) Handles mnuOpen.Click
        Dim newTextEditor As New TextEditorForm
        newTextEditor.MdiParent = Me

        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                Dim reader As New StreamReader(OpenFileDialog.FileName)
                newTextEditor.txtEditText.Text = reader.ReadToEnd
                reader.Close()

                newTextEditor.Show()
                newTextEditor.Text = OpenFileDialog.FileName
            Catch ex As Exception
                Console.WriteLine(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click
        If My.Computer.FileSystem.FileExists(ActiveForm.Text) = True Then
            Save()
        Else
            SaveAs()
        End If
    End Sub

    Private Sub mnuSaveAs_Click(sender As Object, e As EventArgs) Handles mnuSaveAs.Click
        SaveAs()
    End Sub

    Private Sub mnuClose_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
        Dim activeForm As TextEditorForm = DirectCast(Me.ActiveMdiChild, TextEditorForm)
        If My.Computer.FileSystem.FileExists(activeForm.Text) = True Then      'Exists
            If My.Computer.FileSystem.ReadAllText(activeForm.Text) = activeForm.txtEditText.Text Then
                activeForm.Close()
            Else
                Dim result As Integer = MessageBox.Show("Do you want to save changes?", activeForm.Text, MessageBoxButtons.YesNoCancel)
                If result = DialogResult.Yes Then
                    SaveAs()
                    activeForm.Close()
                ElseIf result = DialogResult.No Then
                    activeForm.Close()
                ElseIf result = DialogResult.Cancel Then
                    'Do nothing
                End If
            End If
        Else                                                            'Doesn't Exist
            If activeForm.txtEditText.Text() IsNot "" Then
                Dim result As Integer = MessageBox.Show("Do you want to save changes?", activeForm.Text, MessageBoxButtons.YesNoCancel)
                If result = DialogResult.Yes Then
                    SaveAs()
                    activeForm.Close()
                ElseIf result = DialogResult.No Then
                    activeForm.Close()
                ElseIf result = DialogResult.Cancel Then
                    'Do nothing
                End If
            Else
                activeForm.Close()
            End If
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Dim exitCancelled As Boolean = False
        Dim activeForm As TextEditorForm = DirectCast(Me.ActiveMdiChild, TextEditorForm)
        If AverageUnitsShippedForm.Visible = True Then
            AverageUnitsShippedForm.Close()
        End If
        For Each Child As TextEditorForm In MdiChildren.OfType(Of TextEditorForm)
            If My.Computer.FileSystem.FileExists(activeForm.Text) = True Then      'Exists
                If My.Computer.FileSystem.ReadAllText(activeForm.Text) = activeForm.txtEditText.Text Then
                    activeForm.Close()
                Else
                    Dim result As Integer = MessageBox.Show("Do you want to save changes?", activeForm.Text, MessageBoxButtons.YesNoCancel)
                    If result = DialogResult.Yes Then
                        SaveAs()
                        activeForm.Close()
                    ElseIf result = DialogResult.No Then
                        activeForm.Close()
                    ElseIf result = DialogResult.Cancel Then
                        exitCancelled = True
                    End If
                End If
            Else                                                            'Doesn't Exist
                If activeForm.txtEditText.Text() IsNot "" Then
                    Dim result As Integer = MessageBox.Show("Do you want to save changes?", activeForm.Text, MessageBoxButtons.YesNoCancel)
                    If result = DialogResult.Yes Then
                        SaveAs()
                        activeForm.Close()
                    ElseIf result = DialogResult.No Then
                        activeForm.Close()
                    ElseIf result = DialogResult.Cancel Then
                        exitCancelled = True
                    End If
                Else
                    activeForm.Close()
                End If
            End If
        Next Child
        If exitCancelled = False Then
            Application.Exit()
        End If
    End Sub

    Private Sub mnuCopy_Click(sender As Object, e As EventArgs) Handles mnuCopy.Click
        Copy()
    End Sub

    Private Sub mnuCut_Click(sender As Object, e As EventArgs) Handles mnuCut.Click
        Cut()
    End Sub

    Private Sub mnuPaste_Click(sender As Object, e As EventArgs) Handles mnuPaste.Click
        Paste()
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        MessageBox.Show("NETD-2202" + Environment.NewLine + "Lab 5" + Environment.NewLine + "T.Segovia")
    End Sub

    Private Sub mnuAverageUnitsShipped_Click(sender As Object, e As EventArgs) Handles mnuAverageUnitsShipped.Click
        Dim newAverageUnitsShipped As New AverageUnitsShippedForm
        newAverageUnitsShipped.MdiParent = Me
        newAverageUnitsShipped.Show()
    End Sub
#End Region
End Class