Public Class Usuario


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Puesto.ShowDialog()
    End Sub

    Private Sub ButEmpl_Click(sender As Object, e As EventArgs) Handles ButEmpl.Click
        Empleados.ShowDialog()
    End Sub

    Private Sub ButDep_Click(sender As Object, e As EventArgs) Handles ButDep.Click
        Departamentos.ShowDialog()
    End Sub

    Private Sub ButPer_Click(sender As Object, e As EventArgs) Handles ButPer.Click
        Perp.ShowDialog()
    End Sub

    Private Sub ButInc_Click(sender As Object, e As EventArgs) Handles ButInc.Click
        Incidencias.ShowDialog()
    End Sub

    Private Sub Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEmpresas_Click(sender As Object, e As EventArgs) Handles btnEmpresas.Click
        Empresas.ShowDialog()
    End Sub
End Class