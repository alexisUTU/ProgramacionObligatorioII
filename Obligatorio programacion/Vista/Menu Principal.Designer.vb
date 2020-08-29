<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.btnArt = New System.Windows.Forms.Button()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.pnlEmp = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.btnEmp = New System.Windows.Forms.Button()
        Me.pnlArt = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlWrap = New System.Windows.Forms.Panel()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlEmp.SuspendLayout()
        Me.pnlArt.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnArt
        '
        Me.btnArt.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnArt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnArt.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnArt.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnArt.FlatAppearance.BorderSize = 0
        Me.btnArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArt.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArt.ForeColor = System.Drawing.Color.White
        Me.btnArt.Location = New System.Drawing.Point(0, 143)
        Me.btnArt.Name = "btnArt"
        Me.btnArt.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnArt.Size = New System.Drawing.Size(184, 57)
        Me.btnArt.TabIndex = 10
        Me.btnArt.Text = "Articulos"
        Me.btnArt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnArt.UseVisualStyleBackColor = False
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.pnlEmp)
        Me.pnlSidebar.Controls.Add(Me.btnEmp)
        Me.pnlSidebar.Controls.Add(Me.pnlArt)
        Me.pnlSidebar.Controls.Add(Me.btnArt)
        Me.pnlSidebar.Controls.Add(Me.Button1)
        Me.pnlSidebar.Controls.Add(Me.Panel1)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(184, 450)
        Me.pnlSidebar.TabIndex = 12
        '
        'pnlEmp
        '
        Me.pnlEmp.Controls.Add(Me.Button3)
        Me.pnlEmp.Controls.Add(Me.Button6)
        Me.pnlEmp.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlEmp.Location = New System.Drawing.Point(0, 348)
        Me.pnlEmp.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlEmp.Name = "pnlEmp"
        Me.pnlEmp.Size = New System.Drawing.Size(184, 94)
        Me.pnlEmp.TabIndex = 15
        Me.pnlEmp.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(0, 46)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Button3.Size = New System.Drawing.Size(184, 46)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Listar empleados"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(0, 0)
        Me.Button6.Name = "Button6"
        Me.Button6.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Button6.Size = New System.Drawing.Size(184, 46)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "Agregar empleado"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.UseVisualStyleBackColor = False
        '
        'btnEmp
        '
        Me.btnEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnEmp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmp.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEmp.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnEmp.FlatAppearance.BorderSize = 0
        Me.btnEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmp.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmp.ForeColor = System.Drawing.Color.White
        Me.btnEmp.Location = New System.Drawing.Point(0, 291)
        Me.btnEmp.Name = "btnEmp"
        Me.btnEmp.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnEmp.Size = New System.Drawing.Size(184, 57)
        Me.btnEmp.TabIndex = 15
        Me.btnEmp.Text = "Empleados"
        Me.btnEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmp.UseVisualStyleBackColor = False
        '
        'pnlArt
        '
        Me.pnlArt.Controls.Add(Me.Button4)
        Me.pnlArt.Controls.Add(Me.Button5)
        Me.pnlArt.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlArt.Location = New System.Drawing.Point(0, 200)
        Me.pnlArt.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlArt.Name = "pnlArt"
        Me.pnlArt.Size = New System.Drawing.Size(184, 91)
        Me.pnlArt.TabIndex = 14
        Me.pnlArt.Visible = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(0, 46)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Button4.Size = New System.Drawing.Size(184, 46)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Listar artículos"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(0, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Button5.Size = New System.Drawing.Size(184, 46)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Agregar artículo"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(0, 86)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(184, 57)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Menu Principal"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(184, 86)
        Me.Panel1.TabIndex = 0
        '
        'pnlWrap
        '
        Me.pnlWrap.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlWrap.Location = New System.Drawing.Point(184, 0)
        Me.pnlWrap.Name = "pnlWrap"
        Me.pnlWrap.Size = New System.Drawing.Size(616, 450)
        Me.pnlWrap.TabIndex = 13
        '
        'Menu_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pnlWrap)
        Me.Controls.Add(Me.pnlSidebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Menu_Principal"
        Me.Text = "Menu_Principal"
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlEmp.ResumeLayout(False)
        Me.pnlArt.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnArt As Button
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlEmp As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents btnEmp As Button
    Friend WithEvents pnlArt As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents pnlWrap As Panel
End Class
