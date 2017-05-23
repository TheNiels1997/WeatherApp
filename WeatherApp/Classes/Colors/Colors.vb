Public Class Colors
    Public Shared Property LightBlack As Color = Color.FromArgb(22, 21, 28)
    Public Shared Property Black As Color = Color.FromArgb(0, 0, 0)
    Public Shared Property Alcon As Color = Color.FromArgb(0, 121, 193)

    Public Shared Function MakeBrighter(ByVal color As Color) As Color
        Dim r As Integer = color.R + 15
        Dim g As Integer = color.G + 15
        Dim b As Integer = color.B + 15

        If r > 255 Then
            r = color.R
        End If

        If g > 255 Then
            g = color.G
        End If

        If b > 255 Then
            b = color.B
        End If

        Return Color.FromArgb(r, g, b)
    End Function

    Public Shared Function MakeDarker(ByVal color As Color) As Color
        Dim r As Integer = color.R - 25
        Dim g As Integer = color.G - 25
        Dim b As Integer = color.B - 25

        If r < 0 Then
            r = color.R
        End If

        If g < 0 Then
            g = color.G
        End If

        If b < 0 Then
            b = color.B
        End If

        Return Color.FromArgb(r, g, b)
    End Function

    Public Shared Function ToBrush(ByVal color As Color) As Brush
        Return New SolidBrush(color)
    End Function
End Class

'clr 1 = r81  g40 b106 a69
'clr 2 = r22 g21 b28 a23
'clr 3 = r8 g8 b11 a11