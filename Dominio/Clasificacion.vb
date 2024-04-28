Public Class Clasificacion
    Public Property Temporada As Integer
    Public Property Piloto As Piloto
    Public Property Escuderia As Escuderia
    Public ReadOnly Property ClasificacionDAO As ClasificacionDAO 'creamos objeto tipo PersonaDAO'

    Public Sub New(temporada As Integer)
        Me.ClasificacionDAO = New ClasificacionDAO
        Me.Temporada = temporada
    End Sub

    Public Function ConseguirClasificacionPilotos() As Collection
        Return Me.ClasificacionDAO.LeerClasificacionPilotos(Me)
    End Function

    Public Function ConseguirClasificacionEscuderias() As Collection
        Return Me.ClasificacionDAO.LeerClasificacionEscuderias(Me)
    End Function

End Class
