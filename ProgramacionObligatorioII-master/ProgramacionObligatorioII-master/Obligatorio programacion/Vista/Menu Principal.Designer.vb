<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.pnlTienda = New System.Windows.Forms.Panel()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnPublicar = New System.Windows.Forms.Button()
        Me.btnTiendaM = New FontAwesome.Sharp.IconButton()
        Me.pnlEmp = New System.Windows.Forms.Panel()
        Me.btnListEmp = New System.Windows.Forms.Button()
        Me.btnAddEmp = New System.Windows.Forms.Button()
        Me.btnEmp = New FontAwesome.Sharp.IconButton()
        Me.pnlArt = New System.Windows.Forms.Panel()
        Me.btnListArt = New System.Windows.Forms.Button()
        Me.btnAddArt = New System.Windows.Forms.Button()
        Me.btnArt = New FontAwesome.Sharp.IconButton()
        Me.btnMain = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pnlTopBar = New System.Windows.Forms.Panel()
        Me.btnMinimizar = New FontAwesome.Sharp.IconButton()
        Me.btnCerrar = New FontAwesome.Sharp.IconButton()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlTienda.SuspendLayout()
        Me.pnlEmp.SuspendLayout()
        Me.pnlArt.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlTopBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.AutoScroll = True
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.btnCerrarSesion)
        Me.pnlSidebar.Controls.Add(Me.pnlTienda)
        Me.pnlSidebar.Controls.Add(Me.btnTiendaM)
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
        Me.pnlSidebar.Size = New System.Drawing.Size(245, 696)
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
        Me.btnCerrarSesion.Location = New System.Drawing.Point(0, 730)
        Me.btnCerrarSesion.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Padding = New System.Windows.Forms.Padding(13, 0, 27, 0)
        Me.btnCerrarSesion.Rotation = 0R
        Me.btnCerrarSesion.Size = New System.Drawing.Size(224, 70)
        Me.btnCerrarSesion.TabIndex = 16
        Me.btnCerrarSesion.Text = "Cerrar Sesión"
        Me.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCerrarSesion.UseVisualStyleBackColor = False
        '
        'pnlTienda
        '
        Me.pnlTienda.Controls.Add(Me.btnBuscar)
        Me.pnlTienda.Controls.Add(Me.btnPublicar)
        Me.pnlTienda.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTienda.Location = New System.Drawing.Point(0, 614)
        Me.pnlTienda.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlTienda.Name = "pnlTienda"
        Me.pnlTienda.Size = New System.Drawing.Size(224, 116)
        Me.pnlTienda.TabIndex = 20
        Me.pnlTienda.Visible = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(0, 57)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Padding = New System.Windows.Forms.Padding(27, 0, 0, 0)
        Me.btnBuscar.Size = New System.Drawing.Size(224, 57)
        Me.btnBuscar.TabIndex = 10
        Me.btnBuscar.Text = "Buscar articulo"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnPublicar
        '
        Me.btnPublicar.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnPublicar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPublicar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPublicar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnPublicar.FlatAppearance.BorderSize = 0
        Me.btnPublicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPublicar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPublicar.ForeColor = System.Drawing.Color.White
        Me.btnPublicar.Location = New System.Drawing.Point(0, 0)
        Me.btnPublicar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPublicar.Name = "btnPublicar"
        Me.btnPublicar.Padding = New System.Windows.Forms.Padding(27, 0, 0, 0)
        Me.btnPublicar.Size = New System.Drawing.Size(224, 57)
        Me.btnPublicar.TabIndex = 9
        Me.btnPublicar.Text = "Publicar articulo"
        Me.btnPublicar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPublicar.UseVisualStyleBackColor = False
        '
        'btnTiendaM
        '
        Me.btnTiendaM.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnTiendaM.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTiendaM.FlatAppearance.BorderSize = 0
        Me.btnTiendaM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTiendaM.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnTiendaM.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTiendaM.ForeColor = System.Drawing.Color.White
        Me.btnTiendaM.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.btnTiendaM.IconColor = System.Drawing.Color.White
        Me.btnTiendaM.IconSize = 32
        Me.btnTiendaM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTiendaM.Location = New System.Drawing.Point(0, 544)
        Me.btnTiendaM.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTiendaM.Name = "btnTiendaM"
        Me.btnTiendaM.Padding = New System.Windows.Forms.Padding(13, 0, 27, 0)
        Me.btnTiendaM.Rotation = 0R
        Me.btnTiendaM.Size = New System.Drawing.Size(224, 70)
        Me.btnTiendaM.TabIndex = 19
        Me.btnTiendaM.Text = "Tienda"
        Me.btnTiendaM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTiendaM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTiendaM.UseVisualStyleBackColor = False
        '
        'pnlEmp
        '
        Me.pnlEmp.Controls.Add(Me.btnListEmp)
        Me.pnlEmp.Controls.Add(Me.btnAddEmp)
        Me.pnlEmp.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlEmp.Location = New System.Drawing.Point(0, 428)
        Me.pnlEmp.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlEmp.Name = "pnlEmp"
        Me.pnlEmp.Size = New System.Drawing.Size(224, 116)
        Me.pnlEmp.TabIndex = 15
        Me.pnlEmp.Visible = False
        '
        'btnListEmp
        '
        Me.btnListEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnListEmp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListEmp.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnListEmp.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnListEmp.FlatAppearance.BorderSize = 0
        Me.btnListEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListEmp.ForeColor = System.Drawing.Color.White
        Me.btnListEmp.Location = New System.Drawing.Point(0, 57)
        Me.btnListEmp.Margin = New System.Windows.Forms.Padding(4)
        Me.btnListEmp.Name = "btnListEmp"
        Me.btnListEmp.Padding = New System.Windows.Forms.Padding(27, 0, 0, 0)
        Me.btnListEmp.Size = New System.Drawing.Size(224, 57)
        Me.btnListEmp.TabIndex = 10
        Me.btnListEmp.Text = "Listar empleados"
        Me.btnListEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListEmp.UseVisualStyleBackColor = False
        '
        'btnAddEmp
        '
        Me.btnAddEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnAddEmp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddEmp.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAddEmp.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnAddEmp.FlatAppearance.BorderSize = 0
        Me.btnAddEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEmp.ForeColor = System.Drawing.Color.White
        Me.btnAddEmp.Location = New System.Drawing.Point(0, 0)
        Me.btnAddEmp.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddEmp.Name = "btnAddEmp"
        Me.btnAddEmp.Padding = New System.Windows.Forms.Padding(27, 0, 0, 0)
        Me.btnAddEmp.Size = New System.Drawing.Size(224, 57)
        Me.btnAddEmp.TabIndex = 9
        Me.btnAddEmp.Text = "Agregar empleado"
        Me.btnAddEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddEmp.UseVisualStyleBackColor = False
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
        Me.btnEmp.Location = New System.Drawing.Point(0, 358)
        Me.btnEmp.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEmp.Name = "btnEmp"
        Me.btnEmp.Padding = New System.Windows.Forms.Padding(13, 0, 27, 0)
        Me.btnEmp.Rotation = 0R
        Me.btnEmp.Size = New System.Drawing.Size(224, 70)
        Me.btnEmp.TabIndex = 18
        Me.btnEmp.Text = "Empleados"
        Me.btnEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEmp.UseVisualStyleBackColor = False
        '
        'pnlArt
        '
        Me.pnlArt.Controls.Add(Me.btnListArt)
        Me.pnlArt.Controls.Add(Me.btnAddArt)
        Me.pnlArt.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlArt.Location = New System.Drawing.Point(0, 246)
        Me.pnlArt.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlArt.Name = "pnlArt"
        Me.pnlArt.Size = New System.Drawing.Size(224, 112)
        Me.pnlArt.TabIndex = 14
        Me.pnlArt.Visible = False
        '
        'btnListArt
        '
        Me.btnListArt.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnListArt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListArt.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnListArt.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnListArt.FlatAppearance.BorderSize = 0
        Me.btnListArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListArt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListArt.ForeColor = System.Drawing.Color.White
        Me.btnListArt.Location = New System.Drawing.Point(0, 57)
        Me.btnListArt.Margin = New System.Windows.Forms.Padding(4)
        Me.btnListArt.Name = "btnListArt"
        Me.btnListArt.Padding = New System.Windows.Forms.Padding(27, 0, 0, 0)
        Me.btnListArt.Size = New System.Drawing.Size(224, 57)
        Me.btnListArt.TabIndex = 10
        Me.btnListArt.Text = "Listar artículos"
        Me.btnListArt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListArt.UseVisualStyleBackColor = False
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
        Me.btnAddArt.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddArt.Name = "btnAddArt"
        Me.btnAddArt.Padding = New System.Windows.Forms.Padding(27, 0, 0, 0)
        Me.btnAddArt.Size = New System.Drawing.Size(224, 57)
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
        Me.btnArt.Location = New System.Drawing.Point(0, 176)
        Me.btnArt.Margin = New System.Windows.Forms.Padding(4)
        Me.btnArt.Name = "btnArt"
        Me.btnArt.Padding = New System.Windows.Forms.Padding(13, 0, 27, 0)
        Me.btnArt.Rotation = 0R
        Me.btnArt.Size = New System.Drawing.Size(224, 70)
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
        Me.btnMain.Location = New System.Drawing.Point(0, 106)
        Me.btnMain.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Padding = New System.Windows.Forms.Padding(13, 0, 27, 0)
        Me.btnMain.Rotation = 0R
        Me.btnMain.Size = New System.Drawing.Size(224, 70)
        Me.btnMain.TabIndex = 17
        Me.btnMain.Text = "Menu Principal"
        Me.btnMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMain.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(224, 106)
        Me.Panel1.TabIndex = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(37, 31)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(172, 49)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Sistema de control de stock"
        '
        'pnlTopBar
        '
        Me.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.pnlTopBar.Controls.Add(Me.btnMinimizar)
        Me.pnlTopBar.Controls.Add(Me.btnCerrar)
        Me.pnlTopBar.Location = New System.Drawing.Point(245, 0)
        Me.pnlTopBar.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlTopBar.Name = "pnlTopBar"
        Me.pnlTopBar.Size = New System.Drawing.Size(1189, 43)
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
        Me.btnMinimizar.Location = New System.Drawing.Point(1085, 4)
        Me.btnMinimizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Rotation = 0R
        Me.btnMinimizar.Size = New System.Drawing.Size(48, 39)
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
        Me.btnCerrar.Location = New System.Drawing.Point(1136, 4)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Rotation = 0R
        Me.btnCerrar.Size = New System.Drawing.Size(48, 39)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Menu_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1433, 696)
        Me.Controls.Add(Me.pnlTopBar)
        Me.Controls.Add(Me.pnlSidebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Menu_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu_Principal"
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlTienda.ResumeLayout(False)
        Me.pnlEmp.ResumeLayout(False)
        Me.pnlArt.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.pnlTopBar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlEmp As Panel
    Friend WithEvents btnListEmp As Button
    Friend WithEvents btnAddEmp As Button
    Friend WithEvents pnlArt As Panel
    Friend WithEvents btnListArt As Button
    Friend WithEvents btnAddArt As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlTopBar As Panel
    Friend WithEvents btnArt As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCerrarSesion As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMain As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEmp As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCerrar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMinimizar As FontAwesome.Sharp.IconButton
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnTiendaM As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlTienda As Panel
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnPublicar As Button
End Class
