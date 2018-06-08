<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.reloj = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.evento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rnd_llegada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tel_llegada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prox_llegada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rnd_tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_reparacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rnd_tecnico1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tiempo_at1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fin_at1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FinPrimeros15minTecnico1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FinEsperaTipoCTecnico1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rnd_tecnico2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tiempo_at2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fin_at2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fin_1c = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fin_2c = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cola = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ac_tiempo_ocupacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cont_comp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cont_no_atendidas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.permanencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nro_iteracion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoComputadora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoComputadora2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoComputadora3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tiempo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cant_iteraciones = New System.Windows.Forms.TextBox()
        Me.btn_iniciar = New System.Windows.Forms.Button()
        Me.txt_desde = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.b_formateo = New System.Windows.Forms.TextBox()
        Me.a_formateo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.b_agregar = New System.Windows.Forms.TextBox()
        Me.a_agregar = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.b_cambio = New System.Windows.Forms.TextBox()
        Me.a_cambio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.b_ampliacion = New System.Windows.Forms.TextBox()
        Me.a_ampliacion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.b_placa = New System.Windows.Forms.TextBox()
        Me.a_placa = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.b_llegada = New System.Windows.Forms.TextBox()
        Me.a_llegada = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Borrar = New System.Windows.Forms.Button()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cant_no_atendidos = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ocupacion_tecnicos = New System.Windows.Forms.TextBox()
        Me.prom_permanencia = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Iteraciones = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox4.SuspendLayout
        Me.GroupBox1.SuspendLayout
        Me.GroupBox7.SuspendLayout
        Me.GroupBox5.SuspendLayout
        Me.GroupBox3.SuspendLayout
        Me.GroupBox6.SuspendLayout
        Me.GroupBox8.SuspendLayout
        Me.GroupBox2.SuspendLayout
        Me.GroupBox9.SuspendLayout
        Me.GroupBox10.SuspendLayout
        Me.SuspendLayout
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = false
        Me.DataGridView1.AllowUserToDeleteRows = false
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.reloj, Me.evento, Me.rnd_llegada, Me.tel_llegada, Me.prox_llegada, Me.rnd_tipo, Me.tipo_reparacion, Me.rnd_tecnico1, Me.tiempo_at1, Me.fin_at1, Me.estado1, Me.FinPrimeros15minTecnico1, Me.FinEsperaTipoCTecnico1, Me.rnd_tecnico2, Me.tiempo_at2, Me.fin_at2, Me.estado2, Me.fin_1c, Me.fin_2c, Me.cola, Me.ac_tiempo_ocupacion, Me.cont_comp, Me.cont_no_atendidas, Me.permanencia, Me.nro_iteracion, Me.EstadoComputadora, Me.EstadoComputadora2, Me.EstadoComputadora3})
        Me.DataGridView1.Location = New System.Drawing.Point(16, 417)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = true
        Me.DataGridView1.Size = New System.Drawing.Size(1709, 267)
        Me.DataGridView1.TabIndex = 0
        '
        'reloj
        '
        Me.reloj.HeaderText = "Reloj"
        Me.reloj.Name = "reloj"
        Me.reloj.ReadOnly = true
        '
        'evento
        '
        Me.evento.HeaderText = "Evento"
        Me.evento.Name = "evento"
        Me.evento.ReadOnly = true
        '
        'rnd_llegada
        '
        Me.rnd_llegada.HeaderText = "RND Llegada"
        Me.rnd_llegada.Name = "rnd_llegada"
        Me.rnd_llegada.ReadOnly = true
        '
        'tel_llegada
        '
        Me.tel_llegada.HeaderText = "Tiempo Entre Llegadas"
        Me.tel_llegada.Name = "tel_llegada"
        Me.tel_llegada.ReadOnly = true
        '
        'prox_llegada
        '
        Me.prox_llegada.HeaderText = "Proxima Llegada"
        Me.prox_llegada.Name = "prox_llegada"
        Me.prox_llegada.ReadOnly = true
        '
        'rnd_tipo
        '
        Me.rnd_tipo.HeaderText = "RND Tipo Reparacion"
        Me.rnd_tipo.Name = "rnd_tipo"
        Me.rnd_tipo.ReadOnly = true
        '
        'tipo_reparacion
        '
        Me.tipo_reparacion.HeaderText = "Tipo Reparacion"
        Me.tipo_reparacion.Name = "tipo_reparacion"
        Me.tipo_reparacion.ReadOnly = true
        '
        'rnd_tecnico1
        '
        Me.rnd_tecnico1.HeaderText = "RND Tiempo Tecnico1"
        Me.rnd_tecnico1.Name = "rnd_tecnico1"
        Me.rnd_tecnico1.ReadOnly = true
        '
        'tiempo_at1
        '
        Me.tiempo_at1.HeaderText = "TA Tecnico1"
        Me.tiempo_at1.Name = "tiempo_at1"
        Me.tiempo_at1.ReadOnly = true
        '
        'fin_at1
        '
        Me.fin_at1.HeaderText = "Fin Atencion Tecnico1"
        Me.fin_at1.Name = "fin_at1"
        Me.fin_at1.ReadOnly = true
        '
        'estado1
        '
        Me.estado1.HeaderText = "Estado Tecnico1"
        Me.estado1.Name = "estado1"
        Me.estado1.ReadOnly = true
        '
        'FinPrimeros15minTecnico1
        '
        Me.FinPrimeros15minTecnico1.HeaderText = "Fin Primeros 15 min Tipo C Tecnico 1"
        Me.FinPrimeros15minTecnico1.Name = "FinPrimeros15minTecnico1"
        Me.FinPrimeros15minTecnico1.ReadOnly = true
        '
        'FinEsperaTipoCTecnico1
        '
        Me.FinEsperaTipoCTecnico1.HeaderText = "Fin Espera Tipo C Tecnico 1"
        Me.FinEsperaTipoCTecnico1.Name = "FinEsperaTipoCTecnico1"
        Me.FinEsperaTipoCTecnico1.ReadOnly = true
        '
        'rnd_tecnico2
        '
        Me.rnd_tecnico2.HeaderText = "RND Tiempo Tecnico2"
        Me.rnd_tecnico2.Name = "rnd_tecnico2"
        Me.rnd_tecnico2.ReadOnly = true
        '
        'tiempo_at2
        '
        Me.tiempo_at2.HeaderText = "TA Tecnico 2"
        Me.tiempo_at2.Name = "tiempo_at2"
        Me.tiempo_at2.ReadOnly = true
        '
        'fin_at2
        '
        Me.fin_at2.HeaderText = "Fin Atencion Tecnico2"
        Me.fin_at2.Name = "fin_at2"
        Me.fin_at2.ReadOnly = true
        '
        'estado2
        '
        Me.estado2.HeaderText = "Estado Tecnico2"
        Me.estado2.Name = "estado2"
        Me.estado2.ReadOnly = true
        '
        'fin_1c
        '
        Me.fin_1c.HeaderText = "Fin primeros 15 min Tipo C Tecnico 1"
        Me.fin_1c.Name = "fin_1c"
        Me.fin_1c.ReadOnly = true
        '
        'fin_2c
        '
        Me.fin_2c.HeaderText = "Fin Espera Tipo C Tecnico 1"
        Me.fin_2c.Name = "fin_2c"
        Me.fin_2c.ReadOnly = true
        '
        'cola
        '
        Me.cola.HeaderText = "Cola"
        Me.cola.Name = "cola"
        Me.cola.ReadOnly = true
        '
        'ac_tiempo_ocupacion
        '
        Me.ac_tiempo_ocupacion.HeaderText = "Acumulador Tiempo Ocupacion"
        Me.ac_tiempo_ocupacion.Name = "ac_tiempo_ocupacion"
        Me.ac_tiempo_ocupacion.ReadOnly = true
        '
        'cont_comp
        '
        Me.cont_comp.HeaderText = "Contador Computadoras"
        Me.cont_comp.Name = "cont_comp"
        Me.cont_comp.ReadOnly = true
        '
        'cont_no_atendidas
        '
        Me.cont_no_atendidas.HeaderText = "Contador Computadoras No Atendidas"
        Me.cont_no_atendidas.Name = "cont_no_atendidas"
        Me.cont_no_atendidas.ReadOnly = true
        '
        'permanencia
        '
        Me.permanencia.HeaderText = "Acumulador Permanencia"
        Me.permanencia.Name = "permanencia"
        Me.permanencia.ReadOnly = true
        '
        'nro_iteracion
        '
        Me.nro_iteracion.HeaderText = "Nro Iteracion"
        Me.nro_iteracion.Name = "nro_iteracion"
        Me.nro_iteracion.ReadOnly = true
        Me.nro_iteracion.Visible = false
        '
        'EstadoComputadora
        '
        Me.EstadoComputadora.HeaderText = "EstadoComputadora"
        Me.EstadoComputadora.Name = "EstadoComputadora"
        Me.EstadoComputadora.ReadOnly = true
        '
        'EstadoComputadora2
        '
        Me.EstadoComputadora2.HeaderText = "EstadoComputadora2"
        Me.EstadoComputadora2.Name = "EstadoComputadora2"
        Me.EstadoComputadora2.ReadOnly = true
        '
        'EstadoComputadora3
        '
        Me.EstadoComputadora3.HeaderText = "EstadoComputadora3"
        Me.EstadoComputadora3.Name = "EstadoComputadora3"
        Me.EstadoComputadora3.ReadOnly = true
        '
        'tiempo
        '
        Me.tiempo.Enabled = false
        Me.tiempo.Location = New System.Drawing.Point(124, 23)
        Me.tiempo.Margin = New System.Windows.Forms.Padding(4)
        Me.tiempo.Name = "tiempo"
        Me.tiempo.Size = New System.Drawing.Size(203, 22)
        Me.tiempo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(127, 38)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Inicio:"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(12, 70)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cantidad de iteraciones:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cant_iteraciones)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.btn_iniciar)
        Me.GroupBox4.Controls.Add(Me.txt_desde)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 228)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(381, 148)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = false
        Me.GroupBox4.Text = "Mostrar en Tabla"
        '
        'cant_iteraciones
        '
        Me.cant_iteraciones.Location = New System.Drawing.Point(181, 66)
        Me.cant_iteraciones.Margin = New System.Windows.Forms.Padding(4)
        Me.cant_iteraciones.Name = "cant_iteraciones"
        Me.cant_iteraciones.Size = New System.Drawing.Size(113, 22)
        Me.cant_iteraciones.TabIndex = 4
        '
        'btn_iniciar
        '
        Me.btn_iniciar.Location = New System.Drawing.Point(257, 98)
        Me.btn_iniciar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_iniciar.Name = "btn_iniciar"
        Me.btn_iniciar.Size = New System.Drawing.Size(100, 28)
        Me.btn_iniciar.TabIndex = 5
        Me.btn_iniciar.Text = "Iniciar"
        Me.btn_iniciar.UseVisualStyleBackColor = true
        '
        'txt_desde
        '
        Me.txt_desde.Location = New System.Drawing.Point(181, 34)
        Me.txt_desde.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_desde.Name = "txt_desde"
        Me.txt_desde.Size = New System.Drawing.Size(113, 22)
        Me.txt_desde.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox8)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(405, 20)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(787, 377)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Distribuciones"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.b_formateo)
        Me.GroupBox7.Controls.Add(Me.a_formateo)
        Me.GroupBox7.Controls.Add(Me.Label12)
        Me.GroupBox7.Controls.Add(Me.Label13)
        Me.GroupBox7.Location = New System.Drawing.Point(539, 39)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox7.Size = New System.Drawing.Size(216, 137)
        Me.GroupBox7.TabIndex = 12
        Me.GroupBox7.TabStop = false
        Me.GroupBox7.Text = "Formateo de disco"
        '
        'b_formateo
        '
        Me.b_formateo.Location = New System.Drawing.Point(55, 70)
        Me.b_formateo.Margin = New System.Windows.Forms.Padding(4)
        Me.b_formateo.Name = "b_formateo"
        Me.b_formateo.Size = New System.Drawing.Size(76, 22)
        Me.b_formateo.TabIndex = 9
        Me.b_formateo.Text = "54"
        '
        'a_formateo
        '
        Me.a_formateo.Location = New System.Drawing.Point(55, 34)
        Me.a_formateo.Margin = New System.Windows.Forms.Padding(4)
        Me.a_formateo.Name = "a_formateo"
        Me.a_formateo.Size = New System.Drawing.Size(76, 22)
        Me.a_formateo.TabIndex = 11
        Me.a_formateo.Text = "30"
        '
        'Label12
        '
        Me.Label12.AutoSize = true
        Me.Label12.Location = New System.Drawing.Point(24, 74)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(21, 17)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "B:"
        '
        'Label13
        '
        Me.Label13.AutoSize = true
        Me.Label13.Location = New System.Drawing.Point(24, 38)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(21, 17)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "A:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.b_agregar)
        Me.GroupBox5.Controls.Add(Me.a_agregar)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Location = New System.Drawing.Point(539, 208)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(216, 137)
        Me.GroupBox5.TabIndex = 12
        Me.GroupBox5.TabStop = false
        Me.GroupBox5.Text = "Agregar CD o DVD"
        '
        'b_agregar
        '
        Me.b_agregar.Location = New System.Drawing.Point(55, 70)
        Me.b_agregar.Margin = New System.Windows.Forms.Padding(4)
        Me.b_agregar.Name = "b_agregar"
        Me.b_agregar.Size = New System.Drawing.Size(76, 22)
        Me.b_agregar.TabIndex = 9
        Me.b_agregar.Text = "99"
        '
        'a_agregar
        '
        Me.a_agregar.Location = New System.Drawing.Point(55, 34)
        Me.a_agregar.Margin = New System.Windows.Forms.Padding(4)
        Me.a_agregar.Name = "a_agregar"
        Me.a_agregar.Size = New System.Drawing.Size(76, 22)
        Me.a_agregar.TabIndex = 11
        Me.a_agregar.Text = "80"
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Location = New System.Drawing.Point(24, 74)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "B:"
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Location = New System.Drawing.Point(24, 38)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 17)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "A:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.b_cambio)
        Me.GroupBox3.Controls.Add(Me.a_cambio)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(285, 208)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(216, 137)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = false
        Me.GroupBox3.Text = "Cambio de memoria"
        '
        'b_cambio
        '
        Me.b_cambio.Location = New System.Drawing.Point(55, 70)
        Me.b_cambio.Margin = New System.Windows.Forms.Padding(4)
        Me.b_cambio.Name = "b_cambio"
        Me.b_cambio.Size = New System.Drawing.Size(76, 22)
        Me.b_cambio.TabIndex = 9
        Me.b_cambio.Text = "79"
        '
        'a_cambio
        '
        Me.a_cambio.Location = New System.Drawing.Point(55, 34)
        Me.a_cambio.Margin = New System.Windows.Forms.Padding(4)
        Me.a_cambio.Name = "a_cambio"
        Me.a_cambio.Size = New System.Drawing.Size(76, 22)
        Me.a_cambio.TabIndex = 11
        Me.a_cambio.Text = "70"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(24, 74)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "B:"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Location = New System.Drawing.Point(24, 38)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 17)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "A:"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.b_ampliacion)
        Me.GroupBox6.Controls.Add(Me.a_ampliacion)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Location = New System.Drawing.Point(31, 208)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Size = New System.Drawing.Size(216, 137)
        Me.GroupBox6.TabIndex = 12
        Me.GroupBox6.TabStop = false
        Me.GroupBox6.Text = "Ampliacion de memoria"
        '
        'b_ampliacion
        '
        Me.b_ampliacion.Location = New System.Drawing.Point(55, 70)
        Me.b_ampliacion.Margin = New System.Windows.Forms.Padding(4)
        Me.b_ampliacion.Name = "b_ampliacion"
        Me.b_ampliacion.Size = New System.Drawing.Size(76, 22)
        Me.b_ampliacion.TabIndex = 9
        Me.b_ampliacion.Text = "69"
        '
        'a_ampliacion
        '
        Me.a_ampliacion.Location = New System.Drawing.Point(55, 34)
        Me.a_ampliacion.Margin = New System.Windows.Forms.Padding(4)
        Me.a_ampliacion.Name = "a_ampliacion"
        Me.a_ampliacion.Size = New System.Drawing.Size(76, 22)
        Me.a_ampliacion.TabIndex = 11
        Me.a_ampliacion.Text = "55"
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Location = New System.Drawing.Point(24, 74)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(21, 17)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "B:"
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.Location = New System.Drawing.Point(24, 38)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 17)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "A:"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.b_placa)
        Me.GroupBox8.Controls.Add(Me.a_placa)
        Me.GroupBox8.Controls.Add(Me.Label14)
        Me.GroupBox8.Controls.Add(Me.Label15)
        Me.GroupBox8.Location = New System.Drawing.Point(285, 39)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox8.Size = New System.Drawing.Size(216, 137)
        Me.GroupBox8.TabIndex = 12
        Me.GroupBox8.TabStop = false
        Me.GroupBox8.Text = "Cambio de placa"
        '
        'b_placa
        '
        Me.b_placa.Location = New System.Drawing.Point(55, 70)
        Me.b_placa.Margin = New System.Windows.Forms.Padding(4)
        Me.b_placa.Name = "b_placa"
        Me.b_placa.Size = New System.Drawing.Size(76, 22)
        Me.b_placa.TabIndex = 9
        Me.b_placa.Text = "29"
        '
        'a_placa
        '
        Me.a_placa.Location = New System.Drawing.Point(55, 34)
        Me.a_placa.Margin = New System.Windows.Forms.Padding(4)
        Me.a_placa.Name = "a_placa"
        Me.a_placa.Size = New System.Drawing.Size(76, 22)
        Me.a_placa.TabIndex = 11
        Me.a_placa.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = true
        Me.Label14.Location = New System.Drawing.Point(24, 74)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(21, 17)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "B:"
        '
        'Label15
        '
        Me.Label15.AutoSize = true
        Me.Label15.Location = New System.Drawing.Point(24, 38)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(21, 17)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "A:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.b_llegada)
        Me.GroupBox2.Controls.Add(Me.a_llegada)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(31, 39)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(216, 137)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Llegada computadoras"
        '
        'b_llegada
        '
        Me.b_llegada.Location = New System.Drawing.Point(55, 70)
        Me.b_llegada.Margin = New System.Windows.Forms.Padding(4)
        Me.b_llegada.Name = "b_llegada"
        Me.b_llegada.Size = New System.Drawing.Size(76, 22)
        Me.b_llegada.TabIndex = 9
        Me.b_llegada.Text = "90"
        '
        'a_llegada
        '
        Me.a_llegada.Location = New System.Drawing.Point(55, 34)
        Me.a_llegada.Margin = New System.Windows.Forms.Padding(4)
        Me.a_llegada.Name = "a_llegada"
        Me.a_llegada.Size = New System.Drawing.Size(76, 22)
        Me.a_llegada.TabIndex = 11
        Me.a_llegada.Text = "30"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(24, 74)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "B:"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(24, 38)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "A:"
        '
        'Borrar
        '
        Me.Borrar.Location = New System.Drawing.Point(1625, 704)
        Me.Borrar.Margin = New System.Windows.Forms.Padding(4)
        Me.Borrar.Name = "Borrar"
        Me.Borrar.Size = New System.Drawing.Size(100, 28)
        Me.Borrar.TabIndex = 8
        Me.Borrar.Text = "Borrar"
        Me.Borrar.UseVisualStyleBackColor = true
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label16)
        Me.GroupBox9.Controls.Add(Me.cant_no_atendidos)
        Me.GroupBox9.Controls.Add(Me.Label17)
        Me.GroupBox9.Controls.Add(Me.ocupacion_tecnicos)
        Me.GroupBox9.Controls.Add(Me.prom_permanencia)
        Me.GroupBox9.Controls.Add(Me.Label18)
        Me.GroupBox9.Location = New System.Drawing.Point(1213, 129)
        Me.GroupBox9.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox9.Size = New System.Drawing.Size(512, 182)
        Me.GroupBox9.TabIndex = 9
        Me.GroupBox9.TabStop = false
        Me.GroupBox9.Text = "Resultados"
        '
        'Label16
        '
        Me.Label16.AutoSize = true
        Me.Label16.Location = New System.Drawing.Point(105, 117)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(267, 17)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "Porcentaje de ocupación de los técnicos:"
        '
        'cant_no_atendidos
        '
        Me.cant_no_atendidos.Location = New System.Drawing.Point(381, 74)
        Me.cant_no_atendidos.Margin = New System.Windows.Forms.Padding(4)
        Me.cant_no_atendidos.Name = "cant_no_atendidos"
        Me.cant_no_atendidos.ReadOnly = true
        Me.cant_no_atendidos.Size = New System.Drawing.Size(109, 22)
        Me.cant_no_atendidos.TabIndex = 13
        '
        'Label17
        '
        Me.Label17.AutoSize = true
        Me.Label17.Location = New System.Drawing.Point(31, 78)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(344, 17)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Porcentaje de equipos que no pueden ser atendidos:"
        '
        'ocupacion_tecnicos
        '
        Me.ocupacion_tecnicos.Location = New System.Drawing.Point(381, 113)
        Me.ocupacion_tecnicos.Margin = New System.Windows.Forms.Padding(4)
        Me.ocupacion_tecnicos.Name = "ocupacion_tecnicos"
        Me.ocupacion_tecnicos.ReadOnly = true
        Me.ocupacion_tecnicos.Size = New System.Drawing.Size(109, 22)
        Me.ocupacion_tecnicos.TabIndex = 15
        '
        'prom_permanencia
        '
        Me.prom_permanencia.Location = New System.Drawing.Point(381, 36)
        Me.prom_permanencia.Margin = New System.Windows.Forms.Padding(4)
        Me.prom_permanencia.Name = "prom_permanencia"
        Me.prom_permanencia.ReadOnly = true
        Me.prom_permanencia.Size = New System.Drawing.Size(109, 22)
        Me.prom_permanencia.TabIndex = 17
        '
        'Label18
        '
        Me.Label18.AutoSize = true
        Me.Label18.Location = New System.Drawing.Point(8, 39)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(372, 17)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "Promedio de permanencia en el laboratorio de un equipo:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1200, 368)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.RadioButton2)
        Me.GroupBox10.Controls.Add(Me.RadioButton1)
        Me.GroupBox10.Controls.Add(Me.Iteraciones)
        Me.GroupBox10.Controls.Add(Me.tiempo)
        Me.GroupBox10.Location = New System.Drawing.Point(16, 31)
        Me.GroupBox10.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox10.Size = New System.Drawing.Size(336, 123)
        Me.GroupBox10.TabIndex = 11
        Me.GroupBox10.TabStop = false
        Me.GroupBox10.Text = "Simular por:"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = true
        Me.RadioButton2.Location = New System.Drawing.Point(8, 66)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(98, 21)
        Me.RadioButton2.TabIndex = 13
        Me.RadioButton2.Text = "Iteraciones"
        Me.RadioButton2.UseVisualStyleBackColor = true
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = true
        Me.RadioButton1.Checked = true
        Me.RadioButton1.Location = New System.Drawing.Point(8, 25)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(76, 21)
        Me.RadioButton1.TabIndex = 12
        Me.RadioButton1.TabStop = true
        Me.RadioButton1.Text = "Tiempo"
        Me.RadioButton1.UseVisualStyleBackColor = true
        '
        'Iteraciones
        '
        Me.Iteraciones.Enabled = false
        Me.Iteraciones.Location = New System.Drawing.Point(124, 66)
        Me.Iteraciones.Margin = New System.Windows.Forms.Padding(4)
        Me.Iteraciones.Name = "Iteraciones"
        Me.Iteraciones.Size = New System.Drawing.Size(203, 22)
        Me.Iteraciones.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1741, 750)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.Borrar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "TP5"
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox4.ResumeLayout(false)
        Me.GroupBox4.PerformLayout
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox7.ResumeLayout(false)
        Me.GroupBox7.PerformLayout
        Me.GroupBox5.ResumeLayout(false)
        Me.GroupBox5.PerformLayout
        Me.GroupBox3.ResumeLayout(false)
        Me.GroupBox3.PerformLayout
        Me.GroupBox6.ResumeLayout(false)
        Me.GroupBox6.PerformLayout
        Me.GroupBox8.ResumeLayout(false)
        Me.GroupBox8.PerformLayout
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        Me.GroupBox9.ResumeLayout(false)
        Me.GroupBox9.PerformLayout
        Me.GroupBox10.ResumeLayout(false)
        Me.GroupBox10.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents tiempo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cant_iteraciones As System.Windows.Forms.TextBox
    Friend WithEvents btn_iniciar As System.Windows.Forms.Button
    Friend WithEvents txt_desde As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents b_formateo As System.Windows.Forms.TextBox
    Friend WithEvents a_formateo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents b_ampliacion As System.Windows.Forms.TextBox
    Friend WithEvents a_ampliacion As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents b_placa As System.Windows.Forms.TextBox
    Friend WithEvents a_placa As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents b_agregar As System.Windows.Forms.TextBox
    Friend WithEvents a_agregar As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents b_llegada As System.Windows.Forms.TextBox
    Friend WithEvents a_llegada As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents b_cambio As System.Windows.Forms.TextBox
    Friend WithEvents a_cambio As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Borrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cant_no_atendidos As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ocupacion_tecnicos As System.Windows.Forms.TextBox
    Friend WithEvents prom_permanencia As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Iteraciones As System.Windows.Forms.TextBox
    Friend WithEvents reloj As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents evento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rnd_llegada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tel_llegada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prox_llegada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rnd_tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_reparacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rnd_tecnico1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tiempo_at1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fin_at1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FinPrimeros15minTecnico1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FinEsperaTipoCTecnico1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rnd_tecnico2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tiempo_at2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fin_at2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fin_1c As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fin_2c As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cola As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ac_tiempo_ocupacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cont_comp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cont_no_atendidas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents permanencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nro_iteracion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoComputadora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoComputadora2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoComputadora3 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
