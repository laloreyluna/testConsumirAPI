Imports RestSharp

Public Class DBApi
    Public Function Post(url As String, headers As List(Of Parametro), parametros As List(Of Parametro), objeto As Object) As String
        Dim client = New RestClient()
        client.BaseUrl = New Uri(url)

        Dim request = New RestRequest()
        request.Method = Method.POST

        'Header
        For Each item As Parametro In headers
            request.AddHeader(item.Clave, item.Valor)
        Next

        'Parametros
        For Each parametro As Parametro In parametros
            request.AddParameter(parametro.Clave, parametro.Valor)
        Next

        If parametros.Count = 0 Then
            request.AddJsonBody(objeto)
        End If

        Dim response = client.Execute(request).Content.ToString
        Return response
    End Function
End Class
