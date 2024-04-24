Public Class PilotoDAO
    Public ReadOnly Property Pilotos As Collection 'personas es una variable de tipo colleción'

    Public Sub New()
        Me.Pilotos = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim p As Piloto
        Dim pa As Pais
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM pilotos ORDER BY IdPiloto") 'llamamos a obtenerAgente que como es shared no tenemos que crear el objeto agente'
        For Each aux In col 'aux es una coleccion que representa a cada elemento de col en el bucle'
            p = New Piloto(aux(1).ToString) 'el primer elemento( axu(1) ) es el ID'
            pa = New Pais(aux(4).ToString)
            p.Nombre = aux(2).ToString 'el segundo elemento( aux(2) ) es el nombre'
            p.Apellido = aux(3).ToString
            p.PaisPiloto = pa
            Me.Pilotos.Add(p) 'add añade algo a una coleccion: añadimos la persona a la coleccion'
        Next 'dato importante: para acceder al id es 1 y nombre 2 no como en el reader que el primer elemento es 0 y el segundo 1'
    End Sub

    Public Sub Leer(ByRef p As Piloto) 'lo mismo que leer todas pero solo una persona la diferencia esta que como parametros pasamos una persona'
        Dim col As Collection : Dim aux As Collection
        Dim pa As Pais
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM pilotos WHERE IdPiloto='" & p.IDPiloto & "';") 'el select es diferente al de leer todas le pasamos la id de persona'
        For Each aux In col
            pa = New Pais(aux(4).ToString)
            p.IDPiloto = aux(1)
            p.Nombre = aux(2).ToString
            p.Apellido = aux(3).ToString
            p.PaisPiloto = pa
        Next
    End Sub
    Public Function Insertar(ByVal p As Piloto) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO pilotos (NombrePiloto,ApellidoPiloto,PaisPiloto) VALUES ('" & p.Nombre & "', '" & p.Apellido & "', '" & p.PaisPiloto.IDPais & "');")
    End Function

    Public Function Actualizar(ByVal p As Piloto) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE pilotos SET NombrePiloto='" & p.Nombre & "' WHERE IdPiloto='" & p.IDPiloto & "';")
    End Function

    Public Function Borrar(ByVal p As Piloto) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM pilotos WHERE IdPiloto='" & p.IDPiloto & "';")
    End Function

End Class