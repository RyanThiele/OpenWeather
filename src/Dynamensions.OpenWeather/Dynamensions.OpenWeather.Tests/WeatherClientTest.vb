Imports System.IO
Imports Xunit

Namespace Dynamensions.OpenWeather.Tests
    Public Class WeatherClientTest
        <Fact>
        Async Function GetWeatherByZipCode() As Task
            ' Arrange
            Dim reader = File.OpenText("apiKey")
            Dim apiKey = reader.ReadToEnd()

            Dim client As New WeatherClient("Add Api Key")
            Dim result = Await client.GetWeatherByPostalCodeAsync("Zip Code")
        End Function
    End Class
End Namespace

