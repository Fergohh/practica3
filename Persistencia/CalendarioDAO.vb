Imports System.Data.SqlClient

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
                calendario = New Calendario With {
                    .Temporada = aux(1), ' El primer elemento es la temporada
                    .GP = aux(2), ' El segundo elemento es el GP
                    .Orden = aux(3) ' El tercer elemento es el orden
                    }
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
            Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Calendario (Temporada, GP, Orden) VALUES ('" & calendario.Temporada & "', '" & calendario.GP & "', '" & calendario.Orden & "')") ' Insertar un nuevo calendario en la base de datos
        Catch ex As Exception
            Throw New Exception("Error al insertar el calendario", ex)
        End Try
    End Function

End Class
