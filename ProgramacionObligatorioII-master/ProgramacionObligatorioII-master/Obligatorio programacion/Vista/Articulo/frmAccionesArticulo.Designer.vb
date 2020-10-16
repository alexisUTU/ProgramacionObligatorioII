<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAccionesArticulo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblFechaFabricacion = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAgregarArt = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.MaskedTextBox()
        Me.txtPrecio = New System.Windows.Forms.MaskedTextBox()
        Me.pcbArticulo = New System.Windows.Forms.PictureBox()
        Me.btnSelecImagen = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        CType(Me.pcbArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFechaFabricacion
        '
        Me.lblFechaFabricacion.AutoSize = True
        Me.lblFechaFabricacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaFabricacion.Location = New System.Drawing.Point(228, 407)
        Me.lblFechaFabricacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaFabricacion.Name = "lblFechaFabricacion"
        Me.lblFechaFabricacion.Size = New System.Drawing.Size(266, 31)
        Me.lblFechaFabricacion.TabIndex = 14
        Me.lblFechaFabricacion.Text = "Fecha de fabricación"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.Location = New System.Drawing.Point(29, 407)
        Me.lblPrecio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(91, 31)
        Me.lblPrecio.TabIndex = 12
        Me.lblPrecio.Text = "Precio"
        '
        'txtDesc
        '
        Me.txtDesc.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(509, 251)
        Me.txtDesc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(632, 232)
        Me.txtDesc.TabIndex = 2
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(503, 216)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(157, 31)
        Me.lblDescripcion.TabIndex = 10
        Me.lblDescripcion.Text = "Descripción"
        '
        'txtCod
        '
        Me.txtCod.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCod.Location = New System.Drawing.Point(826, 162)
        Me.txtCod.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(315, 30)
        Me.txtCod.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(820, 126)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 31)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Código"
        '
        'btnAgregarArt
        '
        Me.btnAgregarArt.BackColor = System.Drawing.Color.Gainsboro
        Me.btnAgregarArt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarArt.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAgregarArt.FlatAppearance.BorderSize = 0
        Me.btnAgregarArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarArt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.btnAgregarArt.Location = New System.Drawing.Point(35, 508)
        Me.btnAgregarArt.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregarArt.Name = "btnAgregarArt"
        Me.btnAgregarArt.Size = New System.Drawing.Size(473, 104)
        Me.btnAgregarArt.TabIndex = 6
        Me.btnAgregarArt.Text = "Modificar"
        Me.btnAgregarArt.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(501, 52)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(298, 46)
        Me.lblTitulo.TabIndex = 17
        Me.lblTitulo.Text = "Ingrese un artículo"
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.Color.Gainsboro
        Me.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFecha.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.txtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(234, 453)
        Me.txtFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFecha.Mask = "00/00/0000"
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(176, 30)
        Me.txtFecha.TabIndex = 5
        Me.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtFecha.ValidatingType = GetType(Date)
        '
        'txtPrecio
        '
        Me.txtPrecio.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.Location = New System.Drawing.Point(35, 446)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrecio.Mask = "999,99"
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(141, 42)
        Me.txtPrecio.TabIndex = 4
        Me.txtPrecio.ValidatingType = GetType(Integer)
        '
        'pcbArticulo
        '
        Me.pcbArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbArticulo.Image = Global.Vista.My.Resources.Resources.iconfinder_43_Duck_River_Canada_4783009
        Me.pcbArticulo.Location = New System.Drawing.Point(35, 52)
        Me.pcbArticulo.Margin = New System.Windows.Forms.Padding(4)
        Me.pcbArticulo.Name = "pcbArticulo"
        Me.pcbArticulo.Size = New System.Drawing.Size(375, 283)
        Me.pcbArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbArticulo.TabIndex = 22
        Me.pcbArticulo.TabStop = False
        '
        'btnSelecImagen
        '
        Me.btnSelecImagen.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSelecImagen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelecImagen.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSelecImagen.FlatAppearance.BorderSize = 0
        Me.btnSelecImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelecImagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.btnSelecImagen.Location = New System.Drawing.Point(35, 331)
        Me.btnSelecImagen.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSelecImagen.Name = "btnSelecImagen"
        Me.btnSelecImagen.Size = New System.Drawing.Size(375, 63)
        Me.btnSelecImagen.TabIndex = 3
        Me.btnSelecImagen.Text = "Seleccionar imagen"
        Me.btnSelecImagen.UseVisualStyleBackColor = False
        '
        'btnQuitar
        '
        Me.btnQuitar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnQuitar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuitar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnQuitar.FlatAppearance.BorderSize = 0
        Me.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.btnQuitar.Location = New System.Drawing.Point(516, 508)
        Me.btnQuitar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(625, 104)
        Me.btnQuitar.TabIndex = 23
        Me.btnQuitar.Text = "Quitar"
        Me.btnQuitar.UseVisualStyleBackColor = False
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(509, 162)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(315, 30)
        Me.txtNombre.TabIndex = 24
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(503, 126)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(110, 31)
        Me.lblNombre.TabIndex = 25
        Me.lblNombre.Text = "Nombre"
        '
        'frmAccionesArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1188, 640)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.btnSelecImagen)
        Me.Controls.Add(Me.pcbArticulo)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnAgregarArt)
        Me.Controls.Add(Me.lblFechaFabricacion)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.txtCod)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAccionesArticulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmModificarArticulo"
        CType(Me.pcbArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFechaFabricacion As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents txtCod As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAgregarArt As Button
    Friend WithEvents lblTitulo As Label
    Friend WithEvents txtFecha As MaskedTextBox
    Friend WithEvents txtPrecio As MaskedTextBox
    Friend WithEvents pcbArticulo As PictureBox
    Friend WithEvents btnSelecImagen As Button
    Friend WithEvents btnQuitar As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
End Class
