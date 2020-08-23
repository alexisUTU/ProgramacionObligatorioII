Imports Controlador

Public Class VMenuPrincipal
    Private Sub btnArticulos_Click(sender As Object, e As EventArgs) Handles btnArticulos.Click
        VMenuArticulos.Show()
        Me.Hide()
    End Sub
    Private Sub btnEmpleos_Click(sender As Object, e As EventArgs) Handles btnEmpleos.Click
        VMenuEmpleos.Show()
        Me.Hide()
    End Sub

    Private Sub btnPersona_Click(sender As Object, e As EventArgs) Handles btnPersona.Click
        VMenuPersonal.Show()
        Me.Hide()
    End Sub

    Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
    End Sub
End Class