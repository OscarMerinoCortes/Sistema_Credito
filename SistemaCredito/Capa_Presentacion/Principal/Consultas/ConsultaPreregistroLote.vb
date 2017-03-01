Public Class ConsultaPreregistroLote
    Public TablaPreregistroLote As New DataTable
    Private Sub ConsultaPreregistroLote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGConsultaPreregistroLote.DataSource = Nothing
    End Sub
    Private Sub BTNBuscar_Click(sender As Object, e As EventArgs) Handles BTNBuscar.Click
        Consultar()
    End Sub
    Private Sub Consultar()
        Dim EntidadPreregistroLote As New Capa_Entidad.PreregistroLotes
        Dim NegocioPreregistroLote As New Capa_Negocio.PreregistroLotes
        EntidadPreregistroLote.NombreLote = TBNombre.Text
        NegocioPreregistroLote.ConsultarPreregistroLotes(EntidadPreregistroLote)
        TablaPreregistroLote = EntidadPreregistroLote.TablaPreregistroLotes
        DGConsultaPreregistroLote.DataSource = TablaPreregistroLote
        FormatoDelDataGridView()
    End Sub
    Private Sub FormatoDelDataGridView()
        DGConsultaPreregistroLote.Columns(0).Visible = False
        DGConsultaPreregistroLote.Columns(1).HeaderText = "Nombre del propietario"
        DGConsultaPreregistroLote.Columns(6).HeaderText = "Superficie total"
        DGConsultaPreregistroLote.Columns(7).HeaderText = "Superficie a sembrar"
        DGConsultaPreregistroLote.Columns(8).HeaderText = "Superficie restante"
        DGConsultaPreregistroLote.Columns(9).Visible = False
        DGConsultaPreregistroLote.Columns(10).Visible = False
        DGConsultaPreregistroLote.Columns(11).Visible = False
        DGConsultaPreregistroLote.Columns(12).Visible = False
        DGConsultaPreregistroLote.Columns(2).Width = 150
        DGConsultaPreregistroLote.Columns(1).Width = 200
    End Sub

    Private Sub DGConsultaPreregistroLote_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGConsultaPreregistroLote.CellContentClick
        If DGConsultaPreregistroLote.RowCount = 0 Then
            MessageBox.Show("No hay datos para seleccionar.")
        ElseIf DGConsultaPreregistroLote.CurrentRow IsNot Nothing Then
            Dim index As Integer
            index = DGConsultaPreregistroLote.CurrentRow.Index
            VGIndex = index
            VGTabla = TablaPreregistroLote
            Close()
        End If
    End Sub
End Class