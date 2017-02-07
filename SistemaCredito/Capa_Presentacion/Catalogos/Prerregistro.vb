Public Class Prerregistro
    Private Sub PBFoto_Click(sender As Object, e As EventArgs) Handles PBFoto.Click
        Dim Ruta As String
        OFDPreregistro.ShowDialog()
        Ruta = OFDPreregistro.FileName.ToString
        PBFoto.Image = Image.FromFile(Ruta)
    End Sub
    Private Sub Prerregistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click

    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click

    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
End Class