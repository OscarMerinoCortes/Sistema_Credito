<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaLotesParaAsignacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaLotesParaAsignacion))
        Me.DGConsultaSeleccionLote = New System.Windows.Forms.DataGridView()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.LbNombre = New System.Windows.Forms.Label()
        Me.BTCancelar = New System.Windows.Forms.Button()
        Me.BTSeleccionar = New System.Windows.Forms.Button()
        CType(Me.DGConsultaSeleccionLote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGConsultaSeleccionLote
        '
        Me.DGConsultaSeleccionLote.AllowUserToAddRows = False
        Me.DGConsultaSeleccionLote.AllowUserToDeleteRows = False
        Me.DGConsultaSeleccionLote.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGConsultaSeleccionLote.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DGConsultaSeleccionLote.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGConsultaSeleccionLote.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGConsultaSeleccionLote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGConsultaSeleccionLote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DGConsultaSeleccionLote.Location = New System.Drawing.Point(12, 38)
        Me.DGConsultaSeleccionLote.Name = "DGConsultaSeleccionLote"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGConsultaSeleccionLote.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGConsultaSeleccionLote.RowHeadersVisible = False
        Me.DGConsultaSeleccionLote.RowHeadersWidth = 40
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGConsultaSeleccionLote.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGConsultaSeleccionLote.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGConsultaSeleccionLote.Size = New System.Drawing.Size(610, 308)
        Me.DGConsultaSeleccionLote.TabIndex = 15
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(62, 9)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(560, 20)
        Me.TBNombre.TabIndex = 13
        '
        'LbNombre
        '
        Me.LbNombre.AutoSize = True
        Me.LbNombre.Location = New System.Drawing.Point(12, 9)
        Me.LbNombre.Name = "LbNombre"
        Me.LbNombre.Size = New System.Drawing.Size(44, 13)
        Me.LbNombre.TabIndex = 12
        Me.LbNombre.Text = "Nombre"
        '
        'BTCancelar
        '
        Me.BTCancelar.Location = New System.Drawing.Point(430, 352)
        Me.BTCancelar.Name = "BTCancelar"
        Me.BTCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BTCancelar.TabIndex = 16
        Me.BTCancelar.Text = "Cancelar"
        Me.BTCancelar.UseVisualStyleBackColor = True
        '
        'BTSeleccionar
        '
        Me.BTSeleccionar.Location = New System.Drawing.Point(547, 353)
        Me.BTSeleccionar.Name = "BTSeleccionar"
        Me.BTSeleccionar.Size = New System.Drawing.Size(75, 23)
        Me.BTSeleccionar.TabIndex = 16
        Me.BTSeleccionar.Text = "Seleccionar"
        Me.BTSeleccionar.UseVisualStyleBackColor = True
        '
        'ConsultaLotesParaAsignacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 387)
        Me.Controls.Add(Me.BTSeleccionar)
        Me.Controls.Add(Me.BTCancelar)
        Me.Controls.Add(Me.DGConsultaSeleccionLote)
        Me.Controls.Add(Me.TBNombre)
        Me.Controls.Add(Me.LbNombre)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ConsultaLotesParaAsignacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta"
        CType(Me.DGConsultaSeleccionLote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGConsultaSeleccionLote As DataGridView
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents LbNombre As Label
    Friend WithEvents BTCancelar As Button
    Friend WithEvents BTSeleccionar As Button
End Class
