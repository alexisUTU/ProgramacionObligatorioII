Imports Logica
Public Class frmAgregar
    Public Shared instancia As frmAgregar
    Public Shared Function Singleton() As frmAgregar
        If instancia Is Nothing Then
            instancia = New frmAgregar
        End If
        Return instancia
    End Function

    Private Sub btnAgregarArt_Click(sender As Object, e As EventArgs) Handles btnAgregarArt.Click
        Dim cEmpleado As New ControladorEmpleado(Me.txtCedula.Text, Me.txtPNombre.Text, Me.txtSNombre.Text, Me.txtPApellido.Text, Me.txtSApellido.Text, "", "", Integer.Parse(Me.txtSueldo.Text))

        If cEmpleado.registrar() Then
            MsgBox("OPJIADGASDJK")
        Else
            MsgBox("xd")
        End If
    End Sub


End Class