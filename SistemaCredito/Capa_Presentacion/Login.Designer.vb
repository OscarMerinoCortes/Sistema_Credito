<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.LbUsername = New System.Windows.Forms.Label()
        Me.LbPassword = New System.Windows.Forms.Label()
        Me.TbUsername = New System.Windows.Forms.TextBox()
        Me.TbPassword = New System.Windows.Forms.TextBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.LbMensaje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LbUsername
        '
        Me.LbUsername.AutoSize = True
        Me.LbUsername.Location = New System.Drawing.Point(13, 13)
        Me.LbUsername.Name = "LbUsername"
        Me.LbUsername.Size = New System.Drawing.Size(55, 13)
        Me.LbUsername.TabIndex = 0
        Me.LbUsername.Text = "Username"
        '
        'LbPassword
        '
        Me.LbPassword.AutoSize = True
        Me.LbPassword.Location = New System.Drawing.Point(13, 39)
        Me.LbPassword.Name = "LbPassword"
        Me.LbPassword.Size = New System.Drawing.Size(53, 13)
        Me.LbPassword.TabIndex = 1
        Me.LbPassword.Text = "Password"
        '
        'TbUsername
        '
        Me.TbUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbUsername.Location = New System.Drawing.Point(74, 13)
        Me.TbUsername.Name = "TbUsername"
        Me.TbUsername.Size = New System.Drawing.Size(198, 20)
        Me.TbUsername.TabIndex = 2
        '
        'TbPassword
        '
        Me.TbPassword.Location = New System.Drawing.Point(74, 39)
        Me.TbPassword.Name = "TbPassword"
        Me.TbPassword.Size = New System.Drawing.Size(198, 20)
        Me.TbPassword.TabIndex = 3
        Me.TbPassword.UseSystemPasswordChar = True
        '
        'BtnLogin
        '
        Me.BtnLogin.Location = New System.Drawing.Point(197, 75)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(75, 23)
        Me.BtnLogin.TabIndex = 4
        Me.BtnLogin.Text = "LOGIN"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'LbMensaje
        '
        Me.LbMensaje.AutoSize = True
        Me.LbMensaje.Location = New System.Drawing.Point(13, 75)
        Me.LbMensaje.Name = "LbMensaje"
        Me.LbMensaje.Size = New System.Drawing.Size(171, 13)
        Me.LbMensaje.TabIndex = 5
        Me.LbMensaje.Text = "*Contraseña y/o usuario incorrecto"
        Me.LbMensaje.Visible = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 111)
        Me.Controls.Add(Me.LbMensaje)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.TbPassword)
        Me.Controls.Add(Me.TbUsername)
        Me.Controls.Add(Me.LbPassword)
        Me.Controls.Add(Me.LbUsername)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbUsername As Label
    Friend WithEvents LbPassword As Label
    Friend WithEvents TbUsername As TextBox
    Friend WithEvents TbPassword As TextBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents LbMensaje As Label
End Class
