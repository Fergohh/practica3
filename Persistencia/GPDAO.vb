﻿Public Class GPDAO
    Public ReadOnly Property GPs As Collection 'personas es una variable de tipo colleción'

    Public Sub New()
        Me.GPs = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim p As GP
        Dim pa As Pais
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM gps ORDER BY IdGP") 'llamamos a obtenerAgente que como es shared no tenemos que crear el objeto agente'
        For Each aux In col 'aux es una coleccion que representa a cada elemento de col en el bucle'
            p = New GP(aux(1).ToString) 'el primer elemento( axu(1) ) es el ID'
            pa = New Pais(aux(3).ToString)
            p.denominacionGP = aux(2).ToString 'el segundo elemento( aux(2) ) es el nombre'
            p.PaisGP = pa
            Me.GPs.Add(p) 'add añade algo a una coleccion: añadimos la persona a la coleccion'
        Next 'dato importante: para acceder al id es 1 y nombre 2 no como en el reader que el primer elemento es 0 y el segundo 1'
    End Sub

    Public Sub Leer(ByRef p As GP) 'lo mismo que leer todas pero solo una persona la diferencia esta que como parametros pasamos una persona'
        Dim pa As Pais
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM gps WHERE IdGP='" & p.IDGP & "';") 'el select es diferente al de leer todas le pasamos la id de persona'
        For Each aux In col
            pa = New Pais(aux(3).ToString)
            p.DenominacionGP = aux(2).ToString
            p.PaisGP = pa
        Next
    End Sub

    Public Function Insertar(ByVal p As GP) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO gps (DenominacionGP, PaisGP) VALUES ('" & p.DenominacionGP & "', '" & p.PaisGP.IDPais & "');")
    End Function

    Public Function Actualizar(ByVal p As GP) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE gps SET DenominacionGP='" & p.DenominacionGP & "' WHERE IdGP='" & p.IDGP & "';")
    End Function

    Public Function Borrar(ByVal p As GP) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM gps WHERE IdGP='" & p.IDGP & "';")
    End Function

End Class
