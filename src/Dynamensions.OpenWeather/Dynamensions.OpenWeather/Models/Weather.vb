Namespace Models
    Public Class Weather


        ''' <summary>
        ''' Weather condition id
        ''' </summary>
        Public ReadOnly Property Id As Integer

        ''' <summary>
        ''' Group of weather parameters (Rain, Snow, Extreme etc.)
        ''' </summary>
        Public ReadOnly Property Main As String

        ''' <summary>
        ''' Weather condition within the group. You can get the output in your language.
        ''' </summary>
        Public ReadOnly Property Description As String

        ''' <summary>
        ''' Weather icon id
        ''' </summary>
        Public ReadOnly Property Icon As String

        Friend Sub New(id As Integer, main As String, description As String, icon As String)
            Me.Id = id
            Me.Main = main
            Me.Description = description
            Me.Icon = icon
        End Sub

        Friend Sub New(result As Result.Weather)
            Me.Id = result.id
            Me.Main = result.main
            Me.Description = result.description
            Me.Icon = result.icon
        End Sub
    End Class
End Namespace
