Imports MySql.Data.MySqlClient

Public Class ModeloCompra : Inherits ModeloArticulo
    Private Shared instancia As ModeloCompra
    Private idsArticulos As New List(Of Integer)
    Public Shared Function Singleton() As ModeloCompra
        If instancia Is Nothing Then
            instancia = New ModeloCompra
        End If
        Return instancia
    End Function
    Public Function ComprarArticulos() As Integer
        ' id : un eleemnto no se pudo comprar

        Dim ocurrioError As Integer
        For Each id As Integer In idsArticulos
            Dim consulta As String = "CALL comprar(?)"
            Dim parametros As New List(Of MySqlParameter)
            parametros.Add(New MySqlParameter("id", id))
            If ConsultasBase.Singleton.consultaInsert(parametros, consulta) Then
                ocurrioError = id
            End If
        Next
        Return ocurrioError
    End Function

    Public Sub QuitarLista(id As Integer)
        Me.idsArticulos.Add(id)
    End Sub

    Public Sub AgregarALista(id As Integer)
        Me.idsArticulos.Add(id)
    End Sub
End Class
