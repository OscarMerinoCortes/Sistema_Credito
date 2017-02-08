Public Class Documentos
    Private Sub Documentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarCombos()
    End Sub
    Private Sub llenarCombos()
        Dim dt As DataTable = New DataTable("Tabla")

        dt.Columns.Add("IdDocumento")
        dt.Columns.Add("Descripcion")

        Dim dr As DataRow

        dr = dt.NewRow()
        dr("IdDocumento") = "0"
        dr("Descripcion") = "INACTIVO"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("IdDocumento") = "1"
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
        TBNombreDocumento.Text = ""
        CBEstatusDocumento.SelectedIndex = -1
        CBTipoPersona.SelectedIndex = -1

    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click

    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class