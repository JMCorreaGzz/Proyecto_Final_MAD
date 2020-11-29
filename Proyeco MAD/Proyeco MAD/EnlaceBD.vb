Imports System.Data
Imports System.Data.SqlClient
Public Class EnlaceBD
    Private aux As String
    Private conexion As SqlConnection
    Private tabla As DataTable = New DataTable
    Private adaptador As SqlDataAdapter = New SqlDataAdapter
    Private comandosql As SqlCommand = New SqlCommand("data source = DESKTOP-RP76UEH\SQLEXPRESS;Initial Catalog=NominaEmpresas; persist security info=True;Integred Security=SSPI")

    Private Sub conectar()
        conexion = New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("desarrollo").ConnectionString)
    End Sub

    Private Sub desconectar()
        conexion.Close()
    End Sub

    Public ReadOnly Property obtenertabla() As DataTable
        Get
            Return tabla
        End Get
    End Property

    Public Function Puestos(ByVal Opc As Char, ByVal IDPuesto As Integer, ByVal NomPuesto As String,
                            ByVal Empresa As String, ByVal NomDepartamento As String, ByVal NivSlarial As Decimal,
                            ByVal Antiguedad As Decimal, ByVal Activo As Boolean) As DataTable
        Dim data As New DataTable
        Dim Qry As String
        Try
            conectar()
            Qry = "sp_Puestos"
            comandosql = New SqlCommand(Qry, conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.Char, 1)
            parametro1.Value = Opc

            If (IDPuesto = 0) Then
                Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@IDPuesto", SqlDbType.Int, 16)
                parametro2.Value = DBNull.Value

            Else
                Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@IDPuesto", SqlDbType.Int, 16)
                parametro2.Value = IDPuesto
            End If

            If (NomPuesto = "") Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@NomPuesto", SqlDbType.VarChar, 20)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@NomPuesto", SqlDbType.VarChar, 20)
                parametro3.Value = NomPuesto
            End If

            If (Empresa = "") Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Empresa", SqlDbType.VarChar, 20)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Empresa", SqlDbType.VarChar, 20)
                parametro3.Value = Empresa
            End If

            If (NomDepartamento = "") Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@NomDepartamento", SqlDbType.VarChar, 20)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@NomDepartamento", SqlDbType.VarChar, 20)
                parametro3.Value = NomDepartamento
            End If

            If (NivSlarial = 0) Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@NivSlarial", SqlDbType.Float, 4)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@NivSlarial", SqlDbType.Float, 4)
                parametro3.Value = NivSlarial
            End If

            If (Antiguedad = 0) Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Antiguedad", SqlDbType.Float, 4)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Antiguedad", SqlDbType.Float, 4)
                parametro3.Value = Antiguedad
            End If

            If (Activo = 0) Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Activo", SqlDbType.Bit, 8)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Activo", SqlDbType.Bit, 8)
                parametro3.Value = Activo
            End If

            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)

        Catch ex As SqlException

        Finally
            desconectar()
        End Try
        Return data
    End Function

    Public Function Perp_Dedu(ByVal Opc As Char, ByVal IDPerp_Dedu As Integer, ByVal Tipo As Boolean,
                            ByVal Motivo As String, ByVal Monto As Decimal, ByVal Activo As Boolean) As DataTable
        Dim data As New DataTable
        Dim Qry As String
        Try
            conectar()
            Qry = "sp_Perp_Dedu"
            comandosql = New SqlCommand(Qry, conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.Char, 1)
            parametro1.Value = Opc

            If (IDPerp_Dedu = 0) Then
                Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@IDPerp_Dedu", SqlDbType.Int, 16)
                parametro2.Value = DBNull.Value

            Else
                Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@IDPerp_Dedu", SqlDbType.Int, 16)
                parametro2.Value = IDPerp_Dedu
            End If

            If (Tipo = "") Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Tipo", SqlDbType.Bit, 8)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Tipo", SqlDbType.Bit, 8)
                parametro3.Value = Tipo
            End If

            If (Motivo = "") Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Motivo", SqlDbType.VarChar, 30)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Motivo", SqlDbType.VarChar, 30)
                parametro3.Value = Motivo
            End If

            If (Monto = 0) Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Monto", SqlDbType.Float, 4)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Monto", SqlDbType.Float, 4)
                parametro3.Value = Monto
            End If

            If (Activo = 0) Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Activo", SqlDbType.Bit, 8)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Activo", SqlDbType.Bit, 8)
                parametro3.Value = Activo
            End If

            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)

        Catch ex As SqlException

        Finally
            desconectar()
        End Try
        Return data
    End Function

    Public Function Incidencias(ByVal Opc As Char, ByVal IDIncidencias As Integer, ByVal Motivo As Char,
                                ByVal Fecha As Date, ByVal NomEmpresa As String, ByVal NomDepartamento As String,
                                ByVal Tarea As String, ByVal Activo As Boolean) As DataTable
        Dim data As New DataTable
        Dim Qry As String
        Try
            conectar()
            Qry = "sp_Incidencias"
            comandosql = New SqlCommand(Qry, conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.Char, 1)
            parametro1.Value = Opc

            If (IDIncidencias = 0) Then
                Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@IDIncidencias", SqlDbType.Int, 16)
                parametro2.Value = DBNull.Value

            Else
                Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@IDIncidencias", SqlDbType.Int, 16)
                parametro2.Value = IDIncidencias
            End If

            If (Motivo = "") Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Motivo", SqlDbType.VarChar, 30)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Motivo", SqlDbType.VarChar, 30)
                parametro3.Value = Motivo
            End If

            If (Fecha = "10 - 10 - 1000") Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Fecha", SqlDbType.Date, 64)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Fecha", SqlDbType.Date, 64)
                parametro3.Value = Fecha
            End If

            If (NomEmpresa = "") Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@NomEmpresa", SqlDbType.VarChar, 30)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@NomEmpresa", SqlDbType.VarChar, 30)
                parametro3.Value = NomEmpresa
            End If

            If (NomDepartamento = "") Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@NomDepartamento", SqlDbType.VarChar, 50)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@NomDepartamento", SqlDbType.VarChar, 50)
                parametro3.Value = NomDepartamento
            End If

            If (Tarea = "") Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Tarea", SqlDbType.VarChar, 30)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Tarea", SqlDbType.VarChar, 30)
                parametro3.Value = Tarea
            End If

            If (Activo = 0) Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Activo", SqlDbType.Bit, 8)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Activo", SqlDbType.Bit, 8)
                parametro3.Value = Activo
            End If

            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)

        Catch ex As SqlException

        Finally
            desconectar()
        End Try
        Return data
    End Function

    Public Function Empleados(ByVal Opc As Char, ByVal NumEmpleado As Integer, ByVal Contraseña As String,
                                ByVal ApPaterno As String, ByVal ApMaterno As String, ByVal Nombre As String,
                                ByVal Remuneracion As Decimal, ByVal Puesto As String, ByVal NivSalarial As String,
                                ByVal FechaNacimiento As Date, ByVal CURP As String, ByVal NSS As String, ByVal RFC As String,
                                ByVal Calle As String, ByVal Num As Integer, ByVal Colonia As String, ByVal Municipio As String,
                                ByVal Estado As String, ByVal CP As Integer, ByVal Banco As String, ByVal NumCuenta As Integer,
                                ByVal Email As String, ByVal Telefono As Integer, ByVal Antiguedad As Boolean,
                                ByVal IDEmpresa As Integer, ByVal IDPuesto As Integer, Activo As Boolean) As DataTable
        Dim data As New DataTable
        Dim Qry As String
        Try
            conectar()
            Qry = "sp_Empleados"
            comandosql = New SqlCommand(Qry, conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.Char, 1)
            parametro1.Value = Opc

            If (NumEmpleado = 0) Then
                Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@NumEmpleado", SqlDbType.Int, 16)
                parametro2.Value = DBNull.Value

            Else
                Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@NumEmpleado", SqlDbType.Int, 16)
                parametro2.Value = NumEmpleado
            End If

            If (Contraseña = "") Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Contraseña", SqlDbType.VarChar, 40)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Contraseña", SqlDbType.VarChar, 40)
                parametro3.Value = Contraseña
            End If

            If (ApPaterno = "") Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@ApPaterno", SqlDbType.VarChar, 30)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@ApPaterno", SqlDbType.VarChar, 30)
                parametro3.Value = ApPaterno
            End If

            If (ApMaterno = "") Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@ApMaterno", SqlDbType.VarChar, 30)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@ApMaterno", SqlDbType.VarChar, 30)
                parametro3.Value = ApMaterno
            End If

            If (Nombre = "") Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 25)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 25)
                parametro3.Value = Nombre
            End If

            If (Remuneracion = 0) Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Remuneracion", SqlDbType.Float, 4)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Remuneracion", SqlDbType.Float, 4)
                parametro3.Value = Remuneracion
            End If

            If (Puesto = "") Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Puesto", SqlDbType.VarChar, 30)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Puesto", SqlDbType.VarChar, 30)
                parametro3.Value = Puesto
            End If

            If (NivSalarial = "") Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@NivSalarial", SqlDbType.VarChar, 10)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@NivSalarial", SqlDbType.VarChar, 10)
                parametro3.Value = NivSalarial
            End If

            If (FechaNacimiento = "10 - 10 - 1000") Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@FechaNacimiento", SqlDbType.Date, 64)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@FechaNacimiento", SqlDbType.Date, 64)
                parametro3.Value = FechaNacimiento
            End If

            If (CURP = "") Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@CURP", SqlDbType.VarChar, 25)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@CURP", SqlDbType.VarChar, 25)
                parametro3.Value = CURP
            End If

            If (NSS = "") Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@NSS", SqlDbType.VarChar, 25)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@NSS", SqlDbType.VarChar, 25)
                parametro3.Value = NSS
            End If

            If (RFC = "") Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@RFC", SqlDbType.VarChar, 15)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@RFC", SqlDbType.VarChar, 15)
                parametro3.Value = RFC
            End If

            If (Calle = "") Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Calle", SqlDbType.VarChar, 15)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Calle", SqlDbType.VarChar, 15)
                parametro3.Value = Calle
            End If

            If (Num = 0) Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Num", SqlDbType.Int, 16)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Num", SqlDbType.Int, 16)
                parametro3.Value = Num
            End If

            If (Colonia = "") Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Colonia", SqlDbType.VarChar, 25)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Colonia", SqlDbType.VarChar, 25)
                parametro3.Value = Colonia
            End If

            If (Municipio = "") Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Municipio", SqlDbType.VarChar, 25)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Municipio", SqlDbType.VarChar, 25)
                parametro3.Value = Municipio
            End If

            If (Estado = "") Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Estado", SqlDbType.VarChar, 25)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Estado", SqlDbType.VarChar, 25)
                parametro3.Value = Estado
            End If

            If (CP = 0) Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@CP", SqlDbType.Int, 16)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@CP", SqlDbType.Int, 16)
                parametro3.Value = CP
            End If

            If (Banco = "") Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Banco", SqlDbType.VarChar, 15)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Banco", SqlDbType.VarChar, 15)
                parametro3.Value = Banco
            End If

            If (NumCuenta = 0) Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@NumCuenta", SqlDbType.Int, 16)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@NumCuenta", SqlDbType.Int, 16)
                parametro3.Value = NumCuenta
            End If

            If (Email = "") Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Email", SqlDbType.VarChar, 50)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Email", SqlDbType.VarChar, 50)
                parametro3.Value = Email
            End If

            If (Telefono = 0) Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Telefono", SqlDbType.Int, 16)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Telefono", SqlDbType.Int, 16)
                parametro3.Value = Telefono
            End If

            If (Antiguedad = 0) Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Antiguedad", SqlDbType.Float, 4)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Antiguedad", SqlDbType.Float, 4)
                parametro3.Value = Antiguedad
            End If

            If (IDEmpresa = 0) Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@IDEmpresa", SqlDbType.Int, 16)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@IDEmpresa", SqlDbType.Int, 16)
                parametro3.Value = IDEmpresa
            End If

            If (IDPuesto = 0) Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@IDPuesto", SqlDbType.Int, 16)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@IDPuesto", SqlDbType.Int, 16)
                parametro3.Value = IDPuesto
            End If

            If (Activo = 0) Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Activo", SqlDbType.Bit, 8)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Activo", SqlDbType.Bit, 8)
                parametro3.Value = Activo
            End If

            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)

        Catch ex As SqlException

        Finally
            desconectar()
        End Try
        Return data
    End Function

    Public Function Nomina(ByVal Opc As Char, ByVal IDNomina As Integer, ByVal Frecuencia As Decimal,
                           ByVal FechaPago As Date, ByVal SuelDiario As Decimal, ByVal ISR As Decimal,
                           ByVal PSS As Decimal, ByVal IDPerp_Dedu As Integer, ByVal Activo As Boolean) As DataTable

        Dim data As New DataTable
        Dim Qry As String
        Try
            conectar()
            Qry = "sp_Nomina"
            comandosql = New SqlCommand(Qry, conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.Char, 1)
            parametro1.Value = Opc

            If (IDNomina = 0) Then
                Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@IDNomina", SqlDbType.Int, 16)
                parametro2.Value = DBNull.Value

            Else
                Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@IDNomina", SqlDbType.Int, 16)
                parametro2.Value = IDNomina
            End If

            If (Frecuencia = "") Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Frecuencia", SqlDbType.Float, 4)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Frecuencia", SqlDbType.Float, 4)
                parametro3.Value = Frecuencia
            End If


            If (FechaPago = "10 - 10 - 1000") Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@FechaPago", SqlDbType.Date, 64)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@FechaPago", SqlDbType.Date, 64)
                parametro3.Value = FechaPago
            End If

            If (SuelDiario = "") Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@SuelDiario", SqlDbType.Float, 4)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@SuelDiario", SqlDbType.Float, 4)
                parametro3.Value = Frecuencia
            End If

            If (ISR = "") Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@ISR", SqlDbType.Float, 4)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@ISR", SqlDbType.Float, 4)
                parametro3.Value = Frecuencia
            End If

            If (PSS = "") Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@PSS", SqlDbType.Float, 4)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@PSS", SqlDbType.Float, 4)
                parametro3.Value = Frecuencia
            End If

            If (IDPerp_Dedu = 0) Then
                Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@IDPerp_Dedu", SqlDbType.Int, 16)
                parametro2.Value = DBNull.Value

            Else
                Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@IDPerp_Dedu", SqlDbType.Int, 16)
                parametro2.Value = IDPerp_Dedu
            End If

            If (Activo = 0) Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Activo", SqlDbType.Bit, 8)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Activo", SqlDbType.Bit, 8)
                parametro3.Value = Activo
            End If

            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)

        Catch ex As SqlException

        Finally
            desconectar()
        End Try
        Return data
    End Function

    Public Function Departamento(ByVal Opc As Char, ByVal IDDepartamento As Integer, ByVal NomDepartamento As String,
                            ByVal Empleados As Integer, ByVal SueldoBase As Boolean, ByVal Activo As Boolean) As DataTable
        Dim data As New DataTable
        Dim Qry As String
        Try
            conectar()
            Qry = "sp_Departamento"
            comandosql = New SqlCommand(Qry, conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.Char, 1)
            parametro1.Value = Opc

            If (IDDepartamento = 0) Then
                Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@IDDepartamento", SqlDbType.Int, 16)
                parametro2.Value = DBNull.Value

            Else
                Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@IDDepartamento", SqlDbType.Int, 16)
                parametro2.Value = IDDepartamento
            End If

            If (NomDepartamento = "") Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@NomDepartamento", SqlDbType.VarChar, 20)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@NomDepartamento", SqlDbType.VarChar, 20)
                parametro3.Value = NomDepartamento
            End If

            If (Empleados = 0) Then
                Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Empleados", SqlDbType.Int, 16)
                parametro2.Value = DBNull.Value

            Else
                Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Empleados", SqlDbType.Int, 16)
                parametro2.Value = Empleados
            End If

            If (SueldoBase = 0) Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@SueldoBase", SqlDbType.Float, 4)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@SueldoBase", SqlDbType.Float, 4)
                parametro3.Value = SueldoBase
            End If

            If (Activo = 0) Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Activo", SqlDbType.Bit, 8)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Activo", SqlDbType.Bit, 8)
                parametro3.Value = Activo
            End If

            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)

        Catch ex As SqlException

        Finally
            desconectar()
        End Try
        Return data
    End Function

    Public Function Empresas(ByVal Opc As Char, ByVal IDEmpresa As Integer, ByVal RazSocial As String, ByVal DomFiscal As String,
                            ByVal DatContacto As String, ByVal RegPatronal As String, ByVal RegFederal As Decimal,
                            ByVal FechaInicio As Date, ByVal NomEmpresa As String, ByVal NominaFK As Integer,
                            ByVal Dep As Integer, ByVal Puestos As Integer, ByVal Activo As Boolean) As DataTable
        Dim data As New DataTable
        Dim Qry As String
        Try
            conectar()
            Qry = "sp_Empresas"
            comandosql = New SqlCommand(Qry, conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.Char, 1)
            parametro1.Value = Opc

            If (IDEmpresa = 0) Then
                Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@IDEmpresa", SqlDbType.Int, 16)
                parametro2.Value = DBNull.Value

            Else
                Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@IDEmpresa", SqlDbType.Int, 16)
                parametro2.Value = IDEmpresa
            End If

            If (RazSocial = "") Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@RazSocial", SqlDbType.VarChar, 30)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@RazSocial", SqlDbType.VarChar, 30)
                parametro3.Value = RazSocial
            End If

            If (DomFiscal = "") Then
                Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@DomFiscal", SqlDbType.VarChar, 30)
                parametro2.Value = DBNull.Value

            Else
                Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@DomFiscal", SqlDbType.VarChar, 30)
                parametro2.Value = DomFiscal
            End If

            If (DatContacto = "") Then
                Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@DatContacto", SqlDbType.Char, 11)
                parametro2.Value = DBNull.Value

            Else
                Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@DatContacto", SqlDbType.Char, 11)
                parametro2.Value = DatContacto
            End If

            If (RegPatronal = "") Then
                Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@RegPatronal", SqlDbType.Char, 11)
                parametro2.Value = DBNull.Value

            Else
                Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@RegPatronal", SqlDbType.Char, 11)
                parametro2.Value = RegPatronal
            End If

            If (RegFederal = 0) Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@RegFederal", SqlDbType.Float, 4)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@RegFederal", SqlDbType.Float, 4)
                parametro3.Value = RegFederal
            End If

            If (FechaInicio = "10 - 10 - 1000") Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@FechaInicio", SqlDbType.Date, 64)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@FechaInicio", SqlDbType.Date, 64)
                parametro3.Value = FechaInicio
            End If

            If (NomEmpresa = "") Then
                Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@NomEmpresa", SqlDbType.VarChar, 30)
                parametro2.Value = DBNull.Value

            Else
                Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@NomEmpresa", SqlDbType.VarChar, 30)
                parametro2.Value = NomEmpresa
            End If

            If (NominaFK = 0) Then
                Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@NominaFK", SqlDbType.Int, 16)
                parametro2.Value = DBNull.Value

            Else
                Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@NominaFK", SqlDbType.Int, 16)
                parametro2.Value = NominaFK
            End If

            If (Dep = 0) Then
                Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Dep", SqlDbType.Int, 16)
                parametro2.Value = DBNull.Value

            Else
                Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Dep", SqlDbType.Int, 16)
                parametro2.Value = Dep
            End If

            If (Puestos = 0) Then
                Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Puestos", SqlDbType.Int, 16)
                parametro2.Value = DBNull.Value

            Else
                Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Puestos", SqlDbType.Int, 16)
                parametro2.Value = Puestos
            End If

            If (Activo = 0) Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Activo", SqlDbType.Bit, 8)
                parametro3.Value = DBNull.Value
            Else
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Activo", SqlDbType.Bit, 8)
                parametro3.Value = Activo
            End If

            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)

        Catch ex As SqlException

        Finally
            desconectar()
        End Try
        Return data
    End Function




    'Funciones del Profe
    Public Function GeneraAnalisis1(ByVal dFechaI As Date, ByVal dFechaF As Date, ByVal Tienda As Integer, ByVal Depto As String) As Boolean
        Dim estado As Boolean = True
        Try
            conectar()
            comandosql = New SqlCommand("dbo.cumhoGeneraAnalisis1", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@FechaIni", SqlDbType.SmallDateTime, 15)
            parametro1.Value = dFechaI
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@FechaFin", SqlDbType.SmallDateTime, 15)
            parametro2.Value = dFechaF
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@pTienda", SqlDbType.Int, 8)
            parametro3.Value = Tienda
            Dim parametro4 As SqlParameter = comandosql.Parameters.Add("@pDepto", SqlDbType.VarChar, 10)
            parametro4.Value = Depto

            adaptador.SelectCommand = comandosql
            adaptador.Fill(tabla)

        Catch ex As SqlException
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function ObtenTiendas(ByVal Tienda As Integer) As Boolean
        Dim estado As Boolean = True
        Dim Qry As String = ""

        Qry = "SELECT Id, Nombre FROM Tienda"
        Try
            conectar()
            comandosql = New SqlCommand(Qry, conexion)
            comandosql.CommandType = CommandType.Text

            adaptador.SelectCommand = comandosql
            adaptador.Fill(tabla)

        Catch ex As SqlException
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function ObtenDeptos(ByVal tienda As Integer) As Boolean
        Dim estado As Boolean = True
        Dim Qry As String
        Qry = "sp_Deptos"
        Try
            conectar()
            comandosql = New SqlCommand(Qry, conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            adaptador.SelectCommand = comandosql
            adaptador.Fill(tabla)

        Catch ex As SqlException
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function Get_Puestos() As DataTable
        Dim Qry As String
        Dim data As New DataTable

        Try

            conectar()

            Qry = "sp_Puestos"
            comandosql = New SqlCommand(Qry, conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.Char, 1)
            parametro1.Value = "X"


            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)

        Catch ex As SqlException

        Finally
            desconectar()
        End Try
        Return data

    End Function
    Public Function ObtenDatosArchivo(ByVal CveOperacion As String, ByVal TipoPago As Integer, ByVal DiaPago As String) As Boolean
        Dim estado As Boolean = True
        Dim qry As String
        'qry = "dbo.CtlInt_PagoNomina_pUP"
        qry = "dbo.sp_pruebas"
        Try
            conectar()
            comandosql = New SqlCommand(qry, conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@pCveOperacion", SqlDbType.VarChar, 4)
            parametro1.Value = CveOperacion
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@pTipoPago", SqlDbType.SmallInt, 4)
            parametro2.Value = TipoPago
            If CveOperacion <> "HEDS" Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@pDiaPago", SqlDbType.VarChar, 15)
                parametro3.Value = DiaPago
            End If
            adaptador.SelectCommand = comandosql
            adaptador.Fill(tabla)

        Catch ex As SqlException
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function ObtenDatosPago(ByVal CveOperacion As String, ByVal TipoPago As Integer, ByVal DiaPago As String) As Boolean
        Dim estado As Boolean = True

        Try
            conectar()
            comandosql = New SqlCommand("dbo.sp_Pruebas", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@pCveOperacion", SqlDbType.VarChar, 4)
            parametro1.Value = CveOperacion
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@pTipoPago", SqlDbType.SmallInt, 4)
            parametro2.Value = TipoPago
            If CveOperacion = "DETS" Then
                Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@pDiaPago", SqlDbType.VarChar, 15)
                parametro3.Value = DiaPago
            End If
            adaptador.SelectCommand = comandosql
            adaptador.Fill(tabla)

        Catch ex As SqlException
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function


End Class
