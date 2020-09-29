Imports System.Data.Odbc
Public Class ModeloArticulo

    Public Shared instancia As ModeloArticulo
    Public Shared Function Singleton() As ModeloArticulo

        If instancia Is Nothing Then
            instancia = New ModeloArticulo
        End If

        Return instancia
    End Function
    Public Function AltaArticulo(codigo As Int32, foto As String, descripcion As String, precio As Double, fecha As Date) As Boolean

        Dim consulta As String = "INSERT INTO articulos (codigo, foto, descripcion, precio, fecha_fabricacion) VALUES (?,?,?,?,?)"

        Dim parametros As New List(Of OdbcParameter)
        parametros.Add(New OdbcParameter("codigo", codigo))
        parametros.Add(New OdbcParameter("foto", foto))
        parametros.Add(New OdbcParameter("descripcion", descripcion))
        parametros.Add(New OdbcParameter("precio", precio))
        parametros.Add(New OdbcParameter("fecha_fabricacion", fecha))

        If ConsultasBase.Singleton.consultaInsert(parametros, consulta) Then
            Return True
        End If

        Return False
    End Function
    Public Function ModificarArticulo(id As Integer, codigo As Int32, foto As String, descripcion As String, precio As Double, fecha As Date) As Boolean

        Dim consulta As String = "UPDATE ARTICULOS " &
            "SET codigo=?, foto=?, descripcion=?, precio=?, fecha_fabricacion=? " &
            "WHERE id_articulo=?"
        Dim parametros As New List(Of OdbcParameter)
        With parametros
            .Add(New OdbcParameter("codigo", codigo))
            .Add(New OdbcParameter("foto", foto))
            .Add(New OdbcParameter("descripcion", descripcion))
            .Add(New OdbcParameter("precio", precio))
            .Add(New OdbcParameter("fecha_fabricacion", fecha))
            .Add(New OdbcParameter("id_articulo", id))
        End With

        If ConsultasBase.Singleton.consultaInsert(parametros, consulta) Then
            Return True
        End If
        Return False
    End Function

    Public Function QuitarArticulo(pos As Integer) As Boolean

        Dim consulta As String = "DELETE FROM ARTICULOS WHERE id_articulo=?"

        Dim parametros As New List(Of OdbcParameter)
        parametros.Add(New OdbcParameter("id_articulo", pos))

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
