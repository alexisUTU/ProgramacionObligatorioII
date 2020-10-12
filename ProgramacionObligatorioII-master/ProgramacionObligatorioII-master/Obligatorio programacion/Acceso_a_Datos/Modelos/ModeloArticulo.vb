Imports System.Data.Mysql
Imports MySql.Data.MySqlClient

Public Class ModeloArticulo

    Public Shared instancia As ModeloArticulo
    Public Shared Function Singleton() As ModeloArticulo

        If instancia Is Nothing Then
            instancia = New ModeloArticulo
        End If

        Return instancia
    End Function
    Public Function AltaArticulo(codigo As Int32, foto As String, nombre As String, descripcion As String, precio As Double, fecha As Date) As Boolean

        Dim consulta As String = "INSERT INTO articulos (codigo, foto, nombre, descripcion, precio, fecha_fabricacion) VALUES (?,?,?,?,?,?)"

        Dim parametros As New List(Of MySqlParameter)
        parametros.Add(New MySqlParameter("codigo", codigo))
        parametros.Add(New MySqlParameter("foto", foto))
        parametros.Add(New MySqlParameter("nombre", nombre))
        parametros.Add(New MySqlParameter("descripcion", descripcion))
        parametros.Add(New MySqlParameter("precio", precio))
        parametros.Add(New MySqlParameter("fecha_fabricacion", fecha))

        If ConsultasBase.Singleton.consultaInsert(parametros, consulta) Then
            Return True
        End If

        Return False
    End Function
    Public Function ModificarArticulo(id As Integer, codigo As Int32, foto As String, nombre As String, descripcion As String, precio As Double, fecha As Date) As Boolean

        Dim consulta As String = "UPDATE ARTICULOS " &
            "SET codigo=?, foto=?,nombre=? descripcion=?, precio=?, fecha_fabricacion=? " &
            "WHERE id_articulo=?"
        Dim parametros As New List(Of MySqlParameter)
        With parametros
            .Add(New MySqlParameter("codigo", codigo))
            .Add(New MySqlParameter("foto", foto))
            .Add(New MySqlParameter("nombre", nombre))
            .Add(New MySqlParameter("descripcion", descripcion))
            .Add(New MySqlParameter("precio", precio))
            .Add(New MySqlParameter("fecha_fabricacion", fecha))
            .Add(New MySqlParameter("id_articulo", id))
        End With

        If ConsultasBase.Singleton.consultaInsert(parametros, consulta) Then
            Return True
        End If
        Return False
    End Function

    Public Function QuitarArticulo(pos As Integer) As Boolean

        Dim consulta As String = "DELETE FROM ARTICULOS WHERE id_articulo=?"

        Dim parametros As New List(Of MySqlParameter)
        parametros.Add(New MySqlParameter("id_articulo", pos))

        If ConsultasBase.Singleton.consultaInsert(parametros, consulta) Then
            Return True
        End If
        Return False
    End Function

    Public Function ListarArticulo()
        Dim consulta As String = "CALL listarArticulos"
        Return ConsultasBase.Singleton.ConsultaTabla(consulta)
    End Function

End Class
