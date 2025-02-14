Public Class MathGame
    Private rnd As New Random()
    Private num1 As Integer
    Private num2 As Integer
    Private operation As String
    Private correctAnswer As Integer
    Private score As Integer = 0
    Private timeLeft As Integer = 60

    Private Sub MathGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateQuestion()
        timerGame.Start()
    End Sub

    Private Sub GenerateQuestion()
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
                score += 10
            Else
                score -= 10
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
