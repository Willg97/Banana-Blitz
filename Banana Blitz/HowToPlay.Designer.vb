<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HowToPlay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HowToPlay))
        Me.PboHowToPlay = New System.Windows.Forms.PictureBox()
        Me.TxtHowToPlay = New System.Windows.Forms.TextBox()
        Me.BtnMainMenu = New System.Windows.Forms.Button()
        CType(Me.PboHowToPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PboHowToPlay
        '
        Me.PboHowToPlay.Image = CType(resources.GetObject("PboHowToPlay.Image"), System.Drawing.Image)
        Me.PboHowToPlay.Location = New System.Drawing.Point(73, 12)
        Me.PboHowToPlay.Name = "PboHowToPlay"
        Me.PboHowToPlay.Size = New System.Drawing.Size(459, 93)
        Me.PboHowToPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PboHowToPlay.TabIndex = 5
        Me.PboHowToPlay.TabStop = False
        '
        'TxtHowToPlay
        '
        Me.TxtHowToPlay.Location = New System.Drawing.Point(174, 189)
        Me.TxtHowToPlay.Multiline = True
        Me.TxtHowToPlay.Name = "TxtHowToPlay"
        Me.TxtHowToPlay.ReadOnly = True
        Me.TxtHowToPlay.Size = New System.Drawing.Size(272, 115)
        Me.TxtHowToPlay.TabIndex = 6
        Me.TxtHowToPlay.Tag = ""
        Me.TxtHowToPlay.Text = resources.GetString("TxtHowToPlay.Text")
        '
        'BtnMainMenu
        '
        Me.BtnMainMenu.Location = New System.Drawing.Point(12, 367)
        Me.BtnMainMenu.Name = "BtnMainMenu"
        Me.BtnMainMenu.Size = New System.Drawing.Size(130, 54)
        Me.BtnMainMenu.TabIndex = 7
        Me.BtnMainMenu.Text = "Main Menu"
        Me.BtnMainMenu.UseVisualStyleBackColor = True
        '
        'HowToPlay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(609, 433)
        Me.Controls.Add(Me.BtnMainMenu)
        Me.Controls.Add(Me.TxtHowToPlay)
        Me.Controls.Add(Me.PboHowToPlay)
        Me.Name = "HowToPlay"
        Me.Text = "HowToPlay"
        CType(Me.PboHowToPlay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PboHowToPlay As PictureBox
    Friend WithEvents TxtHowToPlay As TextBox
    Friend WithEvents BtnMainMenu As Button
End Class
