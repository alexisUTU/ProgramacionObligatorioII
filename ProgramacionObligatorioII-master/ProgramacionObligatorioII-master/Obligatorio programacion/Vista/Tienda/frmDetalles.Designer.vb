<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDetalles
    Inherits System.Windows.Forms.Form


    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalles))
        Me.pnlDetalles = New System.Windows.Forms.Panel()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblCodigoValor = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblFabricacion = New System.Windows.Forms.Label()
        Me.lblFabricacionValor = New System.Windows.Forms.Label()
        Me.btnAgregarAlCarro = New System.Windows.Forms.Button()
        Me.lblPrecioValor = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblNombreValor = New System.Windows.Forms.Label()
        Me.pcbArticulo = New System.Windows.Forms.PictureBox()
        Me.pnlDetalles.SuspendLayout()
        CType(Me.pcbArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlDetalles
        '
        Me.pnlDetalles.AutoScroll = True
        Me.pnlDetalles.Controls.Add(Me.lblNombre)
        Me.pnlDetalles.Controls.Add(Me.lblCodigoValor)
        Me.pnlDetalles.Controls.Add(Me.lblCodigo)
        Me.pnlDetalles.Controls.Add(Me.lblFabricacion)
        Me.pnlDetalles.Controls.Add(Me.lblFabricacionValor)
        Me.pnlDetalles.Controls.Add(Me.btnAgregarAlCarro)
        Me.pnlDetalles.Controls.Add(Me.lblPrecioValor)
        Me.pnlDetalles.Controls.Add(Me.lblPrecio)
        Me.pnlDetalles.Controls.Add(Me.lblDescripcion)
        Me.pnlDetalles.Controls.Add(Me.lblNombreValor)
        Me.pnlDetalles.Controls.Add(Me.pcbArticulo)
        Me.pnlDetalles.Location = New System.Drawing.Point(38, 56)
        Me.pnlDetalles.MaximumSize = New System.Drawing.Size(1180, 595)
        Me.pnlDetalles.Name = "pnlDetalles"
        Me.pnlDetalles.Size = New System.Drawing.Size(1150, 585)
        Me.pnlDetalles.TabIndex = 1
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblNombre.ForeColor = System.Drawing.SystemColors.Control
        Me.lblNombre.Location = New System.Drawing.Point(6, -1)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(153, 39)
        Me.lblNombre.TabIndex = 19
        Me.lblNombre.Text = "Producto"
        '
        'lblCodigoValor
        '
        Me.lblCodigoValor.AutoSize = True
        Me.lblCodigoValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblCodigoValor.ForeColor = System.Drawing.SystemColors.Control
        Me.lblCodigoValor.Location = New System.Drawing.Point(6, 433)
        Me.lblCodigoValor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodigoValor.Name = "lblCodigoValor"
        Me.lblCodigoValor.Size = New System.Drawing.Size(131, 39)
        Me.lblCodigoValor.TabIndex = 18
        Me.lblCodigoValor.Text = "000000"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblCodigo.ForeColor = System.Drawing.SystemColors.Control
        Me.lblCodigo.Location = New System.Drawing.Point(4, 394)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(126, 39)
        Me.lblCodigo.TabIndex = 17
        Me.lblCodigo.Text = "Codigo"
        '
        'lblFabricacion
        '
        Me.lblFabricacion.AutoSize = True
        Me.lblFabricacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblFabricacion.ForeColor = System.Drawing.SystemColors.Control
        Me.lblFabricacion.Location = New System.Drawing.Point(409, 0)
        Me.lblFabricacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFabricacion.Name = "lblFabricacion"
        Me.lblFabricacion.Size = New System.Drawing.Size(194, 39)
        Me.lblFabricacion.TabIndex = 16
        Me.lblFabricacion.Text = "Fabricacion"
        '
        'lblFabricacionValor
        '
        Me.lblFabricacionValor.AutoSize = True
        Me.lblFabricacionValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblFabricacionValor.ForeColor = System.Drawing.SystemColors.Control
        Me.lblFabricacionValor.Location = New System.Drawing.Point(409, 38)
        Me.lblFabricacionValor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFabricacionValor.Name = "lblFabricacionValor"
        Me.lblFabricacionValor.Size = New System.Drawing.Size(187, 39)
        Me.lblFabricacionValor.TabIndex = 15
        Me.lblFabricacionValor.Text = "00/00/0000"
        '
        'btnAgregarAlCarro
        '
        Me.btnAgregarAlCarro.BackColor = System.Drawing.Color.Gainsboro
        Me.btnAgregarAlCarro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarAlCarro.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAgregarAlCarro.FlatAppearance.BorderSize = 0
        Me.btnAgregarAlCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarAlCarro.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarAlCarro.Location = New System.Drawing.Point(867, 424)
        Me.btnAgregarAlCarro.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregarAlCarro.Name = "btnAgregarAlCarro"
        Me.btnAgregarAlCarro.Size = New System.Drawing.Size(246, 56)
        Me.btnAgregarAlCarro.TabIndex = 14
        Me.btnAgregarAlCarro.Text = "Agregar al carro"
        Me.btnAgregarAlCarro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregarAlCarro.UseVisualStyleBackColor = False
        '
        'lblPrecioValor
        '
        Me.lblPrecioValor.AutoSize = True
        Me.lblPrecioValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblPrecioValor.ForeColor = System.Drawing.SystemColors.Control
        Me.lblPrecioValor.Location = New System.Drawing.Point(950, 39)
        Me.lblPrecioValor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrecioValor.Name = "lblPrecioValor"
        Me.lblPrecioValor.Size = New System.Drawing.Size(121, 39)
        Me.lblPrecioValor.TabIndex = 12
        Me.lblPrecioValor.Text = "000.00"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblPrecio.ForeColor = System.Drawing.SystemColors.Control
        Me.lblPrecio.Location = New System.Drawing.Point(948, 0)
        Me.lblPrecio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(114, 39)
        Me.lblPrecio.TabIndex = 11
        Me.lblPrecio.Text = "Precio"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblDescripcion.Location = New System.Drawing.Point(7, 509)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(15, 0, 15, 0)
        Me.lblDescripcion.MaximumSize = New System.Drawing.Size(1110, 0)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(1106, 288)
        Me.lblDescripcion.TabIndex = 10
        Me.lblDescripcion.Text = resources.GetString("lblDescripcion.Text")
        '
        'lblNombreValor
        '
        Me.lblNombreValor.AutoSize = True
        Me.lblNombreValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblNombreValor.ForeColor = System.Drawing.SystemColors.Control
        Me.lblNombreValor.Location = New System.Drawing.Point(4, 38)
        Me.lblNombreValor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombreValor.Name = "lblNombreValor"
        Me.lblNombreValor.Size = New System.Drawing.Size(142, 39)
        Me.lblNombreValor.TabIndex = 9
        Me.lblNombreValor.Text = "Xxxxxxx"
        '
        'pcbArticulo
        '
        Me.pcbArticulo.Image = Global.Vista.My.Resources.Resources.iconfinder_43_Duck_River_Canada_4783009
        Me.pcbArticulo.Location = New System.Drawing.Point(6, 80)
        Me.pcbArticulo.Name = "pcbArticulo"
        Me.pcbArticulo.Size = New System.Drawing.Size(1107, 400)
        Me.pcbArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbArticulo.TabIndex = 0
        Me.pcbArticulo.TabStop = False
        '
        'frmDetalles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1188, 640)
        Me.Controls.Add(Me.pnlDetalles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmDetalles"
        Me.Text = "frmBienvenida"
        Me.pnlDetalles.ResumeLayout(False)
        Me.pnlDetalles.PerformLayout()
        CType(Me.pcbArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pcbArticulo As PictureBox
    Friend WithEvents pnlDetalles As Panel
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblNombreValor As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblPrecioValor As Label
    Friend WithEvents btnAgregarAlCarro As Button
    Friend WithEvents lblFabricacionValor As Label
    Friend WithEvents lblFabricacion As Label
    Friend WithEvents lblCodigoValor As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents lblNombre As Label
End Class
