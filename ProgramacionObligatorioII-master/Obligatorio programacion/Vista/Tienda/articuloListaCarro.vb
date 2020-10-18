Imports Logica

Public Class articuloListaCarro
    Property articulo As ControladorArticulo
    Property id As Integer
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Sub New(id As Integer, articulo As ControladorArticulo)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.id = id
        Me.articulo = articulo
        With articulo
            Me.lblNombreValor.Text = .nombre.Chars(0) + .nombre.Substring(1).ToLower
            Me.lblDescripcion.Text = .descripcion
            Me.lblPrecioValor.Text = .precio
            Me.lblFabricacionValor.Text = .fecha
            Me.lblCodigoValor.Text = .codigo
            If .foto <> "" Then
                Me.pcbArticulo.Image = Base64_A_Image(.foto)
            End If
        End With
    End Sub
    Function Base64_A_Image(ByVal base64string As String) As System.Drawing.Image
        'Setup image and get data stream together
        Dim img As System.Drawing.Image
        Dim MS As System.IO.MemoryStream = New System.IO.MemoryStream
        Dim b64 As String = base64string.Replace(" ", "+")
        Dim b() As Byte

        'Converts the base64 encoded msg to image data
        b = Convert.FromBase64String(b64)
        MS = New System.IO.MemoryStream(b)

        'creates image
        img = System.Drawing.Image.FromStream(MS)
        Return img
    End Function

    Private Sub lblDescripcion_Click(sender As Object, e As EventArgs) Handles pcbArticulo.Click,
        lblFabricacion.Click, lblNombreValor.Click, lblFabricacionValor.Click, lblDescripcion.Click,
        lblPrecioValor.Click, lblPrecio.Click, lblCodigoValor.Click, MyBase.Click
        Menu_Principal.frmChange(New frmDetalles(id, articulo, False))
    End Sub

    Private Sub btnQuitarDelCarro_Click(sender As Object, e As EventArgs) Handles btnQuitarDelCarro.Click
        MsgBox("Quitado")
    End Sub

End Class
