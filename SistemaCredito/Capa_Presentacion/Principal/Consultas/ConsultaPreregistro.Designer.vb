<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaPreregistro
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaPreregistro))
        Me.LbNombre = New System.Windows.Forms.Label()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.DGConsultaPreregistro = New System.Windows.Forms.DataGridView()
        CType(Me.DGConsultaPreregistro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbNombre
        '
        Me.LbNombre.AutoSize = True
        Me.LbNombre.Location = New System.Drawing.Point(13, 13)
        Me.LbNombre.Name = "LbNombre"
        Me.LbNombre.Size = New System.Drawing.Size(44, 13)
        Me.LbNombre.TabIndex = 1
        Me.LbNombre.Text = "Nombre"
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(64, 13)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(558, 20)
        Me.TBNombre.TabIndex = 2
        '
        'DGConsultaPreregistro
        '
        Me.DGConsultaPreregistro.AllowUserToAddRows = False
        Me.DGConsultaPreregistro.AllowUserToDeleteRows = False
        Me.DGConsultaPreregistro.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGConsultaPreregistro.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DGConsultaPreregistro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGConsultaPreregistro.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGConsultaPreregistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGConsultaPreregistro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DGConsultaPreregistro.Location = New System.Drawing.Point(12, 42)
        Me.DGConsultaPreregistro.Name = "DGConsultaPreregistro"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGConsultaPreregistro.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGConsultaPreregistro.RowHeadersVisible = False
        Me.DGConsultaPreregistro.RowHeadersWidth = 40
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGConsultaPreregistro.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGConsultaPreregistro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGConsultaPreregistro.Size = New System.Drawing.Size(610, 308)
        Me.DGConsultaPreregistro.TabIndex = 10
        '
        'ConsultaPreregistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 361)
        Me.Controls.Add(Me.DGConsultaPreregistro)
        Me.Controls.Add(Me.TBNombre)
        Me.Controls.Add(Me.LbNombre)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ConsultaPreregistro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta"
        CType(Me.DGConsultaPreregistro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LbNombre As Label
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents DGConsultaPreregistro As DataGridView
End Class
