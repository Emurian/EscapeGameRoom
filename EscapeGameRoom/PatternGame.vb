Public Class PatternGame
    Dim WithEvents timer As Timer
    Dim score As Integer
    Dim timeLeft As Integer
    Dim currentSequence As List(Of Integer)
    Dim correctAnswer As Integer

    Private Sub PatternGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        score = 0
        timeLeft = 60
        lblScore.Text = "Score: " & score
        lblTimeLeft.Text = "Time Left: " & timeLeft

        timer = New Timer()
        timer.Interval = 1000
        timer.Start()

        GenerateSequence()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        timeLeft -= 1
        lblTimeLeft.Text = "Time Left: " & timeLeft

        If timeLeft = 0 Then
            timer.Stop()
            Dim result As New ResultsScreen(score)
            result.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub GenerateSequence()
        Dim rand As New Random()
        Dim startNum As Integer = rand.Next(1, 10)
        Dim stepValue As Integer = rand.Next(1, 5)
        Dim sequenceLength As Integer = 4

        currentSequence = New List(Of Integer)
        For i As Integer = 0 To sequenceLength - 1
            currentSequence.Add(startNum + (i * stepValue))
        Next

        correctAnswer = startNum + (sequenceLength * stepValue)

        lblPattern.Text = "Sequence: " & String.Join(", ", currentSequence) & ", ?"
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim userAnswer As Integer
        If Integer.TryParse(txtUserInput.Text, userAnswer) Then
            If userAnswer = correctAnswer Then
                score += 10
                lblScore.Text = "Score: " & score
            Else
                score -= 10
                If score < 0 Then
                    score = 0
                End If
                lblScore.Text = "Score: " & score
            End If
        End If

        txtUserInput.Clear()
        GenerateSequence()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim mainMenu As New MainMenu()
        mainMenu.Show()
        Me.Close()
    End Sub
End Class