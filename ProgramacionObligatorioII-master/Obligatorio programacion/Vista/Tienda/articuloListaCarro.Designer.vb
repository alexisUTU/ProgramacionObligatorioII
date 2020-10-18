<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class articuloListaCarro
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(articuloListaCarro))
        Me.btnQuitarDelCarro = New System.Windows.Forms.Button()
        Me.lblPrecioValor = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblFabricacion = New System.Windows.Forms.Label()
        Me.lblFabricacionValor = New System.Windows.Forms.Label()
        Me.lblCodigoValor = New System.Windows.Forms.Label()
        Me.lblNombreValor = New System.Windows.Forms.Label()
        Me.pcbArticulo = New System.Windows.Forms.PictureBox()
        CType(Me.pcbArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnQuitarDelCarro
        '
        Me.btnQuitarDelCarro.BackColor = System.Drawing.Color.Gainsboro
        Me.btnQuitarDelCarro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuitarDelCarro.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnQuitarDelCarro.FlatAppearance.BorderSize = 0
        Me.btnQuitarDelCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitarDelCarro.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarDelCarro.Location = New System.Drawing.Point(833, 189)
        Me.btnQuitarDelCarro.Margin = New System.Windows.Forms.Padding(4)
        Me.btnQuitarDelCarro.Name = "btnQuitarDelCarro"
        Me.btnQuitarDelCarro.Size = New System.Drawing.Size(231, 59)
        Me.btnQuitarDelCarro.TabIndex = 39
        Me.btnQuitarDelCarro.Text = "Quitar del carro"
        Me.btnQuitarDelCarro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnQuitarDelCarro.UseVisualStyleBackColor = False
        '
        'lblPrecioValor
        '
        Me.lblPrecioValor.AutoSize = True
        Me.lblPrecioValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblPrecioValor.ForeColor = System.Drawing.SystemColors.Control
        Me.lblPrecioValor.Location = New System.Drawing.Point(826, 146)
        Me.lblPrecioValor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrecioValor.Name = "lblPrecioValor"
        Me.lblPrecioValor.Size = New System.Drawing.Size(121, 39)
        Me.lblPrecioValor.TabIndex = 38
        Me.lblPrecioValor.Text = "000.00"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblPrecio.ForeColor = System.Drawing.SystemColors.Control
        Me.lblPrecio.Location = New System.Drawing.Point(950, 109)
        Me.lblPrecio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(114, 39)
        Me.lblPrecio.TabIndex = 37
        Me.lblPrecio.Text = "Precio"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoEllipsis = True
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblDescripcion.Location = New System.Drawing.Point(317, 28)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(15, 0, 15, 0)
        Me.lblDescripcion.MaximumSize = New System.Drawing.Size(480, 230)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(479, 230)
        Me.lblDescripcion.TabIndex = 36
        Me.lblDescripcion.Text = resources.GetString("lblDescripcion.Text")
        '
        'lblFabricacion
        '
        Me.lblFabricacion.AutoSize = True
        Me.lblFabricacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblFabricacion.ForeColor = System.Drawing.SystemColors.Control
        Me.lblFabricacion.Location = New System.Drawing.Point(870, 28)
        Me.lblFabricacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFabricacion.Name = "lblFabricacion"
        Me.lblFabricacion.Size = New System.Drawing.Size(194, 39)
        Me.lblFabricacion.TabIndex = 35
        Me.lblFabricacion.Text = "Fabricacion"
        '
        'lblFabricacionValor
        '
        Me.lblFabricacionValor.AutoSize = True
        Me.lblFabricacionValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblFabricacionValor.ForeColor = System.Drawing.SystemColors.Control
        Me.lblFabricacionValor.Location = New System.Drawing.Point(826, 70)
        Me.lblFabricacionValor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFabricacionValor.Name = "lblFabricacionValor"
        Me.lblFabricacionValor.Size = New System.Drawing.Size(187, 39)
        Me.lblFabricacionValor.TabIndex = 34
        Me.lblFabricacionValor.Text = "00/00/0000"
        '
        'lblCodigoValor
        '
        Me.lblCodigoValor.AutoSize = True
        Me.lblCodigoValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblCodigoValor.ForeColor = System.Drawing.SystemColors.Control
        Me.lblCodigoValor.Location = New System.Drawing.Point(44, 237)
        Me.lblCodigoValor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodigoValor.Name = "lblCodigoValor"
        Me.lblCodigoValor.Size = New System.Drawing.Size(131, 39)
        Me.lblCodigoValor.TabIndex = 33
        Me.lblCodigoValor.Text = "000000"
        '
        'lblNombreValor
        '
        Me.lblNombreValor.AutoSize = True
        Me.lblNombreValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblNombreValor.ForeColor = System.Drawing.SystemColors.Control
        Me.lblNombreValor.Location = New System.Drawing.Point(44, 28)
        Me.lblNombreValor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombreValor.Name = "lblNombreValor"
        Me.lblNombreValor.Size = New System.Drawing.Size(142, 39)
        Me.lblNombreValor.TabIndex = 31
        Me.lblNombreValor.Text = "Xxxxxxx"
        '
        'pcbArticulo
        '
        Me.pcbArticulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pcbArticulo.Image = Global.Vista.My.Resources.Resources.iconfinder_43_Duck_River_Canada_4783009
        Me.pcbArticulo.Location = New System.Drawing.Point(51, 70)
        Me.pcbArticulo.MaximumSize = New System.Drawing.Size(1107, 400)
        Me.pcbArticulo.Name = "pcbArticulo"
        Me.pcbArticulo.Size = New System.Drawing.Size(213, 164)
        Me.pcbArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbArticulo.TabIndex = 32
        Me.pcbArticulo.TabStop = False
        '
        'articuloListaCarro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Controls.Add(Me.lblNombreValor)
        Me.Controls.Add(Me.btnQuitarDelCarro)
        Me.Controls.Add(Me.lblPrecioValor)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblFabricacion)
        Me.Controls.Add(Me.lblFabricacionValor)
        Me.Controls.Add(Me.lblCodigoValor)
        Me.Controls.Add(Me.pcbArticulo)
        Me.Name = "articuloListaCarro"
        Me.Size = New System.Drawing.Size(1121, 281)
        CType(Me.pcbArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnQuitarDelCarro As Button
    Friend WithEvents lblPrecioValor As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblFabricacion As Label
    Friend WithEvents lblFabricacionValor As Label
    Friend WithEvents lblCodigoValor As Label
    Friend WithEvents pcbArticulo As PictureBox
    Friend WithEvents lblNombreValor As Label
End Class
