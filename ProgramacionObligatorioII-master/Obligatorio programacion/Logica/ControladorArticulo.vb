Imports Acceso_a_Datos
Imports System.Data.Odbc

Public Class ControladorArticulo

    Property codigo As String
    Property foto As String
    Property descripcion As String
    Property precio As String
    Property fecha As String

    Public Sub New()

    End Sub

    Public Sub New(codigo As String, foto As String, descripcion As String, precio As String, fecha As String)

        Me.codigo = codigo
        Me.foto = foto
        Me.descripcion = descripcion
        Me.precio = precio
        Me.fecha = fecha

    End Sub

    Public Function altaArticulos() As Boolean

        Dim consulta As String = "INSERT INTO articulos (codigo, foto, descripcion, precio, fecha_fabricacion) VALUES (?,?,?,?,?)"

        Dim parametros As New List(Of OdbcParameter)
        parametros.Add(New OdbcParameter("codigo", codigo))
        parametros.Add(New OdbcParameter("foto", foto))
        parametros.Add(New OdbcParameter("descripcion", descripcion))
        parametros.Add(New OdbcParameter("precio", precio))
        parametros.Add(New OdbcParameter("fecha_fabricacion", fecha))

        If ConsultasBase.Singleton.consultaInsert(parametros, consulta) Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function listarArticulos() As DataTable
        Dim consulta As String = "SELECT foto AS Foto, descripcion AS Descripcion, precio AS Precio, fecha_fabricacion AS FechaFabricacion FROM articulos"
        Return ConsultasBase.Singleton.ConsultaTabla(consulta)

    End Function
End Class
