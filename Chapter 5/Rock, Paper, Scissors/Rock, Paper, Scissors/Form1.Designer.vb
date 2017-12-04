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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.picboxRock = New System.Windows.Forms.PictureBox()
        Me.picboxPaper = New System.Windows.Forms.PictureBox()
        Me.picboxScissors = New System.Windows.Forms.PictureBox()
        Me.btnShoot = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblRockTotal = New System.Windows.Forms.Label()
        Me.lblPaperTotal = New System.Windows.Forms.Label()
        Me.lblScissorTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.picboxRock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxPaper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxScissors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picboxRock
        '
        Me.picboxRock.Image = CType(resources.GetObject("picboxRock.Image"), System.Drawing.Image)
        Me.picboxRock.Location = New System.Drawing.Point(12, 24)
        Me.picboxRock.Name = "picboxRock"
        Me.picboxRock.Size = New System.Drawing.Size(161, 165)
        Me.picboxRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxRock.TabIndex = 0
        Me.picboxRock.TabStop = False
        '
        'picboxPaper
        '
        Me.picboxPaper.Image = CType(resources.GetObject("picboxPaper.Image"), System.Drawing.Image)
        Me.picboxPaper.Location = New System.Drawing.Point(179, 24)
        Me.picboxPaper.Name = "picboxPaper"
        Me.picboxPaper.Size = New System.Drawing.Size(178, 165)
        Me.picboxPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxPaper.TabIndex = 1
        Me.picboxPaper.TabStop = False
        '
        'picboxScissors
        '
        Me.picboxScissors.Image = CType(resources.GetObject("picboxScissors.Image"), System.Drawing.Image)
        Me.picboxScissors.Location = New System.Drawing.Point(363, 24)
        Me.picboxScissors.Name = "picboxScissors"
        Me.picboxScissors.Size = New System.Drawing.Size(162, 165)
        Me.picboxScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxScissors.TabIndex = 2
        Me.picboxScissors.TabStop = False
        '
        'btnShoot
        '
        Me.btnShoot.Location = New System.Drawing.Point(386, 240)
        Me.btnShoot.Name = "btnShoot"
        Me.btnShoot.Size = New System.Drawing.Size(92, 47)
        Me.btnShoot.TabIndex = 3
        Me.btnShoot.Text = "Shoot"
        Me.btnShoot.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(386, 293)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(92, 49)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblRockTotal
        '
        Me.lblRockTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRockTotal.Location = New System.Drawing.Point(244, 240)
        Me.lblRockTotal.Name = "lblRockTotal"
        Me.lblRockTotal.Size = New System.Drawing.Size(70, 36)
        Me.lblRockTotal.TabIndex = 5
        '
        'lblPaperTotal
        '
        Me.lblPaperTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPaperTotal.Location = New System.Drawing.Point(244, 293)
        Me.lblPaperTotal.Name = "lblPaperTotal"
        Me.lblPaperTotal.Size = New System.Drawing.Size(70, 36)
        Me.lblPaperTotal.TabIndex = 6
        '
        'lblScissorTotal
        '
        Me.lblScissorTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblScissorTotal.Location = New System.Drawing.Point(244, 344)
        Me.lblScissorTotal.Name = "lblScissorTotal"
        Me.lblScissorTotal.Size = New System.Drawing.Size(70, 36)
        Me.lblScissorTotal.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(157, 257)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Rock total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(157, 311)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Paper total:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(157, 357)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Scissor total:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 389)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblScissorTotal)
        Me.Controls.Add(Me.lblPaperTotal)
        Me.Controls.Add(Me.lblRockTotal)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnShoot)
        Me.Controls.Add(Me.picboxScissors)
        Me.Controls.Add(Me.picboxPaper)
        Me.Controls.Add(Me.picboxRock)
        Me.Name = "Form1"
        Me.Text = "Rock, Paper, Scissors"
        CType(Me.picboxRock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxPaper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxScissors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picboxRock As System.Windows.Forms.PictureBox
    Friend WithEvents picboxPaper As System.Windows.Forms.PictureBox
    Friend WithEvents picboxScissors As System.Windows.Forms.PictureBox
    Friend WithEvents btnShoot As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblRockTotal As System.Windows.Forms.Label
    Friend WithEvents lblPaperTotal As System.Windows.Forms.Label
    Friend WithEvents lblScissorTotal As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
