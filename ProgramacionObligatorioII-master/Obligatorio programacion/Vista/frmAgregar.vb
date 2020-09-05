Public Class frmAgregar
    Public Shared instancia As frmAgregar
    Public Shared Function Singleton() As frmAgregar
        If instancia Is Nothing Then
            instancia = New frmAgregar
        End If
        Return instancia
    End Function
End Class