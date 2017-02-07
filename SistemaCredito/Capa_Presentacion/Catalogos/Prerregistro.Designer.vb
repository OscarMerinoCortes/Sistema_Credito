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
        Me.RBAlgodon = New System.Windows.Forms.RadioButton()
        Me.RBMaiz = New System.Windows.Forms.RadioButton()
        Me.RBTrigo = New System.Windows.Forms.RadioButton()
        Me.GBTipoCultivo = New System.Windows.Forms.GroupBox()
        Me.LBTipoPersona = New System.Windows.Forms.Label()
        Me.CBTipoPersona = New System.Windows.Forms.ComboBox()
        Me.PBFoto = New System.Windows.Forms.PictureBox()
        Me.DGDocumentos = New System.Windows.Forms.DataGridView()
        Me.MSPreregistro.SuspendLayout()
        Me.GBTipoCultivo.SuspendLayout()
        CType(Me.PBFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        resources.ApplyResources(Me.TBNombre, "TBNombre")
        Me.TBNombre.Name = "TBNombre"
        '
        'TBRFC
        '
        resources.ApplyResources(Me.TBRFC, "TBRFC")
        Me.TBRFC.Name = "TBRFC"
        '
        'TBCURP
        '
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
        'RBAlgodon
        '
        resources.ApplyResources(Me.RBAlgodon, "RBAlgodon")
        Me.RBAlgodon.Name = "RBAlgodon"
        Me.RBAlgodon.TabStop = True
        Me.RBAlgodon.UseVisualStyleBackColor = True
        '
        'RBMaiz
        '
        resources.ApplyResources(Me.RBMaiz, "RBMaiz")
        Me.RBMaiz.Name = "RBMaiz"
        Me.RBMaiz.TabStop = True
        Me.RBMaiz.UseVisualStyleBackColor = True
        '
        'RBTrigo
        '
        resources.ApplyResources(Me.RBTrigo, "RBTrigo")
        Me.RBTrigo.Name = "RBTrigo"
        Me.RBTrigo.TabStop = True
        Me.RBTrigo.UseVisualStyleBackColor = True
        '
        'GBTipoCultivo
        '
        Me.GBTipoCultivo.Controls.Add(Me.RBAlgodon)
        Me.GBTipoCultivo.Controls.Add(Me.RBTrigo)
        Me.GBTipoCultivo.Controls.Add(Me.RBMaiz)
        resources.ApplyResources(Me.GBTipoCultivo, "GBTipoCultivo")
        Me.GBTipoCultivo.Name = "GBTipoCultivo"
        Me.GBTipoCultivo.TabStop = False
        '
        'LBTipoPersona
        '
        resources.ApplyResources(Me.LBTipoPersona, "LBTipoPersona")
        Me.LBTipoPersona.Name = "LBTipoPersona"
        '
        'CBTipoPersona
        '
        Me.CBTipoPersona.FormattingEnabled = True
        Me.CBTipoPersona.Items.AddRange(New Object() {resources.GetString("CBTipoPersona.Items"), resources.GetString("CBTipoPersona.Items1")})
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
        Me.DGDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.DGDocumentos, "DGDocumentos")
        Me.DGDocumentos.Name = "DGDocumentos"
        '
        'Prerregistro
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DGDocumentos)
        Me.Controls.Add(Me.CBTipoPersona)
        Me.Controls.Add(Me.LBTipoPersona)
        Me.Controls.Add(Me.GBTipoCultivo)
        Me.Controls.Add(Me.TBFecha)
        Me.Controls.Add(Me.LbFecha)
        Me.Controls.Add(Me.TBCorreo)
        Me.Controls.Add(Me.TBTelefono)
        Me.Controls.Add(Me.TBCURP)
        Me.Controls.Add(Me.TBRFC)
        Me.Controls.Add(Me.TBNombre)
        Me.Controls.Add(Me.LbCorreo)
        Me.Controls.Add(Me.LbTelefono)
        Me.Controls.Add(Me.LbCURP)
        Me.Controls.Add(Me.LbRFC)
        Me.Controls.Add(Me.LbNombre)
        Me.Controls.Add(Me.PBFoto)
        Me.Controls.Add(Me.LbTitle)
        Me.Controls.Add(Me.MSPreregistro)
        Me.MainMenuStrip = Me.MSPreregistro
        Me.Name = "Prerregistro"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.MSPreregistro.ResumeLayout(False)
        Me.MSPreregistro.PerformLayout()
        Me.GBTipoCultivo.ResumeLayout(False)
        Me.GBTipoCultivo.PerformLayout()
        CType(Me.PBFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents RBAlgodon As RadioButton
    Friend WithEvents RBMaiz As RadioButton
    Friend WithEvents RBTrigo As RadioButton
    Friend WithEvents GBTipoCultivo As GroupBox
    Friend WithEvents LBTipoPersona As Label
    Friend WithEvents CBTipoPersona As ComboBox
    Friend WithEvents DGDocumentos As DataGridView
End Class
