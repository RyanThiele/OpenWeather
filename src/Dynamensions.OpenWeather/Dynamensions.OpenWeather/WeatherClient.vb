
Imports System.Net.Http
Imports System.Net.Http.Json
Imports System.Threading

Public NotInheritable Class WeatherClient
    Implements IDisposable

    Private _apiKey As String

    Public Sub New(apiKey As String)
        _apiKey = apiKey
    End Sub

    Public Async Function GetWeatherByPostalCodeAsync(postalCode As String, Optional cancellationToken As CancellationToken = Nothing) As Task(Of Models.GetWeatherByZipCodeResult)
        Dim url As String = $"https://api.openweathermap.org/data/2.5/weather?zip={postalCode}&appid={_apiKey}"
        Dim response As New Result.GetWeatherByZipResponse

        Using client As New HttpClient(New HttpClientHandler With {.AllowAutoRedirect = True})
            response = Await client.GetFromJsonAsync(Of Result.GetWeatherByZipResponse)(url, cancellationToken).ConfigureAwait(False)


        End Using


        Return New Models.GetWeatherByZipCodeResult(
        New Models.Coordinates(response.coord),
        response.weather.Select(Function(w) New Models.Weather(w)).ToArray(),
        New Models.Main(TemperatureUnits.Fahrenheit, response.main),
        New Models.Wind(SpeedUnits.MilesPerHour, response.wind),
        New Models.Clouds(response.clouds),
        response.dt,
        New Models.System(response.sys),
        response.timezone,
        response.id,
        response.cod
        )

    End Function



#Region "IDisposable"

    Private disposedValue As Boolean

    Private Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects)
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override finalizer
            ' TODO: set large fields to null
            disposedValue = True
        End If
    End Sub

    ' ' TODO: override finalizer only if 'Dispose(disposing As Boolean)' has code to free unmanaged resources
    ' Protected Overrides Sub Finalize()
    '     ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
    '     Dispose(disposing:=False)
    '     MyBase.Finalize()
    ' End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
        Dispose(disposing:=True)
        GC.SuppressFinalize(Me)
    End Sub

#End Region

End Class
