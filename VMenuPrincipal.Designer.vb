<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VMenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VMenuPrincipal))
        Me.lblPrincipal = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnPersona = New System.Windows.Forms.Button()
        Me.btnArticulos = New System.Windows.Forms.Button()
        Me.brnPersonal = New System.Windows.Forms.Button()
        Me.btnEmpleos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPrincipal
        '
        Me.lblPrincipal.AutoSize = True
        Me.lblPrincipal.Font = New System.Drawing.Font("Tahoma", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrincipal.Location = New System.Drawing.Point(275, 60)
        Me.lblPrincipal.Name = "lblPrincipal"
        Me.lblPrincipal.Size = New System.Drawing.Size(293, 51)
        Me.lblPrincipal.TabIndex = 0
        Me.lblPrincipal.Text = "Administración"
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(474, 547)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(346, 169)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnPersona
        '
        Me.btnPersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPersona.Image = Global.Vista.My.Resources.Resources.icons8_head_profile_64
        Me.btnPersona.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPersona.Location = New System.Drawing.Point(105, 187)
        Me.btnPersona.Name = "btnPersona"
        Me.btnPersona.Size = New System.Drawing.Size(346, 169)
        Me.btnPersona.TabIndex = 1
        Me.btnPersona.Text = "Personal"
        Me.btnPersona.UseVisualStyleBackColor = True
        '
        'btnArticulos
        '
        Me.btnArticulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnArticulos.Image = Global.Vista.My.Resources.Resources.icons8_box_64
        Me.btnArticulos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnArticulos.Location = New System.Drawing.Point(474, 152)
        Me.btnArticulos.Name = "btnArticulos"
        Me.btnArticulos.Size = New System.Drawing.Size(346, 169)
        Me.btnArticulos.TabIndex = 2
        Me.btnArticulos.Text = "Articulos"
        Me.btnArticulos.UseVisualStyleBackColor = True
        '
        'brnPersonal
        '
        Me.brnPersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.brnPersonal.Image = Global.Vista.My.Resources.Resources.icons8_name_tag_64
        Me.brnPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.brnPersonal.Location = New System.Drawing.Point(105, 387)
        Me.brnPersonal.Name = "brnPersonal"
        Me.brnPersonal.Size = New System.Drawing.Size(346, 169)
        Me.brnPersonal.TabIndex = 3
        Me.brnPersonal.Text = "Empleados"
        Me.brnPersonal.UseVisualStyleBackColor = True
        '
        'btnEmpleos
        '
        Me.btnEmpleos.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnEmpleos.Image = Global.Vista.My.Resources.Resources.icons8_paint_roller_64
        Me.btnEmpleos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmpleos.Location = New System.Drawing.Point(474, 352)
        Me.btnEmpleos.Name = "btnEmpleos"
        Me.btnEmpleos.Size = New System.Drawing.Size(346, 169)
        Me.btnEmpleos.TabIndex = 4
        Me.btnEmpleos.Text = "Empleos"
        Me.btnEmpleos.UseVisualStyleBackColor = True
        '
        'VMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 757)
        Me.Controls.Add(Me.lblPrincipal)
        Me.Controls.Add(Me.btnPersona)
        Me.Controls.Add(Me.btnArticulos)
        Me.Controls.Add(Me.brnPersonal)
        Me.Controls.Add(Me.btnEmpleos)
        Me.Controls.Add(Me.btnSalir)
        Me.Name = "VMenuPrincipal"
        Me.Text = "VMenuPrincipal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrincipal As Label
    Friend WithEvents btnPersona As Button
    Friend WithEvents brnPersonal As Button
    Friend WithEvents btnEmpleos As Button
    Friend WithEvents btnArticulos As Button
    Friend WithEvents btnSalir As Button
End Class
