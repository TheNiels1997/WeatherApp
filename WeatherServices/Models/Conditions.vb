Public Class Conditions
    <JsonProperty("key")>
    Public Property Key As String

    <JsonProperty("class")>
    Public Property [Class] As String

    <JsonProperty("visibility")>
    Public Property Visibility As String

    <JsonProperty("date")>
    Public Property [Date] As Long

    <JsonProperty("wxIcon")>
    Public Property WxIcon As String

    <JsonProperty("temp")>
    Public Property Temp As Integer

    <JsonProperty("dewPoint")>
    Public Property DewPoint As Integer

    <JsonProperty("pressure")>
    Public Property Pressure As Double

    <JsonProperty("pressureDescription")>
    Public Property PressureDescription As String

    <JsonProperty("feelsLike")>
    Public Property FeelsLike As Integer

    <JsonProperty("humid")>
    Public Property Humid As Integer

    <JsonProperty("wSpeed")>
    Public Property WSpeed As Integer

    <JsonProperty("wDir")>
    Public Property WDir As Integer

    <JsonProperty("uv")>
    Public Property Uv As Integer

    <JsonProperty("uvText")>
    Public Property UvText As String

    <JsonProperty("obsName")>
    Public Property ObsName As String

    <JsonProperty("wDirText")>
    Public Property WDirText As String

    <JsonProperty("text")>
    Public Property Text As String

    <JsonProperty("heatIndex")>
    Public Property HeatIndex As Integer

    <JsonProperty("windchill")>
    Public Property Windchill As Integer

    <JsonProperty("qualifier")>
    Public Property Qualifier As String

    <JsonProperty("blunt_phrase")>
    Public Property BluntPhrase As String

    <JsonProperty("terse_phrase")>
    Public Property TersePhrase As String
End Class
