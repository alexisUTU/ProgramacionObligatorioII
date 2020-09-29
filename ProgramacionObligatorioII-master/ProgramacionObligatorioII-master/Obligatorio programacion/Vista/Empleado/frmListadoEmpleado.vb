Imports Logica
Public Class frmListadoEmpleado

    Private Sub frmListados_Load(sender As Object, e As EventArgs) Handles Me.Load
        If ControladorEmpleado.ListarEmpleados IsNot Nothing Then
            dgvListadoEmpleado.DataSource = ControladorEmpleado.ListarEmpleados
        Else
            MsgBox("Error al cargar el listado")
        End If
    End Sub

    Private Sub dgvListadoEmpleado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoEmpleado.CellDoubleClick
        'Dim senderAux As DataGridView = sender
        'Dim listaDatos = senderAux.CurrentRow.Cells

        Dim listaDatos = sender.CurrentRow.Cells
        Dim cedula As Integer = Integer.Parse(listaDatos(0).Value)
        Dim sueldo As Integer = Integer.Parse(listaDatos(1).value)

        Dim primer_nombre As String = listaDatos(3).Value.ToString
        Dim segundo_nombre As String = listaDatos(4).Value.ToString
        Dim primer_apellido As String = listaDatos(5).Value.ToString
        Dim segundo_apellido As String = listaDatos(6).Value.ToString
        Dim telefono As Integer = Integer.Parse(listaDatos(7).Value)
        Dim direccion As String = listaDatos(8).value.ToString

        Dim formAcciones As New frmAccionesEmpleado(New ControladorEmpleado(
                New ControladorPersona(cedula, primer_nombre, segundo_nombre,
            primer_apellido, segundo_apellido, telefono, direccion), sueldo
        ))
        Menu_Principal.frmChange(formAcciones)
    End Sub

End Class