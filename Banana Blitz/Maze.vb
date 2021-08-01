Public Class MazeMonkey
    Public Shared width As Integer
    Public Shared height As Integer

    Public X_start As Integer = 20
    Public Y_start As Integer = 20
    Public Colour As Brush
    Public Pen As Pen
    Public Image As Bitmap
    Public map_x As Integer
    Public map_y As Integer

    Public Image2 As Bitmap
    Public Shared numColumn As Integer
    Public Shared numRow As Integer
    Public map(numColumn, numRow) As String
    Public Shared Gap As Integer = 1
    Public isActive As Boolean = True
    Public Sub New()

    End Sub
    Public Sub New(ByVal _Image, ByVal _X_start, ByVal _Y_start, ByVal _width, ByVal _height, ByVal _numRow, ByVal _numColumn, ByVal _isActive)
        Image = _Image
        X_start = _X_start
        Y_start = _Y_start
        numColumn = _numColumn
        numRow = _numRow
        width = _width
        height = _height
        isActive = _isActive
        Map_()
    End Sub



    Public Sub Map_()
        For r = 1 To numRow
            For c = 1 To numColumn
                map = New String(c, r) {}
                map(c, r) = "Wall"
            Next
        Next

    End Sub


    Public Sub draw(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim xpos As Integer = X_start
        Dim ypos As Integer = Y_start
        Dim MapData As String
        Pen = New Pen(Color.Honeydew, 2)
        For Row = 1 To numRow
            For Col = 1 To numColumn
                MapData = map(Col, Row)
                Select Case MapData
                    Case "Wall"
                        If Image2 IsNot Nothing Then
                            e.Graphics.DrawRectangle(Pen, xpos, ypos, width, height)
                            e.Graphics.DrawImage(Image2, xpos, ypos, width, height)

                        Else
                            e.Graphics.DrawRectangle(Pen, xpos, ypos, width, height)
                            e.Graphics.FillRectangle(Colour, xpos, ypos, width, height)

                        End If
                    Case "path"
                        If Image IsNot Nothing Then

                            e.Graphics.DrawRectangle(Pen, xpos, ypos, width, height)
                            e.Graphics.DrawImage(Image, xpos, ypos, width, height)
                        Else
                            e.Graphics.DrawRectangle(Pen, xpos, ypos, width, height)
                            e.Graphics.FillRectangle(Colour, xpos, ypos, width, height)
                        End If
                    Case Else
                        If Image2 IsNot Nothing Then

                            e.Graphics.DrawRectangle(Pen, xpos, ypos, width, height)
                            e.Graphics.DrawImage(Image2, xpos, ypos, width, height)
                        Else

                            e.Graphics.DrawRectangle(Pen, xpos, ypos, width, height)
                            e.Graphics.FillRectangle(Colour, xpos, ypos, width, height)
                        End If


                End Select
                xpos = xpos + width + Gap
            Next
            xpos = X_start
            ypos = ypos + height + Gap
        Next
    End Sub

End Class
