﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PreregistroLotes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PreregistroLotes))
        Me.LbTitle = New System.Windows.Forms.Label()
        Me.MSPreregistroLotes = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OFDPreregistroLotes = New System.Windows.Forms.OpenFileDialog()
        Me.LbNombre = New System.Windows.Forms.Label()
        Me.LbIdCliente = New System.Windows.Forms.Label()
        Me.TBIdPreregistroLotes = New System.Windows.Forms.TextBox()
        Me.LbFecha = New System.Windows.Forms.Label()
        Me.TBFecha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBIdEstado = New System.Windows.Forms.ComboBox()
        Me.CBNombreCliente = New System.Windows.Forms.ComboBox()
        Me.TBVolumen = New System.Windows.Forms.TextBox()
        Me.NuSupCultivable = New System.Windows.Forms.NumericUpDown()
        Me.NuSupTotal = New System.Windows.Forms.NumericUpDown()
        Me.DtTitulo = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TBTitulo = New System.Windows.Forms.TextBox()
        Me.TBRegimen = New System.Windows.Forms.TextBox()
        Me.TbCurp = New System.Windows.Forms.TextBox()
        Me.TbRfc = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GbEscrituracion = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DTRpp = New System.Windows.Forms.DateTimePicker()
        Me.TBNumeroRPP = New System.Windows.Forms.TextBox()
        Me.TBFolioRPP = New System.Windows.Forms.TextBox()
        Me.TBLibroRPP = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TBWMinutos = New System.Windows.Forms.TextBox()
        Me.TBWHoras = New System.Windows.Forms.TextBox()
        Me.TBWGrados = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBNGrados = New System.Windows.Forms.TextBox()
        Me.TBNHoras = New System.Windows.Forms.TextBox()
        Me.TBNMinutos = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CBColonia = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBNoLote = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGDocumentosPropietario = New System.Windows.Forms.DataGridView()
        Me.BTAbrirCarpeta = New System.Windows.Forms.Button()
        Me.MSPreregistroLotes.SuspendLayout()
        CType(Me.NuSupCultivable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuSupTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbEscrituracion.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGDocumentosPropietario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbTitle
        '
        Me.LbTitle.AutoSize = True
        Me.LbTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LbTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbTitle.Location = New System.Drawing.Point(274, 24)
        Me.LbTitle.Name = "LbTitle"
        Me.LbTitle.Size = New System.Drawing.Size(136, 13)
        Me.LbTitle.TabIndex = 1
        Me.LbTitle.Text = "REGISTRO DE LOTES"
        '
        'MSPreregistroLotes
        '
        Me.MSPreregistroLotes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MSPreregistroLotes.Location = New System.Drawing.Point(0, 0)
        Me.MSPreregistroLotes.Name = "MSPreregistroLotes"
        Me.MSPreregistroLotes.Size = New System.Drawing.Size(727, 24)
        Me.MSPreregistroLotes.TabIndex = 2
        Me.MSPreregistroLotes.Text = "MenuStrip1"
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
        'OFDPreregistroLotes
        '
        Me.OFDPreregistroLotes.FileName = "OpenFileDialog1"
        '
        'LbNombre
        '
        Me.LbNombre.AutoSize = True
        Me.LbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LbNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbNombre.Location = New System.Drawing.Point(23, 105)
        Me.LbNombre.Name = "LbNombre"
        Me.LbNombre.Size = New System.Drawing.Size(113, 13)
        Me.LbNombre.TabIndex = 3
        Me.LbNombre.Text = "Nombre del propietario"
        '
        'LbIdCliente
        '
        Me.LbIdCliente.AutoSize = True
        Me.LbIdCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LbIdCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbIdCliente.Location = New System.Drawing.Point(23, 57)
        Me.LbIdCliente.Name = "LbIdCliente"
        Me.LbIdCliente.Size = New System.Drawing.Size(18, 13)
        Me.LbIdCliente.TabIndex = 26
        Me.LbIdCliente.Text = "ID"
        Me.LbIdCliente.Visible = False
        '
        'TBIdPreregistroLotes
        '
        Me.TBIdPreregistroLotes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBIdPreregistroLotes.Location = New System.Drawing.Point(173, 54)
        Me.TBIdPreregistroLotes.Name = "TBIdPreregistroLotes"
        Me.TBIdPreregistroLotes.Size = New System.Drawing.Size(60, 20)
        Me.TBIdPreregistroLotes.TabIndex = 0
        Me.TBIdPreregistroLotes.Visible = False
        '
        'LbFecha
        '
        Me.LbFecha.AutoSize = True
        Me.LbFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LbFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbFecha.Location = New System.Drawing.Point(530, 30)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.Size = New System.Drawing.Size(37, 13)
        Me.LbFecha.TabIndex = 28
        Me.LbFecha.Text = "Fecha"
        '
        'TBFecha
        '
        Me.TBFecha.Enabled = False
        Me.TBFecha.Location = New System.Drawing.Point(578, 27)
        Me.TBFecha.Name = "TBFecha"
        Me.TBFecha.Size = New System.Drawing.Size(139, 20)
        Me.TBFecha.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(23, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Estado"
        '
        'CBIdEstado
        '
        Me.CBIdEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CBIdEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBIdEstado.FormattingEnabled = True
        Me.CBIdEstado.Location = New System.Drawing.Point(173, 185)
        Me.CBIdEstado.Name = "CBIdEstado"
        Me.CBIdEstado.Size = New System.Drawing.Size(163, 21)
        Me.CBIdEstado.TabIndex = 4
        '
        'CBNombreCliente
        '
        Me.CBNombreCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CBNombreCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBNombreCliente.FormattingEnabled = True
        Me.CBNombreCliente.Location = New System.Drawing.Point(173, 105)
        Me.CBNombreCliente.Name = "CBNombreCliente"
        Me.CBNombreCliente.Size = New System.Drawing.Size(258, 21)
        Me.CBNombreCliente.TabIndex = 2
        '
        'TBVolumen
        '
        Me.TBVolumen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBVolumen.Location = New System.Drawing.Point(173, 238)
        Me.TBVolumen.Name = "TBVolumen"
        Me.TBVolumen.Size = New System.Drawing.Size(60, 20)
        Me.TBVolumen.TabIndex = 7
        '
        'NuSupCultivable
        '
        Me.NuSupCultivable.Location = New System.Drawing.Point(482, 210)
        Me.NuSupCultivable.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.NuSupCultivable.Name = "NuSupCultivable"
        Me.NuSupCultivable.Size = New System.Drawing.Size(175, 20)
        Me.NuSupCultivable.TabIndex = 6
        Me.NuSupCultivable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NuSupTotal
        '
        Me.NuSupTotal.Location = New System.Drawing.Point(173, 212)
        Me.NuSupTotal.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.NuSupTotal.Name = "NuSupTotal"
        Me.NuSupTotal.Size = New System.Drawing.Size(163, 20)
        Me.NuSupTotal.TabIndex = 5
        Me.NuSupTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DtTitulo
        '
        Me.DtTitulo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtTitulo.Location = New System.Drawing.Point(129, 469)
        Me.DtTitulo.Name = "DtTitulo"
        Me.DtTitulo.Size = New System.Drawing.Size(102, 20)
        Me.DtTitulo.TabIndex = 12
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(16, 469)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(88, 13)
        Me.Label18.TabIndex = 59
        Me.Label18.Text = "Fecha del Título:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(329, 446)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(81, 13)
        Me.Label17.TabIndex = 58
        Me.Label17.Text = "Titulo del Agua:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(16, 446)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 13)
        Me.Label16.TabIndex = 57
        Me.Label16.Text = "Régimen Hídrico:"
        '
        'TBTitulo
        '
        Me.TBTitulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBTitulo.Location = New System.Drawing.Point(438, 443)
        Me.TBTitulo.Name = "TBTitulo"
        Me.TBTitulo.Size = New System.Drawing.Size(162, 20)
        Me.TBTitulo.TabIndex = 11
        '
        'TBRegimen
        '
        Me.TBRegimen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBRegimen.Location = New System.Drawing.Point(129, 443)
        Me.TBRegimen.Name = "TBRegimen"
        Me.TBRegimen.Size = New System.Drawing.Size(162, 20)
        Me.TBRegimen.TabIndex = 10
        '
        'TbCurp
        '
        Me.TbCurp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbCurp.Enabled = False
        Me.TbCurp.Location = New System.Drawing.Point(482, 132)
        Me.TbCurp.Name = "TbCurp"
        Me.TbCurp.Size = New System.Drawing.Size(175, 20)
        Me.TbCurp.TabIndex = 56
        '
        'TbRfc
        '
        Me.TbRfc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbRfc.Enabled = False
        Me.TbRfc.Location = New System.Drawing.Point(173, 132)
        Me.TbRfc.Name = "TbRfc"
        Me.TbRfc.Size = New System.Drawing.Size(163, 20)
        Me.TbRfc.TabIndex = 55
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(373, 132)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 13)
        Me.Label15.TabIndex = 54
        Me.Label15.Text = "CURP"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(23, 132)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 13)
        Me.Label14.TabIndex = 53
        Me.Label14.Text = "RFC"
        '
        'GbEscrituracion
        '
        Me.GbEscrituracion.Controls.Add(Me.Label13)
        Me.GbEscrituracion.Controls.Add(Me.DTRpp)
        Me.GbEscrituracion.Controls.Add(Me.TBNumeroRPP)
        Me.GbEscrituracion.Controls.Add(Me.TBFolioRPP)
        Me.GbEscrituracion.Controls.Add(Me.TBLibroRPP)
        Me.GbEscrituracion.Controls.Add(Me.Label12)
        Me.GbEscrituracion.Controls.Add(Me.Label11)
        Me.GbEscrituracion.Controls.Add(Me.Label10)
        Me.GbEscrituracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbEscrituracion.Location = New System.Drawing.Point(14, 370)
        Me.GbEscrituracion.Name = "GbEscrituracion"
        Me.GbEscrituracion.Size = New System.Drawing.Size(586, 63)
        Me.GbEscrituracion.TabIndex = 9
        Me.GbEscrituracion.TabStop = False
        Me.GbEscrituracion.Text = "Escrituración del Registro Público de la Propiedad"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(418, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 13)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Fecha"
        '
        'DTRpp
        '
        Me.DTRpp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTRpp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTRpp.Location = New System.Drawing.Point(461, 29)
        Me.DTRpp.Name = "DTRpp"
        Me.DTRpp.Size = New System.Drawing.Size(102, 20)
        Me.DTRpp.TabIndex = 3
        '
        'TBNumeroRPP
        '
        Me.TBNumeroRPP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBNumeroRPP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBNumeroRPP.Location = New System.Drawing.Point(84, 29)
        Me.TBNumeroRPP.Name = "TBNumeroRPP"
        Me.TBNumeroRPP.Size = New System.Drawing.Size(69, 20)
        Me.TBNumeroRPP.TabIndex = 0
        '
        'TBFolioRPP
        '
        Me.TBFolioRPP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBFolioRPP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBFolioRPP.Location = New System.Drawing.Point(213, 29)
        Me.TBFolioRPP.Name = "TBFolioRPP"
        Me.TBFolioRPP.Size = New System.Drawing.Size(69, 20)
        Me.TBFolioRPP.TabIndex = 1
        '
        'TBLibroRPP
        '
        Me.TBLibroRPP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBLibroRPP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBLibroRPP.Location = New System.Drawing.Point(343, 29)
        Me.TBLibroRPP.Name = "TBLibroRPP"
        Me.TBLibroRPP.Size = New System.Drawing.Size(69, 20)
        Me.TBLibroRPP.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(15, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Del Número"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(159, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Del Folio"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(288, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Del Libro"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TBWMinutos)
        Me.GroupBox2.Controls.Add(Me.TBWHoras)
        Me.GroupBox2.Controls.Add(Me.TBWGrados)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TBNGrados)
        Me.GroupBox2.Controls.Add(Me.TBNHoras)
        Me.GroupBox2.Controls.Add(Me.TBNMinutos)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(14, 292)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(648, 72)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Coordenadas del Lote"
        '
        'TBWMinutos
        '
        Me.TBWMinutos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBWMinutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBWMinutos.Location = New System.Drawing.Point(559, 26)
        Me.TBWMinutos.Name = "TBWMinutos"
        Me.TBWMinutos.Size = New System.Drawing.Size(76, 20)
        Me.TBWMinutos.TabIndex = 5
        '
        'TBWHoras
        '
        Me.TBWHoras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBWHoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBWHoras.Location = New System.Drawing.Point(477, 26)
        Me.TBWHoras.Name = "TBWHoras"
        Me.TBWHoras.Size = New System.Drawing.Size(76, 20)
        Me.TBWHoras.TabIndex = 4
        '
        'TBWGrados
        '
        Me.TBWGrados.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBWGrados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBWGrados.Location = New System.Drawing.Point(395, 26)
        Me.TBWGrados.Name = "TBWGrados"
        Me.TBWGrados.Size = New System.Drawing.Size(76, 20)
        Me.TBWGrados.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Latitud N"
        '
        'TBNGrados
        '
        Me.TBNGrados.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBNGrados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBNGrados.Location = New System.Drawing.Point(72, 29)
        Me.TBNGrados.Name = "TBNGrados"
        Me.TBNGrados.Size = New System.Drawing.Size(75, 20)
        Me.TBNGrados.TabIndex = 0
        '
        'TBNHoras
        '
        Me.TBNHoras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBNHoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBNHoras.Location = New System.Drawing.Point(153, 29)
        Me.TBNHoras.Name = "TBNHoras"
        Me.TBNHoras.Size = New System.Drawing.Size(75, 20)
        Me.TBNHoras.TabIndex = 1
        '
        'TBNMinutos
        '
        Me.TBNMinutos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBNMinutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBNMinutos.Location = New System.Drawing.Point(234, 29)
        Me.TBNMinutos.Name = "TBNMinutos"
        Me.TBNMinutos.Size = New System.Drawing.Size(75, 20)
        Me.TBNMinutos.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(315, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Longitud W"
        '
        'CBColonia
        '
        Me.CBColonia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CBColonia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBColonia.DropDownHeight = 100
        Me.CBColonia.FormattingEnabled = True
        Me.CBColonia.IntegralHeight = False
        Me.CBColonia.Location = New System.Drawing.Point(173, 158)
        Me.CBColonia.Name = "CBColonia"
        Me.CBColonia.Size = New System.Drawing.Size(163, 21)
        Me.CBColonia.TabIndex = 3
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(23, 238)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(48, 13)
        Me.Label19.TabIndex = 47
        Me.Label19.Text = "Volumen"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(373, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Superficie Cultivable"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Superficie Total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Colonia"
        '
        'TBNoLote
        '
        Me.TBNoLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBNoLote.Location = New System.Drawing.Point(173, 80)
        Me.TBNoLote.Name = "TBNoLote"
        Me.TBNoLote.Size = New System.Drawing.Size(163, 20)
        Me.TBNoLote.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(23, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "No. Lote"
        '
        'DGDocumentosPropietario
        '
        Me.DGDocumentosPropietario.AllowUserToAddRows = False
        Me.DGDocumentosPropietario.AllowUserToDeleteRows = False
        Me.DGDocumentosPropietario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGDocumentosPropietario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DGDocumentosPropietario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGDocumentosPropietario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGDocumentosPropietario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGDocumentosPropietario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DGDocumentosPropietario.Location = New System.Drawing.Point(128, 495)
        Me.DGDocumentosPropietario.Name = "DGDocumentosPropietario"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGDocumentosPropietario.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DGDocumentosPropietario.RowHeadersVisible = False
        Me.DGDocumentosPropietario.RowHeadersWidth = 40
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGDocumentosPropietario.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DGDocumentosPropietario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGDocumentosPropietario.Size = New System.Drawing.Size(472, 192)
        Me.DGDocumentosPropietario.TabIndex = 61
        '
        'BTAbrirCarpeta
        '
        Me.BTAbrirCarpeta.BackgroundImage = CType(resources.GetObject("BTAbrirCarpeta.BackgroundImage"), System.Drawing.Image)
        Me.BTAbrirCarpeta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTAbrirCarpeta.Location = New System.Drawing.Point(609, 495)
        Me.BTAbrirCarpeta.Name = "BTAbrirCarpeta"
        Me.BTAbrirCarpeta.Size = New System.Drawing.Size(28, 25)
        Me.BTAbrirCarpeta.TabIndex = 62
        Me.BTAbrirCarpeta.UseVisualStyleBackColor = True
        '
        'PreregistroLotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 722)
        Me.Controls.Add(Me.BTAbrirCarpeta)
        Me.Controls.Add(Me.DGDocumentosPropietario)
        Me.Controls.Add(Me.TBNoLote)
        Me.Controls.Add(Me.TBVolumen)
        Me.Controls.Add(Me.NuSupCultivable)
        Me.Controls.Add(Me.NuSupTotal)
        Me.Controls.Add(Me.DtTitulo)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TBTitulo)
        Me.Controls.Add(Me.TBRegimen)
        Me.Controls.Add(Me.TbCurp)
        Me.Controls.Add(Me.TbRfc)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GbEscrituracion)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.CBColonia)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CBNombreCliente)
        Me.Controls.Add(Me.CBIdEstado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBFecha)
        Me.Controls.Add(Me.LbFecha)
        Me.Controls.Add(Me.TBIdPreregistroLotes)
        Me.Controls.Add(Me.LbIdCliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LbNombre)
        Me.Controls.Add(Me.LbTitle)
        Me.Controls.Add(Me.MSPreregistroLotes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MSPreregistroLotes
        Me.Name = "PreregistroLotes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pre-registro Lotes"
        Me.MSPreregistroLotes.ResumeLayout(False)
        Me.MSPreregistroLotes.PerformLayout()
        CType(Me.NuSupCultivable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuSupTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbEscrituracion.ResumeLayout(False)
        Me.GbEscrituracion.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGDocumentosPropietario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbTitle As Label
    Friend WithEvents MSPreregistroLotes As MenuStrip
    Friend WithEvents OFDPreregistroLotes As OpenFileDialog
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LbNombre As Label
    Friend WithEvents LbIdCliente As Label
    Friend WithEvents TBIdPreregistroLotes As TextBox
    Friend WithEvents LbFecha As Label
    Friend WithEvents TBFecha As TextBox
    Friend WithEvents Lote As DataGridViewTextBoxColumn
    Friend WithEvents Colonia As DataGridViewTextBoxColumn
    Friend WithEvents SuperficieTotal As DataGridViewTextBoxColumn
    Friend WithEvents SuperficieSembrar As DataGridViewTextBoxColumn
    Friend WithEvents SuperficieRestante As DataGridViewTextBoxColumn
    Friend WithEvents FolioAserca As DataGridViewTextBoxColumn
    Friend WithEvents Predio As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents CBIdEstado As ComboBox
    Friend WithEvents CBNombreCliente As ComboBox
    Friend WithEvents TBVolumen As TextBox
    Friend WithEvents NuSupCultivable As NumericUpDown
    Friend WithEvents NuSupTotal As NumericUpDown
    Friend WithEvents DtTitulo As DateTimePicker
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TBTitulo As TextBox
    Friend WithEvents TBRegimen As TextBox
    Friend WithEvents TbCurp As TextBox
    Friend WithEvents TbRfc As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents GbEscrituracion As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents DTRpp As DateTimePicker
    Friend WithEvents TBNumeroRPP As TextBox
    Friend WithEvents TBFolioRPP As TextBox
    Friend WithEvents TBLibroRPP As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TBWMinutos As TextBox
    Friend WithEvents TBWHoras As TextBox
    Friend WithEvents TBWGrados As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TBNGrados As TextBox
    Friend WithEvents TBNHoras As TextBox
    Friend WithEvents TBNMinutos As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CBColonia As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TBNoLote As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DGDocumentosPropietario As DataGridView
    Friend WithEvents BTAbrirCarpeta As Button
End Class
