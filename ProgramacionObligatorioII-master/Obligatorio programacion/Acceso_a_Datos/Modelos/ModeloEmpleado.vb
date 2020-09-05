Imports System.Data.Odbc

Public Class ModeloEmpleado

    Public Shared instancia As ModeloEmpleado

    Public Function Singleton() As ModeloEmpleado

        If instancia Is Nothing Then
            instancia = New ModeloEmpleado
        End If

    End Function

    Public Function alta()

    End Function

    Public Function baja()

    End Function

End Class
