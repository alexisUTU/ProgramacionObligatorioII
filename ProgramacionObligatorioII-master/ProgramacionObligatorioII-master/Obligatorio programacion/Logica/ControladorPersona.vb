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
    Sub New(p As ControladorPersona)
        Me.New(p.cedula, p.pNombre, p.sNombre, p.pApellido, p.sApellido, p.telefono, p.direccion)
    End Sub
    Public Overridable Function registrar() As Integer
        If ModeloPersona.Singleton.AltaPersona(cedula, pNombre, sNombre,
                    pApellido, sApellido, telefono, direccion) Then
            Return 0
        End If
        Return 2
    End Function

End Class
