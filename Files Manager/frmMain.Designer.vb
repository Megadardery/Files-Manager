<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.lstFiles = New System.Windows.Forms.ListBox()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.chkIndex = New System.Windows.Forms.CheckBox()
        Me.txtIndex = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nmrStartFrom = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.prgProgress = New System.Windows.Forms.ProgressBar()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatue = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.nmrStartFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(410, 4)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 0
        Me.btnBrowse.Text = "Browse"
        Me.ToolTip1.SetToolTip(Me.btnBrowse, "Import all (not hidden) files from a file into the list")
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'lstFiles
        '
        Me.lstFiles.FormattingEnabled = True
        Me.lstFiles.Location = New System.Drawing.Point(12, 32)
        Me.lstFiles.Name = "lstFiles"
        Me.lstFiles.ScrollAlwaysVisible = True
        Me.lstFiles.Size = New System.Drawing.Size(179, 160)
        Me.lstFiles.TabIndex = 1
        '
        'btnDown
        '
        Me.btnDown.Location = New System.Drawing.Point(197, 133)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(94, 23)
        Me.btnDown.TabIndex = 2
        Me.btnDown.Text = "Move Down"
        Me.ToolTip1.SetToolTip(Me.btnDown, "Move an item down in the list")
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnUp
        '
        Me.btnUp.Location = New System.Drawing.Point(197, 104)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(94, 23)
        Me.btnUp.TabIndex = 3
        Me.btnUp.Text = "Move Up"
        Me.ToolTip1.SetToolTip(Me.btnUp, "Move an item up in the list")
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'chkIndex
        '
        Me.chkIndex.AutoSize = True
        Me.chkIndex.Location = New System.Drawing.Point(9, 39)
        Me.chkIndex.Name = "chkIndex"
        Me.chkIndex.Size = New System.Drawing.Size(101, 17)
        Me.chkIndex.TabIndex = 11
        Me.chkIndex.Text = "Index renaming"
        Me.ToolTip1.SetToolTip(Me.chkIndex, "Index the files instead of renaming them(more information in the help)")
        Me.chkIndex.UseVisualStyleBackColor = True
        '
        'txtIndex
        '
        Me.txtIndex.Enabled = False
        Me.txtIndex.Location = New System.Drawing.Point(136, 62)
        Me.txtIndex.MaxLength = 5
        Me.txtIndex.Name = "txtIndex"
        Me.txtIndex.Size = New System.Drawing.Size(51, 20)
        Me.txtIndex.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.txtIndex, "Append a character or more after the index and before the orginal name")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(58, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "The splitter:"
        '
        'nmrStartFrom
        '
        Me.nmrStartFrom.Location = New System.Drawing.Point(136, 13)
        Me.nmrStartFrom.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nmrStartFrom.Name = "nmrStartFrom"
        Me.nmrStartFrom.Size = New System.Drawing.Size(51, 20)
        Me.nmrStartFrom.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.nmrStartFrom, "The Number To Start Renaming Files From")
        Me.nmrStartFrom.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Start renaming from"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(197, 61)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(94, 37)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear The List"
        Me.ToolTip1.SetToolTip(Me.btnClear, "Remove The Selected Item From The List(Not From The Computer)")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(9, 104)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(256, 23)
        Me.btnStart.TabIndex = 5
        Me.btnStart.Text = "Rename"
        Me.ToolTip1.SetToolTip(Me.btnStart, "Start renaming files in the list")
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(197, 32)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(94, 23)
        Me.btnRefresh.TabIndex = 10
        Me.btnRefresh.Text = "Refresh"
        Me.ToolTip1.SetToolTip(Me.btnRefresh, "Re-import all the files(will cancel all your movements)")
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(197, 162)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 37)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Reverse Order"
        Me.ToolTip1.SetToolTip(Me.Button1, "Move an item down in the list")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'prgProgress
        '
        Me.prgProgress.Location = New System.Drawing.Point(12, 378)
        Me.prgProgress.Name = "prgProgress"
        Me.prgProgress.Size = New System.Drawing.Size(473, 23)
        Me.prgProgress.TabIndex = 8
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(297, 32)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(188, 340)
        Me.RichTextBox1.TabIndex = 9
        Me.RichTextBox1.Text = ""
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(73, 6)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(331, 20)
        Me.txtPath.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Directory:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatue})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 406)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(495, 22)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatue
        '
        Me.lblStatue.Name = "lblStatue"
        Me.lblStatue.Size = New System.Drawing.Size(187, 17)
        Me.lblStatue.Text = "Thanks for choosing my program."
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 198)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(279, 174)
        Me.TabControl1.TabIndex = 16
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.chkIndex)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtIndex)
        Me.TabPage1.Controls.Add(Me.nmrStartFrom)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.btnStart)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(271, 148)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Index Renamer"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(271, 148)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Name Remover"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(27, 15)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(211, 20)
        Me.TextBox1.TabIndex = 17
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(100, 55)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Start"
        Me.ToolTip1.SetToolTip(Me.Button2, "Import all (not hidden) files from a file into the list")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 428)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.prgProgress)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.lstFiles)
        Me.Controls.Add(Me.btnBrowse)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Files Manager"
        Me.ToolTip1.SetToolTip(Me, "By Megadardery")
        CType(Me.nmrStartFrom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents lstFiles As System.Windows.Forms.ListBox
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents nmrStartFrom As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents prgProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents txtIndex As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkIndex As System.Windows.Forms.CheckBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStatue As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
