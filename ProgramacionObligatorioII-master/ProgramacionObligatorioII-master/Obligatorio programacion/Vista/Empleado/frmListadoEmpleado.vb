Imports Logica
Public Class frmListadoEmpleado

    Private Sub frmListados_Load(sender As Object, e As EventArgs) Handles Me.Load
        If ControladorEmpleado.ListarEmpleados IsNot Nothing Then
            dgvListadoEmpleado.DataSource = ControladorEmpleado.ListarEmpleados
        Else
            MsgBox("Error al cargar el listado")
        End If
    End Sub
End Class