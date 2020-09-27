Imports System.Data.Odbc

Public Class ModeloEmpleado

    Public Shared instancia As ModeloEmpleado

    Public Function Singleton() As ModeloEmpleado

        If instancia Is Nothing Then
            instancia = New ModeloEmpleado
        End If

        Return instancia
    End Function

End Class
