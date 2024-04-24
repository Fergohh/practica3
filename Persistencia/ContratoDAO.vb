Public Class ContratoDAO

    Public ReadOnly Property Contratos As Collection 'personas es una variable de tipo colleción'

    Public Sub New()
        Me.Contratos = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim p As Contrato
        Dim es As Escuderia
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM contratos ORDER BY Escuderia") 'llamamos a obtenerAgente que como es shared no tenemos que crear el objeto agente'
        For Each aux In col 'aux es una coleccion que representa a cada elemento de col en el bucle'
            es = New Escuderia(aux(1).ToString)
            p = New Contrato(es, aux(2).ToString) 'el primer elemento( axu(1) ) es el ID'
            p.Piloto1 = aux(3)
            p.Piloto2 = aux(4)
            Me.Contratos.Add(p) 'add añade algo a una coleccion: añadimos la persona a la coleccion'
        Next 'dato importante: para acceder al id es 1 y nombre 2 no como en el reader que el primer elemento es 0 y el segundo 1'
    End Sub

    Public Sub Leer(ByRef p As Contrato) 'lo mismo que leer todas pero solo una persona la diferencia esta que como parametros pasamos una persona'
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM contratos WHERE Escuderia='" & p.Escuderia.IDEscuderia & "';") 'el select es diferente al de leer todas le pasamos la id de persona'
        For Each aux In col
            p.Temporada = aux(2)
            p.Piloto1 = aux(3)
            p.Piloto2 = aux(4)

        Next
    End Sub

    Public Function Insertar(ByVal p As Contrato) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO contratos VALUES ('" & p.Escuderia.IDEscuderia & "', '" & p.Temporada & "', '" & p.Piloto1.IDPiloto & "', '" & p.Piloto2.IDPiloto & "');")
    End Function


    Public Function Borrar(ByVal p As Contrato) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM contratos WHERE Escuderia='" & p.Escuderia.IDEscuderia & "';")
    End Function

    Public Function BorrarTodos() As Integer
        Contratos.Clear()
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM contratos;")
    End Function

End Class
