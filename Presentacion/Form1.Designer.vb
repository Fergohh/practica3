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
        GPs = New TabPage()
        TabPage4 = New TabPage()
        Conectar = New Button()
        Button1 = New Button()
        TabControl1.SuspendLayout()
        Pais.SuspendLayout()
        Pilotos.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(Pais)
        TabControl1.Controls.Add(Pilotos)
        TabControl1.Controls.Add(GPs)
        TabControl1.Controls.Add(TabPage4)
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
        Pilotos.Controls.Add(Button1)
        Pilotos.Location = New Point(4, 24)
        Pilotos.Name = "Pilotos"
        Pilotos.Padding = New Padding(3)
        Pilotos.Size = New Size(570, 352)
        Pilotos.TabIndex = 1
        Pilotos.Text = "Pilotos"
        Pilotos.UseVisualStyleBackColor = True
        ' 
        ' GPs
        ' 
        GPs.Location = New Point(4, 24)
        GPs.Name = "GPs"
        GPs.Size = New Size(570, 352)
        GPs.TabIndex = 2
        GPs.Text = "Escuderias"
        GPs.UseVisualStyleBackColor = True
        ' 
        ' TabPage4
        ' 
        TabPage4.Location = New Point(4, 24)
        TabPage4.Name = "TabPage4"
        TabPage4.Size = New Size(570, 352)
        TabPage4.TabIndex = 3
        TabPage4.Text = "GPs"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' Conectar
        ' 
        Conectar.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Conectar.Location = New Point(685, 47)
        Conectar.Name = "Conectar"
        Conectar.Size = New Size(103, 352)
        Conectar.TabIndex = 1
        Conectar.Text = "Conectar!!!"
        Conectar.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(306, 188)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
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
    Friend WithEvents Button1 As Button

End Class
