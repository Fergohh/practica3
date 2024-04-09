Public Class Escuderia
    Public Property IDEscuderia As Integer
    Public Property Nombre As String

    Public Property PaisEscuderia As String

    Public Property FechaCrec As Date

    Public ReadOnly Property EscuderiaDAO As EscuderiaDAO 'cereamos objeto tipo PersonaDAO'

    Public Sub New()
        Me.EscuderiaDAO = New EscuderiaDAO
    End Sub

    Public Sub New(id As String)
        Me.EscuderiaDAO = New EscuderiaDAO
        Me.IDEscuderia = id
    End Sub

    Public Sub LeerTodosPaises()
        Me.EscuderiaDAO.LeerTodas()
    End Sub

    Public Sub LeerPaises()
        Me.EscuderiaDAO.Leer(Me) 'Me es un objeto persona'
    End Sub

    Public Function InsertarPaises() As Integer
        Return Me.EscuderiaDAO.Insertar(Me)
    End Function

    Public Function ActualizarPersona() As Integer
        Return Me.EscuderiaDAO.Actualizar(Me)
    End Function

    Public Function BorrarPersona() As Integer
        Return Me.EscuderiaDAO.Borrar(Me)
    End Function


End Class