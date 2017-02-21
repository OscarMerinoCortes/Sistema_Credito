Public Class AsignacionLotes
    Public TablaCultivos As DataTable
    Private Sub AsignacionLotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenaComboCultivos()
    End Sub
    Private Sub LlenaComboCultivos()
        Dim EntidadAsignacionLotes As New Capa_Entidad.AsignacionLotes
        Dim NegocioAsignacionLotes As New Capa_Negocio.AsignacionLotes

        NegocioAsignacionLotes.LLenaCombo(EntidadAsignacionLotes)
        TablaCultivos = EntidadAsignacionLotes.TablaComboCultivo

        CBCultivos.DataSource = TablaCultivos
        CBCultivos.DisplayMember = "Cultivo"
        CBCultivos.ValueMember = "Id"

    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
End Class