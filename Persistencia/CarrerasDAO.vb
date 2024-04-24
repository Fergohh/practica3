Public Class CarrerasDAO

    Public ReadOnly Property Carrera As Collection 'personas es una variable de tipo colleción'

    Public Sub New()
        Me.Carrera = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim p As Carreras
        Dim pi As Piloto
        Dim gp As GP
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM carreras ORDER BY Temporada") 'llamamos a obtenerAgente que como es shared no tenemos que crear el objeto agente'
        For Each aux In col 'aux es una coleccion que representa a cada elemento de col en el bucle'
            pi = New Piloto(aux(3).ToString)
            gp = New GP(aux(2).ToString)
            p = New Carreras(aux(1).ToString, gp, pi) 'el primer elemento( axu(1) ) es el ID'
            p.Posicion = (aux(4).ToString)
            p.Puntos = (aux(5).ToString)
            Me.Carrera.Add(p) 'add añade algo a una coleccion: añadimos la persona a la coleccion'
        Next 'dato importante: para acceder al id es 1 y nombre 2 no como en el reader que el primer elemento es 0 y el segundo 1'
    End Sub

    Public Sub Leer(ByRef p As Carreras) 'lo mismo que leer todas pero solo una persona la diferencia esta que como parametros pasamos una persona'
        Dim col As Collection : Dim aux As Collection
        Dim pi As Piloto
        Dim gp As GP
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM carreras WHERE Temporada='" & p.Temporada & "';") 'el select es diferente al de leer todas le pasamos la id de persona'
        For Each aux In col
            gp = New GP(aux(2).ToString)
            pi = New Piloto(aux(3).ToString)
            p.GP = gp
            p.Piloto = pi
            p.Posicion = aux(4)
            p.Puntos = aux(5)
        Next
    End Sub

    Public Function Insertar(ByVal p As Carreras) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO carreras VALUES ('" & p.Temporada & "', '" & p.GP.IDGP & "', '" & p.Piloto.IDPiloto & "', '" & p.Posicion & "', '" & p.Puntos & "');")
    End Function


    Public Function Borrar(ByVal p As Carreras) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM carreras WHERE Temporada='" & p.Temporada & "';")
    End Function

    Public Function BorrarTodos() As Integer
        Carrera.Clear()
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM carreras;")
    End Function
End Class
