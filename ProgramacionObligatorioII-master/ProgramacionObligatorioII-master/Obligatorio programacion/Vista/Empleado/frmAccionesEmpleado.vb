Imports Logica
Public Class frmAccionesEmpleado
    Property empleado As ControladorEmpleado
    Sub New(empleado As ControladorEmpleado)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.empleado = empleado
        With empleado
            Me.txtCedula.Text = .cedula
            Me.txtDir.Text = .direccion
            Me.txtPNombre.Text = .pNombre
            Me.txtSNombre.Text = .sNombre
            Me.txtPApellido.Text = .pApellido
            Me.txtSApellido.Text = .sApellido
            Me.txtSueldo.Text = .sueldo
            Me.txtTel.Text = .telefono
        End With

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub


    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        If Me.empleado.quitar() Then
            MsgBox("Empleado quitado con éxito")
            Menu_Principal.frmChange(New frmListadoEmpleado)
        Else
            MsgBox("Error al quitar el empleado")
        End If
    End Sub

    Private Sub btnModEmp_Click(sender As Object, e As EventArgs) Handles btnModEmp.Click
        Dim cEmpleado As New ControladorEmpleado(
                     New ControladorPersona(Integer.Parse(Me.txtCedula.Text), Me.txtPNombre.Text, Me.txtSNombre.Text,
                Me.txtPApellido.Text, Me.txtSApellido.Text, Integer.Parse(Me.txtTel.Text), Me.txtDir.Text), Integer.Parse(Me.txtSueldo.Text))
        Select Case cEmpleado.modificar()
            Case 0
                MsgBox("Empleado modificado con éxito")
            Case 1
                MsgBox("Error al modificar empleado")
            Case 2
                MsgBox("Error al modificar persona")
            Case Else
                MsgBox("Error?")
        End Select
        Menu_Principal.frmChange(New frmListadoEmpleado)

    End Sub
End Class