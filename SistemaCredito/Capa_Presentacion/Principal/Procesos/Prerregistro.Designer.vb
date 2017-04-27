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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.CBIdEstatus = New System.Windows.Forms.ComboBox()
        Me.LbIdCliente = New System.Windows.Forms.Label()
        Me.TBIdCliente = New System.Windows.Forms.TextBox()
        Me.TBCalle = New System.Windows.Forms.TextBox()
        Me.TCRegistro = New System.Windows.Forms.TabControl()
        Me.TPDatosRegistroPersonas = New System.Windows.Forms.TabPage()
        Me.CBRegimen = New System.Windows.Forms.ComboBox()
        Me.LbRegimen = New System.Windows.Forms.Label()
        Me.LbTipoCambio = New System.Windows.Forms.Label()
        Me.CBTipoCambio = New System.Windows.Forms.ComboBox()
        Me.GBFecMatConyugue = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBConyugue = New System.Windows.Forms.ComboBox()
        Me.CBMunicipioMatrimonioCony = New System.Windows.Forms.ComboBox()
        Me.CBEstadoMatrimonioCony = New System.Windows.Forms.ComboBox()
        Me.LbMunicipioMatrimonioCony = New System.Windows.Forms.Label()
        Me.LbEstadoMatrimonioCony = New System.Windows.Forms.Label()
        Me.DTPFechaMatrimonioCony = New System.Windows.Forms.DateTimePicker()
        Me.LbFechaMatrimonioCony = New System.Windows.Forms.Label()
        Me.LbActividad = New System.Windows.Forms.Label()
        Me.TBActividad = New System.Windows.Forms.TextBox()
        Me.TBImporteLetra = New System.Windows.Forms.TextBox()
        Me.LbImporteLetra = New System.Windows.Forms.Label()
        Me.TBImporte = New System.Windows.Forms.TextBox()
        Me.LbImporte = New System.Windows.Forms.Label()
        Me.GBFechaNacimiento = New System.Windows.Forms.GroupBox()
        Me.CBMunicipioNac = New System.Windows.Forms.ComboBox()
        Me.CBEstadoNac = New System.Windows.Forms.ComboBox()
        Me.LbMunicipioNac = New System.Windows.Forms.Label()
        Me.LbEstadoNac = New System.Windows.Forms.Label()
        Me.DTPFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.LbFechaNac = New System.Windows.Forms.Label()
        Me.GBDomicilio = New System.Windows.Forms.GroupBox()
        Me.CBMunicipio = New System.Windows.Forms.ComboBox()
        Me.CBEstado = New System.Windows.Forms.ComboBox()
        Me.TBCP = New System.Windows.Forms.TextBox()
        Me.LbCP = New System.Windows.Forms.Label()
        Me.TBPoblacion = New System.Windows.Forms.TextBox()
        Me.LbPoblacion = New System.Windows.Forms.Label()
        Me.LbMunicipio = New System.Windows.Forms.Label()
        Me.LbEstado = New System.Windows.Forms.Label()
        Me.TBNumero = New System.Windows.Forms.TextBox()
        Me.LbNumero = New System.Windows.Forms.Label()
        Me.TBColonia = New System.Windows.Forms.TextBox()
        Me.LbColonia = New System.Windows.Forms.Label()
        Me.LbCalle = New System.Windows.Forms.Label()
        Me.GBDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.CBNacionalidadNac = New System.Windows.Forms.ComboBox()
        Me.LbNacionalidad = New System.Windows.Forms.Label()
        Me.LbEdad = New System.Windows.Forms.Label()
        Me.CBSexo = New System.Windows.Forms.ComboBox()
        Me.TBEdad = New System.Windows.Forms.TextBox()
        Me.LbSexo = New System.Windows.Forms.Label()
        Me.LbSegundoNombre = New System.Windows.Forms.Label()
        Me.LbApellidoMaterno = New System.Windows.Forms.Label()
        Me.TBSegNombre = New System.Windows.Forms.TextBox()
        Me.LbApellidoPaterno = New System.Windows.Forms.Label()
        Me.TBApePaterno = New System.Windows.Forms.TextBox()
        Me.TBApeMaterno = New System.Windows.Forms.TextBox()
        Me.LbEstadoCivil = New System.Windows.Forms.Label()
        Me.CBEstadoCivil = New System.Windows.Forms.ComboBox()
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
        Me.BtnCarpetas = New System.Windows.Forms.Button()
        Me.MSPreregistro.SuspendLayout()
        CType(Me.PBFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TCRegistro.SuspendLayout()
        Me.TPDatosRegistroPersonas.SuspendLayout()
        Me.GBFecMatConyugue.SuspendLayout()
        Me.GBFechaNacimiento.SuspendLayout()
        Me.GBDomicilio.SuspendLayout()
        Me.GBDatosGenerales.SuspendLayout()
        Me.TPDatos.SuspendLayout()
        Me.GBSocios.SuspendLayout()
        CType(Me.DGAgregados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGSocios, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CBTipoPersona.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CBTipoPersona.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGDocumentos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.DGDocumentos, "DGDocumentos")
        Me.DGDocumentos.Name = "DGDocumentos"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGDocumentos.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGDocumentos.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGDocumentos.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGDocumentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'LbIdEstado
        '
        resources.ApplyResources(Me.LbIdEstado, "LbIdEstado")
        Me.LbIdEstado.Name = "LbIdEstado"
        '
        'CBIdEstatus
        '
        Me.CBIdEstatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CBIdEstatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        resources.ApplyResources(Me.CBIdEstatus, "CBIdEstatus")
        Me.CBIdEstatus.FormattingEnabled = True
        Me.CBIdEstatus.Items.AddRange(New Object() {resources.GetString("CBIdEstatus.Items"), resources.GetString("CBIdEstatus.Items1")})
        Me.CBIdEstatus.Name = "CBIdEstatus"
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
        Me.TPDatosRegistroPersonas.Controls.Add(Me.CBRegimen)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.LbRegimen)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.LbTipoCambio)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.CBTipoCambio)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.GBFecMatConyugue)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.LbActividad)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.TBActividad)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.TBImporteLetra)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.LbImporteLetra)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.TBImporte)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.LbImporte)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.GBFechaNacimiento)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.GBDomicilio)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.GBDatosGenerales)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.LbEstadoCivil)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.CBEstadoCivil)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.DGDocumentos)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.LbNombre)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.LbRFC)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.LbCURP)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.LbTelefono)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.TBIdCliente)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.LbCorreo)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.LbIdCliente)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.TBNombre)
        Me.TPDatosRegistroPersonas.Controls.Add(Me.CBIdEstatus)
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
        'CBRegimen
        '
        Me.CBRegimen.FormattingEnabled = True
        resources.ApplyResources(Me.CBRegimen, "CBRegimen")
        Me.CBRegimen.Name = "CBRegimen"
        '
        'LbRegimen
        '
        resources.ApplyResources(Me.LbRegimen, "LbRegimen")
        Me.LbRegimen.Name = "LbRegimen"
        '
        'LbTipoCambio
        '
        resources.ApplyResources(Me.LbTipoCambio, "LbTipoCambio")
        Me.LbTipoCambio.Name = "LbTipoCambio"
        '
        'CBTipoCambio
        '
        Me.CBTipoCambio.FormattingEnabled = True
        resources.ApplyResources(Me.CBTipoCambio, "CBTipoCambio")
        Me.CBTipoCambio.Name = "CBTipoCambio"
        '
        'GBFecMatConyugue
        '
        Me.GBFecMatConyugue.Controls.Add(Me.Label1)
        Me.GBFecMatConyugue.Controls.Add(Me.CBConyugue)
        Me.GBFecMatConyugue.Controls.Add(Me.CBMunicipioMatrimonioCony)
        Me.GBFecMatConyugue.Controls.Add(Me.CBEstadoMatrimonioCony)
        Me.GBFecMatConyugue.Controls.Add(Me.LbMunicipioMatrimonioCony)
        Me.GBFecMatConyugue.Controls.Add(Me.LbEstadoMatrimonioCony)
        Me.GBFecMatConyugue.Controls.Add(Me.DTPFechaMatrimonioCony)
        Me.GBFecMatConyugue.Controls.Add(Me.LbFechaMatrimonioCony)
        resources.ApplyResources(Me.GBFecMatConyugue, "GBFecMatConyugue")
        Me.GBFecMatConyugue.Name = "GBFecMatConyugue"
        Me.GBFecMatConyugue.TabStop = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'CBConyugue
        '
        Me.CBConyugue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CBConyugue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBConyugue.FormattingEnabled = True
        resources.ApplyResources(Me.CBConyugue, "CBConyugue")
        Me.CBConyugue.Name = "CBConyugue"
        '
        'CBMunicipioMatrimonioCony
        '
        Me.CBMunicipioMatrimonioCony.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CBMunicipioMatrimonioCony.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBMunicipioMatrimonioCony.FormattingEnabled = True
        resources.ApplyResources(Me.CBMunicipioMatrimonioCony, "CBMunicipioMatrimonioCony")
        Me.CBMunicipioMatrimonioCony.Name = "CBMunicipioMatrimonioCony"
        '
        'CBEstadoMatrimonioCony
        '
        Me.CBEstadoMatrimonioCony.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CBEstadoMatrimonioCony.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBEstadoMatrimonioCony.FormattingEnabled = True
        resources.ApplyResources(Me.CBEstadoMatrimonioCony, "CBEstadoMatrimonioCony")
        Me.CBEstadoMatrimonioCony.Name = "CBEstadoMatrimonioCony"
        '
        'LbMunicipioMatrimonioCony
        '
        resources.ApplyResources(Me.LbMunicipioMatrimonioCony, "LbMunicipioMatrimonioCony")
        Me.LbMunicipioMatrimonioCony.Name = "LbMunicipioMatrimonioCony"
        '
        'LbEstadoMatrimonioCony
        '
        resources.ApplyResources(Me.LbEstadoMatrimonioCony, "LbEstadoMatrimonioCony")
        Me.LbEstadoMatrimonioCony.Name = "LbEstadoMatrimonioCony"
        '
        'DTPFechaMatrimonioCony
        '
        resources.ApplyResources(Me.DTPFechaMatrimonioCony, "DTPFechaMatrimonioCony")
        Me.DTPFechaMatrimonioCony.Name = "DTPFechaMatrimonioCony"
        '
        'LbFechaMatrimonioCony
        '
        resources.ApplyResources(Me.LbFechaMatrimonioCony, "LbFechaMatrimonioCony")
        Me.LbFechaMatrimonioCony.Name = "LbFechaMatrimonioCony"
        '
        'LbActividad
        '
        resources.ApplyResources(Me.LbActividad, "LbActividad")
        Me.LbActividad.Name = "LbActividad"
        '
        'TBActividad
        '
        resources.ApplyResources(Me.TBActividad, "TBActividad")
        Me.TBActividad.Name = "TBActividad"
        '
        'TBImporteLetra
        '
        resources.ApplyResources(Me.TBImporteLetra, "TBImporteLetra")
        Me.TBImporteLetra.Name = "TBImporteLetra"
        '
        'LbImporteLetra
        '
        resources.ApplyResources(Me.LbImporteLetra, "LbImporteLetra")
        Me.LbImporteLetra.Name = "LbImporteLetra"
        '
        'TBImporte
        '
        resources.ApplyResources(Me.TBImporte, "TBImporte")
        Me.TBImporte.Name = "TBImporte"
        '
        'LbImporte
        '
        resources.ApplyResources(Me.LbImporte, "LbImporte")
        Me.LbImporte.Name = "LbImporte"
        '
        'GBFechaNacimiento
        '
        Me.GBFechaNacimiento.Controls.Add(Me.CBMunicipioNac)
        Me.GBFechaNacimiento.Controls.Add(Me.CBEstadoNac)
        Me.GBFechaNacimiento.Controls.Add(Me.LbMunicipioNac)
        Me.GBFechaNacimiento.Controls.Add(Me.LbEstadoNac)
        Me.GBFechaNacimiento.Controls.Add(Me.DTPFechaNacimiento)
        Me.GBFechaNacimiento.Controls.Add(Me.LbFechaNac)
        resources.ApplyResources(Me.GBFechaNacimiento, "GBFechaNacimiento")
        Me.GBFechaNacimiento.Name = "GBFechaNacimiento"
        Me.GBFechaNacimiento.TabStop = False
        '
        'CBMunicipioNac
        '
        Me.CBMunicipioNac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CBMunicipioNac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBMunicipioNac.FormattingEnabled = True
        resources.ApplyResources(Me.CBMunicipioNac, "CBMunicipioNac")
        Me.CBMunicipioNac.Name = "CBMunicipioNac"
        '
        'CBEstadoNac
        '
        Me.CBEstadoNac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CBEstadoNac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBEstadoNac.FormattingEnabled = True
        resources.ApplyResources(Me.CBEstadoNac, "CBEstadoNac")
        Me.CBEstadoNac.Name = "CBEstadoNac"
        '
        'LbMunicipioNac
        '
        resources.ApplyResources(Me.LbMunicipioNac, "LbMunicipioNac")
        Me.LbMunicipioNac.Name = "LbMunicipioNac"
        '
        'LbEstadoNac
        '
        resources.ApplyResources(Me.LbEstadoNac, "LbEstadoNac")
        Me.LbEstadoNac.Name = "LbEstadoNac"
        '
        'DTPFechaNacimiento
        '
        resources.ApplyResources(Me.DTPFechaNacimiento, "DTPFechaNacimiento")
        Me.DTPFechaNacimiento.Name = "DTPFechaNacimiento"
        '
        'LbFechaNac
        '
        resources.ApplyResources(Me.LbFechaNac, "LbFechaNac")
        Me.LbFechaNac.Name = "LbFechaNac"
        '
        'GBDomicilio
        '
        Me.GBDomicilio.Controls.Add(Me.CBMunicipio)
        Me.GBDomicilio.Controls.Add(Me.CBEstado)
        Me.GBDomicilio.Controls.Add(Me.TBCP)
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
        'CBMunicipio
        '
        Me.CBMunicipio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CBMunicipio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBMunicipio.FormattingEnabled = True
        resources.ApplyResources(Me.CBMunicipio, "CBMunicipio")
        Me.CBMunicipio.Name = "CBMunicipio"
        '
        'CBEstado
        '
        Me.CBEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CBEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBEstado.FormattingEnabled = True
        resources.ApplyResources(Me.CBEstado, "CBEstado")
        Me.CBEstado.Name = "CBEstado"
        '
        'TBCP
        '
        Me.TBCP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.TBCP, "TBCP")
        Me.TBCP.Name = "TBCP"
        '
        'LbCP
        '
        resources.ApplyResources(Me.LbCP, "LbCP")
        Me.LbCP.Name = "LbCP"
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
        'LbMunicipio
        '
        resources.ApplyResources(Me.LbMunicipio, "LbMunicipio")
        Me.LbMunicipio.Name = "LbMunicipio"
        '
        'LbEstado
        '
        resources.ApplyResources(Me.LbEstado, "LbEstado")
        Me.LbEstado.Name = "LbEstado"
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
        'TBColonia
        '
        Me.TBColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.TBColonia, "TBColonia")
        Me.TBColonia.Name = "TBColonia"
        '
        'LbColonia
        '
        resources.ApplyResources(Me.LbColonia, "LbColonia")
        Me.LbColonia.Name = "LbColonia"
        '
        'LbCalle
        '
        resources.ApplyResources(Me.LbCalle, "LbCalle")
        Me.LbCalle.Name = "LbCalle"
        '
        'GBDatosGenerales
        '
        Me.GBDatosGenerales.Controls.Add(Me.CBNacionalidadNac)
        Me.GBDatosGenerales.Controls.Add(Me.LbNacionalidad)
        Me.GBDatosGenerales.Controls.Add(Me.LbEdad)
        Me.GBDatosGenerales.Controls.Add(Me.CBSexo)
        Me.GBDatosGenerales.Controls.Add(Me.TBEdad)
        Me.GBDatosGenerales.Controls.Add(Me.LbSexo)
        Me.GBDatosGenerales.Controls.Add(Me.LbSegundoNombre)
        Me.GBDatosGenerales.Controls.Add(Me.LbApellidoMaterno)
        Me.GBDatosGenerales.Controls.Add(Me.TBSegNombre)
        Me.GBDatosGenerales.Controls.Add(Me.LbApellidoPaterno)
        Me.GBDatosGenerales.Controls.Add(Me.TBApePaterno)
        Me.GBDatosGenerales.Controls.Add(Me.TBApeMaterno)
        resources.ApplyResources(Me.GBDatosGenerales, "GBDatosGenerales")
        Me.GBDatosGenerales.Name = "GBDatosGenerales"
        Me.GBDatosGenerales.TabStop = False
        '
        'CBNacionalidadNac
        '
        Me.CBNacionalidadNac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CBNacionalidadNac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBNacionalidadNac.FormattingEnabled = True
        resources.ApplyResources(Me.CBNacionalidadNac, "CBNacionalidadNac")
        Me.CBNacionalidadNac.Name = "CBNacionalidadNac"
        '
        'LbNacionalidad
        '
        resources.ApplyResources(Me.LbNacionalidad, "LbNacionalidad")
        Me.LbNacionalidad.Name = "LbNacionalidad"
        '
        'LbEdad
        '
        resources.ApplyResources(Me.LbEdad, "LbEdad")
        Me.LbEdad.Name = "LbEdad"
        '
        'CBSexo
        '
        Me.CBSexo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CBSexo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBSexo.FormattingEnabled = True
        resources.ApplyResources(Me.CBSexo, "CBSexo")
        Me.CBSexo.Name = "CBSexo"
        '
        'TBEdad
        '
        resources.ApplyResources(Me.TBEdad, "TBEdad")
        Me.TBEdad.Name = "TBEdad"
        '
        'LbSexo
        '
        resources.ApplyResources(Me.LbSexo, "LbSexo")
        Me.LbSexo.Name = "LbSexo"
        '
        'LbSegundoNombre
        '
        resources.ApplyResources(Me.LbSegundoNombre, "LbSegundoNombre")
        Me.LbSegundoNombre.Name = "LbSegundoNombre"
        '
        'LbApellidoMaterno
        '
        resources.ApplyResources(Me.LbApellidoMaterno, "LbApellidoMaterno")
        Me.LbApellidoMaterno.Name = "LbApellidoMaterno"
        '
        'TBSegNombre
        '
        Me.TBSegNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.TBSegNombre, "TBSegNombre")
        Me.TBSegNombre.Name = "TBSegNombre"
        '
        'LbApellidoPaterno
        '
        resources.ApplyResources(Me.LbApellidoPaterno, "LbApellidoPaterno")
        Me.LbApellidoPaterno.Name = "LbApellidoPaterno"
        '
        'TBApePaterno
        '
        Me.TBApePaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.TBApePaterno, "TBApePaterno")
        Me.TBApePaterno.Name = "TBApePaterno"
        '
        'TBApeMaterno
        '
        Me.TBApeMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.TBApeMaterno, "TBApeMaterno")
        Me.TBApeMaterno.Name = "TBApeMaterno"
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
        Me.CBTesorero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CBTesorero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        resources.ApplyResources(Me.CBTesorero, "CBTesorero")
        Me.CBTesorero.FormattingEnabled = True
        Me.CBTesorero.Name = "CBTesorero"
        '
        'CBRL
        '
        Me.CBRL.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CBRL.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        resources.ApplyResources(Me.CBRL, "CBRL")
        Me.CBRL.FormattingEnabled = True
        Me.CBRL.Name = "CBRL"
        '
        'CBSecretario
        '
        Me.CBSecretario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CBSecretario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        resources.ApplyResources(Me.CBSecretario, "CBSecretario")
        Me.CBSecretario.FormattingEnabled = True
        Me.CBSecretario.Name = "CBSecretario"
        '
        'CBPresidente
        '
        Me.CBPresidente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CBPresidente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        resources.ApplyResources(Me.CBPresidente, "CBPresidente")
        Me.CBPresidente.FormattingEnabled = True
        Me.CBPresidente.Name = "CBPresidente"
        '
        'BtnCarpetas
        '
        resources.ApplyResources(Me.BtnCarpetas, "BtnCarpetas")
        Me.BtnCarpetas.Name = "BtnCarpetas"
        Me.BtnCarpetas.UseVisualStyleBackColor = True
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
        Me.GBFecMatConyugue.ResumeLayout(False)
        Me.GBFecMatConyugue.PerformLayout()
        Me.GBFechaNacimiento.ResumeLayout(False)
        Me.GBFechaNacimiento.PerformLayout()
        Me.GBDomicilio.ResumeLayout(False)
        Me.GBDomicilio.PerformLayout()
        Me.GBDatosGenerales.ResumeLayout(False)
        Me.GBDatosGenerales.PerformLayout()
        Me.TPDatos.ResumeLayout(False)
        Me.TPDatos.PerformLayout()
        Me.GBSocios.ResumeLayout(False)
        CType(Me.DGAgregados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGSocios, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents CBIdEstatus As ComboBox
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
    Friend WithEvents DGAgregados As DataGridView
    Friend WithEvents BtAgregar As Button
    Friend WithEvents BtnCarpetas As Button
    Friend WithEvents GBDatosGenerales As GroupBox
    Friend WithEvents LbApellidoMaterno As Label
    Friend WithEvents LbApellidoPaterno As Label
    Friend WithEvents TBApeMaterno As TextBox
    Friend WithEvents TBApePaterno As TextBox
    Friend WithEvents TBSegNombre As TextBox
    Friend WithEvents LbSegundoNombre As Label
    Friend WithEvents GBDomicilio As GroupBox
    Friend WithEvents CBMunicipio As ComboBox
    Friend WithEvents CBEstado As ComboBox
    Friend WithEvents TBCP As TextBox
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
    Friend WithEvents CBNacionalidadNac As ComboBox
    Friend WithEvents LbNacionalidad As Label
    Friend WithEvents LbEdad As Label
    Friend WithEvents CBSexo As ComboBox
    Friend WithEvents TBEdad As TextBox
    Friend WithEvents LbSexo As Label
    Friend WithEvents GBFechaNacimiento As GroupBox
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
    Friend WithEvents DTPFechaNacimiento As DateTimePicker
    Friend WithEvents LbFechaNac As Label
    Friend WithEvents GBFecMatConyugue As GroupBox
    Friend WithEvents CBMunicipioMatrimonioCony As ComboBox
    Friend WithEvents CBEstadoMatrimonioCony As ComboBox
    Friend WithEvents LbMunicipioMatrimonioCony As Label
    Friend WithEvents LbEstadoMatrimonioCony As Label
    Friend WithEvents DTPFechaMatrimonioCony As DateTimePicker
    Friend WithEvents LbFechaMatrimonioCony As Label
    Friend WithEvents LbTipoCambio As Label
    Friend WithEvents CBTipoCambio As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CBConyugue As ComboBox
    Friend WithEvents CBRegimen As ComboBox
    Friend WithEvents LbRegimen As Label
End Class
