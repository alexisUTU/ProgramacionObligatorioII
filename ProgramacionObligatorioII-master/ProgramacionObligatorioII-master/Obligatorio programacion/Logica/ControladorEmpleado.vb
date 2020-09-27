Imports Acceso_a_Datos
Imports System.Data.Odbc

Public Class ControladorEmpleado

    Inherits ControladorPersona

    Property sueldo As Integer

    Sub New(cedula As String, pNombre As String, sNombre As String, pApellido As String, sApellido As String,
                telefono As String, direccion As String, sueldo As Integer)
        MyBase.New(cedula, pNombre, sNombre, pApellido, sApellido, telefono, direccion)
        Me.sueldo = sueldo
    End Sub

    Public Overrides Function registrar() As Boolean

        MyBase.registrar()
        Dim consulta As String = "INSERT INTO EMPLEADOS VALUES (?,?)"
        Dim parametros As New List(Of OdbcParameter)

        parametros.Add(New OdbcParameter("cedula", Me.cedula))
        parametros.Add(New OdbcParameter("sueldoMens", Me.sueldo))


        If ConsultasBase.Singleton.consultaInsert(parametros, consulta) Then
            Return True
        End If

        Return False

    End Function
End Class
