<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso designerComponents IsNot Nothing Then
            designerComponents.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private designerComponents As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnMathGame = New Button()
        btnLogicGame = New Button()
        btnPatternGame = New Button()
        lblTitle = New Label()
        cmbDifficulty = New ComboBox()
        SuspendLayout()
        ' 
        ' btnMathGame
        ' 
        btnMathGame.BackColor = SystemColors.GrayText
        btnMathGame.Font = New Font("AniMe Matrix - MB_EN", 15.0F)
        btnMathGame.Location = New Point(250, 148)
        btnMathGame.Name = "btnMathGame"
        btnMathGame.Size = New Size(300, 60)
        btnMathGame.TabIndex = 0
        btnMathGame.Text = "Math Game"
        btnMathGame.UseVisualStyleBackColor = False
        ' 
        ' btnLogicGame
        ' 
        btnLogicGame.BackColor = Color.Gold
        btnLogicGame.Font = New Font("AniMe Matrix - MB_EN", 15.0F)
        btnLogicGame.Location = New Point(250, 253)
        btnLogicGame.Name = "btnLogicGame"
        btnLogicGame.Size = New Size(300, 60)
        btnLogicGame.TabIndex = 1
        btnLogicGame.Text = "Logic Game"
        btnLogicGame.UseVisualStyleBackColor = False
        ' 
        ' btnPatternGame
        ' 
        btnPatternGame.BackColor = SystemColors.GrayText
        btnPatternGame.Font = New Font("AniMe Matrix - MB_EN", 15.0F)
        btnPatternGame.Location = New Point(250, 361)
        btnPatternGame.Name = "btnPatternGame"
        btnPatternGame.Size = New Size(300, 60)
        btnPatternGame.TabIndex = 2
        btnPatternGame.Text = "Pattern Game"
        btnPatternGame.UseVisualStyleBackColor = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.BackColor = SystemColors.ControlDarkDark
        lblTitle.Font = New Font("AniMe Matrix - MB_EN", 20.0F)
        lblTitle.ForeColor = Color.Gold
        lblTitle.Location = New Point(213, 41)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(376, 32)
        lblTitle.TabIndex = 3
        lblTitle.Text = "Escape Room Game"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cmbDifficulty
        ' 
        cmbDifficulty.BackColor = SystemColors.ControlDarkDark
        cmbDifficulty.DropDownStyle = ComboBoxStyle.DropDownList
        cmbDifficulty.Font = New Font("AniMe Matrix - MB_EN", 14.0F)
        cmbDifficulty.FormattingEnabled = True
        cmbDifficulty.Items.AddRange(New Object() {"Easy", "Normal", "Hard"})
        cmbDifficulty.Location = New Point(250, 450)
        cmbDifficulty.Name = "cmbDifficulty"
        cmbDifficulty.Size = New Size(300, 31)
        cmbDifficulty.TabIndex = 4
        ' 
        ' MainMenu
        ' 
        BackgroundImage = My.Resources.Resources.MainBG11
        ClientSize = New Size(800, 600)
        Controls.Add(cmbDifficulty)
        Controls.Add(btnMathGame)
        Controls.Add(btnLogicGame)
        Controls.Add(btnPatternGame)
        Controls.Add(lblTitle)
        Font = New Font("Century Gothic", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "MainMenu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Main Menu"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    ' Declare controls
    Private WithEvents btnMathGame As Button
    Private WithEvents btnLogicGame As Button
    Private WithEvents btnPatternGame As Button
    Private lblTitle As Label
    Private WithEvents cmbDifficulty As ComboBox ' ComboBox for difficulty selection
End Class
