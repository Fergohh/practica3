Imports Microsoft.VisualBasic

Public Class CarreraDAO
    Public ReadOnly Property Carreras As Collection 'personas es una variable de tipo colleción'

    Public Sub New()
        Me.Carreras = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim p As Carrera
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM carreras ORDER BY Temporada") 'llamamos a obtenerAgente que como es shared no tenemos que crear el objeto agente'
        For Each aux In col 'aux es una coleccion que representa a cada elemento de col en el bucle'
            p = New Escuderia(aux(1).ToString, aux(2).ToString, aux(3).ToString) 'el primer elemento( axu(1) ) es el ID'
            p.Posicion = (aux(4).ToString)
            p.puntos = (aux(5).ToString)
            Me.Carreras.Add(p) 'add añade algo a una coleccion: añadimos la persona a la coleccion'
        Next 'dato importante: para acceder al id es 1 y nombre 2 no como en el reader que el primer elemento es 0 y el segundo 1'
    End Sub

    Public Sub Leer(ByRef p As Carrera) 'lo mismo que leer todas pero solo una persona la diferencia esta que como parametros pasamos una persona'
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM carreras WHERE Temporada='" & p.Temporada & "';") 'el select es diferente al de leer todas le pasamos la id de persona'
        For Each aux In col
            p.Nombre = aux(2).ToString
            p.PaisEscuderia = aux(3)
            p.FechaCrec = aux(4)
        Next
    End Sub

    Public Function Insertar(ByVal p As Carrera) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO carreras (NombreEscuderia,PaisEscuderia,FechaCreacion) VALUES ('" & p.Nombre & "', '" & p.PaisEscuderia & "', '" & p.FechaCrec.ToString("yyyy-MM-dd") & "');")
    End Function


    Public Function Borrar(ByVal p As Carrera) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM carreras WHERE Temporada='" & p.Temporada & "';")
    End Function
End Class
