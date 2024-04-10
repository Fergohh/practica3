Public Class EscuderiaDAO
    Public ReadOnly Property GPs As Collection 'personas es una variable de tipo colleción'

    Public Sub New()
        Me.GPs = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim p As GP
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM escuderias ORDER BY IdEscuderia") 'llamamos a obtenerAgente que como es shared no tenemos que crear el objeto agente'
        For Each aux In col 'aux es una coleccion que representa a cada elemento de col en el bucle'
            p = New GP(aux(1).ToString) 'el primer elemento( axu(1) ) es el ID'
            p.denominacionGP = aux(2).ToString 'el segundo elemento( aux(2) ) es el nombre'
            p.PaisGP = aux(3).ToString
            Me.GPs.Add(p) 'add añade algo a una coleccion: añadimos la persona a la coleccion'
        Next 'dato importante: para acceder al id es 1 y nombre 2 no como en el reader que el primer elemento es 0 y el segundo 1'
    End Sub

    Public Sub Leer(ByRef p As GP) 'lo mismo que leer todas pero solo una persona la diferencia esta que como parametros pasamos una persona'
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM escuderias WHERE IdEscuderia='" & p.IDGP & "';") 'el select es diferente al de leer todas le pasamos la id de persona'
        For Each aux In col
            p.denominacionGP = aux(2).ToString
            p.PaisGP = aux(3).ToString
        Next
    End Sub

    Public Function Insertar(ByVal p As GP) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO escuderias VALUES ('" & p.IDGP & "', '" & p.denominacionGP & "', '" & p.PaisGP & "'from PILOTOS(nombre,apellido,pais)from PILOTOS(nombre,apellido,pais)from PILOTOS(nombre,apelliis));")
    End Function

    Public Function Actualizar(ByVal p As GP) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE escuderias SET NombreEscuderia='" & p.denominacionGP & "' WHERE IdEscuderia='" & p.IDGP & "';")
    End Function

    Public Function Borrar(ByVal p As GP) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM escuderias WHERE IdEscuderia='" & p.IDGP & "';")
    End Function

End Class
