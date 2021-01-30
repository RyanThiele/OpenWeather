Public Class Snow
    ''' <summary>
    ''' The units used
    ''' </summary>
    Public ReadOnly Property Units As DistanceUnits

    ''' <summary>
    ''' Rain in the last hour
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property RainInLastHour As Double

    ''' <summary>
    ''' Rain in the last three hours
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property RainInLastThreeHours As Double

    Friend Sub New(units As DistanceUnits, rainInLastHour As Double, rainInLastThreeHours As Double)
        Me.Units = units
        Me.RainInLastHour = rainInLastHour
        Me.RainInLastThreeHours = rainInLastThreeHours
    End Sub

    Friend Sub New(units As DistanceUnits, result As Result.Rain)
        Me.Units = units

        Select Case units
            Case DistanceUnits.Inches
                Me.RainInLastHour = result.OneHour.ToInches(DistanceUnits.Millimeters)
                Me.RainInLastThreeHours = result.ThreeHour.ToInches(DistanceUnits.Millimeters)
            Case DistanceUnits.Millimeters
                Me.RainInLastHour = result.OneHour.ToMillimeters(DistanceUnits.Millimeters)
                Me.RainInLastThreeHours = result.ThreeHour.ToMillimeters(DistanceUnits.Millimeters)
        End Select


    End Sub

End Class
