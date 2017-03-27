<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UbicacionDocumentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UbicacionDocumentos))
        Me.TBRuta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GuardarActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TBIdUbicacion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BTUbicacion = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBPersonas = New System.Windows.Forms.TextBox()
        Me.TBNombreRaiz = New System.Windows.Forms.TextBox()
        Me.TBLotes = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TBRutaSolicitud = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BTUbicacionSolicitud = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TBRuta
        '
        Me.TBRuta.Location = New System.Drawing.Point(52, 57)
        Me.TBRuta.Name = "TBRuta"
        Me.TBRuta.Size = New System.Drawing.Size(566, 20)
        Me.TBRuta.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ruta"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarActualizarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(691, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GuardarActualizarToolStripMenuItem
        '
        Me.GuardarActualizarToolStripMenuItem.Name = "GuardarActualizarToolStripMenuItem"
        Me.GuardarActualizarToolStripMenuItem.Size = New System.Drawing.Size(124, 20)
        Me.GuardarActualizarToolStripMenuItem.Text = "Guardar / Actualizar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'TBIdUbicacion
        '
        Me.TBIdUbicacion.Location = New System.Drawing.Point(52, 31)
        Me.TBIdUbicacion.Name = "TBIdUbicacion"
        Me.TBIdUbicacion.Size = New System.Drawing.Size(100, 20)
        Me.TBIdUbicacion.TabIndex = 5
        Me.TBIdUbicacion.Text = "1"
        Me.TBIdUbicacion.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "ID"
        Me.Label5.Visible = False
        '
        'BTUbicacion
        '
        Me.BTUbicacion.BackgroundImage = CType(resources.GetObject("BTUbicacion.BackgroundImage"), System.Drawing.Image)
        Me.BTUbicacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTUbicacion.Location = New System.Drawing.Point(624, 51)
        Me.BTUbicacion.Name = "BTUbicacion"
        Me.BTUbicacion.Size = New System.Drawing.Size(30, 30)
        Me.BTUbicacion.TabIndex = 2
        Me.BTUbicacion.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(293, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre para Carpeta de Documentos de Personas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Nombre para Carpeta Raiz"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(272, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nombre para Carpeta de Documentos de Lotes"
        '
        'TBPersonas
        '
        Me.TBPersonas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBPersonas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBPersonas.Location = New System.Drawing.Point(362, 77)
        Me.TBPersonas.Name = "TBPersonas"
        Me.TBPersonas.Size = New System.Drawing.Size(281, 20)
        Me.TBPersonas.TabIndex = 0
        '
        'TBNombreRaiz
        '
        Me.TBNombreRaiz.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBNombreRaiz.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBNombreRaiz.Location = New System.Drawing.Point(362, 40)
        Me.TBNombreRaiz.Name = "TBNombreRaiz"
        Me.TBNombreRaiz.Size = New System.Drawing.Size(281, 20)
        Me.TBNombreRaiz.TabIndex = 0
        '
        'TBLotes
        '
        Me.TBLotes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBLotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBLotes.Location = New System.Drawing.Point(362, 109)
        Me.TBLotes.Name = "TBLotes"
        Me.TBLotes.Size = New System.Drawing.Size(281, 20)
        Me.TBLotes.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TBLotes)
        Me.GroupBox1.Controls.Add(Me.TBNombreRaiz)
        Me.GroupBox1.Controls.Add(Me.TBPersonas)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 148)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(667, 150)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nombra las carpetas de Documentos"
        '
        'TBRutaSolicitud
        '
        Me.TBRutaSolicitud.Location = New System.Drawing.Point(253, 93)
        Me.TBRutaSolicitud.Name = "TBRutaSolicitud"
        Me.TBRutaSolicitud.Size = New System.Drawing.Size(366, 20)
        Me.TBRutaSolicitud.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(234, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Ruta de Formato de Solicitud de Credito"
        '
        'BTUbicacionSolicitud
        '
        Me.BTUbicacionSolicitud.BackgroundImage = CType(resources.GetObject("BTUbicacionSolicitud.BackgroundImage"), System.Drawing.Image)
        Me.BTUbicacionSolicitud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTUbicacionSolicitud.Location = New System.Drawing.Point(625, 87)
        Me.BTUbicacionSolicitud.Name = "BTUbicacionSolicitud"
        Me.BTUbicacionSolicitud.Size = New System.Drawing.Size(30, 30)
        Me.BTUbicacionSolicitud.TabIndex = 2
        Me.BTUbicacionSolicitud.UseVisualStyleBackColor = True
        '
        'UbicacionDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 310)
        Me.Controls.Add(Me.TBIdUbicacion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTUbicacionSolicitud)
        Me.Controls.Add(Me.BTUbicacion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBRutaSolicitud)
        Me.Controls.Add(Me.TBRuta)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "UbicacionDocumentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ubicacion de Documentos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBRuta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BTUbicacion As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GuardarActualizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TBIdUbicacion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TBPersonas As TextBox
    Friend WithEvents TBNombreRaiz As TextBox
    Friend WithEvents TBLotes As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TBRutaSolicitud As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BTUbicacionSolicitud As Button
End Class
