Imports Logica
Public Class frmListados
    Private Sub frmListados_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim articulos As New ControladorArticulo
        dgvListado.DataSource = articulos.listarArticulos
    End Sub
End Class