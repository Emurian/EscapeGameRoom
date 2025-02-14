Public Class PatternGame
    Dim WithEvents timer As Timer
    Dim score As Integer
    Dim timeLeft As Integer
    Dim currentSequence As List(Of Integer)
    Dim correctAnswer As Integer
    Dim previousSequences As New List(Of List(Of Integer))()

    ' Difficulty settings variables
    Dim pointsPerCorrect As Integer
    Dim pointsDeduction As Integer
    Dim difficulty As String

    ' Constructor to pass the selected difficulty
    Public Sub New(selectedDifficulty As String)
        InitializeComponent()
        difficulty = selectedDifficulty
    End Sub

    Private Sub PatternGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        ' Generate a new sequence that hasn't been used before
        currentSequence = New List(Of Integer)
        Do
            currentSequence.Clear()
            For i As Integer = 0 To sequenceLength - 1
                currentSequence.Add(startNum + (i * stepValue))
            Next
        Loop While previousSequences.Contains(currentSequence)

        ' Add the current sequence to the list of previously used sequences
        previousSequences.Add(New List(Of Integer)(currentSequence))

        correctAnswer = startNum + (sequenceLength * stepValue)

        lblPattern.Text = "Sequence: " & String.Join(", ", currentSequence) & ", ?"
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim userAnswer As Integer
        If Integer.TryParse(txtUserInput.Text, userAnswer) Then
            If userAnswer = correctAnswer Then
                score += pointsPerCorrect
            Else
                score -= pointsDeduction
                If score < 0 Then
                    score = 0
                End If
            End If
            lblScore.Text = "Score: " & score
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
