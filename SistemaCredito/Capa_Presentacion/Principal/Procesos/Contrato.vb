Imports System.IO

Public Class Contrato
    Public TipoPersona As String
    Public TablaDocumentosObtenidos As New DataTable()
    Public TablaConsulta As New DataTable()
    Public EntidadPreregistro As New Capa_Entidad.Preregistro
    Public NegocioPreregistro As New Capa_Negocio.Preregistro
    Private Sub Contrato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GBDatos.Visible = False
    End Sub
    Private Sub TBCantidad_TextChanged(sender As Object, e As PreviewKeyDownEventArgs) Handles TBImporte.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            RTBImporteLetra.Text = Letras(TBImporte.Text)
        End If
        RTBImporteLetra.Text = RTBImporteLetra.Text.ToUpper()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click

    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click

    End Sub
    Private Sub BtBuscar_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        Dim index As Integer
        Dim foto As Byte()
        Dim tabla As New DataTable
        ConsultaPreregistro.ShowDialog()
        index = VGIndex
        If index > 0 Then
            TablaConsulta = VGTablaDatosDelCliente
            TBIdCliente.Text = TablaConsulta.Rows(index).Item("IdCliente")
            TBNombre.Text = TablaConsulta.Rows(index).Item("Nombre")
            CBTipoPersona.Text = TablaConsulta.Rows(index).Item("TipoPersona")
            TBDomicilio.Text = TablaConsulta.Rows(index).Item("Domicilio")
            foto = CType(TablaConsulta.Rows(index).Item("Foto"), Byte())
            Dim MSFoto As New MemoryStream(foto)
            PBFoto.Image = Image.FromStream(MSFoto)
            EntidadPreregistro.IdCliente = TablaConsulta.Rows(index).Item("IdCliente")
            EntidadPreregistro.ConsultaDocumentos = 2
            NegocioPreregistro.Consultar(EntidadPreregistro)
            tabla = EntidadPreregistro.TablaDocumentosRegistrados
            ConsultarDocumentos()
            GBDatos.Visible = True
        End If
    End Sub
    Private Sub ConsultarDocumentos()
        Dim EntidadPreregistro As New Capa_Entidad.Preregistro
        Dim NegocioPreregistro As New Capa_Negocio.Preregistro
        Dim TablaDocumentos2 As New DataTable
        If CBTipoPersona.Text = "FISICA" Then
            TipoPersona = "F"
        Else
            TipoPersona = "M"
        End If
        EntidadPreregistro.TipoPersona = TipoPersona
        EntidadPreregistro.ConsultaDocumentos = 1
        NegocioPreregistro.Consultar(EntidadPreregistro)
    End Sub
End Class