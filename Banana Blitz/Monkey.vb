Imports Banana_Blitz

Public Class Monkey
    Inherits MazeMonkey
    Public X As Integer
    Public Y As Integer
    Public Player_Width As Integer
    Public Player_Height As Integer
    Public MapX As Integer
    Public MapY As Integer
    Public MonkeyImage As Bitmap
    Public Score As Integer

    Public Sub New()

    End Sub
    Public Sub New(ByVal _Image, ByVal height, ByVal width, ByVal Map_Y, ByVal Map_X, ByVal _isActive)
        Image = _Image
        Player_Width = width
        Player_Height = height
        MapY = Map_Y
        MapX = Map_X
        isActive = _isActive
        StartPosition(MapX, MapY)


    End Sub



    Public Overloads Sub Setimage(ByVal newImage As Bitmap)
        Image = newImage
    End Sub
    Public Overloads Sub draw(ByVal e As System.Windows.Forms.PaintEventArgs)
        If Image IsNot Nothing Then

            e.Graphics.DrawImage(Image, X, Y, Player_Width, Player_Height)
        Else
            e.Graphics.FillRectangle(Colour, X, Y, Player_Width, Player_Height)
        End If
    End Sub
    Public Sub StartPosition(ByVal Map_X, ByVal Map_Y)
        X = GetXpos()
        Y = GetYpos()

    End Sub
    Public Function GetXpos() As Integer
        If (MapX <= numColumn) Then
            X = ((MapX - 1) * width) + (Gap * (MapX - 1)) + X_start
            X = X + (width / 2) - Player_Width / 2
        Else
            MapX = numColumn - 1
        End If
        Return X
    End Function
    Public Function GetYpos() As Integer
        Y = ((MapY - 1) * height) + (Gap * (MapX - 1)) + Y_start
        Y = Y + (height / 2) - Player_Height / 2
        Return Y
    End Function
    Public Sub MoveDown()
        MapY = MapY + 1
        Y = GetYpos()
    End Sub
    Public Sub MoveRight()
        MapX = MapX + 1
        X = GetXpos()
    End Sub
    Public Sub MoveLeft()
        MapX = MapX - 1
        X = GetXpos()
    End Sub
    Public Sub MoveUp()
        MapY = MapY - 1
        Y = GetYpos()
    End Sub
    Public Sub StartPosistion(ByVal Map_X, ByVal Map_Y)
        X = GetXpos()
        Y = GetYpos()
    End Sub
    Public Function Touching(ByVal o As Object) As Boolean
        Dim isTouching As Boolean
        If isActive = True Then
            If (X + width >= o.x And X <= o.x + o.Width) And (Y <= o.y + o.Height And Y + height >= o.y) Then
                isTouching = True
            Else
                isTouching = False

            End If
        End If
        Return isTouching
    End Function
    Public Sub PlayerScore(ByVal Score)

    End Sub

    Friend Function Touching() As Banana
        Throw New NotImplementedException()
    End Function
End Class
