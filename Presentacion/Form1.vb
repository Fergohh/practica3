Imports System.Globalization
Imports System.Runtime.InteropServices.Marshalling
Imports System.Xml.XPath

Public Class Form1
    Dim p As Pais
    Dim pi As Piloto
    Dim es As Escuderia
    Dim G As GP
    Dim ca As Calendario
    Dim c As Carreras
    Dim con As Contrato
    Dim cla As Clasificacion

    Private temporada As Int32
    Private rnd As New Random()

    Private Sub Añadir_Click(sender As Object, e As EventArgs) Handles Añadir.Click
        If Me.txtID.Text <> String.Empty And Me.txtNombre.Text <> String.Empty And Me.txtID.Text.Length = 3 Then '<> significa !='
            Try
                p = New Pais
                p.IDPais = txtID.Text
                p.Nombre = txtNombre.Text
                p.Habitantes = txtHab.Text


                If p.InsertarPais() <> 1 Then
                    MessageBox.Show("INSERT return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub 'si hay algo raro que salte y vuelva a ejecutar'

            End Try
            Me.ListBox1.Items.Add(p.IDPais)
        End If
    End Sub

    Private Sub Actualizar_Click(sender As Object, e As EventArgs) Handles Actualizar.Click
        If Not p Is Nothing Then 'el p Is Nothing es como p == NULL, si le pones el Not delante seria p != NULL'
            p.IDPais = txtID.Text
            p.Nombre = txtNombre.Text
            p.Habitantes = txtHab.Text
            Try
                If p.ActualizarPais() <> 1 Then
                    MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub 'si hay algo raro que salte y vuelva a ejecutar'
            End Try
            MessageBox.Show(p.Nombre & " actualizado correctamente!")
        End If
    End Sub

    Private Sub Borrar_Click(sender As Object, e As EventArgs) Handles Borrar.Click
        If Not Me.p Is Nothing Then
            If MessageBox.Show("¿Estas seguro que quieres borrar?" & Me.p.IDPais & "?", "Por favor, confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    If Me.p.BorrarPersona() <> 1 Then
                        MessageBox.Show("DELETE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub 'si hay algo raro que salte y vuelva a ejecutar'
                End Try
                Me.ListBox1.Items.Remove(p.IDPais)
            End If
            Me.Limpiar.PerformClick() 'Hacer click'

        End If
    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        Me.txtID.Text = String.Empty
        Me.txtNombre.Text = String.Empty
        Me.txtHab.Text = String.Empty
        Me.txtID.Enabled = True
        Me.txtNombre.Enabled = True
        Me.txtHab.Enabled = True
        Me.txtID.ReadOnly = True
    End Sub

    Private Sub Conectar_Click(sender As Object, e As EventArgs) Handles Conectar.Click
        Dim Escuderias As New List(Of Escuderia)
        Dim GPs As New List(Of GP)
        Dim pAux As Pais
        Dim piAux As Piloto
        Dim EAux As Escuderia
        Dim GAux As GP
        Dim caAux As Calendario
        Dim cAux As Carreras
        Dim conAux As Contrato
        Me.p = New Pais
        Me.pi = New Piloto
        Me.es = New Escuderia
        Me.G = New GP
        Me.c = New Carreras
        Me.con = New Contrato
        Me.ca = New Calendario
        Me.Numeros_escuderias.Enabled = False
        Me.Numeros_GP.Enabled = False
        Try
            Me.p.LeerTodosPaises()
            Me.pi.LeerTodosPilotos()
            Me.es.LeerTodosEscuderias()
            Me.G.LeerTodosGPs()
            Me.ca.LeerTodosCalendarios()
            Me.c.LeerTodosCarreras()
            Me.con.LeerTodosContratos()

        Catch ex As Exception
            MessageBox.Show(ex.Message & " error primero", ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub 'si hay algo raro que salte y vuelva a ejecutar'
        End Try
        Try
            temporada = rnd.Next(1970, DateTime.Now.Year)
            Escuderias = generarRandomsEscuderias()
            Me.ListBox_Escuderia.Items.Clear()

            For Each escuderia In Escuderias
                Me.ListBox_Escuderia.Items.Add(escuderia.IDEscuderia)
            Next

            GPs = generarRandomsGPs()
            Me.ListBox_GP.Items.Clear()
            For Each gp In GPs
                Me.ListBox_GP.Items.Add(gp.IDGP)
            Next
            generarRandomContratos(Escuderias)
            Me.ListBox_Contratos.Items.Clear()
            For Each conAux In Me.con.ContratoDAO.Contratos
                Me.ListBox_Contratos.Items.Add(conAux.Escuderia.IDEscuderia) 'imprime el id de la persona en la lista con .Items.Add'
                Me.ListBox_HistorialEscuderia_Escuderia.Items.Add(conAux.Escuderia.IDEscuderia)
                Me.ListBox_HistorialPiloto_Piloto.Items.Add(conAux.Piloto1.IDPiloto)
                Me.ListBox_HistorialPiloto_Piloto.Items.Add(conAux.Piloto2.IDPiloto)
            Next
            Me.c.CarrerasDAO.BorrarTodos()
            generarRandomCalendarios(GPs)
            generarRandomCarreras(GPs)

        Catch ex As Exception
            MessageBox.Show("debes crear primero las escuderias, GPs, Pilotos y Paises", ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Conectar.Enabled = False
            Conectar.Visible = False
            Añadir.Enabled = True
            Me.Numeros_escuderias.Enabled = False
            Me.Numeros_GP.Enabled = False
            Me.Button_Valores.Visible = False
            Me.Button_Valores.Enabled = False
            Me.Label_Valores.Visible = False
            For Each pAux In Me.p.PaisDAO.Paises
                Me.ListBox1.Items.Add(pAux.IDPais) 'imprime el id de la persona en la lista con .Items.Add'
                Me.ComboBox_Pais_Piloto.Items.Add(pAux.IDPais)
                Me.ComboBox_Pais_Escuderia.Items.Add(pAux.IDPais)
                Me.ComboBox_GP_Pais.Items.Add(pAux.IDPais)
            Next
            Exit Sub 'si hay algo raro que salte y vuelva a ejecutar'
        End Try
        For Each pAux In Me.p.PaisDAO.Paises
            Me.ListBox1.Items.Add(pAux.IDPais) 'imprime el id de la persona en la lista con .Items.Add'
            Me.ComboBox_Pais_Piloto.Items.Add(pAux.IDPais)
            Me.ComboBox_Pais_Escuderia.Items.Add(pAux.IDPais)
            Me.ComboBox_GP_Pais.Items.Add(pAux.IDPais)
        Next
        For Each piAux In Me.pi.PilotoDAO.Pilotos
            Me.ListBox_Piloto.Items.Add(piAux.IDPiloto) 'imprime el id de la persona en la lista con .Items.Add'
        Next
        For Each EAux In Me.es.EscuderiaDAO.Escuderias
            Me.ListBox_Escuderia.Items.Add(EAux.IDEscuderia) 'imprime el id de la persona en la lista con .Items.Add'
        Next
        For Each GAux In Me.G.GPDAO.GPs
            Me.ListBox_GP.Items.Add(GAux.IDGP) 'imprime el id de la persona en la lista con .Items.Add'
        Next
        For Each caAux In Me.ca.CalendarioDAO.Calendarios
            Me.ListBox_Calendario.Items.Add(caAux.GP.IDGP) 'imprime el id de la persona en la lista con .Items.Add'
        Next
        For Each cAux In Me.c.CarrerasDAO.Carrera
            Me.ListBox_Carreras.Items.Add(cAux.Temporada) 'imprime el id de la persona en la lista con .Items.Add'
        Next

        Conectar.Enabled = False
        Conectar.Visible = False
        Añadir.Enabled = True
        VerClasificacionCarrera()

        Me.Numeros_escuderias.Enabled = False
        Me.Numeros_GP.Enabled = False
        Me.Button_Valores.Visible = False
        Me.Button_Valores.Enabled = False
        Me.Label_Valores.Visible = False


    End Sub

    Private Sub generarRandomContratos(escuderias As List(Of Escuderia))
        Me.con.ContratoDAO.BorrarTodos()

        Dim conAux As Contrato
        Dim i As Integer
        Dim numEscuderias As Integer
        Dim rnd As New Random()
        numEscuderias = escuderias.Count
        Dim Pilotos As New List(Of Piloto)
        Dim PAux As Piloto
        For Each PAux In Me.pi.PilotoDAO.Pilotos
            Pilotos.Add(PAux)
        Next
        MessageBox.Show(numEscuderias & "Este es el numero de escuderias")
        For i = 0 To numEscuderias - 1
            If Pilotos.Count < 2 Then
                MessageBox.Show("No hay suficientes pilotos para crear un nuevo contrato.")
                Exit Sub
            End If

            Dim randomPiloto1Index As Integer = rnd.Next(0, Pilotos.Count)
            Dim piloto1 As Piloto = Pilotos(randomPiloto1Index)
            Pilotos.RemoveAt(randomPiloto1Index)

            Dim randomPiloto2Index As Integer = rnd.Next(0, Pilotos.Count)
            Dim piloto2 As Piloto = Pilotos(randomPiloto2Index)
            Pilotos.RemoveAt(randomPiloto2Index)

            conAux = New Contrato With {
            .Escuderia = escuderias(i),
            .Temporada = temporada,
            .Piloto1 = piloto1,
            .Piloto2 = piloto2
            }
            Me.con.ContratoDAO.Contratos.Add(conAux)
            Me.con.ContratoDAO.Insertar(conAux)
        Next
    End Sub

    Private Sub generarRandomCarreras(GPs As List(Of GP))
        Me.c.CarrerasDAO.BorrarTodos()

        Dim rnd As New Random()
        Dim GPAux As GP
        Dim numContratos As Integer = Me.con.ContratoDAO.Contratos.Count
        Dim conAux As Contrato
        Dim numPilotos As Integer = 20
        Dim puntosPorPosicion As Integer() = {10, 6, 4, 3, 2, 1}
        Dim PosicionesFinal As New List(Of Integer)
        Dim j As Integer = 0

        For Each GPAux In GPs
            Dim carrera As New Carreras With {
            .Temporada = temporada,
            .GP = GPAux}
            For i = 0 To (numContratos * 2)
                PosicionesFinal.Add(i)
            Next
            PosicionesFinal.Sort(Function(x, y) rnd.Next(-1, 2))

            For Each conAux In Me.con.ContratoDAO.Contratos
                For y = 1 To 2
                    Dim posicion As Integer = PosicionesFinal.Item(j) ' Genera una posición aleatoria entre 1 y 6
                    Dim puntos As Integer = 0

                    If posicion <= 6 And posicion > 0 Then
                        puntos = puntosPorPosicion(posicion - 1)
                    ElseIf posicion = 0 Then
                        puntos = puntosPorPosicion(0)
                    Else
                        puntos = 0
                    End If

                    If y = 2 Then
                        carrera.Piloto = conAux.Piloto2
                    Else
                        carrera.Piloto = conAux.Piloto1
                    End If
                    carrera.Posicion = posicion
                    carrera.Puntos = puntos
                    j = j + 1
                    Me.c.CarrerasDAO.Carrera.Add(carrera)
                    Me.c.CarrerasDAO.Insertar(carrera)
                Next


            Next
            PosicionesFinal.Clear()
            j = 0


        Next
    End Sub

    Private Sub generarRandomCalendarios(GPs As List(Of GP))
        Me.ca.CalendarioDAO.BorrarTodos()

        Dim calen As Calendario
        Dim i As Integer = 1
        Dim GPAux As GP
        For Each GPAux In GPs

            calen = New Calendario With {
            .Temporada = temporada,
            .GP = GPAux,
            .Orden = i
            }

            Me.ca.CalendarioDAO.Calendarios.Add(calen)
            i += 1
            Me.ca.CalendarioDAO.Insertar(calen)

        Next
    End Sub

    Private Sub Clasificacion()


        Dim calen As Calendario
        Dim i As Integer = 1
        Dim carrAux As Carreras
        For Each carrAux In Me.c.CarrerasDAO.Carrera


        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Me.Actualizar.Enabled = True
        Me.Borrar.Enabled = True
        Me.txtID.Enabled = False
        If Not Me.ListBox1.SelectedItem Is Nothing Then
            Me.p = New Pais(Me.ListBox1.SelectedItem.ToString) 'para obtener un elemento de la listaBox'
            Try
                Me.p.LeerPais()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub 'si hay algo raro que salte y vuelva a ejecutar'
            End Try
            Me.txtID.Text = Me.p.IDPais.ToString
            Me.txtNombre.Text = Me.p.Nombre.ToString
            Me.txtHab.Text = Me.p.Habitantes.ToString
        End If
    End Sub

    Private Sub Añadir_Piloto_Click(sender As Object, e As EventArgs) Handles Añadir_Piloto.Click
        If Me.TextBox_Nombre_Piloto.Text <> String.Empty And Me.TextBox_Apellido_Piloto.Text <> String.Empty And ComboBox_Pais_Piloto.SelectedItem <> String.Empty Then '<> significa !='
            Try
                Dim pa As Pais

                pi = New Piloto
                pa = New Pais(ComboBox_Pais_Piloto.SelectedItem.ToString)
                pa.LeerPais()
                pi.PaisPiloto = pa
                pi.Nombre = TextBox_Nombre_Piloto.Text
                pi.Apellido = TextBox_Apellido_Piloto.Text


                If pi.InsertarPilotos <> 1 Then
                    MessageBox.Show("INSERT return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub 'si hay algo raro que salte y vuelva a ejecutar'

            End Try
            ListBox_Piloto.Items.Clear()
            Dim piAux As Piloto
            pi.LeerTodosPilotos()
            For Each piAux In Me.pi.PilotoDAO.Pilotos
                Me.ListBox_Piloto.Items.Add(piAux.IDPiloto) 'imprime el id de la persona en la lista con .Items.Add'
            Next
        End If
    End Sub

    Private Sub Actualizar_Piloto_Click(sender As Object, e As EventArgs) Handles Actualizar_Piloto.Click
        If Not pi Is Nothing Then 'el p Is Nothing es como p == NULL, si le pones el Not delante seria p != NULL'
            pi.Nombre = TextBox_Nombre_Piloto.Text
            pi.Apellido = TextBox_Apellido_Piloto.Text
            Try
                If pi.ActualizarPilotos() <> 1 Then
                    MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub 'si hay algo raro que salte y vuelva a ejecutar'
            End Try
            MessageBox.Show(pi.Nombre & " actualizado correctamente!")
        End If
    End Sub

    Private Sub Borrar_Piloto_Click(sender As Object, e As EventArgs) Handles Borrar_Piloto.Click
        If Not Me.pi Is Nothing Then
            If MessageBox.Show("¿Estas seguro que quieres borrar?" & Me.pi.IDPiloto & "?", "Por favor, confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    If Me.pi.BorrarPilotos() <> 1 Then
                        MessageBox.Show("DELETE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub 'si hay algo raro que salte y vuelva a ejecutar'
                End Try
                Me.ListBox_Piloto.Items.Remove(pi.IDPiloto)
            End If
            Me.Limpiar_Piloto.PerformClick() 'Hacer click'

        End If
    End Sub

    Private Sub Limpiar_Piloto_Click(sender As Object, e As EventArgs) Handles Limpiar_Piloto.Click
        Me.TextBox_ID_Piloto.Text = String.Empty
        Me.ComboBox_Pais_Piloto.SelectedIndex = -1
        Me.TextBox_ID_Piloto.Enabled = True
        Me.ComboBox_Pais_Piloto.Enabled = True
        Me.TextBox_Nombre_Piloto.Text = String.Empty
        Me.TextBox_Apellido_Piloto.Text = String.Empty
        Me.TextBox_Nombre_Piloto.Enabled = True
        Me.TextBox_Apellido_Piloto.Enabled = True

    End Sub


    Private Sub ListBox_Piloto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_Piloto.SelectedIndexChanged
        Me.Actualizar_Piloto.Enabled = True
        Me.Borrar_Piloto.Enabled = True
        Me.TextBox_ID_Piloto.Enabled = False
        Me.ComboBox_Pais_Piloto.Enabled = False
        Me.TextBox_Nombre_Piloto.Enabled = True

        Me.TextBox_Apellido_Piloto.Enabled = True
        If Not Me.ListBox_Piloto.SelectedItem Is Nothing Then
            Me.pi = New Piloto(Me.ListBox_Piloto.SelectedItem.ToString) 'para obtener un elemento de la listaBox'
            Try
                Me.pi.LeerPilotos()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub 'si hay algo raro que salte y vuelva a ejecutar'
            End Try
            Me.TextBox_ID_Piloto.Text = Me.pi.IDPiloto.ToString
            Me.ComboBox_Pais_Piloto.SelectedItem = Me.pi.PaisPiloto.IDPais
            Me.TextBox_Nombre_Piloto.Text = Me.pi.Nombre.ToString
            Me.TextBox_Apellido_Piloto.Text = Me.pi.Apellido.ToString


        End If
    End Sub

    Private Sub ListBox_Escuderia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_Escuderia.SelectedIndexChanged
        Me.Actualizar_Escuderia.Enabled = True
        Me.Borrar_Escuderia.Enabled = True
        Me.TextBox_ID_Escuderia.Enabled = False
        Me.TextBox_Nombre_Escuderia.Enabled = True
        Me.ComboBox_Pais_Escuderia.Enabled = False
        Me.DateTimePicker_Escuderia.Enabled = False
        If Not Me.ListBox_Escuderia.SelectedItem Is Nothing Then
            Me.es = New Escuderia(Me.ListBox_Escuderia.SelectedItem.ToString) 'para obtener un elemento de la listaBox'
            Try
                Me.es.LeerEscuderia()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub 'si hay algo raro que salte y vuelva a ejecutar'
            End Try
            Me.TextBox_ID_Escuderia.Text = Me.es.IDEscuderia.ToString
            Me.DateTimePicker_Escuderia.Value = Me.es.FechaCrec
            Me.ComboBox_Pais_Escuderia.SelectedItem = Me.es.PaisEscuderia.IDPais
            Me.TextBox_Nombre_Escuderia.Text = Me.es.Nombre.ToString
        End If
    End Sub

    Private Sub Añadir_Escuderia_Click(sender As Object, a As EventArgs) Handles Añadir_Escuderia.Click
        If TextBox_Nombre_Escuderia.Text <> String.Empty And ComboBox_Pais_Escuderia.Text <> String.Empty Then '<> significa !='
            Dim pa As Pais
            Try
                es = New Escuderia
                pa = New Pais(ComboBox_Pais_Escuderia.SelectedItem)
                pa.LeerPais()
                es.PaisEscuderia = pa
                es.Nombre = TextBox_Nombre_Escuderia.Text
                es.FechaCrec = DateTimePicker_Escuderia.Value.ToString("yyyy-MM-dd")
                If es.InsertarEscuderia <> 1 Then
                    MessageBox.Show("INSERT return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub 'si hay algo raro que salte y vuelva a ejecutar'

            End Try
            ListBox_Escuderia.Items.Clear()
            Dim esAux As Escuderia
            es.LeerTodosEscuderias()
            For Each esAux In Me.es.EscuderiaDAO.Escuderias
                Me.ListBox_Escuderia.Items.Add(esAux.IDEscuderia) 'imprime el id de la persona en la lista con .Items.Add'
            Next
        End If
    End Sub

    Private Sub Actualizar_Escuderia_Click(sender As Object, e As EventArgs) Handles Actualizar_Escuderia.Click
        If Not es Is Nothing Then 'el p Is Nothing es como p == NULL, si le pones el Not delante seria p != NULL'
            es.Nombre = TextBox_Nombre_Escuderia.Text
            es.FechaCrec = DateTimePicker_Escuderia.Value.ToString("yyyy-MM-dd")
            Try
                If es.ActualizarEscuderia() <> 1 Then
                    MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub 'si hay algo raro que salte y vuelva a ejecutar'
            End Try
            MessageBox.Show(G.DenominacionGP & " actualizado correctamente!")
        End If
    End Sub

    Private Sub Borrar_Escuderia_Click(sender As Object, e As EventArgs) Handles Borrar_Escuderia.Click
        If Not Me.es Is Nothing Then
            If MessageBox.Show("¿Estas seguro que quieres borrar?" & Me.es.IDEscuderia & "?", "Por favor, confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    If Me.es.BorrarEscuderia() <> 1 Then
                        MessageBox.Show("DELETE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub 'si hay algo raro que salte y vuelva a ejecutar'
                End Try
                Me.ListBox_Escuderia.Items.Remove(es.IDEscuderia)
            End If
            Me.Limpiar_Escuderia.PerformClick() 'Hacer click'

        End If
    End Sub
    Private Sub Limpiar_Escuderia_Click(sender As Object, e As EventArgs) Handles Limpiar_Escuderia.Click
        TextBox_ID_Escuderia.Text = String.Empty
        ComboBox_Pais_Escuderia.SelectedIndex = -1
        TextBox_Nombre_Escuderia.Text = String.Empty
        DateTimePicker_Escuderia.Value = Date.Today
        TextBox_ID_Escuderia.Enabled = True
        ComboBox_Pais_Escuderia.Enabled = True
        TextBox_Nombre_Escuderia.Enabled = True
        DateTimePicker_Escuderia.Enabled = True
    End Sub


    Private Sub ListBox_GP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_GP.SelectedIndexChanged
        Me.Actualizar_Piloto.Enabled = True
        Me.Borrar_Piloto.Enabled = True
        Me.TextBox_GP_ID.Enabled = False
        Me.ComboBox_GP_Pais.Enabled = False
        Me.TextBox_GP_Denominacion.Enabled = True

        If Not Me.ListBox_GP.SelectedItem Is Nothing Then
            Me.G = New GP(Me.ListBox_GP.SelectedItem.ToString) 'para obtener un elemento de la listaBox'
            Try
                Me.G.LeerGP()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub 'si hay algo raro que salte y vuelva a ejecutar'
            End Try
            Me.TextBox_GP_ID.Text = Me.G.IDGP.ToString
            Me.ComboBox_GP_Pais.SelectedItem = Me.G.PaisGP.IDPais
            Me.TextBox_GP_Denominacion.Text = Me.G.DenominacionGP.ToString


        End If
    End Sub


    Private Sub Añadir_GP_Click(sender As Object, e As EventArgs) Handles Añadir_GP.Click
        If Me.TextBox_GP_Denominacion.Text <> String.Empty And ComboBox_GP_Pais.SelectedItem <> String.Empty Then '<> significa !='
            Dim pa As Pais
            Try
                G = New GP
                pa = New Pais(ComboBox_GP_Pais.SelectedItem)
                pa.LeerPais()
                G.PaisGP = pa
                G.DenominacionGP = TextBox_GP_Denominacion.Text


                If G.InsertarGP <> 1 Then
                    MessageBox.Show("INSERT return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub 'si hay algo raro que salte y vuelva a ejecutar'

            End Try
            ListBox_GP.Items.Clear()
            Dim GAux As GP
            G.LeerTodosGPs()
            For Each GAux In Me.G.GPDAO.GPs
                Me.ListBox_GP.Items.Add(GAux.IDGP) 'imprime el id de la persona en la lista con .Items.Add'
            Next
        End If
    End Sub


    Private Sub Actualizar_GP_Click(sender As Object, e As EventArgs) Handles Actualizar_GP.Click
        If Not G Is Nothing Then 'el p Is Nothing es como p == NULL, si le pones el Not delante seria p != NULL'
            G.DenominacionGP = TextBox_GP_Denominacion.Text

            Try
                If G.ActualizarGP() <> 1 Then
                    MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub 'si hay algo raro que salte y vuelva a ejecutar'
            End Try
            MessageBox.Show(G.DenominacionGP & " actualizado correctamente!")
        End If
    End Sub

    Private Sub Borrar_GP_Click(sender As Object, e As EventArgs) Handles Borrar_GP.Click
        If Not Me.G Is Nothing Then
            If MessageBox.Show("¿Estas seguro que quieres borrar?" & Me.G.IDGP & "?", "Por favor, confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    If Me.G.BorrarGP() <> 1 Then
                        MessageBox.Show("DELETE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub 'si hay algo raro que salte y vuelva a ejecutar'
                End Try
                Me.ListBox_GP.Items.Remove(G.IDGP)
            End If

            Me.Limpiar_GP.PerformClick() 'Hacer click'
        End If
    End Sub


    Private Sub Limpiar_GP_Click(sender As Object, e As EventArgs) Handles Limpiar_GP.Click
        Me.TextBox_GP_ID.Text = String.Empty
        Me.ComboBox_GP_Pais.SelectedIndex = -1
        Me.TextBox_GP_Denominacion.Text = String.Empty
        Me.ComboBox_GP_Pais.Enabled = True
        Me.TextBox_GP_Denominacion.Enabled = True

    End Sub

    Private Sub ListBox_Calendario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_Calendario.SelectedIndexChanged
        If Not Me.ListBox_Calendario.SelectedItem Is Nothing Then
            Dim gp As New GP(Me.ListBox_Calendario.SelectedItem.ToString)
            gp.LeerGP()
            Me.ca = New Calendario(temporada, gp) 'para obtener un elemento de la listaBox'
            Try
                Me.ca.LeerCalendario()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub 'si hay algo raro que salte y vuelva a ejecutar'
            End Try
            Me.TextBox_GP_Calendario.Text = Me.ca.Temporada.ToString
            Me.TextBox_Orden_Calendario.Text = Me.ca.Orden.ToString


        End If
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        Dim txt As String
        txt = txtNombre.Text

        If txt <> String.Empty And txt.Length > 2 Then
            txtID.Text = txt.Substring(0, 3).ToUpper

            For Each pAux In Me.p.PaisDAO.Paises
                If pAux.IDPais = txtID.Text Then
                    txtID.ReadOnly = False
                Else
                    txtID.ReadOnly = True
                End If
            Next
        End If
    End Sub

    Public Function generarRandomsEscuderias() As List(Of Escuderia)
        Dim EAux As Escuderia
        Me.es = New Escuderia
        Dim EscuderiasRandom As New List(Of Escuderia)
        Dim EscuderiasFinal As New List(Of Escuderia)
        Try

            es.LeerTodosEscuderias()

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try 'si hay algo raro que salte y vuelva a ejecutar'
        For Each EAux In Me.es.EscuderiaDAO.Escuderias
            EscuderiasRandom.Add(EAux)
        Next
        Dim rnd As New Random()
        Dim numElementos As Integer
        ' Comparador personalizado para el método Sort que genera un orden aleatorio
        Dim comparador As New Comparison(Of Escuderia)(Function(x, y) rnd.Next(-1, 2))

        ' Aplicar el comparador para desordenar la lista
        EscuderiasRandom.Sort(comparador)

        If (Numeros_escuderias.Value = 0) Then
            numElementos = rnd.NextInt64(10, 21)
        Else
            numElementos = Numeros_escuderias.Value
        End If


        While EscuderiasFinal.Count < numElementos
            Dim randomIndex As Integer = rnd.Next(0, EscuderiasRandom.Count)
            EscuderiasFinal.Add(EscuderiasRandom(randomIndex))
            EscuderiasRandom.RemoveAt(randomIndex)
        End While

        Return EscuderiasFinal

    End Function

    Public Function generarRandomsGPs() As List(Of GP)
        Dim GPAux As GP
        Me.G = New GP
        Dim GPRandom As New List(Of GP)
        Dim GPFinal As New List(Of GP)
        Try

            G.LeerTodosGPs()

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try 'si hay algo raro que salte y vuelva a ejecutar'
        For Each GPAux In Me.G.GPDAO.GPs
            GPRandom.Add(GPAux)
        Next
        Dim rnd As New Random()
        Dim numElementos As Integer
        ' Comparador personalizado para el método Sort que genera un orden aleatorio
        Dim comparador As New Comparison(Of GP)(Function(x, y) rnd.Next(-1, 2))

        ' Aplicar el comparador para desordenar la lista
        GPRandom.Sort(comparador)

        If (Numeros_GP.Enabled = False) Then
            numElementos = rnd.NextInt64(10, 21)
        Else
            numElementos = Numeros_GP.Value
        End If

        While GPFinal.Count < numElementos
            Dim randomIndex As Integer = rnd.Next(0, GPRandom.Count)
            GPFinal.Add(GPRandom(randomIndex))
            GPRandom.RemoveAt(randomIndex)
        End While

        Return GPFinal

    End Function


    Private Sub Button_Valores_Click(sender As Object, e As EventArgs) Handles Button_Valores.Click
        Me.Numeros_escuderias.Enabled = True
        Me.Numeros_GP.Enabled = True
        Me.Button_Valores.Enabled = False

    End Sub

    Private Sub ListBox_Contratos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_Contratos.SelectedIndexChanged
        If Not Me.ListBox_Contratos.SelectedItem Is Nothing Then
            Dim esc As Escuderia
            esc = New Escuderia(Me.ListBox_Contratos.SelectedItem.ToString)
            esc.LeerEscuderia()
            Me.con = New Contrato(esc, Me.temporada) 'para obtener un elemento de la listaBox'
            Try
                Me.con.LeerContrato()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub 'si hay algo raro que salte y vuelva a ejecutar'
            End Try
            Me.textBox_Contratos_Escuderia.Text = Me.con.Escuderia.IDEscuderia.ToString
            Me.textBox_Contratos_Temporada.Text = Me.temporada.ToString
            Me.textBox_Contratos_Piloto1.Text = Me.con.Piloto1.IDPiloto.ToString
            Me.textBox_Contratos_Piloto2.Text = Me.con.Piloto2.IDPiloto.ToString
        End If
    End Sub

    Public Sub GenerarInformeFinal()
        Dim piAux As Piloto
        Dim puntos As List(Of KeyValuePair(Of Integer, Piloto)) = New List(Of KeyValuePair(Of Integer, Piloto))
        Dim puntosPiloto As Integer = 0
        Dim carrera As Carreras
        For Each carrera In Me.c.CarrerasDAO.Carrera
            piAux = New Piloto(carrera.Piloto.IDPiloto)
            piAux.LeerPilotos()

            Dim kvp As KeyValuePair(Of Integer, Piloto) = New KeyValuePair(Of Integer, Piloto)(puntosPiloto, piAux)
            puntos.Add(kvp)
        Next

        puntos.Sort(Function(x, y) x.Key.CompareTo(y.Key))
        puntos.Reverse()

        Dim valores As KeyValuePair(Of Integer, Piloto)

        For Each valores In puntos
            ListBox_Clasificacion_Pilotos.Items.Add(valores)
        Next

    End Sub


    Private Sub ListBox_HistorialEscuderia_Escuderia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_HistorialEscuderia_Escuderia.SelectedIndexChanged
        ListBox_HistorialEscuderia_Piloto.Items.Clear()

        If Not Me.ListBox_HistorialEscuderia_Escuderia.SelectedItem Is Nothing Then
            Me.es = New Escuderia(Me.ListBox_HistorialEscuderia_Escuderia.SelectedItem.ToString) 'para obtener un elemento de la listaBox'
            Dim contrato As Contrato

            For Each contrato In Me.con.ContratoDAO.Contratos
                If contrato.Escuderia.IDEscuderia = Me.es.IDEscuderia Then
                    Me.ListBox_HistorialEscuderia_Piloto.Items.Add(contrato.Piloto1.IDPiloto)
                    Me.ListBox_HistorialEscuderia_Piloto.Items.Add(contrato.Piloto2.IDPiloto)
                End If
            Next



        End If
    End Sub

    Private Sub ListBox_HistorialEscuderia_Piloto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_HistorialEscuderia_Piloto.SelectedIndexChanged
        If Not Me.ListBox_HistorialEscuderia_Piloto.SelectedItem Is Nothing Then
            Me.pi = New Piloto(Me.ListBox_HistorialEscuderia_Piloto.SelectedItem.ToString)
            Dim fechainicio As Integer = DateTimePicker_HistorialEscuderia_Inicio.Value.Year
            Dim fechafin As Integer = DateTimePicker_HistorialEscuderia_Final.Value.Year
            Dim carreras As Collection = New Collection
            Dim carrera As Carreras
            Dim puntos As Integer = 0

            For Each carrera In Me.c.CarrerasDAO.Carrera
                If carrera.Piloto.IDPiloto = Me.pi.IDPiloto And carrera.Temporada >= fechainicio And carrera.Temporada <= fechafin Then
                    carreras.Add(carrera)
                    puntos += carrera.Puntos
                End If
            Next

            TextBox_HistorialEscuderia_Puntos.Text = puntos
        End If
    End Sub

    Private Sub ListBox_HistorialPiloto_Piloto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_HistorialPiloto_Piloto.SelectedIndexChanged

        Dim pi As Piloto
        Dim caAux As Carreras
        Dim gp As GP
        Dim ca As Carreras
        If Not Me.ListBox_HistorialPiloto_Piloto.SelectedItem Is Nothing Then
            Me.ListBox_HistorialPiloto_Carreras.Items.Clear()
            pi = New Piloto(Me.ListBox_HistorialPiloto_Piloto.SelectedItem.ToString)

            For Each caAux In Me.c.CarrerasDAO.Carrera

                If pi.IDPiloto = caAux.Piloto.IDPiloto Then
                    Me.ListBox_HistorialPiloto_Carreras.Items.Add(caAux.GP.IDGP)
                End If
            Next
            Me.TextBox_HistorialPiloto_GP.Text = String.Empty
            Me.TextBox_HistorialPiloto_Posicion.Text = String.Empty
            Me.TextBox_HistorialPiloto_Puntos.Text = String.Empty
        End If
    End Sub

    Private Sub ListBox_HistorialPiloto_Carreras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_HistorialPiloto_Carreras.SelectedIndexChanged
        If Not Me.ListBox_HistorialPiloto_Carreras.SelectedItem Is Nothing Then
            Dim gp = New GP(Me.ListBox_HistorialPiloto_Carreras.SelectedItem.ToString)
            Dim ca As Carreras
            Dim pi = New Piloto(Me.ListBox_HistorialPiloto_Piloto.SelectedItem.ToString)
            Try
                gp.LeerGP()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            ca = New Carreras(temporada, gp, pi)
            ca.LeerCarrera()
            Me.TextBox_HistorialPiloto_GP.Text = gp.DenominacionGP
            Me.TextBox_HistorialPiloto_Posicion.Text = ca.Posicion.ToString
            Me.TextBox_HistorialPiloto_Puntos.Text = ca.Puntos.ToString
        End If
    End Sub

    Private Sub VerClasificacionCarrera()
        Dim clasifica As Clasificacion
        Dim claAux As Clasificacion
        Dim piloto As Piloto
        Dim escuderia As Escuderia
        clasifica = New Clasificacion(temporada)
        clasifica.ConseguirClasificacionPilotos()
        clasifica.ConseguirClasificacionEscuderias()

        Try
            For Each claAux In clasifica.ClasificacionDAO.ClasificacionesPilotos

                piloto = claAux.Piloto
                piloto.LeerPilotos()
                ListBox_Clasificacion_Pilotos.Items.Add(piloto.Nombre)
            Next

            For Each claAux In clasifica.ClasificacionDAO.ClasificacionesEscuderias

                escuderia = claAux.Escuderia
                escuderia.LeerEscuderia()
                ListBox_Clasificacion_Escuderias.Items.Add(escuderia.Nombre)
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try



    End Sub


    Private Sub EliminarInfoDeUnaTemporada()
        Me.con.BorrarTodosLoscontratos()
        Me.c.BorrarTodasLasCarreras()
        Me.ca.BorrarTodosLosCalendarios()

    End Sub

    Private Sub ListBox_Clasificacion_Pilotos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_Clasificacion_Pilotos.SelectedIndexChanged
        If Not Me.ListBox_Clasificacion_Pilotos.SelectedItem Is Nothing Then

        End If
    End Sub

    Private Sub ListBox_Clasificacion_Escuderias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_Clasificacion_Escuderias.SelectedIndexChanged
        If Not Me.ListBox_Clasificacion_Escuderias.SelectedItem Is Nothing Then

        End If
    End Sub


End Class
