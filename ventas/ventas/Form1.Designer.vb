<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.txtNombrecliente = New System.Windows.Forms.TextBox()
        Me.codigo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.direccion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.a = New System.Windows.Forms.Label()
        Me.insertarbtn = New System.Windows.Forms.Button()
        Me.tmensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnmostrarcliente = New System.Windows.Forms.Button()
        Me.btnmodificarcliente = New System.Windows.Forms.Button()
        Me.btneliminarcliente = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnmostrarproductos = New System.Windows.Forms.Button()
        Me.btnmodificarproducto = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btninsertarproducto = New System.Windows.Forms.Button()
        Me.btnbuscarproducto = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtdescripcionproductos = New System.Windows.Forms.TextBox()
        Me.txtproducto = New System.Windows.Forms.TextBox()
        Me.txtidp = New System.Windows.Forms.TextBox()
        Me.Ventas = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnmostrarventas = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtcodcliente = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnmodificarventa = New System.Windows.Forms.Button()
        Me.btneliminarventa = New System.Windows.Forms.Button()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Btnagrgarventa = New System.Windows.Forms.Button()
        Me.txtidproducto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtidventa = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ErrorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Ventas.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(81, 24)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtcodigo.TabIndex = 0
        '
        'txtNombrecliente
        '
        Me.txtNombrecliente.Location = New System.Drawing.Point(81, 56)
        Me.txtNombrecliente.Name = "txtNombrecliente"
        Me.txtNombrecliente.Size = New System.Drawing.Size(100, 20)
        Me.txtNombrecliente.TabIndex = 1
        '
        'codigo
        '
        Me.codigo.AutoSize = True
        Me.codigo.Location = New System.Drawing.Point(1, 27)
        Me.codigo.Name = "codigo"
        Me.codigo.Size = New System.Drawing.Size(74, 13)
        Me.codigo.TabIndex = 2
        Me.codigo.Text = "Codigo cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "nombre Cliente"
        '
        'direccion
        '
        Me.direccion.Location = New System.Drawing.Point(81, 143)
        Me.direccion.Name = "direccion"
        Me.direccion.Size = New System.Drawing.Size(100, 20)
        Me.direccion.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Direccion"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(212, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(81, 99)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(100, 20)
        Me.txtapellido.TabIndex = 8
        '
        'a
        '
        Me.a.AutoSize = True
        Me.a.Location = New System.Drawing.Point(1, 102)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(44, 13)
        Me.a.TabIndex = 9
        Me.a.Text = "Apellido"
        '
        'insertarbtn
        '
        Me.insertarbtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.insertarbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.insertarbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan
        Me.insertarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.insertarbtn.Location = New System.Drawing.Point(212, 56)
        Me.insertarbtn.Name = "insertarbtn"
        Me.insertarbtn.Size = New System.Drawing.Size(75, 23)
        Me.insertarbtn.TabIndex = 10
        Me.insertarbtn.Text = "Insertar"
        Me.insertarbtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox1.Controls.Add(Me.btnmostrarcliente)
        Me.GroupBox1.Controls.Add(Me.btnmodificarcliente)
        Me.GroupBox1.Controls.Add(Me.btneliminarcliente)
        Me.GroupBox1.Controls.Add(Me.codigo)
        Me.GroupBox1.Controls.Add(Me.txtcodigo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNombrecliente)
        Me.GroupBox1.Controls.Add(Me.a)
        Me.GroupBox1.Controls.Add(Me.txtapellido)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.direccion)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.insertarbtn)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(393, 192)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CLiente"
        '
        'btnmostrarcliente
        '
        Me.btnmostrarcliente.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnmostrarcliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.btnmostrarcliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan
        Me.btnmostrarcliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmostrarcliente.Location = New System.Drawing.Point(201, 143)
        Me.btnmostrarcliente.Name = "btnmostrarcliente"
        Me.btnmostrarcliente.Size = New System.Drawing.Size(100, 23)
        Me.btnmostrarcliente.TabIndex = 13
        Me.btnmostrarcliente.Text = "Mostrar Clientes"
        Me.btnmostrarcliente.UseVisualStyleBackColor = True
        '
        'btnmodificarcliente
        '
        Me.btnmodificarcliente.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnmodificarcliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.btnmodificarcliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan
        Me.btnmodificarcliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificarcliente.Location = New System.Drawing.Point(212, 115)
        Me.btnmodificarcliente.Name = "btnmodificarcliente"
        Me.btnmodificarcliente.Size = New System.Drawing.Size(75, 23)
        Me.btnmodificarcliente.TabIndex = 12
        Me.btnmodificarcliente.Text = "Modificar"
        Me.btnmodificarcliente.UseVisualStyleBackColor = True
        '
        'btneliminarcliente
        '
        Me.btneliminarcliente.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btneliminarcliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.btneliminarcliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan
        Me.btneliminarcliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneliminarcliente.Location = New System.Drawing.Point(212, 86)
        Me.btneliminarcliente.Name = "btneliminarcliente"
        Me.btneliminarcliente.Size = New System.Drawing.Size(75, 23)
        Me.btneliminarcliente.TabIndex = 11
        Me.btneliminarcliente.Text = "Eliminar"
        Me.btneliminarcliente.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox2.Controls.Add(Me.btnmostrarproductos)
        Me.GroupBox2.Controls.Add(Me.btnmodificarproducto)
        Me.GroupBox2.Controls.Add(Me.btneliminar)
        Me.GroupBox2.Controls.Add(Me.btninsertarproducto)
        Me.GroupBox2.Controls.Add(Me.btnbuscarproducto)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtdescripcionproductos)
        Me.GroupBox2.Controls.Add(Me.txtproducto)
        Me.GroupBox2.Controls.Add(Me.txtidp)
        Me.GroupBox2.Location = New System.Drawing.Point(446, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(452, 192)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Producto"
        '
        'btnmostrarproductos
        '
        Me.btnmostrarproductos.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnmostrarproductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.btnmostrarproductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan
        Me.btnmostrarproductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmostrarproductos.Location = New System.Drawing.Point(249, 152)
        Me.btnmostrarproductos.Name = "btnmostrarproductos"
        Me.btnmostrarproductos.Size = New System.Drawing.Size(112, 23)
        Me.btnmostrarproductos.TabIndex = 16
        Me.btnmostrarproductos.Text = "Mostrar Productos"
        Me.btnmostrarproductos.UseVisualStyleBackColor = True
        '
        'btnmodificarproducto
        '
        Me.btnmodificarproducto.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnmodificarproducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.btnmodificarproducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan
        Me.btnmodificarproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificarproducto.Location = New System.Drawing.Point(266, 123)
        Me.btnmodificarproducto.Name = "btnmodificarproducto"
        Me.btnmodificarproducto.Size = New System.Drawing.Size(75, 23)
        Me.btnmodificarproducto.TabIndex = 15
        Me.btnmodificarproducto.Text = "Modificar"
        Me.btnmodificarproducto.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btneliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.btneliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan
        Me.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneliminar.Location = New System.Drawing.Point(266, 90)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar.TabIndex = 14
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btninsertarproducto
        '
        Me.btninsertarproducto.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btninsertarproducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.btninsertarproducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan
        Me.btninsertarproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninsertarproducto.Location = New System.Drawing.Point(266, 54)
        Me.btninsertarproducto.Name = "btninsertarproducto"
        Me.btninsertarproducto.Size = New System.Drawing.Size(75, 23)
        Me.btninsertarproducto.TabIndex = 11
        Me.btninsertarproducto.Text = "Insertar"
        Me.btninsertarproducto.UseVisualStyleBackColor = True
        '
        'btnbuscarproducto
        '
        Me.btnbuscarproducto.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnbuscarproducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.btnbuscarproducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan
        Me.btnbuscarproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarproducto.Location = New System.Drawing.Point(266, 19)
        Me.btnbuscarproducto.Name = "btnbuscarproducto"
        Me.btnbuscarproducto.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscarproducto.TabIndex = 11
        Me.btnbuscarproducto.Text = "Buscar"
        Me.btnbuscarproducto.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 133)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Descripcion Producto"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Nombre Producto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "id Producto"
        '
        'txtdescripcionproductos
        '
        Me.txtdescripcionproductos.Location = New System.Drawing.Point(121, 130)
        Me.txtdescripcionproductos.Name = "txtdescripcionproductos"
        Me.txtdescripcionproductos.Size = New System.Drawing.Size(100, 20)
        Me.txtdescripcionproductos.TabIndex = 2
        '
        'txtproducto
        '
        Me.txtproducto.Location = New System.Drawing.Point(121, 74)
        Me.txtproducto.Name = "txtproducto"
        Me.txtproducto.Size = New System.Drawing.Size(100, 20)
        Me.txtproducto.TabIndex = 1
        '
        'txtidp
        '
        Me.txtidp.Location = New System.Drawing.Point(121, 24)
        Me.txtidp.Name = "txtidp"
        Me.txtidp.Size = New System.Drawing.Size(100, 20)
        Me.txtidp.TabIndex = 0
        '
        'Ventas
        '
        Me.Ventas.BackColor = System.Drawing.Color.Gainsboro
        Me.Ventas.Controls.Add(Me.CheckBox1)
        Me.Ventas.Controls.Add(Me.btnmostrarventas)
        Me.Ventas.Controls.Add(Me.Button6)
        Me.Ventas.Controls.Add(Me.Label11)
        Me.Ventas.Controls.Add(Me.txtcodcliente)
        Me.Ventas.Controls.Add(Me.Button5)
        Me.Ventas.Controls.Add(Me.btnmodificarventa)
        Me.Ventas.Controls.Add(Me.btneliminarventa)
        Me.Ventas.Controls.Add(Me.MaskedTextBox1)
        Me.Ventas.Controls.Add(Me.Btnagrgarventa)
        Me.Ventas.Controls.Add(Me.txtidproducto)
        Me.Ventas.Controls.Add(Me.Label7)
        Me.Ventas.Controls.Add(Me.Label6)
        Me.Ventas.Controls.Add(Me.txtcantidad)
        Me.Ventas.Controls.Add(Me.Label5)
        Me.Ventas.Controls.Add(Me.txtprecio)
        Me.Ventas.Controls.Add(Me.Label4)
        Me.Ventas.Controls.Add(Me.Label3)
        Me.Ventas.Controls.Add(Me.txtidventa)
        Me.Ventas.Controls.Add(Me.DataGridView1)
        Me.Ventas.Font = New System.Drawing.Font("Segoe UI Historic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ventas.Location = New System.Drawing.Point(29, 210)
        Me.Ventas.Name = "Ventas"
        Me.Ventas.Size = New System.Drawing.Size(869, 259)
        Me.Ventas.TabIndex = 29
        Me.Ventas.TabStop = False
        Me.Ventas.Text = "GroupBox3"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(721, 76)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(62, 17)
        Me.CheckBox1.TabIndex = 46
        Me.CheckBox1.Text = "Utilizar"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btnmostrarventas
        '
        Me.btnmostrarventas.Enabled = False
        Me.btnmostrarventas.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnmostrarventas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.btnmostrarventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan
        Me.btnmostrarventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmostrarventas.Location = New System.Drawing.Point(666, 99)
        Me.btnmostrarventas.Name = "btnmostrarventas"
        Me.btnmostrarventas.Size = New System.Drawing.Size(177, 24)
        Me.btnmostrarventas.TabIndex = 45
        Me.btnmostrarventas.Text = "mostrar por ventas"
        Me.btnmostrarventas.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Enabled = False
        Me.Button6.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(666, 227)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(177, 23)
        Me.Button6.TabIndex = 44
        Me.Button6.Text = "Mostrar Consulta Examen"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(-1, 41)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 13)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "codigo cliente"
        '
        'txtcodcliente
        '
        Me.txtcodcliente.Enabled = False
        Me.txtcodcliente.Location = New System.Drawing.Point(81, 38)
        Me.txtcodcliente.Name = "txtcodcliente"
        Me.txtcodcliente.Size = New System.Drawing.Size(81, 22)
        Me.txtcodcliente.TabIndex = 42
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(667, 126)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(177, 24)
        Me.Button5.TabIndex = 41
        Me.Button5.Text = "mostrar por codigo cliente"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnmodificarventa
        '
        Me.btnmodificarventa.Enabled = False
        Me.btnmodificarventa.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnmodificarventa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.btnmodificarventa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan
        Me.btnmodificarventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificarventa.Location = New System.Drawing.Point(666, 202)
        Me.btnmodificarventa.Name = "btnmodificarventa"
        Me.btnmodificarventa.Size = New System.Drawing.Size(177, 23)
        Me.btnmodificarventa.TabIndex = 40
        Me.btnmodificarventa.Text = "modificar venta"
        Me.btnmodificarventa.UseVisualStyleBackColor = True
        '
        'btneliminarventa
        '
        Me.btneliminarventa.Enabled = False
        Me.btneliminarventa.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btneliminarventa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.btneliminarventa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan
        Me.btneliminarventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneliminarventa.Location = New System.Drawing.Point(666, 176)
        Me.btneliminarventa.Name = "btneliminarventa"
        Me.btneliminarventa.Size = New System.Drawing.Size(177, 23)
        Me.btneliminarventa.TabIndex = 39
        Me.btneliminarventa.Text = "eliminar venta"
        Me.btneliminarventa.UseVisualStyleBackColor = True
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Enabled = False
        Me.MaskedTextBox1.Location = New System.Drawing.Point(361, 36)
        Me.MaskedTextBox1.Mask = "0000/00/00"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(87, 22)
        Me.MaskedTextBox1.TabIndex = 38
        '
        'Btnagrgarventa
        '
        Me.Btnagrgarventa.Enabled = False
        Me.Btnagrgarventa.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnagrgarventa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.Btnagrgarventa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan
        Me.Btnagrgarventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnagrgarventa.Location = New System.Drawing.Point(666, 151)
        Me.Btnagrgarventa.Name = "Btnagrgarventa"
        Me.Btnagrgarventa.Size = New System.Drawing.Size(177, 23)
        Me.Btnagrgarventa.TabIndex = 37
        Me.Btnagrgarventa.Text = "Agregar venta"
        Me.Btnagrgarventa.UseVisualStyleBackColor = True
        '
        'txtidproducto
        '
        Me.txtidproducto.Enabled = False
        Me.txtidproducto.Location = New System.Drawing.Point(775, 37)
        Me.txtidproducto.Name = "txtidproducto"
        Me.txtidproducto.Size = New System.Drawing.Size(73, 22)
        Me.txtidproducto.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(709, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "id producto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(575, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Cantidad"
        '
        'txtcantidad
        '
        Me.txtcantidad.Enabled = False
        Me.txtcantidad.Location = New System.Drawing.Point(630, 36)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(73, 22)
        Me.txtcantidad.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(454, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "precio"
        '
        'txtprecio
        '
        Me.txtprecio.Enabled = False
        Me.txtprecio.Location = New System.Drawing.Point(496, 37)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(73, 22)
        Me.txtprecio.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(321, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(165, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Id venta"
        '
        'txtidventa
        '
        Me.txtidventa.Enabled = False
        Me.txtidventa.Location = New System.Drawing.Point(215, 37)
        Me.txtidventa.Name = "txtidventa"
        Me.txtidventa.Size = New System.Drawing.Size(100, 22)
        Me.txtidventa.TabIndex = 28
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(25, 69)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(618, 184)
        Me.DataGridView1.TabIndex = 27
        '
        'ErrorValidacion
        '
        Me.ErrorValidacion.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.ClientSize = New System.Drawing.Size(933, 510)
        Me.Controls.Add(Me.Ventas)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Ventas.ResumeLayout(False)
        Me.Ventas.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents txtNombrecliente As TextBox
    Friend WithEvents codigo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents direccion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents a As Label
    Friend WithEvents insertarbtn As Button
    Friend WithEvents tmensaje As ToolTip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtproducto As TextBox
    Friend WithEvents txtidp As TextBox
    Friend WithEvents btnbuscarproducto As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtdescripcionproductos As TextBox
    Friend WithEvents btninsertarproducto As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnmodificarproducto As Button
    Friend WithEvents btnmostrarproductos As Button
    Friend WithEvents btneliminarcliente As Button
    Friend WithEvents btnmodificarcliente As Button
    Friend WithEvents btnmostrarcliente As Button
    Friend WithEvents Ventas As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtcodcliente As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents btnmodificarventa As Button
    Friend WithEvents btneliminarventa As Button
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Btnagrgarventa As Button
    Friend WithEvents txtidproducto As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtidventa As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button6 As Button
    Friend WithEvents btnmostrarventas As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ErrorValidacion As ErrorProvider
End Class
