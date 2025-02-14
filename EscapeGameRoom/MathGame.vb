Public Class MathGame
    ' Declare variables for difficulty-based settings
    Private rnd As New Random()
    Private num1 As Integer
    Private num2 As Integer
    Private operation As String
    Private correctAnswer As Integer
    Private score As Integer = 0
    Private timeLeft As Integer
    Private pointsPerCorrect As Integer
    Private pointsDeduction As Integer
    Private difficulty As String ' Stores selected difficulty

    ' Constructor that accepts difficulty as a parameter
    Public Sub New(selectedDifficulty As String)
        InitializeComponent()
        difficulty = selectedDifficulty
    End Sub

    Private Sub MathGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set game parameters based on selected difficulty
        Select Case difficulty
            Case "Easy"
                timeLeft = 90
                pointsPerCorrect = 20
                pointsDeduction = 10
            Case "Normal"
                timeLeft = 60
                pointsPerCorrect = 15
                pointsDeduction = 10
            Case "Hard"
                timeLeft = 30
                pointsPerCorrect = 30
                pointsDeduction = 25
        End Select

        lblScore.Text = $"Score: {score}"
        lblTimer.Text = $"Time: {timeLeft}"

        ' Start the game timer
        timerGame.Start()

        ' Generate the first question
        GenerateQuestion()
    End Sub

    Private Sub GenerateQuestion()
        ' Generate random numbers and operators for the math question
        num1 = rnd.Next(1, 20)
        num2 = rnd.Next(1, 20)
        Dim opIndex As Integer = rnd.Next(0, 4)

        Select Case opIndex
            Case 0
                operation = "+"
                correctAnswer = num1 + num2
            Case 1
                operation = "-"
                correctAnswer = num1 - num2
            Case 2
                operation = "*"
                correctAnswer = num1 * num2
            Case 3
                operation = "/"
                If num2 = 0 Then num2 = 1
                num1 = num2 * rnd.Next(1, 10) ' Ensure division is whole number
                correctAnswer = num1 \ num2
        End Select

        lblQuestion.Text = $"{num1} {operation} {num2} = ?"
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim userAnswer As Integer

        If Integer.TryParse(txtAnswer.Text, userAnswer) Then
            If userAnswer = correctAnswer Then
                score += pointsPerCorrect
            Else
                score -= pointsDeduction
                If score < 0 Then score = 0 ' Prevent negative score
            End If

            lblScore.Text = $"Score: {score}"
            txtAnswer.Clear()
            GenerateQuestion()
        Else
            MessageBox.Show("Please enter a valid number.", "Invalid Input")
        End If
    End Sub

    Private Sub timerGame_Tick(sender As Object, e As EventArgs) Handles timerGame.Tick
        timeLeft -= 1
        lblTimer.Text = $"Time: {timeLeft}"

        If timeLeft <= 0 Then
            timerGame.Stop()
            MessageBox.Show($"Time's up! Your score: {score}", "Game Over")
            Dim resultScreen As New ResultsScreen(score)
            resultScreen.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim mainMenu As New MainMenu()
        mainMenu.Show()
        Me.Close()
    End Sub
End Class
