<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarPerfil
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModificarPerfil))
        Me.oflImagen = New System.Windows.Forms.OpenFileDialog()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnOut = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.btnAyuda = New System.Windows.Forms.Button()
        Me.btnPerfil = New System.Windows.Forms.Button()
        Me.pnFormulario = New System.Windows.Forms.Panel()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDescripcionV = New System.Windows.Forms.Label()
        Me.lblNombreV = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnFormulario.SuspendLayout()
        Me.SuspendLayout()
        '
        'oflImagen
        '
        Me.oflImagen.FileName = "OpenFileDialog1"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnVolver)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(232, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(969, 130)
        Me.Panel3.TabIndex = 43
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.Transparent
        Me.btnVolver.FlatAppearance.BorderSize = 0
        Me.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnVolver.Image = CType(resources.GetObject("btnVolver.Image"), System.Drawing.Image)
        Me.btnVolver.Location = New System.Drawing.Point(11, 39)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(48, 47)
        Me.btnVolver.TabIndex = 31
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(72, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 47)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Modificar rol"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Controls.Add(Me.Button10)
        Me.Panel4.Controls.Add(Me.Button8)
        Me.Panel4.Controls.Add(Me.Button7)
        Me.Panel4.Controls.Add(Me.Button9)
        Me.Panel4.Controls.Add(Me.Button6)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.btnOut)
        Me.Panel4.Controls.Add(Me.btnSalir)
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Controls.Add(Me.btnInicio)
        Me.Panel4.Controls.Add(Me.btnAyuda)
        Me.Panel4.Controls.Add(Me.btnPerfil)
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(231, 717)
        Me.Panel4.TabIndex = 45
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Transparent
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Button10.Image = CType(resources.GetObject("Button10.Image"), System.Drawing.Image)
        Me.Button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button10.Location = New System.Drawing.Point(15, 547)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(200, 59)
        Me.Button10.TabIndex = 35
        Me.Button10.Text = "Reportes"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(15, 488)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(200, 59)
        Me.Button8.TabIndex = 33
        Me.Button8.Text = "Becas"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(15, 370)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(200, 59)
        Me.Button7.TabIndex = 32
        Me.Button7.Text = "Académico"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Transparent
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Button9.Image = CType(resources.GetObject("Button9.Image"), System.Drawing.Image)
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.Location = New System.Drawing.Point(15, 429)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(200, 59)
        Me.Button9.TabIndex = 34
        Me.Button9.Text = "Seguridad"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(15, 311)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(200, 59)
        Me.Button6.TabIndex = 31
        Me.Button6.Text = "Usuarios"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel5.Controls.Add(Me.PictureBox3)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Location = New System.Drawing.Point(0, 1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(231, 131)
        Me.Panel5.TabIndex = 30
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(89, 31)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(53, 50)
        Me.PictureBox3.TabIndex = 31
        Me.PictureBox3.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.Location = New System.Drawing.Point(234, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(916, 69)
        Me.Panel6.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(49, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 25)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Mauricio Araica"
        '
        'btnOut
        '
        Me.btnOut.BackColor = System.Drawing.Color.Transparent
        Me.btnOut.FlatAppearance.BorderSize = 0
        Me.btnOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOut.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnOut.Image = CType(resources.GetObject("btnOut.Image"), System.Drawing.Image)
        Me.btnOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOut.Location = New System.Drawing.Point(15, 606)
        Me.btnOut.Name = "btnOut"
        Me.btnOut.Size = New System.Drawing.Size(200, 59)
        Me.btnOut.TabIndex = 25
        Me.btnOut.Text = "Salir"
        Me.btnOut.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSalir.Location = New System.Drawing.Point(261, 289)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(122, 80)
        Me.btnSalir.TabIndex = 23
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(-176, 289)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 80)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Seguridad"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnInicio
        '
        Me.btnInicio.BackColor = System.Drawing.Color.Transparent
        Me.btnInicio.FlatAppearance.BorderSize = 0
        Me.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicio.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnInicio.Image = CType(resources.GetObject("btnInicio.Image"), System.Drawing.Image)
        Me.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInicio.Location = New System.Drawing.Point(15, 134)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(200, 59)
        Me.btnInicio.TabIndex = 20
        Me.btnInicio.Text = "Inicio"
        Me.btnInicio.UseVisualStyleBackColor = False
        '
        'btnAyuda
        '
        Me.btnAyuda.BackColor = System.Drawing.Color.Transparent
        Me.btnAyuda.FlatAppearance.BorderSize = 0
        Me.btnAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAyuda.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAyuda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAyuda.Image = CType(resources.GetObject("btnAyuda.Image"), System.Drawing.Image)
        Me.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAyuda.Location = New System.Drawing.Point(15, 252)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(200, 59)
        Me.btnAyuda.TabIndex = 18
        Me.btnAyuda.Text = "Ayuda"
        Me.btnAyuda.UseVisualStyleBackColor = False
        '
        'btnPerfil
        '
        Me.btnPerfil.BackColor = System.Drawing.Color.Transparent
        Me.btnPerfil.FlatAppearance.BorderSize = 0
        Me.btnPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPerfil.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPerfil.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPerfil.Image = CType(resources.GetObject("btnPerfil.Image"), System.Drawing.Image)
        Me.btnPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPerfil.Location = New System.Drawing.Point(15, 193)
        Me.btnPerfil.Name = "btnPerfil"
        Me.btnPerfil.Size = New System.Drawing.Size(200, 59)
        Me.btnPerfil.TabIndex = 17
        Me.btnPerfil.Text = "Mi perfil"
        Me.btnPerfil.UseVisualStyleBackColor = False
        '
        'pnFormulario
        '
        Me.pnFormulario.BackColor = System.Drawing.Color.White
        Me.pnFormulario.Controls.Add(Me.TextBox4)
        Me.pnFormulario.Controls.Add(Me.TextBox3)
        Me.pnFormulario.Controls.Add(Me.Label7)
        Me.pnFormulario.Controls.Add(Me.Label6)
        Me.pnFormulario.Controls.Add(Me.TextBox2)
        Me.pnFormulario.Controls.Add(Me.TextBox1)
        Me.pnFormulario.Controls.Add(Me.Label5)
        Me.pnFormulario.Controls.Add(Me.Label3)
        Me.pnFormulario.Controls.Add(Me.lblDescripcionV)
        Me.pnFormulario.Controls.Add(Me.lblNombreV)
        Me.pnFormulario.Controls.Add(Me.btnRegistrar)
        Me.pnFormulario.Controls.Add(Me.txtNombre)
        Me.pnFormulario.Controls.Add(Me.Label4)
        Me.pnFormulario.Location = New System.Drawing.Point(232, 129)
        Me.pnFormulario.Name = "pnFormulario"
        Me.pnFormulario.Size = New System.Drawing.Size(966, 579)
        Me.pnFormulario.TabIndex = 47
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(341, 418)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(226, 33)
        Me.TextBox4.TabIndex = 57
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(341, 326)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(226, 33)
        Me.TextBox3.TabIndex = 56
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(336, 376)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 25)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Telefono:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(336, 286)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 25)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Dirección:"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(341, 149)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(226, 33)
        Me.TextBox2.TabIndex = 53
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(341, 241)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(226, 33)
        Me.TextBox1.TabIndex = 52
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(336, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 25)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Segundo apelido:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(336, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 25)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Primer apellido:"
        '
        'lblDescripcionV
        '
        Me.lblDescripcionV.Location = New System.Drawing.Point(586, 64)
        Me.lblDescripcionV.Name = "lblDescripcionV"
        Me.lblDescripcionV.Size = New System.Drawing.Size(33, 31)
        Me.lblDescripcionV.TabIndex = 49
        '
        'lblNombreV
        '
        Me.lblNombreV.Location = New System.Drawing.Point(597, 62)
        Me.lblNombreV.Name = "lblNombreV"
        Me.lblNombreV.Size = New System.Drawing.Size(32, 33)
        Me.lblNombreV.TabIndex = 48
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.White
        Me.btnRegistrar.FlatAppearance.BorderSize = 2
        Me.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrar.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnRegistrar.Location = New System.Drawing.Point(341, 499)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(226, 37)
        Me.btnRegistrar.TabIndex = 47
        Me.btnRegistrar.Text = "Modificar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(341, 64)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(226, 33)
        Me.txtNombre.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(336, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 25)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Nombre:"
        '
        'FrmModificarPerfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1202, 720)
        Me.Controls.Add(Me.pnFormulario)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmModificarPerfil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAgregarAlumno"
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnFormulario.ResumeLayout(False)
        Me.pnFormulario.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents oflImagen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents btnOut As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnInicio As System.Windows.Forms.Button
    Friend WithEvents btnAyuda As System.Windows.Forms.Button
    Friend WithEvents btnPerfil As System.Windows.Forms.Button
    Friend WithEvents pnFormulario As System.Windows.Forms.Panel
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents lblNombreV As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblDescripcionV As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
