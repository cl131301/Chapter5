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
        Me.btnFlip = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PictureBoxHeads = New System.Windows.Forms.PictureBox()
        Me.PictureBoxTails = New System.Windows.Forms.PictureBox()
        Me.lblTailTotal = New System.Windows.Forms.Label()
        Me.lblHeadTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBoxHeads, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxTails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFlip
        '
        Me.btnFlip.Location = New System.Drawing.Point(105, 282)
        Me.btnFlip.Name = "btnFlip"
        Me.btnFlip.Size = New System.Drawing.Size(75, 23)
        Me.btnFlip.TabIndex = 0
        Me.btnFlip.Text = "Flip Coin"
        Me.btnFlip.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(203, 282)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PictureBoxHeads
        '
        Me.PictureBoxHeads.Image = CType(resources.GetObject("PictureBoxHeads.Image"), System.Drawing.Image)
        Me.PictureBoxHeads.Location = New System.Drawing.Point(24, 38)
        Me.PictureBoxHeads.Name = "PictureBoxHeads"
        Me.PictureBoxHeads.Size = New System.Drawing.Size(156, 156)
        Me.PictureBoxHeads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxHeads.TabIndex = 2
        Me.PictureBoxHeads.TabStop = False
        '
        'PictureBoxTails
        '
        Me.PictureBoxTails.Image = CType(resources.GetObject("PictureBoxTails.Image"), System.Drawing.Image)
        Me.PictureBoxTails.Location = New System.Drawing.Point(203, 38)
        Me.PictureBoxTails.Name = "PictureBoxTails"
        Me.PictureBoxTails.Size = New System.Drawing.Size(158, 156)
        Me.PictureBoxTails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxTails.TabIndex = 3
        Me.PictureBoxTails.TabStop = False
        '
        'lblTailTotal
        '
        Me.lblTailTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTailTotal.Location = New System.Drawing.Point(284, 211)
        Me.lblTailTotal.Name = "lblTailTotal"
        Me.lblTailTotal.Size = New System.Drawing.Size(77, 40)
        Me.lblTailTotal.TabIndex = 4
        '
        'lblHeadTotal
        '
        Me.lblHeadTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHeadTotal.Location = New System.Drawing.Point(111, 211)
        Me.lblHeadTotal.Name = "lblHeadTotal"
        Me.lblHeadTotal.Size = New System.Drawing.Size(69, 40)
        Me.lblHeadTotal.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 212)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Number of Heads:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(200, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Number of Tails:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 317)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblHeadTotal)
        Me.Controls.Add(Me.lblTailTotal)
        Me.Controls.Add(Me.PictureBoxTails)
        Me.Controls.Add(Me.PictureBoxHeads)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnFlip)
        Me.Name = "Form1"
        Me.Text = "Coin Toss"
        CType(Me.PictureBoxHeads, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxTails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFlip As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents PictureBoxHeads As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxTails As System.Windows.Forms.PictureBox
    Friend WithEvents lblTailTotal As System.Windows.Forms.Label
    Friend WithEvents lblHeadTotal As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
