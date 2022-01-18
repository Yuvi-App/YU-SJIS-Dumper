<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rbtnFolder = New System.Windows.Forms.RadioButton()
        Me.rbtnFile = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.nudSJIS1 = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatTXTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.nudSJIS1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 116)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Dump"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'rbtnFolder
        '
        Me.rbtnFolder.AutoSize = True
        Me.rbtnFolder.Location = New System.Drawing.Point(15, 37)
        Me.rbtnFolder.Name = "rbtnFolder"
        Me.rbtnFolder.Size = New System.Drawing.Size(54, 17)
        Me.rbtnFolder.TabIndex = 1
        Me.rbtnFolder.TabStop = True
        Me.rbtnFolder.Text = "Folder"
        Me.ToolTip1.SetToolTip(Me.rbtnFolder, "Extract in bulk")
        Me.rbtnFolder.UseVisualStyleBackColor = True
        '
        'rbtnFile
        '
        Me.rbtnFile.AutoSize = True
        Me.rbtnFile.Location = New System.Drawing.Point(145, 37)
        Me.rbtnFile.Name = "rbtnFile"
        Me.rbtnFile.Size = New System.Drawing.Size(41, 17)
        Me.rbtnFile.TabIndex = 2
        Me.rbtnFile.TabStop = True
        Me.rbtnFile.Text = "File"
        Me.ToolTip1.SetToolTip(Me.rbtnFile, "Choose 1 file")
        Me.rbtnFile.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Many Files"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(142, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "One File"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 9)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Yuvi v1.1"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'nudSJIS1
        '
        Me.nudSJIS1.Location = New System.Drawing.Point(145, 90)
        Me.nudSJIS1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudSJIS1.Name = "nudSJIS1"
        Me.nudSJIS1.Size = New System.Drawing.Size(40, 20)
        Me.nudSJIS1.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.nudSJIS1, "Counts this many SJIS characters before extracting the text")
        Me.nudSJIS1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "SJIS Letter Minimum"
        Me.ToolTip1.SetToolTip(Me.Label4, "Counts this many SJIS characters before extracting the text")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(200, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormatTXTToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'FormatTXTToolStripMenuItem
        '
        Me.FormatTXTToolStripMenuItem.Name = "FormatTXTToolStripMenuItem"
        Me.FormatTXTToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FormatTXTToolStripMenuItem.Text = "TXT - CSV"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(200, 154)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nudSJIS1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rbtnFile)
        Me.Controls.Add(Me.rbtnFolder)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "SJIS Dumper"
        CType(Me.nudSJIS1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents rbtnFolder As RadioButton
    Friend WithEvents rbtnFile As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents nudSJIS1 As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatTXTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
End Class
