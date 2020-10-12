Imports Logica

Public Class frmDetalles

    Property articulo As ControladorArticulo
    Property id As Integer
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
        End With
        ' agregar si esta en lista de compras btnAgregarAlCarro pase a decir sacar del carro
    End Sub

    Private Sub btnAgregarAlCarro_Click(sender As Object, e As EventArgs) Handles btnAgregarAlCarro.Click

    End Sub

End Class