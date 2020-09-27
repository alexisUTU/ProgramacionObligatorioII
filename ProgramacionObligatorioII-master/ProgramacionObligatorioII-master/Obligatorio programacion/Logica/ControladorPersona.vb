Imports System.Data.Odbc
Imports Acceso_a_Datos

Public Class ControladorPersona
    Property cedula As String
    Property pNombre As String
    Property sNombre As String
    Property pApellido As String
    Property sApellido As String
    Property telefono As String
    Property direccion As String

    Sub New(cedula As String, pNombre As String, sNombre As String, pApellido As String,
               sApellido As String, telefono As String, direccion As String)
        Me.cedula = cedula
        Me.pNombre = pNombre
        Me.sNombre = sNombre
        Me.pApellido = pApellido
        Me.sApellido = sApellido
        Me.telefono = telefono
        Me.direccion = direccion
    End Sub

    Public Overridable Function registrar() As Boolean
        Dim consulta As String = "INSERT INTO PERSONA VALUES (?,?,?,?,?)"
        Dim parametros As New List(Of OdbcParameter)

        parametros.Add(New OdbcParameter("cedula", Me.cedula))
        parametros.Add(New OdbcParameter("primer_nombre", Me.pNombre))
        parametros.Add(New OdbcParameter("segundo_nombre", Me.sNombre))
        parametros.Add(New OdbcParameter("primer_apellido", Me.pApellido))
        parametros.Add(New OdbcParameter("segundo_apellido", Me.sApellido))
        parametros.Add(New OdbcParameter("telefono", Me.telefono))
        parametros.Add(New OdbcParameter("direccion", Me.direccion))

        If ConsultasBase.Singleton.consultaInsert(parametros, consulta) Then
            Return True
        End If

        Return False
    End Function

End Class
