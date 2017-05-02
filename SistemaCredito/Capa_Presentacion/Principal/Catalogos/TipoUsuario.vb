Public Class TipoUsuario
    Public Tabla As New DataTable
    Private Sub TipoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarCombos()
        ConsultarListaTipoUsuarios()
        Formato()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim EntidadTipoUsuario As New Capa_Entidad.TipoUsuario
        Dim NegocioTipoUsuario As New Capa_Negocio.TipoUsuario
        EntidadTipoUsuario.IdTipoUsuario = IIf(TbIdTipoUsuario.Text = "", 0, TbIdTipoUsuario.Text)
        EntidadTipoUsuario.Descripcion = TbDescripcion.Text
        EntidadTipoUsuario.IdEstatus = CbIdEstatus.SelectedValue
        NegocioTipoUsuario.Guardar(EntidadTipoUsuario)
        Limpiar()
        ConsultarListaTipoUsuarios()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub Limpiar()
        TbIdTipoUsuario.Text = ""
        TbDescripcion.Text = ""
        CbIdEstatus.SelectedValue = 1
    End Sub
    Private Sub ConsultarListaTipoUsuarios()
        Dim EntidadTipoUsuario As New Capa_Entidad.TipoUsuario
        Dim NegocioTipoUsuario As New Capa_Negocio.TipoUsuario
        EntidadTipoUsuario.IdTipoConsulta = 1
        NegocioTipoUsuario.Consultar(EntidadTipoUsuario)
        Tabla = EntidadTipoUsuario.tabla
        DGTipoUsuario.DataSource = Tabla
        DGTipoUsuario.Columns(0).HeaderText = "ID"
    End Sub
    Private Sub LlenarCombos()
        Dim tabla As DataTable = New DataTable("Tabla")
        tabla.Columns.Add("IdEstatus")
        tabla.Columns.Add("Descripcion")
        Dim row As DataRow
        row = tabla.NewRow()
        row("IdEstatus") = 1
        row("Descripcion") = "ACTIVO"
        tabla.Rows.Add(row)
        row = tabla.NewRow()
        row("IdEstatus") = 2
        row("Descripcion") = "INACTIVO"
        tabla.Rows.Add(row)
        CbIdEstatus.DataSource = tabla
        CbIdEstatus.ValueMember = "IdEstatus"
        CbIdEstatus.DisplayMember = "Descripcion"
        CbIdEstatus.SelectedValue = 1
    End Sub
    Private Sub DGTipoUsuario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGTipoUsuario.CellContentDoubleClick
        Dim index As Integer
        index = DGTipoUsuario.CurrentRow.Index
        If DGTipoUsuario.RowCount <> 0 Then
            TbIdTipoUsuario.Text = Tabla.Rows(index).Item("IdTipoUsuario")
            TbDescripcion.Text = Tabla.Rows(index).Item("Descripcion")
            CbIdEstatus.SelectedValue = Tabla.Rows(index).Item("IdEstatus")
        End If
    End Sub
    Private Sub Formato()
        DGTipoUsuario.Columns(0).HeaderText = "Id"
        DGTipoUsuario.Columns(1).HeaderText = "Descripcion"
        DGTipoUsuario.Columns(1).Width = 270
        DGTipoUsuario.Columns(2).Visible = False
    End Sub
End Class
