<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Prerregistro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Prerregistro))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LbTitle = New System.Windows.Forms.Label()
        Me.LbNombre = New System.Windows.Forms.Label()
        Me.LbRFC = New System.Windows.Forms.Label()
        Me.LbCURP = New System.Windows.Forms.Label()
        Me.LbTelefono = New System.Windows.Forms.Label()
        Me.LbCorreo = New System.Windows.Forms.Label()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.TBRFC = New System.Windows.Forms.TextBox()
        Me.TBCURP = New System.Windows.Forms.TextBox()
        Me.TBTelefono = New System.Windows.Forms.TextBox()
        Me.TBCorreo = New System.Windows.Forms.TextBox()
        Me.LbFecha = New System.Windows.Forms.Label()
        Me.TBFecha = New System.Windows.Forms.TextBox()
        Me.MSPreregistro = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OFDPreregistro = New System.Windows.Forms.OpenFileDialog()
        Me.LBTipoPersona = New System.Windows.Forms.Label()
        Me.CBTipoPersona = New System.Windows.Forms.ComboBox()
        Me.PBFoto = New System.Windows.Forms.PictureBox()
        Me.DGDocumentos = New System.Windows.Forms.DataGridView()
        Me.LbIdEstado = New System.Windows.Forms.Label()
        Me.CBIdEstado = New System.Windows.Forms.ComboBox()
        Me.LbIdCliente = New System.Windows.Forms.Label()
        Me.TBIdCliente = New System.Windows.Forms.TextBox()
        Me.TBCalle = New System.Windows.Forms.TextBox()
        Me.TCRegistro = New System.Windows.Forms.TabControl()
        Me.TPDatosRegistroPersonas = New System.Windows.Forms.TabPage()
        Me.BtnCarpetas = New System.Windows.Forms.Button()
        Me.LbEstadoCivil = New System.Windows.Forms.Label()
        Me.CBEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.GBDatosConyugue = New System.Windows.Forms.GroupBox()
        Me.TBCURPConyugue = New System.Windows.Forms.TextBox()
        Me.TBRFCConyugue = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TPDatos = New System.Windows.Forms.TabPage()
        Me.GBSocios = New System.Windows.Forms.GroupBox()
        Me.DGAgregados = New System.Windows.Forms.DataGridView()
        Me.BtAgregar = New System.Windows.Forms.Button()
        Me.DGSocios = New System.Windows.Forms.DataGridView()
        Me.LbTesorero = New System.Windows.Forms.Label()
        Me.LbRepLegal = New System.Windows.Forms.Label()
        Me.LbSecretario = New System.Windows.Forms.Label()
        Me.LbPresidente = New System.Windows.Forms.Label()
        Me.CBTesorero = New System.Windows.Forms.ComboBox()
        Me.CBRL = New System.Windows.Forms.ComboBox()
        Me.CBSecretario = New System.Windows.Forms.ComboBox()
        Me.CBPresidente = New System.Windows.Forms.ComboBox()
        Me.LbSegundoNombre = New System.Windows.Forms.Label()
        Me.TBSegNombre = New System.Windows.Forms.TextBox()
        Me.TBApePaterno = New System.Windows.Forms.TextBox()
        Me.TBApeMaterno = New System.Windows.Forms.TextBox()
        Me.LbApellidoPaterno = New System.Windows.Forms.Label()
        Me.LbApellidoMaterno = New System.Windows.Forms.Label()
        Me.GBDatosPersonaFisica = New System.Windows.Forms.GroupBox()
        Me.LbSexo = New System.Windows.Forms.Label()
        Me.TBAnios = New System.Windows.Forms.TextBox()
        Me.CBSexo = New System.Windows.Forms.ComboBox()
        Me.LbEdad = New System.Windows.Forms.Label()
        Me.LbNacionalidad = New System.Windows.Forms.Label()
        Me.CBNacionalidad = New System.Windows.Forms.ComboBox()
        Me.GBDomicilio = New System.Windows.Forms.GroupBox()
        Me.LbCalle = New System.Windows.Forms.Label()
        Me.LbColonia = New System.Windows.Forms.Label()
        Me.TBColonia = New System.Windows.Forms.TextBox()
        Me.TBNumero = New System.Windows.Forms.TextBox()
        Me.LbNumero = New System.Windows.Forms.Label()
        Me.LbEstado = New System.Windows.Forms.Label()
        Me.LbMunicipio = New System.Windows.Forms.Label()
        Me.TBPoblacion = New System.Windows.Forms.TextBox()
        Me.LbPoblacion = New System.Windows.Forms.Label()
        Me.TbCP = New System.Windows.Forms.TextBox()
        Me.LbCP = New System.Windows.Forms.Label()
        Me.CBEstado = New System.Windows.Forms.ComboBox()
        Me.CBMunicipio = New System.Windows.Forms.ComboBox()
        Me.GBFecNac = New System.Windows.Forms.GroupBox()
        Me.LbFechaNac = New System.Windows.Forms.Label()
        Me.DTPFecha = New System.Windows.Forms.DateTimePicker()
        Me.LbEstadoNac = New System.Windows.Forms.Label()
        Me.LbMunicipioNac = New System.Windows.Forms.Label()
        Me.CBEstadoNac = New System.Windows.Forms.ComboBox()
        Me.CBMunicipioNac = New System.Windows.Forms.ComboBox()
        Me.LbImporte = New System.Windows.Forms.Label()
        Me.TBImporte = New System.Windows.Forms.TextBox()
        Me.LbImporteLetra = New System.Windows.Forms.Label()
        Me.TBImporteLetra = New System.Windows.Forms.TextBox()
        Me.TBActividad = New System.Windows.Forms.TextBox()
        Me.LbActividad = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.MSPreregistro.SuspendLayout()
        CType(Me.PBFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TCRegistro.SuspendLayout()
        Me.TPDatosRegistroPersonas.SuspendLayout()
        Me.GBDatosConyugue.SuspendLayout()
        Me.TPDatos.SuspendLayout()
        Me.GBSocios.SuspendLayout()
        CType(Me.DGAgregados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGSocios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBDatosPersonaFisica.SuspendLayout()
        Me.GBDomicilio.SuspendLayout()
        Me.GBFecNac.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LbTitle
        '
        resources.ApplyResources(Me.LbTitle, "LbTitle")
        Me.LbTitle.Name = "LbTitle"
        '
        'LbNombre
        '
        resources.ApplyResources(Me.LbNombre, "LbNombre")
        Me.LbNombre.Name = "LbNombre"
        '
        'LbRFC
        '
        resources.ApplyResources(Me.LbRFC, "LbRFC")
        Me.LbRFC.Name = "LbRFC"
        '
        'LbCURP
        '
        resources.ApplyResources(Me.LbCURP, "LbCURP")
        Me.LbCURP.Name = "LbCURP"
        '
        'LbTelefono
        '
        resources.ApplyResources(Me.LbTelefono, "LbTelefono")
        Me.LbTelefono.Name = "LbTelefono"
        '
        'LbCorreo
        '
        resources.ApplyResources(Me.LbCorreo, "LbCorreo")
        Me.LbCorreo.Name = "LbCorreo"
        '
        'TBNombre
        '
        Me.TBNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.TBNombre, "TBNombre")
        Me.TBNombre.Name = "TBNombre"
        '
        'TBRFC
        '
        Me.TBRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.TBRFC, "TBRFC")
        Me.TBRFC.Name = "TBRFC"
        '
        'TBCURP
        '
        Me.TBCURP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.TBCURP, "TBCURP")
        Me.TBCURP.Name = "TBCURP"
        '
        'TBTelefono
        '
        resources.ApplyResources(Me.TBTelefono, "TBTelefono")
        Me.TBTelefono.Name = "TBTelefono"
        '
        'TBCorreo
        '
        resources.ApplyResources(Me.TBCorreo, "TBCorreo")
        Me.TBCorreo.Name = "TBCorreo"
        '
        'LbFecha
        '
        resources.ApplyResources(Me.LbFecha, "LbFecha")
        Me.LbFecha.Name = "LbFecha"
        '
        'TBFecha
        '
        resources.ApplyResources(Me.TBFecha, "TBFecha")
        Me.TBFecha.Name = "TBFecha"
        '
        'MSPreregistro
        '
        Me.MSPreregistro.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.SalirToolStripMenuItem})
        resources.ApplyResources(Me.MSPreregistro, "MSPreregistro")
        Me.MSPreregistro.Name = "MSPreregistro"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        resources.ApplyResources(Me.NuevoToolStripMenuItem, "NuevoToolStripMenuItem")
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        resources.ApplyResources(Me.GuardarToolStripMenuItem, "GuardarToolStripMenuItem")
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        resources.ApplyResources(Me.ConsultarToolStripMenuItem, "ConsultarToolStripMenuItem")
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        resources.ApplyResources(Me.SalirToolStripMenuItem, "SalirToolStripMenuItem")
        '
        'OFDPreregistro
        '
        Me.OFDPreregistro.FileName = "OFDPreregistro"
        '
        'LBTipoPersona
        '
        resources.ApplyResources(Me.LBTipoPersona, "LBTipoPersona")
        Me.LBTipoPersona.Name = "LBTipoPersona"
        '
        'CBTipoPersona
        '
        Me.CBTipoPersona.FormattingEnabled = True
        resources.ApplyResources(Me.CBTipoPersona, "CBTipoPersona")
        Me.CBTipoPersona.Name = "CBTipoPersona"
        '
        'PBFoto
        '
        resources.ApplyResources(Me.PBFoto, "PBFoto")
        Me.PBFoto.Name = "PBFoto"
        Me.PBFoto.TabStop = False
        '
        'DGDocumentos
        '
        Me.DGDocumentos.AllowUserToAddRows = False
        Me.DGDocumentos.AllowUserToDeleteRows = False
        Me.DGDocumentos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGDocumentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DGDocumentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGDocumentos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.DGDocumentos, "DGDocumentos")
        Me.DGDocumentos.Name = "DGDocumentos"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGDocumentos.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DGDocumentos.RowHeadersVisible = False
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGDocumentos.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DGDocumentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'LbIdEstado
        '
        resources.ApplyResources(Me.LbIdEstado, "LbIdEstado")
        Me.LbIdEstado.Name = "LbIdEstado"
        '
        'CBIdEstado
        '
        Me.CBIdEstado.FormattingEnabled = True
        Me.CBIdEstado.Items.AddRange(New Object() {resources.GetString("CBIdEstado.Items"), resources.GetString("CBIdEstado.Items1")})
        resources.ApplyResources(Me.CBIdEstado, "CBIdEstado")
        Me.CBIdEstado.Name = "CBIdEstado"
        '
        'LbIdCliente
        '
        resources.ApplyResources(Me.LbIdCliente, "LbIdCliente")
        Me.LbIdCliente.Name = "LbIdCliente"
        '
        'TBIdCliente
        '
        Me.TBIdCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.TBIdCliente, "TBIdCliente")
        Me.TBIdCliente.Name = "TBIdCliente"
        '
        'TBCalle
        '
        Me.TBCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.TBCalle, "TBCalle")
        Me.TBCalle.Name = "TBCalle"
        '
        'TCRegistro
        '
        Me.TCRegistro.Controls.Add(Me.TPDatosRegistroPersonas)
        Me.TCRegistro.Controls.Add(Me.TPDatos)
        resources.ApplyResources(Me.TCRegistro, "TCRegistro")
        Me.TCRegistro.Name = "TCRegistro"
        Me.TCRegistro.SelectedIndex = 0
        '
        'TPDatosRegistroPersonas
        '
        Me.TPDatosRegistroPersonas.Controls.Add(Me.LbActividad)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.TBActividad)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.TBImporteLetra)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.LbImporteLetra)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.TBImporte)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.LbImporte)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.GBFecNac)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.GBDomicilio)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.GBDatosPersonaFisica)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.LbEstadoCivil)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.CBEstadoCivil)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.GBDatosConyugue)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.DGDocumentos)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.LbNombre)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.LbRFC)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.LbCURP)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.LbTelefono)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.TBIdCliente)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.LbCorreo)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.LbIdCliente)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.TBNombre)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.CBIdEstado)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.TBRFC)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.LbIdEstado)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.TBCURP)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.TBTelefono)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.CBTipoPersona)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.TBCorreo)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.LBTipoPersona)
        resources.ApplyResources(Me.TPDatosRegistroPersonas, "TPDatosRegistroPersonas")
        Me.TPDatosRegistroPersonas.Name = "TPDatosRegistroPersonas"
        Me.TPDatosRegistroPersonas.UseVisualStyleBackColor = True
        '
        'BtnCarpetas
        '
        resources.ApplyResources(Me.BtnCarpetas, "BtnCarpetas")
        Me.BtnCarpetas.Name = "BtnCarpetas"
        Me.BtnCarpetas.UseVisualStyleBackColor = True
        '
        'LbEstadoCivil
        '
        resources.ApplyResources(Me.LbEstadoCivil, "LbEstadoCivil")
        Me.LbEstadoCivil.Name = "LbEstadoCivil"
        '
        'CBEstadoCivil
        '
        Me.CBEstadoCivil.FormattingEnabled = True
        resources.ApplyResources(Me.CBEstadoCivil, "CBEstadoCivil")
        Me.CBEstadoCivil.Name = "CBEstadoCivil"
        '
        'GBDatosConyugue
        '
        Me.GBDatosConyugue.Controls.Add(Me.Label4)
        Me.GBDatosConyugue.Controls.Add(Me.TextBox5)
        Me.GBDatosConyugue.Controls.Add(Me.GroupBox2)
        Me.GBDatosConyugue.Controls.Add(Me.GroupBox1)
        Me.GBDatosConyugue.Controls.Add(Me.Label7)
        Me.GBDatosConyugue.Controls.Add(Me.TextBox4)
        Me.GBDatosConyugue.Controls.Add(Me.Label6)
        Me.GBDatosConyugue.Controls.Add(Me.TextBox3)
        Me.GBDatosConyugue.Controls.Add(Me.Label5)
        Me.GBDatosConyugue.Controls.Add(Me.TextBox2)
        Me.GBDatosConyugue.Controls.Add(Me.Label2)
        Me.GBDatosConyugue.Controls.Add(Me.TextBox1)
        Me.GBDatosConyugue.Controls.Add(Me.TBCURPConyugue)
        Me.GBDatosConyugue.Controls.Add(Me.TBRFCConyugue)
        Me.GBDatosConyugue.Controls.Add(Me.Label3)
        Me.GBDatosConyugue.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.GBDatosConyugue, "GBDatosConyugue")
        Me.GBDatosConyugue.Name = "GBDatosConyugue"
        Me.GBDatosConyugue.TabStop = False
        '
        'TBCURPConyugue
        '
        resources.ApplyResources(Me.TBCURPConyugue, "TBCURPConyugue")
        Me.TBCURPConyugue.Name = "TBCURPConyugue"
        '
        'TBRFCConyugue
        '
        resources.ApplyResources(Me.TBRFCConyugue, "TBRFCConyugue")
        Me.TBRFCConyugue.Name = "TBRFCConyugue"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'TPDatos
        '
        Me.TPDatos.Controls.Add(Me.GBSocios)
        Me.TPDatos.Controls.Add(Me.LbTesorero)
        Me.TPDatos.Controls.Add(Me.LbRepLegal)
        Me.TPDatos.Controls.Add(Me.LbSecretario)
        Me.TPDatos.Controls.Add(Me.LbPresidente)
        Me.TPDatos.Controls.Add(Me.CBTesorero)
        Me.TPDatos.Controls.Add(Me.CBRL)
        Me.TPDatos.Controls.Add(Me.CBSecretario)
        Me.TPDatos.Controls.Add(Me.CBPresidente)
        resources.ApplyResources(Me.TPDatos, "TPDatos")
        Me.TPDatos.Name = "TPDatos"
        Me.TPDatos.UseVisualStyleBackColor = True
        '
        'GBSocios
        '
        Me.GBSocios.Controls.Add(Me.DGAgregados)
        Me.GBSocios.Controls.Add(Me.BtAgregar)
        Me.GBSocios.Controls.Add(Me.DGSocios)
        resources.ApplyResources(Me.GBSocios, "GBSocios")
        Me.GBSocios.Name = "GBSocios"
        Me.GBSocios.TabStop = False
        '
        'DGAgregados
        '
        Me.DGAgregados.AllowUserToAddRows = False
        Me.DGAgregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.DGAgregados, "DGAgregados")
        Me.DGAgregados.Name = "DGAgregados"
        '
        'BtAgregar
        '
        resources.ApplyResources(Me.BtAgregar, "BtAgregar")
        Me.BtAgregar.Name = "BtAgregar"
        Me.BtAgregar.UseVisualStyleBackColor = True
        '
        'DGSocios
        '
        Me.DGSocios.AllowUserToAddRows = False
        Me.DGSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.DGSocios, "DGSocios")
        Me.DGSocios.Name = "DGSocios"
        '
        'LbTesorero
        '
        resources.ApplyResources(Me.LbTesorero, "LbTesorero")
        Me.LbTesorero.Name = "LbTesorero"
        '
        'LbRepLegal
        '
        resources.ApplyResources(Me.LbRepLegal, "LbRepLegal")
        Me.LbRepLegal.Name = "LbRepLegal"
        '
        'LbSecretario
        '
        resources.ApplyResources(Me.LbSecretario, "LbSecretario")
        Me.LbSecretario.Name = "LbSecretario"
        '
        'LbPresidente
        '
        resources.ApplyResources(Me.LbPresidente, "LbPresidente")
        Me.LbPresidente.Name = "LbPresidente"
        '
        'CBTesorero
        '
        resources.ApplyResources(Me.CBTesorero, "CBTesorero")
        Me.CBTesorero.FormattingEnabled = True
        Me.CBTesorero.Name = "CBTesorero"
        '
        'CBRL
        '
        resources.ApplyResources(Me.CBRL, "CBRL")
        Me.CBRL.FormattingEnabled = True
        Me.CBRL.Name = "CBRL"
        '
        'CBSecretario
        '
        resources.ApplyResources(Me.CBSecretario, "CBSecretario")
        Me.CBSecretario.FormattingEnabled = True
        Me.CBSecretario.Name = "CBSecretario"
        '
        'CBPresidente
        '
        resources.ApplyResources(Me.CBPresidente, "CBPresidente")
        Me.CBPresidente.FormattingEnabled = True
        Me.CBPresidente.Name = "CBPresidente"
        '
        'LbSegundoNombre
        '
        resources.ApplyResources(Me.LbSegundoNombre, "LbSegundoNombre")
        Me.LbSegundoNombre.Name = "LbSegundoNombre"
        '
        'TBSegNombre
        '
        resources.ApplyResources(Me.TBSegNombre, "TBSegNombre")
        Me.TBSegNombre.Name = "TBSegNombre"
        '
        'TBApePaterno
        '
        resources.ApplyResources(Me.TBApePaterno, "TBApePaterno")
        Me.TBApePaterno.Name = "TBApePaterno"
        '
        'TBApeMaterno
        '
        resources.ApplyResources(Me.TBApeMaterno, "TBApeMaterno")
        Me.TBApeMaterno.Name = "TBApeMaterno"
        '
        'LbApellidoPaterno
        '
        resources.ApplyResources(Me.LbApellidoPaterno, "LbApellidoPaterno")
        Me.LbApellidoPaterno.Name = "LbApellidoPaterno"
        '
        'LbApellidoMaterno
        '
        resources.ApplyResources(Me.LbApellidoMaterno, "LbApellidoMaterno")
        Me.LbApellidoMaterno.Name = "LbApellidoMaterno"
        '
        'GBDatosPersonaFisica
        '
        Me.GBDatosPersonaFisica.Controls.Add(Me.LbEdad)
        Me.GBDatosPersonaFisica.Controls.Add(Me.CBSexo)
        Me.GBDatosPersonaFisica.Controls.Add(Me.TBAnios)
        Me.GBDatosPersonaFisica.Controls.Add(Me.LbSexo)
        Me.GBDatosPersonaFisica.Controls.Add(Me.LbSegundoNombre)
        Me.GBDatosPersonaFisica.Controls.Add(Me.LbApellidoMaterno)
        Me.GBDatosPersonaFisica.Controls.Add(Me.TBSegNombre)
        Me.GBDatosPersonaFisica.Controls.Add(Me.LbApellidoPaterno)
        Me.GBDatosPersonaFisica.Controls.Add(Me.TBApePaterno)
        Me.GBDatosPersonaFisica.Controls.Add(Me.TBApeMaterno)
        resources.ApplyResources(Me.GBDatosPersonaFisica, "GBDatosPersonaFisica")
        Me.GBDatosPersonaFisica.Name = "GBDatosPersonaFisica"
        Me.GBDatosPersonaFisica.TabStop = False
        '
        'LbSexo
        '
        resources.ApplyResources(Me.LbSexo, "LbSexo")
        Me.LbSexo.Name = "LbSexo"
        '
        'TBAnios
        '
        resources.ApplyResources(Me.TBAnios, "TBAnios")
        Me.TBAnios.Name = "TBAnios"
        '
        'CBSexo
        '
        Me.CBSexo.FormattingEnabled = True
        resources.ApplyResources(Me.CBSexo, "CBSexo")
        Me.CBSexo.Name = "CBSexo"
        '
        'LbEdad
        '
        resources.ApplyResources(Me.LbEdad, "LbEdad")
        Me.LbEdad.Name = "LbEdad"
        '
        'LbNacionalidad
        '
        resources.ApplyResources(Me.LbNacionalidad, "LbNacionalidad")
        Me.LbNacionalidad.Name = "LbNacionalidad"
        '
        'CBNacionalidad
        '
        Me.CBNacionalidad.FormattingEnabled = True
        resources.ApplyResources(Me.CBNacionalidad, "CBNacionalidad")
        Me.CBNacionalidad.Name = "CBNacionalidad"
        '
        'GBDomicilio
        '
        Me.GBDomicilio.Controls.Add(Me.CBMunicipio)
        Me.GBDomicilio.Controls.Add(Me.CBEstado)
        Me.GBDomicilio.Controls.Add(Me.TbCP)
        Me.GBDomicilio.Controls.Add(Me.LbCP)
        Me.GBDomicilio.Controls.Add(Me.TBPoblacion)
        Me.GBDomicilio.Controls.Add(Me.LbPoblacion)
        Me.GBDomicilio.Controls.Add(Me.LbMunicipio)
        Me.GBDomicilio.Controls.Add(Me.LbEstado)
        Me.GBDomicilio.Controls.Add(Me.TBNumero)
        Me.GBDomicilio.Controls.Add(Me.LbNumero)
        Me.GBDomicilio.Controls.Add(Me.TBColonia)
        Me.GBDomicilio.Controls.Add(Me.LbColonia)
        Me.GBDomicilio.Controls.Add(Me.LbCalle)
        Me.GBDomicilio.Controls.Add(Me.TBCalle)
        resources.ApplyResources(Me.GBDomicilio, "GBDomicilio")
        Me.GBDomicilio.Name = "GBDomicilio"
        Me.GBDomicilio.TabStop = False
        '
        'LbCalle
        '
        resources.ApplyResources(Me.LbCalle, "LbCalle")
        Me.LbCalle.Name = "LbCalle"
        '
        'LbColonia
        '
        resources.ApplyResources(Me.LbColonia, "LbColonia")
        Me.LbColonia.Name = "LbColonia"
        '
        'TBColonia
        '
        Me.TBColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.TBColonia, "TBColonia")
        Me.TBColonia.Name = "TBColonia"
        '
        'TBNumero
        '
        Me.TBNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.TBNumero, "TBNumero")
        Me.TBNumero.Name = "TBNumero"
        '
        'LbNumero
        '
        resources.ApplyResources(Me.LbNumero, "LbNumero")
        Me.LbNumero.Name = "LbNumero"
        '
        'LbEstado
        '
        resources.ApplyResources(Me.LbEstado, "LbEstado")
        Me.LbEstado.Name = "LbEstado"
        '
        'LbMunicipio
        '
        resources.ApplyResources(Me.LbMunicipio, "LbMunicipio")
        Me.LbMunicipio.Name = "LbMunicipio"
        '
        'TBPoblacion
        '
        Me.TBPoblacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.TBPoblacion, "TBPoblacion")
        Me.TBPoblacion.Name = "TBPoblacion"
        '
        'LbPoblacion
        '
        resources.ApplyResources(Me.LbPoblacion, "LbPoblacion")
        Me.LbPoblacion.Name = "LbPoblacion"
        '
        'TbCP
        '
        Me.TbCP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.TbCP, "TbCP")
        Me.TbCP.Name = "TbCP"
        '
        'LbCP
        '
        resources.ApplyResources(Me.LbCP, "LbCP")
        Me.LbCP.Name = "LbCP"
        '
        'CBEstado
        '
        Me.CBEstado.FormattingEnabled = True
        resources.ApplyResources(Me.CBEstado, "CBEstado")
        Me.CBEstado.Name = "CBEstado"
        '
        'CBMunicipio
        '
        Me.CBMunicipio.FormattingEnabled = True
        resources.ApplyResources(Me.CBMunicipio, "CBMunicipio")
        Me.CBMunicipio.Name = "CBMunicipio"
        '
        'GBFecNac
        '
        Me.GBFecNac.Controls.Add(Me.CBNacionalidad)
        Me.GBFecNac.Controls.Add(Me.CBMunicipioNac)
        Me.GBFecNac.Controls.Add(Me.LbNacionalidad)
        Me.GBFecNac.Controls.Add(Me.CBEstadoNac)
        Me.GBFecNac.Controls.Add(Me.LbMunicipioNac)
        Me.GBFecNac.Controls.Add(Me.LbEstadoNac)
        Me.GBFecNac.Controls.Add(Me.DTPFecha)
        Me.GBFecNac.Controls.Add(Me.LbFechaNac)
        resources.ApplyResources(Me.GBFecNac, "GBFecNac")
        Me.GBFecNac.Name = "GBFecNac"
        Me.GBFecNac.TabStop = False
        '
        'LbFechaNac
        '
        resources.ApplyResources(Me.LbFechaNac, "LbFechaNac")
        Me.LbFechaNac.Name = "LbFechaNac"
        '
        'DTPFecha
        '
        resources.ApplyResources(Me.DTPFecha, "DTPFecha")
        Me.DTPFecha.Name = "DTPFecha"
        '
        'LbEstadoNac
        '
        resources.ApplyResources(Me.LbEstadoNac, "LbEstadoNac")
        Me.LbEstadoNac.Name = "LbEstadoNac"
        '
        'LbMunicipioNac
        '
        resources.ApplyResources(Me.LbMunicipioNac, "LbMunicipioNac")
        Me.LbMunicipioNac.Name = "LbMunicipioNac"
        '
        'CBEstadoNac
        '
        Me.CBEstadoNac.FormattingEnabled = True
        resources.ApplyResources(Me.CBEstadoNac, "CBEstadoNac")
        Me.CBEstadoNac.Name = "CBEstadoNac"
        '
        'CBMunicipioNac
        '
        Me.CBMunicipioNac.FormattingEnabled = True
        resources.ApplyResources(Me.CBMunicipioNac, "CBMunicipioNac")
        Me.CBMunicipioNac.Name = "CBMunicipioNac"
        '
        'LbImporte
        '
        resources.ApplyResources(Me.LbImporte, "LbImporte")
        Me.LbImporte.Name = "LbImporte"
        '
        'TBImporte
        '
        resources.ApplyResources(Me.TBImporte, "TBImporte")
        Me.TBImporte.Name = "TBImporte"
        '
        'LbImporteLetra
        '
        resources.ApplyResources(Me.LbImporteLetra, "LbImporteLetra")
        Me.LbImporteLetra.Name = "LbImporteLetra"
        '
        'TBImporteLetra
        '
        resources.ApplyResources(Me.TBImporteLetra, "TBImporteLetra")
        Me.TBImporteLetra.Name = "TBImporteLetra"
        '
        'TBActividad
        '
        resources.ApplyResources(Me.TBActividad, "TBActividad")
        Me.TBActividad.Name = "TBActividad"
        '
        'LbActividad
        '
        resources.ApplyResources(Me.LbActividad, "LbActividad")
        Me.LbActividad.Name = "LbActividad"
        '
        'TextBox1
        '
        resources.ApplyResources(Me.TextBox1, "TextBox1")
        Me.TextBox1.Name = "TextBox1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'TextBox2
        '
        resources.ApplyResources(Me.TextBox2, "TextBox2")
        Me.TextBox2.Name = "TextBox2"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'TextBox3
        '
        resources.ApplyResources(Me.TextBox3, "TextBox3")
        Me.TextBox3.Name = "TextBox3"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'TextBox4
        '
        resources.ApplyResources(Me.TextBox4, "TextBox4")
        Me.TextBox4.Name = "TextBox4"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.Label11)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        resources.ApplyResources(Me.ComboBox1, "ComboBox1")
        Me.ComboBox1.Name = "ComboBox1"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        resources.ApplyResources(Me.ComboBox2, "ComboBox2")
        Me.ComboBox2.Name = "ComboBox2"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'DateTimePicker2
        '
        resources.ApplyResources(Me.DateTimePicker2, "DateTimePicker2")
        Me.DateTimePicker2.Name = "DateTimePicker2"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        resources.ApplyResources(Me.ComboBox3, "ComboBox3")
        Me.ComboBox3.Name = "ComboBox3"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox5)
        Me.GroupBox2.Controls.Add(Me.ComboBox6)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Label14)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        resources.ApplyResources(Me.ComboBox5, "ComboBox5")
        Me.ComboBox5.Name = "ComboBox5"
        '
        'ComboBox6
        '
        Me.ComboBox6.FormattingEnabled = True
        resources.ApplyResources(Me.ComboBox6, "ComboBox6")
        Me.ComboBox6.Name = "ComboBox6"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.Name = "Label13"
        '
        'DateTimePicker1
        '
        resources.ApplyResources(Me.DateTimePicker1, "DateTimePicker1")
        Me.DateTimePicker1.Name = "DateTimePicker1"
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.Name = "Label14"
        '
        'TextBox5
        '
        resources.ApplyResources(Me.TextBox5, "TextBox5")
        Me.TextBox5.Name = "TextBox5"
        '
        'Prerregistro
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TCRegistro)
        Me.Controls.Add(Me.TBFecha)
        Me.Controls.Add(Me.BtnCarpetas)
        Me.Controls.Add(Me.LbFecha)
        Me.Controls.Add(Me.PBFoto)
        Me.Controls.Add(Me.LbTitle)
        Me.Controls.Add(Me.MSPreregistro)
        Me.MainMenuStrip = Me.MSPreregistro
        Me.Name = "Prerregistro"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.MSPreregistro.ResumeLayout(False)
        Me.MSPreregistro.PerformLayout()
        CType(Me.PBFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TCRegistro.ResumeLayout(False)
        Me.TPDatosRegistroPersonas.ResumeLayout(False)
        Me.TPDatosRegistroPersonas.PerformLayout()
        Me.GBDatosConyugue.ResumeLayout(False)
        Me.GBDatosConyugue.PerformLayout()
        Me.TPDatos.ResumeLayout(False)
        Me.TPDatos.PerformLayout()
        Me.GBSocios.ResumeLayout(False)
        CType(Me.DGAgregados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGSocios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBDatosPersonaFisica.ResumeLayout(False)
        Me.GBDatosPersonaFisica.PerformLayout()
        Me.GBDomicilio.ResumeLayout(False)
        Me.GBDomicilio.PerformLayout()
        Me.GBFecNac.ResumeLayout(False)
        Me.GBFecNac.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbTitle As Label
    Friend WithEvents LbNombre As Label
    Friend WithEvents LbRFC As Label
    Friend WithEvents LbCURP As Label
    Friend WithEvents LbTelefono As Label
    Friend WithEvents LbCorreo As Label
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents TBRFC As TextBox
    Friend WithEvents TBCURP As TextBox
    Friend WithEvents TBTelefono As TextBox
    Friend WithEvents TBCorreo As TextBox
    Friend WithEvents PBFoto As PictureBox
    Friend WithEvents LbFecha As Label
    Friend WithEvents TBFecha As TextBox
    Friend WithEvents MSPreregistro As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OFDPreregistro As OpenFileDialog
    Friend WithEvents LBTipoPersona As Label
    Friend WithEvents CBTipoPersona As ComboBox
    Friend WithEvents DGDocumentos As DataGridView
    Friend WithEvents LbIdEstado As Label
    Friend WithEvents CBIdEstado As ComboBox
    Friend WithEvents LbIdCliente As Label
    Friend WithEvents TBIdCliente As TextBox
    Friend WithEvents TBCalle As TextBox
    Friend WithEvents TCRegistro As TabControl
    Friend WithEvents TPDatosRegistroPersonas As TabPage
    Friend WithEvents TPDatos As TabPage
    Friend WithEvents GBSocios As GroupBox
    Friend WithEvents DGSocios As DataGridView
    Friend WithEvents LbTesorero As Label
    Friend WithEvents LbRepLegal As Label
    Friend WithEvents LbSecretario As Label
    Friend WithEvents LbPresidente As Label
    Friend WithEvents CBTesorero As ComboBox
    Friend WithEvents CBRL As ComboBox
    Friend WithEvents CBSecretario As ComboBox
    Friend WithEvents CBPresidente As ComboBox
    Friend WithEvents LbEstadoCivil As Label
    Friend WithEvents CBEstadoCivil As ComboBox
    Friend WithEvents GBDatosConyugue As GroupBox
    Friend WithEvents TBCURPConyugue As TextBox
    Friend WithEvents TBRFCConyugue As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DGAgregados As DataGridView
    Friend WithEvents BtAgregar As Button
    Friend WithEvents BtnCarpetas As Button
    Friend WithEvents GBDatosPersonaFisica As GroupBox
    Friend WithEvents LbApellidoMaterno As Label
    Friend WithEvents LbApellidoPaterno As Label
    Friend WithEvents TBApeMaterno As TextBox
    Friend WithEvents TBApePaterno As TextBox
    Friend WithEvents TBSegNombre As TextBox
    Friend WithEvents LbSegundoNombre As Label
    Friend WithEvents GBDomicilio As GroupBox
    Friend WithEvents CBMunicipio As ComboBox
    Friend WithEvents CBEstado As ComboBox
    Friend WithEvents TbCP As TextBox
    Friend WithEvents LbCP As Label
    Friend WithEvents TBPoblacion As TextBox
    Friend WithEvents LbPoblacion As Label
    Friend WithEvents LbMunicipio As Label
    Friend WithEvents LbEstado As Label
    Friend WithEvents TBNumero As TextBox
    Friend WithEvents LbNumero As Label
    Friend WithEvents TBColonia As TextBox
    Friend WithEvents LbColonia As Label
    Friend WithEvents LbCalle As Label
    Friend WithEvents CBNacionalidad As ComboBox
    Friend WithEvents LbNacionalidad As Label
    Friend WithEvents LbEdad As Label
    Friend WithEvents CBSexo As ComboBox
    Friend WithEvents TBAnios As TextBox
    Friend WithEvents LbSexo As Label
    Friend WithEvents GBFecNac As GroupBox
    Friend WithEvents LbActividad As Label
    Friend WithEvents TBActividad As TextBox
    Friend WithEvents TBImporteLetra As TextBox
    Friend WithEvents LbImporteLetra As Label
    Friend WithEvents TBImporte As TextBox
    Friend WithEvents LbImporte As Label
    Friend WithEvents CBMunicipioNac As ComboBox
    Friend WithEvents CBEstadoNac As ComboBox
    Friend WithEvents LbMunicipioNac As Label
    Friend WithEvents LbEstadoNac As Label
    Friend WithEvents DTPFecha As DateTimePicker
    Friend WithEvents LbFechaNac As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label11 As Label
End Class
