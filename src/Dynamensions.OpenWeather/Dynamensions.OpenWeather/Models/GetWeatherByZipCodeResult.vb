Namespace Models
    Public Class GetWeatherByZipCodeResult
        Public ReadOnly Property Coordinates As Coordinates
        Public Property Weather As IEnumerable(Of Weather)
        Public Property Base As String
        Public Property Main As Main
        Public Property Visibility As Integer
        Public Property Wind As Wind
        Public Property Clouds As Clouds
        Public Property DateTime As DateTimeOffset
        Public Property System As System
        Public Property Id As Integer
        Public Property Name As String
        Public Property Cod As Integer


        Friend Sub New(coordinates As Coordinates, weather As IEnumerable(Of Weather), main As Main, wind As Wind, clouds As Clouds, unixDateTime As Integer, system As System, timezone As Integer, id As Integer, cod As Integer)
            Me.Coordinates = coordinates
            Me.Weather = weather
            Me.Main = main
            Me.Wind = wind
            Me.Clouds = clouds
            Me.DateTime = DateTimeOffset.FromUnixTimeSeconds(unixDateTime)
            Me.DateTime = Me.DateTime.AddSeconds(timezone)
            Me.Id = id
            Me.Cod = cod

            Me.System = New System(system, TimeSpan.FromSeconds(timezone))
        End Sub

    End Class
End Namespace
