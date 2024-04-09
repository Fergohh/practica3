Public Class EscuderiaDAO
    Public ReadOnly Property Escuderias As Collection 'personas es una variable de tipo colleción'

    Public Sub New()
        Me.Escuderias = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim p As Escuderia
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM PAISES ORDER BY IdPais") 'llamamos a obtenerAgente que como es shared no tenemos que crear el objeto agente'
        For Each aux In col 'aux es una coleccion que representa a cada elemento de col en el bucle'
            p = New Escuderia(aux(1).ToString) 'el primer elemento( axu(1) ) es el ID'
            p.Nombre = aux(2).ToString 'el segundo elemento( aux(2) ) es el nombre'
            p.PaisEscuderia = CInt(aux(3).ToString)
            p.FechaCrec = (aux(4).ToString)
            Me.Escuderias.Add(p) 'add añade algo a una coleccion: añadimos la persona a la coleccion'
        Next 'dato importante: para acceder al id es 1 y nombre 2 no como en el reader que el primer elemento es 0 y el segundo 1'
    End Sub

    Public Sub Leer(ByRef p As Escuderia) 'lo mismo que leer todas pero solo una persona la diferencia esta que como parametros pasamos una persona'
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM PAISES WHERE IdPais='" & p.IDEscuderia & "';") 'el select es diferente al de leer todas le pasamos la id de persona'
        For Each aux In col
            p.Nombre = aux(2).ToString
            p.PaisEscuderia = aux(3)
            p.FechaCrec = aux(4)
        Next
    End Sub

    Public Function Insertar(ByVal p As Escuderia) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO PAISES VALUES ('" & p.IDEscuderia & "', '" & p.Nombre & "', '" & p.FechaCrec & "');")
    End Function

    Public Function Actualizar(ByVal p As Escuderia) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE PAISES SET NombrePais='" & p.Nombre & "' WHERE IdPais='" & p.IDEscuderia & "';")
    End Function

    Public Function Borrar(ByVal p As Escuderia) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM PAISES WHERE IdPais='" & p.IDEscuderia & "';")
    End Function

End Class
