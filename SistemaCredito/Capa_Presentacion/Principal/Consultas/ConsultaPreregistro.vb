Public Class ConsultaPreregistro
    Public TablaClientes As New DataTable
    Private Sub ConsultaPreregistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Consultar()
        'DGConsultaPreregistro.DataSource = Nothing
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
    Private Sub FormatoDelDataGridView()
        DGConsultaPreregistro.Columns(2).HeaderText = "Seg. Nombre"
        DGConsultaPreregistro.Columns(3).HeaderText = "Ape. Paterno"
        DGConsultaPreregistro.Columns(4).HeaderText = "Ape. Materno"
        DGConsultaPreregistro.Columns(5).HeaderText = "Fecha de Nac."
        DGConsultaPreregistro.Columns(6).HeaderText = "Importe Solicitado"
        DGConsultaPreregistro.Columns(7).HeaderText = "Importe en Letra"
        DGConsultaPreregistro.Columns(8).HeaderText = "Act. Habitual"
    End Sub
    Private Sub DGConsultaPreregistro_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGConsultaPreregistro.CellDoubleClick
        If DGConsultaPreregistro.RowCount = 0 Then
            MessageBox.Show("No hay datos para seleccionar.")
        ElseIf DGConsultaPreregistro.CurrentRow IsNot Nothing Then
            Dim index As Integer
            Dim IdCliente As Integer
            index = DGConsultaPreregistro.CurrentRow.Index
            IdCliente = TablaClientes.Rows(index).Item("IdCliente")
            VGIdCliente = IdCliente
            Close()
        End If
    End Sub
    Private Sub TBNombre_TextChanged(sender As Object, e As PreviewKeyDownEventArgs) Handles TBNombre.PreviewKeyDown
        Consultar()
    End Sub
End Class