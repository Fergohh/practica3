Public Class Form1
    Dim p As Pais
    Private Sub Añadir_Click(sender As Object, e As EventArgs) Handles Añadir.Click
        If Me.txtID.Text <> String.Empty And Me.txtNombre.Text <> String.Empty Then '<> significa !='
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
        Me.p = New Pais
        Try
            Me.p.LeerTodasPersonas()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub 'si hay algo raro que salte y vuelva a ejecutar'
        End Try
        For Each pAux In Me.p.PerDAO.Personas
            Me.ListBox1.Items.Add(pAux.IDPais) 'imprime el id de la persona en la lista con .Items.Add'
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

End Class
