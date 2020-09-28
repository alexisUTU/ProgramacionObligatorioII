Imports System.Data.Odbc

Public Class ModeloPersona
    Public Shared instancia As ModeloPersona

    Public Shared Function Singleton() As ModeloPersona

        If instancia Is Nothing Then
            instancia = New ModeloPersona
        End If

        Return instancia
    End Function
    Public Function AltaPersona(cedula As String, pnom As String, snom As String,
                              pape As String, sape As String, telefono As String,
                              direccion As String) As Boolean
        Dim consulta As String = "INSERT INTO PERSONAS (cedula, primer_nombre," &
            " segundo_nombre, primer_apellido, segundo_apellido, telefono, direccion) " &
            "VALUES (?,?,?,?,?,?,?)"
        Dim parametros As New List(Of OdbcParameter)

        parametros.Add(New OdbcParameter("cedula", cedula))
        parametros.Add(New OdbcParameter("primer_nombre", pnom))
        parametros.Add(New OdbcParameter("segundo_nombre", snom))
        parametros.Add(New OdbcParameter("primer_apellido", pape))
        parametros.Add(New OdbcParameter("segundo_apellido", sape))
        parametros.Add(New OdbcParameter("telefono", telefono))
        parametros.Add(New OdbcParameter("direccion", direccion))

        If ConsultasBase.Singleton.consultaInsert(parametros, consulta) Then
            Return True
        End If

        Return False
    End Function
End Class
