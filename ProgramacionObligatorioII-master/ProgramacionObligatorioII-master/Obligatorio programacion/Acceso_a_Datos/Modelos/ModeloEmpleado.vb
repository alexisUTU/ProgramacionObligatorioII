Imports System.Data.Odbc

Public Class ModeloEmpleado

    Public Shared instancia As ModeloEmpleado

    Public Shared Function Singleton() As ModeloEmpleado

        If instancia Is Nothing Then
            instancia = New ModeloEmpleado
        End If

        Return instancia
    End Function
    Function AltaEmpleado(cedula As String, sueldo As Integer) As Integer
        Dim consulta As String = "INSERT INTO EMPLEADOS VALUES (?,?)"
        Dim parametros As New List(Of OdbcParameter)

        parametros.Add(New OdbcParameter("cedula", cedula))
        parametros.Add(New OdbcParameter("sueldoMens", sueldo))

        If ConsultasBase.Singleton.consultaInsert(parametros, consulta) Then
            Return 0
        End If
        Return 1
    End Function
    Public Function ListarEmpleados()

        Dim consulta As String = "CALL listarEmpleados"
        Return ConsultasBase.Singleton.ConsultaTabla(consulta)
    End Function

End Class
