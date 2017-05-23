Public Class CityList
    Inherits ListBox

    Public Sub New()
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or
                    ControlStyles.OptimizedDoubleBuffer Or
                    ControlStyles.ResizeRedraw Or
                    ControlStyles.UserPaint, True)

        Me.DrawMode = DrawMode.OwnerDrawFixed
        Me.ItemHeight = 30
        Me.IntegralHeight = False
    End Sub

    Protected Overrides Sub OnSelectedIndexChanged(e As EventArgs)
        MyBase.OnSelectedIndexChanged(e) : Me.Invalidate()
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim g As Graphics = e.Graphics

        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic

        For i As Integer = Me.Items.Count - 1 To 0 Step -1
            If Me.SelectedIndex <> i Then
                Dim rect As Rectangle = Me.GetItemRectangle(i)

                Using br As New SolidBrush(Colors.MakeBrighter(Colors.LightBlack))
                    g.FillRectangle(br, rect)

                    rect.Width -= 1
                    rect.Height -= 1

                    Using p As New Pen(br)
                        g.DrawRectangle(p, rect)
                    End Using
                End Using

                Using fnt As New Font("Segoe UI", 8)
                    g.DrawString(Me.Items(i), fnt, Brushes.White, rect, New StringFormat With {.Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Center})
                End Using
            End If
        Next

        If Me.SelectedIndex <> -1 Then
            Dim rect As Rectangle = Me.GetItemRectangle(Me.SelectedIndex)

            Using br As New SolidBrush(Colors.MakeBrighter(Colors.LightBlack))
                g.FillRectangle(br, rect)

                rect.Width -= 1
                rect.Height -= 1

                Using p As New Pen(br)
                    g.DrawRectangle(p, rect)
                End Using
            End Using

            Using fnt As New Font("Segoe UI", 8)
                g.DrawString(Me.Items(Me.SelectedIndex), fnt, Brushes.White, rect, New StringFormat With {.Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Center})
            End Using
        End If
    End Sub
End Class
