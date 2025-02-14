Public Class LogicGame
    Private rnd As New Random()
    Private riddles As New Dictionary(Of String, String) From {
        {"I speak without a mouth and hear without ears. I have no body, but I come alive with wind. What am I?", "echo"},
        {"The more you take, the more you leave behind. What am I?", "footsteps"},
        {"I have cities, but no houses. I have mountains, but no trees. I have water, but no fish. What am I?", "map"},
        {"What has to be broken before you can use it?", "egg"},
        {"What comes once in a minute, twice in a moment, but never in a thousand years?", "the letter m"},
        {"What has keys but can't open locks?", "piano"},
        {"I am tall when I am young, and I am short when I am old. What am I?", "candle"},
        {"What can travel around the world while staying in the corner?", "stamp"},
        {"I am not alive, but I grow; I do not have lungs, but I need air; I do not have a mouth, and I can drown. What am I?", "fire"},
        {"What has a heart that doesn't beat?", "artichoke"},
        {"What begins with T, ends with T, and has T in it?", "teapot"},
        {"What is always in front of you but can't be seen?", "future"},
        {"What has one head, one foot, and four legs?", "bed"},
        {"What can be cracked, made, told, and played?", "joke"},
        {"What has a neck but no head?", "bottle"},
        {"What is full of holes but still holds a lot of weight?", "net"},
        {"What comes down but never goes up?", "rain"},
        {"What has a face but can't smile?", "clock"},
        {"What has many keys but can't open a single door?", "keyboard"},
        {"What has a tail but no body?", "coin"},
        {"What is made of water but can never get wet?", "reflection"},
        {"What has a bed but never sleeps?", "river"},
        {"What is light as a feather, yet the strongest man can't hold it?", "breath"},
        {"What starts with an E, ends with an E, but only has one letter?", "envelope"},
        {"What has legs but doesn't walk?", "table"},
        {"What is so fragile that saying its name breaks it?", "silence"},
        {"What is always coming but never arrives?", "tomorrow"},
        {"What has four legs but can't walk?", "chair"},
        {"What gets wetter the more it dries?", "towel"},
        {"What can you catch but not throw?", "cold"},
        {"What has one eye but can’t see?", "needle"},
        {"What is yours but mostly used by others?", "name"},
        {"What can be cracked, but never held?", "phone"}
    }

    Private hints As New Dictionary(Of String, String) From {
        {"echo", "Think about sound."},
        {"footsteps", "Look behind you when you walk."},
        {"map", "Used for navigation."},
        {"egg", "You usually eat it for breakfast."},
        {"the letter m", "Look at the wordplay."},
        {"piano", "It's a musical instrument."},
        {"candle", "It's used to provide light."},
        {"stamp", "It's on letters."},
        {"fire", "It's hot and dangerous."},
        {"artichoke", "It's a type of vegetable."},
        {"teapot", "It's used for tea."},
        {"future", "It's ahead of you."},
        {"bed", "You sleep on it."},
        {"joke", "It makes people laugh."},
        {"bottle", "It holds liquid."},
        {"net", "Used for fishing."},
        {"rain", "It falls from the sky."},
        {"clock", "It tells the time."},
        {"keyboard", "It has black and white keys."},
        {"coin", "You use it to buy things."},
        {"reflection", "You can see yourself in it."},
        {"river", "It flows with water."},
        {"breath", "You do it constantly."},
        {"envelope", "It holds letters."},
        {"table", "You eat on it."},
        {"silence", "It is the absence of sound."},
        {"tomorrow", "It’s the day after today."},
        {"chair", "You sit on it."},
        {"towel", "Used to dry yourself."},
        {"cold", "It makes you shiver."},
        {"needle", "It sews fabric."},
        {"name", "It’s what people call you."},
        {"phone", "You use it to make calls."}
    }

    Private usedRiddles As New List(Of String)() ' List to track used riddles
    Private currentRiddle As String
    Private correctAnswer As String
    Private score As Integer = 0
    Private timeLeft As Integer = 60

    Private Sub LogicGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateRiddle()
        timerGame.Start()
    End Sub

    Private Sub GenerateRiddle()
        If riddles.Count = usedRiddles.Count Then
            usedRiddles.Clear() ' Reset used riddles when all have been used
        End If

        Dim availableRiddles As List(Of String) = riddles.Keys.Except(usedRiddles).ToList()
        Dim index As Integer = rnd.Next(availableRiddles.Count)
        currentRiddle = availableRiddles(index)
        correctAnswer = riddles(currentRiddle)
        lblRiddle.Text = currentRiddle
        lblHint.Text = ""

        usedRiddles.Add(currentRiddle)
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim userAnswer As String = txtAnswer.Text.Trim().ToLower()

        If userAnswer = correctAnswer Then
            score += 10
        Else
            score -= 10
        End If

        lblScore.Text = $"Score: {score}"
        txtAnswer.Clear()
        GenerateRiddle()
    End Sub

    Private Sub btnHint_Click(sender As Object, e As EventArgs) Handles btnHint.Click
        If hints.ContainsKey(correctAnswer) Then
            lblHint.Text = hints(correctAnswer)
            score -= 5
            lblScore.Text = $"Score: {score}"
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
