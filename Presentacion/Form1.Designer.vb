<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        TabControl1 = New TabControl()
        Pais = New TabPage()
        ListView1 = New ListView()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtID = New TextBox()
        Limpiar = New Button()
        Borrar = New Button()
        Actualizar = New Button()
        Añadir = New Button()
        txtHab = New TextBox()
        txtNombre = New TextBox()
        ListBox1 = New ListBox()
        Pilotos = New TabPage()
        TextBox_Nombre_Piloto = New TextBox()
        ComboBox_Pais_Piloto = New ComboBox()
        TextBox_ID_Piloto = New TextBox()
        Limpiar_Piloto = New Button()
        Borrar_Piloto = New Button()
        Actualizar_Piloto = New Button()
        Añadir_Piloto = New Button()
        lbl_Pais_Piloto = New Label()
        ListBox_Piloto = New ListBox()
        lbl_ID_Piloto = New Label()
        GPs = New TabPage()
        lbl_nombre_Escuderia = New Label()
        TextBox_Nombre_Escuderia = New TextBox()
        DateTimePicker_Escuderia = New DateTimePicker()
        ComboBox_Pais_Escuderia = New ComboBox()
        TextBox_ID_Escuderia = New TextBox()
        Limpiar_Escuderia = New Button()
        Borrar_Escuderia = New Button()
        Actualizar_Escuderia = New Button()
        Añadir_Escuderia = New Button()
        Label4 = New Label()
        ListBox_Escuderia = New ListBox()
        Label5 = New Label()
        TabPage4 = New TabPage()
        TextBox3 = New TextBox()
        TabPage1 = New TabPage()
        Conectar = New Button()
        TextBox_Apellido_Piloto = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        TabControl1.SuspendLayout()
        Pais.SuspendLayout()
        Pilotos.SuspendLayout()
        GPs.SuspendLayout()
        TabPage4.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(Pais)
        TabControl1.Controls.Add(Pilotos)
        TabControl1.Controls.Add(GPs)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Location = New Point(70, 29)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(578, 380)
        TabControl1.TabIndex = 0
        ' 
        ' Pais
        ' 
        Pais.Controls.Add(ListView1)
        Pais.Controls.Add(Label3)
        Pais.Controls.Add(Label2)
        Pais.Controls.Add(Label1)
        Pais.Controls.Add(txtID)
        Pais.Controls.Add(Limpiar)
        Pais.Controls.Add(Borrar)
        Pais.Controls.Add(Actualizar)
        Pais.Controls.Add(Añadir)
        Pais.Controls.Add(txtHab)
        Pais.Controls.Add(txtNombre)
        Pais.Controls.Add(ListBox1)
        Pais.Location = New Point(4, 24)
        Pais.Name = "Pais"
        Pais.Padding = New Padding(3)
        Pais.Size = New Size(570, 352)
        Pais.TabIndex = 0
        Pais.Text = "Pais"
        Pais.UseVisualStyleBackColor = True
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(78, 256)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(121, 49)
        ListView1.TabIndex = 12
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(265, 143)
        Label3.Name = "Label3"
        Label3.Size = New Size(32, 15)
        Label3.TabIndex = 11
        Label3.Text = "Hab."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(265, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 10
        Label2.Text = "Nombre"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(265, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(18, 15)
        Label1.TabIndex = 9
        Label1.Text = "ID"
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(332, 22)
        txtID.Name = "txtID"
        txtID.Size = New Size(212, 23)
        txtID.TabIndex = 8
        ' 
        ' Limpiar
        ' 
        Limpiar.Location = New Point(447, 234)
        Limpiar.Name = "Limpiar"
        Limpiar.Size = New Size(97, 29)
        Limpiar.TabIndex = 7
        Limpiar.Text = "Limpiar"
        Limpiar.UseVisualStyleBackColor = True
        ' 
        ' Borrar
        ' 
        Borrar.Location = New Point(332, 234)
        Borrar.Name = "Borrar"
        Borrar.Size = New Size(97, 29)
        Borrar.TabIndex = 6
        Borrar.Text = "Borrar"
        Borrar.UseVisualStyleBackColor = True
        ' 
        ' Actualizar
        ' 
        Actualizar.Location = New Point(447, 189)
        Actualizar.Name = "Actualizar"
        Actualizar.Size = New Size(97, 29)
        Actualizar.TabIndex = 5
        Actualizar.Text = "Actualizar"
        Actualizar.UseVisualStyleBackColor = True
        ' 
        ' Añadir
        ' 
        Añadir.Location = New Point(332, 189)
        Añadir.Name = "Añadir"
        Añadir.Size = New Size(97, 29)
        Añadir.TabIndex = 4
        Añadir.Text = "Añadir"
        Añadir.UseVisualStyleBackColor = True
        ' 
        ' txtHab
        ' 
        txtHab.Location = New Point(332, 140)
        txtHab.Name = "txtHab"
        txtHab.Size = New Size(212, 23)
        txtHab.TabIndex = 2
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(332, 76)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(212, 23)
        txtNombre.TabIndex = 1
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(30, 25)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(212, 214)
        ListBox1.TabIndex = 0
        ' 
        ' Pilotos
        ' 
        Pilotos.Controls.Add(Label7)
        Pilotos.Controls.Add(Label6)
        Pilotos.Controls.Add(TextBox_Apellido_Piloto)
        Pilotos.Controls.Add(TextBox_Nombre_Piloto)
        Pilotos.Controls.Add(ComboBox_Pais_Piloto)
        Pilotos.Controls.Add(TextBox_ID_Piloto)
        Pilotos.Controls.Add(Limpiar_Piloto)
        Pilotos.Controls.Add(Borrar_Piloto)
        Pilotos.Controls.Add(Actualizar_Piloto)
        Pilotos.Controls.Add(Añadir_Piloto)
        Pilotos.Controls.Add(lbl_Pais_Piloto)
        Pilotos.Controls.Add(ListBox_Piloto)
        Pilotos.Controls.Add(lbl_ID_Piloto)
        Pilotos.Location = New Point(4, 24)
        Pilotos.Name = "Pilotos"
        Pilotos.Padding = New Padding(3)
        Pilotos.Size = New Size(570, 352)
        Pilotos.TabIndex = 1
        Pilotos.Text = "Pilotos"
        Pilotos.UseVisualStyleBackColor = True
        ' 
        ' TextBox_Nombre_Piloto
        ' 
        TextBox_Nombre_Piloto.Location = New Point(267, 125)
        TextBox_Nombre_Piloto.Name = "TextBox_Nombre_Piloto"
        TextBox_Nombre_Piloto.Size = New Size(260, 23)
        TextBox_Nombre_Piloto.TabIndex = 33
        ' 
        ' ComboBox_Pais_Piloto
        ' 
        ComboBox_Pais_Piloto.FormattingEnabled = True
        ComboBox_Pais_Piloto.Location = New Point(267, 70)
        ComboBox_Pais_Piloto.Margin = New Padding(3, 2, 3, 2)
        ComboBox_Pais_Piloto.Name = "ComboBox_Pais_Piloto"
        ComboBox_Pais_Piloto.Size = New Size(260, 23)
        ComboBox_Pais_Piloto.TabIndex = 32
        ' 
        ' TextBox_ID_Piloto
        ' 
        TextBox_ID_Piloto.Location = New Point(267, 23)
        TextBox_ID_Piloto.Margin = New Padding(3, 2, 3, 2)
        TextBox_ID_Piloto.Name = "TextBox_ID_Piloto"
        TextBox_ID_Piloto.ReadOnly = True
        TextBox_ID_Piloto.Size = New Size(260, 23)
        TextBox_ID_Piloto.TabIndex = 31
        ' 
        ' Limpiar_Piloto
        ' 
        Limpiar_Piloto.Location = New Point(400, 259)
        Limpiar_Piloto.Margin = New Padding(3, 2, 3, 2)
        Limpiar_Piloto.Name = "Limpiar_Piloto"
        Limpiar_Piloto.Size = New Size(82, 22)
        Limpiar_Piloto.TabIndex = 30
        Limpiar_Piloto.Text = "Limpiar"
        Limpiar_Piloto.UseVisualStyleBackColor = True
        ' 
        ' Borrar_Piloto
        ' 
        Borrar_Piloto.Location = New Point(285, 259)
        Borrar_Piloto.Margin = New Padding(3, 2, 3, 2)
        Borrar_Piloto.Name = "Borrar_Piloto"
        Borrar_Piloto.Size = New Size(82, 22)
        Borrar_Piloto.TabIndex = 29
        Borrar_Piloto.Text = "Borrar"
        Borrar_Piloto.UseVisualStyleBackColor = True
        ' 
        ' Actualizar_Piloto
        ' 
        Actualizar_Piloto.Location = New Point(400, 223)
        Actualizar_Piloto.Margin = New Padding(3, 2, 3, 2)
        Actualizar_Piloto.Name = "Actualizar_Piloto"
        Actualizar_Piloto.Size = New Size(82, 22)
        Actualizar_Piloto.TabIndex = 28
        Actualizar_Piloto.Text = "Actualizar"
        Actualizar_Piloto.UseVisualStyleBackColor = True
        ' 
        ' Añadir_Piloto
        ' 
        Añadir_Piloto.Location = New Point(284, 223)
        Añadir_Piloto.Margin = New Padding(3, 2, 3, 2)
        Añadir_Piloto.Name = "Añadir_Piloto"
        Añadir_Piloto.Size = New Size(82, 22)
        Añadir_Piloto.TabIndex = 27
        Añadir_Piloto.Text = "Anadir"
        Añadir_Piloto.UseVisualStyleBackColor = True
        ' 
        ' lbl_Pais_Piloto
        ' 
        lbl_Pais_Piloto.AutoSize = True
        lbl_Pais_Piloto.Location = New Point(227, 70)
        lbl_Pais_Piloto.Name = "lbl_Pais_Piloto"
        lbl_Pais_Piloto.Size = New Size(28, 15)
        lbl_Pais_Piloto.TabIndex = 26
        lbl_Pais_Piloto.Text = "Pais"
        ' 
        ' ListBox_Piloto
        ' 
        ListBox_Piloto.FormattingEnabled = True
        ListBox_Piloto.ItemHeight = 15
        ListBox_Piloto.Location = New Point(27, 26)
        ListBox_Piloto.Margin = New Padding(3, 2, 3, 2)
        ListBox_Piloto.Name = "ListBox_Piloto"
        ListBox_Piloto.Size = New Size(147, 289)
        ListBox_Piloto.TabIndex = 25
        ' 
        ' lbl_ID_Piloto
        ' 
        lbl_ID_Piloto.AutoSize = True
        lbl_ID_Piloto.Location = New Point(237, 26)
        lbl_ID_Piloto.Name = "lbl_ID_Piloto"
        lbl_ID_Piloto.Size = New Size(18, 15)
        lbl_ID_Piloto.TabIndex = 24
        lbl_ID_Piloto.Text = "ID"
        ' 
        ' GPs
        ' 
        GPs.Controls.Add(lbl_nombre_Escuderia)
        GPs.Controls.Add(TextBox_Nombre_Escuderia)
        GPs.Controls.Add(DateTimePicker_Escuderia)
        GPs.Controls.Add(ComboBox_Pais_Escuderia)
        GPs.Controls.Add(TextBox_ID_Escuderia)
        GPs.Controls.Add(Limpiar_Escuderia)
        GPs.Controls.Add(Borrar_Escuderia)
        GPs.Controls.Add(Actualizar_Escuderia)
        GPs.Controls.Add(Añadir_Escuderia)
        GPs.Controls.Add(Label4)
        GPs.Controls.Add(ListBox_Escuderia)
        GPs.Controls.Add(Label5)
        GPs.Location = New Point(4, 24)
        GPs.Name = "GPs"
        GPs.Size = New Size(570, 352)
        GPs.TabIndex = 2
        GPs.Text = "Escuderias"
        GPs.UseVisualStyleBackColor = True
        ' 
        ' lbl_nombre_Escuderia
        ' 
        lbl_nombre_Escuderia.AutoSize = True
        lbl_nombre_Escuderia.Location = New Point(306, 148)
        lbl_nombre_Escuderia.Name = "lbl_nombre_Escuderia"
        lbl_nombre_Escuderia.Size = New Size(51, 15)
        lbl_nombre_Escuderia.TabIndex = 47
        lbl_nombre_Escuderia.Text = "Nombre"
        ' 
        ' TextBox_Nombre_Escuderia
        ' 
        TextBox_Nombre_Escuderia.Location = New Point(368, 146)
        TextBox_Nombre_Escuderia.Margin = New Padding(3, 2, 3, 2)
        TextBox_Nombre_Escuderia.Name = "TextBox_Nombre_Escuderia"
        TextBox_Nombre_Escuderia.Size = New Size(132, 23)
        TextBox_Nombre_Escuderia.TabIndex = 46
        ' 
        ' DateTimePicker_Escuderia
        ' 
        DateTimePicker_Escuderia.Location = New Point(260, 190)
        DateTimePicker_Escuderia.Margin = New Padding(3, 2, 3, 2)
        DateTimePicker_Escuderia.Name = "DateTimePicker_Escuderia"
        DateTimePicker_Escuderia.Size = New Size(239, 23)
        DateTimePicker_Escuderia.TabIndex = 45
        ' 
        ' ComboBox_Pais_Escuderia
        ' 
        ComboBox_Pais_Escuderia.FormattingEnabled = True
        ComboBox_Pais_Escuderia.Location = New Point(368, 111)
        ComboBox_Pais_Escuderia.Margin = New Padding(3, 2, 3, 2)
        ComboBox_Pais_Escuderia.Name = "ComboBox_Pais_Escuderia"
        ComboBox_Pais_Escuderia.Size = New Size(132, 23)
        ComboBox_Pais_Escuderia.TabIndex = 44
        ' 
        ' TextBox_ID_Escuderia
        ' 
        TextBox_ID_Escuderia.Location = New Point(368, 75)
        TextBox_ID_Escuderia.Margin = New Padding(3, 2, 3, 2)
        TextBox_ID_Escuderia.Name = "TextBox_ID_Escuderia"
        TextBox_ID_Escuderia.ReadOnly = True
        TextBox_ID_Escuderia.Size = New Size(132, 23)
        TextBox_ID_Escuderia.TabIndex = 43
        ' 
        ' Limpiar_Escuderia
        ' 
        Limpiar_Escuderia.Location = New Point(416, 264)
        Limpiar_Escuderia.Margin = New Padding(3, 2, 3, 2)
        Limpiar_Escuderia.Name = "Limpiar_Escuderia"
        Limpiar_Escuderia.Size = New Size(82, 22)
        Limpiar_Escuderia.TabIndex = 42
        Limpiar_Escuderia.Text = "Limpiar"
        Limpiar_Escuderia.UseVisualStyleBackColor = True
        ' 
        ' Borrar_Escuderia
        ' 
        Borrar_Escuderia.Location = New Point(319, 264)
        Borrar_Escuderia.Margin = New Padding(3, 2, 3, 2)
        Borrar_Escuderia.Name = "Borrar_Escuderia"
        Borrar_Escuderia.Size = New Size(82, 22)
        Borrar_Escuderia.TabIndex = 41
        Borrar_Escuderia.Text = "Borrar"
        Borrar_Escuderia.UseVisualStyleBackColor = True
        ' 
        ' Actualizar_Escuderia
        ' 
        Actualizar_Escuderia.Location = New Point(416, 228)
        Actualizar_Escuderia.Margin = New Padding(3, 2, 3, 2)
        Actualizar_Escuderia.Name = "Actualizar_Escuderia"
        Actualizar_Escuderia.Size = New Size(82, 22)
        Actualizar_Escuderia.TabIndex = 40
        Actualizar_Escuderia.Text = "Actualizar"
        Actualizar_Escuderia.UseVisualStyleBackColor = True
        ' 
        ' Añadir_Escuderia
        ' 
        Añadir_Escuderia.Location = New Point(318, 228)
        Añadir_Escuderia.Margin = New Padding(3, 2, 3, 2)
        Añadir_Escuderia.Name = "Añadir_Escuderia"
        Añadir_Escuderia.Size = New Size(82, 22)
        Añadir_Escuderia.TabIndex = 39
        Añadir_Escuderia.Text = "Anadir"
        Añadir_Escuderia.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(332, 113)
        Label4.Name = "Label4"
        Label4.Size = New Size(28, 15)
        Label4.TabIndex = 38
        Label4.Text = "Pais"
        ' 
        ' ListBox_Escuderia
        ' 
        ListBox_Escuderia.FormattingEnabled = True
        ListBox_Escuderia.ItemHeight = 15
        ListBox_Escuderia.Location = New Point(72, 70)
        ListBox_Escuderia.Margin = New Padding(3, 2, 3, 2)
        ListBox_Escuderia.Name = "ListBox_Escuderia"
        ListBox_Escuderia.Size = New Size(144, 199)
        ListBox_Escuderia.TabIndex = 37
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(341, 77)
        Label5.Name = "Label5"
        Label5.Size = New Size(18, 15)
        Label5.TabIndex = 36
        Label5.Text = "ID"
        ' 
        ' TabPage4
        ' 
        TabPage4.Controls.Add(TextBox3)
        TabPage4.Location = New Point(4, 24)
        TabPage4.Name = "TabPage4"
        TabPage4.Size = New Size(570, 352)
        TabPage4.TabIndex = 3
        TabPage4.Text = "GPs"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(220, 168)
        TextBox3.Margin = New Padding(3, 2, 3, 2)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(132, 23)
        TextBox3.TabIndex = 44
        ' 
        ' TabPage1
        ' 
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(570, 352)
        TabPage1.TabIndex = 4
        TabPage1.Text = "TabPage1"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Conectar
        ' 
        Conectar.Font = New Font("Segoe UI", 48.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Conectar.Image = CType(resources.GetObject("Conectar.Image"), Image)
        Conectar.Location = New Point(685, 47)
        Conectar.Name = "Conectar"
        Conectar.Size = New Size(103, 352)
        Conectar.TabIndex = 1
        Conectar.Text = "Conectar!!!"
        Conectar.UseVisualStyleBackColor = True
        ' 
        ' TextBox_Apellido_Piloto
        ' 
        TextBox_Apellido_Piloto.Location = New Point(267, 172)
        TextBox_Apellido_Piloto.Name = "TextBox_Apellido_Piloto"
        TextBox_Apellido_Piloto.Size = New Size(260, 23)
        TextBox_Apellido_Piloto.TabIndex = 34
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(204, 128)
        Label6.Name = "Label6"
        Label6.Size = New Size(51, 15)
        Label6.TabIndex = 35
        Label6.Text = "Nombre"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(204, 177)
        Label7.Name = "Label7"
        Label7.Size = New Size(51, 15)
        Label7.TabIndex = 36
        Label7.Text = "Apellido"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Conectar)
        Controls.Add(TabControl1)
        Name = "Form1"
        Text = "Form1"
        TabControl1.ResumeLayout(False)
        Pais.ResumeLayout(False)
        Pais.PerformLayout()
        Pilotos.ResumeLayout(False)
        Pilotos.PerformLayout()
        GPs.ResumeLayout(False)
        GPs.PerformLayout()
        TabPage4.ResumeLayout(False)
        TabPage4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Pais As TabPage
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Pilotos As TabPage
    Friend WithEvents GPs As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Limpiar As Button
    Friend WithEvents Borrar As Button
    Friend WithEvents Actualizar As Button
    Friend WithEvents Añadir As Button
    Friend WithEvents txtHab As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label3 As Label
    Friend WithEvents Conectar As Button
    Friend WithEvents ComboBox_Pais_Piloto As ComboBox
    Friend WithEvents TextBox_ID_Piloto As TextBox
    Friend WithEvents Limpiar_Piloto As Button
    Friend WithEvents Borrar_Piloto As Button
    Friend WithEvents Actualizar_Piloto As Button
    Friend WithEvents Añadir_Piloto As Button
    Friend WithEvents lbl_Pais_Piloto As Label
    Friend WithEvents ListBox_Piloto As ListBox
    Friend WithEvents lbl_ID_Piloto As Label
    Friend WithEvents lbl_nombre_Escuderia As Label
    Friend WithEvents TextBox_Nombre_Escuderia As TextBox
    Friend WithEvents DateTimePicker_Escuderia As DateTimePicker
    Friend WithEvents ComboBox_Pais_Escuderia As ComboBox
    Friend WithEvents TextBox_ID_Escuderia As TextBox
    Friend WithEvents Limpiar_Escuderia As Button
    Friend WithEvents Borrar_Escuderia As Button
    Friend WithEvents Actualizar_Escuderia As Button
    Friend WithEvents Añadir_Escuderia As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ListBox_Escuderia As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TextBox_Nombre_Piloto As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox_Apellido_Piloto As TextBox

End Class
