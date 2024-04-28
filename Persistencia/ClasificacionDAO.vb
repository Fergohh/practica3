Public Class ClasificacionDAO

    Public ReadOnly Property Clasificaciones As Collection 'personas es una variable de tipo colleción'
    Public ReadOnly Property CarreraPorTemporada As Collection
    Public Sub New()
        Me.Clasificaciones = New Collection
    End Sub


    Public Function LeerClasificacion(ByVal p As Clasificacion)
        MessageBox.Show("se Procede a leer las clasificiones")
        Dim pi As Piloto
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT P.IdPiloto, P.NombrePiloto, P.ApellidoPiloto, SUM(C.Puntos) as TotalPuntos
FROM PILOTOS P
JOIN CARRERAS C ON P.IdPiloto = C.Piloto
WHERE C.Temporada = '" & p.Temporada & "'
GROUP BY P.IdPiloto
ORDER BY TotalPuntos DESC, (SELECT COUNT(*)
                            FROM CARRERAS C2
                            WHERE C2.Piloto = C.Piloto AND C2.Posicion = 1
                            AND C2.Temporada = '" & p.Temporada & "') DESC;")

        For Each aux In col
            pi = New Piloto(aux(1).ToString)
            p.Piloto = pi
            Me.Clasificaciones.Add(p)
        Next

    End Function
End Class
