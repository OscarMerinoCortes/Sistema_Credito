Public Class AsignacionLotes
    Public TablaCultivos As DataTable
    Public TablaClientes As DataTable
    Private Sub AsignacionLotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenaCombo()
        TBIdCliente.Text = ""
        TBIdAsignacion.Text = ""
        CBClientes.SelectedIndex = -1
        CBCultivos.SelectedIndex = -1
    End Sub
    Private Sub LlenaCombo()
        Dim EntidadAsignacionLotes As New Capa_Entidad.AsignacionLotes
        Dim NegocioAsignacionLotes As New Capa_Negocio.AsignacionLotes
        NegocioAsignacionLotes.LLenaCombo(EntidadAsignacionLotes)
        TablaCultivos = EntidadAsignacionLotes.TablaCultivos
        CBCultivos.DataSource = TablaCultivos
        CBCultivos.DisplayMember = "Cultivo"
        CBCultivos.ValueMember = "IdCultivo"
        '-----------------------------------------------------------------------------------
        Dim EntidadPreregistro As New Capa_Entidad.Preregistro
        Dim NegocioPreregistro As New Capa_Negocio.Preregistro
        NegocioPreregistro.ConsultarClientesCombo(EntidadPreregistro)
        TablaClientes = EntidadPreregistro.TablaDatosDelCliente
        CBClientes.DataSource = TablaClientes
        CBClientes.DisplayMember = "Nombre"
        CBClientes.ValueMember = "IdCliente"
    End Sub
    Private Sub BTSeleccion_Click(sender As Object, e As EventArgs) Handles BTSeleccion.Click
        Dim ConsultaLotes As New ConsultaLotesParaAsignacion
        ConsultaLotes.ShowDialog()
        If VGTablaSeleccionLotes IsNot Nothing Then
            DGLotes.DataSource = VGTablaSeleccionLotes
            SumaHectareasSeleccionadas()
            PropiedadesDGLotes()
        End If
    End Sub
    Private Sub CBClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBClientes.SelectionChangeCommitted
        If CBClientes.SelectedIndex >= 0 Then TBIdCliente.Text = CBClientes.SelectedValue
    End Sub
    Private Sub PropiedadesDGLotes()
        DGLotes.Columns("IdPreregistroLote").HeaderText = "ID Lote"
        DGLotes.Columns("Nombre_Lote").HeaderText = "Nombre de Lote"
        DGLotes.Columns("IdColonia").HeaderText = "Colonia"
        DGLotes.Columns("Folio_Lote").HeaderText = "ID Lote"
        DGLotes.Columns("SuperficieRestante").HeaderText = "Superficie"

        DGLotes.Columns("Chcol").Visible = False
        DGLotes.Columns("IdPropietario").Visible = False
        DGLotes.Columns("Nombre").Visible = False
        DGLotes.Columns("RFC").Visible = False
        DGLotes.Columns("SuperficieSembrar").Visible = False
        DGLotes.Columns("SuperficieTotal").Visible = False
        DGLotes.Columns("SuperficieRestante").DefaultCellStyle.Format = "###,##0.000"
        DGLotes.Columns("Volumen").Visible = False
        DGLotes.Columns("Latitud_Grados").Visible = False
        DGLotes.Columns("Latitud_Horas").Visible = False
        DGLotes.Columns("Latitud_Minutos").Visible = False
        DGLotes.Columns("Longitud_Grados").Visible = False
        DGLotes.Columns("Longitud_Horas").Visible = False
        DGLotes.Columns("Longitud_Minutos").Visible = False
        DGLotes.Columns("Numero_RPP").Visible = False
        DGLotes.Columns("Folio_RPP").Visible = False
        DGLotes.Columns("Libro_RPP").Visible = False
        DGLotes.Columns("Fecha_RPP").Visible = False
        DGLotes.Columns("Titulo_Agua").Visible = False
        DGLotes.Columns("Regimen_Hidrico").Visible = False
        DGLotes.Columns("Fecha_Titulo_Agua").Visible = False
        DGLotes.Columns("Estado").Visible = False
    End Sub
    Private Sub SumaHectareasSeleccionadas()
        Dim Contador As Integer
        Dim SumaHa As Double
        For Contador = 0 To DGLotes.RowCount - 1

            SumaHa = SumaHa + DGLotes.Rows(Contador).Cells("SuperficieRestante").Value.ToString()

        Next Contador
        NUHectareas.Value = SumaHa
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        TBIdCliente.Text = ""
        TBIdAsignacion.Text = ""
        CBClientes.SelectedIndex = -1
        CBCultivos.SelectedIndex = -1
        NUHectareas.Value = 0.000
        DGLotes.DataSource = ""

        If VGTablaSeleccionLotes IsNot Nothing Then VGTablaSeleccionLotes.Clear()
    End Sub
    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        ConsultaClientesAsignarLotes.ShowDialog()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim EntidadAsignacionLotes As New Capa_Entidad.AsignacionLotes
        Dim NegocioAsignacionLotes As New Capa_Negocio.AsignacionLotes
        If TBIdAsignacion.Text Is String.Empty Then
            EntidadAsignacionLotes.IdAsignacion = 0
        Else
            EntidadAsignacionLotes.IdAsignacion = TBIdAsignacion.Text
        End If
        EntidadAsignacionLotes.IdCliente = CBClientes.SelectedValue
        EntidadAsignacionLotes.IdCultivo = CBCultivos.SelectedValue
        EntidadAsignacionLotes.IdHectareas = NUHectareas.Value
        EntidadAsignacionLotes.TablaLotesSeleccionados = VGTablaSeleccionLotes

        NegocioAsignacionLotes.GuardarAsignacion(EntidadAsignacionLotes)
        MsgBox("Registro guardado o editado con éxito")
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
End Class