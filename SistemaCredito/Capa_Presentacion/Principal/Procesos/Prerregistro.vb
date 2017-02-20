﻿Imports System.IO
Public Class Prerregistro
    Public TipoPersona As String
    Public TablaDocumentosObtenidos As New DataTable()
    Public TablaConsulta As New DataTable()
    Public EntidadPreregistro As New Capa_Entidad.Preregistro
    Public NegocioPreregistro As New Capa_Negocio.Preregistro
    Private Sub Prerregistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBFecha.Text = Now
        OFDPreregistro.Filter = "Todos(*.Jpg, *.Png, *.Gif, *.Tiff, *.Jpeg, *.Bmp)|*.Jpg; *.Png; *.Gif; *.Tiff; *.Jpeg; *.Bmp"
        CargarComboBoxs()
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
        Limpiar()
        ConsultarDocumentos()
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
        If TBIdCliente.Text Is String.Empty Then
            EntidadPreregistro.IdCliente = 0
        Else
            EntidadPreregistro.IdCliente = TBIdCliente.Text
        End If
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
        MsgBox("Registro guardado o editado con éxito")
        'CargarComboBoxs()
        Limpiar()
        ConsultarDocumentos()
    End Sub
    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        Dim index As Integer
        Dim foto As Byte()
        Dim tabla As New DataTable
        ConsultaPreregistro.ShowDialog()
        index = VGIndex
        TablaConsulta = VGTablaDatosDelCliente
        TBIdCliente.Text = TablaConsulta.Rows(index).Item("IdCliente")
        TBNombre.Text = TablaConsulta.Rows(index).Item("Nombre")
        CBTipoPersona.Text = TablaConsulta.Rows(index).Item("TipoPersona")
        foto = CType(TablaConsulta.Rows(index).Item("Foto"), Byte())
        Dim MSFoto As New MemoryStream(foto)
        PBFoto.Image = Image.FromStream(MSFoto)
        TBRFC.Text = TablaConsulta.Rows(index).Item("RFC")
        TBCURP.Text = TablaConsulta.Rows(index).Item("CURP")
        TBTelefono.Text = TablaConsulta.Rows(index).Item("Telefono")
        TBCorreo.Text = TablaConsulta.Rows(index).Item("Correo")
        CBIdEstado.Text = TablaConsulta.Rows(index).Item("Estado")
        If TablaConsulta.Rows(index).Item("IdTipoCultivo") = 1 Then
            RBAlgodon.Checked = True
        ElseIf TablaConsulta.Rows(index).Item("IdTipoCultivo") = 2 Then
            RBMaiz.Checked = True
        ElseIf TablaConsulta.Rows(index).Item("IdTipoCultivo") = 3 Then
            RBTrigo.Checked = True
        End If
        EntidadPreregistro.IdCliente = TablaConsulta.Rows(index).Item("IdCliente")
        EntidadPreregistro.ConsultaDocumentos = 2
        NegocioPreregistro.Consultar(EntidadPreregistro)
        tabla = EntidadPreregistro.TablaDocumentosRegistrados
        'DGDocumentos.DataSource = Nothing
        DGDocumentos.DataSource = tabla
        DGDocumentos.Columns(0).Visible = False
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
        EntidadPreregistro.ConsultaDocumentos = 1
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
    Private Sub Limpiar()
        TBNombre.Text = ""
        TBRFC.Text = ""
        TBCURP.Text = ""
        TBTelefono.Text = ""
        TBCorreo.Text = ""
        RBAlgodon.Checked = True
        '--Limpiar el picturebox
        PBFoto.Image = Nothing
    End Sub
    Private Sub CargarComboBoxs()
        CBTipoPersona.SelectedText = "FISICA"
        CBIdEstado.SelectedText = "ACTIVO"
    End Sub
End Class