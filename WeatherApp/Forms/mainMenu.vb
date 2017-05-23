Public Class mainMenu
    Dim loc As WxLocation
    Dim cl As Client

    Private Sub mainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = Colors.MakeBrighter(Colors.LightBlack)
        Panel1.BackColor = Colors.Alcon

        loc = New WxLocation With {.City = "Dinteloord", .Country = "Netherlands", .CountyId = "North Brabant", .ParentLoc = "NLXX0040"}
        cl = New Client(loc)
        UpdateInfo()
    End Sub

    Private Sub UpdateInfo()
        cl.Update()
        lbCityName.Text = String.Format("{0}, {1}", cl.CurrentLocation.City, cl.CurrentLocation.CountyId)
        lbTemp.Text = cl.CurrentConditions.Temp & "°C"
        PictureBox1.Image = GetProperImage(cl.CurrentConditions.WxIcon)
        lbConditions.Text = cl.CurrentConditions.Text
        lbWind.Text = String.Format("{0}, {1} KM/H", GetProperWindText(cl.CurrentConditions.WDirText), cl.CurrentConditions.WSpeed)
    End Sub

    Private Function GetProperImage(ByVal iconCode As Integer) As Image
        Select Case iconCode
            Case 1, 3, 4, 37, 38, 39, 40, 45, 47
                Return My.Resources.stormblack
            Case 2, 24
                Return My.Resources.windsymbol
            Case 5, 7, 16, 17, 46, 13, 14, 15, 42
                Return My.Resources.snowblack
            Case 6, 18, 35, 8, 10
                Return My.Resources.rainblack
            Case 9
                Return My.Resources.rain
            Case 11, 12, 40
                Return My.Resources.rainwindcloud
            Case 19, 20, 21, 22, 23
                Return My.Resources.fog
            Case 25, 41, 43
                Return My.Resources.snowsymbol
            Case 26
                Return My.Resources.cloud
            Case 28, 30
                Return My.Resources.clouds
            Case 27, 29
                Return My.Resources.variableblack
            Case 31, 33
                Return My.Resources.moon
            Case 32, 34, 36
                Return My.Resources.sun
            Case 44
                Return My.Resources.suncloud
            Case 3200
                Return My.Resources.na
            Case Else
                Return Nothing
        End Select
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UpdateInfo()
    End Sub

    Private Function GetProperWindText(ByVal wdirText As String) As String
        Select Case wdirText
            Case "N"
                Return "North"
            Case "NNW"
                Return "North North West"
            Case "NW"
                Return "North West"
            Case "WNW"
                Return "West North West"
            Case "W"
                Return "West"
            Case "WSW"
                Return "West South West"
            Case "SW"
                Return "South West"
            Case "SSW"
                Return "South South West"
            Case "S"
                Return "South"
            Case "SSE"
                Return "South South East"
            Case "SE"
                Return "South East"
            Case "ESE"
                Return "East South East"
            Case "E"
                Return "East"
            Case "ENE"
                Return "East North East"
            Case "NE"
                Return "North East"
            Case "NNE"
                Return "North North East"
            Case Else
                Return "No wind"
        End Select
    End Function
End Class
