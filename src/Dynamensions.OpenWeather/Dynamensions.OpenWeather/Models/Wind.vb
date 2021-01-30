Namespace Models
    Public Class Wind

        ''' <summary>
        ''' The current units used for distance
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property Units As SpeedUnits

        ''' <summary>
        ''' Wind speed in units per hour
        ''' </summary>
        Public ReadOnly Property Speed As Double

        ''' <summary>
        ''' Wind direction, degrees (meteorological)
        ''' </summary>
        Public ReadOnly Property Degrees As Integer

        ''' <summary>
        ''' Wind gusts units per hour
        ''' </summary>
        Public ReadOnly Property Gusts As Double

        ''' <summary>
        ''' Compass oriented direction string (e.g. NNW)
        ''' </summary>
        Public ReadOnly Property Direction As String


        Private Function ConvertDegreesToCompassDirection(degrees As Double) As String
            Dim Sector As String() = {"N", "NNE", "NE", "ENE", "E", "ESE", "SE", "SSE", "S", "SSW", "SW", "WSW", "W", "WNW", "NW", "NNW", "N"}
            Dim index = Convert.ToDecimal(degrees Mod 360)
            index = Decimal.Round(index / 22.5D, 0) + 1

            Return Sector(index)
        End Function



        Public Sub New(units As SpeedUnits, speed As Double, degrees As Double, gusts As Double)
            Me.Units = units
            Me.Speed = speed
            Me.Degrees = degrees
            Me.Gusts = gusts

            Me.Direction = ConvertDegreesToCompassDirection(degrees)


            'If degrees >= 0 And degrees <= 11 Then
            '    Direction = "N"
            'ElseIf degrees >= 12 And degrees <= 33 Then
            '    Direction = "NNE"
            'ElseIf degrees >= 34 And degrees <= 57 Then
            '    Direction = "NE"
            'ElseIf degrees >= 58 And degrees <= 78 Then
            '    Direction = "ENE"
            'ElseIf degrees >= 79 And degrees <= 57 Then
            '    Direction = "NE"

            'End If
        End Sub


        Friend Sub New(units As SpeedUnits, wind As Result.Wind)
            Me.Units = units

            Select Case units
                Case SpeedUnits.MetersPerSecond
                    Me.Speed = wind.speed.ToMetersPerSecond(SpeedUnits.MetersPerSecond)
                Case SpeedUnits.MilesPerHour
                    Me.Speed = wind.speed.ToMilesPerHour(SpeedUnits.MetersPerSecond)
            End Select

            Me.Degrees = wind.deg
            Me.Direction = ConvertDegreesToCompassDirection(wind.deg)
        End Sub
    End Class
End Namespace

