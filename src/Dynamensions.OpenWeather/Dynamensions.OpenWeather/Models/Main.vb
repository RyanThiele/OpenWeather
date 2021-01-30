Namespace Models
    Public Class Main
        ''' <summary>
        ''' The unit the temperature is in. Use extension methods to convert the temperature if needed.
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property TemperatureUnits As TemperatureUnits

        ''' <summary>
        ''' Temperature.
        ''' </summary>
        Public ReadOnly Property Temperature As Double

        ''' <summary>
        ''' This temperature parameter accounts for the human perception of weather.
        ''' </summary>
        Public ReadOnly Property FeelsLike As Double

        ''' <summary>
        ''' Minimum temperature at the moment. This is minimal currently observed temperature (within large megalopolises and urban areas).
        ''' </summary>
        Public ReadOnly Property TemperatureMin As Double

        ''' <summary>
        ''' Maximum temperature at the moment. This is maximal currently observed temperature (within large megalopolises and urban areas). 
        ''' </summary>
        Public ReadOnly Property TemperatureMax As Double

        ''' <summary>
        ''' Atmospheric pressure (on the sea level, if there is no sea_level or grnd_level data), hPa
        ''' </summary>
        Public ReadOnly Property Pressure As Integer

        ''' <summary>
        ''' Relative Humidity, %
        ''' </summary>
        Public ReadOnly Property Humidity As Integer

        Friend Sub New(units As TemperatureUnits, temperature As Double, feelsLike As Double, temperatureMin As Double, temperatureMax As Double, pressure As Integer, humidity As Integer)
            Me.TemperatureUnits = units
            Me.Temperature = temperature
            Me.FeelsLike = feelsLike
            Me.TemperatureMax = temperatureMax
            Me.TemperatureMin = temperatureMin
            Me.Pressure = pressure
            Me.Humidity = humidity
        End Sub


        Friend Sub New(units As TemperatureUnits, main As Result.Main)
            Me.TemperatureUnits = units

            Select Case units
                Case TemperatureUnits.Celsius
                    Me.Temperature = main.temp.ToCelsius(TemperatureUnits.Kelvin)
                    Me.FeelsLike = main.feels_like.ToCelsius(TemperatureUnits.Kelvin)
                    Me.TemperatureMax = main.temp_max.ToCelsius(TemperatureUnits.Kelvin)
                    Me.TemperatureMin = main.temp_min.ToCelsius(TemperatureUnits.Kelvin)
                Case TemperatureUnits.Fahrenheit
                    Me.Temperature = main.temp.ToFahrenheit(TemperatureUnits.Kelvin)
                    Me.FeelsLike = main.feels_like.ToFahrenheit(TemperatureUnits.Kelvin)
                    Me.TemperatureMax = main.temp_max.ToFahrenheit(TemperatureUnits.Kelvin)
                    Me.TemperatureMin = main.temp_min.ToFahrenheit(TemperatureUnits.Kelvin)
                Case TemperatureUnits.Kelvin
                    Me.Temperature = main.temp.ToKelvin(TemperatureUnits.Kelvin)
                    Me.FeelsLike = main.feels_like.ToKelvin(TemperatureUnits.Kelvin)
                    Me.TemperatureMax = main.temp_max.ToKelvin(TemperatureUnits.Kelvin)
                    Me.TemperatureMin = main.temp_min.ToKelvin(TemperatureUnits.Kelvin)
            End Select
            Me.Pressure = main.pressure
            Me.Humidity = main.humidity
        End Sub

    End Class
End Namespace