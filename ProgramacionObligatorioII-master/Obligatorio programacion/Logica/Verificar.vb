Public Class Verificar

    Private Shared instancia As Verificar

    Public Shared Function Singleton() As Verificar

        If instancia Is Nothing Then
            instancia = New Verificar
        End If

        Return instancia
    End Function

    Public Function VerificarString(campo As String) As Boolean

        If Not IsNumeric(campo) Then
            If campo.Length > 6 Then
                Return True
            End If
        End If

        Return False
    End Function

    Public Function VerificarInt(numero As String) As Boolean

        If IsNumeric(numero) Then
            Return True
        End If

        Return False
    End Function

End Class
