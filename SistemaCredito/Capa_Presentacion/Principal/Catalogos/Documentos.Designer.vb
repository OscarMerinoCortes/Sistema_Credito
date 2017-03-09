<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Documentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Documentos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBNombreDocumento = New System.Windows.Forms.TextBox()
        Me.CBTipoPersona = New System.Windows.Forms.ComboBox()
        Me.MSDocumentos = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBEstatusDocumento = New System.Windows.Forms.ComboBox()
        Me.TBIdDocumento = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DGDocumentos = New System.Windows.Forms.DataGridView()
        Me.MSDocumentos.SuspendLayout()
        CType(Me.DGDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre del Documento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tipo Persona"
        '
        'TBNombreDocumento
        '
        Me.TBNombreDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBNombreDocumento.Location = New System.Drawing.Point(174, 66)
        Me.TBNombreDocumento.Name = "TBNombreDocumento"
        Me.TBNombreDocumento.Size = New System.Drawing.Size(209, 20)
        Me.TBNombreDocumento.TabIndex = 1
        '
        'CBTipoPersona
        '
        Me.CBTipoPersona.FormattingEnabled = True
        Me.CBTipoPersona.Location = New System.Drawing.Point(174, 91)
        Me.CBTipoPersona.Name = "CBTipoPersona"
        Me.CBTipoPersona.Size = New System.Drawing.Size(136, 21)
        Me.CBTipoPersona.TabIndex = 2
        '
        'MSDocumentos
        '
        Me.MSDocumentos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MSDocumentos.Location = New System.Drawing.Point(0, 0)
        Me.MSDocumentos.Name = "MSDocumentos"
        Me.MSDocumentos.Size = New System.Drawing.Size(445, 24)
        Me.MSDocumentos.TabIndex = 4
        Me.MSDocumentos.Text = "MenuStrip1"
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Estatus"
        '
        'CBEstatusDocumento
        '
        Me.CBEstatusDocumento.FormattingEnabled = True
        Me.CBEstatusDocumento.Location = New System.Drawing.Point(174, 118)
        Me.CBEstatusDocumento.Name = "CBEstatusDocumento"
        Me.CBEstatusDocumento.Size = New System.Drawing.Size(136, 21)
        Me.CBEstatusDocumento.TabIndex = 3
        '
        'TBIdDocumento
        '
        Me.TBIdDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBIdDocumento.Enabled = False
        Me.TBIdDocumento.Location = New System.Drawing.Point(174, 40)
        Me.TBIdDocumento.Name = "TBIdDocumento"
        Me.TBIdDocumento.Size = New System.Drawing.Size(80, 20)
        Me.TBIdDocumento.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ID"
        '
        'DGDocumentos
        '
        Me.DGDocumentos.AllowUserToAddRows = False
        Me.DGDocumentos.AllowUserToDeleteRows = False
        Me.DGDocumentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGDocumentos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DGDocumentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DGDocumentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGDocumentos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DGDocumentos.Location = New System.Drawing.Point(13, 184)
        Me.DGDocumentos.MultiSelect = False
        Me.DGDocumentos.Name = "DGDocumentos"
        Me.DGDocumentos.ReadOnly = True
        Me.DGDocumentos.RowHeadersVisible = False
        Me.DGDocumentos.RowHeadersWidth = 40
        Me.DGDocumentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGDocumentos.Size = New System.Drawing.Size(370, 151)
        Me.DGDocumentos.TabIndex = 18
        '
        'Documentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 360)
        Me.Controls.Add(Me.DGDocumentos)
        Me.Controls.Add(Me.MSDocumentos)
        Me.Controls.Add(Me.CBEstatusDocumento)
        Me.Controls.Add(Me.CBTipoPersona)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TBIdDocumento)
        Me.Controls.Add(Me.TBNombreDocumento)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Documentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de Documentos"
        Me.MSDocumentos.ResumeLayout(False)
        Me.MSDocumentos.PerformLayout()
        CType(Me.DGDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TBNombreDocumento As TextBox
    Friend WithEvents CBTipoPersona As ComboBox
    Friend WithEvents MSDocumentos As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents CBEstatusDocumento As ComboBox
    Friend WithEvents TBIdDocumento As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DGDocumentos As DataGridView
End Class
