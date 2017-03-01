Imports System.IO

Public Class Contrato

    Public TipoPersona As String
    Public TablaDocumentosObtenidos As New DataTable()
    Public TablaConsulta As New DataTable()
    Public EntidadPreregistro As New Capa_Entidad.Preregistro
    Public NegocioPreregistro As New Capa_Negocio.Preregistro
    Private Sub Contrato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelContrato.Visible = False
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
            TBNomRS.Text = TablaConsulta.Rows(index).Item("Nombre")
            CBTipoPersona.Text = TablaConsulta.Rows(index).Item("TipoPersona")
            TBRepresentanteL.Text = TablaConsulta.Rows(index).Item("RepresentanteLegal")
            TBDomicilio.Text = TablaConsulta.Rows(index).Item("Domicilio")
            foto = CType(TablaConsulta.Rows(index).Item("Foto"), Byte())
            Dim MSFoto As New MemoryStream(foto)
            PBFoto.Image = Image.FromStream(MSFoto)
            'TBRepreLe.Text = TablaConsulta.Rows(index).Item("RepresentanteLegal")
            'TBDomicilio.Text = TablaConsulta.Rows(index).Item("Domicilio")

            'If TablaConsulta.Rows(index).Item("IdTipoCultivo") = 1 Then
            '    RBAlgodon.Checked = True
            'ElseIf TablaConsulta.Rows(index).Item("IdTipoCultivo") = 2 Then
            '    RBMaiz.Checked = True
            'ElseIf TablaConsulta.Rows(index).Item("IdTipoCultivo") = 3 Then
            '    RBTrigo.Checked = True
            'End If
            EntidadPreregistro.IdCliente = TablaConsulta.Rows(index).Item("IdCliente")
            EntidadPreregistro.ConsultaDocumentos = 2
            NegocioPreregistro.Consultar(EntidadPreregistro)
            tabla = EntidadPreregistro.TablaDocumentosRegistrados
            'DGDocumentos.DataSource = Nothing
            ConsultarDocumentos()
            PanelContrato.Visible = True

        End If

    End Sub
    Private Sub ConsultarDocumentos()
        Dim EntidadPreregistro As New Capa_Entidad.Preregistro
        Dim NegocioPreregistro As New Capa_Negocio.Preregistro
        Dim TablaDocumentos2 As New DataTable
        If CBTipoPersona.Text = "FISICA" Then
            TipoPersona = "F"
            LbRepresentanteL.Visible = False
            TBRepresentanteL.Visible = False
        Else
            TipoPersona = "M"
            LbRepresentanteL.Visible = True
            TBRepresentanteL.Visible = True
        End If
        EntidadPreregistro.TipoPersona = TipoPersona
        EntidadPreregistro.ConsultaDocumentos = 1
        NegocioPreregistro.Consultar(EntidadPreregistro)


    End Sub

    Private Sub TBCantidad_TextChanged(sender As Object, e As PreviewKeyDownEventArgs) Handles TBCantidad.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            RichTextBox1.Text = Letras(TBCantidad.Text)

        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
End Class