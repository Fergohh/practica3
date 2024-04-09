Public Class Piloto
    Public Property IDPiloto As Integer
    Public Property Nombre As String

    Public Property Apellido As String

    Public Property PaisPiloto As String
    Public ReadOnly Property PilotoDAO As PilotoDAO 'cereamos objeto tipo PersonaDAO'

    Public Sub New()
        Me.PilotoDAO = New PilotoDAO
    End Sub

    Public Sub New(id As String)
        Me.PilotoDAO = New PilotoDAO
        Me.IDPiloto = id
    End Sub

    Public Sub LeerTodosPilotos()
        Me.PilotoDAO.LeerTodas()
    End Sub

    Public Sub LeerPilotos()
        Me.PilotoDAO.Leer(Me) 'Me es un objeto persona'
    End Sub

    Public Function InsertarPilotos() As Integer
        Return Me.PilotoDAO.Insertar(Me)
    End Function

    Public Function ActualizarPilotos() As Integer
        Return Me.PilotoDAO.Actualizar(Me)
    End Function

    Public Function BorrarPilotos() As Integer
        Return Me.PilotoDAO.Borrar(Me)
    End Function

End Class