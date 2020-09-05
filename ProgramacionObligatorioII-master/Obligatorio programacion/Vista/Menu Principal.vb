Public Class Menu_Principal

    Private drag As Boolean
    Private mouseX, mouseY As Integer

    Public Sub esconder()

        If pnlArt.Visible = True Then
            pnlArt.Visible = False
        ElseIf pnlEmp.Visible = True Then
            pnlEmp.Visible = False
        End If

    End Sub

    Public Sub mostrar(pnl As Panel)

        If pnl.Visible = False Then
            pnl.Visible = True
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
        If pnlEmp.Visible = True Then
            esconder()
        Else
            mostrar(pnlEmp)
        End If
    End Sub

    Private Sub btnArt_Click(sender As Object, e As EventArgs) Handles btnArt.Click
        If pnlArt.Visible = True Then
            esconder()
        Else
            mostrar(pnlArt)
        End If
    End Sub

    Private Sub btnAddArt_Click(sender As Object, e As EventArgs) Handles btnAddArt.Click
        frmChange(New frmAgregarArticulo)
    End Sub

    Private Sub frmChange(form As Form)

        Me.MdiChildren(0).Close()
        form.MdiParent = Me
        form.BringToFront()
        form.Dock = DockStyle.Fill
        form.Show()

    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        frmChange(frmAgregar.Singleton)

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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frmChange(frmListados)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub

    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        frmChange(frmBienvenida)
    End Sub

    Private Sub Menu_Principal_Load(sender As Object, e As EventArgs) Handles Me.Load
        frmBienvenida.MdiParent = Me
        frmBienvenida.Dock = DockStyle.Fill
        frmBienvenida.Show()
    End Sub
End Class
