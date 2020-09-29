Imports System.Data.Odbc
Imports Acceso_a_Datos

Public Class ControladorPersona
    Property cedula As Integer
    Property pNombre As String
    Property sNombre As String
    Property pApellido As String
    Property sApellido As String
    Property telefono As Integer
    Property direccion As String

    Sub New(cedula As Integer, pNombre As String, sNombre As String, pApellido As String,
               sApellido As String, telefono As Integer, direccion As String)
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
    Public Overridable Function modificar() As Integer
        If ModeloPersona.Singleton.ModificarPersona(cedula, pNombre, sNombre,
            pApellido, sApellido, telefono, direccion) Then
            Return 0
        End If
        Return 2
    End Function
    Public Overridable Function quitar() As Integer
        If ModeloPersona.Singleton.QuitarPersona(Me.cedula) Then
            Return 0
        End If
        Return 2
    End Function
End Class
