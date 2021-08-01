Public Class Level_2
    Dim Player As Monkey
    Dim Maze As MazeMonkey
    Dim WizardMonkey As Enemy
    Dim WizardMonkey2 As Enemy
    Dim WizardMonkey3 As Enemy
    Dim WizardMonkey4 As Enemy
    Dim WizardMonkey5 As Enemy
    Dim WizardMonkey6 As Enemy
    Dim WizardMonkey7 As Enemy
    Dim WizardMonkey8 As Enemy
    Dim BananaPoint As Banana
    Dim R As New Random
    Dim PowerUp As PowerUp
    Private Sub Level_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Xmap As Integer
        Dim Ymap As Integer
        Maze = New MazeMonkey(My.Resources.Images.Path, 20, 20, 40, 40, 15, 15, True)
        Maze.Image2 = My.Resources.Images.Wall
        Maze.map(8, 6) = "path"
        Maze.map(8, 7) = "path"
        Maze.map(8, 8) = "path"
        Maze.map(8, 9) = "path"
        Maze.map(8, 10) = "path"
        Maze.map(8, 11) = "path"
        Maze.map(7, 14) = "path"
        Maze.map(8, 14) = "path"
        Maze.map(8, 12) = "path"
        Maze.map(3, 3) = "path"
        Maze.map(3, 2) = "path"
        Maze.map(3, 14) = "path"
        Maze.map(2, 3) = "path"
        Maze.map(2, 4) = "path"
        Maze.map(2, 5) = "path"
        Maze.map(2, 6) = "path"
        Maze.map(2, 7) = "path"
        Maze.map(2, 8) = "path"
        Maze.map(2, 9) = "path"
        Maze.map(2, 10) = "path"
        Maze.map(2, 11) = "path"
        Maze.map(2, 12) = "path"
        Maze.map(2, 13) = "path"
        Maze.map(2, 14) = "path"
        Maze.map(4, 3) = "path"
        Maze.map(4, 5) = "path"
        Maze.map(4, 6) = "path"
        Maze.map(4, 7) = "path"
        Maze.map(4, 8) = "path"
        Maze.map(4, 9) = "path"
        Maze.map(4, 10) = "path"
        Maze.map(4, 11) = "path"
        Maze.map(4, 12) = "path"
        Maze.map(4, 13) = "path"
        Maze.map(4, 14) = "path"
        Maze.map(5, 2) = "path"
        Maze.map(5, 3) = "path"
        Maze.map(5, 5) = "path"
        Maze.map(5, 7) = "path"
        Maze.map(5, 14) = "path"
        Maze.map(6, 2) = "path"
        Maze.map(6, 5) = "path"
        Maze.map(6, 6) = "path"
        Maze.map(6, 7) = "path"
        Maze.map(6, 8) = "path"
        Maze.map(6, 9) = "path"
        Maze.map(6, 10) = "path"
        Maze.map(6, 11) = "path"
        Maze.map(6, 12) = "path"
        Maze.map(6, 13) = "path"
        Maze.map(6, 14) = "path"
        Maze.map(7, 2) = "path"
        Maze.map(7, 3) = "path"
        Maze.map(7, 5) = "path"
        Maze.map(7, 9) = "path"
        Maze.map(8, 3) = "path"
        Maze.map(8, 5) = "path"
        Maze.map(8, 13) = "path"
        Maze.map(9, 2) = "path"
        Maze.map(9, 3) = "path"
        Maze.map(9, 5) = "path"
        Maze.map(9, 12) = "path"
        Maze.map(9, 14) = "path"
        Maze.map(10, 2) = "path"
        Maze.map(10, 5) = "path"
        Maze.map(10, 6) = "path"
        Maze.map(10, 7) = "path"
        Maze.map(10, 8) = "path"
        Maze.map(10, 9) = "path"
        Maze.map(10, 10) = "path"
        Maze.map(10, 11) = "path"
        Maze.map(10, 12) = "path"
        Maze.map(10, 13) = "path"
        Maze.map(10, 14) = "path"
        Maze.map(11, 2) = "path"
        Maze.map(11, 3) = "path"
        Maze.map(11, 5) = "path"
        Maze.map(11, 14) = "path"
        Maze.map(10, 13) = "path"
        Maze.map(10, 14) = "path"
        Maze.map(11, 2) = "path"
        Maze.map(11, 9) = "path"
        Maze.map(11, 14) = "path"
        Maze.map(12, 3) = "path"
        Maze.map(12, 5) = "path"
        Maze.map(12, 6) = "path"
        Maze.map(12, 7) = "path"
        Maze.map(12, 8) = "path"
        Maze.map(12, 9) = "path"
        Maze.map(12, 10) = "path"
        Maze.map(12, 11) = "path"
        Maze.map(12, 12) = "path"
        Maze.map(12, 13) = "path"
        Maze.map(12, 14) = "path"
        Maze.map(13, 2) = "path"
        Maze.map(13, 3) = "path"
        Maze.map(13, 14) = "path"
        Maze.map(14, 2) = "path"
        Maze.map(14, 3) = "path"
        Maze.map(14, 4) = "path"
        Maze.map(14, 5) = "path"
        Maze.map(14, 6) = "path"
        Maze.map(14, 7) = "path"
        Maze.map(14, 8) = "path"
        Maze.map(14, 9) = "path"
        Maze.map(14, 10) = "path"
        Maze.map(14, 11) = "path"
        Maze.map(14, 12) = "path"
        Maze.map(14, 13) = "path"
        Maze.map(14, 14) = "path"


        Player = New Monkey(My.Resources.Images.Player, 35, 25, 3, 2, True)


        WizardMonkey = New Enemy(My.Resources.Images.RedMonkeyLeft, 15, 15, 14, 14, True)


        WizardMonkey2 = New Enemy(My.Resources.Images.RedMonkeyDown, 15, 15, 14, 14, True)


        WizardMonkey3 = New Enemy(My.Resources.Images.RedMonkeyUp, 15, 15, 14, 6, True)

        WizardMonkey4 = New Enemy(My.Resources.Images.RedMonkeyUp, 15, 15, 14, 10, True)

        WizardMonkey5 = New Enemy(My.Resources.Images.RedMonkeyDown, 15, 15, 5, 4, True)

        WizardMonkey6 = New Enemy(My.Resources.Images.RedMonkeyDown, 15, 15, 5, 8, True)

        WizardMonkey7 = New Enemy(My.Resources.Images.RedMonkeyDown, 15, 15, 5, 12, True)

        WizardMonkey8 = New Enemy(My.Resources.Images.RedMonkeyDown, 15, 15, 14, 14, True)


        BananaPoint = New Banana(My.Resources.Images.Banana, 20, 20, 13, 8, True)

        tmrMaze.Enabled = True
        tmrMaze.Interval = 100
        tmrMaze.Start()
        Xmap = Player.MapX
        Ymap = Player.MapY
        LblPoints.Text = 100
        Player.Score = 100
    End Sub
    Private Sub Form1_Paint(Sender As System.Object, e As System.EventArgs) Handles MyBase.Paint

        Maze.draw(e)
        Player.draw(e)
        WizardMonkey.draw(e)
        WizardMonkey2.draw(e)
        WizardMonkey3.draw(e)
        WizardMonkey4.draw(e)
        WizardMonkey5.draw(e)
        WizardMonkey6.draw(e)
        BananaPoint.draw(e)

    End Sub
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        Me.DoubleBuffered = True
        Dim MapX As Integer
        Dim MapY As Integer
        Dim Touched As Boolean = False
        Dim BananaLocation As Integer
        If e.KeyCode = Keys.Down Then
            MapX = Player.MapX
            MapY = Player.MapY
            If Maze.map(MapX, MapY + 1) = "path" Then
                Player.Image = My.Resources.Images.Player_Down
                Player.MoveDown()
                MapX = Player.MapX
                MapY = Player.MapY
                Me.Refresh()
            End If
        End If

        If e.KeyCode = Keys.Up Then
            MapX = Player.MapX
            MapY = Player.MapY
            If Maze.map(MapX, MapY - 1) = "path" Then
                Player.Image = My.Resources.Images.Player
                Player.MoveUp()
                MapX = Player.MapX
                MapY = Player.MapX
                Me.Refresh()
            End If
        End If

        If e.KeyCode = Keys.Left Then
            MapX = Player.MapX
            MapY = Player.MapY
            If Maze.map(MapX - 1, MapY) = "path" Then
                Player.Image = My.Resources.Images.Player_Left
                Player.MoveLeft()
                MapX = Player.MapX
                MapY = Player.MapX
                Me.Refresh()
            End If
        End If

        If e.KeyCode = Keys.Right Then
            MapX = Player.MapX
            MapY = Player.MapY
            If Maze.map(MapX + 1, MapY) = "path" Then
                Player.Image = My.Resources.Images.Player_Right
                Player.MoveRight()
                MapX = Player.MapX
                MapY = Player.MapX
                Me.Refresh()
            End If
        End If
        If Touched = False Then
            If Player.Touching(BananaPoint) Then

                Player.Score = Player.Score + 10
                LblPoints.Text = Player.Score
                BananaLocation = R.Next(1, 10)
            End If
            Touched = True
        End If
        If Player.Score = 200 Then
            MessageBox.Show("Game Complete")
            Application.Exit()


        End If

        Select Case BananaLocation
            Case 0

            Case 1
                BananaPoint = New Banana(My.Resources.Images.Banana, 20, 20, 14, 14, True)
            Case 2
                BananaPoint = New Banana(My.Resources.Images.Banana, 20, 20, 2, 2, True)
            Case 3
                BananaPoint = New Banana(My.Resources.Images.Banana, 20, 20, 9, 7, True)
            Case 4
                BananaPoint = New Banana(My.Resources.Images.Banana, 20, 20, 9, 8, True)
            Case 5
                BananaPoint = New Banana(My.Resources.Images.Banana, 20, 20, 12, 12, True)
            Case 6
                BananaPoint = New Banana(My.Resources.Images.Banana, 20, 20, 11, 8, True)
            Case 7
                BananaPoint = New Banana(My.Resources.Images.Banana, 20, 20, 11, 4, True)
            Case 8
                BananaPoint = New Banana(My.Resources.Images.Banana, 20, 20, 3, 7, True)
            Case 9
                BananaPoint = New Banana(My.Resources.Images.Banana, 20, 20, 14, 6, True)
            Case 10
                BananaPoint = New Banana(My.Resources.Images.Banana, 20, 20, 14, 10, True)


        End Select
    End Sub
    Private Sub tmrMaze_Tick(sender As Object, e As EventArgs) Handles tmrMaze.Tick

        DoubleBuffered = True
        If (WizardMonkey.MapX > 2) And WizardMonkey.Movment = "Left" Then
            WizardMonkey.Image = My.Resources.Images.RedMonkeyLeft
            WizardMonkey.MoveLeft()
            If Player.Touching(WizardMonkey) Then

                If pbrHealth.Value > 0 Then pbrHealth.Value -= 10


            End If
        Else
            WizardMonkey.Movment = "Right"
            Me.Refresh()


        End If
        If (WizardMonkey.MapX < 14) And WizardMonkey.Movment = "Right" Then
            WizardMonkey.Image = My.Resources.Images.RedMonkeyRight
            WizardMonkey.MoveRight()
            If Player.Touching(WizardMonkey) Then
                If pbrHealth.Value > 0 Then pbrHealth.Value -= 10


            End If
        Else
            WizardMonkey.Movment = "Left"
            Me.Refresh()

        End If


        If (WizardMonkey2.MapY < 14) And WizardMonkey2.Movment = "Down" Then
            WizardMonkey2.Image = My.Resources.Images.RedMonkeyDown
            WizardMonkey2.MoveDown()
            If Player.Touching(WizardMonkey2) Then
                If pbrHealth.Value > 0 Then pbrHealth.Value -= 10



            End If
        Else
            WizardMonkey2.Movment = "Up"
            Me.Refresh()


        End If
        If (WizardMonkey2.MapY > 2) And WizardMonkey2.Movment = "Up" Then
            WizardMonkey2.Image = My.Resources.Images.RedMonkeyUp
            WizardMonkey2.MoveUp()
            If Player.Touching(WizardMonkey2) Then
                If pbrHealth.Value > 0 Then pbrHealth.Value -= 10

            End If
        Else
            WizardMonkey2.Movment = "Down"
            Me.Refresh()
        End If

        If (WizardMonkey3.MapY < 14) And WizardMonkey3.Movment = "Down" Then
            WizardMonkey3.Image = My.Resources.Images.RedMonkeyDown
            WizardMonkey3.MoveDown()
            If Player.Touching(WizardMonkey3) Then
                If pbrHealth.Value > 0 Then pbrHealth.Value -= 10


            End If
        Else
            WizardMonkey3.Movment = "Up"
            Me.Refresh()


        End If
        If (WizardMonkey3.MapY > 5) And WizardMonkey3.Movment = "Up" Then
            WizardMonkey3.Image = My.Resources.Images.RedMonkeyUp
            WizardMonkey3.MoveUp()
            If Player.Touching(WizardMonkey3) Then
                If pbrHealth.Value > 0 Then pbrHealth.Value -= 10

            End If
        Else
            WizardMonkey3.Movment = "Down"
            Me.Refresh()
        End If

        If (WizardMonkey4.MapY < 14) And WizardMonkey4.Movment = "Down" Then
            WizardMonkey4.Image = My.Resources.Images.RedMonkeyDown
            WizardMonkey4.MoveDown()
            If Player.Touching(WizardMonkey4) Then
                If pbrHealth.Value > 0 Then pbrHealth.Value -= 10



            End If
        Else
            WizardMonkey4.Movment = "Up"
            Me.Refresh()


        End If
        If (WizardMonkey4.MapY > 5) And WizardMonkey4.Movment = "Up" Then
            WizardMonkey4.Image = My.Resources.Images.RedMonkeyUp
            WizardMonkey4.MoveUp()
            If Player.Touching(WizardMonkey4) Then
                If pbrHealth.Value > 0 Then pbrHealth.Value -= 10
            End If
        Else
            WizardMonkey4.Movment = "Down"
            Me.Refresh()
        End If

        If (WizardMonkey5.MapY < 14) And WizardMonkey5.Movment = "Down" Then
            WizardMonkey5.Image = My.Resources.Images.RedMonkeyDown
            WizardMonkey5.MoveDown()
            If Player.Touching(WizardMonkey5) Then
                If pbrHealth.Value > 0 Then pbrHealth.Value -= 10


            End If
        Else
            WizardMonkey5.Movment = "Up"
            Me.Refresh()


        End If
        If (WizardMonkey5.MapY > 5) And WizardMonkey5.Movment = "Up" Then
            WizardMonkey5.Image = My.Resources.Images.RedMonkeyUp
            WizardMonkey5.MoveUp()
            If Player.Touching(WizardMonkey5) Then
                If pbrHealth.Value > 0 Then pbrHealth.Value -= 10

            End If
        Else
            WizardMonkey5.Movment = "Down"
            Me.Refresh()
        End If
        If (WizardMonkey6.MapY < 14) And WizardMonkey6.Movment = "Down" Then
            WizardMonkey6.Image = My.Resources.Images.RedMonkeyDown
            WizardMonkey6.MoveDown()
            If Player.Touching(WizardMonkey6) Then
                If pbrHealth.Value > 0 Then pbrHealth.Value -= 10


            End If
        Else
            WizardMonkey6.Movment = "Up"
            Me.Refresh()


        End If
        If (WizardMonkey6.MapY > 5) And WizardMonkey6.Movment = "Up" Then
            WizardMonkey6.Image = My.Resources.Images.RedMonkeyUp
            WizardMonkey6.MoveUp()
            If Player.Touching(WizardMonkey6) Then
                If pbrHealth.Value > 0 Then pbrHealth.Value -= 10

            End If
        Else
            WizardMonkey6.Movment = "Down"
            Me.Refresh()
        End If
        If pbrHealth.Value = 0 Then

            MessageBox.Show("Game Over")
            MessageBox.Show(Player.Score)
            Application.Exit()

        End If

    End Sub

End Class