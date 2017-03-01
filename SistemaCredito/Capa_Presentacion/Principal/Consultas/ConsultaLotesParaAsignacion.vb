Public Class ConsultaLotesParaAsignacion
    Public TablaPreregistroLote As DataTable
    Private Sub ConsultaLotesParaAsignacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        DGConsultaSeleccionLote.Columns("RFC").Visible = False
        DGConsultaSeleccionLote.Columns("CURP").Visible = False
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

    Private Sub BTNBuscar_Click(sender As Object, e As EventArgs) Handles BTNBuscar.Click
        Consultar()
    End Sub
End Class