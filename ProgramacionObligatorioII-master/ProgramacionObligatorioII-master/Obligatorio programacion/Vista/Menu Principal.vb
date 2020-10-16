Public Class Menu_Principal

    Private drag As Boolean
    Private mouseX, mouseY As Integer

    Public Sub recargar(btn As Button)
        pnlArt.Visible = False
        pnlEmp.Visible = False
        pnlTienda.Visible = False
        If btnArt.GetHashCode = btn.GetHashCode Then
            pnlArt.Visible = True
        ElseIf btnEmp.GetHashCode = btn.GetHashCode Then
            pnlEmp.Visible = True
        ElseIf btnTiendaM.GetHashCode = btn.GetHashCode Then
            pnlTienda.Visible = True
        End If
    End Sub


    ' SALIO MAL xdxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx 
    ' poner visible=true en el evento del boton si se crea otro form

    'Dim activo As Form = Nothing
    Public Sub mostrarForm(formhijo As Form)

        '    formhijo.TopLevel = False
        '    formhijo.FormBorderStyle = BorderStyle.None
        '    formhijo.Dock = DockStyle.Fill
        '    pnlWrap.Controls.Add(activo)
        '    pnlWrap.Tag = formhijo
        '    formhijo.BringToFront()

        '    formhijo.Visible = True
        'If activo IsNot Nothing Then
        'activo.Close()
        'activo = formhijo

        'End If

    End Sub

    Private Sub btnEmp_Click_1(sender As Object, e As EventArgs) Handles btnEmp.Click
        recargar(btnEmp)
    End Sub

    Private Sub btnArt_Click(sender As Object, e As EventArgs) Handles btnArt.Click
        recargar(btnArt)
    End Sub

    Public Sub btnAddArt_Click(sender As Object, e As EventArgs) Handles btnAddArt.Click
        frmChange(New frmAgregarArticulo)
    End Sub

    Public Sub frmChange(form As Form)
        Me.MdiChildren(0).Close()

        form.MdiParent = Me
        form.BringToFront()
        form.Dock = DockStyle.Fill
        form.Activate()
        form.Show()


    End Sub
    Private Sub btnAddEmp_Click(sender As Object, e As EventArgs) Handles btnAddEmp.Click
        frmChange(frmAgregarEmpleado.Singleton)
    End Sub

    Private Sub pnlTopBar_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlTopBar.MouseDown
        Me.drag = True
        Me.mouseX = Cursor.Position.X - Me.Left
        Me.mouseY = Cursor.Position.Y - Me.Top

    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub pnlTopBar_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlTopBar.MouseUp
        Me.drag = False
    End Sub

    Private Sub pnlTopBar_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlTopBar.MouseMove

        If Me.drag Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub btnListArt_Click(sender As Object, e As EventArgs) Handles btnListArt.Click
        frmChange(New frmListadoArticulo)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub

    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        frmChange(New frmBienvenida)
    End Sub

    Private Sub btnListEmp_Click(sender As Object, e As EventArgs) Handles btnListEmp.Click
        frmChange(New frmListadoEmpleado)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        frmChange(New frmBuscador)
    End Sub

    Private Sub btnTiendaM_Click(sender As Object, e As EventArgs) Handles btnTiendaM.Click
        recargar(btnTiendaM)
    End Sub

    Private Sub btnCarro_Click(sender As Object, e As EventArgs) Handles btnCarro.Click
        frmChange(New frmListaCarro)
    End Sub

    Private Sub Menu_Principal_Load(sender As Object, e As EventArgs) Handles Me.Load
        frmBienvenida.MdiParent = Me
        frmBienvenida.Dock = DockStyle.Fill
        frmBienvenida.Show()
    End Sub
End Class
