Namespace Result

    Friend Structure GetWeatherByZipResponse
        Public Property coord As Coord
        Public Property weather As Weather()
        Public Property base As String
        Public Property main As Main
        Public Property visibility As Integer
        Public Property wind As Wind
        Public Property clouds As Clouds
        Public Property dt As Integer
        Public Property sys As Sys
        Public Property timezone As Integer
        Public Property id As Integer
        Public Property name As String
        Public Property cod As Integer
    End Structure
End Namespace
