Public Class Menu
    Private Sub PrerregistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrerregistroToolStripMenuItem.Click
        Prerregistro.Show()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub DocumentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocumentosToolStripMenuItem.Click
        Documentos.Show()
    End Sub
End Class
