Public Class DayPart
    <JsonProperty("humid")>
    Public Property Humid As Integer

    <JsonProperty("wSpeed")>
    Public Property WSpeed As Integer

    <JsonProperty("wDir")>
    Public Property WDir As Integer

    <JsonProperty("pop")>
    Public Property Pop As Integer

    <JsonProperty("uv")>
    Public Property Uv As Integer

    <JsonProperty("icon")>
    Public Property Icon As Integer

    <JsonProperty("wDirText")>
    Public Property WDirText As String

    <JsonProperty("phrase")>
    Public Property Phrase As String

    <JsonProperty("bluntPhrase")>
    Public Property BluntPhrase As String

    <JsonProperty("precip_type")>
    Public Property PrecipType As String

    <JsonProperty("snwAccumPhrase")>
    Public Property SnwAccumPhrase As String

    <JsonProperty("snwAccumPhraseTerse")>
    Public Property SnwAccumPhraseTerse As String

    <JsonProperty("extQual")>
    Public Property ExtQual As String

    <JsonProperty("weatherCode")>
    Public Property WeatherCode As String
End Class
