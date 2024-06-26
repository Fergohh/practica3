﻿Public Class PaisDAO

    Public ReadOnly Property Paises As Collection

    Public Sub New()
        Me.Paises = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim p As Pais
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM paises ORDER BY IdPais")
        For Each aux In col
            p = New Pais(aux(1).ToString)
            p.Nombre = aux(2).ToString
            p.Habitantes = aux(3).ToString
            Me.Paises.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As Pais)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM paises WHERE IdPais='" & p.IDPais & "';")
        For Each aux In col
            p.Nombre = aux(2).ToString
            p.Habitantes = aux(3).ToString
            Me.Paises.Add(p)
        Next
    End Sub

    Public Function Insertar(ByVal p As Pais) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO paises VALUES ('" & p.IDPais & "', '" & p.Nombre & "', '" & p.Habitantes & "');")
    End Function

    Public Function Actualizar(ByVal p As Pais) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE paises SET NombrePais = '" & p.Nombre & "', HabitantesPais = '" & p.Habitantes & "' WHERE (`IdPais` = '" & p.IDPais & "');")
    End Function


    Public Function Borrar(ByVal p As Pais) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM paises WHERE IdPais='" & p.IDPais & "';")
    End Function

End Class
