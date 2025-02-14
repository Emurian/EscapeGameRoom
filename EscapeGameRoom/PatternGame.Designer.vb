<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PatternGame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso designerComponents IsNot Nothing Then
            designerComponents.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private designerComponents As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblPattern = New Label()
        lblTimeLeft = New Label()
        lblScore = New Label()
        txtUserInput = New TextBox()
        btnSubmit = New Button()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' lblPattern
        ' 
        lblPattern.AutoSize = True
        lblPattern.Font = New Font("AniMe Matrix - MB_EN", 14.25F, FontStyle.Bold)
        lblPattern.Location = New Point(26, 81)
        lblPattern.Name = "lblPattern"
        lblPattern.Size = New Size(145, 23)
        lblPattern.TabIndex = 0
        lblPattern.Text = "Pattern:"
        ' 
        ' lblTimeLeft
        ' 
        lblTimeLeft.AutoSize = True
        lblTimeLeft.Font = New Font("AniMe Matrix - MB_EN", 14.25F, FontStyle.Bold)
        lblTimeLeft.Location = New Point(295, 28)
        lblTimeLeft.Name = "lblTimeLeft"
        lblTimeLeft.Size = New Size(218, 23)
        lblTimeLeft.TabIndex = 1
        lblTimeLeft.Text = "Time Left: 60s"
        ' 
        ' lblScore
        ' 
        lblScore.AutoSize = True
        lblScore.Font = New Font("AniMe Matrix - MB_EN", 14.25F, FontStyle.Bold)
        lblScore.Location = New Point(26, 28)
        lblScore.Name = "lblScore"
        lblScore.Size = New Size(131, 23)
        lblScore.TabIndex = 2
        lblScore.Text = "Score: 0"
        ' 
        ' txtUserInput
        ' 
        txtUserInput.Font = New Font("AniMe Matrix - MB_EN", 14.25F, FontStyle.Bold)
        txtUserInput.Location = New Point(141, 169)
        txtUserInput.Margin = New Padding(3, 2, 3, 2)
        txtUserInput.Name = "txtUserInput"
        txtUserInput.Size = New Size(263, 30)
        txtUserInput.TabIndex = 3
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Font = New Font("AniMe Matrix - MB_EN", 14.25F, FontStyle.Bold)
        btnSubmit.Location = New Point(183, 226)
        btnSubmit.Margin = New Padding(3, 2, 3, 2)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(186, 58)
        btnSubmit.TabIndex = 4
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("AniMe Matrix - MB_EN", 14.25F, FontStyle.Bold)
        btnExit.Location = New Point(183, 302)
        btnExit.Margin = New Padding(3, 2, 3, 2)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(186, 58)
        btnExit.TabIndex = 5
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' PatternGame
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.geometricBG
        ClientSize = New Size(525, 422)
        Controls.Add(btnExit)
        Controls.Add(btnSubmit)
        Controls.Add(txtUserInput)
        Controls.Add(lblScore)
        Controls.Add(lblTimeLeft)
        Controls.Add(lblPattern)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(3, 2, 3, 2)
        MaximizeBox = False
        Name = "PatternGame"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sequence Game"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblPattern As Label
    Friend WithEvents lblTimeLeft As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents txtUserInput As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnExit As Button ' Declared Exit button
End Class
