Public Class Calendario
    Public Property Temporada As Short ' SmallInt en SQL
    Public Property GP As GP
    Public Property Orden As Byte ' TinyInt en SQL

    Public ReadOnly Property CalendarioDAO As CalendarioDAO

    Public Sub New()
        Me.CalendarioDAO = New CalendarioDAO
    End Sub

    Public Sub New(ByVal temporada As Short, ByVal GP As GP)
        Me.Temporada = temporada
        Me.GP = GP
        Me.CalendarioDAO = New CalendarioDAO
    End Sub

    Public Sub LeerTodosCalendarios()
        Me.CalendarioDAO.LeerTodos()
    End Sub

    Public Sub LeerCalendario()
        Me.CalendarioDAO.Leer(Me)
    End Sub

    Public Function InsertarCalendario() As Integer
        Return Me.CalendarioDAO.Insertar(Me)
    End Function

    Public Function ActualizarCalendario() As Integer
        Return Me.CalendarioDAO.Actualizar(Me)
    End Function

    Public Function BorrarTodosLosCalendarios() As Integer
        Return Me.CalendarioDAO.BorrarTodos()
    End Function
End Class
