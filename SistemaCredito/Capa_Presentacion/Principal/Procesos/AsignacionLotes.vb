Public Class AsignacionLotes
    Public TablaCultivos As DataTable
    Public TablaClientes As DataTable
    Private Sub AsignacionLotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenaComboCultivos()
    End Sub
    Private Sub LlenaComboCultivos()
        Dim EntidadPreregistro As New Capa_Entidad.Preregistro
        Dim NegocioPreregistro As New Capa_Negocio.Preregistro
        EntidadPreregistro.ConsultaDocumentos = 3
        NegocioPreregistro.Consultar(EntidadPreregistro)
        TablaCultivos = EntidadPreregistro.TablaDocumentosRegistrados
        CBCultivos.DataSource = TablaCultivos
        CBCultivos.DisplayMember = "Cultivo"
        CBCultivos.ValueMember = "Id"
        '-----------------------------------------------------------------------------------
        NegocioPreregistro.ConsultarClientes(EntidadPreregistro)
        TablaClientes = EntidadPreregistro.TablaDatosDelCliente
        CBClientes.DataSource = TablaClientes
        CBClientes.DisplayMember = "Nombre"
        CBClientes.ValueMember = "IdCliente"

    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
End Class