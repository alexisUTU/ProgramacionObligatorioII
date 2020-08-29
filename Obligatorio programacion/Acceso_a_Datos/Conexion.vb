Imports System.Data.Odbc
Public Class Conexion
    Public Shared instancia As Conexion
    Dim conn As New OdbcConnection("dsn=driverODBC;uid=root;pwd=;")

    Public Shared Function Singleton() As Conexion

        If instancia Is Nothing Then
            instancia = New Conexion
        End If
        Return instancia
    End Function
    Public Sub CheckConexion()

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()

            End If

        Catch ex As Exception
            MsgBox("no es x ahi")
        End Try
    End Sub
    Public Sub cerrarConexion()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox("no es x ahi")
        End Try
    End Sub
End Class
