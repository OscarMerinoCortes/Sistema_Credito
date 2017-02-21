Public Class Documentos
    Public TablaDocumentos2 As New DataTable
    Private Sub Documentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarCombos()
        LimpiarCampos()
        ConsultarDocumentos()
        PropiedadesDGDocumentos()
    End Sub
    Private Sub LimpiarCampos()
        TBIdDocumento.Text = ""
        TBNombreDocumento.Text = ""
        CBTipoPersona.SelectedIndex = -1
        CBTipoPersona.Text = ""
        CBEstatusDocumento.SelectedIndex = -1
        CBEstatusDocumento.Text = ""
        DGDocumentos.DataSource = Nothing
    End Sub
    Private Sub llenarCombos()
        Dim dt As DataTable = New DataTable("Tabla")

        dt.Columns.Add("IdDocumento")
        dt.Columns.Add("Descripcion")

        Dim dr As DataRow

        dr = dt.NewRow()
        dr("IdDocumento") = 0
        dr("Descripcion") = "INACTIVO"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("IdDocumento") = 1
        dr("Descripcion") = "ACTIVO"
        dt.Rows.Add(dr)

        CBEstatusDocumento.DataSource = dt
        CBEstatusDocumento.ValueMember = "IdDocumento"
        CBEstatusDocumento.DisplayMember = "Descripcion"
        CBEstatusDocumento.SelectedIndex = -1
        '***************************************************************************
        Dim dt1 As DataTable = New DataTable("Tabla")

        dt1.Columns.Add("IdTipoPersona")
        dt1.Columns.Add("Descripcion")

        Dim dr1 As DataRow

        dr1 = dt1.NewRow()
        dr1("IdTipoPersona") = "F"
        dr1("Descripcion") = "FISICA"
        dt1.Rows.Add(dr1)

        dr1 = dt1.NewRow()
        dr1("IdTipoPersona") = "M"
        dr1("Descripcion") = "MORAL"
        dt1.Rows.Add(dr1)

        dr1 = dt1.NewRow()
        dr1("IdTipoPersona") = "A"
        dr1("Descripcion") = "AMBOS"
        dt1.Rows.Add(dr1)

        CBTipoPersona.DataSource = dt1
        CBTipoPersona.ValueMember = "IdTipoPersona"
        CBTipoPersona.DisplayMember = "Descripcion"
        CBTipoPersona.SelectedIndex = -1

    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        LimpiarCampos()
        ConsultarDocumentos()
        PropiedadesDGDocumentos()
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim EntidadDocumentos As New Capa_Entidad.Documentos
        Dim NegocioDocumentos As New Capa_Negocio.Documentos
        If TBNombreDocumento.Text = "" Or CBTipoPersona.SelectedValue = Nothing Or CBEstatusDocumento.SelectedValue = Nothing Then
            MsgBox("Verifica campos vacios", 0, "Aviso")
            Exit Sub
        End If
        If TBIdDocumento.Text Is String.Empty Then
            EntidadDocumentos.IdTipoDocumento = 0
        Else
            EntidadDocumentos.IdTipoDocumento = TBIdDocumento.Text
        End If
        EntidadDocumentos.Descripcion = TBNombreDocumento.Text
        EntidadDocumentos.TipoPersona = CBTipoPersona.SelectedValue
        EntidadDocumentos.IdEstado = CBEstatusDocumento.SelectedValue
        NegocioDocumentos.Guardar(EntidadDocumentos)
        ConsultarDocumentos()
        PropiedadesDGDocumentos()
        MsgBox("Registro guardado o editado con éxito")
        LimpiarCampos()
        ConsultarDocumentos()
        PropiedadesDGDocumentos()
    End Sub
    Private Sub ConsultarDocumentos()
        Dim EntidadDocumentos As New Capa_Entidad.Documentos
        Dim NegocioDocumentos As New Capa_Negocio.Documentos

        NegocioDocumentos.Consultar(EntidadDocumentos)
        TablaDocumentos2 = EntidadDocumentos.TablaDocumentosRegistrados
        DGDocumentos.DataSource = TablaDocumentos2
    End Sub
    Private Sub PropiedadesDGDocumentos()
        DGDocumentos.Columns("id").Visible = False
    End Sub
    Private Sub DGDocumentos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGDocumentos.CellDoubleClick
        If DGDocumentos.RowCount = 0 Then
            MessageBox.Show("No hay datos para seleccionar.")
        ElseIf DGDocumentos.CurrentRow IsNot Nothing Then
            Dim index As Integer
            index = DGDocumentos.CurrentRow.Index
            TBIdDocumento.Text = TablaDocumentos2.Rows(index).Item("id")
            TBNombreDocumento.Text = TablaDocumentos2.Rows(index).Item("descripcion")
            Select Case TablaDocumentos2.Rows(index).Item("tipo persona")
                Case "MORAL"
                    CBTipoPersona.SelectedValue = "M"
                Case "FISICA"
                    CBTipoPersona.SelectedValue = "F"
                Case "AMBOS"
                    CBTipoPersona.SelectedValue = "A"
            End Select
            Select Case TablaDocumentos2.Rows(index).Item("estatus")
                Case "ACTIVO"
                    CBEstatusDocumento.SelectedValue = 1
                Case "INACTIVO"
                    CBEstatusDocumento.SelectedValue = 0
            End Select
        End If
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class