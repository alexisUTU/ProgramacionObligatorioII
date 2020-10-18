Imports MySql.Data.MySqlClient

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
        Dim command As New MySqlCommand(consulta, Conexion.Singleton.connection)

        Return command.ExecuteScalar()

    End Function

    Public Function ConsultaTabla(consulta As String) As DataTable

        Conexion.Singleton.CheckConexion()
        Dim tabla As New DataTable
        Dim adapter As New MySqlDataAdapter(consulta, Conexion.Singleton.connection)

        adapter.Fill(tabla)

        Return tabla

    End Function
    Public Function ConsultaTabla(parametros As List(Of MySqlParameter), consulta As String) As DataTable
        Conexion.Singleton.CheckConexion()

        Dim tabla As New DataTable
        Dim adapter As New MySqlDataAdapter(consulta, Conexion.Singleton.connection)

        For Each parameter In parametros
            adapter.SelectCommand.Parameters.Add(parameter)
        Next

        adapter.Fill(tabla)

        Return tabla
    End Function

    Public Function consultaInsert(parametros As List(Of MySqlParameter), consulta As String) As Boolean

        Conexion.Singleton.CheckConexion()
        Dim command As New MySqlCommand(consulta, Conexion.Singleton.connection)

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
