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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.tmrMaze = New System.Windows.Forms.Timer(Me.components)
        Me.LblPoints = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbrHealth = New System.Windows.Forms.ProgressBar()
        Me.tmrPower = New System.Windows.Forms.Timer(Me.components)
        Me.lblHealth = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrMaze
        '
        Me.tmrMaze.Enabled = True
        Me.tmrMaze.Interval = 1
        '
        'LblPoints
        '
        Me.LblPoints.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LblPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblPoints.Location = New System.Drawing.Point(743, 9)
        Me.LblPoints.Name = "LblPoints"
        Me.LblPoints.Size = New System.Drawing.Size(83, 33)
        Me.LblPoints.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 632)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(290, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'pbrHealth
        '
        Me.pbrHealth.BackColor = System.Drawing.SystemColors.GrayText
        Me.pbrHealth.Location = New System.Drawing.Point(706, 60)
        Me.pbrHealth.Name = "pbrHealth"
        Me.pbrHealth.Size = New System.Drawing.Size(100, 23)
        Me.pbrHealth.TabIndex = 2
        Me.pbrHealth.UseWaitCursor = True
        Me.pbrHealth.Value = 100
        '
        'tmrPower
        '
        Me.tmrPower.Enabled = True
        Me.tmrPower.Interval = 1
        '
        'lblHealth
        '
        Me.lblHealth.AutoSize = True
        Me.lblHealth.Location = New System.Drawing.Point(652, 60)
        Me.lblHealth.Name = "lblHealth"
        Me.lblHealth.Size = New System.Drawing.Size(38, 13)
        Me.lblHealth.TabIndex = 4
        Me.lblHealth.Text = "Health"
        Me.lblHealth.UseWaitCursor = True
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(678, 19)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(35, 13)
        Me.lblScore.TabIndex = 5
        Me.lblScore.Text = "Score"
        Me.lblScore.UseWaitCursor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(838, 703)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblHealth)
        Me.Controls.Add(Me.pbrHealth)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LblPoints)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tmrMaze As Timer
    Friend WithEvents LblPoints As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pbrHealth As ProgressBar
    Friend WithEvents tmrPower As Timer
    Friend WithEvents lblHealth As Label
    Friend WithEvents lblScore As Label
End Class
