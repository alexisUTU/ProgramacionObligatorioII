Public Class VMenuPrincipal
    Private Sub btnArticulos_Click(sender As Object, e As EventArgs) Handles btnArticulos.Click
        Me.Hide()
    End Sub

    Private Sub brnPersonal_Click(sender As Object, e As EventArgs) Handles brnPersonal.Click
        Me.Hide()
    End Sub

    Private Sub btnEmpleos_Click(sender As Object, e As EventArgs) Handles btnEmpleos.Click
        Me.Hide()
        VMenuEmpleados.Show()
    End Sub

    Private Sub btnPersona_Click(sender As Object, e As EventArgs) Handles btnPersona.Click
        Me.Hide()
    End Sub
End Class