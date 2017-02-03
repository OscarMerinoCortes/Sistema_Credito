<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBIdCliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBSocio = New System.Windows.Forms.TextBox()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.CBTipoPersona = New System.Windows.Forms.ComboBox()
        Me.TCTipoPersona = New System.Windows.Forms.TabControl()
        Me.TPPersonaFisica = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TBRFC = New System.Windows.Forms.TextBox()
        Me.CBEstado = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TBCelular = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TBColonia = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TBCurp = New System.Windows.Forms.TextBox()
        Me.TBCalle = New System.Windows.Forms.TextBox()
        Me.TBApoderado = New System.Windows.Forms.TextBox()
        Me.TBNumero = New System.Windows.Forms.TextBox()
        Me.TBTelefono = New System.Windows.Forms.TextBox()
        Me.TBCorreoElectronico = New System.Windows.Forms.TextBox()
        Me.TPPersonaMoral = New System.Windows.Forms.TabPage()
        Me.PaApoderado = New System.Windows.Forms.Panel()
        Me.PaActaConstitutiva = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.TCTipoPersona.SuspendLayout()
        Me.TPPersonaFisica.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TPPersonaMoral.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(984, 24)
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
        Me.Label1.Location = New System.Drawing.Point(16, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID"
        '
        'TBIdCliente
        '
        Me.TBIdCliente.Location = New System.Drawing.Point(133, 37)
        Me.TBIdCliente.Name = "TBIdCliente"
        Me.TBIdCliente.Size = New System.Drawing.Size(121, 20)
        Me.TBIdCliente.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Socio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "TIpo de persona"
        '
        'TBSocio
        '
        Me.TBSocio.Location = New System.Drawing.Point(133, 63)
        Me.TBSocio.Name = "TBSocio"
        Me.TBSocio.Size = New System.Drawing.Size(121, 20)
        Me.TBSocio.TabIndex = 6
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(133, 89)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(200, 20)
        Me.TBNombre.TabIndex = 7
        '
        'CBTipoPersona
        '
        Me.CBTipoPersona.FormattingEnabled = True
        Me.CBTipoPersona.Location = New System.Drawing.Point(133, 116)
        Me.CBTipoPersona.Name = "CBTipoPersona"
        Me.CBTipoPersona.Size = New System.Drawing.Size(121, 21)
        Me.CBTipoPersona.TabIndex = 8
        '
        'TCTipoPersona
        '
        Me.TCTipoPersona.Controls.Add(Me.TPPersonaFisica)
        Me.TCTipoPersona.Controls.Add(Me.TPPersonaMoral)
        Me.TCTipoPersona.Location = New System.Drawing.Point(19, 163)
        Me.TCTipoPersona.Name = "TCTipoPersona"
        Me.TCTipoPersona.SelectedIndex = 0
        Me.TCTipoPersona.Size = New System.Drawing.Size(953, 279)
        Me.TCTipoPersona.TabIndex = 9
        '
        'TPPersonaFisica
        '
        Me.TPPersonaFisica.Controls.Add(Me.Panel1)
        Me.TPPersonaFisica.Location = New System.Drawing.Point(4, 22)
        Me.TPPersonaFisica.Name = "TPPersonaFisica"
        Me.TPPersonaFisica.Padding = New System.Windows.Forms.Padding(3)
        Me.TPPersonaFisica.Size = New System.Drawing.Size(945, 253)
        Me.TPPersonaFisica.TabIndex = 0
        Me.TPPersonaFisica.Text = "Persona Fisica"
        Me.TPPersonaFisica.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TBRFC)
        Me.Panel1.Controls.Add(Me.CBEstado)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.TBCelular)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.TBColonia)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.TBCurp)
        Me.Panel1.Controls.Add(Me.TBCalle)
        Me.Panel1.Controls.Add(Me.TBApoderado)
        Me.Panel1.Controls.Add(Me.TBNumero)
        Me.Panel1.Controls.Add(Me.TBTelefono)
        Me.Panel1.Controls.Add(Me.TBCorreoElectronico)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(939, 247)
        Me.Panel1.TabIndex = 10
        '
        'TBRFC
        '
        Me.TBRFC.Location = New System.Drawing.Point(107, 14)
        Me.TBRFC.Name = "TBRFC"
        Me.TBRFC.Size = New System.Drawing.Size(150, 20)
        Me.TBRFC.TabIndex = 8
        '
        'CBEstado
        '
        Me.CBEstado.FormattingEnabled = True
        Me.CBEstado.Location = New System.Drawing.Point(107, 122)
        Me.CBEstado.Name = "CBEstado"
        Me.CBEstado.Size = New System.Drawing.Size(150, 21)
        Me.CBEstado.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 129)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Estado"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 156)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Telefono"
        '
        'TBCelular
        '
        Me.TBCelular.Location = New System.Drawing.Point(304, 149)
        Me.TBCelular.Name = "TBCelular"
        Me.TBCelular.Size = New System.Drawing.Size(120, 20)
        Me.TBCelular.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Numero"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 183)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Correo electronico"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(256, 156)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 13)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Celular"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Calle"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 210)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Apoderado"
        '
        'TBColonia
        '
        Me.TBColonia.Location = New System.Drawing.Point(304, 92)
        Me.TBColonia.Name = "TBColonia"
        Me.TBColonia.Size = New System.Drawing.Size(120, 20)
        Me.TBColonia.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Curp"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "RFC"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(256, 95)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Colonia"
        '
        'TBCurp
        '
        Me.TBCurp.Location = New System.Drawing.Point(107, 41)
        Me.TBCurp.Name = "TBCurp"
        Me.TBCurp.Size = New System.Drawing.Size(150, 20)
        Me.TBCurp.TabIndex = 9
        '
        'TBCalle
        '
        Me.TBCalle.Location = New System.Drawing.Point(107, 68)
        Me.TBCalle.Name = "TBCalle"
        Me.TBCalle.Size = New System.Drawing.Size(150, 20)
        Me.TBCalle.TabIndex = 10
        '
        'TBApoderado
        '
        Me.TBApoderado.Location = New System.Drawing.Point(107, 203)
        Me.TBApoderado.Name = "TBApoderado"
        Me.TBApoderado.Size = New System.Drawing.Size(150, 20)
        Me.TBApoderado.TabIndex = 15
        '
        'TBNumero
        '
        Me.TBNumero.Location = New System.Drawing.Point(107, 95)
        Me.TBNumero.Name = "TBNumero"
        Me.TBNumero.Size = New System.Drawing.Size(130, 20)
        Me.TBNumero.TabIndex = 11
        '
        'TBTelefono
        '
        Me.TBTelefono.Location = New System.Drawing.Point(107, 149)
        Me.TBTelefono.Name = "TBTelefono"
        Me.TBTelefono.Size = New System.Drawing.Size(130, 20)
        Me.TBTelefono.TabIndex = 13
        '
        'TBCorreoElectronico
        '
        Me.TBCorreoElectronico.Location = New System.Drawing.Point(107, 176)
        Me.TBCorreoElectronico.Name = "TBCorreoElectronico"
        Me.TBCorreoElectronico.Size = New System.Drawing.Size(150, 20)
        Me.TBCorreoElectronico.TabIndex = 14
        '
        'TPPersonaMoral
        '
        Me.TPPersonaMoral.Controls.Add(Me.PaApoderado)
        Me.TPPersonaMoral.Controls.Add(Me.PaActaConstitutiva)
        Me.TPPersonaMoral.Location = New System.Drawing.Point(4, 22)
        Me.TPPersonaMoral.Name = "TPPersonaMoral"
        Me.TPPersonaMoral.Padding = New System.Windows.Forms.Padding(3)
        Me.TPPersonaMoral.Size = New System.Drawing.Size(945, 253)
        Me.TPPersonaMoral.TabIndex = 1
        Me.TPPersonaMoral.Text = "Persona Moral"
        Me.TPPersonaMoral.UseVisualStyleBackColor = True
        '
        'PaApoderado
        '
        Me.PaApoderado.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.PaApoderado.Cursor = System.Windows.Forms.Cursors.SizeNESW
        Me.PaApoderado.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.PaApoderado.Location = New System.Drawing.Point(487, 6)
        Me.PaApoderado.Name = "PaApoderado"
        Me.PaApoderado.Size = New System.Drawing.Size(452, 241)
        Me.PaApoderado.TabIndex = 1
        '
        'PaActaConstitutiva
        '
        Me.PaActaConstitutiva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PaActaConstitutiva.Location = New System.Drawing.Point(6, 6)
        Me.PaActaConstitutiva.Name = "PaActaConstitutiva"
        Me.PaActaConstitutiva.Size = New System.Drawing.Size(467, 241)
        Me.PaActaConstitutiva.TabIndex = 0
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 812)
        Me.ControlBox = False
        Me.Controls.Add(Me.TCTipoPersona)
        Me.Controls.Add(Me.CBTipoPersona)
        Me.Controls.Add(Me.TBNombre)
        Me.Controls.Add(Me.TBSocio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBIdCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TCTipoPersona.ResumeLayout(False)
        Me.TPPersonaFisica.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TPPersonaMoral.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents TBIdCliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TBSocio As TextBox
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents CBTipoPersona As ComboBox
    Friend WithEvents TCTipoPersona As TabControl
    Friend WithEvents TPPersonaFisica As TabPage
    Friend WithEvents CBEstado As ComboBox
    Friend WithEvents TBCelular As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TBColonia As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TBApoderado As TextBox
    Friend WithEvents TBCorreoElectronico As TextBox
    Friend WithEvents TBTelefono As TextBox
    Friend WithEvents TBNumero As TextBox
    Friend WithEvents TBCalle As TextBox
    Friend WithEvents TBCurp As TextBox
    Friend WithEvents TBRFC As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TPPersonaMoral As TabPage
    Friend WithEvents PaApoderado As Panel
    Friend WithEvents PaActaConstitutiva As Panel
    Friend WithEvents Panel1 As Panel
End Class
