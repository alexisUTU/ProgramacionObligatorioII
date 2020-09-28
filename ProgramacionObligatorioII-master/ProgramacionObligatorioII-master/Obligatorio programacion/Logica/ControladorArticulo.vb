﻿Imports Acceso_a_Datos
Imports System.Data.Odbc

Public Class ControladorArticulo

    Property codigo As Int32
    Property foto As String
    Property descripcion As String
    Property precio As Double
    Property fecha As Date

    Public Sub New(codigo As Int32, foto As String, descripcion As String, precio As Double, fecha As Date)

        Me.codigo = codigo
        Me.foto = foto
        Me.descripcion = descripcion
        Me.precio = precio
        Me.fecha = fecha

    End Sub
    Public Function AltaArticulos() As Boolean
        Try
            Dim resultado As Boolean = ModeloArticulo.Singleton.AltaArticulo(codigo, foto, descripcion, precio, fecha)
            Return resultado
        Catch ex As Exception
            Return False
        End Try

        Return False
    End Function
    Public Shared Function ListarArticulo() As DataTable
        Try
            Dim tabla As DataTable = ModeloArticulo.Singleton.ListarArticulo
            Return tabla
        Catch ex As Exception
            Return Nothing
        End Try

        Return Nothing
    End Function

End Class
