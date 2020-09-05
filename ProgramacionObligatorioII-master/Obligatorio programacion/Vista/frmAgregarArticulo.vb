Imports Logica

Public Class frmAgregarArticulo



    Private Sub btnAgregarArt_Click(sender As Object, e As EventArgs) Handles btnAgregarArt.Click

        Dim articulo As New ControladorArticulo(txtCod.Text, "df", txtDesc.Text, txtPrecio.Text, txtFecha.Text)

        If articulo.altaArticulos() Then
            MsgBox("Artículo ingresado con éxito")
        Else
            MsgBox("Error")
        End If


    End Sub

End Class