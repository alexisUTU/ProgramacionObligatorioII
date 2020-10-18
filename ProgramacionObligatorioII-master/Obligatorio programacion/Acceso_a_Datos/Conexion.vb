Imports MySql.Data.MySqlClient

Public Class Conexion

    Public Shared instancia As Conexion
    Public Property connection As MySqlConnection
    'Sub New()
    '    Dim conBuilder As New MySqlConnectionStringBuilder()
    '    With conBuilder
    '        .Server = "bytesoft.duckdns.org"
    '        .Port = 3306
    '        .UserID = "sysMati"
    '        .Password = "mati123"
    '        .Database = "empresa"
    '    End With
    '    connection = New MySqlConnection(conBuilder.ToString)
    'End Sub
    Sub New()
        Dim conBuilder As New MySqlConnectionStringBuilder()
        With conBuilder
            .Server = "localhost"
            .Port = 3308
            .UserID = "root"
            .Password = ""
            .Database = "empresa"
        End With
        connection = New MySqlConnection(conBuilder.ToString)
    End Sub
    Public Shared Function Singleton() As Conexion

        If instancia Is Nothing Then
            instancia = New Conexion
        End If

        Return instancia
    End Function

    Public Sub CheckConexion()

        Try
            If connection.State = ConnectionState.Closed Then
                Me.connection.Open()
            End If

        Catch ex As Exception
            MsgBox("Error al conectarse a la base de datos")
        End Try

    End Sub

    Public Sub CerrarConexion()

        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If

        Catch ex As Exception
            MsgBox("Error al conectarse a la base de datos")
        End Try

    End Sub

End Class
