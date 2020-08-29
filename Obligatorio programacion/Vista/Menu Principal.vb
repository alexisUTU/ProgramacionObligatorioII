Public Class Menu_Principal
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



    Private Sub BbtnArt_Click(sender As Object, e As EventArgs) Handles btnArt.Click
        esconder()
        mostrar(pnlArt)
    End Sub

    Private Sub btnEmp_Click(sender As Object, e As EventArgs) Handles btnEmp.Click
        esconder()
        mostrar(pnlEmp)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'mostrarForm(New Login())
    End Sub
End Class