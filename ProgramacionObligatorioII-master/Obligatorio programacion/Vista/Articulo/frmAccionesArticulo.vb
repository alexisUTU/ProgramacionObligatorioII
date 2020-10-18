Imports System.IO
Imports Logica

Public Class frmAccionesArticulo

    Property pathImage As String
    Property articulo As ControladorArticulo
    Property id As Integer
    Sub New(id As Integer, articulo As ControladorArticulo)


        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.id = id
        Me.pathImage = Nothing
        Me.articulo = articulo

        With articulo
            Me.txtCod.Text = .codigo
            Me.txtNombre.Text = .nombre
            Me.txtDesc.Text = .descripcion
            Me.txtFecha.Text = .fecha
            Me.txtPrecio.Text = .precio
        End With

        If Not Me.articulo.foto = "" Then
            Using ms As New MemoryStream(Convert.FromBase64String(articulo.foto))
                Dim streamImage As Bitmap = Image.FromStream(ms)
                If Not IsNothing(streamImage) Then
                    Me.pcbArticulo.Image = streamImage
                End If
            End Using
        End If

    End Sub

    Private Sub btnModificarArt_Click(sender As Object, e As EventArgs) Handles btnAgregarArt.Click
        If Verificar.Singleton.VerificarInt(txtCod.Text) Then
            If Verificar.Singleton.VerificarInt(txtPrecio.Text) Then
                If Verificar.Singleton.VerificarString(txtDesc.Text) Then
                    If IsDate(txtFecha.Text) Then
                        If Not pathImage Is Nothing Then
                            Me.articulo.foto = Base64(pathImage)
                        End If
                        Dim articulo As New ControladorArticulo(CType(txtCod.Text, Int32),
                                Me.articulo.foto, Me.txtNombre.Text, txtDesc.Text, CType(txtPrecio.Text, Double),
                                CType(txtFecha.Text, Date)
                        )
                        If articulo.ModificarArticulo(id) Then
                            MsgBox("Artículo modificado con éxito")

                            Menu_Principal.frmChange(New frmListadoArticulo)
                        Else
                            MsgBox("Error al modificar el artículo")
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
    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click

        If articulo.QuitarArticulo(id) Then
            MsgBox("Artículo quitado con éxito")
            Menu_Principal.frmChange(New frmListadoArticulo)
        Else
            MsgBox("Error al quitar el artículo")
        End If
    End Sub
    Private Sub txtFecha_MouseDown(sender As Object, e As MouseEventArgs) Handles txtFecha.MouseDown
        txtFecha.Select(0, 0)
    End Sub

    Private Sub btnSelecImagen_Click(sender As Object, e As EventArgs) Handles btnSelecImagen.Click
        Dim opf As New OpenFileDialog

        opf.Title = "Seleccione una imágen"
        opf.InitialDirectory = "C:\Users\rpere\OneDrive\Escritorio\Programacion\Solución\Vista\bin\Debug"
        opf.Filter = "Imágen|*.jpg;*.png"

        If opf.ShowDialog = DialogResult.OK Then
            pathImage = opf.FileName
            pcbArticulo.Image = Image.FromFile(pathImage)
        End If
    End Sub

    Private Function Base64(path As String) As String

        Dim convert64 As String = ""
        Dim stream As New IO.MemoryStream
        Dim bitmap As New Bitmap(path)
        Dim imgFormat As Imaging.ImageFormat = Imaging.ImageFormat.Jpeg

        bitmap.Save(stream, imgFormat)
        convert64 = Convert.ToBase64String(stream.ToArray)

        Return convert64
    End Function


    Private Sub pcbArticulo_Click(sender As Object, e As EventArgs) Handles pcbArticulo.Click
        btnSelecImagen_Click(sender, e)
    End Sub

End Class