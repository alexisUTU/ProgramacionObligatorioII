﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu_Principal
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
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.btnCerrarSesion = New FontAwesome.Sharp.IconButton()
        Me.pnlEmp = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.btnEmp = New FontAwesome.Sharp.IconButton()
        Me.pnlArt = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnAddArt = New System.Windows.Forms.Button()
        Me.btnArt = New FontAwesome.Sharp.IconButton()
        Me.btnMain = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlTopBar = New System.Windows.Forms.Panel()
        Me.btnMinimizar = New FontAwesome.Sharp.IconButton()
        Me.btnCerrar = New FontAwesome.Sharp.IconButton()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlEmp.SuspendLayout()
        Me.pnlArt.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlTopBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.btnCerrarSesion)
        Me.pnlSidebar.Controls.Add(Me.pnlEmp)
        Me.pnlSidebar.Controls.Add(Me.btnEmp)
        Me.pnlSidebar.Controls.Add(Me.pnlArt)
        Me.pnlSidebar.Controls.Add(Me.btnArt)
        Me.pnlSidebar.Controls.Add(Me.btnMain)
        Me.pnlSidebar.Controls.Add(Me.Panel1)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(184, 525)
        Me.pnlSidebar.TabIndex = 12
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCerrarSesion.FlatAppearance.BorderSize = 0
        Me.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarSesion.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnCerrarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarSesion.ForeColor = System.Drawing.Color.White
        Me.btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.btnCerrarSesion.IconColor = System.Drawing.Color.White
        Me.btnCerrarSesion.IconSize = 32
        Me.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrarSesion.Location = New System.Drawing.Point(0, 442)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnCerrarSesion.Rotation = 0R
        Me.btnCerrarSesion.Size = New System.Drawing.Size(184, 57)
        Me.btnCerrarSesion.TabIndex = 16
        Me.btnCerrarSesion.Text = "Cerrar Sesión"
        Me.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCerrarSesion.UseVisualStyleBackColor = False
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
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnEmp.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEmp.FlatAppearance.BorderSize = 0
        Me.btnEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmp.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmp.ForeColor = System.Drawing.Color.White
        Me.btnEmp.IconChar = FontAwesome.Sharp.IconChar.UserFriends
        Me.btnEmp.IconColor = System.Drawing.Color.White
        Me.btnEmp.IconSize = 32
        Me.btnEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmp.Location = New System.Drawing.Point(0, 291)
        Me.btnEmp.Name = "btnEmp"
        Me.btnEmp.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnEmp.Rotation = 0R
        Me.btnEmp.Size = New System.Drawing.Size(184, 57)
        Me.btnEmp.TabIndex = 18
        Me.btnEmp.Text = "Empleados"
        Me.btnEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEmp.UseVisualStyleBackColor = False
        '
        'pnlArt
        '
        Me.pnlArt.Controls.Add(Me.Button4)
        Me.pnlArt.Controls.Add(Me.btnAddArt)
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
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        'btnAddArt
        '
        Me.btnAddArt.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnAddArt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddArt.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAddArt.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnAddArt.FlatAppearance.BorderSize = 0
        Me.btnAddArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddArt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddArt.ForeColor = System.Drawing.Color.White
        Me.btnAddArt.Location = New System.Drawing.Point(0, 0)
        Me.btnAddArt.Name = "btnAddArt"
        Me.btnAddArt.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnAddArt.Size = New System.Drawing.Size(184, 46)
        Me.btnAddArt.TabIndex = 9
        Me.btnAddArt.Text = "Agregar artículo"
        Me.btnAddArt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddArt.UseVisualStyleBackColor = False
        '
        'btnArt
        '
        Me.btnArt.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnArt.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnArt.FlatAppearance.BorderSize = 0
        Me.btnArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArt.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnArt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArt.ForeColor = System.Drawing.Color.White
        Me.btnArt.IconChar = FontAwesome.Sharp.IconChar.BoxOpen
        Me.btnArt.IconColor = System.Drawing.Color.White
        Me.btnArt.IconSize = 32
        Me.btnArt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnArt.Location = New System.Drawing.Point(0, 143)
        Me.btnArt.Name = "btnArt"
        Me.btnArt.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnArt.Rotation = 0R
        Me.btnArt.Size = New System.Drawing.Size(184, 57)
        Me.btnArt.TabIndex = 15
        Me.btnArt.Text = "Artículos"
        Me.btnArt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnArt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnArt.UseVisualStyleBackColor = False
        '
        'btnMain
        '
        Me.btnMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMain.FlatAppearance.BorderSize = 0
        Me.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMain.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMain.ForeColor = System.Drawing.Color.White
        Me.btnMain.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.btnMain.IconColor = System.Drawing.Color.White
        Me.btnMain.IconSize = 32
        Me.btnMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMain.Location = New System.Drawing.Point(0, 86)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnMain.Rotation = 0R
        Me.btnMain.Size = New System.Drawing.Size(184, 57)
        Me.btnMain.TabIndex = 17
        Me.btnMain.Text = "Menu Principal"
        Me.btnMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMain.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(184, 86)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(28, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sistema de control de stock"
        '
        'pnlTopBar
        '
        Me.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.pnlTopBar.Controls.Add(Me.btnMinimizar)
        Me.pnlTopBar.Controls.Add(Me.btnCerrar)
        Me.pnlTopBar.Location = New System.Drawing.Point(184, 0)
        Me.pnlTopBar.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlTopBar.Name = "pnlTopBar"
        Me.pnlTopBar.Size = New System.Drawing.Size(892, 35)
        Me.pnlTopBar.TabIndex = 14
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnMinimizar.ForeColor = System.Drawing.Color.Red
        Me.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.btnMinimizar.IconColor = System.Drawing.Color.White
        Me.btnMinimizar.IconSize = 16
        Me.btnMinimizar.Location = New System.Drawing.Point(814, 3)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Rotation = 0R
        Me.btnMinimizar.Size = New System.Drawing.Size(36, 32)
        Me.btnMinimizar.TabIndex = 1
        Me.btnMinimizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnCerrar.ForeColor = System.Drawing.Color.Red
        Me.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.btnCerrar.IconColor = System.Drawing.Color.Red
        Me.btnCerrar.IconSize = 16
        Me.btnCerrar.Location = New System.Drawing.Point(852, 3)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Rotation = 0R
        Me.btnCerrar.Size = New System.Drawing.Size(36, 32)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Menu_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1075, 525)
        Me.Controls.Add(Me.pnlTopBar)
        Me.Controls.Add(Me.pnlSidebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "Menu_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu_Principal"
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlEmp.ResumeLayout(False)
        Me.pnlArt.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.pnlTopBar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlEmp As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents pnlArt As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents btnAddArt As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlTopBar As Panel
    Friend WithEvents btnArt As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCerrarSesion As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMain As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEmp As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCerrar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMinimizar As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
End Class