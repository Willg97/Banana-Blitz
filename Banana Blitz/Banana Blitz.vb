Public Class Form1
    Dim Player As Monkey
    Dim Maze As MazeMonkey
    Dim RedMonkey As Enemy
    Dim RedMonkey2 As Enemy
    Dim RedMonkey3 As Enemy
    Dim RedMonkey4 As Enemy
    Dim BananaPoint As Banana
    Dim PowerUp As PowerUp
    Dim R As New Random
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim Xmap As Integer
        Dim Ymap As Integer
        Maze = New MazeMonkey(My.Resources.Images.Path, 20, 20, 40, 40, 15, 15, True)
        Maze.Image2 = My.Resources.Images.Wall


        Maze.Colour = Brushes.DarkGreen
        Maze.map(2, 2) = "path"
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
        Maze.map(3, 5) = "path"
        Maze.map(3, 8) = "path"
        Maze.map(3, 2) = "path"
        Maze.map(3, 14) = "path"
        Maze.map(4, 2) = "path"
        Maze.map(4, 3) = "path"
        Maze.map(4, 4) = "path"
        Maze.map(4, 5) = "path"
        Maze.map(4, 6) = "path"
        Maze.map(4, 7) = "path"
        Maze.map(4, 8) = "path"
        Maze.map(4, 9) = "path"
        Maze.map(4, 10) = "path"
        Maze.map(4, 11) = "path"
        Maze.map(4, 12) = "path"
        Maze.map(4, 14) = "path"
        Maze.map(5, 2) = "path"
        Maze.map(5, 7) = "path"
        Maze.map(5, 14) = "path"
        Maze.map(6, 2) = "path"
        Maze.map(6, 3) = "path"
        Maze.map(6, 4) = "path"
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
        Maze.map(7, 3) = "path"
        Maze.map(7, 9) = "path"
        Maze.map(7, 14) = "path"
        Maze.map(8, 2) = "path"
        Maze.map(8, 3) = "path"
        Maze.map(8, 4) = "path"
        Maze.map(8, 5) = "path"
        Maze.map(8, 6) = "path"
        Maze.map(8, 7) = "path"
        Maze.map(8, 8) = "path"
        Maze.map(8, 9) = "path"
        Maze.map(8, 10) = "path"
        Maze.map(8, 11) = "path"
        Maze.map(8, 13) = "path"
        Maze.map(8, 14) = "path"
        Maze.map(9, 7) = "path"
        Maze.map(9, 14) = "path"
        Maze.map(10, 2) = "path"
        Maze.map(10, 3) = "path"
        Maze.map(10, 4) = "path"
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
        Maze.map(11, 9) = "path"
        Maze.map(11, 14) = "path"
        Maze.map(12, 2) = "path"
        Maze.map(12, 3) = "path"
        Maze.map(12, 4) = "path"
        Maze.map(12, 5) = "path"
        Maze.map(12, 6) = "path"
        Maze.map(12, 7) = "path"
        Maze.map(12, 8) = "path"
        Maze.map(12, 9) = "path"
        Maze.map(12, 10) = "path"
        Maze.map(12, 11) = "path"
        Maze.map(12, 12) = "path"
        Maze.map(12, 14) = "path"
        Maze.map(13, 5) = "path"
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






        Player = New Monkey(My.Resources.Images.Player, 35, 25, 2, 2, True)


        RedMonkey = New Enemy(My.Resources.Images.RedMonkeyLeft, 15, 15, 14, 14, True)


        RedMonkey2 = New Enemy(My.Resources.Images.RedMonkeyDown, 15, 15, 2, 14, True)


        RedMonkey3 = New Enemy(My.Resources.Images.RedMonkeyDown, 15, 15, 2, 6, True)

        RedMonkey4 = New Enemy(My.Resources.Images.RedMonkeyDown, 15, 15, 2, 10, True)

        BananaPoint = New Banana(My.Resources.Images.Banana, 20, 20, 13, 8, True)

        PowerUp = New PowerUp(My.Resources.Images.Health_Pot, 20, 20, 14, 14, True)

        tmrMaze.Enabled = True
        tmrMaze.Interval = 100
        tmrMaze.Start()

        Xmap = Player.MapX
        Ymap = Player.MapY

    End Sub
    Private Sub Form1_Paint(Sender As System.Object, e As System.EventArgs) Handles MyBase.Paint

        Maze.draw(e)
        Player.draw(e)
        RedMonkey.draw(e)
        RedMonkey2.draw(e)
        RedMonkey3.draw(e)
        RedMonkey4.draw(e)
        BananaPoint.draw(e)
        PowerUp.draw(e)
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        Me.DoubleBuffered = True
        Dim MapX As Integer
        Dim MapY As Integer
        Dim Touched As Boolean = False
        Dim PowerUpTouched As Boolean = False
        Dim BananaLocation As Integer
        Dim PowerUpLocation As Integer
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
        If PowerUpTouched = False Then

            If Player.Touching(PowerUp) Then
                If pbrHealth.Value >= 100 Then
                    pbrHealth.Value = 100
                    PowerUpLocation = R.Next(1, 4)
                Else
                    pbrHealth.Value = pbrHealth.Value + 10
                    PowerUpLocation = R.Next(1, 4)
                End If
                PowerUpTouched = True
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
        If Player.Score = 10 Then
            MessageBox.Show("Level 1 Complete")
            Level_2.Show()
            Me.Close()
        End If
        If pbrHealth.Value = 0 Then
            MessageBox.Show("Game Over")
            MessageBox.Show(Player.Score)
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
        Select Case PowerUpLocation
            Case 0

            Case 1
                PowerUp = New PowerUp(My.Resources.Images.Health_Pot, 20, 20, 14, 14, True)
            Case 2
                PowerUp = New PowerUp(My.Resources.Images.Health_Pot, 20, 20, 14, 2, True)
            Case 3
                PowerUp = New PowerUp(My.Resources.Images.Health_Pot, 20, 20, 2, 2, True)
            Case 4
                PowerUp = New PowerUp(My.Resources.Images.Health_Pot, 20, 20, 2, 14, True)
        End Select
    End Sub

    Private Sub tmrMaze_Tick(sender As Object, e As EventArgs) Handles tmrMaze.Tick

        Me.DoubleBuffered = True
        If (RedMonkey.MapX > 2) And RedMonkey.Movment = "Left" Then
            RedMonkey.Image = My.Resources.Images.RedMonkeyLeft
            RedMonkey.MoveLeft()
            If Player.Touching(RedMonkey) Then

                If pbrHealth.Value > 0 Then pbrHealth.Value -= 10


            End If
        Else
            RedMonkey.Movment = "Right"
            Me.Refresh()


        End If
        If (RedMonkey.MapX < 14) And RedMonkey.Movment = "Right" Then
            RedMonkey.Image = My.Resources.Images.RedMonkeyRight
            RedMonkey.MoveRight()
            If Player.Touching(RedMonkey) Then


                If pbrHealth.Value > 0 Then pbrHealth.Value -= 10


            End If
        Else
            RedMonkey.Movment = "Left"
            Me.Refresh()

        End If


        If (RedMonkey2.MapY < 14) And RedMonkey2.Movment = "Down" Then
            RedMonkey2.Image = My.Resources.Images.RedMonkeyDown
            RedMonkey2.MoveDown()
            If Player.Touching(RedMonkey2) Then

                If pbrHealth.Value > 0 Then pbrHealth.Value -= 10



            End If
        Else
            RedMonkey2.Movment = "Up"
            Me.Refresh()


        End If
        If (RedMonkey2.MapY > 2) And RedMonkey2.Movment = "Up" Then
            RedMonkey2.Image = My.Resources.Images.RedMonkeyUp
            RedMonkey2.MoveUp()
            If Player.Touching(RedMonkey2) Then


                If pbrHealth.Value > 0 Then pbrHealth.Value -= 10

            End If
        Else
            RedMonkey2.Movment = "Down"
            Me.Refresh()
        End If

        If (RedMonkey3.MapY < 14) And RedMonkey3.Movment = "Down" Then
            RedMonkey3.Image = My.Resources.Images.RedMonkeyDown
            RedMonkey3.MoveDown()
            If Player.Touching(RedMonkey3) Then

                If pbrHealth.Value > 0 Then pbrHealth.Value -= 10


            End If
        Else
            RedMonkey3.Movment = "Up"
            Me.Refresh()


        End If
        If (RedMonkey3.MapY > 2) And RedMonkey3.Movment = "Up" Then
            RedMonkey3.Image = My.Resources.Images.RedMonkeyUp
            RedMonkey3.MoveUp()
            If Player.Touching(RedMonkey3) Then


                If pbrHealth.Value > 0 Then pbrHealth.Value -= 10

            End If
        Else
            RedMonkey3.Movment = "Down"
            Me.Refresh()
        End If

        If (RedMonkey4.MapY < 14) And RedMonkey4.Movment = "Down" Then
            RedMonkey4.Image = My.Resources.Images.RedMonkeyDown
            RedMonkey4.MoveDown()
            If Player.Touching(RedMonkey4) Then

                If pbrHealth.Value > 0 Then pbrHealth.Value -= 10



            End If
        Else
            RedMonkey4.Movment = "Up"
            Me.Refresh()


        End If
        If (RedMonkey4.MapY > 2) And RedMonkey4.Movment = "Up" Then
            RedMonkey4.Image = My.Resources.Images.RedMonkeyUp
            RedMonkey4.MoveUp()
            If Player.Touching(RedMonkey4) Then


                If pbrHealth.Value > 0 Then pbrHealth.Value -= 10
            End If
        Else
            RedMonkey4.Movment = "Down"
            Me.Refresh()
        End If

    End Sub
    Private Sub tmrPower_Tick(sender As Object, e As EventArgs) Handles tmrPower.Tick


    End Sub

End Class
