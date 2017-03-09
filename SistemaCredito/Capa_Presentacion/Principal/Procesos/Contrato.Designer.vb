<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contrato
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Contrato))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.L = New System.Windows.Forms.Label()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.TBDomicilio = New System.Windows.Forms.TextBox()
        Me.RTBImporteLetra = New System.Windows.Forms.RichTextBox()
        Me.CBTipoCultivo = New System.Windows.Forms.ComboBox()
        Me.CBDivisa = New System.Windows.Forms.ComboBox()
        Me.s = New System.Windows.Forms.DataGridView()
        Me.TBImporte = New System.Windows.Forms.TextBox()
        Me.TBHectareas = New System.Windows.Forms.TextBox()
        Me.DTPFechaPago = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DTPFechaContrato = New System.Windows.Forms.DateTimePicker()
        Me.PBFoto = New System.Windows.Forms.PictureBox()
        Me.TBIdCliente = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CBTipoPersona = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GBDatos = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBIdContrato = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.s, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(765, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ConsultarToolStripMenuItem.Text = "Consultar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre o Razón Social"
        '
        'L
        '
        Me.L.AutoSize = True
        Me.L.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L.Location = New System.Drawing.Point(17, 106)
        Me.L.Name = "L"
        Me.L.Size = New System.Drawing.Size(61, 13)
        Me.L.TabIndex = 3
        Me.L.Text = "Dirección"
        '
        'TBNombre
        '
        Me.TBNombre.Enabled = False
        Me.TBNombre.Location = New System.Drawing.Point(206, 80)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(360, 20)
        Me.TBNombre.TabIndex = 4
        '
        'TBDomicilio
        '
        Me.TBDomicilio.Enabled = False
        Me.TBDomicilio.Location = New System.Drawing.Point(206, 106)
        Me.TBDomicilio.Name = "TBDomicilio"
        Me.TBDomicilio.Size = New System.Drawing.Size(360, 20)
        Me.TBDomicilio.TabIndex = 6
        '
        'RTBImporteLetra
        '
        Me.RTBImporteLetra.Enabled = False
        Me.RTBImporteLetra.Location = New System.Drawing.Point(186, 124)
        Me.RTBImporteLetra.Name = "RTBImporteLetra"
        Me.RTBImporteLetra.Size = New System.Drawing.Size(540, 20)
        Me.RTBImporteLetra.TabIndex = 3
        Me.RTBImporteLetra.Text = ""
        '
        'CBTipoCultivo
        '
        Me.CBTipoCultivo.FormattingEnabled = True
        Me.CBTipoCultivo.Items.AddRange(New Object() {"ALGODON", "MAIZ", "TRIGO"})
        Me.CBTipoCultivo.Location = New System.Drawing.Point(186, 177)
        Me.CBTipoCultivo.Name = "CBTipoCultivo"
        Me.CBTipoCultivo.Size = New System.Drawing.Size(133, 21)
        Me.CBTipoCultivo.TabIndex = 5
        '
        'CBDivisa
        '
        Me.CBDivisa.FormattingEnabled = True
        Me.CBDivisa.Items.AddRange(New Object() {"MXN", "USD"})
        Me.CBDivisa.Location = New System.Drawing.Point(186, 150)
        Me.CBDivisa.Name = "CBDivisa"
        Me.CBDivisa.Size = New System.Drawing.Size(133, 21)
        Me.CBDivisa.TabIndex = 4
        '
        's
        '
        Me.s.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.s.Location = New System.Drawing.Point(9, 230)
        Me.s.Name = "s"
        Me.s.Size = New System.Drawing.Size(717, 218)
        Me.s.TabIndex = 14
        '
        'TBImporte
        '
        Me.TBImporte.Location = New System.Drawing.Point(186, 98)
        Me.TBImporte.Name = "TBImporte"
        Me.TBImporte.Size = New System.Drawing.Size(133, 20)
        Me.TBImporte.TabIndex = 2
        '
        'TBHectareas
        '
        Me.TBHectareas.Enabled = False
        Me.TBHectareas.Location = New System.Drawing.Point(186, 204)
        Me.TBHectareas.Name = "TBHectareas"
        Me.TBHectareas.Size = New System.Drawing.Size(133, 20)
        Me.TBHectareas.TabIndex = 0
        '
        'DTPFechaPago
        '
        Me.DTPFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaPago.Location = New System.Drawing.Point(186, 72)
        Me.DTPFechaPago.Name = "DTPFechaPago"
        Me.DTPFechaPago.Size = New System.Drawing.Size(100, 20)
        Me.DTPFechaPago.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 204)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Hectareas"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 177)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Cultivo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Importe en Letra"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Moneda"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Importe"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Fecha de Pago"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Fecha Inicio de Contrato"
        '
        'DTPFechaContrato
        '
        Me.DTPFechaContrato.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaContrato.Location = New System.Drawing.Point(186, 46)
        Me.DTPFechaContrato.Name = "DTPFechaContrato"
        Me.DTPFechaContrato.Size = New System.Drawing.Size(100, 20)
        Me.DTPFechaContrato.TabIndex = 0
        '
        'PBFoto
        '
        Me.PBFoto.BackgroundImage = CType(resources.GetObject("PBFoto.BackgroundImage"), System.Drawing.Image)
        Me.PBFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBFoto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PBFoto.Location = New System.Drawing.Point(624, 27)
        Me.PBFoto.Name = "PBFoto"
        Me.PBFoto.Size = New System.Drawing.Size(128, 126)
        Me.PBFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBFoto.TabIndex = 8
        Me.PBFoto.TabStop = False
        '
        'TBIdCliente
        '
        Me.TBIdCliente.Enabled = False
        Me.TBIdCliente.Location = New System.Drawing.Point(206, 27)
        Me.TBIdCliente.Name = "TBIdCliente"
        Me.TBIdCliente.Size = New System.Drawing.Size(121, 20)
        Me.TBIdCliente.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(17, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "ID del Cliente"
        '
        'CBTipoPersona
        '
        Me.CBTipoPersona.Enabled = False
        Me.CBTipoPersona.FormattingEnabled = True
        Me.CBTipoPersona.Items.AddRange(New Object() {"FISICA", "MORAL"})
        Me.CBTipoPersona.Location = New System.Drawing.Point(206, 53)
        Me.CBTipoPersona.Name = "CBTipoPersona"
        Me.CBTipoPersona.Size = New System.Drawing.Size(121, 21)
        Me.CBTipoPersona.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Tipo de Persona"
        '
        'GBDatos
        '
        Me.GBDatos.Controls.Add(Me.TBIdContrato)
        Me.GBDatos.Controls.Add(Me.Label3)
        Me.GBDatos.Controls.Add(Me.Label4)
        Me.GBDatos.Controls.Add(Me.RTBImporteLetra)
        Me.GBDatos.Controls.Add(Me.DTPFechaContrato)
        Me.GBDatos.Controls.Add(Me.CBTipoCultivo)
        Me.GBDatos.Controls.Add(Me.Label5)
        Me.GBDatos.Controls.Add(Me.CBDivisa)
        Me.GBDatos.Controls.Add(Me.Label6)
        Me.GBDatos.Controls.Add(Me.s)
        Me.GBDatos.Controls.Add(Me.Label7)
        Me.GBDatos.Controls.Add(Me.TBImporte)
        Me.GBDatos.Controls.Add(Me.Label8)
        Me.GBDatos.Controls.Add(Me.TBHectareas)
        Me.GBDatos.Controls.Add(Me.Label9)
        Me.GBDatos.Controls.Add(Me.DTPFechaPago)
        Me.GBDatos.Controls.Add(Me.Label10)
        Me.GBDatos.Location = New System.Drawing.Point(20, 159)
        Me.GBDatos.Name = "GBDatos"
        Me.GBDatos.Size = New System.Drawing.Size(732, 454)
        Me.GBDatos.TabIndex = 24
        Me.GBDatos.TabStop = False
        Me.GBDatos.Text = "Datos del Contrato"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "ID del Contrato"
        '
        'TBIdContrato
        '
        Me.TBIdContrato.Enabled = False
        Me.TBIdContrato.Location = New System.Drawing.Point(186, 20)
        Me.TBIdContrato.Name = "TBIdContrato"
        Me.TBIdContrato.Size = New System.Drawing.Size(100, 20)
        Me.TBIdContrato.TabIndex = 30
        '
        'Contrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 647)
        Me.Controls.Add(Me.GBDatos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CBTipoPersona)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TBIdCliente)
        Me.Controls.Add(Me.PBFoto)
        Me.Controls.Add(Me.TBDomicilio)
        Me.Controls.Add(Me.TBNombre)
        Me.Controls.Add(Me.L)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Contrato"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contrato"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.s, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBDatos.ResumeLayout(False)
        Me.GBDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents L As Label
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents TBDomicilio As TextBox
    Friend WithEvents DTPFechaContrato As DateTimePicker
    Friend WithEvents TBImporte As TextBox
    Friend WithEvents TBHectareas As TextBox
    Friend WithEvents DTPFechaPago As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents s As DataGridView
    Friend WithEvents PBFoto As PictureBox
    Friend WithEvents TBIdCliente As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents CBTipoPersona As ComboBox
    Friend WithEvents CBTipoCultivo As ComboBox
    Friend WithEvents CBDivisa As ComboBox
    Friend WithEvents RTBImporteLetra As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GBDatos As GroupBox
    Friend WithEvents TBIdContrato As TextBox
    Friend WithEvents Label3 As Label
End Class
