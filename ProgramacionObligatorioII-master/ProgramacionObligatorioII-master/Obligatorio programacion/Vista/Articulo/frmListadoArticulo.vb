Imports Logica
Public Class frmListadoArticulo

    Private Sub frmListados_Load(sender As Object, e As EventArgs) Handles Me.Load

        If ControladorArticulo.ListarArticulo IsNot Nothing Then
            dgvListado.DataSource = ControladorArticulo.ListarArticulo
        Else
            MsgBox("Error al cargar el listado")
        End If
    End Sub
End Class