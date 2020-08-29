Imports System.Data.Odbc
Public Class ModeloArticulo
    Public Shared instancia As ModeloArticulo
    Public Shared Function Singleton() As ModeloArticulo

        If instancia Is Nothing Then
            instancia = New ModeloArticulo
        End If
    End Function
    Public Function alta()

    End Function
    Public Function baja()

    End Function
End Class
