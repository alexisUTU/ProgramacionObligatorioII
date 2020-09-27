Imports Logica

Public Class frmAgregarArticulo

    Dim pathImage As String

    Private Sub btnAgregarArt_Click(sender As Object, e As EventArgs) Handles btnAgregarArt.Click

        If Verificar.Singleton.VerificarInt(txtCod.Text) Then
            If Verificar.Singleton.VerificarInt(txtPrecio.Text) Then
                If Verificar.Singleton.VerificarString(txtDesc.Text) Then
                    If IsDate(txtFecha.Text) Then

                        Dim articulo As New ControladorArticulo(CType(txtCod.Text, Int32), Base64(pathImage), txtDesc.Text, CType(txtPrecio.Text, Double), CType(txtFecha.Text, Date))

                        If articulo.AltaArticulos() Then
                            MsgBox("Artículo ingresado con éxito")
                        Else
                            MsgBox("Error al ingresar el artículo")
                        End If

                    Else
                        MsgBox("Error al ingresar la fecha")
                    End If
                Else
                    MsgBox("Error al ingresar la descripción")
                End If
            Else
                MsgBox("Error al ingresar el precio")
            End If
        Else
            MsgBox("Error al ingresar el código")
        End If

    End Sub

    Private Sub txtFecha_MouseDown(sender As Object, e As MouseEventArgs) Handles txtFecha.MouseDown
        txtFecha.Select(0, 0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim opf As New OpenFileDialog

        opf.Title = "Seleccione una imágen"
        opf.InitialDirectory = "C:\Users\rpere\OneDrive\Escritorio\Programacion\Solución\Vista\bin\Debug"
        opf.Filter = "Imágen|*.jpg;*.png"

        If opf.ShowDialog = DialogResult.OK Then
            pathImage = opf.FileName
            PictureBox1.Image = Image.FromFile(pathImage)
        End If

    End Sub

    Private Function Base64(path As String)

        Dim convert64 As String = ""
        Dim stream As New IO.MemoryStream
        Dim bitmap As New Bitmap(path)
        Dim imgFormat As Imaging.ImageFormat = Imaging.ImageFormat.Jpeg

        bitmap.Save(stream, imgFormat)
        convert64 = Convert.ToBase64String(stream.ToArray)

        Return convert64
    End Function

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class