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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Antiguedad As Decimal
        Dim nivel As Decimal
        Dim obj As New EnlaceBD
        Dim result As Boolean = False

        Antiguedad = Decimal.Parse(NivSal.Text)
        nivel = Decimal.Parse(Antig.Text)

        obj.Puestos("I", 0, "Banco", "Banorte", "Dinero", nivel, Antiguedad, 1)

        If result Then
            MessageBox.Show("El Puesto fue agregado")

        End If

    End Sub

End Class
