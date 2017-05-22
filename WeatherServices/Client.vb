Public Class Client
    Dim obsTemplate As String = "http://wxdata.weather.com/wxdata/obs/{0}.xml?key=e88d3874-a740-102c-bafd-001321203584&locale={1}&units={2}"
    Dim fcastTemplate As String = "http://wxdata.weather.com/wxdata/df/{0}.xml?key=e88d3874-a740-102c-bafd-001321203584&day={1}&locale={2}&units={3}"
    Dim searchTemplate As String = "http://wxdata.weather.com/wxdata/locsearch/{0}.xml?key=e88d3874-a740-102c-bafd-001321203584&locale={1}"

    Public Property Locale As String
    Public Property Units As String = "e"
    Public Property DayCount As Integer = 5

    Public Property CurrentLocation As WxLocation
    Public Property CurrentConditions As Conditions
    Public Property Forecast As ForecastDay()

    Public Sub New(ByVal loc As WxLocation)
        CurrentLocation = loc
        Update()
    End Sub

    Private Function LoadPage(ByVal pageUri As String) As String
        Using cl As New HttpClient
            Dim resp = cl.GetAsync(pageUri)

            If resp.Result.StatusCode = HttpStatusCode.OK Then
                Return resp.Result.Content.ReadAsStringAsync.Result
            Else
                Return String.Empty
            End If
        End Using
    End Function

    Private Sub LoadConditions()
        Dim page As String = LoadPage(String.Format(obsTemplate, CurrentLocation.ParentLoc, Locale, Units))

        CurrentConditions = JsonConvert.DeserializeObject(Of Conditions)(page)
    End Sub

    Private Sub LoadForecast()
        Dim dayList As String = String.Empty

        For i As Integer = 0 To DayCount
            dayList = "," & i
        Next

        Dim page As String = LoadPage(String.Format(fcastTemplate, CurrentLocation.ParentLoc, dayList, Locale, Units))

        Forecast = JsonConvert.DeserializeObject(Of ForecastDay())(page)
    End Sub

    Public Sub Update()
        LoadConditions()
        LoadForecast()
    End Sub

    Public Function Search(ByVal arg As String) As SearchData
        Dim page As String = LoadPage(String.Format(searchTemplate, arg, Locale))

        Return JsonConvert.DeserializeObject(Of SearchData)(page)
    End Function

End Class
