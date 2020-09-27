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

    Public Function ListarArticulo()

        Dim consulta As String = "SELECT foto AS Foto, descripcion AS Descripcion, precio AS Precio, fecha_fabricacion AS FechaFabricacion FROM articulos"

        Return ConsultasBase.Singleton.ConsultaTabla(consulta)
    End Function

End Class
