Option Strict On
Imports System.IO

Public Class MDITextEditorForm

#Region "Variable and Constant Declaration"
    Dim filename As String
#End Region

#Region "Functions and Subs"
    ''' <summary>
    '''     Prepares the program for a new file
    ''' </summary>
    Sub NewFile()
        txtEditText.Text() = ""
        filename = ""
        Me.Text = "Text Editor"
    End Sub

    ''' <summary>
    '''     Prompts the SaveFileDialog box to save a new file
    ''' </summary>
    Sub SaveAs()
        SaveFileDialog.Filter = "TXT Files (*.txt)|*.txt"
        If SaveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                Dim writer As New StreamWriter(SaveFileDialog.FileName)
                writer.Write(txtEditText.Text())
                filename = SaveFileDialog.FileName
                Me.Text = Path.GetFileName(filename)
                writer.Close()
            Catch ex As Exception
                Console.WriteLine(ex.ToString())
            End Try
        End If
    End Sub

    ''' <summary>
    '''     Overwrites the existing file with text
    ''' </summary>
    Sub Save()
        My.Computer.FileSystem.WriteAllText(filename, txtEditText.Text(), False)
    End Sub

    ''' <summary>
    '''     Opens a new file
    ''' </summary>
    Sub Open()
        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                Dim reader As New StreamReader(OpenFileDialog.FileName)
                txtEditText.Text() = reader.ReadToEnd()
                filename = OpenFileDialog.FileName
                Me.Text = Path.GetFileName(filename)
                reader.Close()
            Catch ex As Exception
                Console.WriteLine(ex.ToString())
            End Try
        End If
    End Sub

    ''' <summary>
    '''     Copies selected text to clipboard
    ''' </summary>
    Sub Copy()
        Try
            My.Computer.Clipboard.SetText(txtEditText.SelectedText)
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
    End Sub

    ''' <summary>
    '''     Copies selected text to clipboard and deletes it from textbox
    ''' </summary>
    Sub Cut()
        Try
            My.Computer.Clipboard.SetText(txtEditText.SelectedText)
            txtEditText.SelectedText = ""
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
    End Sub

    ''' <summary>
    '''     Retrieves text from clipboard and adds it to textbox
    ''' </summary>
    Sub Paste()
        Try
            txtEditText.SelectedText = My.Computer.Clipboard.GetText()
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
    End Sub
#End Region

#Region "Event Handlers"
    Private Sub mnuNew_Click(sender As Object, e As EventArgs) Handles mnuNew.Click
        If My.Computer.FileSystem.FileExists(filename) = True Then      'Exists
            If My.Computer.FileSystem.ReadAllText(filename) = txtEditText.Text() Then
                NewFile()
            Else
                Dim result As Integer = MessageBox.Show("Do you want to save changes?", "Text Editor", MessageBoxButtons.YesNoCancel)
                If result = DialogResult.Yes Then
                    SaveAs()
                    NewFile()
                ElseIf result = DialogResult.No Then
                    NewFile()
                ElseIf result = DialogResult.Cancel Then
                    'Do nothing
                End If
            End If
        Else                                                            'Doesn't Exist
            If txtEditText.Text() IsNot "" Then
                Dim result As Integer = MessageBox.Show("Do you want to save changes?", "Text Editor", MessageBoxButtons.YesNoCancel)
                If result = DialogResult.Yes Then
                    SaveAs()
                    NewFile()
                ElseIf result = DialogResult.No Then
                    NewFile()
                ElseIf result = DialogResult.Cancel Then
                    'Do nothing
                End If
            End If
        End If
    End Sub

    Private Sub mnuOpen_Click(sender As Object, e As EventArgs) Handles mnuOpen.Click
        If My.Computer.FileSystem.FileExists(filename) = True Then      'Exists
            If My.Computer.FileSystem.ReadAllText(filename) = txtEditText.Text() Then
                Open()
            Else
                Dim result As Integer = MessageBox.Show("Do you want to save changes?", "Text Editor", MessageBoxButtons.YesNoCancel)
                If result = DialogResult.Yes Then
                    SaveAs()
                    Open()
                ElseIf result = DialogResult.No Then
                    Open()
                ElseIf result = DialogResult.Cancel Then
                    'Do nothing
                End If
            End If
        Else                                                            'Doesn't Exist
            If txtEditText.Text() IsNot "" Then
                Dim result As Integer = MessageBox.Show("Do you want to save changes?", "Text Editor", MessageBoxButtons.YesNoCancel)
                If result = DialogResult.Yes Then
                    SaveAs()
                    Open()
                ElseIf result = DialogResult.No Then
                    Open()
                ElseIf result = DialogResult.Cancel Then
                    'Do nothing
                End If
            Else
                Open()
            End If
        End If
    End Sub

    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click
        If My.Computer.FileSystem.FileExists(filename) = True Then
            Save()
        Else
            SaveAs()
        End If
    End Sub

    Private Sub mnuSaveAs_Click(sender As Object, e As EventArgs) Handles mnuSaveAs.Click
        SaveAs()
    End Sub

    Private Sub mnuClose_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
        If My.Computer.FileSystem.FileExists(filename) = True Then      'Exists
            If My.Computer.FileSystem.ReadAllText(filename) = txtEditText.Text() Then
                Application.Exit()
            Else
                Dim result As Integer = MessageBox.Show("Do you want to save changes?", "Text Editor", MessageBoxButtons.YesNoCancel)
                If result = DialogResult.Yes Then
                    SaveAs()
                    Application.Exit()
                ElseIf result = DialogResult.No Then
                    Application.Exit()
                ElseIf result = DialogResult.Cancel Then
                    'Do nothing
                End If
            End If
        Else                                                            'Doesn't Exist
            If txtEditText.Text() IsNot "" Then
                Dim result As Integer = MessageBox.Show("Do you want to save changes?", "Text Editor", MessageBoxButtons.YesNoCancel)
                If result = DialogResult.Yes Then
                    SaveAs()
                    Application.Exit()
                ElseIf result = DialogResult.No Then
                    Application.Exit()
                ElseIf result = DialogResult.Cancel Then
                    'Do nothing
                End If
            Else
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        If My.Computer.FileSystem.FileExists(filename) = True Then      'Exists
            If My.Computer.FileSystem.ReadAllText(filename) = txtEditText.Text() Then
                Application.Exit()
            Else
                Dim result As Integer = MessageBox.Show("Do you want to save changes?", "Text Editor", MessageBoxButtons.YesNoCancel)
                If result = DialogResult.Yes Then
                    SaveAs()
                    Application.Exit()
                ElseIf result = DialogResult.No Then
                    Application.Exit()
                ElseIf result = DialogResult.Cancel Then
                    'Do nothing
                End If
            End If
        Else                                                            'Doesn't Exist
            If txtEditText.Text() IsNot "" Then
                Dim result As Integer = MessageBox.Show("Do you want to save changes?", "Text Editor", MessageBoxButtons.YesNoCancel)
                If result = DialogResult.Yes Then
                    SaveAs()
                    Application.Exit()
                ElseIf result = DialogResult.No Then
                    Application.Exit()
                ElseIf result = DialogResult.Cancel Then
                    'Do nothing
                End If
            Else
                Application.Exit()
            End If
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

#End Region

End Class