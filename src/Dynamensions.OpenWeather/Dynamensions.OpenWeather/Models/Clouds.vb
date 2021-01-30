Namespace Models
    Public Class Clouds

        ''' <summary>
        ''' Percent of cloud coverage
        ''' </summary>
        Public ReadOnly Property Coverage As Double


        Friend Sub New(coverage As Double)
            Me.Coverage = coverage
        End Sub

        Friend Sub New(result As Result.Clouds)
            Me.Coverage = result.all
        End Sub

    End Class

End Namespace
