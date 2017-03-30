Public Class Usuarios
    Public Tabla As DataTable
    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarCombos()
        ConsultarUsuarios()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim EntidadUsuario As New Capa_Entidad.Usuario
        Dim NegocioUsuario As New Capa_Negocio.Usuario
        EntidadUsuario.IdUsuario = IIf(TbIdUsuario.Text = "", 0, TbIdUsuario.Text)
        EntidadUsuario.Nombre = TbNombreUsuario.Text
        EntidadUsuario.Usuario = TbUsuario.Text
        EntidadUsuario.Password = TbPassword.Text
        EntidadUsuario.IdTipoUsuario = CbTipoUsuario.SelectedValue
        EntidadUsuario.IdEstatus = CbIdEstatus.SelectedValue
        NegocioUsuario.Guardar(EntidadUsuario)
        Limpiar()
        ConsultarUsuarios()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub
    Private Sub Limpiar()
        TbIdUsuario.Text = ""
        TbNombreUsuario.Text = ""
        TbUsuario.Text = ""
        TbPassword.Text = ""
        CbTipoUsuario.SelectedValue = -1
    End Sub
    Private Sub LlenarCombos()
        '-----Tipo de Usuario-----
        Dim EntidadTipoUsuario As New Capa_Entidad.TipoUsuario
        Dim NegocioTipoUsuario As New Capa_Negocio.TipoUsuario
        EntidadTipoUsuario.IdTipoConsulta = 1
        NegocioTipoUsuario.Consultar(EntidadTipoUsuario)
        CbTipoUsuario.DataSource = EntidadTipoUsuario.tabla
        CbTipoUsuario.DisplayMember = "Descripcion"
        CbTipoUsuario.ValueMember = "IdTipoUsuario"
        CbTipoUsuario.SelectedValue = -1
        '---Estatus-----
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
    Private Sub ConsultarUsuarios()
        Dim EntidadUsuario As New Capa_Entidad.Usuario
        Dim NegocioUsuario As New Capa_Negocio.Usuario
        EntidadUsuario.IdTipoConsulta = 1
        NegocioUsuario.Consultar(EntidadUsuario)
        Tabla = EntidadUsuario.tabla
        DGUsuarios.DataSource = Tabla
        PropiedadesDGUsuarios()
    End Sub

    Private Sub DGUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGUsuarios.CellContentDoubleClick
        Dim index As Integer
        index = DGUsuarios.CurrentRow.Index
        If DGUsuarios.RowCount <> 0 Then
            TbIdUsuario.Text = Tabla.Rows(index).Item("IdUsuario")
            TbNombreUsuario.Text = Tabla.Rows(index).Item("Nombre")
            TbUsuario.Text = Tabla.Rows(index).Item("Usuario")
            TbPassword.Text = Tabla.Rows(index).Item("Pass")
            CbTipoUsuario.SelectedValue = Tabla.Rows(index).Item("IdTipoUsuario")
            CbIdEstatus.SelectedValue = Tabla.Rows(index).Item("IdEstatus")
        End If
    End Sub
    Private Sub PropiedadesDGUsuarios()
        DGUsuarios.Columns(0).Visible = False
        DGUsuarios.Columns(3).Visible = False
        DGUsuarios.Columns(4).Visible = False
        DGUsuarios.Columns(5).Visible = False
        DGUsuarios.Columns(1).Width = 300
        DGUsuarios.Columns(2).Width = 200
    End Sub
End Class