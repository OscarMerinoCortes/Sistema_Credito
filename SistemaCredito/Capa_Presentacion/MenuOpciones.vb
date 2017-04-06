Public Class MenuOpciones
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub DocumentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocumentosToolStripMenuItem.Click
        Documentos.Show()
    End Sub

    Private Sub PreregistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreregistroToolStripMenuItem.Click
        Prerregistro.Show()
    End Sub

    Private Sub PreregistroLotesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreregistroLotesToolStripMenuItem.Click
        PreregistroLotes.Show()
    End Sub

    Private Sub AsignacionDeLotesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignacionDeLotesToolStripMenuItem.Click
        AsignacionLotes.Show()
    End Sub

    Private Sub ContratosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContratosToolStripMenuItem.Click
        Contrato.Show()
    End Sub

    Private Sub UbicacionDeDocumentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UbicacionDeDocumentosToolStripMenuItem.Click
        UbicacionDocumentos.Show()
    End Sub

    Private Sub AltaDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaDeUsuariosToolStripMenuItem.Click
        Usuarios.Show()
    End Sub

    Private Sub TipoDeUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeUsuarioToolStripMenuItem.Click
        TipoUsuario.Show()
    End Sub
    Private Sub DatosUsuario()
        Dim Usuario As Object = Login.Usuario
        Dim TipoUsuario1 As Object = Login.Tipo
        Dim Id As Object = Login.IdUser
        SbFecha.Text = Now
        LbUsuario.Text = Usuario
        LbIdUsuario.Text = Id
        Me.LbTipoUsuario1.Text = TipoUsuario1
    End Sub
    Private Sub MenuOpciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatosUsuario()
    End Sub
End Class
