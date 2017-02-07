<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prerregistro
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MSPreregistro = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PBFoto = New System.Windows.Forms.PictureBox()
        Me.OFDPreregistro = New System.Windows.Forms.OpenFileDialog()
        Me.MSPreregistro.SuspendLayout()
        CType(Me.PBFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbTitle
        '
        Me.LbTitle.AutoSize = True
        Me.LbTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTitle.Location = New System.Drawing.Point(186, 33)
        Me.LbTitle.Name = "LbTitle"
        Me.LbTitle.Size = New System.Drawing.Size(290, 13)
        Me.LbTitle.TabIndex = 0
        Me.LbTitle.Text = "REGISTRO DE PERSONAS FISICAS O MORALES"
        '
        'LbNombre
        '
        Me.LbNombre.AutoSize = True
        Me.LbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNombre.Location = New System.Drawing.Point(27, 194)
        Me.LbNombre.Name = "LbNombre"
        Me.LbNombre.Size = New System.Drawing.Size(187, 13)
        Me.LbNombre.TabIndex = 2
        Me.LbNombre.Text = "Nombre (Persona fisica o moral)"
        '
        'LbRFC
        '
        Me.LbRFC.AutoSize = True
        Me.LbRFC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbRFC.Location = New System.Drawing.Point(27, 220)
        Me.LbRFC.Name = "LbRFC"
        Me.LbRFC.Size = New System.Drawing.Size(31, 13)
        Me.LbRFC.TabIndex = 3
        Me.LbRFC.Text = "RFC"
        '
        'LbCURP
        '
        Me.LbCURP.AutoSize = True
        Me.LbCURP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCURP.Location = New System.Drawing.Point(27, 246)
        Me.LbCURP.Name = "LbCURP"
        Me.LbCURP.Size = New System.Drawing.Size(41, 13)
        Me.LbCURP.TabIndex = 5
        Me.LbCURP.Text = "CURP"
        '
        'LbTelefono
        '
        Me.LbTelefono.AutoSize = True
        Me.LbTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTelefono.Location = New System.Drawing.Point(27, 272)
        Me.LbTelefono.Name = "LbTelefono"
        Me.LbTelefono.Size = New System.Drawing.Size(141, 13)
        Me.LbTelefono.TabIndex = 6
        Me.LbTelefono.Text = "Telefono (Casa/celular)"
        '
        'LbCorreo
        '
        Me.LbCorreo.AutoSize = True
        Me.LbCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCorreo.Location = New System.Drawing.Point(27, 298)
        Me.LbCorreo.Name = "LbCorreo"
        Me.LbCorreo.Size = New System.Drawing.Size(111, 13)
        Me.LbCorreo.TabIndex = 7
        Me.LbCorreo.Text = "Correo electronico"
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(254, 194)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(407, 20)
        Me.TBNombre.TabIndex = 8
        '
        'TBRFC
        '
        Me.TBRFC.Location = New System.Drawing.Point(254, 220)
        Me.TBRFC.Name = "TBRFC"
        Me.TBRFC.Size = New System.Drawing.Size(200, 20)
        Me.TBRFC.TabIndex = 9
        '
        'TBCURP
        '
        Me.TBCURP.Location = New System.Drawing.Point(254, 246)
        Me.TBCURP.Name = "TBCURP"
        Me.TBCURP.Size = New System.Drawing.Size(200, 20)
        Me.TBCURP.TabIndex = 10
        '
        'TBTelefono
        '
        Me.TBTelefono.Location = New System.Drawing.Point(254, 272)
        Me.TBTelefono.Name = "TBTelefono"
        Me.TBTelefono.Size = New System.Drawing.Size(200, 20)
        Me.TBTelefono.TabIndex = 11
        '
        'TBCorreo
        '
        Me.TBCorreo.Location = New System.Drawing.Point(254, 298)
        Me.TBCorreo.Name = "TBCorreo"
        Me.TBCorreo.Size = New System.Drawing.Size(200, 20)
        Me.TBCorreo.TabIndex = 12
        '
        'LbFecha
        '
        Me.LbFecha.AutoSize = True
        Me.LbFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFecha.Location = New System.Drawing.Point(471, 70)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.Size = New System.Drawing.Size(42, 13)
        Me.LbFecha.TabIndex = 13
        Me.LbFecha.Text = "Fecha"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(519, 70)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(142, 20)
        Me.TextBox1.TabIndex = 14
        '
        'MSPreregistro
        '
        Me.MSPreregistro.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MSPreregistro.Location = New System.Drawing.Point(0, 0)
        Me.MSPreregistro.Name = "MSPreregistro"
        Me.MSPreregistro.Size = New System.Drawing.Size(684, 24)
        Me.MSPreregistro.TabIndex = 15
        Me.MSPreregistro.Text = "MenuStrip1"
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
        'PBFoto
        '
        Me.PBFoto.BackgroundImage = CType(resources.GetObject("PBFoto.BackgroundImage"), System.Drawing.Image)
        Me.PBFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBFoto.Location = New System.Drawing.Point(55, 70)
        Me.PBFoto.Name = "PBFoto"
        Me.PBFoto.Size = New System.Drawing.Size(100, 100)
        Me.PBFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBFoto.TabIndex = 1
        Me.PBFoto.TabStop = False
        '
        'OFDPreregistro
        '
        Me.OFDPreregistro.FileName = "OFDPreregistro"
        '
        'Prerregistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 762)
        Me.Controls.Add(Me.TextBox1)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MSPreregistro
        Me.Name = "Prerregistro"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pre Registro"
        Me.MSPreregistro.ResumeLayout(False)
        Me.MSPreregistro.PerformLayout()
        CType(Me.PBFoto, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MSPreregistro As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OFDPreregistro As OpenFileDialog
End Class
