Public Class Pais

    Public Property IDPais As String
    Public Property Nombre As String
    Public Property Habitantes As Integer
    Public ReadOnly Property PaisDAO As PaisDAO

    Public Sub New()
        Me.PaisDAO = New PaisDAO
    End Sub

    Public Sub New(id As String)
        Me.PaisDAO = New PaisDAO
        Me.IDPais = id
    End Sub

    Public Sub LeerTodosPaises()
        Me.PaisDAO.LeerTodas()
    End Sub

    Public Sub LeerPais()
        Me.PaisDAO.Leer(Me)
    End Sub

    Public Function InsertarPais() As Integer
        Return Me.PaisDAO.Insertar(Me)
    End Function

    Public Function ActualizarPais() As Integer
        Return Me.PaisDAO.Actualizar(Me)
    End Function

    Public Function BorrarPersona() As Integer
        Return Me.PaisDAO.Borrar(Me)
    End Function


End Class
