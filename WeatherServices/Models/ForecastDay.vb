Public Class ForecastDay
    <JsonProperty("key")>
    Public Property Key As String

    <JsonProperty("class")>
    Public Property [Class] As String

    <JsonProperty("validDate")>
    Public Property ValidDate As Long

    <JsonProperty("maxTemp")>
    Public Property MaxTemp As Integer

    <JsonProperty("minTemp")>
    Public Property MinTemp As Integer

    <JsonProperty("precip_type")>
    Public Property PrecipType As String

    <JsonProperty("day")>
    Public Property Day As DayPart

    <JsonProperty("night")>
    Public Property Night As DayPart
End Class
