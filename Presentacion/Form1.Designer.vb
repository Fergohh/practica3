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
        ListBox_Contratos = New ListBox()
        Conectar = New Button()
        TabControl1.SuspendLayout()
        Pais.SuspendLayout()
        Pilotos.SuspendLayout()
        GPs.SuspendLayout()
        TabPage4.SuspendLayout()
        Calendario.SuspendLayout()
        Carreras.SuspendLayout()
        Contratos.SuspendLayout()
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
        TabControl1.Location = New Point(80, 39)
        TabControl1.Margin = New Padding(3, 4, 3, 4)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(661, 507)
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
        Pais.Location = New Point(4, 29)
        Pais.Margin = New Padding(3, 4, 3, 4)
        Pais.Name = "Pais"
        Pais.Padding = New Padding(3)
        Pais.Size = New Size(570, 352)
        Pais.TabIndex = 0
        Pais.Text = "Pais"
        Pais.UseVisualStyleBackColor = True
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(89, 341)
        ListView1.Margin = New Padding(3, 4, 3, 4)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(138, 64)
        ListView1.TabIndex = 12
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(303, 191)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 20)
        Label3.TabIndex = 11
        Label3.Text = "Hab."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(303, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 20)
        Label2.TabIndex = 10
        Label2.Text = "Nombre"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(303, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(24, 20)
        Label1.TabIndex = 9
        Label1.Text = "ID"
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(379, 29)
        txtID.Margin = New Padding(3, 4, 3, 4)
        txtID.Name = "txtID"
        txtID.Size = New Size(242, 27)
        txtID.TabIndex = 8
        ' 
        ' Limpiar
        ' 
        Limpiar.Location = New Point(511, 312)
        Limpiar.Margin = New Padding(3, 4, 3, 4)
        Limpiar.Name = "Limpiar"
        Limpiar.Size = New Size(111, 39)
        Limpiar.TabIndex = 7
        Limpiar.Text = "Limpiar"
        Limpiar.UseVisualStyleBackColor = True
        ' 
        ' Borrar
        ' 
        Borrar.Location = New Point(379, 312)
        Borrar.Margin = New Padding(3, 4, 3, 4)
        Borrar.Name = "Borrar"
        Borrar.Size = New Size(111, 39)
        Borrar.TabIndex = 6
        Borrar.Text = "Borrar"
        Borrar.UseVisualStyleBackColor = True
        ' 
        ' Actualizar
        ' 
        Actualizar.Location = New Point(511, 252)
        Actualizar.Margin = New Padding(3, 4, 3, 4)
        Actualizar.Name = "Actualizar"
        Actualizar.Size = New Size(111, 39)
        Actualizar.TabIndex = 5
        Actualizar.Text = "Actualizar"
        Actualizar.UseVisualStyleBackColor = True
        ' 
        ' Añadir
        ' 
        Añadir.Location = New Point(379, 252)
        Añadir.Margin = New Padding(3, 4, 3, 4)
        Añadir.Name = "Añadir"
        Añadir.Size = New Size(111, 39)
        Añadir.TabIndex = 4
        Añadir.Text = "Añadir"
        Añadir.UseVisualStyleBackColor = True
        ' 
        ' txtHab
        ' 
        txtHab.Location = New Point(379, 187)
        txtHab.Margin = New Padding(3, 4, 3, 4)
        txtHab.Name = "txtHab"
        txtHab.Size = New Size(242, 27)
        txtHab.TabIndex = 2
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(379, 101)
        txtNombre.Margin = New Padding(3, 4, 3, 4)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(242, 27)
        txtNombre.TabIndex = 1
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(34, 33)
        ListBox1.Margin = New Padding(3, 4, 3, 4)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(242, 284)
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
        Pilotos.Location = New Point(4, 29)
        Pilotos.Margin = New Padding(3, 4, 3, 4)
        Pilotos.Name = "Pilotos"
        Pilotos.Padding = New Padding(3, 3, 3, 3)
        Pilotos.Size = New Size(570, 352)
        Pilotos.TabIndex = 1
        Pilotos.Text = "Pilotos"
        Pilotos.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(233, 236)
        Label7.Name = "Label7"
        Label7.Size = New Size(66, 20)
        Label7.TabIndex = 36
        Label7.Text = "Apellido"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(233, 171)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 20)
        Label6.TabIndex = 35
        Label6.Text = "Nombre"
        ' 
        ' TextBox_Apellido_Piloto
        ' 
        TextBox_Apellido_Piloto.Location = New Point(305, 229)
        TextBox_Apellido_Piloto.Margin = New Padding(3, 4, 3, 4)
        TextBox_Apellido_Piloto.Name = "TextBox_Apellido_Piloto"
        TextBox_Apellido_Piloto.Size = New Size(297, 27)
        TextBox_Apellido_Piloto.TabIndex = 34
        ' 
        ' TextBox_Nombre_Piloto
        ' 
        TextBox_Nombre_Piloto.Location = New Point(305, 167)
        TextBox_Nombre_Piloto.Margin = New Padding(3, 4, 3, 4)
        TextBox_Nombre_Piloto.Name = "TextBox_Nombre_Piloto"
        TextBox_Nombre_Piloto.Size = New Size(297, 27)
        TextBox_Nombre_Piloto.TabIndex = 33
        ' 
        ' ComboBox_Pais_Piloto
        ' 
        ComboBox_Pais_Piloto.FormattingEnabled = True
        ComboBox_Pais_Piloto.Location = New Point(305, 93)
        ComboBox_Pais_Piloto.Name = "ComboBox_Pais_Piloto"
        ComboBox_Pais_Piloto.Size = New Size(297, 28)
        ComboBox_Pais_Piloto.TabIndex = 32
        ' 
        ' TextBox_ID_Piloto
        ' 
        TextBox_ID_Piloto.Location = New Point(305, 31)
        TextBox_ID_Piloto.Name = "TextBox_ID_Piloto"
        TextBox_ID_Piloto.ReadOnly = True
        TextBox_ID_Piloto.Size = New Size(297, 27)
        TextBox_ID_Piloto.TabIndex = 31
        ' 
        ' Limpiar_Piloto
        ' 
        Limpiar_Piloto.Location = New Point(457, 345)
        Limpiar_Piloto.Name = "Limpiar_Piloto"
        Limpiar_Piloto.Size = New Size(94, 29)
        Limpiar_Piloto.TabIndex = 30
        Limpiar_Piloto.Text = "Limpiar"
        Limpiar_Piloto.UseVisualStyleBackColor = True
        ' 
        ' Borrar_Piloto
        ' 
        Borrar_Piloto.Location = New Point(326, 345)
        Borrar_Piloto.Name = "Borrar_Piloto"
        Borrar_Piloto.Size = New Size(94, 29)
        Borrar_Piloto.TabIndex = 29
        Borrar_Piloto.Text = "Borrar"
        Borrar_Piloto.UseVisualStyleBackColor = True
        ' 
        ' Actualizar_Piloto
        ' 
        Actualizar_Piloto.Location = New Point(457, 297)
        Actualizar_Piloto.Name = "Actualizar_Piloto"
        Actualizar_Piloto.Size = New Size(94, 29)
        Actualizar_Piloto.TabIndex = 28
        Actualizar_Piloto.Text = "Actualizar"
        Actualizar_Piloto.UseVisualStyleBackColor = True
        ' 
        ' Añadir_Piloto
        ' 
        Añadir_Piloto.Location = New Point(325, 297)
        Añadir_Piloto.Name = "Añadir_Piloto"
        Añadir_Piloto.Size = New Size(94, 29)
        Añadir_Piloto.TabIndex = 27
        Añadir_Piloto.Text = "Anadir"
        Añadir_Piloto.UseVisualStyleBackColor = True
        ' 
        ' lbl_Pais_Piloto
        ' 
        lbl_Pais_Piloto.AutoSize = True
        lbl_Pais_Piloto.Location = New Point(259, 93)
        lbl_Pais_Piloto.Name = "lbl_Pais_Piloto"
        lbl_Pais_Piloto.Size = New Size(34, 20)
        lbl_Pais_Piloto.TabIndex = 26
        lbl_Pais_Piloto.Text = "Pais"
        ' 
        ' ListBox_Piloto
        ' 
        ListBox_Piloto.FormattingEnabled = True
        ListBox_Piloto.Location = New Point(31, 35)
        ListBox_Piloto.Name = "ListBox_Piloto"
        ListBox_Piloto.Size = New Size(167, 384)
        ListBox_Piloto.TabIndex = 25
        ' 
        ' lbl_ID_Piloto
        ' 
        lbl_ID_Piloto.AutoSize = True
        lbl_ID_Piloto.Location = New Point(271, 35)
        lbl_ID_Piloto.Name = "lbl_ID_Piloto"
        lbl_ID_Piloto.Size = New Size(24, 20)
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
        GPs.Location = New Point(4, 29)
        GPs.Margin = New Padding(3, 4, 3, 4)
        GPs.Name = "GPs"
        GPs.Size = New Size(653, 474)
        GPs.TabIndex = 2
        GPs.Text = "Escuderias"
        GPs.UseVisualStyleBackColor = True
        ' 
        ' lbl_nombre_Escuderia
        ' 
        lbl_nombre_Escuderia.AutoSize = True
        lbl_nombre_Escuderia.Location = New Point(350, 197)
        lbl_nombre_Escuderia.Name = "lbl_nombre_Escuderia"
        lbl_nombre_Escuderia.Size = New Size(64, 20)
        lbl_nombre_Escuderia.TabIndex = 47
        lbl_nombre_Escuderia.Text = "Nombre"
        ' 
        ' TextBox_Nombre_Escuderia
        ' 
        TextBox_Nombre_Escuderia.Location = New Point(421, 195)
        TextBox_Nombre_Escuderia.Name = "TextBox_Nombre_Escuderia"
        TextBox_Nombre_Escuderia.Size = New Size(150, 27)
        TextBox_Nombre_Escuderia.TabIndex = 46
        ' 
        ' DateTimePicker_Escuderia
        ' 
        DateTimePicker_Escuderia.Location = New Point(297, 253)
        DateTimePicker_Escuderia.Name = "DateTimePicker_Escuderia"
        DateTimePicker_Escuderia.Size = New Size(273, 27)
        DateTimePicker_Escuderia.TabIndex = 45
        ' 
        ' ComboBox_Pais_Escuderia
        ' 
        ComboBox_Pais_Escuderia.FormattingEnabled = True
        ComboBox_Pais_Escuderia.Location = New Point(421, 148)
        ComboBox_Pais_Escuderia.Name = "ComboBox_Pais_Escuderia"
        ComboBox_Pais_Escuderia.Size = New Size(150, 28)
        ComboBox_Pais_Escuderia.TabIndex = 44
        ' 
        ' TextBox_ID_Escuderia
        ' 
        TextBox_ID_Escuderia.Location = New Point(421, 100)
        TextBox_ID_Escuderia.Name = "TextBox_ID_Escuderia"
        TextBox_ID_Escuderia.ReadOnly = True
        TextBox_ID_Escuderia.Size = New Size(150, 27)
        TextBox_ID_Escuderia.TabIndex = 43
        ' 
        ' Limpiar_Escuderia
        ' 
        Limpiar_Escuderia.Location = New Point(475, 352)
        Limpiar_Escuderia.Name = "Limpiar_Escuderia"
        Limpiar_Escuderia.Size = New Size(94, 29)
        Limpiar_Escuderia.TabIndex = 42
        Limpiar_Escuderia.Text = "Limpiar"
        Limpiar_Escuderia.UseVisualStyleBackColor = True
        ' 
        ' Borrar_Escuderia
        ' 
        Borrar_Escuderia.Location = New Point(365, 352)
        Borrar_Escuderia.Name = "Borrar_Escuderia"
        Borrar_Escuderia.Size = New Size(94, 29)
        Borrar_Escuderia.TabIndex = 41
        Borrar_Escuderia.Text = "Borrar"
        Borrar_Escuderia.UseVisualStyleBackColor = True
        ' 
        ' Actualizar_Escuderia
        ' 
        Actualizar_Escuderia.Location = New Point(475, 304)
        Actualizar_Escuderia.Name = "Actualizar_Escuderia"
        Actualizar_Escuderia.Size = New Size(94, 29)
        Actualizar_Escuderia.TabIndex = 40
        Actualizar_Escuderia.Text = "Actualizar"
        Actualizar_Escuderia.UseVisualStyleBackColor = True
        ' 
        ' Añadir_Escuderia
        ' 
        Añadir_Escuderia.Location = New Point(363, 304)
        Añadir_Escuderia.Name = "Añadir_Escuderia"
        Añadir_Escuderia.Size = New Size(94, 29)
        Añadir_Escuderia.TabIndex = 39
        Añadir_Escuderia.Text = "Anadir"
        Añadir_Escuderia.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(379, 151)
        Label4.Name = "Label4"
        Label4.Size = New Size(34, 20)
        Label4.TabIndex = 38
        Label4.Text = "Pais"
        ' 
        ' ListBox_Escuderia
        ' 
        ListBox_Escuderia.FormattingEnabled = True
        ListBox_Escuderia.Location = New Point(82, 93)
        ListBox_Escuderia.Name = "ListBox_Escuderia"
        ListBox_Escuderia.Size = New Size(164, 264)
        ListBox_Escuderia.TabIndex = 37
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(390, 103)
        Label5.Name = "Label5"
        Label5.Size = New Size(24, 20)
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
        TabPage4.Location = New Point(4, 29)
        TabPage4.Margin = New Padding(3, 4, 3, 4)
        TabPage4.Name = "TabPage4"
        TabPage4.Size = New Size(653, 474)
        TabPage4.TabIndex = 3
        TabPage4.Text = "GPs"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(397, 245)
        Label10.Name = "Label10"
        Label10.Size = New Size(34, 20)
        Label10.TabIndex = 54
        Label10.Text = "Pais"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(341, 181)
        Label9.Name = "Label9"
        Label9.Size = New Size(98, 20)
        Label9.TabIndex = 53
        Label9.Text = "Denomiacion"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(397, 131)
        Label8.Name = "Label8"
        Label8.Size = New Size(40, 20)
        Label8.TabIndex = 52
        Label8.Text = "IdGP"
        ' 
        ' Limpiar_GP
        ' 
        Limpiar_GP.Location = New Point(501, 380)
        Limpiar_GP.Name = "Limpiar_GP"
        Limpiar_GP.Size = New Size(94, 29)
        Limpiar_GP.TabIndex = 51
        Limpiar_GP.Text = "Limpiar"
        Limpiar_GP.UseVisualStyleBackColor = True
        ' 
        ' Borrar_GP
        ' 
        Borrar_GP.Location = New Point(391, 380)
        Borrar_GP.Name = "Borrar_GP"
        Borrar_GP.Size = New Size(94, 29)
        Borrar_GP.TabIndex = 50
        Borrar_GP.Text = "Borrar"
        Borrar_GP.UseVisualStyleBackColor = True
        ' 
        ' Actualizar_GP
        ' 
        Actualizar_GP.Location = New Point(501, 332)
        Actualizar_GP.Name = "Actualizar_GP"
        Actualizar_GP.Size = New Size(94, 29)
        Actualizar_GP.TabIndex = 49
        Actualizar_GP.Text = "Actualizar"
        Actualizar_GP.UseVisualStyleBackColor = True
        ' 
        ' Añadir_GP
        ' 
        Añadir_GP.Location = New Point(389, 332)
        Añadir_GP.Name = "Añadir_GP"
        Añadir_GP.Size = New Size(94, 29)
        Añadir_GP.TabIndex = 48
        Añadir_GP.Text = "Anadir"
        Añadir_GP.UseVisualStyleBackColor = True
        ' 
        ' TextBox_GP_Denominacion
        ' 
        TextBox_GP_Denominacion.Location = New Point(445, 179)
        TextBox_GP_Denominacion.Name = "TextBox_GP_Denominacion"
        TextBox_GP_Denominacion.Size = New Size(150, 27)
        TextBox_GP_Denominacion.TabIndex = 47
        ' 
        ' TextBox_GP_ID
        ' 
        TextBox_GP_ID.Location = New Point(445, 127)
        TextBox_GP_ID.Name = "TextBox_GP_ID"
        TextBox_GP_ID.ReadOnly = True
        TextBox_GP_ID.Size = New Size(150, 27)
        TextBox_GP_ID.TabIndex = 46
        ' 
        ' ComboBox_GP_Pais
        ' 
        ComboBox_GP_Pais.FormattingEnabled = True
        ComboBox_GP_Pais.Location = New Point(445, 243)
        ComboBox_GP_Pais.Name = "ComboBox_GP_Pais"
        ComboBox_GP_Pais.Size = New Size(150, 28)
        ComboBox_GP_Pais.TabIndex = 45
        ' 
        ' ListBox_GP
        ' 
        ListBox_GP.FormattingEnabled = True
        ListBox_GP.Location = New Point(39, 25)
        ListBox_GP.Name = "ListBox_GP"
        ListBox_GP.Size = New Size(231, 384)
        ListBox_GP.TabIndex = 0
        ' 
        ' Calendario
        ' 
        Calendario.Controls.Add(Label12)
        Calendario.Controls.Add(TextBox_GP_Calendario)
        Calendario.Controls.Add(Label11)
        Calendario.Controls.Add(TextBox_Orden_Calendario)
        Calendario.Controls.Add(ListBox_Calendario)
        Calendario.Location = New Point(4, 29)
        Calendario.Name = "Calendario"
        Calendario.Padding = New Padding(3)
        Calendario.Size = New Size(653, 474)
        Calendario.TabIndex = 6
        Calendario.Text = "Calendario"
        Calendario.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(399, 246)
        Label12.Name = "Label12"
        Label12.Size = New Size(50, 20)
        Label12.TabIndex = 5
        Label12.Text = "Orden"
        ' 
        ' TextBox_GP_Calendario
        ' 
        TextBox_GP_Calendario.Enabled = False
        TextBox_GP_Calendario.Location = New Point(455, 128)
        TextBox_GP_Calendario.Name = "TextBox_GP_Calendario"
        TextBox_GP_Calendario.Size = New Size(145, 27)
        TextBox_GP_Calendario.TabIndex = 4
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(422, 131)
        Label11.Name = "Label11"
        Label11.Size = New Size(27, 20)
        Label11.TabIndex = 3
        Label11.Text = "GP"
        ' 
        ' TextBox_Orden_Calendario
        ' 
        TextBox_Orden_Calendario.Enabled = False
        TextBox_Orden_Calendario.Location = New Point(455, 243)
        TextBox_Orden_Calendario.Name = "TextBox_Orden_Calendario"
        TextBox_Orden_Calendario.Size = New Size(145, 27)
        TextBox_Orden_Calendario.TabIndex = 1
        ' 
        ' ListBox_Calendario
        ' 
        ListBox_Calendario.FormattingEnabled = True
        ListBox_Calendario.Location = New Point(124, 58)
        ListBox_Calendario.Name = "ListBox_Calendario"
        ListBox_Calendario.Size = New Size(215, 284)
        ListBox_Calendario.TabIndex = 0
        ' 
        ' Carreras
        ' 
        Carreras.Controls.Add(ListBox_Carreras)
        Carreras.Location = New Point(4, 29)
        Carreras.Margin = New Padding(3, 4, 3, 4)
        Carreras.Name = "Carreras"
        Carreras.Padding = New Padding(3, 3, 3, 3)
        Carreras.Size = New Size(570, 352)
        Carreras.TabIndex = 4
        Carreras.Text = "Carreras"
        Carreras.UseVisualStyleBackColor = True
        ' 
        ' ListBox_Carreras
        ' 
        ListBox_Carreras.FormattingEnabled = True
        ListBox_Carreras.Location = New Point(152, 28)
        ListBox_Carreras.Name = "ListBox_Carreras"
        ListBox_Carreras.Size = New Size(338, 384)
        ListBox_Carreras.TabIndex = 0
        ' 
        ' Contratos
        ' 
        Contratos.Controls.Add(ListBox_Contratos)
        Contratos.Location = New Point(4, 29)
        Contratos.Name = "Contratos"
        Contratos.Padding = New Padding(3)
        Contratos.Size = New Size(653, 474)
        Contratos.TabIndex = 5
        Contratos.Text = "Contratos"
        Contratos.UseVisualStyleBackColor = True
        ' 
        ' ListBox_Contratos
        ' 
        ListBox_Contratos.FormattingEnabled = True
        ListBox_Contratos.Location = New Point(197, 28)
        ListBox_Contratos.Name = "ListBox_Contratos"
        ListBox_Contratos.Size = New Size(267, 344)
        ListBox_Contratos.TabIndex = 0
        ' 
        ' Conectar
        ' 
        Conectar.Font = New Font("Segoe UI", 48.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Conectar.Image = CType(resources.GetObject("Conectar.Image"), Image)
        Conectar.Location = New Point(783, 63)
        Conectar.Margin = New Padding(3, 4, 3, 4)
        Conectar.Name = "Conectar"
        Conectar.Size = New Size(118, 469)
        Conectar.TabIndex = 1
        Conectar.Text = "Conectar!!!"
        Conectar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 600)
        Controls.Add(Conectar)
        Controls.Add(TabControl1)
        Margin = New Padding(3, 4, 3, 4)
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

End Class
