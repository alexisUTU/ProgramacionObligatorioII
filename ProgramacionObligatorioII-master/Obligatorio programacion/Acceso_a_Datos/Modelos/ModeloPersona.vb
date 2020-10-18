
Imports MySql.Data.MySqlClient

Public Class ModeloPersona
    Public Shared instancia As ModeloPersona

    Public Shared Function Singleton() As ModeloPersona

        If instancia Is Nothing Then
            instancia = New ModeloPersona
        End If

        Return instancia
    End Function
    Public Function AltaPersona(cedula As Integer, pnom As String, snom As String,
                              pape As String, sape As String, telefono As String,
                              direccion As String) As Boolean
        Dim consulta As String = "INSERT INTO PERSONAS (cedula, primer_nombre," &
            " segundo_nombre, primer_apellido, segundo_apellido, telefono, direccion) " &
            "VALUES (?,?,?,?,?,?,?)"
        Dim parametros As New List(Of MySqlParameter)

        parametros.Add(New MySqlParameter("cedula", cedula))
        parametros.Add(New MySqlParameter("primer_nombre", pnom))
        parametros.Add(New MySqlParameter("segundo_nombre", snom))
        parametros.Add(New MySqlParameter("primer_apellido", pape))
        parametros.Add(New MySqlParameter("segundo_apellido", sape))
        parametros.Add(New MySqlParameter("telefono", telefono))
        parametros.Add(New MySqlParameter("direccion", direccion))

        If ConsultasBase.Singleton.consultaInsert(parametros, consulta) Then
            Return True
        End If

        Return False
    End Function

    Public Function ModificarPersona(cedula As Integer, pnom As String,
            snom As String, pape As String, sape As String, telefono As Integer,
            direccion As String) As Boolean
        Dim consulta As String = "UPDATE PERSONAS SET " &
            "primer_nombre=?, segundo_nombre=?, primer_apellido=?, " &
            "segundo_apellido=?, telefono=?, direccion=? WHERE cedula=?"

        Dim parametros As New List(Of MySqlParameter)

        With parametros
            .Add(New MySqlParameter("primer_nombre", pnom))
            .Add(New MySqlParameter("segundo_nombre", snom))
            .Add(New MySqlParameter("primer_apellido", pape))
            .Add(New MySqlParameter("segundo_apellido", sape))
            .Add(New MySqlParameter("telefono", telefono))
            .Add(New MySqlParameter("direccion", direccion))
            .Add(New MySqlParameter("cedula", cedula))
        End With



        If ConsultasBase.Singleton.consultaInsert(parametros, consulta) Then
            Return True
        End If

        Return False
    End Function
    Public Function QuitarPersona(cedula As Integer) As Boolean

        Dim consulta As String = "DELETE FROM PERSONAS WHERE cedula=?"

        Dim parametros As New List(Of MySqlParameter)
        parametros.Add(New MySqlParameter("cedula", cedula))

        If ConsultasBase.Singleton.consultaInsert(parametros, consulta) Then
            Return True
        End If
        Return False
    End Function
End Class
