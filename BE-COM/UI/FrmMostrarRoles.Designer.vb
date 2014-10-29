<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMostrarRoles
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMostrarRoles))
        Me.dtgMostrarRoles = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnOut = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.btnAyuda = New System.Windows.Forms.Button()
        Me.btnPerfil = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.cmbFiltroBusqueda = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.lblRolesNoRegistrados = New System.Windows.Forms.Label()
        Me.btnPermisosUsuario = New System.Windows.Forms.Button()
        Me.TEliminacion = New System.Windows.Forms.Timer(Me.components)
        Me.chkUsuariosInactivos = New System.Windows.Forms.CheckBox()
        CType(Me.dtgMostrarRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtgMostrarRoles
        '
        Me.dtgMostrarRoles.AllowUserToAddRows = False
        Me.dtgMostrarRoles.AllowUserToDeleteRows = False
        Me.dtgMostrarRoles.AllowUserToResizeColumns = False
        Me.dtgMostrarRoles.AllowUserToResizeRows = False
        Me.dtgMostrarRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgMostrarRoles.BackgroundColor = System.Drawing.Color.White
        Me.dtgMostrarRoles.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgMostrarRoles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgMostrarRoles.ColumnHeadersHeight = 40
        Me.dtgMostrarRoles.EnableHeadersVisualStyles = False
        Me.dtgMostrarRoles.GridColor = System.Drawing.Color.White
        Me.dtgMostrarRoles.Location = New System.Drawing.Point(243, 192)
        Me.dtgMostrarRoles.MultiSelect = False
        Me.dtgMostrarRoles.Name = "dtgMostrarRoles"
        Me.dtgMostrarRoles.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgMostrarRoles.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgMostrarRoles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.dtgMostrarRoles.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgMostrarRoles.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.dtgMostrarRoles.RowTemplate.Height = 30
        Me.dtgMostrarRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgMostrarRoles.Size = New System.Drawing.Size(871, 463)
        Me.dtgMostrarRoles.TabIndex = 8
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
        Me.Panel4.Controls.Add(Me.Panel1)
        Me.Panel4.Controls.Add(Me.btnOut)
        Me.Panel4.Controls.Add(Me.btnSalir)
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Controls.Add(Me.btnInicio)
        Me.Panel4.Controls.Add(Me.btnAyuda)
        Me.Panel4.Controls.Add(Me.btnPerfil)
        Me.Panel4.Location = New System.Drawing.Point(1, 1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(231, 717)
        Me.Panel4.TabIndex = 30
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblNombre)
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(231, 131)
        Me.Panel1.TabIndex = 30
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
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(234, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(916, 69)
        Me.Panel2.TabIndex = 30
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(49, 91)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(133, 25)
        Me.lblNombre.TabIndex = 16
        Me.lblNombre.Text = "Mauricio Araica"
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnVolver)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(231, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(969, 130)
        Me.Panel3.TabIndex = 32
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
        Me.Label1.Size = New System.Drawing.Size(210, 47)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Roles"
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(312, 149)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(186, 33)
        Me.txtBuscar.TabIndex = 35
        '
        'cmbFiltroBusqueda
        '
        Me.cmbFiltroBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFiltroBusqueda.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFiltroBusqueda.FormattingEnabled = True
        Me.cmbFiltroBusqueda.Items.AddRange(New Object() {"Nombre"})
        Me.cmbFiltroBusqueda.Location = New System.Drawing.Point(643, 149)
        Me.cmbFiltroBusqueda.Name = "cmbFiltroBusqueda"
        Me.cmbFiltroBusqueda.Size = New System.Drawing.Size(186, 33)
        Me.cmbFiltroBusqueda.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(243, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 25)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Buscar:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(537, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 25)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Buscar por:"
        '
        'btnModificar
        '
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(1135, 293)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(55, 53)
        Me.btnModificar.TabIndex = 41
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(1135, 366)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(55, 53)
        Me.btnEliminar.TabIndex = 42
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrar.Image = CType(resources.GetObject("btnRegistrar.Image"), System.Drawing.Image)
        Me.btnRegistrar.Location = New System.Drawing.Point(1135, 220)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(55, 53)
        Me.btnRegistrar.TabIndex = 43
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'lblRolesNoRegistrados
        '
        Me.lblRolesNoRegistrados.Font = New System.Drawing.Font("Segoe UI Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRolesNoRegistrados.Location = New System.Drawing.Point(449, 312)
        Me.lblRolesNoRegistrados.Name = "lblRolesNoRegistrados"
        Me.lblRolesNoRegistrados.Size = New System.Drawing.Size(460, 158)
        Me.lblRolesNoRegistrados.TabIndex = 44
        Me.lblRolesNoRegistrados.Text = "No se encuentran roles registrados que coincidan con su búsqueda."
        Me.lblRolesNoRegistrados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblRolesNoRegistrados.Visible = False
        '
        'btnPermisosUsuario
        '
        Me.btnPermisosUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnPermisosUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnPermisosUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPermisosUsuario.Image = CType(resources.GetObject("btnPermisosUsuario.Image"), System.Drawing.Image)
        Me.btnPermisosUsuario.Location = New System.Drawing.Point(1135, 436)
        Me.btnPermisosUsuario.Name = "btnPermisosUsuario"
        Me.btnPermisosUsuario.Size = New System.Drawing.Size(55, 53)
        Me.btnPermisosUsuario.TabIndex = 45
        Me.btnPermisosUsuario.UseVisualStyleBackColor = True
        '
        'TEliminacion
        '
        Me.TEliminacion.Enabled = True
        '
        'chkUsuariosInactivos
        '
        Me.chkUsuariosInactivos.AutoSize = True
        Me.chkUsuariosInactivos.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUsuariosInactivos.Location = New System.Drawing.Point(866, 151)
        Me.chkUsuariosInactivos.Name = "chkUsuariosInactivos"
        Me.chkUsuariosInactivos.Size = New System.Drawing.Size(198, 29)
        Me.chkUsuariosInactivos.TabIndex = 47
        Me.chkUsuariosInactivos.Text = "Ver usuarios inactivos"
        Me.chkUsuariosInactivos.UseVisualStyleBackColor = True
        '
        'FrmMostrarRoles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1202, 720)
        Me.Controls.Add(Me.chkUsuariosInactivos)
        Me.Controls.Add(Me.btnPermisosUsuario)
        Me.Controls.Add(Me.lblRolesNoRegistrados)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbFiltroBusqueda)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.dtgMostrarRoles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMostrarRoles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dtgMostrarRoles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtgMostrarRoles As System.Windows.Forms.DataGridView
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents btnOut As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnInicio As System.Windows.Forms.Button
    Friend WithEvents btnAyuda As System.Windows.Forms.Button
    Friend WithEvents btnPerfil As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents cmbFiltroBusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents lblRolesNoRegistrados As System.Windows.Forms.Label
    Friend WithEvents btnPermisosUsuario As System.Windows.Forms.Button
    Friend WithEvents TEliminacion As System.Windows.Forms.Timer
    Friend WithEvents chkUsuariosInactivos As System.Windows.Forms.CheckBox
End Class
