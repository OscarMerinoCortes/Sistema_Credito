Public Class ConsultaLotesParaAsignacion
    Public TablaPreregistroLote As DataTable
    Private Sub ConsultaLotesParaAsignacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Consultar()
    End Sub
    Private Sub PropiedadesDG()
        If DGConsultaSeleccionLote.Columns("ChCol") Is Nothing Then
            Dim checkBoxColumn As New DataGridViewCheckBoxColumn()
            checkBoxColumn.HeaderText = ""
            checkBoxColumn.Width = 40
            checkBoxColumn.Name = "ChCol"
            DGConsultaSeleccionLote.Columns.Insert(0, checkBoxColumn)
        End If
        DGConsultaSeleccionLote.Columns("idPreregistroLote").Visible = False
        DGConsultaSeleccionLote.Columns("IdPropietario").Visible = False
        DGConsultaSeleccionLote.Columns("Nombre").Visible = False
        DGConsultaSeleccionLote.Columns("RFC").Visible = False
        DGConsultaSeleccionLote.Columns("SuperficieTotal").Visible = False
        DGConsultaSeleccionLote.Columns("SuperficieSembrar").Visible = False
        DGConsultaSeleccionLote.Columns("SuperficieRestante").Visible = True
        DGConsultaSeleccionLote.Columns("Volumen").Visible = False
        DGConsultaSeleccionLote.Columns("Latitud_Grados").Visible = False
        DGConsultaSeleccionLote.Columns("Latitud_Horas").Visible = False
        DGConsultaSeleccionLote.Columns("Latitud_Minutos").Visible = False
        DGConsultaSeleccionLote.Columns("Longitud_Grados").Visible = False
        DGConsultaSeleccionLote.Columns("Longitud_Horas").Visible = False
        DGConsultaSeleccionLote.Columns("Longitud_Minutos").Visible = False
        DGConsultaSeleccionLote.Columns("Numero_RPP").Visible = False
        DGConsultaSeleccionLote.Columns("Folio_RPP").Visible = False
        DGConsultaSeleccionLote.Columns("Libro_RPP").Visible = False
        DGConsultaSeleccionLote.Columns("Fecha_RPP").Visible = False
        DGConsultaSeleccionLote.Columns("Titulo_Agua").Visible = False
        DGConsultaSeleccionLote.Columns("Regimen_Hidrico").Visible = False
        DGConsultaSeleccionLote.Columns("Fecha_Titulo_Agua").Visible = False
        DGConsultaSeleccionLote.Columns("Estado").Visible = False
        DGConsultaSeleccionLote.Columns("SuperficieRestante").DefaultCellStyle.Format = "###,##0.000"
    End Sub
    Private Sub Consultar()
        Dim EntidadPreregistroLote As New Capa_Entidad.PreregistroLotes
        Dim NegocioPreregistroLote As New Capa_Negocio.PreregistroLotes
        EntidadPreregistroLote.NombreLote = TBNombre.Text
        NegocioPreregistroLote.ConsultarPreregistroLotes(EntidadPreregistroLote)
        TablaPreregistroLote = EntidadPreregistroLote.TablaPreregistroLotes
        DGConsultaSeleccionLote.DataSource = TablaPreregistroLote
        PropiedadesDG()
    End Sub

    Private Sub BTNBuscar_Click(sender As Object, e As EventArgs) Handles TBNombre.PreviewKeyDown
        Consultar()
    End Sub
    ''' <summary>
    ''' Devuelve un objeto DataTable con la estructura de columnas
    ''' existentes en el control DataGridView especificado.
    ''' </summary>
    ''' <param name="dgv">Referencia a un control DataGridView válido.</param>
    ''' 
    Private Function DataGridViewToDataTable(dgv As DataGridView) As DataTable

        If (dgv Is Nothing) Then Return Nothing
        Dim dt As New DataTable()

        For Each col As DataGridViewColumn In dgv.Columns
            Dim column As New DataColumn(col.Name, Type.GetType("System.String"))
            dt.Columns.Add(column)
        Next
        For Each viewRow As DataGridViewRow In dgv.Rows

            Dim row As DataRow = dt.NewRow()

            For Each col As DataGridViewColumn In dgv.Columns


                If dgv.Rows(TabIndex).Cells("chCol").Value = True Then
                    Dim value As Object = viewRow.Cells(col.Name).Value


                    row.Item(col.Name) = If(value Is Nothing, DBNull.Value, value)
                End If
            Next col

            dt.Rows.Add(row)

        Next viewRow
        Return dt

    End Function
    Private Sub BTSeleccionar_Click(sender As Object, e As EventArgs) Handles BTSeleccionar.Click
        Try

            Dim dt As DataTable = Me.DataGridViewToDataTable(Me.DGConsultaSeleccionLote)
            VGTablaSeleccionLotes = dt
            Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Sub BTCancelar_Click(sender As Object, e As EventArgs) Handles BTCancelar.Click
        Close()
    End Sub

End Class