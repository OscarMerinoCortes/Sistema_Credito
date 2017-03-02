Public Class Menu
    Private Sub PrerregistroToolStripMenuItem_Click(sender As Object, e As EventArgs) 

    End Sub
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
End Class
