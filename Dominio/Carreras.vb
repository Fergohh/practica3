Public Class Carreras

    Public Property Temporada As Integer
    Public Property GP As GP
    Public Property Piloto As Piloto
    Public Property Posicion As Integer
    Public Property Puntos As Integer
    Public ReadOnly Property CarrerasDAO As CarrerasDAO 'creamos objeto tipo PersonaDAO'

    Public Sub New()
        Me.CarrerasDAO = New CarrerasDAO
    End Sub

    Public Sub New(temporada As String, Gp As GP, Piloto As Piloto)
        Me.CarrerasDAO = New CarrerasDAO
        Me.Temporada = temporada
        Me.GP = Gp
        Me.Piloto = Piloto
    End Sub

    Public Sub LeerTodosCarreras()
        Me.CarrerasDAO.LeerTodas()
    End Sub

    Public Sub LeerCarrera()
        Me.CarrerasDAO.Leer(Me) 'Me es un objeto persona'
    End Sub

    Public Function InsertarCarrera() As Integer
        Return Me.CarrerasDAO.Insertar(Me)
    End Function

    Public Function BorrarPilotos() As Integer
        Return Me.CarrerasDAO.Borrar(Me)
    End Function

    Public Function BorrarTodasLasCarreras() As Integer
        Return Me.CarrerasDAO.BorrarTodos()
    End Function
End Class