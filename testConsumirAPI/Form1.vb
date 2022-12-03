Imports Newtonsoft.Json

Public Class Form1
    Private Sub btnAPIJson_Click(sender As Object, e As EventArgs) Handles btnAPIJson.Click
        Dim persona = New Persona()
        persona.Nombre = "Gerardo Reyes"
        persona.Oficio = "Desarrollador"

        Dim url As String = "https://jsonplaceholder.typicode.com/users"

        Dim headers = New List(Of Parametro) From {
                New Parametro("Authorization", "bearer asdasdas"),
                New Parametro("Cookie", "asdasdasdas")
            }

        Dim api = New DBApi
        Dim parametros = New List(Of Parametro)
        Dim response = api.Post(url, headers, parametros, persona)

        Dim result = JsonConvert.DeserializeObject(Of respuesta)(response)
        txtID.Text = result.id.tostring()
    End Sub

    Private Sub btnAPIParametro_Click(sender As Object, e As EventArgs) Handles btnAPIParametro.Click
        Dim persona = New Persona()
        persona.Nombre = "Gerardo Reyes"
        persona.Oficio = "Desarrollador"

        Dim url As String = "https://jsonplaceholder.typicode.com/users"

        Dim headers = New List(Of Parametro) From {
                New Parametro("Authorization", "bearer asdasdas"),
                New Parametro("Cookie", "asdasdasdas")
            }

        Dim api = New DBApi
        Dim parametros = New List(Of Parametro) From {
             New Parametro("Nombre", "Gerardo Reyes"),
             New Parametro("Oficio", "Desarrollador")
            }
        Dim response = api.Post(url, headers, parametros, Nothing)

        Dim result = JsonConvert.DeserializeObject(Of respuesta)(response)
        txtID.Text = result.id.ToString()
    End Sub
End Class

Class respuesta
    Public Property nombre As String
    Public Property oficio As String
    Public Property id As Integer
End Class
