<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuOpciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuOpciones))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CatálogosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaDeUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcesoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreregistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreregistroLotesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignacionDeLotesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContratosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtileriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UbicacionDeDocumentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.SbIdUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LbIdUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SbTipoUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LbTipoUsuario1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SbUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LbUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TsSeparador = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SbFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatálogosToolStripMenuItem, Me.ProcesoToolStripMenuItem, Me.UtileriasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1578, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CatálogosToolStripMenuItem
        '
        Me.CatálogosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DocumentosToolStripMenuItem, Me.AltaDeUsuariosToolStripMenuItem, Me.TipoDeUsuarioToolStripMenuItem})
        Me.CatálogosToolStripMenuItem.Name = "CatálogosToolStripMenuItem"
        Me.CatálogosToolStripMenuItem.Size = New System.Drawing.Size(75, 21)
        Me.CatálogosToolStripMenuItem.Text = "Catalogos"
        '
        'DocumentosToolStripMenuItem
        '
        Me.DocumentosToolStripMenuItem.Name = "DocumentosToolStripMenuItem"
        Me.DocumentosToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.DocumentosToolStripMenuItem.Text = "Alta de Documentos"
        '
        'AltaDeUsuariosToolStripMenuItem
        '
        Me.AltaDeUsuariosToolStripMenuItem.Name = "AltaDeUsuariosToolStripMenuItem"
        Me.AltaDeUsuariosToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.AltaDeUsuariosToolStripMenuItem.Text = "Alta de Usuarios"
        '
        'TipoDeUsuarioToolStripMenuItem
        '
        Me.TipoDeUsuarioToolStripMenuItem.Name = "TipoDeUsuarioToolStripMenuItem"
        Me.TipoDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.TipoDeUsuarioToolStripMenuItem.Text = "Tipo de Usuario"
        '
        'ProcesoToolStripMenuItem
        '
        Me.ProcesoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreregistroToolStripMenuItem, Me.PreregistroLotesToolStripMenuItem, Me.AsignacionDeLotesToolStripMenuItem, Me.ContratosToolStripMenuItem})
        Me.ProcesoToolStripMenuItem.Name = "ProcesoToolStripMenuItem"
        Me.ProcesoToolStripMenuItem.Size = New System.Drawing.Size(68, 21)
        Me.ProcesoToolStripMenuItem.Text = "Procesos"
        '
        'PreregistroToolStripMenuItem
        '
        Me.PreregistroToolStripMenuItem.Name = "PreregistroToolStripMenuItem"
        Me.PreregistroToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.PreregistroToolStripMenuItem.Text = "Preregistro de Productores"
        '
        'PreregistroLotesToolStripMenuItem
        '
        Me.PreregistroLotesToolStripMenuItem.Name = "PreregistroLotesToolStripMenuItem"
        Me.PreregistroLotesToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.PreregistroLotesToolStripMenuItem.Text = "Preregistro de Lotes"
        '
        'AsignacionDeLotesToolStripMenuItem
        '
        Me.AsignacionDeLotesToolStripMenuItem.Name = "AsignacionDeLotesToolStripMenuItem"
        Me.AsignacionDeLotesToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.AsignacionDeLotesToolStripMenuItem.Text = "Asignacion de Lotes"
        '
        'ContratosToolStripMenuItem
        '
        Me.ContratosToolStripMenuItem.Name = "ContratosToolStripMenuItem"
        Me.ContratosToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.ContratosToolStripMenuItem.Text = "Contratos"
        '
        'UtileriasToolStripMenuItem
        '
        Me.UtileriasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UbicacionDeDocumentosToolStripMenuItem})
        Me.UtileriasToolStripMenuItem.Name = "UtileriasToolStripMenuItem"
        Me.UtileriasToolStripMenuItem.Size = New System.Drawing.Size(65, 21)
        Me.UtileriasToolStripMenuItem.Text = "Utilerias"
        '
        'UbicacionDeDocumentosToolStripMenuItem
        '
        Me.UbicacionDeDocumentosToolStripMenuItem.Image = CType(resources.GetObject("UbicacionDeDocumentosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UbicacionDeDocumentosToolStripMenuItem.Name = "UbicacionDeDocumentosToolStripMenuItem"
        Me.UbicacionDeDocumentosToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.UbicacionDeDocumentosToolStripMenuItem.Text = "Ubicacion de Documentos"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SbIdUsuario, Me.LbIdUsuario, Me.SbTipoUsuario, Me.LbTipoUsuario1, Me.SbUsuario, Me.LbUsuario, Me.TsSeparador, Me.SbFecha})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 769)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1578, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'SbIdUsuario
        '
        Me.SbIdUsuario.Name = "SbIdUsuario"
        Me.SbIdUsuario.Size = New System.Drawing.Size(71, 17)
        Me.SbIdUsuario.Text = "Id Usuario:"
        '
        'LbIdUsuario
        '
        Me.LbIdUsuario.Name = "LbIdUsuario"
        Me.LbIdUsuario.Size = New System.Drawing.Size(40, 17)
        Me.LbIdUsuario.Text = "        "
        '
        'SbTipoUsuario
        '
        Me.SbTipoUsuario.Name = "SbTipoUsuario"
        Me.SbTipoUsuario.Size = New System.Drawing.Size(85, 17)
        Me.SbTipoUsuario.Text = "Tipo Usuario:"
        '
        'LbTipoUsuario1
        '
        Me.LbTipoUsuario1.Name = "LbTipoUsuario1"
        Me.LbTipoUsuario1.Size = New System.Drawing.Size(28, 17)
        Me.LbTipoUsuario1.Text = "     "
        '
        'SbUsuario
        '
        Me.SbUsuario.Name = "SbUsuario"
        Me.SbUsuario.Size = New System.Drawing.Size(60, 17)
        Me.SbUsuario.Text = "Usuario: "
        '
        'LbUsuario
        '
        Me.LbUsuario.Name = "LbUsuario"
        Me.LbUsuario.Size = New System.Drawing.Size(44, 17)
        Me.LbUsuario.Text = "         "
        '
        'TsSeparador
        '
        Me.TsSeparador.Name = "TsSeparador"
        Me.TsSeparador.Size = New System.Drawing.Size(124, 17)
        Me.TsSeparador.Text = "|                           |"
        '
        'SbFecha
        '
        Me.SbFecha.Name = "SbFecha"
        Me.SbFecha.Size = New System.Drawing.Size(43, 17)
        Me.SbFecha.Text = "Fecha"
        '
        'MenuOpciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1578, 791)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuOpciones"
        Me.Text = "Menu Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CatálogosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DocumentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProcesoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PreregistroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PreregistroLotesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsignacionDeLotesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContratosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UtileriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UbicacionDeDocumentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaDeUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TipoDeUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents SbTipoUsuario As ToolStripStatusLabel
    Friend WithEvents SbUsuario As ToolStripStatusLabel
    Friend WithEvents LbUsuario As ToolStripStatusLabel
    Friend WithEvents TsSeparador As ToolStripStatusLabel
    Friend WithEvents SbIdUsuario As ToolStripStatusLabel
    Friend WithEvents SbFecha As ToolStripStatusLabel
    Friend WithEvents LbIdUsuario As ToolStripStatusLabel
    Friend WithEvents LbTipoUsuario1 As ToolStripStatusLabel
End Class
