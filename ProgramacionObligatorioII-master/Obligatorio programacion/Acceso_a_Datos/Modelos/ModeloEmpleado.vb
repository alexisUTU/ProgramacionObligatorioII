
Imports MySql.Data.MySqlClient

Public Class ModeloEmpleado

    Public Shared instancia As ModeloEmpleado

    Public Shared Function Singleton() As ModeloEmpleado

        If instancia Is Nothing Then
            instancia = New ModeloEmpleado
        End If

        Return instancia
    End Function
    Function AltaEmpleado(cedula As Integer, sueldo As Integer) As Integer
        Dim consulta As String = "INSERT INTO EMPLEADOS VALUES (?,?)"
        Dim parametros As New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("cedula", cedula))
        parametros.Add(New MySqlParameter("sueldoMens", sueldo))

        If ConsultasBase.Singleton.consultaInsert(parametros, consulta) Then
            Return 0
        End If
        Return 1
    End Function

    Public Function ModificarEmpleado(cedula As Integer, sueldo As Integer) As Boolean
        Dim consulta As String = "UPDATE EMPLEADOS SET sueldoMens=? WHERE cedula=?"

        Dim parametros As New List(Of MySqlParameter)

        With parametros
            .Add(New MySqlParameter("sueldoMens", sueldo))
            .Add(New MySqlParameter("cedula", cedula))
        End With

        If ConsultasBase.Singleton.consultaInsert(parametros, consulta) Then
            Return True
        End If

        Return False
    End Function
    Public Function QuitarEmpleado(cedula As Integer) As Boolean

        Dim consulta As String = "DELETE FROM EMPLEADOS WHERE cedula=?"

        Dim parametros As New List(Of MySqlParameter)
        parametros.Add(New MySqlParameter("cedula", cedula))

        If ConsultasBase.Singleton.consultaInsert(parametros, consulta) Then
            Return True
        End If
        Return False
    End Function

    Public Function ListarEmpleados() As DataTable
        Dim consulta As String = "CALL listarEmpleados"
        Return ConsultasBase.Singleton.ConsultaTabla(consulta)
    End Function

    Public Function ListarEmpleadosEmpieza(texto As String) As DataTable
        Dim consulta As String = "CALL listarArticulosPorNombreProducto('" & texto & "')"

        Dim parametros As New List(Of MySqlParameter)
        parametros.Add(New MySqlParameter("nombreProducto", texto))


        Return ConsultasBase.Singleton.ConsultaTabla(consulta)
    End Function
End Class
