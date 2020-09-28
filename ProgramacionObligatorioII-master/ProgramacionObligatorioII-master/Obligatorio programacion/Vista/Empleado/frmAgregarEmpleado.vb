Imports Logica
Public Class frmAgregarEmpleado
    Public Shared instancia As frmAgregarEmpleado
    Public Shared Function Singleton() As frmAgregarEmpleado
        If instancia Is Nothing Then
            instancia = New frmAgregarEmpleado
        End If
        Return instancia
    End Function

    Private Sub btnAgregarArt_Click(sender As Object, e As EventArgs) Handles btnAgregarArt.Click
        Dim cEmpleado As New ControladorEmpleado(
            New ControladorPersona(Me.txtCedula.Text, Me.txtPNombre.Text, Me.txtSNombre.Text,
                        Me.txtPApellido.Text, Me.txtSApellido.Text, Integer.Parse(Me.txtTel.Text), Me.txtDir.Text),
            Integer.Parse(Me.txtSueldo.Text))
        Select Case cEmpleado.registrar()
            Case 0
                MsgBox("Empleado ingresado con éxito")
            Case 1
                MsgBox("Error al ingresar el empleado")
            Case 2
                MsgBox("Error al ingresar el persona")
            Case Else
                MsgBox("Error?")
        End Select

    End Sub


End Class