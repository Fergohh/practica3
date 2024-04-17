Imports MySql.Data.MySqlClient

Public Class CalendarioDAO
    Public ReadOnly Property Calendarios As Collection ' Calendarios es una colección de objetos Calendario

    Public Sub New()
        Me.Calendarios = New Collection
    End Sub

    Public Sub LeerTodos()
        Try
            Dim calendario As Calendario
            Dim col, aux As Collection
            col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Calendario ORDER BY Temporada, Orden") ' Leer todos los calendarios ordenados por temporada y orden
            For Each aux In col
                calendario = New Calendario()
                calendario.Temporada = aux(1) ' El primer elemento es la temporada
                calendario.GP = aux(2) ' El segundo elemento es el GP
                calendario.Orden = aux(3) ' El tercer elemento es el orden
                Me.Calendarios.Add(calendario) ' Agregar el calendario a la colección
            Next
        Catch ex As Exception
            Throw New Exception("Error al leer todos los calendarios", ex)
        End Try
    End Sub

    Public Sub Leer(ByRef calendario As Calendario)
        Try
            Dim col As Collection : Dim aux As Collection
            col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Calendario WHERE Temporada='" & calendario.Temporada & "' AND GP='" & calendario.GP & "';") ' Leer un calendario específico por temporada y GP
            For Each aux In col
                calendario.Orden = aux(3) ' Actualizar el orden del calendario proporcionado
            Next
        Catch ex As Exception
            Throw New Exception("Error al leer el calendario", ex)
        End Try
    End Sub

    Public Function Insertar(ByVal calendario As Calendario) As Integer
        Try
            If calendario.Temporada < 1970 Or calendario.Temporada > 2024 Then
                Throw New ArgumentException("El año de la temporada debe estar entre 1970 y 2024")
            End If

            Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Calendario (Temporada, GP, Orden) VALUES ('" & calendario.Temporada & "', '" & calendario.GP & "', '" & calendario.Orden & "')")
        Catch ex As ArgumentException
            Throw
        Catch ex As Exception
            Throw New Exception("Error al insertar el calendario", ex)
        End Try
    End Function

    Public Function Actualizar(ByVal calendario As Calendario) As Integer
        Try
            Return AgenteBD.ObtenerAgente.Modificar("UPDATE Calendario SET Orden='" & calendario.Orden & "' WHERE Temporada='" & calendario.Temporada & "' AND GP='" & calendario.GP & "';") ' Actualizar el orden de un calendario existente en la base de datos
        Catch ex As Exception
            Throw New Exception("Error al actualizar el calendario", ex)
        End Try
    End Function

    Public Function Borrar(ByVal calendario As Calendario) As Integer
        Try
            Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Calendario WHERE Temporada='" & calendario.Temporada & "' AND GP='" & calendario.GP & "';") ' Borrar un calendario existente de la base de datos
        Catch ex As Exception
            Throw New Exception("Error al borrar el calendario", ex)
        End Try
    End Function
End Class
