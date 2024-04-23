Public Class Form1
    Dim p As Pais
    Dim pi As Piloto
    Dim es As Escuderia
    Dim G As GP
    Dim ca As Calendario
    Dim c As Carreras
    Dim con As Contrato
    Private Sub Añadir_Click(sender As Object, e As EventArgs) Handles Añadir.Click
        If Me.txtID.Text <> String.Empty And Me.txtNombre.Text <> String.Empty And Me.txtID.Text.Length = 3 Then '<> significa !='
            Try
                p = New Pais
                p.IDPais = txtID.Text
                p.Nombre = txtNombre.Text
                p.Habitantes = txtHab.Text


                If p.InsertarPersona() <> 1 Then
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
                If p.ActualizarPersona() <> 1 Then
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
        generarRandomsEscuderias()
        generarRandomContratos()
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
            Me.p.LeerTodasPersonas()
            Me.pi.LeerTodosPilotos()
            Me.es.LeerTodosEscuderias()
            Me.G.LeerTodosGPs()
            Me.ca.LeerTodosCalendarios()
            Me.c.LeerTodosCarreras()
            Me.con.LeerTodosContratos()

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub 'si hay algo raro que salte y vuelva a ejecutar'
        End Try
        For Each pAux In Me.p.PerDAO.Personas
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
            Me.ListBox_Calendario.Items.Add(caAux.Temporada) 'imprime el id de la persona en la lista con .Items.Add'
        Next
        For Each cAux In Me.c.CarrerasDAO.Carrera
            Me.ListBox_Carreras.Items.Add(cAux.Temporada) 'imprime el id de la persona en la lista con .Items.Add'
        Next
        For Each conAux In Me.con.ContratoDAO.Contratos
            Me.ListBox_Contratos.Items.Add(conAux.Escuderia) 'imprime el id de la persona en la lista con .Items.Add'
        Next
        Conectar.Enabled = False
        Conectar.Visible = False
        Añadir.Enabled = True
    End Sub

    Private Sub generarRandomContratos()
        //haz un metodo que genere contratos random, eligiendo a pilotos aleatorios y que no se repitan

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Me.Actualizar.Enabled = True
        Me.Borrar.Enabled = True
        Me.txtID.Enabled = False
        If Not Me.ListBox1.SelectedItem Is Nothing Then
            Me.p = New Pais(Me.ListBox1.SelectedItem.ToString) 'para obtener un elemento de la listaBox'
            Try
                Me.p.LeerPersona()
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
                pi = New Piloto
                pi.PaisPiloto = ComboBox_Pais_Piloto.SelectedItem
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
            Me.ComboBox_Pais_Piloto.SelectedItem = Me.pi.PaisPiloto
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
            Me.ComboBox_Pais_Escuderia.SelectedItem = Me.es.PaisEscuderia
            Me.TextBox_Nombre_Escuderia.Text = Me.es.Nombre.ToString
        End If
    End Sub

    Private Sub Añadir_Escuderia_Click(sender As Object, a As EventArgs) Handles Añadir_Escuderia.Click
        If TextBox_Nombre_Escuderia.Text <> String.Empty And ComboBox_Pais_Escuderia.Text <> String.Empty Then '<> significa !='
            Try
                es = New Escuderia
                es.PaisEscuderia = ComboBox_Pais_Escuderia.SelectedItem
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
            Me.ComboBox_GP_Pais.SelectedItem = Me.G.PaisGP
            Me.TextBox_GP_Denominacion.Text = Me.G.DenominacionGP.ToString


        End If
    End Sub


    Private Sub Añadir_GP_Click(sender As Object, e As EventArgs) Handles Añadir_GP.Click
        If Me.TextBox_GP_Denominacion.Text <> String.Empty And ComboBox_GP_Pais.SelectedItem <> String.Empty Then '<> significa !='
            Try
                G = New GP
                G.PaisGP = ComboBox_GP_Pais.SelectedItem
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
            Me.ca = New Calendario(Me.ListBox_Calendario.SelectedItem.ToString) 'para obtener un elemento de la listaBox'
            Try
                Me.ca.LeerCalendario()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub 'si hay algo raro que salte y vuelva a ejecutar'
            End Try
            Me.TextBox_GP_Calendario.Text = Me.ca.GP.ToString
            Me.TextBox_Orden_Calendario.Text = Me.ca.Orden.ToString


        End If
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        Dim txt As String
        txt = txtNombre.Text

        If txt <> String.Empty And txt.Length > 2 Then
            txtID.Text = txt.Substring(0, 3).ToUpper

            For Each pAux In Me.p.PerDAO.Personas
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
            numElementos = 57
            MessageBox.Show(MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            numElementos = Numeros_escuderias.Value
        End If

        For Each EAux In EscuderiasRandom
            EscuderiasFinal.Add(EAux)
        Next

        Return EscuderiasFinal

    End Function


    Private Sub Button_Valores_Click(sender As Object, e As EventArgs) Handles Button_Valores.Click
        Me.Numeros_escuderias.Enabled = True
        Me.Numeros_GP.Enabled = True
        Me.Button_Valores.Enabled = False

    End Sub

    Private Sub ListBox_Contratos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_Contratos.SelectedIndexChanged
        If Not Me.ListBox_Contratos.SelectedItem Is Nothing Then
            Me.con = New Contrato()
            Try
                Me.con.LeerContrato()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub 'si hay algo raro que salte y vuelva a ejecutar'
            End Try
            Me.textBox_Contratos_Escuderia.Text = Me.con.Escuderia.ToString
            Me.textBox_Contratos_Temporada.Text = Me.con.Temporada.ToString
            Me.textBox_Contratos_Piloto1.Text = Me.con.Piloto1.ToString
            Me.textBox_Contratos_Piloto2.Text = Me.con.Piloto2.ToString
        End If
    End Sub
End Class
