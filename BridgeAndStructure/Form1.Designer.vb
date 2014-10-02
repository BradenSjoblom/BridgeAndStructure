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
        Me.btbCross = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblQuest = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtQuest = New System.Windows.Forms.TextBox()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.lblFate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btbCross
        '
        Me.btbCross.Location = New System.Drawing.Point(42, 202)
        Me.btbCross.Name = "btbCross"
        Me.btbCross.Size = New System.Drawing.Size(207, 23)
        Me.btbCross.TabIndex = 0
        Me.btbCross.Text = "May i cross?"
        Me.btbCross.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(39, 30)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(101, 13)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "What is your name?"
        '
        'lblQuest
        '
        Me.lblQuest.AutoSize = True
        Me.lblQuest.Location = New System.Drawing.Point(39, 75)
        Me.lblQuest.Name = "lblQuest"
        Me.lblQuest.Size = New System.Drawing.Size(103, 13)
        Me.lblQuest.TabIndex = 2
        Me.lblQuest.Text = "What is your Quest?"
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Location = New System.Drawing.Point(12, 115)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(136, 13)
        Me.lblColor.TabIndex = 3
        Me.lblColor.Text = "What is your favorite color?"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(149, 30)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 4
        '
        'txtQuest
        '
        Me.txtQuest.Location = New System.Drawing.Point(149, 68)
        Me.txtQuest.Name = "txtQuest"
        Me.txtQuest.Size = New System.Drawing.Size(100, 20)
        Me.txtQuest.TabIndex = 5
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(149, 108)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(100, 20)
        Me.txtColor.TabIndex = 6
        '
        'lblFate
        '
        Me.lblFate.AutoSize = True
        Me.lblFate.Location = New System.Drawing.Point(101, 162)
        Me.lblFate.Name = "lblFate"
        Me.lblFate.Size = New System.Drawing.Size(0, 13)
        Me.lblFate.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblFate)
        Me.Controls.Add(Me.txtColor)
        Me.Controls.Add(Me.txtQuest)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.lblQuest)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btbCross)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btbCross As System.Windows.Forms.Button
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblQuest As System.Windows.Forms.Label
    Friend WithEvents lblColor As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtQuest As System.Windows.Forms.TextBox
    Friend WithEvents txtColor As System.Windows.Forms.TextBox
    Friend WithEvents lblFate As System.Windows.Forms.Label

End Class
