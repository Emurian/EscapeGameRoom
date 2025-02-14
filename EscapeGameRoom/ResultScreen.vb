Public Class ResultsScreen
    Private finalScore As Integer

    ' Constructor to receive score
    Public Sub New(score As Integer)
        InitializeComponent()
        finalScore = score
        lblFinalScore.Text = $"Final Score: {finalScore}"

        ' Determine escape status based on the score
        If finalScore < 50 Then
            lblTitle.Text = "Failed to Escape!"
            lblTitle.BackColor = Color.IndianRed
        ElseIf finalScore >= 100 Then
            lblTitle.Text = "You Escaped!"
            lblTitle.BackColor = Color.ForestGreen
        Else
            lblTitle.Text = "Close, Try Again!"
            lblTitle.BackColor = Color.Goldenrod
        End If
    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Dim mainMenu As New MainMenu()
        mainMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
