Public Class Button
    Inherits Control

    Dim _isPressed As Boolean = False
    Dim _img As Image
    Public Property Image As Image
        Get
            Return _img
        End Get
        Set(value As Image)
            _img = value
            Me.Invalidate()
        End Set
    End Property

    Public Sub New()
        Me.SetStyle(ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.Size = New Size(32, 32)
    End Sub

    Private Sub DrawBackground(ByVal g As Graphics, ByVal rect As Rectangle, ByVal isPressed As Boolean)
        If isPressed Then
            Using br As New SolidBrush(Colors.Black)
                g.FillRectangle(br, rect)
                Using p As New Pen(br)
                    g.DrawRectangle(p, rect)
                End Using
            End Using
        Else
            Using br As New SolidBrush(Colors.MakeBrighter(Colors.LightBlack))
                g.FillRectangle(br, rect)
                Using p As New Pen(br)
                    g.DrawRectangle(p, rect)
                End Using
            End Using
        End If
    End Sub

    Private Sub DrawImage(ByVal g As Graphics, ByVal rect As Rectangle)
        If _img IsNot Nothing Then
            Dim rectImage As New Rectangle(rect.X + (rect.Width / 2) - (_img.Width / 2), rect.Y + (rect.Height / 2) - (_img.Height / 2), _img.Width, _img.Height)
            g.DrawImage(_img, rectImage)
        End If
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        _isPressed = True
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        _isPressed = False
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim g As Graphics = e.Graphics

        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic

        Dim rect As Rectangle = Me.ClientRectangle

        DrawBackground(g, rect, _isPressed)
        DrawImage(g, rect)
    End Sub
End Class
