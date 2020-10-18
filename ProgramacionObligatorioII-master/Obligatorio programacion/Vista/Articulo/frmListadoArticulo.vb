Imports Logica
Public Class frmListadoArticulo
    Private Sub frmListados_Load(sender As Object, e As EventArgs) Handles Me.Load

        If ControladorArticulo.ListarArticulo IsNot Nothing Then
            dgvListado.DataSource = ControladorArticulo.ListarArticulo
        Else
            MsgBox("Error al cargar el listado")
        End If
    End Sub

    Private Sub dgvListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListado.CellContentClick
        Dim pos As Integer = e.RowIndex
        If pos > -1 Then
            'Dim senderAux As DataGridView = sender
            'Dim listaDatos = senderAux.CurrentRow.Cells

            Dim listaDatos = sender.CurrentRow.Cells

            Dim codigo As Integer = Integer.Parse(listaDatos(0).Value)
            Dim foto As String = listaDatos(1).Value.ToString
            Dim nombre As String = listaDatos(2).Value.ToString
            Dim precio As Double = Double.Parse(listaDatos(3).Value)
            Dim descripcion As String = listaDatos(4).Value.ToString
            Dim fecha As Date = Date.Parse(listaDatos(5).Value)
            Dim id As Integer = Integer.Parse(listaDatos(6).Value)

            Dim formAcciones As New frmAccionesArticulo(id, New ControladorArticulo(
                codigo, foto, nombre, descripcion, precio, fecha
            ))
            Menu_Principal.frmChange(formAcciones)
        End If

    End Sub
End Class