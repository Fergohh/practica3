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
        Label7 = New Label()
        Label6 = New Label()
        TextBox_Apellido_Piloto = New TextBox()
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
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Limpiar_GP = New Button()
        Borrar_GP = New Button()
        Actualizar_GP = New Button()
        Añadir_GP = New Button()
        TextBox_GP_Denominacion = New TextBox()
        TextBox_GP_ID = New TextBox()
        ComboBox_GP_Pais = New ComboBox()
        ListBox_GP = New ListBox()
        Calendario = New TabPage()
        Label12 = New Label()
        TextBox_GP_Calendario = New TextBox()
        Label11 = New Label()
        TextBox_Orden_Calendario = New TextBox()
        ListBox_Calendario = New ListBox()
        Carreras = New TabPage()
        ListBox_Carreras = New ListBox()
        Contratos = New TabPage()
        Label18 = New Label()
        Label17 = New Label()
        Label16 = New Label()
        Label15 = New Label()
        TextBox5 = New TextBox()
        textBox_Contratos_Piloto2 = New TextBox()
        textBox_Contratos_Piloto1 = New TextBox()
        textBox_Contratos_Temporada = New TextBox()
        textBox_Contratos_Escuderia = New TextBox()
        ListBox_Contratos = New ListBox()
        Conectar = New Button()
        Numeros_escuderias = New NumericUpDown()
        Numeros_GP = New NumericUpDown()
        Escuderias = New Label()
        Label14 = New Label()
        Button_Valores = New Button()
        Label_Valores = New Label()
        TabControl1.SuspendLayout()
        Pais.SuspendLayout()
        Pilotos.SuspendLayout()
        GPs.SuspendLayout()
        TabPage4.SuspendLayout()
        Calendario.SuspendLayout()
        Carreras.SuspendLayout()
        Contratos.SuspendLayout()
        CType(Numeros_escuderias, ComponentModel.ISupportInitialize).BeginInit()
        CType(Numeros_GP, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(Pais)
        TabControl1.Controls.Add(Pilotos)
        TabControl1.Controls.Add(GPs)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Controls.Add(Calendario)
        TabControl1.Controls.Add(Carreras)
        TabControl1.Controls.Add(Contratos)
        TabControl1.Location = New Point(61, 22)
        TabControl1.Margin = New Padding(3, 2, 3, 2)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(506, 285)
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
        Pais.Margin = New Padding(3, 2, 3, 2)
        Pais.Name = "Pais"
        Pais.Padding = New Padding(3, 2, 3, 2)
        Pais.Size = New Size(498, 257)
        Pais.TabIndex = 0
        Pais.Text = "Pais"
        Pais.UseVisualStyleBackColor = True
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(68, 192)
        ListView1.Margin = New Padding(3, 2, 3, 2)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(106, 38)
        ListView1.TabIndex = 12
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(232, 107)
        Label3.Name = "Label3"
        Label3.Size = New Size(32, 15)
        Label3.TabIndex = 11
        Label3.Text = "Hab."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(232, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 10
        Label2.Text = "Nombre"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(232, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(18, 15)
        Label1.TabIndex = 9
        Label1.Text = "ID"
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(290, 16)
        txtID.Margin = New Padding(3, 2, 3, 2)
        txtID.Name = "txtID"
        txtID.ReadOnly = True
        txtID.Size = New Size(186, 23)
        txtID.TabIndex = 8
        ' 
        ' Limpiar
        ' 
        Limpiar.Location = New Point(391, 176)
        Limpiar.Margin = New Padding(3, 2, 3, 2)
        Limpiar.Name = "Limpiar"
        Limpiar.Size = New Size(85, 22)
        Limpiar.TabIndex = 7
        Limpiar.Text = "Limpiar"
        Limpiar.UseVisualStyleBackColor = True
        ' 
        ' Borrar
        ' 
        Borrar.Location = New Point(290, 176)
        Borrar.Margin = New Padding(3, 2, 3, 2)
        Borrar.Name = "Borrar"
        Borrar.Size = New Size(85, 22)
        Borrar.TabIndex = 6
        Borrar.Text = "Borrar"
        Borrar.UseVisualStyleBackColor = True
        ' 
        ' Actualizar
        ' 
        Actualizar.Location = New Point(391, 142)
        Actualizar.Margin = New Padding(3, 2, 3, 2)
        Actualizar.Name = "Actualizar"
        Actualizar.Size = New Size(85, 22)
        Actualizar.TabIndex = 5
        Actualizar.Text = "Actualizar"
        Actualizar.UseVisualStyleBackColor = True
        ' 
        ' Añadir
        ' 
        Añadir.Location = New Point(290, 142)
        Añadir.Margin = New Padding(3, 2, 3, 2)
        Añadir.Name = "Añadir"
        Añadir.Size = New Size(85, 22)
        Añadir.TabIndex = 4
        Añadir.Text = "Añadir"
        Añadir.UseVisualStyleBackColor = True
        ' 
        ' txtHab
        ' 
        txtHab.Location = New Point(290, 105)
        txtHab.Margin = New Padding(3, 2, 3, 2)
        txtHab.Name = "txtHab"
        txtHab.Size = New Size(186, 23)
        txtHab.TabIndex = 2
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(290, 57)
        txtNombre.Margin = New Padding(3, 2, 3, 2)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(186, 23)
        txtNombre.TabIndex = 1
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(26, 19)
        ListBox1.Margin = New Padding(3, 2, 3, 2)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(186, 154)
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
        Pilotos.Margin = New Padding(3, 2, 3, 2)
        Pilotos.Name = "Pilotos"
        Pilotos.Padding = New Padding(3, 2, 3, 2)
        Pilotos.Size = New Size(498, 257)
        Pilotos.TabIndex = 1
        Pilotos.Text = "Pilotos"
        Pilotos.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(178, 133)
        Label7.Name = "Label7"
        Label7.Size = New Size(51, 15)
        Label7.TabIndex = 36
        Label7.Text = "Apellido"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(178, 96)
        Label6.Name = "Label6"
        Label6.Size = New Size(51, 15)
        Label6.TabIndex = 35
        Label6.Text = "Nombre"
        ' 
        ' TextBox_Apellido_Piloto
        ' 
        TextBox_Apellido_Piloto.Location = New Point(234, 129)
        TextBox_Apellido_Piloto.Margin = New Padding(3, 2, 3, 2)
        TextBox_Apellido_Piloto.Name = "TextBox_Apellido_Piloto"
        TextBox_Apellido_Piloto.Size = New Size(228, 23)
        TextBox_Apellido_Piloto.TabIndex = 34
        ' 
        ' TextBox_Nombre_Piloto
        ' 
        TextBox_Nombre_Piloto.Location = New Point(234, 94)
        TextBox_Nombre_Piloto.Margin = New Padding(3, 2, 3, 2)
        TextBox_Nombre_Piloto.Name = "TextBox_Nombre_Piloto"
        TextBox_Nombre_Piloto.Size = New Size(228, 23)
        TextBox_Nombre_Piloto.TabIndex = 33
        ' 
        ' ComboBox_Pais_Piloto
        ' 
        ComboBox_Pais_Piloto.FormattingEnabled = True
        ComboBox_Pais_Piloto.Location = New Point(234, 52)
        ComboBox_Pais_Piloto.Margin = New Padding(3, 2, 3, 2)
        ComboBox_Pais_Piloto.Name = "ComboBox_Pais_Piloto"
        ComboBox_Pais_Piloto.Size = New Size(228, 23)
        ComboBox_Pais_Piloto.TabIndex = 32
        ' 
        ' TextBox_ID_Piloto
        ' 
        TextBox_ID_Piloto.Location = New Point(234, 17)
        TextBox_ID_Piloto.Margin = New Padding(3, 2, 3, 2)
        TextBox_ID_Piloto.Name = "TextBox_ID_Piloto"
        TextBox_ID_Piloto.ReadOnly = True
        TextBox_ID_Piloto.Size = New Size(228, 23)
        TextBox_ID_Piloto.TabIndex = 31
        ' 
        ' Limpiar_Piloto
        ' 
        Limpiar_Piloto.Location = New Point(350, 194)
        Limpiar_Piloto.Margin = New Padding(3, 2, 3, 2)
        Limpiar_Piloto.Name = "Limpiar_Piloto"
        Limpiar_Piloto.Size = New Size(72, 16)
        Limpiar_Piloto.TabIndex = 30
        Limpiar_Piloto.Text = "Limpiar"
        Limpiar_Piloto.UseVisualStyleBackColor = True
        ' 
        ' Borrar_Piloto
        ' 
        Borrar_Piloto.Location = New Point(249, 194)
        Borrar_Piloto.Margin = New Padding(3, 2, 3, 2)
        Borrar_Piloto.Name = "Borrar_Piloto"
        Borrar_Piloto.Size = New Size(72, 16)
        Borrar_Piloto.TabIndex = 29
        Borrar_Piloto.Text = "Borrar"
        Borrar_Piloto.UseVisualStyleBackColor = True
        ' 
        ' Actualizar_Piloto
        ' 
        Actualizar_Piloto.Location = New Point(350, 167)
        Actualizar_Piloto.Margin = New Padding(3, 2, 3, 2)
        Actualizar_Piloto.Name = "Actualizar_Piloto"
        Actualizar_Piloto.Size = New Size(72, 16)
        Actualizar_Piloto.TabIndex = 28
        Actualizar_Piloto.Text = "Actualizar"
        Actualizar_Piloto.UseVisualStyleBackColor = True
        ' 
        ' Añadir_Piloto
        ' 
        Añadir_Piloto.Location = New Point(248, 167)
        Añadir_Piloto.Margin = New Padding(3, 2, 3, 2)
        Añadir_Piloto.Name = "Añadir_Piloto"
        Añadir_Piloto.Size = New Size(72, 16)
        Añadir_Piloto.TabIndex = 27
        Añadir_Piloto.Text = "Anadir"
        Añadir_Piloto.UseVisualStyleBackColor = True
        ' 
        ' lbl_Pais_Piloto
        ' 
        lbl_Pais_Piloto.AutoSize = True
        lbl_Pais_Piloto.Location = New Point(199, 52)
        lbl_Pais_Piloto.Name = "lbl_Pais_Piloto"
        lbl_Pais_Piloto.Size = New Size(28, 15)
        lbl_Pais_Piloto.TabIndex = 26
        lbl_Pais_Piloto.Text = "Pais"
        ' 
        ' ListBox_Piloto
        ' 
        ListBox_Piloto.FormattingEnabled = True
        ListBox_Piloto.ItemHeight = 15
        ListBox_Piloto.Location = New Point(24, 20)
        ListBox_Piloto.Margin = New Padding(3, 2, 3, 2)
        ListBox_Piloto.Name = "ListBox_Piloto"
        ListBox_Piloto.Size = New Size(129, 214)
        ListBox_Piloto.TabIndex = 25
        ' 
        ' lbl_ID_Piloto
        ' 
        lbl_ID_Piloto.AutoSize = True
        lbl_ID_Piloto.Location = New Point(207, 20)
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
        GPs.Margin = New Padding(3, 2, 3, 2)
        GPs.Name = "GPs"
        GPs.Size = New Size(498, 257)
        GPs.TabIndex = 2
        GPs.Text = "Escuderias"
        GPs.UseVisualStyleBackColor = True
        ' 
        ' lbl_nombre_Escuderia
        ' 
        lbl_nombre_Escuderia.AutoSize = True
        lbl_nombre_Escuderia.Location = New Point(268, 111)
        lbl_nombre_Escuderia.Name = "lbl_nombre_Escuderia"
        lbl_nombre_Escuderia.Size = New Size(51, 15)
        lbl_nombre_Escuderia.TabIndex = 47
        lbl_nombre_Escuderia.Text = "Nombre"
        ' 
        ' TextBox_Nombre_Escuderia
        ' 
        TextBox_Nombre_Escuderia.Location = New Point(322, 110)
        TextBox_Nombre_Escuderia.Margin = New Padding(3, 2, 3, 2)
        TextBox_Nombre_Escuderia.Name = "TextBox_Nombre_Escuderia"
        TextBox_Nombre_Escuderia.Size = New Size(116, 23)
        TextBox_Nombre_Escuderia.TabIndex = 46
        ' 
        ' DateTimePicker_Escuderia
        ' 
        DateTimePicker_Escuderia.Location = New Point(228, 142)
        DateTimePicker_Escuderia.Margin = New Padding(3, 2, 3, 2)
        DateTimePicker_Escuderia.Name = "DateTimePicker_Escuderia"
        DateTimePicker_Escuderia.Size = New Size(210, 23)
        DateTimePicker_Escuderia.TabIndex = 45
        ' 
        ' ComboBox_Pais_Escuderia
        ' 
        ComboBox_Pais_Escuderia.FormattingEnabled = True
        ComboBox_Pais_Escuderia.Location = New Point(322, 83)
        ComboBox_Pais_Escuderia.Margin = New Padding(3, 2, 3, 2)
        ComboBox_Pais_Escuderia.Name = "ComboBox_Pais_Escuderia"
        ComboBox_Pais_Escuderia.Size = New Size(116, 23)
        ComboBox_Pais_Escuderia.TabIndex = 44
        ' 
        ' TextBox_ID_Escuderia
        ' 
        TextBox_ID_Escuderia.Location = New Point(322, 56)
        TextBox_ID_Escuderia.Margin = New Padding(3, 2, 3, 2)
        TextBox_ID_Escuderia.Name = "TextBox_ID_Escuderia"
        TextBox_ID_Escuderia.ReadOnly = True
        TextBox_ID_Escuderia.Size = New Size(116, 23)
        TextBox_ID_Escuderia.TabIndex = 43
        ' 
        ' Limpiar_Escuderia
        ' 
        Limpiar_Escuderia.Location = New Point(364, 198)
        Limpiar_Escuderia.Margin = New Padding(3, 2, 3, 2)
        Limpiar_Escuderia.Name = "Limpiar_Escuderia"
        Limpiar_Escuderia.Size = New Size(72, 16)
        Limpiar_Escuderia.TabIndex = 42
        Limpiar_Escuderia.Text = "Limpiar"
        Limpiar_Escuderia.UseVisualStyleBackColor = True
        ' 
        ' Borrar_Escuderia
        ' 
        Borrar_Escuderia.Location = New Point(279, 198)
        Borrar_Escuderia.Margin = New Padding(3, 2, 3, 2)
        Borrar_Escuderia.Name = "Borrar_Escuderia"
        Borrar_Escuderia.Size = New Size(72, 16)
        Borrar_Escuderia.TabIndex = 41
        Borrar_Escuderia.Text = "Borrar"
        Borrar_Escuderia.UseVisualStyleBackColor = True
        ' 
        ' Actualizar_Escuderia
        ' 
        Actualizar_Escuderia.Location = New Point(364, 171)
        Actualizar_Escuderia.Margin = New Padding(3, 2, 3, 2)
        Actualizar_Escuderia.Name = "Actualizar_Escuderia"
        Actualizar_Escuderia.Size = New Size(72, 16)
        Actualizar_Escuderia.TabIndex = 40
        Actualizar_Escuderia.Text = "Actualizar"
        Actualizar_Escuderia.UseVisualStyleBackColor = True
        ' 
        ' Añadir_Escuderia
        ' 
        Añadir_Escuderia.Location = New Point(278, 171)
        Añadir_Escuderia.Margin = New Padding(3, 2, 3, 2)
        Añadir_Escuderia.Name = "Añadir_Escuderia"
        Añadir_Escuderia.Size = New Size(72, 16)
        Añadir_Escuderia.TabIndex = 39
        Añadir_Escuderia.Text = "Anadir"
        Añadir_Escuderia.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(290, 85)
        Label4.Name = "Label4"
        Label4.Size = New Size(28, 15)
        Label4.TabIndex = 38
        Label4.Text = "Pais"
        ' 
        ' ListBox_Escuderia
        ' 
        ListBox_Escuderia.FormattingEnabled = True
        ListBox_Escuderia.ItemHeight = 15
        ListBox_Escuderia.Location = New Point(63, 52)
        ListBox_Escuderia.Margin = New Padding(3, 2, 3, 2)
        ListBox_Escuderia.Name = "ListBox_Escuderia"
        ListBox_Escuderia.Size = New Size(126, 139)
        ListBox_Escuderia.TabIndex = 37
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(298, 58)
        Label5.Name = "Label5"
        Label5.Size = New Size(18, 15)
        Label5.TabIndex = 36
        Label5.Text = "ID"
        ' 
        ' TabPage4
        ' 
        TabPage4.Controls.Add(Label10)
        TabPage4.Controls.Add(Label9)
        TabPage4.Controls.Add(Label8)
        TabPage4.Controls.Add(Limpiar_GP)
        TabPage4.Controls.Add(Borrar_GP)
        TabPage4.Controls.Add(Actualizar_GP)
        TabPage4.Controls.Add(Añadir_GP)
        TabPage4.Controls.Add(TextBox_GP_Denominacion)
        TabPage4.Controls.Add(TextBox_GP_ID)
        TabPage4.Controls.Add(ComboBox_GP_Pais)
        TabPage4.Controls.Add(ListBox_GP)
        TabPage4.Location = New Point(4, 24)
        TabPage4.Margin = New Padding(3, 2, 3, 2)
        TabPage4.Name = "TabPage4"
        TabPage4.Size = New Size(498, 257)
        TabPage4.TabIndex = 3
        TabPage4.Text = "GPs"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(304, 138)
        Label10.Name = "Label10"
        Label10.Size = New Size(28, 15)
        Label10.TabIndex = 54
        Label10.Text = "Pais"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(261, 102)
        Label9.Name = "Label9"
        Label9.Size = New Size(78, 15)
        Label9.TabIndex = 53
        Label9.Text = "Denomiacion"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(304, 74)
        Label8.Name = "Label8"
        Label8.Size = New Size(32, 15)
        Label8.TabIndex = 52
        Label8.Text = "IdGP"
        ' 
        ' Limpiar_GP
        ' 
        Limpiar_GP.Location = New Point(383, 214)
        Limpiar_GP.Margin = New Padding(3, 2, 3, 2)
        Limpiar_GP.Name = "Limpiar_GP"
        Limpiar_GP.Size = New Size(72, 16)
        Limpiar_GP.TabIndex = 51
        Limpiar_GP.Text = "Limpiar"
        Limpiar_GP.UseVisualStyleBackColor = True
        ' 
        ' Borrar_GP
        ' 
        Borrar_GP.Location = New Point(299, 214)
        Borrar_GP.Margin = New Padding(3, 2, 3, 2)
        Borrar_GP.Name = "Borrar_GP"
        Borrar_GP.Size = New Size(72, 16)
        Borrar_GP.TabIndex = 50
        Borrar_GP.Text = "Borrar"
        Borrar_GP.UseVisualStyleBackColor = True
        ' 
        ' Actualizar_GP
        ' 
        Actualizar_GP.Location = New Point(383, 187)
        Actualizar_GP.Margin = New Padding(3, 2, 3, 2)
        Actualizar_GP.Name = "Actualizar_GP"
        Actualizar_GP.Size = New Size(72, 16)
        Actualizar_GP.TabIndex = 49
        Actualizar_GP.Text = "Actualizar"
        Actualizar_GP.UseVisualStyleBackColor = True
        ' 
        ' Añadir_GP
        ' 
        Añadir_GP.Location = New Point(298, 187)
        Añadir_GP.Margin = New Padding(3, 2, 3, 2)
        Añadir_GP.Name = "Añadir_GP"
        Añadir_GP.Size = New Size(72, 16)
        Añadir_GP.TabIndex = 48
        Añadir_GP.Text = "Anadir"
        Añadir_GP.UseVisualStyleBackColor = True
        ' 
        ' TextBox_GP_Denominacion
        ' 
        TextBox_GP_Denominacion.Location = New Point(340, 100)
        TextBox_GP_Denominacion.Margin = New Padding(3, 2, 3, 2)
        TextBox_GP_Denominacion.Name = "TextBox_GP_Denominacion"
        TextBox_GP_Denominacion.Size = New Size(116, 23)
        TextBox_GP_Denominacion.TabIndex = 47
        ' 
        ' TextBox_GP_ID
        ' 
        TextBox_GP_ID.Location = New Point(340, 71)
        TextBox_GP_ID.Margin = New Padding(3, 2, 3, 2)
        TextBox_GP_ID.Name = "TextBox_GP_ID"
        TextBox_GP_ID.ReadOnly = True
        TextBox_GP_ID.Size = New Size(116, 23)
        TextBox_GP_ID.TabIndex = 46
        ' 
        ' ComboBox_GP_Pais
        ' 
        ComboBox_GP_Pais.FormattingEnabled = True
        ComboBox_GP_Pais.Location = New Point(340, 136)
        ComboBox_GP_Pais.Margin = New Padding(3, 2, 3, 2)
        ComboBox_GP_Pais.Name = "ComboBox_GP_Pais"
        ComboBox_GP_Pais.Size = New Size(116, 23)
        ComboBox_GP_Pais.TabIndex = 45
        ' 
        ' ListBox_GP
        ' 
        ListBox_GP.FormattingEnabled = True
        ListBox_GP.ItemHeight = 15
        ListBox_GP.Location = New Point(30, 14)
        ListBox_GP.Margin = New Padding(3, 2, 3, 2)
        ListBox_GP.Name = "ListBox_GP"
        ListBox_GP.Size = New Size(178, 214)
        ListBox_GP.TabIndex = 0
        ' 
        ' Calendario
        ' 
        Calendario.Controls.Add(Label12)
        Calendario.Controls.Add(TextBox_GP_Calendario)
        Calendario.Controls.Add(Label11)
        Calendario.Controls.Add(TextBox_Orden_Calendario)
        Calendario.Controls.Add(ListBox_Calendario)
        Calendario.Location = New Point(4, 24)
        Calendario.Margin = New Padding(3, 2, 3, 2)
        Calendario.Name = "Calendario"
        Calendario.Padding = New Padding(3, 2, 3, 2)
        Calendario.Size = New Size(498, 257)
        Calendario.TabIndex = 6
        Calendario.Text = "Calendario"
        Calendario.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(305, 138)
        Label12.Name = "Label12"
        Label12.Size = New Size(40, 15)
        Label12.TabIndex = 5
        Label12.Text = "Orden"
        ' 
        ' TextBox_GP_Calendario
        ' 
        TextBox_GP_Calendario.Enabled = False
        TextBox_GP_Calendario.Location = New Point(348, 72)
        TextBox_GP_Calendario.Margin = New Padding(3, 2, 3, 2)
        TextBox_GP_Calendario.Name = "TextBox_GP_Calendario"
        TextBox_GP_Calendario.Size = New Size(112, 23)
        TextBox_GP_Calendario.TabIndex = 4
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(323, 74)
        Label11.Name = "Label11"
        Label11.Size = New Size(22, 15)
        Label11.TabIndex = 3
        Label11.Text = "GP"
        ' 
        ' TextBox_Orden_Calendario
        ' 
        TextBox_Orden_Calendario.Enabled = False
        TextBox_Orden_Calendario.Location = New Point(348, 136)
        TextBox_Orden_Calendario.Margin = New Padding(3, 2, 3, 2)
        TextBox_Orden_Calendario.Name = "TextBox_Orden_Calendario"
        TextBox_Orden_Calendario.Size = New Size(112, 23)
        TextBox_Orden_Calendario.TabIndex = 1
        ' 
        ' ListBox_Calendario
        ' 
        ListBox_Calendario.FormattingEnabled = True
        ListBox_Calendario.ItemHeight = 15
        ListBox_Calendario.Location = New Point(94, 33)
        ListBox_Calendario.Margin = New Padding(3, 2, 3, 2)
        ListBox_Calendario.Name = "ListBox_Calendario"
        ListBox_Calendario.Size = New Size(166, 154)
        ListBox_Calendario.TabIndex = 0
        ' 
        ' Carreras
        ' 
        Carreras.Controls.Add(ListBox_Carreras)
        Carreras.Location = New Point(4, 24)
        Carreras.Margin = New Padding(3, 2, 3, 2)
        Carreras.Name = "Carreras"
        Carreras.Padding = New Padding(3, 2, 3, 2)
        Carreras.Size = New Size(498, 257)
        Carreras.TabIndex = 4
        Carreras.Text = "Carreras"
        Carreras.UseVisualStyleBackColor = True
        ' 
        ' ListBox_Carreras
        ' 
        ListBox_Carreras.FormattingEnabled = True
        ListBox_Carreras.ItemHeight = 15
        ListBox_Carreras.Location = New Point(116, 16)
        ListBox_Carreras.Margin = New Padding(3, 2, 3, 2)
        ListBox_Carreras.Name = "ListBox_Carreras"
        ListBox_Carreras.Size = New Size(260, 214)
        ListBox_Carreras.TabIndex = 0
        ' 
        ' Contratos
        ' 
        Contratos.Controls.Add(Label18)
        Contratos.Controls.Add(Label17)
        Contratos.Controls.Add(Label16)
        Contratos.Controls.Add(Label15)
        Contratos.Controls.Add(TextBox5)
        Contratos.Controls.Add(textBox_Contratos_Piloto2)
        Contratos.Controls.Add(textBox_Contratos_Piloto1)
        Contratos.Controls.Add(textBox_Contratos_Temporada)
        Contratos.Controls.Add(textBox_Contratos_Escuderia)
        Contratos.Controls.Add(ListBox_Contratos)
        Contratos.Location = New Point(4, 24)
        Contratos.Margin = New Padding(3, 2, 3, 2)
        Contratos.Name = "Contratos"
        Contratos.Padding = New Padding(3, 2, 3, 2)
        Contratos.Size = New Size(498, 257)
        Contratos.TabIndex = 5
        Contratos.Text = "Contratos"
        Contratos.UseVisualStyleBackColor = True
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(237, 179)
        Label18.Name = "Label18"
        Label18.Size = New Size(47, 15)
        Label18.TabIndex = 9
        Label18.Text = "Piloto 2"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(237, 122)
        Label17.Name = "Label17"
        Label17.Size = New Size(47, 15)
        Label17.TabIndex = 8
        Label17.Text = "Piloto 1"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(237, 73)
        Label16.Name = "Label16"
        Label16.Size = New Size(66, 15)
        Label16.TabIndex = 7
        Label16.Text = "Temporada"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(237, 18)
        Label15.Name = "Label15"
        Label15.Size = New Size(57, 15)
        Label15.TabIndex = 6
        Label15.Text = "Escuderia"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(221, 140)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(8, 23)
        TextBox5.TabIndex = 5
        ' 
        ' textBox_Contratos_Piloto2
        ' 
        textBox_Contratos_Piloto2.Location = New Point(330, 176)
        textBox_Contratos_Piloto2.Name = "textBox_Contratos_Piloto2"
        textBox_Contratos_Piloto2.ReadOnly = True
        textBox_Contratos_Piloto2.Size = New Size(131, 23)
        textBox_Contratos_Piloto2.TabIndex = 4
        ' 
        ' textBox_Contratos_Piloto1
        ' 
        textBox_Contratos_Piloto1.Location = New Point(330, 122)
        textBox_Contratos_Piloto1.Name = "textBox_Contratos_Piloto1"
        textBox_Contratos_Piloto1.ReadOnly = True
        textBox_Contratos_Piloto1.Size = New Size(131, 23)
        textBox_Contratos_Piloto1.TabIndex = 3
        ' 
        ' textBox_Contratos_Temporada
        ' 
        textBox_Contratos_Temporada.Location = New Point(330, 73)
        textBox_Contratos_Temporada.Name = "textBox_Contratos_Temporada"
        textBox_Contratos_Temporada.ReadOnly = True
        textBox_Contratos_Temporada.Size = New Size(131, 23)
        textBox_Contratos_Temporada.TabIndex = 2
        ' 
        ' textBox_Contratos_Escuderia
        ' 
        textBox_Contratos_Escuderia.Location = New Point(330, 15)
        textBox_Contratos_Escuderia.Name = "textBox_Contratos_Escuderia"
        textBox_Contratos_Escuderia.ReadOnly = True
        textBox_Contratos_Escuderia.Size = New Size(131, 23)
        textBox_Contratos_Escuderia.TabIndex = 1
        ' 
        ' ListBox_Contratos
        ' 
        ListBox_Contratos.FormattingEnabled = True
        ListBox_Contratos.ItemHeight = 15
        ListBox_Contratos.Location = New Point(16, 15)
        ListBox_Contratos.Margin = New Padding(3, 2, 3, 2)
        ListBox_Contratos.Name = "ListBox_Contratos"
        ListBox_Contratos.Size = New Size(205, 184)
        ListBox_Contratos.TabIndex = 0
        ' 
        ' Conectar
        ' 
        Conectar.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Conectar.Image = CType(resources.GetObject("Conectar.Image"), Image)
        Conectar.Location = New Point(599, 35)
        Conectar.Margin = New Padding(3, 2, 3, 2)
        Conectar.Name = "Conectar"
        Conectar.Size = New Size(90, 264)
        Conectar.TabIndex = 1
        Conectar.Text = "Conectar!!!"
        Conectar.UseVisualStyleBackColor = True
        ' 
        ' Numeros_escuderias
        ' 
        Numeros_escuderias.Enabled = False
        Numeros_escuderias.Location = New Point(432, 311)
        Numeros_escuderias.Margin = New Padding(3, 2, 3, 2)
        Numeros_escuderias.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Numeros_escuderias.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Numeros_escuderias.Name = "Numeros_escuderias"
        Numeros_escuderias.Size = New Size(131, 23)
        Numeros_escuderias.TabIndex = 2
        Numeros_escuderias.Value = New Decimal(New Integer() {5, 0, 0, 0})
        ' 
        ' Numeros_GP
        ' 
        Numeros_GP.Enabled = False
        Numeros_GP.Location = New Point(432, 344)
        Numeros_GP.Margin = New Padding(3, 2, 3, 2)
        Numeros_GP.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Numeros_GP.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Numeros_GP.Name = "Numeros_GP"
        Numeros_GP.Size = New Size(131, 23)
        Numeros_GP.TabIndex = 3
        Numeros_GP.Value = New Decimal(New Integer() {10, 0, 0, 0})
        ' 
        ' Escuderias
        ' 
        Escuderias.AutoSize = True
        Escuderias.Location = New Point(355, 313)
        Escuderias.Name = "Escuderias"
        Escuderias.Size = New Size(62, 15)
        Escuderias.TabIndex = 4
        Escuderias.Text = "Escuderias"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(395, 345)
        Label14.Name = "Label14"
        Label14.Size = New Size(27, 15)
        Label14.TabIndex = 5
        Label14.Text = "GPs"
        ' 
        ' Button_Valores
        ' 
        Button_Valores.Location = New Point(238, 324)
        Button_Valores.Margin = New Padding(3, 2, 3, 2)
        Button_Valores.Name = "Button_Valores"
        Button_Valores.Size = New Size(115, 36)
        Button_Valores.TabIndex = 6
        Button_Valores.Text = "SI QUIERO"
        Button_Valores.UseVisualStyleBackColor = True
        ' 
        ' Label_Valores
        ' 
        Label_Valores.AutoSize = True
        Label_Valores.Location = New Point(21, 313)
        Label_Valores.Name = "Label_Valores"
        Label_Valores.Size = New Size(198, 60)
        Label_Valores.TabIndex = 7
        Label_Valores.Text = "Si quieres elegir los valores " & vbCrLf & "de las escuderias y las GPs " & vbCrLf & "haga clicl en el boton ""Si quiero""" & vbCrLf & "Sino haga click en el boton conectar" & vbCrLf
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label_Valores)
        Controls.Add(Button_Valores)
        Controls.Add(Label14)
        Controls.Add(Escuderias)
        Controls.Add(Numeros_GP)
        Controls.Add(Numeros_escuderias)
        Controls.Add(Conectar)
        Controls.Add(TabControl1)
        Margin = New Padding(3, 2, 3, 2)
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
        Calendario.ResumeLayout(False)
        Calendario.PerformLayout()
        Carreras.ResumeLayout(False)
        Contratos.ResumeLayout(False)
        Contratos.PerformLayout()
        CType(Numeros_escuderias, ComponentModel.ISupportInitialize).EndInit()
        CType(Numeros_GP, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
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
    Friend WithEvents Carreras As TabPage
    Friend WithEvents TextBox_Nombre_Piloto As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox_Apellido_Piloto As TextBox
    Friend WithEvents Contratos As TabPage
    Friend WithEvents ListBox_Carreras As ListBox
    Friend WithEvents ListBox_Contratos As ListBox
    Friend WithEvents ComboBox_GP_Pais As ComboBox
    Friend WithEvents ListBox_GP As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Limpiar_GP As Button
    Friend WithEvents Borrar_GP As Button
    Friend WithEvents Actualizar_GP As Button
    Friend WithEvents Añadir_GP As Button
    Friend WithEvents TextBox_GP_Denominacion As TextBox
    Friend WithEvents TextBox_GP_ID As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Calendario As TabPage
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox_Orden_Calendario As TextBox
    Friend WithEvents ListBox_Calendario As ListBox
    Friend WithEvents TextBox_GP_Calendario As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Numeros_escuderias As NumericUpDown
    Friend WithEvents Numeros_GP As NumericUpDown
    Friend WithEvents Escuderias As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Button_Valores As Button
    Friend WithEvents Label_Valores As Label
    Friend WithEvents textBox_Contratos_Piloto2 As TextBox
    Friend WithEvents textBox_Contratos_Piloto1 As TextBox
    Friend WithEvents textBox_Contratos_Temporada As TextBox
    Friend WithEvents textBox_Contratos_Escuderia As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox5 As TextBox

End Class