Public Class Contrato

    Public Property Temporada As Integer
    Public Property Escuderia As Escuderia
    Public Property Piloto1 As Piloto
    Public Property Piloto2 As Piloto

    Public ReadOnly Property ContratoDAO As ContratoDAO 'creamos objeto tipo PersonaDAO'

    Public Sub New()
        Me.ContratoDAO = New ContratoDAO
    End Sub

    Public Sub New(Escuderia As Escuderia, Temporada As Integer)
        Me.ContratoDAO = New ContratoDAO
        Me.Temporada = Temporada
        Me.Escuderia = Escuderia
    End Sub

    Public Sub LeerTodosContratos()
        Me.ContratoDAO.LeerTodas()
    End Sub

    Public Sub LeerContrato()
        Me.ContratoDAO.Leer(Me) 'Me es un objeto persona'
    End Sub

    Public Sub LeerTodosContratosPorTemporada()
        Me.ContratoDAO.LeerTodosPorTemporada(Me)
    End Sub

    Public Function InsertarContrato() As Integer
        Return Me.ContratoDAO.Insertar(Me)
    End Function

    Public Function BorrarContrato() As Integer
        Return Me.ContratoDAO.Borrar(Me)
    End Function

    Public Function BorrarTodosLoscontratos() As Integer
        Return Me.ContratoDAO.BorrarTodos()
    End Function
End Class