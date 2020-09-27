Imports Logica
Public Class frmListados

    Dim articulos As New ControladorArticulo

    Private Sub frmListados_Load(sender As Object, e As EventArgs) Handles Me.Load

        If articulos.ListarArticulo IsNot Nothing Then
            dgvListado.DataSource = articulos.ListarArticulo
        Else
            MsgBox("Error al cargar el listado")
        End If

    End Sub

End Class