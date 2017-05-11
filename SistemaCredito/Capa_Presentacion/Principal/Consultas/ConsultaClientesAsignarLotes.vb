Public Class ConsultaClientesAsignarLotes
    Public TablaLoteAsignado As DataTable
    Private Sub ConsultaClientesAsignarLotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Consultar()
        Dim EntidadPreregistroLote As New Capa_Entidad.PreregistroLotes
        Dim NegocioPreregistroLote As New Capa_Negocio.PreregistroLotes
        EntidadPreregistroLote.NombreLote = TBNombre.Text
        NegocioPreregistroLote.ConsultarPreregistroLotes(EntidadPreregistroLote)
        TablaLoteAsignado = EntidadPreregistroLote.TablaPreregistroLotes
        DGConsultaSeleccionLote.DataSource = TablaLoteAsignado
        PropiedadesDG()
    End Sub
    Private Sub PropiedadesDG()

    End Sub
End Class