<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistrarTipoBeca
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegistrarTipoBeca))
        Me.pnRegistrarTipoBeca = New System.Windows.Forms.Panel()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.LblPeriodo = New System.Windows.Forms.Label()
        Me.rctDescripcion = New System.Windows.Forms.RichTextBox()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.cmbPeriodo = New System.Windows.Forms.ComboBox()
        Me.lblRequsito = New System.Windows.Forms.Label()
        Me.ChkLbRequisito = New System.Windows.Forms.CheckedListBox()
        Me.lblBeneficios = New System.Windows.Forms.Label()
        Me.ChkLbBeneficios = New System.Windows.Forms.CheckedListBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombree = New System.Windows.Forms.Label()
        Me.lblNombreV = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.lblTituloRegistraTipoBeca = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.btnOut = New System.Windows.Forms.Button()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.btnAyuda = New System.Windows.Forms.Button()
        Me.btnPerfil = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnRegistrarTipoBeca.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnRegistrarTipoBeca
        '
        Me.pnRegistrarTipoBeca.BackColor = System.Drawing.Color.White
        Me.pnRegistrarTipoBeca.Controls.Add(Me.lblDescripcion)
        Me.pnRegistrarTipoBeca.Controls.Add(Me.lblEstado)
        Me.pnRegistrarTipoBeca.Controls.Add(Me.LblPeriodo)
        Me.pnRegistrarTipoBeca.Controls.Add(Me.rctDescripcion)
        Me.pnRegistrarTipoBeca.Controls.Add(Me.cmbEstado)
        Me.pnRegistrarTipoBeca.Controls.Add(Me.cmbPeriodo)
        Me.pnRegistrarTipoBeca.Controls.Add(Me.lblRequsito)
        Me.pnRegistrarTipoBeca.Controls.Add(Me.ChkLbRequisito)
        Me.pnRegistrarTipoBeca.Controls.Add(Me.lblBeneficios)
        Me.pnRegistrarTipoBeca.Controls.Add(Me.ChkLbBeneficios)
        Me.pnRegistrarTipoBeca.Controls.Add(Me.btnRegistrar)
        Me.pnRegistrarTipoBeca.Controls.Add(Me.txtNombre)
        Me.pnRegistrarTipoBeca.Controls.Add(Me.lblNombree)
        Me.pnRegistrarTipoBeca.Controls.Add(Me.lblNombreV)
        Me.pnRegistrarTipoBeca.Location = New System.Drawing.Point(231, 128)
        Me.pnRegistrarTipoBeca.Name = "pnRegistrarTipoBeca"
        Me.pnRegistrarTipoBeca.Size = New System.Drawing.Size(969, 589)
        Me.pnRegistrarTipoBeca.TabIndex = 52
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Segoe UI Light", 14.25!)
        Me.lblDescripcion.Location = New System.Drawing.Point(61, 258)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(104, 25)
        Me.lblDescripcion.TabIndex = 61
        Me.lblDescripcion.Text = "Descripción"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Segoe UI Light", 14.25!)
        Me.lblEstado.Location = New System.Drawing.Point(61, 182)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(70, 25)
        Me.lblEstado.TabIndex = 60
        Me.lblEstado.Text = "Estado:"
        '
        'LblPeriodo
        '
        Me.LblPeriodo.AutoSize = True
        Me.LblPeriodo.Font = New System.Drawing.Font("Segoe UI Light", 14.25!)
        Me.LblPeriodo.Location = New System.Drawing.Point(61, 105)
        Me.LblPeriodo.Name = "LblPeriodo"
        Me.LblPeriodo.Size = New System.Drawing.Size(79, 25)
        Me.LblPeriodo.TabIndex = 59
        Me.LblPeriodo.Text = "Periodo:"
        '
        'rctDescripcion
        '
        Me.rctDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rctDescripcion.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rctDescripcion.Location = New System.Drawing.Point(66, 290)
        Me.rctDescripcion.Name = "rctDescripcion"
        Me.rctDescripcion.Size = New System.Drawing.Size(296, 159)
        Me.rctDescripcion.TabIndex = 58
        Me.rctDescripcion.Text = ""
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Nombre"})
        Me.cmbEstado.Location = New System.Drawing.Point(66, 210)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(201, 33)
        Me.cmbEstado.TabIndex = 57
        '
        'cmbPeriodo
        '
        Me.cmbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPeriodo.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPeriodo.FormattingEnabled = True
        Me.cmbPeriodo.Items.AddRange(New Object() {"Nombre"})
        Me.cmbPeriodo.Location = New System.Drawing.Point(66, 133)
        Me.cmbPeriodo.Name = "cmbPeriodo"
        Me.cmbPeriodo.Size = New System.Drawing.Size(201, 33)
        Me.cmbPeriodo.TabIndex = 56
        '
        'lblRequsito
        '
        Me.lblRequsito.AutoSize = True
        Me.lblRequsito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblRequsito.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRequsito.Location = New System.Drawing.Point(693, 33)
        Me.lblRequsito.Name = "lblRequsito"
        Me.lblRequsito.Size = New System.Drawing.Size(97, 25)
        Me.lblRequsito.TabIndex = 55
        Me.lblRequsito.Text = "Requisitos:"
        '
        'ChkLbRequisito
        '
        Me.ChkLbRequisito.CheckOnClick = True
        Me.ChkLbRequisito.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkLbRequisito.FormattingEnabled = True
        Me.ChkLbRequisito.Location = New System.Drawing.Point(698, 61)
        Me.ChkLbRequisito.Name = "ChkLbRequisito"
        Me.ChkLbRequisito.Size = New System.Drawing.Size(219, 388)
        Me.ChkLbRequisito.TabIndex = 54
        Me.ChkLbRequisito.ThreeDCheckBoxes = True
        '
        'lblBeneficios
        '
        Me.lblBeneficios.AutoSize = True
        Me.lblBeneficios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblBeneficios.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeneficios.Location = New System.Drawing.Point(421, 33)
        Me.lblBeneficios.Name = "lblBeneficios"
        Me.lblBeneficios.Size = New System.Drawing.Size(95, 25)
        Me.lblBeneficios.TabIndex = 53
        Me.lblBeneficios.Text = "Beneficios:"
        '
        'ChkLbBeneficios
        '
        Me.ChkLbBeneficios.CheckOnClick = True
        Me.ChkLbBeneficios.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkLbBeneficios.FormattingEnabled = True
        Me.ChkLbBeneficios.Location = New System.Drawing.Point(427, 61)
        Me.ChkLbBeneficios.Name = "ChkLbBeneficios"
        Me.ChkLbBeneficios.Size = New System.Drawing.Size(219, 388)
        Me.ChkLbBeneficios.TabIndex = 52
        Me.ChkLbBeneficios.ThreeDCheckBoxes = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.White
        Me.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrar.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnRegistrar.Location = New System.Drawing.Point(226, 516)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(513, 37)
        Me.btnRegistrar.TabIndex = 51
        Me.btnRegistrar.Text = "Agregar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(66, 59)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(226, 33)
        Me.txtNombre.TabIndex = 50
        '
        'lblNombree
        '
        Me.lblNombree.AutoSize = True
        Me.lblNombree.Font = New System.Drawing.Font("Segoe UI Light", 14.25!)
        Me.lblNombree.Location = New System.Drawing.Point(61, 33)
        Me.lblNombree.Name = "lblNombree"
        Me.lblNombree.Size = New System.Drawing.Size(83, 25)
        Me.lblNombree.TabIndex = 49
        Me.lblNombree.Text = "Nombre:"
        '
        'lblNombreV
        '
        Me.lblNombreV.AutoSize = True
        Me.lblNombreV.Location = New System.Drawing.Point(459, 56)
        Me.lblNombreV.Name = "lblNombreV"
        Me.lblNombreV.Size = New System.Drawing.Size(0, 13)
        Me.lblNombreV.TabIndex = 48
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnVolver)
        Me.Panel3.Controls.Add(Me.lblTituloRegistraTipoBeca)
        Me.Panel3.Location = New System.Drawing.Point(231, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(974, 130)
        Me.Panel3.TabIndex = 62
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
        Me.btnVolver.TabIndex = 33
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'lblTituloRegistraTipoBeca
        '
        Me.lblTituloRegistraTipoBeca.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblTituloRegistraTipoBeca.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloRegistraTipoBeca.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.lblTituloRegistraTipoBeca.Location = New System.Drawing.Point(72, 39)
        Me.lblTituloRegistraTipoBeca.Name = "lblTituloRegistraTipoBeca"
        Me.lblTituloRegistraTipoBeca.Size = New System.Drawing.Size(516, 59)
        Me.lblTituloRegistraTipoBeca.TabIndex = 32
        Me.lblTituloRegistraTipoBeca.Text = "Registrar tipo de beca"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Controls.Add(Me.Button10)
        Me.Panel4.Controls.Add(Me.Button8)
        Me.Panel4.Controls.Add(Me.Button7)
        Me.Panel4.Controls.Add(Me.Button9)
        Me.Panel4.Controls.Add(Me.Button6)
        Me.Panel4.Controls.Add(Me.btnOut)
        Me.Panel4.Controls.Add(Me.btnInicio)
        Me.Panel4.Controls.Add(Me.btnAyuda)
        Me.Panel4.Controls.Add(Me.btnPerfil)
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Controls.Add(Me.btnSalir)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(233, 723)
        Me.Panel4.TabIndex = 62
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(9, 676)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(36, 34)
        Me.PictureBox2.TabIndex = 37
        Me.PictureBox2.TabStop = False
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
        Me.Button10.Location = New System.Drawing.Point(11, 547)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(200, 59)
        Me.Button10.TabIndex = 44
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
        Me.Button8.Location = New System.Drawing.Point(11, 488)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(200, 59)
        Me.Button8.TabIndex = 42
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
        Me.Button7.Location = New System.Drawing.Point(11, 370)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(200, 59)
        Me.Button7.TabIndex = 41
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
        Me.Button9.Location = New System.Drawing.Point(11, 429)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(200, 59)
        Me.Button9.TabIndex = 43
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
        Me.Button6.Location = New System.Drawing.Point(11, 311)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(200, 59)
        Me.Button6.TabIndex = 40
        Me.Button6.Text = "Usuarios"
        Me.Button6.UseVisualStyleBackColor = False
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
        Me.btnOut.Location = New System.Drawing.Point(9, 606)
        Me.btnOut.Name = "btnOut"
        Me.btnOut.Size = New System.Drawing.Size(200, 59)
        Me.btnOut.TabIndex = 39
        Me.btnOut.Text = "Salir"
        Me.btnOut.UseVisualStyleBackColor = False
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
        Me.btnInicio.TabIndex = 38
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
        Me.btnAyuda.TabIndex = 37
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
        Me.btnPerfil.Location = New System.Drawing.Point(11, 193)
        Me.btnPerfil.Name = "btnPerfil"
        Me.btnPerfil.Size = New System.Drawing.Size(200, 59)
        Me.btnPerfil.TabIndex = 36
        Me.btnPerfil.Text = "Mi perfil"
        Me.btnPerfil.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.lblNombre)
        Me.Panel2.Location = New System.Drawing.Point(0, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(233, 131)
        Me.Panel2.TabIndex = 30
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(89, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(53, 50)
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.Location = New System.Drawing.Point(234, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(916, 69)
        Me.Panel5.TabIndex = 30
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(49, 93)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(133, 25)
        Me.lblNombre.TabIndex = 16
        Me.lblNombre.Text = "Mauricio Araica"
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
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(-176, 289)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 80)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Seguridad"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmRegistrarTipoBeca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1202, 720)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.pnRegistrarTipoBeca)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmRegistrarTipoBeca"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmRegistrarTipoBeca"
        Me.pnRegistrarTipoBeca.ResumeLayout(False)
        Me.pnRegistrarTipoBeca.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnRegistrarTipoBeca As System.Windows.Forms.Panel
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents LblPeriodo As System.Windows.Forms.Label
    Friend WithEvents rctDescripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents lblRequsito As System.Windows.Forms.Label
    Friend WithEvents ChkLbRequisito As System.Windows.Forms.CheckedListBox
    Friend WithEvents lblBeneficios As System.Windows.Forms.Label
    Friend WithEvents ChkLbBeneficios As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombree As System.Windows.Forms.Label
    Friend WithEvents lblNombreV As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents lblTituloRegistraTipoBeca As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents btnOut As System.Windows.Forms.Button
    Friend WithEvents btnInicio As System.Windows.Forms.Button
    Friend WithEvents btnAyuda As System.Windows.Forms.Button
    Friend WithEvents btnPerfil As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
