Public Class MainMenu
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnHowToPlay_Click(sender As Object, e As EventArgs) Handles btnHowToPlay.Click
        HowToPlay.Show()
        Me.Hide()
    End Sub

    Private Sub btnExitGame_Click(sender As Object, e As EventArgs) Handles btnExitGame.Click
        Application.Exit()
    End Sub

    Private Sub btnCheat_Click(sender As Object, e As EventArgs) 
        Cheats.Show()
        Me.Hide()
    End Sub
End Class