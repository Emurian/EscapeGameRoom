<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ResultsScreen
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        lblTitle = New Label()
        lblFinalScore = New Label()
        btnMainMenu = New Button()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.BackColor = Color.IndianRed
        lblTitle.Font = New Font("Arial", 16.0F, FontStyle.Bold)
        lblTitle.Location = New Point(50, 30)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(300, 30)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Game Over! You Failed to Escape!!"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblFinalScore
        ' 
        lblFinalScore.BackColor = Color.Gainsboro
        lblFinalScore.Font = New Font("Arial", 14.0F)
        lblFinalScore.Location = New Point(50, 80)
        lblFinalScore.Name = "lblFinalScore"
        lblFinalScore.Size = New Size(300, 30)
        lblFinalScore.TabIndex = 1
        lblFinalScore.Text = "Final Score: 0"
        lblFinalScore.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnMainMenu
        ' 
        btnMainMenu.BackColor = SystemColors.AppWorkspace
        btnMainMenu.Location = New Point(50, 130)
        btnMainMenu.Name = "btnMainMenu"
        btnMainMenu.Size = New Size(120, 40)
        btnMainMenu.TabIndex = 2
        btnMainMenu.Text = "Main Menu"
        btnMainMenu.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = SystemColors.AppWorkspace
        btnExit.Location = New Point(230, 130)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(120, 40)
        btnExit.TabIndex = 3
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' ResultsScreen
        ' 
        ' Set the background image from resources
        BackgroundImage = My.Resources.ResultScreenBG ' Ensure this matches the resource name in your project
        ClientSize = New Size(400, 200)
        Controls.Add(lblTitle)
        Controls.Add(lblFinalScore)
        Controls.Add(btnMainMenu)
        Controls.Add(btnExit)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "ResultsScreen"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Results"
        ResumeLayout(False)
    End Sub

    Private WithEvents lblTitle As Label
    Private WithEvents lblFinalScore As Label
    Private WithEvents btnMainMenu As Button
    Private WithEvents btnExit As Button
End Class
