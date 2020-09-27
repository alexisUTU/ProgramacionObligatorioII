Imports System.Data.Odbc

Public Class Conexion

    Public Shared instancia As Conexion
    Public Property Connection As New OdbcConnection(
            "dsn=" + "driverODBC" +
            ";UID=" + "sysMati" +
            ";PWD=" + "mati123" +
            ";PORT=" + "3306" +
            ";DATABASE=" + "empresa" +
            ";SERVER=" + "bytesoft.duckdns.org"
            )

    Public Shared Function Singleton() As Conexion

        If instancia Is Nothing Then
            instancia = New Conexion
        End If

        Return instancia
    End Function

    Public Sub CheckConexion()

        Try
            If Connection.State = ConnectionState.Closed Then
                Me.Connection.Open()
            End If

        Catch ex As Exception
            MsgBox("Error al conectarse a la base de datos")
        End Try

    End Sub

    Public Sub CerrarConexion()

        Try
            If Connection.State = ConnectionState.Open Then
                Connection.Close()
            End If

        Catch ex As Exception
            MsgBox("Error al conectarse a la base de datos")
        End Try

    End Sub

End Class
