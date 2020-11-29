Public Class Puesto
    Private grdPuestos As Object

    Private Sub BotMos2_Click(sender As Object, e As EventArgs) Handles BotMos2.Click

        Dim conexion As New EnlaceBD
        Dim tabla As New DataTable

        tabla = conexion.Puestos("X", 0, "", "", "", 0, 0, 0)

        DataGridView1.DataSource = tabla


    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub
End Class