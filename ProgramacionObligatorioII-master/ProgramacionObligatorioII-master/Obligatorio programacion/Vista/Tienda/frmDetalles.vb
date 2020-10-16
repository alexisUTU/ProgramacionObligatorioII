Imports Logica

Public Class frmDetalles
    Private logica
    Property articulo As ControladorArticulo
    Property id As Integer
    Sub New(id As Integer, articulo As ControladorArticulo, activarbtnAgregarAlCarro As Boolean)

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
        Me.btnAgregarAlCarro.Enabled = activarbtnAgregarAlCarro
        ' agregar si esta en lista de compras btnAgregarAlCarro pase a decir sacar del carro
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

    Private Sub btnAgregarAlCarro_Click(sender As Object, e As EventArgs) Handles btnAgregarAlCarro.Click

    End Sub
End Class