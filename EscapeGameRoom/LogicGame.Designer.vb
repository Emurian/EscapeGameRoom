<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LogicGame
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblRiddle = New Label()
        txtAnswer = New TextBox()
        btnSubmit = New Button()
        btnHint = New Button()
        lblHint = New Label()
        lblTimer = New Label()
        lblScore = New Label()
        btnExit = New Button()
        timerGame = New Timer(components)
        SuspendLayout()
        ' 
        ' lblRiddle
        ' 
        lblRiddle.BackColor = SystemColors.ActiveCaption
        lblRiddle.Font = New Font("AniMe Matrix - MB_EN", 15.0F, FontStyle.Bold)
        lblRiddle.Location = New Point(153, 85)
        lblRiddle.Name = "lblRiddle"
        lblRiddle.Size = New Size(500, 50)
        lblRiddle.TabIndex = 0
        lblRiddle.Text = "Riddle appears here"
        lblRiddle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtAnswer
        ' 
        txtAnswer.BackColor = SystemColors.InactiveCaption
        txtAnswer.Font = New Font("AniMe Matrix - MB_EN", 15.0F, FontStyle.Bold)
        txtAnswer.Location = New Point(260, 187)
        txtAnswer.Name = "txtAnswer"
        txtAnswer.Size = New Size(250, 31)
        txtAnswer.TabIndex = 1
        txtAnswer.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = SystemColors.ActiveCaption
        btnSubmit.Font = New Font("AniMe Matrix - MB_EN", 15.0F, FontStyle.Bold)
        btnSubmit.Location = New Point(307, 242)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(150, 40)
        btnSubmit.TabIndex = 2
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' btnHint
        ' 
        btnHint.BackColor = Color.RosyBrown
        btnHint.Font = New Font("AniMe Matrix - MB_EN", 15.0F, FontStyle.Bold)
        btnHint.Location = New Point(24, 389)
        btnHint.Name = "btnHint"
        btnHint.Size = New Size(150, 40)
        btnHint.TabIndex = 3
        btnHint.Text = "Hint (-5 pts)"
        btnHint.UseVisualStyleBackColor = False
        ' 
        ' lblHint
        ' 
        lblHint.BackColor = SystemColors.ActiveCaption
        lblHint.Font = New Font("AniMe Matrix - MB_EN", 15.0F, FontStyle.Bold)
        lblHint.Location = New Point(24, 447)
        lblHint.Name = "lblHint"
        lblHint.Size = New Size(751, 80)
        lblHint.TabIndex = 4
        lblHint.Text = "Hint will appear here"
        lblHint.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTimer
        ' 
        lblTimer.BackColor = Color.IndianRed
        lblTimer.Font = New Font("AniMe Matrix - MB_EN", 15.0F, FontStyle.Bold)
        lblTimer.Location = New Point(625, 28)
        lblTimer.Name = "lblTimer"
        lblTimer.Size = New Size(150, 40)
        lblTimer.TabIndex = 5
        lblTimer.Text = "Time: 60"
        lblTimer.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblScore
        ' 
        lblScore.BackColor = SystemColors.ActiveCaption
        lblScore.Font = New Font("AniMe Matrix - MB_EN", 15.0F, FontStyle.Bold)
        lblScore.Location = New Point(35, 28)
        lblScore.Name = "lblScore"
        lblScore.Size = New Size(208, 40)
        lblScore.TabIndex = 6
        lblScore.Text = "Score: 0"
        lblScore.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.IndianRed
        btnExit.Font = New Font("AniMe Matrix - MB_EN", 15.0F, FontStyle.Bold)
        btnExit.Location = New Point(307, 347)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(150, 40)
        btnExit.TabIndex = 7
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' timerGame
        ' 
        timerGame.Interval = 1000
        ' 
        ' LogicGame
        ' 
        BackgroundImage = My.Resources.Resources.Logicbg
        ClientSize = New Size(800, 600)
        Controls.Add(lblRiddle)
        Controls.Add(txtAnswer)
        Controls.Add(btnSubmit)
        Controls.Add(btnHint)
        Controls.Add(lblHint)
        Controls.Add(lblTimer)
        Controls.Add(lblScore)
        Controls.Add(btnExit)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "LogicGame"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Logic Game"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents lblRiddle As Label
    Private WithEvents txtAnswer As TextBox
    Private WithEvents btnSubmit As Button
    Private WithEvents btnHint As Button
    Private WithEvents lblHint As Label
    Private WithEvents lblTimer As Label
    Private WithEvents lblScore As Label
    Private WithEvents btnExit As Button
    Private WithEvents timerGame As Timer
    Private components As System.ComponentModel.IContainer
End Class
