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
End Class
