Imports System
Imports System.IO
Imports System.Threading

Public Class Form1
    Dim filepath
    Dim folderpath
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If rbtnFile.Checked = True Then
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                Dim filepath = OpenFileDialog1.FileName
                Dim filename = System.IO.Path.GetFileName(OpenFileDialog1.FileName)
                If My.Computer.FileSystem.FileExists("SJIS_Dump.exe") Then
                    Dim sjiscount = nudSJIS1.Value.ToString
                    Dim command = "SJIS_Dump.exe"
                    Dim argu = """" & filepath & """" & " " & filename + ".txt" & " " + sjiscount & " 0"
                    Process.Start(command, argu)
                Else
                    MessageBox.Show("Need SJIS_Dump to work, Please download and place in same dir as this exe.")
                End If
            End If

        ElseIf rbtnFolder.Checked = True Then
            If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
                Dim folderpath = FolderBrowserDialog1.SelectedPath
                Dim foldername = Path.GetFileName(folderpath)
                Dim dir As New DirectoryInfo(folderpath)
                Dim filearr As FileInfo() = dir.GetFiles
                Dim file As FileInfo
                If My.Computer.FileSystem.FileExists("SJIS_Dump.exe") Then
                    If My.Computer.FileSystem.DirectoryExists(foldername) Then
                        For Each file In filearr
                            Dim sjiscount = nudSJIS1.Value.ToString
                            Dim command = "SJIS_Dump.exe"
                            Dim argu = """" & folderpath & "\" & file.ToString & """" & " " & """" & foldername & "\" & file.ToString & ".txt" & """" & " " + sjiscount & " 0"
                            Process.Start(command, argu)
                        Next
                        MessageBox.Show("Done")
                    ElseIf Not My.Computer.FileSystem.DirectoryExists(foldername) Then
                        Directory.CreateDirectory(foldername)
                        For Each file In filearr
                            Dim sjiscount = nudSJIS1.Value.ToString
                            Dim command = "SJIS_Dump.exe"
                            Dim argu = """" & folderpath & "\" & file.ToString & """" & " " & """" & foldername & "\" & file.ToString & ".txt" & """" & " " + sjiscount & " 0"
                            Process.Start(command, argu)
                        Next
                        MessageBox.Show("Done")
                    End If

                Else
                    MessageBox.Show("Need SJIS_Dump to work, Please download and place in same dir as this exe.")
                End If
            End If
        Else
            MessageBox.Show("Please check only button")
        End If
    End Sub

    Private Sub FormatTXTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormatTXTToolStripMenuItem.Click
        If OpenFileDialog2.ShowDialog = DialogResult.OK Then
            Dim filepath = OpenFileDialog2.FileName
            Dim filename = System.IO.Path.GetFileName(OpenFileDialog2.FileName)

            Try
                Dim Position As String
                Dim Text As String
                Dim writefile As System.IO.StreamWriter
                writefile = My.Computer.FileSystem.OpenTextFileWriter(filename & ".csv", True)
                Dim Lines() As String = IO.File.ReadAllLines(filepath, System.Text.Encoding.GetEncoding(932))
                For Each l In Lines
                    If l.ToString.Contains("Position :") Then
                        Dim splitl = l.ToString.Split(":")
                        Position = splitl(1).Trim
                    ElseIf l = "" Then
                        writefile.WriteLine(Position & "," & Text)
                        Position = ""
                        Text = ""
                    Else
                        Text = l.Trim
                    End If
                Next
                writefile.Close()
                MessageBox.Show("CSV Generated")
            Catch ex As Exception
                MessageBox.Show("ERROR: Couldnt convert to CSV")
            End Try
        End If
    End Sub
End Class
