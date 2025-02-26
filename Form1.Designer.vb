<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        btnClickme = New Button()
        Button3 = New Button()
        Timer1 = New Timer(components)
        Lblcount = New Label()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        RestartToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripSeparator()
        ExitToolStripMenuItem1 = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnClickme
        ' 
        btnClickme.BackColor = Color.LightBlue
        btnClickme.ForeColor = Color.Black
        btnClickme.Location = New Point(226, 138)
        btnClickme.Name = "btnClickme"
        btnClickme.Size = New Size(100, 57)
        btnClickme.TabIndex = 0
        btnClickme.Text = "0"
        btnClickme.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ActiveCaption
        Button3.Font = New Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(205, 251)
        Button3.Name = "Button3"
        Button3.Size = New Size(142, 49)
        Button3.TabIndex = 2
        Button3.Text = "Restart"
        Button3.UseVisualStyleBackColor = False
        Button3.Visible = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Lblcount
        ' 
        Lblcount.BorderStyle = BorderStyle.Fixed3D
        Lblcount.Location = New Point(12, 43)
        Lblcount.Name = "Lblcount"
        Lblcount.Size = New Size(119, 69)
        Lblcount.TabIndex = 3
        Lblcount.Text = "5"
        Lblcount.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.ActiveCaption
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(631, 24)
        MenuStrip1.TabIndex = 4
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {RestartToolStripMenuItem, ExitToolStripMenuItem, ExitToolStripMenuItem1})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' RestartToolStripMenuItem
        ' 
        RestartToolStripMenuItem.Name = "RestartToolStripMenuItem"
        RestartToolStripMenuItem.ShortcutKeys = Keys.F5
        RestartToolStripMenuItem.Size = New Size(129, 22)
        RestartToolStripMenuItem.Text = "Restart"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(126, 6)
        ' 
        ' ExitToolStripMenuItem1
        ' 
        ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        ExitToolStripMenuItem1.Size = New Size(129, 22)
        ExitToolStripMenuItem1.Text = "Exit"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(631, 452)
        Controls.Add(Lblcount)
        Controls.Add(Button3)
        Controls.Add(btnClickme)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ClickMe"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClickme As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Lblcount As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem

End Class
