Public Class ClasificacionDAO

    Public ReadOnly Property ClasificacionesPilotos As Collection 'personas es una variable de tipo colleción'
    Public ReadOnly Property ClasificacionesEscuderias As Collection
    Public ReadOnly Property CarreraPorTemporada As Collection
    Public Sub New()
        Me.ClasificacionesPilotos = New Collection
        Me.ClasificacionesEscuderias = New Collection
    End Sub


    Public Function LeerClasificacionPilotos(ByVal p As Clasificacion)
        Dim clasi As Clasificacion
        MessageBox.Show("se Procede a leer las clasificiones")
        Dim pil As Piloto
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
            pil = New Piloto(aux(1).ToString)
            p.Piloto = pil
            clasi = New Clasificacion(p.Temporada)
            clasi.Piloto = pil
            clasi.Puntos = aux(2)
            Me.ClasificacionesPilotos.Add(clasi)

        Next

    End Function

    Public Function LeerClasificacionEscuderias(ByVal p As Clasificacion)
        Dim clasi As Clasificacion
        MessageBox.Show("se Procede a leer las clasificiones")
        Dim escu As Escuderia
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT E.IdEscuderia, SUM(C.Puntos) as TotalPuntos
FROM ESCUDERIAS E
JOIN CONTRATOS CO ON E.IdEscuderia = CO.Escuderia
JOIN CARRERAS C ON CO.Piloto1 = C.Piloto OR CO.Piloto2 = C.Piloto
WHERE C.Temporada = '" & p.Temporada & "'
GROUP BY E.IdEscuderia
ORDER BY TotalPuntos DESC, (SELECT COUNT(*)
                            FROM CARRERAS C2
                            JOIN CONTRATOS CO2 ON C2.Piloto = CO2.Piloto1 OR C2.Piloto = CO2.Piloto2
                            WHERE CO2.Escuderia = E.IdEscuderia AND C2.Posicion = 1
                            AND C2.Temporada = '" & p.Temporada & "') DESC;")

        For Each aux In col
            escu = New Escuderia(aux(1).ToString)
            p.Escuderia = escu
            clasi = New Clasificacion(p.Temporada)
            clasi.Escuderia = escu
            clasi.Puntos = aux(2)
            Me.ClasificacionesEscuderias.Add(clasi)
            MessageBox.Show("veamos:" & aux(1).ToString)
        Next

    End Function
End Class
