Public Class AgenteBD

    Private Shared _instancia As AgenteBD
    Private Shared conexion As MySql.Data.MySqlClient.MySqlConnection
    Private Const cadenaConexion As String = "server=172.19.142.0;port=3306;database=formulauno;uid=Fer;pwd=1234"

    Private Sub New()
        AgenteBD.conexion = New MySql.Data.MySqlClient.MySqlConnection(AgenteBD.cadenaConexion)
    End Sub

    Public Shared Function ObtenerAgente() As AgenteBD
        If AgenteBD._instancia Is Nothing Then
            AgenteBD._instancia = New AgenteBD
        End If
        Return AgenteBD._instancia
    End Function

    Public Function Leer(sql As String) As Collection
        Dim result As New Collection
        Dim fila As Collection
        Dim i As Integer
        Dim reader As MySql.Data.MySqlClient.MySqlDataReader
        Dim com As New MySql.Data.MySqlClient.MySqlCommand(sql, AgenteBD.conexion)
        Conectar()
        reader = com.ExecuteReader
        While reader.Read   'mientras haya algo para leer sigue ejecutandose
            fila = New Collection
            For i = 0 To reader.FieldCount - 1  'fieldCount es el numero de campos, si en vez de count fuera row seria filas
                fila.Add(reader(i).ToString) 'reader(i) apunta hacia el elemento de indice i si i = 0 es ID y si i = 1 el nombre
            Next
            result.Add(fila) 'añadimos la coleccion fila a la coleccion result
        End While
        Desconectar()
        Return result
    End Function

    Public Function Modificar(sql As String) As Integer
        Dim com As New MySql.Data.MySqlClient.MySqlCommand(sql, AgenteBD.conexion)
        Dim result As Integer
        Conectar()
        result = com.ExecuteNonQuery
        Desconectar()
        Return result
    End Function

    Private Sub Conectar()
        If AgenteBD.conexion.State = ConnectionState.Closed Then
            AgenteBD.conexion.Open()
        End If
    End Sub

    Private Sub Desconectar()
        If AgenteBD.conexion.State = ConnectionState.Open Then
            AgenteBD.conexion.Close()
        End If
    End Sub

End Class
