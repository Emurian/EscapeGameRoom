<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MathGame
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblQuestion = New Label()
        txtAnswer = New TextBox()
        btnSubmit = New Button()
        lblTimer = New Label()
        lblScore = New Label()
        btnExit = New Button()
        timerGame = New Timer(components)
        Answer = New Label()
        SuspendLayout()
        ' 
        ' lblQuestion
        ' 
        lblQuestion.BackColor = SystemColors.AppWorkspace
        lblQuestion.Font = New Font("AniMe Matrix - MB_EN", 15.0F)
        lblQuestion.Location = New Point(136, 143)
        lblQuestion.Name = "lblQuestion"
        lblQuestion.Size = New Size(500, 40)
        lblQuestion.TabIndex = 0
        lblQuestion.Text = "Question appears here"
        lblQuestion.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtAnswer
        ' 
        txtAnswer.BackColor = SystemColors.ScrollBar
        txtAnswer.Font = New Font("AniMe Matrix - MB_EN", 15.0F)
        txtAnswer.Location = New Point(282, 270)
        txtAnswer.Name = "txtAnswer"
        txtAnswer.Size = New Size(200, 31)
        txtAnswer.TabIndex = 1
        txtAnswer.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = SystemColors.ButtonShadow
        btnSubmit.Font = New Font("AniMe Matrix - MB_EN", 15.0F)
        btnSubmit.Location = New Point(282, 355)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(200, 40)
        btnSubmit.TabIndex = 2
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' lblTimer
        ' 
        lblTimer.BackColor = SystemColors.ControlDarkDark
        lblTimer.Font = New Font("AniMe Matrix - MB_EN", 15.0F)
        lblTimer.ForeColor = SystemColors.Control
        lblTimer.Location = New Point(27, 20)
        lblTimer.Name = "lblTimer"
        lblTimer.Size = New Size(150, 40)
        lblTimer.TabIndex = 3
        lblTimer.Text = "Time: 60"
        lblTimer.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblScore
        ' 
        lblScore.BackColor = SystemColors.ControlDarkDark
        lblScore.Font = New Font("AniMe Matrix - MB_EN", 15.0F)
        lblScore.ForeColor = SystemColors.ButtonFace
        lblScore.Location = New Point(597, 20)
        lblScore.Name = "lblScore"
        lblScore.Size = New Size(150, 40)
        lblScore.TabIndex = 4
        lblScore.Text = "Score: 0"
        lblScore.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = SystemColors.ButtonShadow
        btnExit.Font = New Font("AniMe Matrix - MB_EN", 15.0F)
        btnExit.Location = New Point(313, 424)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(150, 40)
        btnExit.TabIndex = 5
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' timerGame
        ' 
        timerGame.Interval = 1000
        ' 
        ' Answer
        ' 
        Answer.AutoSize = True
        Answer.BackColor = SystemColors.AppWorkspace
        Answer.Font = New Font("AniMe Matrix - MB_EN", 15.0F)
        Answer.Location = New Point(70, 273)
        Answer.Name = "Answer"
        Answer.Size = New Size(194, 24)
        Answer.TabIndex = 6
        Answer.Text = "Answer Here"
        Answer.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' MathGame
        ' 
        ' Updated BackgroundImage to reference the correct resource
        BackgroundImage = My.Resources.mathbg1  ' Use correct resource name
        ClientSize = New Size(800, 600)
        Controls.Add(Answer)
        Controls.Add(lblQuestion)
        Controls.Add(txtAnswer)
        Controls.Add(btnSubmit)
        Controls.Add(lblTimer)
        Controls.Add(lblScore)
        Controls.Add(btnExit)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "MathGame"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Math Game"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Private WithEvents lblQuestion As Label
    Private WithEvents txtAnswer As TextBox
    Private WithEvents btnSubmit As Button
    Private WithEvents lblTimer As Label
    Private WithEvents lblScore As Label
    Private WithEvents btnExit As Button
    Private WithEvents timerGame As Timer
    Private components As System.ComponentModel.IContainer
    Friend WithEvents Answer As Label
End Class
