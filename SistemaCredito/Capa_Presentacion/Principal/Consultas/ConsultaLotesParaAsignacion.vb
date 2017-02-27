Public Class ConsultaLotesParaAsignacion
    Public TablaPreregistroLote As DataTable
    Private Sub ConsultaLotesParaAsignacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PropiedadesDG()
    End Sub
    Private Sub PropiedadesDG()
        Dim colidentrada As New DataGridViewTextBoxColumn
        colidentrada.Name = "IdInventario"
        colidentrada.Visible = False
        DGConsultaSeleccionLote.Columns.Insert(0, colidentrada)
    End Sub
    Private Sub Consultar()
        Dim EntidadPreregistroLote As New Capa_Entidad.PreregistroLotes
        Dim NegocioPreregistroLote As New Capa_Negocio.PreregistroLotes
        EntidadPreregistroLote.Nombre = TBNombre.Text
        NegocioPreregistroLote.ConsultarPreregistroLotes(EntidadPreregistroLote)
        TablaPreregistroLote = EntidadPreregistroLote.TablaPreregistroLotes
        DGConsultaSeleccionLote.DataSource = TablaPreregistroLote
        PropiedadesDG()
    End Sub
End Class