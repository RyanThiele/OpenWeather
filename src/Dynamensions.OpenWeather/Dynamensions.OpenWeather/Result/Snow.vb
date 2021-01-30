Imports System.Text.Json.Serialization

Namespace Result
    Friend Structure Snow
        <JsonPropertyName("1h")>
        Public Property OneHour As Double

        <JsonPropertyName("3h")>
        Public Property ThreeHour As Double
    End Structure
End Namespace

