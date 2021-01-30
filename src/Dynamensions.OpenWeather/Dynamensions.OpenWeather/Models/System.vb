Namespace Models
    Public Class System
        Public ReadOnly Property Type As Integer
        Public ReadOnly Property Id As Integer
        Public ReadOnly Property Country As String
        Public ReadOnly Property Sunrise As DateTimeOffset
        Public ReadOnly Property Sunset As DateTimeOffset



        Friend Sub New(type As Integer, id As Integer, country As String, sunrise As Integer, sunset As Integer)
            Me.Type = type
            Me.Id = id
            Me.Country = country
            Me.Sunrise = DateTimeOffset.FromUnixTimeSeconds(sunrise)
            Me.Sunset = DateTimeOffset.FromUnixTimeSeconds(sunset)
        End Sub

        Friend Sub New(result As Result.Sys)
            Me.Type = result.type
            Me.Id = result.id
            Me.Country = result.country


            Me.Sunrise = DateTimeOffset.FromUnixTimeSeconds(result.sunrise)
            Me.Sunset = DateTimeOffset.FromUnixTimeSeconds(result.sunset)

        End Sub


        Friend Sub New(system As System, shift As TimeSpan)
            Me.Type = system.Type
            Me.Id = system.Id
            Me.Country = system.Country


            Me.Sunrise = system.Sunrise.Add(shift)
            Me.Sunset = system.Sunset.Add(shift)


        End Sub
    End Class
End Namespace
