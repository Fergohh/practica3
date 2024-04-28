Public Class Clasificacion
    Public Property Temporada As Integer
    Public Property Piloto As Piloto
    Public ReadOnly Property ClasificacionDAO As ClasificacionDAO 'creamos objeto tipo PersonaDAO'

    Public Sub New(temporada As Integer)
        Me.ClasificacionDAO = New ClasificacionDAO
        Me.Temporada = temporada
    End Sub

    Public Function ConseguirClasificacion() As Collection
        Return Me.ClasificacionDAO.LeerClasificacion(Me)
    End Function

End Class
