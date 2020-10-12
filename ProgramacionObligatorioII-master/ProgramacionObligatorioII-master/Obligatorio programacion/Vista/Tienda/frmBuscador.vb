Imports Logica

Public Class frmBuscador
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        cargarLista()
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

            Dim control As New ControladorArticulo(codigo, foto,
                nombre, descripcion, precio, fecha)

            Dim formDetalles As New frmDetalles(id, control)
            Menu_Principal.frmChange(formDetalles)
        End If

    End Sub

    Private Sub frmBuscador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarLista()
    End Sub

    Private Function cargarLista()
        If ControladorEmpleado.ListarEmpleadosEmpieza(Me.txtBuscador.Text) IsNot Nothing Then
            dgvListado.DataSource = ControladorEmpleado.ListarEmpleadosEmpieza(Me.txtBuscador.Text.ToString.ToUpper())
        Else
            MsgBox("Error al cargar el listado")
        End If
    End Function

    Private Sub btnCarro_Click(sender As Object, e As EventArgs) Handles btnCarro.Click
        Menu_Principal.frmChange(New frmListaCarro)
    End Sub
End Class