Public Class Pais

    Public Property IDPais As String
    Public Property Nombre As String
    Public Property Habitantes As Integer
    Public ReadOnly Property PerDAO As PaisDAO

    Public Sub New()
        Me.PerDAO = New PaisDAO
    End Sub

    Public Sub New(id As String)
        Me.PerDAO = New PaisDAO
        Me.IDPais = id
    End Sub

    Public Sub LeerTodasPersonas()
        Me.PerDAO.LeerTodas()
    End Sub

    Public Sub LeerPersona()
        Me.PerDAO.Leer(Me)
    End Sub

    Public Function InsertarPersona() As Integer
        Return Me.PerDAO.Insertar(Me)
    End Function

    Public Function ActualizarPersona() As Integer
        Return Me.PerDAO.Actualizar(Me)
    End Function

    Public Function BorrarPersona() As Integer
        Return Me.PerDAO.Borrar(Me)
    End Function


End Class
