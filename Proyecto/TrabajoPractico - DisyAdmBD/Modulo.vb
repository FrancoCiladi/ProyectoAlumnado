Module Modulo
    Public Const cadenaConexion As String = "Data Source=localhost\sqlexpress;Initial Catalog=TrabajoPracticoBD;User ID=sa;Password=TurnItUp_41134538"

    Public Operacion As String
    Public nro_legajo_alumno_Selec As String
    Public nro_legajo_profesor_Selec As String
    Public cod_materia_Selec As String
    Public cod_turno_Selec As String
    Public año_Selec As String
    Public nro_legajo_profesorReemplazo_Selec As String
    Public sqlInforme As String
    Public Sub Ejecutar(ByVal cadenaSQL As String)
        Dim Conexion As SqlClient.SqlConnection
        Dim Comando As SqlClient.SqlCommand

        Conexion = New SqlClient.SqlConnection
        Conexion.ConnectionString = cadenaConexion
        Conexion.Open()
        Comando = New SqlClient.SqlCommand
        Comando.Connection = Conexion
        Comando.CommandType = CommandType.Text
        Comando.CommandText = cadenaSQL
        Comando.ExecuteNonQuery()

        Conexion.Close()
    End Sub

    Public Sub Recuperar(ByVal cadenaSQL As String, ByRef Tabla As DataTable)
        Dim Conexion As SqlClient.SqlConnection   'lo que permite conectar al servidor
        Dim Comando As SqlClient.SqlCommand  'lleva y trae informacion de la base de datos

        Conexion = New SqlClient.SqlConnection 'genero la conexion
        Conexion.ConnectionString = cadenaConexion  'a que base de datos se tiene que conectar
        Conexion.Open() 'abro la conexion
        Comando = New SqlClient.SqlCommand
        Comando.Connection = Conexion
        Comando.CommandType = CommandType.Text 'text porque son sentencias SQL
        Comando.CommandText = cadenaSQL
        Tabla = New DataTable
        Tabla.Load(Comando.ExecuteReader) 'devuelve el conjunto de registros y los carga en la tabla

        Conexion.Close()
    End Sub
    Public Function ValidarFiltro(ByVal cadena As String)

        Dim caracteres() As String = New String() {"'", """", "%"}
        Dim ok As Boolean = True

        For i = 0 To caracteres.Length - 1
            If (cadena.Contains(caracteres(i))) Then
                ok = False
            End If
        Next

        Return ok
    End Function


End Module
