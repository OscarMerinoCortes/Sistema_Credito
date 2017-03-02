Imports System.IO
Public Class PreregistroLotes
    Public TablaVacia As New DataTable()
    Public TablaDatosyLotes As New DataTable()
    Public TablaDocumentosPropietario As New DataTable()
    Public TablaClientes As New DataTable

    Private Sub PreregistroLotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBFecha.Text = Now.Date.ToString("dd/MM/yyyy")
        LlenarCombos()
        '-------------------------------------------------TABLA VACIA
        TablaVacia.Columns.Clear()
        TablaVacia.Columns.Add(New DataColumn("Lote", Type.GetType("System.String")))
        TablaVacia.Columns.Add(New DataColumn("SuperficieTotal", Type.GetType("System.Double")))
        TablaVacia.Columns.Add(New DataColumn("SuperficieSembrar", Type.GetType("System.Double")))
        TablaVacia.Columns.Add(New DataColumn("SuperficieRestante", Type.GetType("System.Double")))
        TablaVacia.Columns.Add(New DataColumn("Folio_Lote", Type.GetType("System.String")))
        TablaVacia.Columns.Add(New DataColumn("volumen", Type.GetType("System.Double")))
        TablaVacia.Columns.Add(New DataColumn("Latitud_Grados", Type.GetType("System.Double")))
        TablaVacia.Columns.Add(New DataColumn("Latitud_Horas", Type.GetType("System.Double")))
        TablaVacia.Columns.Add(New DataColumn("Latitud_Minutos", Type.GetType("System.Double")))
        TablaVacia.Columns.Add(New DataColumn("Longitud_Grados", Type.GetType("System.Double")))
        TablaVacia.Columns.Add(New DataColumn("Longitud_Horas", Type.GetType("System.Double")))
        TablaVacia.Columns.Add(New DataColumn("Longitud_Minutos", Type.GetType("System.Double")))
        TablaVacia.Columns.Add(New DataColumn("Numero_RPP", Type.GetType("System.Int32")))
        TablaVacia.Columns.Add(New DataColumn("Folio_RPP", Type.GetType("System.Int32")))
        TablaVacia.Columns.Add(New DataColumn("Libro_RPP", Type.GetType("System.Int32")))
        TablaVacia.Columns.Add(New DataColumn("Fecha_RPP", Type.GetType("System.DateTime")))
        TablaVacia.Columns.Add(New DataColumn("Titulo_Agua", Type.GetType("System.String")))
        TablaVacia.Columns.Add(New DataColumn("Regimen_Hidrico", Type.GetType("System.String")))
        TablaVacia.Columns.Add(New DataColumn("Fecha_Titulo_Agua", Type.GetType("System.DateTime")))
        '-------------------------------------------------TABLA DOCUMENTOS
        TablaDocumentosPropietario.Columns.Clear()
        TablaDocumentosPropietario.Columns.Add(New DataColumn("IdPreregistroDetalle", Type.GetType("System.Int32")))
        TablaDocumentosPropietario.Columns.Add(New DataColumn("IdDocumento", Type.GetType("System.Int32")))
        TablaDocumentosPropietario.Columns.Add(New DataColumn("IdEstatus", Type.GetType("System.Boolean")))
        '------------------------------------------
        '-------------------------------------------------TABLA DATOS Y LOTES
        TablaDatosyLotes.Columns.Clear()
        TablaDatosyLotes.Columns.Add(New DataColumn("IdPreregistroLotes", Type.GetType("System.Int32")))
        TablaDatosyLotes.Columns.Add(New DataColumn("Lote", Type.GetType("System.String")))
        TablaDatosyLotes.Columns.Add(New DataColumn("SuperficieTotal", Type.GetType("System.Double")))
        TablaDatosyLotes.Columns.Add(New DataColumn("SuperficieSembrar", Type.GetType("System.Double")))
        TablaDatosyLotes.Columns.Add(New DataColumn("SuperficieRestante", Type.GetType("System.Double")))
        TablaDatosyLotes.Columns.Add(New DataColumn("Folio_Lote", Type.GetType("System.String")))
        TablaDatosyLotes.Columns.Add(New DataColumn("volumen", Type.GetType("System.Double")))
        TablaDatosyLotes.Columns.Add(New DataColumn("Latitud_Grados", Type.GetType("System.Double")))
        TablaDatosyLotes.Columns.Add(New DataColumn("Latitud_Horas", Type.GetType("System.Double")))
        TablaDatosyLotes.Columns.Add(New DataColumn("Latitud_Minutos", Type.GetType("System.Double")))
        TablaDatosyLotes.Columns.Add(New DataColumn("Longitud_Grados", Type.GetType("System.Double")))
        TablaDatosyLotes.Columns.Add(New DataColumn("Longitud_Horas", Type.GetType("System.Double")))
        TablaDatosyLotes.Columns.Add(New DataColumn("Longitud_Minutos", Type.GetType("System.Double")))
        TablaDatosyLotes.Columns.Add(New DataColumn("Numero_RPP", Type.GetType("System.Int32")))
        TablaDatosyLotes.Columns.Add(New DataColumn("Folio_RPP", Type.GetType("System.Int32")))
        TablaDatosyLotes.Columns.Add(New DataColumn("Libro_RPP", Type.GetType("System.Int32")))
        TablaDatosyLotes.Columns.Add(New DataColumn("Fecha_RPP", Type.GetType("System.DateTime")))
        TablaDatosyLotes.Columns.Add(New DataColumn("Titulo_Agua", Type.GetType("System.String")))
        TablaDatosyLotes.Columns.Add(New DataColumn("Regimen_Hidrico", Type.GetType("System.String")))
        TablaDatosyLotes.Columns.Add(New DataColumn("Fecha_Titulo_Agua", Type.GetType("System.DateTime")))
        '------------------------------------------
        ConsultarDocumentosPropietario()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
        ConsultarDocumentosPropietario()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim EntidadPreregistroLotes As New Capa_Entidad.PreregistroLotes
        Dim NegocioPreregistroLotes As New Capa_Negocio.PreregistroLotes
        If CBNombreCliente.SelectedValue Is Nothing Then
            MsgBox("Verifica campos vacios", 0, "Aviso")
            Exit Sub
        End If
        AgregarDocumentosATabla()
        If TBIdPreregistroLotes.Text Is String.Empty Then
            EntidadPreregistroLotes.IdPreregistroLote = 0
        Else
            EntidadPreregistroLotes.IdPreregistroLote = TBIdPreregistroLotes.Text
        End If
        EntidadPreregistroLotes.NombreLote = TBNoLote.Text
        EntidadPreregistroLotes.IdPropietario = CBNombreCliente.SelectedValue
        EntidadPreregistroLotes.IdColonia = CBColonia.SelectedValue
        EntidadPreregistroLotes.FolioLote = TBNoLote.Text
        EntidadPreregistroLotes.SuperficieTotal = NuSupTotal.Value
        EntidadPreregistroLotes.SuperficieSembrar = NuSupCultivable.Value
        EntidadPreregistroLotes.SuperficieRestante = NuSupCultivable.Value
        EntidadPreregistroLotes.volumen = CDbl(TBVolumen.Text)
        EntidadPreregistroLotes.LatitudGrados = TBNGrados.Text
        EntidadPreregistroLotes.LatitudHoras = TBNHoras.Text
        EntidadPreregistroLotes.LatitudMinutos = TBNMinutos.Text
        EntidadPreregistroLotes.LongitudGrados = TBWGrados.Text
        EntidadPreregistroLotes.LongitudHoras = TBWHoras.Text
        EntidadPreregistroLotes.LongitudMinutos = TBWMinutos.Text
        EntidadPreregistroLotes.NumeroRPP = TBNumeroRPP.Text
        EntidadPreregistroLotes.FolioRPP = TBFolioRPP.Text
        EntidadPreregistroLotes.LibroRPP = TBLibroRPP.Text
        EntidadPreregistroLotes.FechaRPP = DTRpp.Value
        EntidadPreregistroLotes.RegimenHidrico = TBRegimen.Text
        EntidadPreregistroLotes.TituloAgua = TBTitulo.Text
        EntidadPreregistroLotes.FechaTituloAgua = DtTitulo.Value
        EntidadPreregistroLotes.IdEstado = CBIdEstado.SelectedValue
        EntidadPreregistroLotes.TablaDocumentosPropietarioGuardar = TablaDocumentosPropietario
        NegocioPreregistroLotes.Guardar(EntidadPreregistroLotes)
        MsgBox("Registro guardado o editado con éxito")
        Limpiar()
        ConsultarDocumentosPropietario()
    End Sub
    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        Dim EntidadPreregistroLotes As New Capa_Entidad.PreregistroLotes
        Dim NegocioPreregistroLotes As New Capa_Negocio.PreregistroLotes
        Dim index As Integer
        Dim tabla As New DataTable
        ConsultaPreregistroLote.ShowDialog()
        index = VGIndex
        tabla = VGTabla
        'If index > 0 Then
        TBIdPreregistroLotes.Text = tabla.Rows(index).Item("IdPreregistroLote")
        CBNombreCliente.SelectedValue = tabla.Rows(index).Item("IdPropietario")
        CBIdEstado.Text = tabla.Rows(index).Item("Estado")
        CBColonia.SelectedValue = tabla.Rows(index).Item("IdColonia")
        NuSupTotal.Value = tabla.Rows(index).Item("SuperficieTotal")
        NuSupCultivable.Value = tabla.Rows(index).Item("SuperficieSembrar")
        TBVolumen.Text = tabla.Rows(index).Item("Volumen")
        TBNGrados.Text = tabla.Rows(index).Item("Latitud_Grados")
        TBNHoras.Text = tabla.Rows(index).Item("Latitud_Horas")
        TBNMinutos.Text = tabla.Rows(index).Item("Latitud_Minutos")
        TBWGrados.Text = tabla.Rows(index).Item("Longitud_Grados")
        TBWHoras.Text = tabla.Rows(index).Item("Longitud_Horas")
        TBWMinutos.Text = tabla.Rows(index).Item("Longitud_Minutos")
        TBNumeroRPP.Text = tabla.Rows(index).Item("Numero_RPP")
        TBFolioRPP.Text = tabla.Rows(index).Item("Folio_RPP")
        TBLibroRPP.Text = tabla.Rows(index).Item("Libro_RPP")
        DTRpp.Value = tabla.Rows(index).Item("Fecha_RPP")
        TBTitulo.Text = tabla.Rows(index).Item("Titulo_Agua")
        TBRegimen.Text = tabla.Rows(index).Item("Regimen_Hidrico")
        DtTitulo.Value = tabla.Rows(index).Item("Fecha_Titulo_Agua")
        TBNoLote.Text = tabla.Rows(index).Item("Nombre_Lote")
        EntidadPreregistroLotes.IdPreregistroLote = TBIdPreregistroLotes.Text
        EntidadPreregistroLotes.ConsultaDocumentosPreregistroLotes = 2
        NegocioPreregistroLotes.Consultar(EntidadPreregistroLotes)
        tabla = EntidadPreregistroLotes.TablaDocumentosPropietario
        DGDocumentosPropietario.DataSource = tabla
        DGDocumentosPropietario.Columns(0).Visible = False
        'End If
    End Sub
    Private Sub BTAbrirCarpeta_Click(sender As Object, e As EventArgs) Handles BTAbrirCarpeta.Click

    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub ConsultarDocumentosPropietario()
        Dim EntidadPreregistroLotes As New Capa_Entidad.PreregistroLotes
        Dim NegocioPreregistroLotes As New Capa_Negocio.PreregistroLotes
        Dim Tabla As New DataTable
        EntidadPreregistroLotes.ConsultaDocumentosPreregistroLotes = 1
        NegocioPreregistroLotes.Consultar(EntidadPreregistroLotes)
        Tabla = EntidadPreregistroLotes.TablaDocumentosPropietario
        DGDocumentosPropietario.DataSource = Tabla
        DGDocumentosPropietario.Columns(0).Visible = False
    End Sub
    Private Sub Limpiar()
        TBIdPreregistroLotes.Text = ""
        TBNoLote.Text = ""
        CBNombreCliente.Text = ""
        CBNombreCliente.SelectedIndex = -1
        TxCurp.Text = ""
        TxRfc.Text = ""
        CBColonia.Text = ""
        CBColonia.SelectedIndex = -1
        CBIdEstado.Text = ""
        CBIdEstado.SelectedIndex = -1
        NuSupCultivable.Value = 0
        NuSupTotal.Value = 0
        TBVolumen.Text = ""
        TBNGrados.Text = ""
        TBNHoras.Text = ""
        TBNMinutos.Text = ""
        TBWGrados.Text = ""
        TBWMinutos.Text = ""
        TBWHoras.Text = ""
        TBNumeroRPP.Text = ""
        TBFolioRPP.Text = ""
        TBLibroRPP.Text = ""
        TBRegimen.Text = ""
        TBTitulo.Text = ""
        DTRpp.Value = Today
        DtTitulo.Value = Today
        DGDocumentosPropietario.DataSource = Nothing
    End Sub
    Private Sub AgregarDocumentosATabla()
        'Dim rengloninsertar As DataRow
        'TablaDocumentosPropietario.Clear()
        'For Contador = 0 To DGDocumentosPropietario.RowCount - 1
        '    rengloninsertar = TablaDocumentosPropietario.NewRow()
        '    rengloninsertar("IdPreregistroDetalle") = DGDocumentosPropietario.Rows(Contador).Cells("IdPreregistroDetalle").Value
        '    rengloninsertar("IdDocumento") = DGDocumentosPropietario.Rows(Contador).Cells("IdDocumento").Value
        '    rengloninsertar("IdEstatus") = DGDocumentosPropietario.Rows(Contador).Cells("Estatus").Value
        '    TablaDocumentosPropietario.Rows.Add(rengloninsertar)
        'Next Contador
        Dim index As Integer
        Dim rengloninsertar As DataRow
        TablaDocumentosPropietario.Clear()
        For Each row As DataGridViewRow In DGDocumentosPropietario.Rows
            index = Convert.ToUInt64(row.Index)
            rengloninsertar = TablaDocumentosPropietario.NewRow()
            rengloninsertar("IdPreregistroDetalle") = DGDocumentosPropietario.Rows(index).Cells("IdPreregistroDetalle").Value
            rengloninsertar("IdDocumento") = DGDocumentosPropietario.Rows(index).Cells("IdDocumento").Value
            rengloninsertar("IdEstatus") = DGDocumentosPropietario.Rows(index).Cells("Estatus").Value
            TablaDocumentosPropietario.Rows.Add(rengloninsertar)
        Next
    End Sub
    Private Sub DGDocumentosPropietario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGDocumentosPropietario.CellContentClick
        Dim i As Integer
        i = DGDocumentosPropietario.CurrentRow.Index
        If DGDocumentosPropietario.Rows(i).Cells("Estatus").Value = False Then
            DGDocumentosPropietario.Rows(i).Cells("Estatus").Value = True
        ElseIf DGDocumentosPropietario.Rows(i).Cells("Estatus").Value = True Then
            DGDocumentosPropietario.Rows(i).Cells("Estatus").Value = False
        End If
    End Sub
    Private Sub LlenarCombos()
        Dim dt As DataTable = New DataTable("Tabla")
        dt.Columns.Add("IdDocumento")
        dt.Columns.Add("Descripcion")
        Dim dr As DataRow
        dr = dt.NewRow()
        dr("IdDocumento") = "2"
        dr("Descripcion") = "INACTIVO"
        dt.Rows.Add(dr)
        dr = dt.NewRow()
        dr("IdDocumento") = "1"
        dr("Descripcion") = "ACTIVO"
        dt.Rows.Add(dr)
        CBIdEstado.DataSource = dt
        CBIdEstado.ValueMember = "IdDocumento"
        CBIdEstado.DisplayMember = "Descripcion"
        CBIdEstado.SelectedIndex = -1
        '------------------------------------------------------------------------------
        Dim dt1 As DataTable = New DataTable("Tabla")
        dt1.Columns.Add("IdColonia")
        dt1.Columns.Add("Nombre")
        Dim dr1 As DataRow
        dr1 = dt1.NewRow()
        dr1("IdColonia") = "2"
        dr1("Nombre") = "NUEVA HOLANDA"
        dt1.Rows.Add(dr1)
        dr1 = dt1.NewRow()
        dr1("IdColonia") = "1"
        dr1("Nombre") = "OASIS"
        dt1.Rows.Add(dr1)
        CBColonia.DataSource = dt1
        CBColonia.ValueMember = "IdColonia"
        CBColonia.DisplayMember = "Nombre"
        CBColonia.SelectedIndex = -1
        '------------------------------------------------------------------------------
        Dim EntidadPreregistro As New Capa_Entidad.Preregistro
        Dim NegocioPreregistro As New Capa_Negocio.Preregistro

        NegocioPreregistro.ConsultarClientes(EntidadPreregistro)
        TablaClientes = EntidadPreregistro.TablaDatosDelCliente
        CBNombreCliente.DataSource = TablaClientes
        CBNombreCliente.DisplayMember = "Nombre"
        CBNombreCliente.ValueMember = "IdCliente"
        CBNombreCliente.SelectedIndex = -1
    End Sub
End Class