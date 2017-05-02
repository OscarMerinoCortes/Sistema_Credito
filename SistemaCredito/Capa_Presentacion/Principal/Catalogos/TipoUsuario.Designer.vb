<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TipoUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TipoUsuario))
        Me.TbIdTipoUsuario = New System.Windows.Forms.TextBox()
        Me.TbDescripcion = New System.Windows.Forms.TextBox()
        Me.CbIdEstatus = New System.Windows.Forms.ComboBox()
        Me.MSMenu = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LbIdTipoUsuario = New System.Windows.Forms.Label()
        Me.LBDescripcion = New System.Windows.Forms.Label()
        Me.LbIdEstatus = New System.Windows.Forms.Label()
        Me.DGTipoUsuario = New System.Windows.Forms.DataGridView()
        Me.MSMenu.SuspendLayout()
        CType(Me.DGTipoUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TbIdTipoUsuario
        '
        Me.TbIdTipoUsuario.Enabled = False
        Me.TbIdTipoUsuario.Location = New System.Drawing.Point(113, 34)
        Me.TbIdTipoUsuario.Name = "TbIdTipoUsuario"
        Me.TbIdTipoUsuario.Size = New System.Drawing.Size(80, 20)
        Me.TbIdTipoUsuario.TabIndex = 0
        '
        'TbDescripcion
        '
        Me.TbDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbDescripcion.Location = New System.Drawing.Point(113, 60)
        Me.TbDescripcion.Name = "TbDescripcion"
        Me.TbDescripcion.Size = New System.Drawing.Size(152, 20)
        Me.TbDescripcion.TabIndex = 1
        '
        'CbIdEstatus
        '
        Me.CbIdEstatus.FormattingEnabled = True
        Me.CbIdEstatus.Location = New System.Drawing.Point(113, 86)
        Me.CbIdEstatus.Name = "CbIdEstatus"
        Me.CbIdEstatus.Size = New System.Drawing.Size(152, 21)
        Me.CbIdEstatus.TabIndex = 2
        '
        'MSMenu
        '
        Me.MSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MSMenu.Location = New System.Drawing.Point(0, 0)
        Me.MSMenu.Name = "MSMenu"
        Me.MSMenu.Size = New System.Drawing.Size(440, 24)
        Me.MSMenu.TabIndex = 3
        Me.MSMenu.Text = "MenuStrip1"
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
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'LbIdTipoUsuario
        '
        Me.LbIdTipoUsuario.AutoSize = True
        Me.LbIdTipoUsuario.Location = New System.Drawing.Point(14, 34)
        Me.LbIdTipoUsuario.Name = "LbIdTipoUsuario"
        Me.LbIdTipoUsuario.Size = New System.Drawing.Size(18, 13)
        Me.LbIdTipoUsuario.TabIndex = 4
        Me.LbIdTipoUsuario.Text = "ID"
        '
        'LBDescripcion
        '
        Me.LBDescripcion.AutoSize = True
        Me.LBDescripcion.Location = New System.Drawing.Point(14, 60)
        Me.LBDescripcion.Name = "LBDescripcion"
        Me.LBDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.LBDescripcion.TabIndex = 5
        Me.LBDescripcion.Text = "Descripcion"
        '
        'LbIdEstatus
        '
        Me.LbIdEstatus.AutoSize = True
        Me.LbIdEstatus.Location = New System.Drawing.Point(14, 86)
        Me.LbIdEstatus.Name = "LbIdEstatus"
        Me.LbIdEstatus.Size = New System.Drawing.Size(42, 13)
        Me.LbIdEstatus.TabIndex = 6
        Me.LbIdEstatus.Text = "Estatus"
        '
        'DGTipoUsuario
        '
        Me.DGTipoUsuario.AllowUserToAddRows = False
        Me.DGTipoUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTipoUsuario.Location = New System.Drawing.Point(17, 113)
        Me.DGTipoUsuario.Name = "DGTipoUsuario"
        Me.DGTipoUsuario.Size = New System.Drawing.Size(411, 150)
        Me.DGTipoUsuario.TabIndex = 7
        '
        'TipoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 278)
        Me.Controls.Add(Me.DGTipoUsuario)
        Me.Controls.Add(Me.LbIdEstatus)
        Me.Controls.Add(Me.LBDescripcion)
        Me.Controls.Add(Me.LbIdTipoUsuario)
        Me.Controls.Add(Me.CbIdEstatus)
        Me.Controls.Add(Me.TbDescripcion)
        Me.Controls.Add(Me.TbIdTipoUsuario)
        Me.Controls.Add(Me.MSMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MSMenu
        Me.Name = "TipoUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo de Usuario"
        Me.MSMenu.ResumeLayout(False)
        Me.MSMenu.PerformLayout()
        CType(Me.DGTipoUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TbIdTipoUsuario As TextBox
    Friend WithEvents TbDescripcion As TextBox
    Friend WithEvents CbIdEstatus As ComboBox
    Friend WithEvents MSMenu As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LbIdTipoUsuario As Label
    Friend WithEvents LBDescripcion As Label
    Friend WithEvents LbIdEstatus As Label
    Friend WithEvents DGTipoUsuario As DataGridView
End Class
