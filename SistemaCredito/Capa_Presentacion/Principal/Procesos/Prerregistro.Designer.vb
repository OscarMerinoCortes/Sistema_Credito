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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBDomicilio = New System.Windows.Forms.TextBox()
        Me.TCRegistro = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LbEstadoCivil = New System.Windows.Forms.Label()
        Me.CBEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.GBDatosConyugue = New System.Windows.Forms.GroupBox()
        Me.TBCURPConyugue = New System.Windows.Forms.TextBox()
        Me.TBRFCConyugue = New System.Windows.Forms.TextBox()
        Me.TBCredencialConyugue = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MSPreregistro.SuspendLayout()
        CType(Me.PBFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TCRegistro.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GBDatosConyugue.SuspendLayout()
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
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'TBDomicilio
        '
        Me.TBDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.TBDomicilio, "TBDomicilio")
        Me.TBDomicilio.Name = "TBDomicilio"
        '
        'TCRegistro
        '
        Me.TCRegistro.Controls.Add(Me.TabPage1)
        Me.TCRegistro.Controls.Add(Me.TPDatos)
        resources.ApplyResources(Me.TCRegistro, "TCRegistro")
        Me.TCRegistro.Name = "TCRegistro"
        Me.TCRegistro.SelectedIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.LbEstadoCivil)
        Me.TabPage1.Controls.Add(Me.CBEstadoCivil)
        Me.TabPage1.Controls.Add(Me.GBDatosConyugue)
        Me.TabPage1.Controls.Add(Me.DGDocumentos)
        Me.TabPage1.Controls.Add(Me.TBDomicilio)
        Me.TabPage1.Controls.Add(Me.LbNombre)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.LbRFC)
        Me.TabPage1.Controls.Add(Me.LbCURP)
        Me.TabPage1.Controls.Add(Me.LbTelefono)
        Me.TabPage1.Controls.Add(Me.TBIdCliente)
        Me.TabPage1.Controls.Add(Me.LbCorreo)
        Me.TabPage1.Controls.Add(Me.LbIdCliente)
        Me.TabPage1.Controls.Add(Me.TBNombre)
        Me.TabPage1.Controls.Add(Me.CBIdEstado)
        Me.TabPage1.Controls.Add(Me.TBRFC)
        Me.TabPage1.Controls.Add(Me.LbIdEstado)
        Me.TabPage1.Controls.Add(Me.TBCURP)
        Me.TabPage1.Controls.Add(Me.TBTelefono)
        Me.TabPage1.Controls.Add(Me.CBTipoPersona)
        Me.TabPage1.Controls.Add(Me.TBCorreo)
        Me.TabPage1.Controls.Add(Me.LBTipoPersona)
        resources.ApplyResources(Me.TabPage1, "TabPage1")
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
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
        Me.GBDatosConyugue.Controls.Add(Me.TBCURPConyugue)
        Me.GBDatosConyugue.Controls.Add(Me.TBRFCConyugue)
        Me.GBDatosConyugue.Controls.Add(Me.TBCredencialConyugue)
        Me.GBDatosConyugue.Controls.Add(Me.Label4)
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
        'TBCredencialConyugue
        '
        resources.ApplyResources(Me.TBCredencialConyugue, "TBCredencialConyugue")
        Me.TBCredencialConyugue.Name = "TBCredencialConyugue"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
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
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Prerregistro
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TCRegistro)
        Me.Controls.Add(Me.TBFecha)
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
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GBDatosConyugue.ResumeLayout(False)
        Me.GBDatosConyugue.PerformLayout()
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
    Friend WithEvents CBIdEstado As ComboBox
    Friend WithEvents LbIdCliente As Label
    Friend WithEvents TBIdCliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TBDomicilio As TextBox
    Friend WithEvents TCRegistro As TabControl
    Friend WithEvents TabPage1 As TabPage
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
    Friend WithEvents TBCredencialConyugue As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DGAgregados As DataGridView
    Friend WithEvents BtAgregar As Button
    Friend WithEvents Button1 As Button
End Class
