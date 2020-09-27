Imports System.Data.Odbc

Public Class ConsultasBase

    Public Shared instancia As ConsultasBase

    Public Shared Function Singleton() As ConsultasBase

        If instancia Is Nothing Then
            instancia = New ConsultasBase
        End If

        Return instancia
    End Function

    Public Function ConsultaCampo(consulta As String)

        Conexion.Singleton.CheckConexion()
        Dim command As New OdbcCommand(consulta, Conexion.Singleton.Connection)

        Return command.ExecuteScalar()

    End Function

    Public Function ConsultaTabla(consulta As String) As DataTable

        Conexion.Singleton.CheckConexion()
        Dim tabla As New DataTable
        Dim adapter As New OdbcDataAdapter(consulta, Conexion.Singleton.Connection)
        adapter.Fill(tabla)

        Return tabla

    End Function

    Public Function consultaInsert(parametros As List(Of OdbcParameter), consulta As String) As Boolean

        Conexion.Singleton.CheckConexion()
        Dim command As New OdbcCommand(consulta, Conexion.Singleton.Connection)

        For Each parameter In parametros
            command.Parameters.Add(parameter)
        Next

        If command.ExecuteNonQuery() >= 1 Then
            Conexion.Singleton.CerrarConexion()
            Return True
        Else
            Conexion.Singleton.CerrarConexion()
            Return False
        End If

    End Function

End Class
