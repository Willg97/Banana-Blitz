<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnHowToPlay = New System.Windows.Forms.Button()
        Me.btnExitGame = New System.Windows.Forms.Button()
        Me.PboTitle = New System.Windows.Forms.PictureBox()
        CType(Me.PboTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(213, 208)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(170, 47)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnHowToPlay
        '
        Me.btnHowToPlay.Location = New System.Drawing.Point(213, 261)
        Me.btnHowToPlay.Name = "btnHowToPlay"
        Me.btnHowToPlay.Size = New System.Drawing.Size(170, 47)
        Me.btnHowToPlay.TabIndex = 2
        Me.btnHowToPlay.Text = "How To Play"
        Me.btnHowToPlay.UseVisualStyleBackColor = True
        '
        'btnExitGame
        '
        Me.btnExitGame.Location = New System.Drawing.Point(213, 314)
        Me.btnExitGame.Name = "btnExitGame"
        Me.btnExitGame.Size = New System.Drawing.Size(170, 47)
        Me.btnExitGame.TabIndex = 3
        Me.btnExitGame.Text = "Exit game"
        Me.btnExitGame.UseVisualStyleBackColor = True
        '
        'PboTitle
        '
        Me.PboTitle.Image = CType(resources.GetObject("PboTitle.Image"), System.Drawing.Image)
        Me.PboTitle.Location = New System.Drawing.Point(52, 12)
        Me.PboTitle.Name = "PboTitle"
        Me.PboTitle.Size = New System.Drawing.Size(490, 77)
        Me.PboTitle.TabIndex = 4
        Me.PboTitle.TabStop = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(609, 433)
        Me.Controls.Add(Me.PboTitle)
        Me.Controls.Add(Me.btnExitGame)
        Me.Controls.Add(Me.btnHowToPlay)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "MainMenu"
        Me.Text = "MainMenu"
        CType(Me.PboTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents btnHowToPlay As Button
    Friend WithEvents btnExitGame As Button
    Friend WithEvents PboTitle As PictureBox
End Class
