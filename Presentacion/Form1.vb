Public Class Form1
    Dim p As Pais
    Dim pi As Piloto
    Dim E As Escuderia
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
            p.Nombre = txtNombre.Text
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
    End Sub

    Private Sub Conectar_Click(sender As Object, e As EventArgs) Handles Conectar.Click
        Dim pAux As Pais
        Dim piAux As Piloto
        Me.p = New Pais
        Me.pi = New Piloto
        Me.E = New Escuderia
        Try
            Me.p.LeerTodasPersonas()
            Me.pi.LeerTodosPilotos()
            Me.E.LeerTodosEscuderias()

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub 'si hay algo raro que salte y vuelva a ejecutar'
        End Try
        For Each pAux In Me.p.PerDAO.Personas
            Me.ListBox1.Items.Add(pAux.IDPais) 'imprime el id de la persona en la lista con .Items.Add'
            Me.ComboBox_Pais_Piloto.Items.Add(pAux.IDPais)
            Me.ComboBox_Pais_Escuderia.Items.Add(pAux.IDPais)
        Next
        For Each piAux In Me.pi.PilotoDAO.Pilotos
            Me.ListBox_Piloto.Items.Add(piAux.IDPiloto) 'imprime el id de la persona en la lista con .Items.Add'
        Next
        For Each EAux In Me.E.EscuderiaDAO.Escuderias
            Me.ListBox_Escuderia.Items.Add(EAux.IDEscuderia) 'imprime el id de la persona en la lista con .Items.Add'
        Next
        Conectar.Enabled = False
        Conectar.Visible = False
        Añadir.Enabled = True
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
        If Me.TextBox_ID_Piloto.Text <> String.Empty Then '<> significa !='
            Try
                pi = New Piloto
                pi.IDPiloto = TextBox_ID_Piloto.Text
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
            Me.ListBox_Piloto.Items.Add(pi.IDPiloto)
        End If
    End Sub

    Private Sub Actualizar_Piloto_Click(sender As Object, e As EventArgs) Handles Actualizar_Piloto.Click
        If Not p Is Nothing Then 'el p Is Nothing es como p == NULL, si le pones el Not delante seria p != NULL'
            p.Nombre = txtNombre.Text
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
        Me.TextBox_Nombre_Piloto.Enabled = False
        Me.TextBox_Apellido_Piloto.Enabled = False
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
        Me.TextBox_Nombre_Escuderia.Enabled = False
        Me.ComboBox_Pais_Escuderia.Enabled = False
        If Not Me.ListBox_Escuderia.SelectedItem Is Nothing Then
            Me.E = New Escuderia(Me.ListBox_Escuderia.SelectedItem.ToString) 'para obtener un elemento de la listaBox'
            Try
                Me.E.LeerEscuderia()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub 'si hay algo raro que salte y vuelva a ejecutar'
            End Try
            Me.TextBox_ID_Escuderia.Text = Me.E.IDEscuderia.ToString
            Me.DateTimePicker_Escuderia.Value = Me.E.FechaCrec
            Me.ComboBox_Pais_Escuderia.SelectedItem = Me.E.PaisEscuderia
            Me.TextBox_Nombre_Escuderia.Text = Me.E.Nombre.ToString
        End If
    End Sub

    Private Sub Añadir_Escuderia_Click(sender As Object, a As EventArgs) Handles Añadir_Escuderia.Click
        If Me.TextBox_ID_Escuderia.Text <> String.Empty Then '<> significa !='
            Try
                E = New Escuderia
                E.PaisEscuderia = ComboBox_Pais_Escuderia.SelectedItem
                E.Nombre = TextBox_Nombre_Escuderia.Text
                E.FechaCrec = DateTimePicker_Escuderia.Value.ToString("yyyy-MM-dd")
                If E.InsertarEscuderia <> 1 Then
                    MessageBox.Show("INSERT return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub 'si hay algo raro que salte y vuelva a ejecutar'

            End Try
            Me.ListBox_Escuderia.Items.Add(E.IDEscuderia)
        End If
    End Sub

    Private Sub Limpiar_Escuderia_Click(sender As Object, e As EventArgs) Handles Limpiar_Escuderia.Click
        Me.TextBox_ID_Escuderia.Text = String.Empty
        Me.ComboBox_Pais_Escuderia.SelectedIndex = -1
        Me.TextBox_Nombre_Escuderia.Text = String.Empty
        Me.DateTimePicker_Escuderia.Value = Date.Today
        Me.TextBox_ID_Escuderia.Enabled = True
        Me.ComboBox_Pais_Escuderia.Enabled = True
        Me.TextBox_Nombre_Escuderia.Enabled = True
    End Sub


End Class
