Public Class PreregistroLotes
    Public TablaVacia As New DataTable()
    Public TablaDatosyLotes As New DataTable()
    Public TablaDocumentosPropietario As New DataTable()
    Private Sub PreregistroLotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBFecha.Text = Now.Date.ToString("dd/MM/yyyy")
        '-------------------------------------------------TABLA VACIA
        TablaVacia.Columns.Clear()
        TablaVacia.Columns.Add(New DataColumn("Lote", Type.GetType("System.String")))
        TablaVacia.Columns.Add(New DataColumn("Colonia", Type.GetType("System.String")))
        TablaVacia.Columns.Add(New DataColumn("SuperficieTotal", Type.GetType("System.Double")))
        TablaVacia.Columns.Add(New DataColumn("SuperficieSembrar", Type.GetType("System.Double")))
        TablaVacia.Columns.Add(New DataColumn("SuperficieRestante", Type.GetType("System.Double")))
        TablaVacia.Columns.Add(New DataColumn("FolioAserca", Type.GetType("System.String")))
        TablaVacia.Columns.Add(New DataColumn("Predio", Type.GetType("System.String")))
        '-------------------------------------------------TABLA DOCUMENTOS
        TablaDocumentosPropietario.Columns.Clear()
        TablaDocumentosPropietario.Columns.Add(New DataColumn("IdPreregistroDetalle", Type.GetType("System.Int32")))
        TablaDocumentosPropietario.Columns.Add(New DataColumn("IdDocumento", Type.GetType("System.Int32")))
        TablaDocumentosPropietario.Columns.Add(New DataColumn("IdEstatus", Type.GetType("System.Boolean")))
        '------------------------------------------
        '-------------------------------------------------TABLA DATOS Y LOTES
        TablaDatosyLotes.Columns.Clear()
        TablaDatosyLotes.Columns.Add(New DataColumn("IdPreregistroLotes", Type.GetType("System.Int32")))
        TablaDatosyLotes.Columns.Add(New DataColumn("Fecha", Type.GetType("System.DateTime")))
        TablaDatosyLotes.Columns.Add(New DataColumn("Nombre", Type.GetType("System.String")))
        TablaDatosyLotes.Columns.Add(New DataColumn("RFC", Type.GetType("System.String")))
        TablaDatosyLotes.Columns.Add(New DataColumn("CURP", Type.GetType("System.String")))
        TablaDatosyLotes.Columns.Add(New DataColumn("Lote", Type.GetType("System.String")))
        TablaDatosyLotes.Columns.Add(New DataColumn("Colonia", Type.GetType("System.String")))
        TablaDatosyLotes.Columns.Add(New DataColumn("SuperficieTotal", Type.GetType("System.Double")))
        TablaDatosyLotes.Columns.Add(New DataColumn("SuperficieSembrar", Type.GetType("System.Double")))
        TablaDatosyLotes.Columns.Add(New DataColumn("SuperficieRestante", Type.GetType("System.Double")))
        TablaDatosyLotes.Columns.Add(New DataColumn("FolioAserca", Type.GetType("System.String")))
        TablaDatosyLotes.Columns.Add(New DataColumn("Predio", Type.GetType("System.String")))
        '------------------------------------------
        AgregarColumnaVacia()
        FormatoDGRegistroLotes()
        ConsultarDocumentosPropietario()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
        AgregarColumnaVacia()
        FormatoDGRegistroLotes()
        ConsultarDocumentosPropietario()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim EntidadPreregistroLotes As New Capa_Entidad.PreregistroLotes
        Dim NegocioPreregistroLotes As New Capa_Negocio.PreregistroLotes
        If TBNombre.Text = "" Or TBRFC.Text = "" Or TBCURP.Text = "" Then
            MsgBox("Verifica campos vacios", 0, "Aviso")
            Exit Sub
        End If
        AgregarDocumentosATabla()
        If TBIdPreregistroLotes.Text Is String.Empty Then
            EntidadPreregistroLotes.IdPreregistroLotes = 0
        Else
            EntidadPreregistroLotes.IdPreregistroLotes = TBIdPreregistroLotes.Text
        End If
        EntidadPreregistroLotes.Fecha = TBFecha.Text
        EntidadPreregistroLotes.Nombre = TBNombre.Text
        EntidadPreregistroLotes.RFC = TBRFC.Text
        EntidadPreregistroLotes.CURP = TBCURP.Text
        EntidadPreregistroLotes.Lote = DGRegistroLotes.Rows(0).Cells("Lote").Value
        EntidadPreregistroLotes.Lote = DGRegistroLotes.Rows(0).Cells("Colonia").Value
        EntidadPreregistroLotes.Lote = DGRegistroLotes.Rows(0).Cells("SuperficieTotal").Value
        EntidadPreregistroLotes.Lote = DGRegistroLotes.Rows(0).Cells("SuperficieSembrar").Value
        EntidadPreregistroLotes.Lote = DGRegistroLotes.Rows(0).Cells("SuperficieRestante").Value
        EntidadPreregistroLotes.Lote = DGRegistroLotes.Rows(0).Cells("FolioAserca").Value
        EntidadPreregistroLotes.Lote = DGRegistroLotes.Rows(0).Cells("Predio").Value
        NegocioPreregistroLotes.Guardar(EntidadPreregistroLotes)
        MsgBox("Registro guardado o editado con éxito")
        'CargarComboBoxs()
        Limpiar()
        'ConsultarDocumentos()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub AgregarColumnaVacia()
        Dim rengloninsertar As DataRow
        TablaVacia.Clear()
        rengloninsertar = TablaVacia.NewRow()
        rengloninsertar("Lote") = ""
        rengloninsertar("Colonia") = ""
        rengloninsertar("SuperficieTotal") = 0.00
        rengloninsertar("SuperficieSembrar") = 0.00
        rengloninsertar("SuperficieRestante") = 0.00
        rengloninsertar("FolioAserca") = ""
        rengloninsertar("Predio") = ""
        TablaVacia.Rows.Add(rengloninsertar)
        DGRegistroLotes.DataSource = TablaVacia
    End Sub
    Private Sub FormatoDGRegistroLotes()
        DGRegistroLotes.Columns(2).HeaderText = "Superficie total"
        DGRegistroLotes.Columns(3).HeaderText = "Superficie a sembrar"
        DGRegistroLotes.Columns(4).HeaderText = "Superficie restante"
        DGRegistroLotes.Columns(5).HeaderText = "Folio aserca"
    End Sub
    Private Sub ConsultarDocumentosPropietario()
        Dim EntidadPreregistroLotes As New Capa_Entidad.PreregistroLotes
        Dim NegocioPreregistroLotes As New Capa_Negocio.PreregistroLotes
        Dim Tabla As New DataTable
        'If CBTipoPersona.Text = "FISICA" Then
        '    TipoPersona = "F"
        'Else
        '    TipoPersona = "M"
        'End If
        'EntidadPreregistro.TipoPersona = TipoPersona
        EntidadPreregistroLotes.ConsultaDocumentosPropietario = 1
        NegocioPreregistroLotes.Consultar(EntidadPreregistroLotes)
        Tabla = EntidadPreregistroLotes.TablaDocumentosPropietario
        DGDocumentosPropietario.DataSource = Tabla
        DGDocumentosPropietario.Columns(0).Visible = False
    End Sub
    Private Sub Limpiar()
        TBNombre.Text = ""
        TBRFC.Text = ""
        TBCURP.Text = ""
        DGRegistroLotes.DataSource = Nothing
        DGDocumentosPropietario.DataSource = Nothing
    End Sub
    Private Sub AgregarDocumentosATabla()
        Dim rengloninsertar As DataRow
        TablaDocumentosPropietario.Clear()
        For Contador = 0 To DGDocumentosPropietario.RowCount - 1
            rengloninsertar = TablaDocumentosPropietario.NewRow()
            rengloninsertar("IdPreregistroDetalle") = DGDocumentosPropietario.Rows(Contador).Cells("IdPreregistroDetalle").Value
            rengloninsertar("IdDocumento") = DGDocumentosPropietario.Rows(Contador).Cells("IdDocumento").Value
            rengloninsertar("IdEstatus") = DGDocumentosPropietario.Rows(Contador).Cells("Estatus").Value
            TablaDocumentosPropietario.Rows.Add(rengloninsertar)
        Next Contador
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
End Class