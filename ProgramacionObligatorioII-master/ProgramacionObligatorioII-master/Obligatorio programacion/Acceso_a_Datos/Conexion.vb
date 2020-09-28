Imports System.Data.Odbc

Public Class Conexion

    Public Shared instancia As Conexion
    Public Property connection As New OdbcConnection(
            "dsn=" + "driverodbc" +
            ";uid=" + "sysMati" +
            ";pwd=" + "mati123" +
            ";port=" + "3306" +
            ";database=" + "empresa" +
            ";server=" + "bytesoft.duckdns.org"
            )
    'Public Property Connection As New OdbcConnection(
    '        "dsn=" + "driverODBCLocal" +
    '        ";UID=" + "root" +
    '        ";PWD=" + "" +
    '        ";PORT=" + "3308" +
    '        ";DATABASE=" + "empresa" +
    '        ";SERVER=" + "localhost"
    '        )

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
