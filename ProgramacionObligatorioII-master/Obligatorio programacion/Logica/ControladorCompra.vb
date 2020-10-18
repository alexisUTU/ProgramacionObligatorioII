Imports Acceso_a_Datos

Public Class ControladorCompra
    Public dt As DataTable

    Private Shared instancia As ControladorCompra

    Public Shared Function Singleton() As ControladorCompra
        If instancia Is Nothing Then
            instancia = New ControladorCompra
            instancia.dt = New DataTable
        End If
        Return instancia
    End Function


    Public Function seleccionarArticulo(id As Integer) As DataTable
        Try
            Dim resultado As DataTable = ModeloCompra.Singleton.SeleccionarArticulo(id)
            Return resultado
        Catch ex As Exception
            Return Nothing
        End Try
        Return Nothing
    End Function
    Public Function AgregarALista(id As Integer)
        ModeloCompra.Singleton.AgregarALista(id)
    End Function
    Public Function QuitarLista(id As Integer)
        ModeloCompra.Singleton.QuitarLista(id)
    End Function
    Public Function ComprarArticulos() As Boolean
        Try
            Dim resultado As Boolean = ModeloCompra.Singleton.ComprarArticulos()
            Return resultado
        Catch ex As Exception
            Return False
        End Try

        Return False
    End Function
End Class
