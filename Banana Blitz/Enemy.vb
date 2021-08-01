Public Class Enemy
    Inherits MazeMonkey
    Public MapX As Integer
    Public MapY As Integer
    Public X As Integer
    Public Y As Integer
    Public EnemyColour As Brush
    Public Movment As String
    Public Enemy_Height As Integer
    Public Enemy_Width As Integer
    Public Sub New()

    End Sub
    Public Sub setImage(ByVal newImage As Bitmap)
        Image = newImage

    End Sub

    Public Sub New(ByVal _Image, ByVal height, ByVal width, ByVal map_y, ByVal map_x, ByVal _IsActive)
        Image = _Image
        Enemy_Height = height
        Enemy_Width = width
        MapY = map_y
        MapX = map_x
        isActive = _IsActive
        StartPosition(MapX, MapY)


    End Sub
    Public Function GetXpos() As Integer
        If (MapX <= numColumn) Then
            X = ((MapX - 1) * width) + (Gap * (MapX - 1)) + X_start
            X = X + (width / 2) - Enemy_Width
        End If
        Return X
    End Function
    Public Function GetYpos() As Integer
        Y = ((MapY - 1) * height) + (Gap * (MapX - 1)) + Y_start
        Y = Y + (height / 2) - Enemy_Height / 2
        Return Y
    End Function
    Public Sub StartPosition(ByVal map_x, ByVal map_y)
        X = GetXpos()
        Y = GetYpos()

    End Sub
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
    Public Overloads Sub draw(ByVal e As System.Windows.Forms.PaintEventArgs)
        If isActive = True Then
            If Image IsNot Nothing Then
                Image.MakeTransparent()
                e.Graphics.DrawImage(Image, X, Y, Enemy_Height, Enemy_Width)
            Else
                e.Graphics.FillRectangle(EnemyColour, X, Y, Enemy_Height, Enemy_Width)
            End If
        End If
    End Sub
End Class

