Public Class ConsultaPreregistro
    Public TablaClientes As New DataTable
    Private Sub ConsultaPreregistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGConsultaPreregistro.DataSource = Nothing
    End Sub
    Private Sub Consultar()
        Dim EntidadPreregistro As New Capa_Entidad.Preregistro
        Dim NegocioPreregistro As New Capa_Negocio.Preregistro
        EntidadPreregistro.Nombre = TBNombre.Text
        NegocioPreregistro.ConsultarClientes(EntidadPreregistro)
        TablaClientes = EntidadPreregistro.TablaDatosDelCliente
        DGConsultaPreregistro.DataSource = TablaClientes
        FormatoDelDataGridView()
    End Sub

    Private Sub BTNBuscar_Click(sender As Object, e As EventArgs) Handles BTNBuscar.Click
        Consultar()
    End Sub
    Private Sub FormatoDelDataGridView()
        DGConsultaPreregistro.Columns(0).Visible = False
        DGConsultaPreregistro.Columns(3).Visible = False
        DGConsultaPreregistro.Columns(4).Visible = False
        DGConsultaPreregistro.Columns(5).Visible = False
        DGConsultaPreregistro.Columns(9).Visible = False
        DGConsultaPreregistro.Columns(10).Visible = False
        DGConsultaPreregistro.Columns(2).HeaderText = "Tipo de persona"
        DGConsultaPreregistro.Columns(2).Width = 150
        DGConsultaPreregistro.Columns(1).Width = 200
    End Sub
    Private Sub DGConsultaPreregistro_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGConsultaPreregistro.CellDoubleClick
        If DGConsultaPreregistro.RowCount = 0 Then
            MessageBox.Show("No hay datos para seleccionar.")
        ElseIf DGConsultaPreregistro.CurrentRow IsNot Nothing Then
            Dim index As Integer
            index = DGConsultaPreregistro.CurrentRow.Index
            VGIndex = index
            VGTablaDatosDelCliente = TablaClientes
            Close()
        End If
    End Sub
End Class