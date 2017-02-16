<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PreregistroLotes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PreregistroLotes))
        Me.LbTitle = New System.Windows.Forms.Label()
        Me.MSPreregistroLotes = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OFDPreregistroLotes = New System.Windows.Forms.OpenFileDialog()
        Me.LbNombre = New System.Windows.Forms.Label()
        Me.LbRFC = New System.Windows.Forms.Label()
        Me.LbCURP = New System.Windows.Forms.Label()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.TBRFC = New System.Windows.Forms.TextBox()
        Me.TBCURP = New System.Windows.Forms.TextBox()
        Me.LbIdCliente = New System.Windows.Forms.Label()
        Me.TBIdPreregistroLotes = New System.Windows.Forms.TextBox()
        Me.LbFecha = New System.Windows.Forms.Label()
        Me.TBFecha = New System.Windows.Forms.TextBox()
        Me.DGRegistroLotes = New System.Windows.Forms.DataGridView()
        Me.DGDocumentosPropietario = New System.Windows.Forms.DataGridView()
        Me.MSPreregistroLotes.SuspendLayout()
        CType(Me.DGRegistroLotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGDocumentosPropietario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbTitle
        '
        Me.LbTitle.AutoSize = True
        Me.LbTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LbTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbTitle.Location = New System.Drawing.Point(252, 24)
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
        Me.MSPreregistroLotes.Size = New System.Drawing.Size(684, 24)
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
        Me.LbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LbNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbNombre.Location = New System.Drawing.Point(12, 96)
        Me.LbNombre.Name = "LbNombre"
        Me.LbNombre.Size = New System.Drawing.Size(135, 13)
        Me.LbNombre.TabIndex = 3
        Me.LbNombre.Text = "Nombre del propietario"
        '
        'LbRFC
        '
        Me.LbRFC.AutoSize = True
        Me.LbRFC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LbRFC.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbRFC.Location = New System.Drawing.Point(12, 122)
        Me.LbRFC.Name = "LbRFC"
        Me.LbRFC.Size = New System.Drawing.Size(31, 13)
        Me.LbRFC.TabIndex = 4
        Me.LbRFC.Text = "RFC"
        '
        'LbCURP
        '
        Me.LbCURP.AutoSize = True
        Me.LbCURP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LbCURP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbCURP.Location = New System.Drawing.Point(12, 148)
        Me.LbCURP.Name = "LbCURP"
        Me.LbCURP.Size = New System.Drawing.Size(41, 13)
        Me.LbCURP.TabIndex = 6
        Me.LbCURP.Text = "CURP"
        '
        'TBNombre
        '
        Me.TBNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBNombre.Location = New System.Drawing.Point(216, 96)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(407, 20)
        Me.TBNombre.TabIndex = 9
        '
        'TBRFC
        '
        Me.TBRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBRFC.Location = New System.Drawing.Point(216, 122)
        Me.TBRFC.Name = "TBRFC"
        Me.TBRFC.Size = New System.Drawing.Size(200, 20)
        Me.TBRFC.TabIndex = 10
        '
        'TBCURP
        '
        Me.TBCURP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBCURP.Location = New System.Drawing.Point(216, 148)
        Me.TBCURP.Name = "TBCURP"
        Me.TBCURP.Size = New System.Drawing.Size(200, 20)
        Me.TBCURP.TabIndex = 11
        '
        'LbIdCliente
        '
        Me.LbIdCliente.AutoSize = True
        Me.LbIdCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LbIdCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbIdCliente.Location = New System.Drawing.Point(12, 70)
        Me.LbIdCliente.Name = "LbIdCliente"
        Me.LbIdCliente.Size = New System.Drawing.Size(20, 13)
        Me.LbIdCliente.TabIndex = 26
        Me.LbIdCliente.Text = "ID"
        Me.LbIdCliente.Visible = False
        '
        'TBIdPreregistroLotes
        '
        Me.TBIdPreregistroLotes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBIdPreregistroLotes.Location = New System.Drawing.Point(216, 70)
        Me.TBIdPreregistroLotes.Name = "TBIdPreregistroLotes"
        Me.TBIdPreregistroLotes.Size = New System.Drawing.Size(121, 20)
        Me.TBIdPreregistroLotes.TabIndex = 27
        Me.TBIdPreregistroLotes.Visible = False
        '
        'LbFecha
        '
        Me.LbFecha.AutoSize = True
        Me.LbFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LbFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbFecha.Location = New System.Drawing.Point(528, 40)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.Size = New System.Drawing.Size(42, 13)
        Me.LbFecha.TabIndex = 28
        Me.LbFecha.Text = "Fecha"
        '
        'TBFecha
        '
        Me.TBFecha.Enabled = False
        Me.TBFecha.Location = New System.Drawing.Point(576, 40)
        Me.TBFecha.Name = "TBFecha"
        Me.TBFecha.Size = New System.Drawing.Size(96, 20)
        Me.TBFecha.TabIndex = 29
        '
        'DGRegistroLotes
        '
        Me.DGRegistroLotes.AllowUserToAddRows = False
        Me.DGRegistroLotes.AllowUserToDeleteRows = False
        Me.DGRegistroLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGRegistroLotes.Location = New System.Drawing.Point(15, 185)
        Me.DGRegistroLotes.Name = "DGRegistroLotes"
        Me.DGRegistroLotes.Size = New System.Drawing.Size(657, 150)
        Me.DGRegistroLotes.TabIndex = 30
        '
        'DGDocumentosPropietario
        '
        Me.DGDocumentosPropietario.AllowUserToAddRows = False
        Me.DGDocumentosPropietario.AllowUserToDeleteRows = False
        Me.DGDocumentosPropietario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGDocumentosPropietario.Location = New System.Drawing.Point(15, 354)
        Me.DGDocumentosPropietario.MultiSelect = False
        Me.DGDocumentosPropietario.Name = "DGDocumentosPropietario"
        Me.DGDocumentosPropietario.Size = New System.Drawing.Size(345, 258)
        Me.DGDocumentosPropietario.TabIndex = 31
        '
        'PreregistroLotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 762)
        Me.Controls.Add(Me.DGDocumentosPropietario)
        Me.Controls.Add(Me.DGRegistroLotes)
        Me.Controls.Add(Me.TBFecha)
        Me.Controls.Add(Me.LbFecha)
        Me.Controls.Add(Me.TBIdPreregistroLotes)
        Me.Controls.Add(Me.LbIdCliente)
        Me.Controls.Add(Me.TBCURP)
        Me.Controls.Add(Me.TBRFC)
        Me.Controls.Add(Me.TBNombre)
        Me.Controls.Add(Me.LbCURP)
        Me.Controls.Add(Me.LbRFC)
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
        CType(Me.DGRegistroLotes, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents LbRFC As Label
    Friend WithEvents LbCURP As Label
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents TBRFC As TextBox
    Friend WithEvents TBCURP As TextBox
    Friend WithEvents LbIdCliente As Label
    Friend WithEvents TBIdPreregistroLotes As TextBox
    Friend WithEvents LbFecha As Label
    Friend WithEvents TBFecha As TextBox
    Friend WithEvents DGRegistroLotes As DataGridView
    Friend WithEvents Lote As DataGridViewTextBoxColumn
    Friend WithEvents Colonia As DataGridViewTextBoxColumn
    Friend WithEvents SuperficieTotal As DataGridViewTextBoxColumn
    Friend WithEvents SuperficieSembrar As DataGridViewTextBoxColumn
    Friend WithEvents SuperficieRestante As DataGridViewTextBoxColumn
    Friend WithEvents FolioAserca As DataGridViewTextBoxColumn
    Friend WithEvents Predio As DataGridViewTextBoxColumn
    Friend WithEvents DGDocumentosPropietario As DataGridView
End Class
