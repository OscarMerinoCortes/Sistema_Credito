<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contrato
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Contrato))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.L = New System.Windows.Forms.Label()
        Me.TBNomRS = New System.Windows.Forms.TextBox()
        Me.TBDomicilio = New System.Windows.Forms.TextBox()
        Me.PanelContrato = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CBDivisa = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TBCantidad = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.PBFoto = New System.Windows.Forms.PictureBox()
        Me.TBIdCliente = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TBRepresentanteL = New System.Windows.Forms.TextBox()
        Me.LbRepresentanteL = New System.Windows.Forms.Label()
        Me.CBTipoPersona = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        Me.PanelContrato.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(762, 24)
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
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre o Razón Social:"
        '
        'L
        '
        Me.L.AutoSize = True
        Me.L.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L.Location = New System.Drawing.Point(12, 70)
        Me.L.Name = "L"
        Me.L.Size = New System.Drawing.Size(65, 13)
        Me.L.TabIndex = 3
        Me.L.Text = "Dirección:"
        '
        'TBNomRS
        '
        Me.TBNomRS.Location = New System.Drawing.Point(162, 41)
        Me.TBNomRS.Name = "TBNomRS"
        Me.TBNomRS.Size = New System.Drawing.Size(360, 20)
        Me.TBNomRS.TabIndex = 4
        '
        'TBDomicilio
        '
        Me.TBDomicilio.Location = New System.Drawing.Point(83, 67)
        Me.TBDomicilio.Name = "TBDomicilio"
        Me.TBDomicilio.Size = New System.Drawing.Size(439, 20)
        Me.TBDomicilio.TabIndex = 6
        '
        'PanelContrato
        '
        Me.PanelContrato.Controls.Add(Me.Button1)
        Me.PanelContrato.Controls.Add(Me.RichTextBox1)
        Me.PanelContrato.Controls.Add(Me.ComboBox1)
        Me.PanelContrato.Controls.Add(Me.CBDivisa)
        Me.PanelContrato.Controls.Add(Me.DataGridView1)
        Me.PanelContrato.Controls.Add(Me.TBCantidad)
        Me.PanelContrato.Controls.Add(Me.TextBox4)
        Me.PanelContrato.Controls.Add(Me.DateTimePicker2)
        Me.PanelContrato.Controls.Add(Me.Label10)
        Me.PanelContrato.Controls.Add(Me.Label9)
        Me.PanelContrato.Controls.Add(Me.Label8)
        Me.PanelContrato.Controls.Add(Me.Label7)
        Me.PanelContrato.Controls.Add(Me.Label6)
        Me.PanelContrato.Controls.Add(Me.Label5)
        Me.PanelContrato.Controls.Add(Me.Label4)
        Me.PanelContrato.Controls.Add(Me.DateTimePicker1)
        Me.PanelContrato.Location = New System.Drawing.Point(12, 139)
        Me.PanelContrato.Name = "PanelContrato"
        Me.PanelContrato.Size = New System.Drawing.Size(740, 396)
        Me.PanelContrato.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(662, 166)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 23)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(145, 105)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(365, 20)
        Me.RichTextBox1.TabIndex = 27
        Me.RichTextBox1.Text = ""
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ALGODON", "MAIZ", "TRIGO"})
        Me.ComboBox1.Location = New System.Drawing.Point(145, 134)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 24
        '
        'CBDivisa
        '
        Me.CBDivisa.FormattingEnabled = True
        Me.CBDivisa.Items.AddRange(New Object() {"MXN", "USD"})
        Me.CBDivisa.Location = New System.Drawing.Point(579, 66)
        Me.CBDivisa.Name = "CBDivisa"
        Me.CBDivisa.Size = New System.Drawing.Size(121, 21)
        Me.CBDivisa.TabIndex = 23
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 195)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(690, 165)
        Me.DataGridView1.TabIndex = 14
        '
        'TBCantidad
        '
        Me.TBCantidad.Location = New System.Drawing.Point(145, 75)
        Me.TBCantidad.Name = "TBCantidad"
        Me.TBCantidad.Size = New System.Drawing.Size(133, 20)
        Me.TBCantidad.TabIndex = 11
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(592, 102)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 9
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(579, 30)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker2.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(517, 105)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Hectareas:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(94, 137)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Cultivo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(45, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Cantidad Letra:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(517, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Moneda:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(83, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Cantidad:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(476, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Fecha de Pago:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Fecha Inico de Contrato:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(199, 29)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'PBFoto
        '
        Me.PBFoto.BackgroundImage = CType(resources.GetObject("PBFoto.BackgroundImage"), System.Drawing.Image)
        Me.PBFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBFoto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PBFoto.Location = New System.Drawing.Point(604, 33)
        Me.PBFoto.Name = "PBFoto"
        Me.PBFoto.Size = New System.Drawing.Size(100, 100)
        Me.PBFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBFoto.TabIndex = 8
        Me.PBFoto.TabStop = False
        '
        'TBIdCliente
        '
        Me.TBIdCliente.Location = New System.Drawing.Point(37, 21)
        Me.TBIdCliente.Name = "TBIdCliente"
        Me.TBIdCliente.Size = New System.Drawing.Size(100, 20)
        Me.TBIdCliente.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(20, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "ID"
        '
        'TBRepresentanteL
        '
        Me.TBRepresentanteL.Location = New System.Drawing.Point(162, 98)
        Me.TBRepresentanteL.Name = "TBRepresentanteL"
        Me.TBRepresentanteL.Size = New System.Drawing.Size(360, 20)
        Me.TBRepresentanteL.TabIndex = 15
        Me.TBRepresentanteL.Visible = False
        '
        'LbRepresentanteL
        '
        Me.LbRepresentanteL.AutoSize = True
        Me.LbRepresentanteL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbRepresentanteL.Location = New System.Drawing.Point(12, 101)
        Me.LbRepresentanteL.Name = "LbRepresentanteL"
        Me.LbRepresentanteL.Size = New System.Drawing.Size(136, 13)
        Me.LbRepresentanteL.TabIndex = 14
        Me.LbRepresentanteL.Text = "Reprensentante Legal:"
        Me.LbRepresentanteL.Visible = False
        '
        'CBTipoPersona
        '
        Me.CBTipoPersona.FormattingEnabled = True
        Me.CBTipoPersona.Items.AddRange(New Object() {"FISICA", "MORAL"})
        Me.CBTipoPersona.Location = New System.Drawing.Point(401, 12)
        Me.CBTipoPersona.Name = "CBTipoPersona"
        Me.CBTipoPersona.Size = New System.Drawing.Size(121, 21)
        Me.CBTipoPersona.TabIndex = 22
        '
        'Contrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 540)
        Me.Controls.Add(Me.CBTipoPersona)
        Me.Controls.Add(Me.TBRepresentanteL)
        Me.Controls.Add(Me.LbRepresentanteL)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TBIdCliente)
        Me.Controls.Add(Me.PBFoto)
        Me.Controls.Add(Me.PanelContrato)
        Me.Controls.Add(Me.TBDomicilio)
        Me.Controls.Add(Me.TBNomRS)
        Me.Controls.Add(Me.L)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Contrato"
        Me.Text = "Contrato"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanelContrato.ResumeLayout(False)
        Me.PanelContrato.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents L As Label
    Friend WithEvents TBNomRS As TextBox
    Friend WithEvents TBDomicilio As TextBox
    Friend WithEvents PanelContrato As Panel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TBCantidad As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PBFoto As PictureBox
    Friend WithEvents TBIdCliente As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TBRepresentanteL As TextBox
    Friend WithEvents LbRepresentanteL As Label
    Friend WithEvents CBTipoPersona As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents CBDivisa As ComboBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button1 As Button
End Class
