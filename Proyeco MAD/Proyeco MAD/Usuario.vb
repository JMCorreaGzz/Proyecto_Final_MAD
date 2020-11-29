Public Class Usuario
    Private Sub BotEmp_Click(sender As Object, e As EventArgs) Handles BotEmp.Click
        EMPRESAS.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Puesto.ShowDialog()
    End Sub

    Private Sub ButEmpl_Click(sender As Object, e As EventArgs) Handles ButEmpl.Click, BotEmp.Click
        Empleados.ShowDialog()
    End Sub

    Private Sub ButDep_Click(sender As Object, e As EventArgs) Handles ButDep.Click, BotEmp.Click
        Departamentos.ShowDialog()
    End Sub

    Private Sub ButPer_Click(sender As Object, e As EventArgs) Handles ButPer.Click, BotEmp.Click
        Perp.ShowDialog()
    End Sub

    Private Sub ButInc_Click(sender As Object, e As EventArgs) Handles ButInc.Click, BotEmp.Click
        Incidencias.ShowDialog()
    End Sub

    Private Sub Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class