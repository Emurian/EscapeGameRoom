Public Class MainMenu
    Dim selectedDifficulty As String

    Private Sub btnMathGame_Click(sender As Object, e As EventArgs) Handles btnMathGame.Click
        ' Pass the selected difficulty to the MathGame form
        Dim mathGame As New MathGame(selectedDifficulty)
        mathGame.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogicGame_Click(sender As Object, e As EventArgs) Handles btnLogicGame.Click
        ' Pass the selected difficulty to the LogicGame form
        Dim logicGame As New LogicGame(selectedDifficulty)
        logicGame.Show()
        Me.Hide()
    End Sub

    Private Sub btnPatternGame_Click(sender As Object, e As EventArgs) Handles btnPatternGame.Click
        ' Pass the selected difficulty to the PatternGame form
        Dim patternGame As New PatternGame(selectedDifficulty)
        patternGame.Show()
        Me.Hide()
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize ComboBox with difficulty levels (only once)
        cmbDifficulty.Items.Clear()
        cmbDifficulty.Items.Add("Easy")
        cmbDifficulty.Items.Add("Normal")
        cmbDifficulty.Items.Add("Hard")
        cmbDifficulty.SelectedIndex = 1 ' Default to "Normal"

        ' Set the selected difficulty
        selectedDifficulty = cmbDifficulty.SelectedItem.ToString()
    End Sub

    ' This event is triggered when a selection is made in the ComboBox
    Private Sub cmbDifficulty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDifficulty.SelectedIndexChanged
        ' Get the selected difficulty
        selectedDifficulty = cmbDifficulty.SelectedItem.ToString()
    End Sub
End Class
