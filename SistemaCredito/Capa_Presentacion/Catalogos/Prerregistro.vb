Imports System.Data.SqlClient
Imports System.IO
Public Class Prerregistro
    Public TipoPersona As String
    Public TablaDocumentosObtenidos As New DataTable()
    Private Sub Prerregistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBFecha.Text = Now
        OFDPreregistro.Filter = "Todos(*.Jpg, *.Png, *.Gif, *.Tiff, *.Jpeg, *.Bmp)|*.Jpg; *.Png; *.Gif; *.Tiff; *.Jpeg; *.Bmp"
        CBTipoPersona.SelectedText = "FISICA"
        CBIdEstado.SelectedText = "ACTIVO"
        ConsultarDocumentos()
        '---------------------------------------------
        TablaDocumentosObtenidos.Columns.Clear()
        TablaDocumentosObtenidos.Columns.Add(New DataColumn("IdPreregistroDetalle", Type.GetType("System.Int32")))
        TablaDocumentosObtenidos.Columns.Add(New DataColumn("IdDocumento", Type.GetType("System.Int32")))
        TablaDocumentosObtenidos.Columns.Add(New DataColumn("IdEstatus", Type.GetType("System.Boolean")))
    End Sub
    Private Sub PBFoto_Click(sender As Object, e As EventArgs) Handles PBFoto.Click
        Try
            Dim Ruta As String
            OFDPreregistro.ShowDialog()
            Ruta = OFDPreregistro.FileName.ToString
            PBFoto.Image = Image.FromFile(Ruta)
        Catch ex As Exception
            MessageBox.Show("Inserte una imagen", "Aviso")
        End Try
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        TBNombre.Text = ""
        TBRFC.Text = ""
        TBCURP.Text = ""
        TBTelefono.Text = ""
        TBCorreo.Text = ""
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim EntidadPreregistro As New Capa_Entidad.Preregistro
        Dim NegocioPreregistro As New Capa_Negocio.Preregistro

        Dim arrFilename() As String = Split(Text, "\")
        Array.Reverse(arrFilename)
        Dim ms As New MemoryStream
        PBFoto.Image.Save(ms, PBFoto.Image.RawFormat)
        Dim arrImage() As Byte = ms.GetBuffer

        AgregarDocumentosATabla()
        EntidadPreregistro.Foto = arrImage
        EntidadPreregistro.Fecha = TBFecha.Text
        EntidadPreregistro.Nombre = TBNombre.Text
        EntidadPreregistro.TipoPersona = CBTipoPersona.Text
        EntidadPreregistro.RFC = TBRFC.Text
        EntidadPreregistro.CURP = TBCURP.Text
        EntidadPreregistro.Telefono = TBTelefono.Text
        EntidadPreregistro.Correo = TBCorreo.Text
        If RBAlgodon.Checked = True Then
            EntidadPreregistro.IdTipoCultivo = 1
        ElseIf RBMaiz.Checked = True Then
            EntidadPreregistro.IdTipoCultivo = 2
        ElseIf RBTrigo.Checked = True Then
            EntidadPreregistro.IdTipoCultivo = 3
        End If
        If CBIdEstado.Text = "ACTIVO" Then
            EntidadPreregistro.IdEstado = 1
        Else
            EntidadPreregistro.IdEstado = 2
        End If
        EntidadPreregistro.TablaDocumentosAgregados = TablaDocumentosObtenidos
        NegocioPreregistro.Guardar(EntidadPreregistro)
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
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
        NegocioPreregistro.Consultar(EntidadPreregistro)
        TablaDocumentos2 = EntidadPreregistro.TablaDocumentos
        DGDocumentos.DataSource = TablaDocumentos2
        DGDocumentos.Columns(0).Visible = False
    End Sub
    Private Sub CBTipoPersona_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBTipoPersona.SelectedIndexChanged
        ConsultarDocumentos()
    End Sub
    Private Sub AgregarDocumentosATabla()
        Dim index As Integer
        Dim rengloninsertar As DataRow
        TablaDocumentosObtenidos.Clear()
        For Each row As DataGridViewRow In DGDocumentos.Rows
            index = Convert.ToUInt64(row.Index)
            rengloninsertar = TablaDocumentosObtenidos.NewRow()
            rengloninsertar("IdPreregistroDetalle") = DGDocumentos.Rows(index).Cells("IdPreregistroDetalle").Value
            rengloninsertar("IdDocumento") = DGDocumentos.Rows(index).Cells("IdDocumento").Value
            rengloninsertar("IdEstatus") = DGDocumentos.Rows(index).Cells("Estatus").Value
            TablaDocumentosObtenidos.Rows.Add(rengloninsertar)
        Next
    End Sub
End Class