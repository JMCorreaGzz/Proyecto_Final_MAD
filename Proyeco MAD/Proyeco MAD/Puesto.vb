Public Class Puesto
    Private grdPuestos As Object

    Private Sub BotMos2_Click(sender As Object, e As EventArgs) Handles BotMos2.Click

        Dim conexion As New EnlaceBD
        Dim tabla As New DataTable

        tabla = conexion.Puestos("X", 0, "", "", "", 0, 0, 0)

        DataGridView1.DataSource = tabla

        ComboBox1.DataSource = tabla
        ComboBox1.DisplayMember = "Nombre Empresa"
        ComboBox1.ValueMember = "Clave"

        ComboBox2.DataSource = tabla
        ComboBox2.DisplayMember = "Nombre Departamento"
        ComboBox2.ValueMember = "Clave"

        ListBox1.DataSource = tabla
        ListBox1.DisplayMember = "Nombre Empresa"
        ListBox1.ValueMember = "Clave"



    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class