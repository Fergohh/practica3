﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        TextBox2 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        ComboBox1 = New ComboBox()
        TextBox1 = New TextBox()
        Limpiar_Escuderia = New Button()
        Borrar_Escuderia = New Button()
        Button1 = New Button()
        Añadir_Escuderia = New Button()
        Label4 = New Label()
        ListBox2 = New ListBox()
        Label5 = New Label()
        TabPage4 = New TabPage()
        TextBox3 = New TextBox()
        Conectar = New Button()
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
        Pais.Padding = New Padding(3, 4, 3, 4)
        Pais.Size = New Size(653, 474)
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
        Pilotos.Padding = New Padding(3, 4, 3, 4)
        Pilotos.Size = New Size(653, 474)
        Pilotos.TabIndex = 1
        Pilotos.Text = "Pilotos"
        Pilotos.UseVisualStyleBackColor = True
        ' 
        ' ComboBox_Pais_Piloto
        ' 
        ComboBox_Pais_Piloto.FormattingEnabled = True
        ComboBox_Pais_Piloto.Location = New Point(381, 166)
        ComboBox_Pais_Piloto.Name = "ComboBox_Pais_Piloto"
        ComboBox_Pais_Piloto.Size = New Size(150, 28)
        ComboBox_Pais_Piloto.TabIndex = 32
        ' 
        ' TextBox_ID_Piloto
        ' 
        TextBox_ID_Piloto.Location = New Point(381, 110)
        TextBox_ID_Piloto.Name = "TextBox_ID_Piloto"
        TextBox_ID_Piloto.Size = New Size(150, 27)
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
        lbl_Pais_Piloto.Location = New Point(341, 166)
        lbl_Pais_Piloto.Name = "lbl_Pais_Piloto"
        lbl_Pais_Piloto.Size = New Size(34, 20)
        lbl_Pais_Piloto.TabIndex = 26
        lbl_Pais_Piloto.Text = "Pais"
        ' 
        ' ListBox_Piloto
        ' 
        ListBox_Piloto.FormattingEnabled = True
        ListBox_Piloto.Location = New Point(102, 100)
        ListBox_Piloto.Name = "ListBox_Piloto"
        ListBox_Piloto.Size = New Size(164, 204)
        ListBox_Piloto.TabIndex = 25
        ' 
        ' lbl_ID_Piloto
        ' 
        lbl_ID_Piloto.AutoSize = True
        lbl_ID_Piloto.Location = New Point(351, 113)
        lbl_ID_Piloto.Name = "lbl_ID_Piloto"
        lbl_ID_Piloto.Size = New Size(24, 20)
        lbl_ID_Piloto.TabIndex = 24
        lbl_ID_Piloto.Text = "ID"
        ' 
        ' GPs
        ' 
        GPs.Controls.Add(lbl_nombre_Escuderia)
        GPs.Controls.Add(TextBox2)
        GPs.Controls.Add(DateTimePicker1)
        GPs.Controls.Add(ComboBox1)
        GPs.Controls.Add(TextBox1)
        GPs.Controls.Add(Limpiar_Escuderia)
        GPs.Controls.Add(Borrar_Escuderia)
        GPs.Controls.Add(Button1)
        GPs.Controls.Add(Añadir_Escuderia)
        GPs.Controls.Add(Label4)
        GPs.Controls.Add(ListBox2)
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
        ' TextBox2
        ' 
        TextBox2.Location = New Point(420, 194)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(150, 27)
        TextBox2.TabIndex = 46
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(297, 253)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(273, 27)
        DateTimePicker1.TabIndex = 45
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(420, 148)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(150, 28)
        ComboBox1.TabIndex = 44
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(420, 100)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 27)
        TextBox1.TabIndex = 43
        ' 
        ' Limpiar_Escuderia
        ' 
        Limpiar_Escuderia.Location = New Point(476, 352)
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
        ' Button1
        ' 
        Button1.Location = New Point(476, 304)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 40
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Añadir_Escuderia
        ' 
        Añadir_Escuderia.Location = New Point(364, 304)
        Añadir_Escuderia.Name = "Añadir_Escuderia"
        Añadir_Escuderia.Size = New Size(94, 29)
        Añadir_Escuderia.TabIndex = 39
        Añadir_Escuderia.Text = "Anadir"
        Añadir_Escuderia.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(380, 151)
        Label4.Name = "Label4"
        Label4.Size = New Size(34, 20)
        Label4.TabIndex = 38
        Label4.Text = "Pais"
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.Location = New Point(82, 94)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(164, 264)
        ListBox2.TabIndex = 37
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
        TabPage4.Controls.Add(TextBox3)
        TabPage4.Location = New Point(4, 29)
        TabPage4.Margin = New Padding(3, 4, 3, 4)
        TabPage4.Name = "TabPage4"
        TabPage4.Size = New Size(653, 474)
        TabPage4.TabIndex = 3
        TabPage4.Text = "GPs"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(251, 224)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(150, 27)
        TextBox3.TabIndex = 44
        ' 
        ' Conectar
        ' 
        Conectar.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        AutoScaleDimensions = New SizeF(8F, 20F)
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
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Limpiar_Escuderia As Button
    Friend WithEvents Borrar_Escuderia As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Añadir_Escuderia As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox

End Class
