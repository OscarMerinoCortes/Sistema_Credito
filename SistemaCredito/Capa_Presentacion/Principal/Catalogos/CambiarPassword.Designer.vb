<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CambiarPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CambiarPassword))
        Me.LbNombreUsuario = New System.Windows.Forms.Label()
        Me.TbUsuario = New System.Windows.Forms.TextBox()
        Me.TbPassActual = New System.Windows.Forms.TextBox()
        Me.TbNuevaPass = New System.Windows.Forms.TextBox()
        Me.TbConfNuevaPass = New System.Windows.Forms.TextBox()
        Me.LbContraseniaActual = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtAceptar = New System.Windows.Forms.Button()
        Me.BtCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LbNombreUsuario
        '
        Me.LbNombreUsuario.AutoSize = True
        Me.LbNombreUsuario.Location = New System.Drawing.Point(12, 16)
        Me.LbNombreUsuario.Name = "LbNombreUsuario"
        Me.LbNombreUsuario.Size = New System.Drawing.Size(43, 13)
        Me.LbNombreUsuario.TabIndex = 0
        Me.LbNombreUsuario.Text = "Usuario"
        '
        'TbUsuario
        '
        Me.TbUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbUsuario.Location = New System.Drawing.Point(161, 16)
        Me.TbUsuario.Name = "TbUsuario"
        Me.TbUsuario.Size = New System.Drawing.Size(138, 20)
        Me.TbUsuario.TabIndex = 1
        '
        'TbPassActual
        '
        Me.TbPassActual.Location = New System.Drawing.Point(161, 42)
        Me.TbPassActual.Name = "TbPassActual"
        Me.TbPassActual.Size = New System.Drawing.Size(138, 20)
        Me.TbPassActual.TabIndex = 2
        Me.TbPassActual.UseSystemPasswordChar = True
        '
        'TbNuevaPass
        '
        Me.TbNuevaPass.Location = New System.Drawing.Point(161, 68)
        Me.TbNuevaPass.Name = "TbNuevaPass"
        Me.TbNuevaPass.Size = New System.Drawing.Size(138, 20)
        Me.TbNuevaPass.TabIndex = 3
        Me.TbNuevaPass.UseSystemPasswordChar = True
        '
        'TbConfNuevaPass
        '
        Me.TbConfNuevaPass.Location = New System.Drawing.Point(161, 94)
        Me.TbConfNuevaPass.Name = "TbConfNuevaPass"
        Me.TbConfNuevaPass.Size = New System.Drawing.Size(138, 20)
        Me.TbConfNuevaPass.TabIndex = 4
        Me.TbConfNuevaPass.UseSystemPasswordChar = True
        '
        'LbContraseniaActual
        '
        Me.LbContraseniaActual.AutoSize = True
        Me.LbContraseniaActual.Location = New System.Drawing.Point(12, 42)
        Me.LbContraseniaActual.Name = "LbContraseniaActual"
        Me.LbContraseniaActual.Size = New System.Drawing.Size(94, 13)
        Me.LbContraseniaActual.TabIndex = 5
        Me.LbContraseniaActual.Text = "Contraseña Actual"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nueva Contraseña"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Confirmar Nueva Contraseña"
        '
        'BtAceptar
        '
        Me.BtAceptar.Location = New System.Drawing.Point(12, 123)
        Me.BtAceptar.Name = "BtAceptar"
        Me.BtAceptar.Size = New System.Drawing.Size(91, 23)
        Me.BtAceptar.TabIndex = 8
        Me.BtAceptar.Text = "Aceptar"
        Me.BtAceptar.UseVisualStyleBackColor = True
        '
        'BtCancelar
        '
        Me.BtCancelar.Location = New System.Drawing.Point(112, 125)
        Me.BtCancelar.Name = "BtCancelar"
        Me.BtCancelar.Size = New System.Drawing.Size(91, 23)
        Me.BtCancelar.TabIndex = 9
        Me.BtCancelar.Text = "Cancelar"
        Me.BtCancelar.UseVisualStyleBackColor = True
        '
        'CambiarPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 158)
        Me.Controls.Add(Me.BtCancelar)
        Me.Controls.Add(Me.BtAceptar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LbContraseniaActual)
        Me.Controls.Add(Me.TbConfNuevaPass)
        Me.Controls.Add(Me.TbNuevaPass)
        Me.Controls.Add(Me.TbPassActual)
        Me.Controls.Add(Me.TbUsuario)
        Me.Controls.Add(Me.LbNombreUsuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CambiarPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambiar Contraseña"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbNombreUsuario As Label
    Friend WithEvents TbUsuario As TextBox
    Friend WithEvents TbPassActual As TextBox
    Friend WithEvents TbNuevaPass As TextBox
    Friend WithEvents TbConfNuevaPass As TextBox
    Friend WithEvents LbContraseniaActual As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtAceptar As Button
    Friend WithEvents BtCancelar As Button
End Class
