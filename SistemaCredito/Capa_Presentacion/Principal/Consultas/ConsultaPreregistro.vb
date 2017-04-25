Public Class ConsultaPreregistro
    Public TablaClientes As New DataTable
    Private Sub ConsultaPreregistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGConsultaPreregistro.DataSource = Nothing
        TBNombre.Text = ""
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
        DGConsultaPreregistro.Columns(1).Visible = False
        DGConsultaPreregistro.Columns(2).Visible = False
        DGConsultaPreregistro.Columns(4).HeaderText = "Segundo Nombre"
        DGConsultaPreregistro.Columns(5).HeaderText = "Apellido Paterno"
        DGConsultaPreregistro.Columns(6).HeaderText = "Apellido Materno"
        DGConsultaPreregistro.Columns(19).HeaderText = "Importe Solicitado"
        DGConsultaPreregistro.Columns(20).HeaderText = "Importe en Letra"
        DGConsultaPreregistro.Columns(22).HeaderText = "Actividad Habitual"
        DGConsultaPreregistro.Columns(7).Visible = False
        DGConsultaPreregistro.Columns(8).Visible = False
        DGConsultaPreregistro.Columns(10).Visible = False
        DGConsultaPreregistro.Columns(11).Visible = False
        DGConsultaPreregistro.Columns(12).Visible = False
        DGConsultaPreregistro.Columns(13).Visible = False
        DGConsultaPreregistro.Columns(14).Visible = False
        DGConsultaPreregistro.Columns(15).Visible = False
        DGConsultaPreregistro.Columns(16).Visible = False
        DGConsultaPreregistro.Columns(17).Visible = False
        DGConsultaPreregistro.Columns(18).Visible = False
        DGConsultaPreregistro.Columns(21).Visible = False
        DGConsultaPreregistro.Columns(23).Visible = False
        DGConsultaPreregistro.Columns(24).Visible = False
        DGConsultaPreregistro.Columns(25).Visible = False
        DGConsultaPreregistro.Columns(26).Visible = False
        DGConsultaPreregistro.Columns(27).Visible = False
        DGConsultaPreregistro.Columns(28).Visible = False
        DGConsultaPreregistro.Columns(29).Visible = False
        DGConsultaPreregistro.Columns(30).Visible = False
        DGConsultaPreregistro.Columns(31).Visible = False
        DGConsultaPreregistro.Columns(32).Visible = False
        DGConsultaPreregistro.Columns(33).Visible = False
        DGConsultaPreregistro.Columns(34).Visible = False
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