Imports Acceso_a_Datos
Imports System.Data.Odbc

Public Class ControladorEmpleado : Inherits ControladorPersona
    Property sueldo As Integer
    Sub New(p As ControladorPersona, sueldo As Integer)
        MyBase.New(p)
        Me.sueldo = sueldo
    End Sub
    Public Overrides Function registrar() As Integer
        If MyBase.registrar() = 0 Then
            Return ModeloEmpleado.Singleton.AltaEmpleado(cedula, sueldo)
        Else
            Return 2
        End If
    End Function
    Public Overrides Function modificar() As Integer
        If MyBase.modificar() = 0 Then
            If ModeloEmpleado.Singleton.ModificarEmpleado(cedula, sueldo) Then
                Return 0
            Else
                Return 1
            End If
        Else
            Return 2
        End If
    End Function
    Public Overrides Function quitar() As Integer
        If MyBase.quitar() = 0 Then
            Return ModeloEmpleado.Singleton.QuitarEmpleado(cedula)
        Else
            Return 2
        End If
    End Function
    Public Shared Function ListarEmpleados() As DataTable
        Try
            Dim tabla As DataTable = ModeloEmpleado.Singleton.ListarEmpleados
            Return tabla
        Catch ex As Exception
            Return Nothing
        End Try

        Return Nothing
    End Function
End Class
