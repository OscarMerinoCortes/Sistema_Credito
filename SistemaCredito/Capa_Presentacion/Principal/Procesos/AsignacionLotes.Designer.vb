<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AsignacionLotes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AsignacionLotes))
        Me.CBClientes = New System.Windows.Forms.ComboBox()
        Me.DGLotes = New System.Windows.Forms.DataGridView()
        Me.MSDocumentos = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBCultivos = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NUHectareas = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BTSeleccion = New System.Windows.Forms.Button()
        Me.TBFolioLote = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DGLotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MSDocumentos.SuspendLayout()
        CType(Me.NUHectareas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CBClientes
        '
        Me.CBClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CBClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBClientes.FormattingEnabled = True
        Me.CBClientes.Location = New System.Drawing.Point(194, 60)
        Me.CBClientes.Name = "CBClientes"
        Me.CBClientes.Size = New System.Drawing.Size(240, 21)
        Me.CBClientes.TabIndex = 0
        '
        'DGLotes
        '
        Me.DGLotes.AllowUserToAddRows = False
        Me.DGLotes.AllowUserToDeleteRows = False
        Me.DGLotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGLotes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DGLotes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DGLotes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGLotes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DGLotes.Location = New System.Drawing.Point(14, 140)
        Me.DGLotes.MultiSelect = False
        Me.DGLotes.Name = "DGLotes"
        Me.DGLotes.ReadOnly = True
        Me.DGLotes.RowHeadersVisible = False
        Me.DGLotes.RowHeadersWidth = 40
        Me.DGLotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGLotes.Size = New System.Drawing.Size(498, 151)
        Me.DGLotes.TabIndex = 20
        '
        'MSDocumentos
        '
        Me.MSDocumentos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MSDocumentos.Location = New System.Drawing.Point(0, 0)
        Me.MSDocumentos.Name = "MSDocumentos"
        Me.MSDocumentos.Size = New System.Drawing.Size(560, 24)
        Me.MSDocumentos.TabIndex = 21
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
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Cliente"
        '
        'CBCultivos
        '
        Me.CBCultivos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CBCultivos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBCultivos.FormattingEnabled = True
        Me.CBCultivos.Location = New System.Drawing.Point(194, 87)
        Me.CBCultivos.Name = "CBCultivos"
        Me.CBCultivos.Size = New System.Drawing.Size(240, 21)
        Me.CBCultivos.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Cultivo"
        '
        'NUHectareas
        '
        Me.NUHectareas.DecimalPlaces = 3
        Me.NUHectareas.Location = New System.Drawing.Point(194, 114)
        Me.NUHectareas.Maximum = New Decimal(New Integer() {-727379969, 232, 0, 0})
        Me.NUHectareas.Name = "NUHectareas"
        Me.NUHectareas.Size = New System.Drawing.Size(120, 20)
        Me.NUHectareas.TabIndex = 24
        Me.NUHectareas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NUHectareas.ThousandsSeparator = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Hectareas"
        '
        'BTSeleccion
        '
        Me.BTSeleccion.Location = New System.Drawing.Point(517, 140)
        Me.BTSeleccion.Name = "BTSeleccion"
        Me.BTSeleccion.Size = New System.Drawing.Size(31, 23)
        Me.BTSeleccion.TabIndex = 25
        Me.BTSeleccion.Text = "..."
        Me.BTSeleccion.UseVisualStyleBackColor = True
        '
        'TBFolioLote
        '
        Me.TBFolioLote.Location = New System.Drawing.Point(194, 34)
        Me.TBFolioLote.Name = "TBFolioLote"
        Me.TBFolioLote.Size = New System.Drawing.Size(100, 20)
        Me.TBFolioLote.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "ID"
        '
        'AsignacionLotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 313)
        Me.Controls.Add(Me.TBFolioLote)
        Me.Controls.Add(Me.BTSeleccion)
        Me.Controls.Add(Me.NUHectareas)
        Me.Controls.Add(Me.CBCultivos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MSDocumentos)
        Me.Controls.Add(Me.DGLotes)
        Me.Controls.Add(Me.CBClientes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AsignacionLotes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignacion Lotes"
        CType(Me.DGLotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MSDocumentos.ResumeLayout(False)
        Me.MSDocumentos.PerformLayout()
        CType(Me.NUHectareas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CBClientes As ComboBox
    Friend WithEvents DGLotes As DataGridView
    Friend WithEvents MSDocumentos As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents CBCultivos As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NUHectareas As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents BTSeleccion As Button
    Friend WithEvents TBFolioLote As TextBox
    Friend WithEvents Label5 As Label
End Class
