Public Class GP
    Public Property IDGP As Integer
    Public Property DenominacionGP As String

    Public Property PaisGP As String


    Public ReadOnly Property GPDAO As GPDAO 'cereamos objeto tipo PersonaDAO'

    Public Sub New()
        Me.GPDAO = New GPDAO
    End Sub

    Public Sub New(id As String)
        Me.GPDAO = New GPDAO
        Me.IDGP = id
    End Sub

    Public Sub LeerTodosGPs()
        Me.GPDAO.LeerTodas()
    End Sub

    Public Sub LeerGP()
        Me.GPDAO.Leer(Me) 'Me es un objeto persona'
    End Sub

    Public Function InsertarGP() As Integer
        Return Me.GPDAO.Insertar(Me)
    End Function

    Public Function ActualizarGP() As Integer
        Return Me.GPDAO.Actualizar(Me)
    End Function

    Public Function BorrarGP() As Integer
        Return Me.GPDAO.Borrar(Me)
    End Function


End Class