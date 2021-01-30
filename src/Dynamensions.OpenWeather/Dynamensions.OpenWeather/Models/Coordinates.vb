Namespace Models

    ''' <summary>
    ''' City geo location
    ''' </summary>
    Public Class Coordinates
        ''' <summary>
        ''' City geo location, latitude
        ''' </summary>
        Public ReadOnly Property Latitude As Double

        ''' <summary>
        ''' City geo location, longitude
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property Longitude As Double

        Friend Sub New(latitude As Double, longitude As Double)
            Me.Latitude = latitude
            Me.Longitude = longitude
        End Sub

        Friend Sub New(coord As Result.Coord)
            Me.Latitude = coord.lat
            Me.Longitude = coord.lon
        End Sub
    End Class
End Namespace

