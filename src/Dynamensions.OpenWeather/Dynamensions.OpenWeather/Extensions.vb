Imports System.Runtime.CompilerServices

Public Enum TemperatureUnits
    Kelvin
    Fahrenheit
    Celsius
End Enum

Public Enum SpeedUnits
    MetersPerSecond
    MilesPerHour
End Enum

Public Enum DistanceUnits
    Inches
    Millimeters
End Enum

<HideModuleName>
Public Module Extensions

    <Extension()>
    Public Function ToFahrenheit(temperature As Double, unit As TemperatureUnits, Optional decimals As Integer = 2) As Double
        Dim result As Decimal = 0

        Select Case unit
            Case TemperatureUnits.Kelvin
                result = Convert.ToDecimal(((temperature - 273.15) * 1.8) + 32)
            Case TemperatureUnits.Celsius
                result = Convert.ToDecimal((temperature * 1.8) + 32)
            Case Else
                result = temperature
        End Select

        Return Decimal.Round(result, decimals)
    End Function


    <Extension()>
    Public Function ToCelsius(temperature As Double, unit As TemperatureUnits, Optional decimals As Integer = 2) As Double
        Dim result As Decimal = 0

        Select Case unit
            Case TemperatureUnits.Kelvin
                result = Convert.ToDecimal(temperature - 273.15)
            Case TemperatureUnits.Fahrenheit
                result = Convert.ToDecimal((temperature * 1.8) + 32)
            Case Else
                result = temperature
        End Select

        Return Decimal.Round(result, decimals)
    End Function


    <Extension()>
    Public Function ToKelvin(temperature As Double, unit As TemperatureUnits, Optional decimals As Integer = 2) As Double
        Dim result As Decimal = 0

        Select Case unit
            Case TemperatureUnits.Celsius
                result = Convert.ToDecimal(temperature + 273.15)
            Case TemperatureUnits.Fahrenheit
                result = Convert.ToDecimal((temperature - 32) / 1.8 + 273.15)
            Case Else
                result = temperature
        End Select

        Return Decimal.Round(result, decimals)
    End Function

    <Extension()>
    Public Function ToMilesPerHour(speed As Double, unit As SpeedUnits, Optional decimals As Integer = 2) As Double
        Dim result As Decimal = 0

        Select Case unit
            Case SpeedUnits.MetersPerSecond
                speed *= 3600
                result = Convert.ToDecimal(speed * 0.000621)
            Case Else
                result = speed
        End Select

        Return Decimal.Round(result, decimals)
    End Function

    <Extension()>
    Public Function ToMetersPerSecond(speed As Double, unit As SpeedUnits, Optional decimals As Integer = 2) As Double
        Dim result As Decimal = 0

        Select Case unit
            Case SpeedUnits.MilesPerHour
                speed /= 3600
                result = Convert.ToDecimal(speed * 1609.344)
            Case Else
                result = speed
        End Select

        Return Decimal.Round(result, decimals)
    End Function


    <Extension()>
    Public Function ToInches(volume As Double, unit As DistanceUnits, Optional decimals As Integer = 2) As Double
        Dim result As Decimal = 0

        Select Case unit
            Case DistanceUnits.Inches
                result = volume * 0.03937
            Case Else
                result = result
        End Select

        Return Decimal.Round(result, decimals)
    End Function


    <Extension()>
    Public Function ToMillimeters(volume As Double, unit As DistanceUnits, Optional decimals As Integer = 2) As Double
        Dim result As Decimal = 0

        Select Case unit
            Case DistanceUnits.Millimeters
                result = volume * 25.4
            Case Else
                result = result
        End Select

        Return Decimal.Round(result, decimals)
    End Function


    <Extension()>
    Public Function ToDateTime(unixTime As Integer) As DateTimeOffset
        Return DateTimeOffset.FromUnixTimeSeconds(unixTime)
    End Function

End Module
