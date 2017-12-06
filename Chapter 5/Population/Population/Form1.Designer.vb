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
        Me.cboxOrganisims = New System.Windows.Forms.ComboBox()
        Me.txtboxIncrease = New System.Windows.Forms.TextBox()
        Me.cboxDays = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboxOrganisims
        '
        Me.cboxOrganisims.FormattingEnabled = True
        Me.cboxOrganisims.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "12", "14", "16", "18", "20"})
        Me.cboxOrganisims.Location = New System.Drawing.Point(202, 66)
        Me.cboxOrganisims.Name = "cboxOrganisims"
        Me.cboxOrganisims.Size = New System.Drawing.Size(121, 21)
        Me.cboxOrganisims.TabIndex = 0
        '
        'txtboxIncrease
        '
        Me.txtboxIncrease.Location = New System.Drawing.Point(202, 140)
        Me.txtboxIncrease.Name = "txtboxIncrease"
        Me.txtboxIncrease.Size = New System.Drawing.Size(121, 20)
        Me.txtboxIncrease.TabIndex = 1
        '
        'cboxDays
        '
        Me.cboxDays.FormattingEnabled = True
        Me.cboxDays.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cboxDays.Location = New System.Drawing.Point(202, 99)
        Me.cboxDays.Name = "cboxDays"
        Me.cboxDays.Size = New System.Drawing.Size(121, 21)
        Me.cboxDays.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Starting number of organisms:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Number of days to multiply:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Average daily increase:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(52, 194)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Enter Data"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(175, 194)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 262)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboxDays)
        Me.Controls.Add(Me.txtboxIncrease)
        Me.Controls.Add(Me.cboxOrganisims)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboxOrganisims As System.Windows.Forms.ComboBox
    Friend WithEvents txtboxIncrease As System.Windows.Forms.TextBox
    Friend WithEvents cboxDays As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
