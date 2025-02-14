Public Class MainMenu
    Private Sub btnMathGame_Click(sender As Object, e As EventArgs) Handles btnMathGame.Click
        Dim mathGame As New MathGame()
        mathGame.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogicGame_Click(sender As Object, e As EventArgs) Handles btnLogicGame.Click
        Dim logicGame As New LogicGame()
        logicGame.Show()
        Me.Hide()
    End Sub

    Private Sub btnPatternGame_Click(sender As Object, e As EventArgs) Handles btnPatternGame.Click
        Dim patternGame As New PatternGame()
        patternGame.Show()
        Me.Hide()
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub




End Class
