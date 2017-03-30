<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuarios))
        Me.TbIdUsuario = New System.Windows.Forms.TextBox()
        Me.LbIdUsuario = New System.Windows.Forms.Label()
        Me.TbNombreUsuario = New System.Windows.Forms.TextBox()
        Me.LbNombre = New System.Windows.Forms.Label()
        Me.TbUsuario = New System.Windows.Forms.TextBox()
        Me.TbPassword = New System.Windows.Forms.TextBox()
        Me.LbUsuario = New System.Windows.Forms.Label()
        Me.LbPassword = New System.Windows.Forms.Label()
        Me.CbTipoUsuario = New System.Windows.Forms.ComboBox()
        Me.LbTipoUsuario = New System.Windows.Forms.Label()
        Me.MSMenu = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DGUsuarios = New System.Windows.Forms.DataGridView()
        Me.LbEstatus = New System.Windows.Forms.Label()
        Me.CbIdEstatus = New System.Windows.Forms.ComboBox()
        Me.MSMenu.SuspendLayout()
        CType(Me.DGUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TbIdUsuario
        '
        Me.TbIdUsuario.Enabled = False
        Me.TbIdUsuario.Location = New System.Drawing.Point(168, 27)
        Me.TbIdUsuario.Name = "TbIdUsuario"
        Me.TbIdUsuario.Size = New System.Drawing.Size(100, 20)
        Me.TbIdUsuario.TabIndex = 0
        '
        'LbIdUsuario
        '
        Me.LbIdUsuario.AutoSize = True
        Me.LbIdUsuario.Location = New System.Drawing.Point(13, 30)
        Me.LbIdUsuario.Name = "LbIdUsuario"
        Me.LbIdUsuario.Size = New System.Drawing.Size(18, 13)
        Me.LbIdUsuario.TabIndex = 1
        Me.LbIdUsuario.Text = "ID"
        '
        'TbNombreUsuario
        '
        Me.TbNombreUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbNombreUsuario.Location = New System.Drawing.Point(168, 53)
        Me.TbNombreUsuario.Name = "TbNombreUsuario"
        Me.TbNombreUsuario.Size = New System.Drawing.Size(319, 20)
        Me.TbNombreUsuario.TabIndex = 2
        '
        'LbNombre
        '
        Me.LbNombre.AutoSize = True
        Me.LbNombre.Location = New System.Drawing.Point(13, 53)
        Me.LbNombre.Name = "LbNombre"
        Me.LbNombre.Size = New System.Drawing.Size(98, 13)
        Me.LbNombre.TabIndex = 3
        Me.LbNombre.Text = "Nombre de Usuario"
        '
        'TbUsuario
        '
        Me.TbUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbUsuario.Location = New System.Drawing.Point(168, 79)
        Me.TbUsuario.Name = "TbUsuario"
        Me.TbUsuario.Size = New System.Drawing.Size(121, 20)
        Me.TbUsuario.TabIndex = 4
        '
        'TbPassword
        '
        Me.TbPassword.Location = New System.Drawing.Point(168, 105)
        Me.TbPassword.Name = "TbPassword"
        Me.TbPassword.Size = New System.Drawing.Size(121, 20)
        Me.TbPassword.TabIndex = 5
        Me.TbPassword.UseSystemPasswordChar = True
        '
        'LbUsuario
        '
        Me.LbUsuario.AutoSize = True
        Me.LbUsuario.Location = New System.Drawing.Point(13, 79)
        Me.LbUsuario.Name = "LbUsuario"
        Me.LbUsuario.Size = New System.Drawing.Size(43, 13)
        Me.LbUsuario.TabIndex = 6
        Me.LbUsuario.Text = "Usuario"
        '
        'LbPassword
        '
        Me.LbPassword.AutoSize = True
        Me.LbPassword.Location = New System.Drawing.Point(13, 105)
        Me.LbPassword.Name = "LbPassword"
        Me.LbPassword.Size = New System.Drawing.Size(61, 13)
        Me.LbPassword.TabIndex = 7
        Me.LbPassword.Text = "Contraseña"
        '
        'CbTipoUsuario
        '
        Me.CbTipoUsuario.FormattingEnabled = True
        Me.CbTipoUsuario.Location = New System.Drawing.Point(168, 131)
        Me.CbTipoUsuario.Name = "CbTipoUsuario"
        Me.CbTipoUsuario.Size = New System.Drawing.Size(121, 21)
        Me.CbTipoUsuario.TabIndex = 8
        '
        'LbTipoUsuario
        '
        Me.LbTipoUsuario.AutoSize = True
        Me.LbTipoUsuario.Location = New System.Drawing.Point(13, 132)
        Me.LbTipoUsuario.Name = "LbTipoUsuario"
        Me.LbTipoUsuario.Size = New System.Drawing.Size(82, 13)
        Me.LbTipoUsuario.TabIndex = 9
        Me.LbTipoUsuario.Text = "Tipo de Usuario"
        '
        'MSMenu
        '
        Me.MSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MSMenu.Location = New System.Drawing.Point(0, 0)
        Me.MSMenu.Name = "MSMenu"
        Me.MSMenu.Size = New System.Drawing.Size(504, 24)
        Me.MSMenu.TabIndex = 10
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
        'DGUsuarios
        '
        Me.DGUsuarios.AllowUserToAddRows = False
        Me.DGUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGUsuarios.Location = New System.Drawing.Point(16, 189)
        Me.DGUsuarios.Name = "DGUsuarios"
        Me.DGUsuarios.Size = New System.Drawing.Size(471, 150)
        Me.DGUsuarios.TabIndex = 11
        '
        'LbEstatus
        '
        Me.LbEstatus.AutoSize = True
        Me.LbEstatus.Location = New System.Drawing.Point(14, 159)
        Me.LbEstatus.Name = "LbEstatus"
        Me.LbEstatus.Size = New System.Drawing.Size(42, 13)
        Me.LbEstatus.TabIndex = 12
        Me.LbEstatus.Text = "Estatus"
        '
        'CbIdEstatus
        '
        Me.CbIdEstatus.FormattingEnabled = True
        Me.CbIdEstatus.Location = New System.Drawing.Point(168, 159)
        Me.CbIdEstatus.Name = "CbIdEstatus"
        Me.CbIdEstatus.Size = New System.Drawing.Size(121, 21)
        Me.CbIdEstatus.TabIndex = 13
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 351)
        Me.Controls.Add(Me.CbIdEstatus)
        Me.Controls.Add(Me.LbEstatus)
        Me.Controls.Add(Me.DGUsuarios)
        Me.Controls.Add(Me.LbTipoUsuario)
        Me.Controls.Add(Me.CbTipoUsuario)
        Me.Controls.Add(Me.LbPassword)
        Me.Controls.Add(Me.LbUsuario)
        Me.Controls.Add(Me.TbPassword)
        Me.Controls.Add(Me.TbUsuario)
        Me.Controls.Add(Me.LbNombre)
        Me.Controls.Add(Me.TbNombreUsuario)
        Me.Controls.Add(Me.LbIdUsuario)
        Me.Controls.Add(Me.TbIdUsuario)
        Me.Controls.Add(Me.MSMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MSMenu
        Me.Name = "Usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de Usuarios"
        Me.MSMenu.ResumeLayout(False)
        Me.MSMenu.PerformLayout()
        CType(Me.DGUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TbIdUsuario As TextBox
    Friend WithEvents LbIdUsuario As Label
    Friend WithEvents TbNombreUsuario As TextBox
    Friend WithEvents LbNombre As Label
    Friend WithEvents TbUsuario As TextBox
    Friend WithEvents TbPassword As TextBox
    Friend WithEvents LbUsuario As Label
    Friend WithEvents LbPassword As Label
    Friend WithEvents CbTipoUsuario As ComboBox
    Friend WithEvents LbTipoUsuario As Label
    Friend WithEvents MSMenu As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DGUsuarios As DataGridView
    Friend WithEvents LbEstatus As Label
    Friend WithEvents CbIdEstatus As ComboBox
End Class
