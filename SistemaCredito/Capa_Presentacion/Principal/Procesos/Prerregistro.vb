Imports System.IO
Public Class Prerregistro
    Public TipoPersona As String
    Public TablaDocumentosObtenidos As New DataTable()
    Public TablaConsulta As New DataTable()
    Public EntidadPreregistro As New Capa_Entidad.Preregistro
    Public NegocioPreregistro As New Capa_Negocio.Preregistro
    '--------------------------------------------------------Persona Morales
    Public TablaSocios As New DataTable
    Public VPresidente, VSecretario, VRL, VTesorero As Integer

    Private Sub Prerregistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBFecha.Text = Now
        OFDPreregistro.Filter = "Todos(*.Jpg, *.Png, *.Gif, *.Tiff, *.Jpeg, *.Bmp)|*.Jpg; *.Png; *.Gif; *.Tiff; *.Jpeg; *.Bmp"
        CargarComboBoxs()
        ConsultarDocumentos()
        '---------------------------------------------
        TablaDocumentosObtenidos.Columns.Clear()
        TablaDocumentosObtenidos.Columns.Add(New DataColumn("IdPreregistroDetalle", Type.GetType("System.Int32")))
        TablaDocumentosObtenidos.Columns.Add(New DataColumn("IdDocumento", Type.GetType("System.Int32")))
        TablaDocumentosObtenidos.Columns.Add(New DataColumn("IdEstatus", Type.GetType("System.Boolean")))
        '---------------------------------------------------------------
        TablaSocios.Columns.Clear()
        TablaSocios.Columns.Add(New DataColumn("IdDatosAdicionales", Type.GetType("System.Int32")))
        TablaSocios.Columns.Add(New DataColumn("IdPersona", Type.GetType("System.Int32")))
        TablaSocios.Columns.Add(New DataColumn("IdCargo", Type.GetType("System.Int32")))
        TablaSocios.Columns.Add(New DataColumn("Nombre", Type.GetType("System.String")))
        TablaSocios.Columns.Add(New DataColumn("IdEstatus", Type.GetType("System.Boolean")))
    End Sub
    Private Sub PBFoto_Click(sender As Object, e As EventArgs) Handles PBFoto.Click
        Try
            Dim Ruta As String
            OFDPreregistro.ShowDialog()
            Ruta = OFDPreregistro.FileName.ToString
            PBFoto.Image = Image.FromFile(Ruta)
        Catch ex As Exception
            MessageBox.Show("Inserte una imagen", "Aviso")
        End Try
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
        ConsultarDocumentos()
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim EntidadPreregistro As New Capa_Entidad.Preregistro
        Dim NegocioPreregistro As New Capa_Negocio.Preregistro
        Dim arrFilename() As String = Split(Text, "\")
        Array.Reverse(arrFilename)
        Dim ms As New MemoryStream
        If PBFoto.Image Is Nothing Then
            MessageBox.Show("Inserte una imagen", "Aviso")
            Exit Sub
        End If
        PBFoto.Image.Save(ms, PBFoto.Image.RawFormat)
        Dim arrImage() As Byte = ms.GetBuffer
        AgregarDocumentosATabla()
        If CBTipoPersona.SelectedValue = 2 Then
            AgregarSocios()
        End If
        If TBIdCliente.Text Is String.Empty Then
            EntidadPreregistro.IdCliente = 0
        Else
            EntidadPreregistro.IdCliente = TBIdCliente.Text
        End If
        EntidadPreregistro.Foto = arrImage
        EntidadPreregistro.Fecha = TBFecha.Text
        EntidadPreregistro.Nombre = TBNombre.Text
        EntidadPreregistro.TipoPersona = CBTipoPersona.Text
        EntidadPreregistro.RFC = TBRFC.Text
        EntidadPreregistro.CURP = TBCURP.Text
        EntidadPreregistro.Domicilio = TBDomicilio.Text
        EntidadPreregistro.Telefono = TBTelefono.Text
        EntidadPreregistro.Correo = TBCorreo.Text
        EntidadPreregistro.IdEstado = CBIdEstado.SelectedValue
        EntidadPreregistro.CredencialConyugue = TBCredencialConyugue.Text
        EntidadPreregistro.RFCConyugue = TBRFCConyugue.Text
        EntidadPreregistro.CURPConyugue = TBCURPConyugue.Text
        EntidadPreregistro.EstadoCivil = CBEstadoCivil.Text
        EntidadPreregistro.TablaDocumentosAgregados = TablaDocumentosObtenidos
        EntidadPreregistro.TablaSocios = TablaSocios
        NegocioPreregistro.Guardar(EntidadPreregistro)
        MsgBox("Registro guardado o editado con éxito")
        Limpiar()
        ActualizarPersonaFisica()
        ConsultarDocumentos()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        Limpiar()
        Dim index As Integer
        Dim foto As Byte()
        Dim tabla As New DataTable
        ConsultaPreregistro.ShowDialog()
        index = VGIndex
        TablaConsulta = VGTablaDatosDelCliente
        If TablaConsulta Is Nothing Then
            Exit Sub
        End If
        TBIdCliente.Text = TablaConsulta.Rows(index).Item("IdCliente")
        TBNombre.Text = TablaConsulta.Rows(index).Item("Nombre")
        CBTipoPersona.Text = TablaConsulta.Rows(index).Item("TipoPersona")
        foto = CType(TablaConsulta.Rows(index).Item("Foto"), Byte())
        Dim MSFoto As New MemoryStream(foto)
        PBFoto.Image = Image.FromStream(MSFoto)
        TBRFC.Text = TablaConsulta.Rows(index).Item("RFC")
        TBCURP.Text = TablaConsulta.Rows(index).Item("CURP")
        TBDomicilio.Text = TablaConsulta.Rows(index).Item("Domicilio")
        TBTelefono.Text = TablaConsulta.Rows(index).Item("Telefono")
        TBCorreo.Text = TablaConsulta.Rows(index).Item("Correo")
        CBIdEstado.SelectedValue = TablaConsulta.Rows(index).Item("Estado")
        TBFecha.Text = TablaConsulta.Rows(index).Item("Fecha")
        CBEstadoCivil.Text = TablaConsulta.Rows(index).Item("EstadoCivil")
        TBCredencialConyugue.Text = TablaConsulta.Rows(index).Item("CredencialConyugue")
        TBRFCConyugue.Text = TablaConsulta.Rows(index).Item("RfcConyugue")
        TBCURPConyugue.Text = TablaConsulta.Rows(index).Item("CurpConyugue")
        EntidadPreregistro.IdCliente = TablaConsulta.Rows(index).Item("IdCliente")
        EntidadPreregistro.ConsultaDocumentos = 2
        NegocioPreregistro.Consultar(EntidadPreregistro)
        tabla = EntidadPreregistro.TablaDocumentosRegistrados
        DGDocumentos.DataSource = tabla
        DGDocumentos.Columns(0).Visible = False
        CBTipoPersona.Enabled = False
        If CBTipoPersona.Text = "MORAL" Then
            EntidadPreregistro.IdCliente = TablaConsulta.Rows(index).Item("IdCliente")
            EntidadPreregistro.ConsultaDocumentos = 4
            NegocioPreregistro.Consultar(EntidadPreregistro)
            Dim TablaDatosAdi As New DataTable
            TablaDatosAdi = EntidadPreregistro.TablaDatosAdicionales
            For Each row As DataRow In TablaDatosAdi.Rows
                If row("IdCargo") = 1 Then
                    CBPresidente.SelectedValue = CInt(row("IdPersona"))
                    VPresidente = CInt(row("IdDatosAdicionales"))
                End If
                If row("IdCargo") = 2 Then
                    CBSecretario.SelectedValue = CInt(row("IdPersona"))
                    VSecretario = CInt(row("IdDatosAdicionales"))
                End If
                If row("IdCargo") = 3 Then
                    CBRL.SelectedValue = CInt(row("IdPersona"))
                    VRL = CInt(row("IdDatosAdicionales"))
                End If
                If row("IdCargo") = 4 Then
                    CBTesorero.SelectedValue = CInt(row("IdPersona"))
                    Vtesorero = CInt(row("IdDatosAdicionales"))
                End If
                If row("IdCargo") = 5 Then
                    DGAgregados.Columns.Clear()
                    DGAgregados.DataSource = Nothing
                    PropiedadesDGAgregados()
                    DGAgregados.Rows.Add(row("IdDatosAdicionales"), row("IdPersona"), row("Nombre"), "", row("ChCol"))
                End If
            Next
            DGAgregados.Columns(0).Visible = False
        End If
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub ConsultarDocumentos()
        Dim EntidadPreregistro As New Capa_Entidad.Preregistro
        Dim NegocioPreregistro As New Capa_Negocio.Preregistro
        Dim TablaDocumentos2 As New DataTable
        If CBTipoPersona.Text = "FISICA" Then
            TipoPersona = "F"
            DesHabilitarCamposAdicionales()
            LbEstadoCivil.Visible = True
            CBEstadoCivil.Visible = True
        Else
            TipoPersona = "M"
            HabilitarCamposAdicionales()
            LbEstadoCivil.Visible = False
            CBEstadoCivil.Visible = False
            GBDatosConyugue.Visible = False
        End If
        EntidadPreregistro.TipoPersona = TipoPersona
        EntidadPreregistro.ConsultaDocumentos = 1
        NegocioPreregistro.Consultar(EntidadPreregistro)
        TablaDocumentos2 = EntidadPreregistro.TablaDocumentos
        DGDocumentos.DataSource = TablaDocumentos2
        DGDocumentos.Columns(0).Visible = False
    End Sub
    Private Sub CBTipoPersona_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBTipoPersona.SelectedIndexChanged
        ConsultarDocumentos()
    End Sub
    Private Sub AgregarDocumentosATabla()
        Dim index As Integer
        Dim rengloninsertar As DataRow
        TablaDocumentosObtenidos.Clear()
        For Each row As DataGridViewRow In DGDocumentos.Rows
            index = Convert.ToUInt64(row.Index)
            rengloninsertar = TablaDocumentosObtenidos.NewRow()
            rengloninsertar("IdPreregistroDetalle") = DGDocumentos.Rows(index).Cells("IdPreregistroDetalle").Value
            rengloninsertar("IdDocumento") = DGDocumentos.Rows(index).Cells("IdDocumento").Value
            rengloninsertar("IdEstatus") = DGDocumentos.Rows(index).Cells("Estatus").Value
            TablaDocumentosObtenidos.Rows.Add(rengloninsertar)
        Next
    End Sub
    Private Sub Limpiar()
        TBIdCliente.Text = ""
        TBNombre.Text = ""
        TBRFC.Text = ""
        TBCURP.Text = ""
        TBDomicilio.Text = ""
        TBTelefono.Text = ""
        TBCorreo.Text = ""
        PBFoto.Image = Nothing
        TBCredencialConyugue.Text = ""
        TBRFCConyugue.Text = ""
        TBCURPConyugue.Text = ""
        CBEstadoCivil.SelectedValue = -1
        CBTipoPersona.Enabled = True
        CBPresidente.SelectedValue = -1
        CBSecretario.SelectedValue = -1
        CBRL.SelectedValue = -1
        CBTesorero.SelectedValue = -1
        DGAgregados.Columns.Clear
    End Sub
    Private Sub CargarComboBoxs()
        Dim dt1 As DataTable = New DataTable("Tabla")
        dt1.Columns.Add("IdDocumento")
        dt1.Columns.Add("Descripcion")
        Dim dr As DataRow

        dr = dt1.NewRow()
        dr("IdDocumento") = 2
        dr("Descripcion") = "INACTIVO"
        dt1.Rows.Add(dr)

        dr = dt1.NewRow()
        dr("IdDocumento") = 1
        dr("Descripcion") = "ACTIVO"
        dt1.Rows.Add(dr)

        CBIdEstado.DataSource = dt1
        CBIdEstado.ValueMember = "IdDocumento"
        CBIdEstado.DisplayMember = "Descripcion"
        CBIdEstado.SelectedValue = 1
        '---------
        Dim tabla As New DataTable
        Dim EntidadPreregistro As New Capa_Entidad.Preregistro
        Dim NegocioPreregistro As New Capa_Negocio.Preregistro
        EntidadPreregistro.ConsultaDocumentos = 3
        NegocioPreregistro.Consultar(EntidadPreregistro)
        tabla = EntidadPreregistro.TablaDocumentosRegistrados

        CBPresidente.DataSource = tabla
        CBPresidente.ValueMember = "IdPersona"
        CBPresidente.DisplayMember = "Nombre"
        CBPresidente.SelectedValue = -1

        Dim tabla2 As New DataTable
        EntidadPreregistro.ConsultaDocumentos = 3
        NegocioPreregistro.Consultar(EntidadPreregistro)
        tabla2 = EntidadPreregistro.TablaDocumentosRegistrados
        CBSecretario.DataSource = tabla2
        CBSecretario.ValueMember = "IdPersona"
        CBSecretario.DisplayMember = "Nombre"
        CBSecretario.SelectedValue = -1

        Dim tabla3 As New DataTable
        EntidadPreregistro.ConsultaDocumentos = 3
        NegocioPreregistro.Consultar(EntidadPreregistro)
        tabla3 = EntidadPreregistro.TablaDocumentosRegistrados
        CBRL.DataSource = tabla3
        CBRL.ValueMember = "IdPersona"
        CBRL.DisplayMember = "Nombre"
        CBRL.SelectedValue = -1

        Dim tabla4 As New DataTable
        EntidadPreregistro.ConsultaDocumentos = 3
        NegocioPreregistro.Consultar(EntidadPreregistro)
        tabla4 = EntidadPreregistro.TablaDocumentosRegistrados
        CBTesorero.DataSource = tabla4
        CBTesorero.ValueMember = "IdPersona"
        CBTesorero.DisplayMember = "Nombre"
        CBTesorero.SelectedValue = -1

        PropiedadesDGSocios()
        '--ESTADO CIVIL---------------
        Dim dt2 As DataTable = New DataTable("Tabla")
        dt2.Columns.Add("IdEstadoCivil")
        dt2.Columns.Add("Descripcion")
        Dim dr2 As DataRow
        dr2 = dt2.NewRow()
        dr2("IdEstadoCivil") = 1
        dr2("Descripcion") = "SOLTERO"
        dt2.Rows.Add(dr2)
        dr2 = dt2.NewRow()
        dr2("IdEstadoCivil") = 2
        dr2("Descripcion") = "SOCIEDAD CONYUGAL"
        dt2.Rows.Add(dr2)
        dr2 = dt2.NewRow()
        dr2("IdEstadoCivil") = 3
        dr2("Descripcion") = "BIENES SEPARADOS"
        dt2.Rows.Add(dr2)

        CBEstadoCivil.DataSource = dt2
        CBEstadoCivil.ValueMember = "IdEstadoCivil"
        CBEstadoCivil.DisplayMember = "Descripcion"
        CBEstadoCivil.SelectedValue = -1
        '---------------------------------------TipoPersona
        Dim dt3 As DataTable = New DataTable("Tabla")
        dt3.Columns.Add("IdTipoPersona")
        dt3.Columns.Add("Descripcion")
        Dim dr3 As DataRow
        dr3 = dt3.NewRow()
        dr3("IdTipoPersona") = 1
        dr3("Descripcion") = "FISICA"
        dt3.Rows.Add(dr3)

        dr3 = dt3.NewRow()
        dr3("IdTipoPersona") = 2
        dr3("Descripcion") = "MORAL"
        dt3.Rows.Add(dr3)

        CBTipoPersona.DataSource = dt3
        CBTipoPersona.ValueMember = "IdTipoPersona"
        CBTipoPersona.DisplayMember = "Descripcion"
        CBTipoPersona.SelectedValue = 1
    End Sub

    Private Sub DGDocumentos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGDocumentos.CellContentClick
        Dim i As Integer
        i = DGDocumentos.CurrentRow.Index
        If DGDocumentos.Rows(i).Cells("Estatus").Value = False Then
            DGDocumentos.Rows(i).Cells("Estatus").Value = True
        ElseIf DGDocumentos.Rows(i).Cells("Estatus").Value = True Then
            DGDocumentos.Rows(i).Cells("Estatus").Value = False
        End If
    End Sub
    Private Sub HabilitarCamposAdicionales()
        CBPresidente.Enabled = True
        CBSecretario.Enabled = True
        CBRL.Enabled = True
        CBTesorero.Enabled = True
        GBSocios.Enabled = True
        BtAgregar.Enabled = True
    End Sub
    Private Sub DesHabilitarCamposAdicionales()
        CBPresidente.Enabled = False
        CBSecretario.Enabled = False
        CBRL.Enabled = False
        CBTesorero.Enabled = False
        GBSocios.Enabled = False
        BtAgregar.Enabled = False
    End Sub
    Private Sub AgregarSocios()
        Dim index As Integer
        Dim rengloninsertar As DataRow
        TablaSocios.Clear()
        For Each row As DataGridViewRow In DGAgregados.Rows
            index = Convert.ToUInt64(row.Index)
            rengloninsertar = TablaSocios.NewRow()
            rengloninsertar("IdDatosAdicionales") = DGAgregados.Rows(index).Cells("IdDatosAdicionales").Value
            rengloninsertar("IdPersona") = DGAgregados.Rows(index).Cells("IdPersona").Value
            rengloninsertar("Nombre") = DGAgregados.Rows(index).Cells("Nombre").Value
            rengloninsertar("IdCargo") = 5
            rengloninsertar("IdEstatus") = DGAgregados.Rows(index).Cells("ChCol").Value
            TablaSocios.Rows.Add(rengloninsertar)
        Next
        'Presidente
        rengloninsertar = TablaSocios.NewRow()
        rengloninsertar("IdDatosAdicionales") = (IIf(TBIdCliente.Text Is String.Empty, 0, VPresidente))
        rengloninsertar("IdPersona") = CBPresidente.SelectedValue
        rengloninsertar("Nombre") = CBPresidente.Text
        rengloninsertar("IdCargo") = 1
        rengloninsertar("IdEstatus") = True
        TablaSocios.Rows.Add(rengloninsertar)
        'Secretario
        rengloninsertar = TablaSocios.NewRow()
        rengloninsertar("IdDatosAdicionales") = (IIf(TBIdCliente.Text Is String.Empty, 0, VSecretario))
        rengloninsertar("IdPersona") = CBSecretario.SelectedValue
        rengloninsertar("Nombre") = CBSecretario.Text
        rengloninsertar("IdCargo") = 2
        rengloninsertar("IdEstatus") = True
        TablaSocios.Rows.Add(rengloninsertar)
        'RepresentanteLegal
        rengloninsertar = TablaSocios.NewRow()
        rengloninsertar("IdDatosAdicionales") = (IIf(TBIdCliente.Text Is String.Empty, 0, VRL))
        rengloninsertar("IdPersona") = CBRL.SelectedValue
        rengloninsertar("Nombre") = CBRL.Text
        rengloninsertar("IdCargo") = 3
        rengloninsertar("IdEstatus") = True
        TablaSocios.Rows.Add(rengloninsertar)
        'Tesorero
        rengloninsertar = TablaSocios.NewRow()
        rengloninsertar("IdDatosAdicionales") = (IIf(TBIdCliente.Text Is String.Empty, 0, VTesorero))
        rengloninsertar("IdPersona") = CBTesorero.SelectedValue
        rengloninsertar("Nombre") = CBTesorero.Text
        rengloninsertar("IdCargo") = 4
        rengloninsertar("IdEstatus") = True
        TablaSocios.Rows.Add(rengloninsertar)
    End Sub
    Private Sub DGSocios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGSocios.CellContentClick
        Dim i As Integer
        i = DGDocumentos.CurrentRow.Index
        If DGDocumentos.Rows(i).Cells("Estatus").Value = False Then
            DGDocumentos.Rows(i).Cells("Estatus").Value = True
        ElseIf DGDocumentos.Rows(i).Cells("Estatus").Value = True Then
            DGDocumentos.Rows(i).Cells("Estatus").Value = False
        End If
    End Sub

    Private Sub CBEstadoCivil_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBEstadoCivil.SelectedIndexChanged
        If CBEstadoCivil.Text = "SOCIEDAD CONYUGAL" Or CBEstadoCivil.Text = "BIENES SEPARADOS" Then
            GBDatosConyugue.Visible = True
        Else
            GBDatosConyugue.Visible = False
        End If
    End Sub
    Private Sub ActualizarPersonaFisica()
        '---------
        Dim tabla As New DataTable
        Dim EntidadPreregistro As New Capa_Entidad.Preregistro
        Dim NegocioPreregistro As New Capa_Negocio.Preregistro
        EntidadPreregistro.ConsultaDocumentos = 3
        NegocioPreregistro.Consultar(EntidadPreregistro)
        tabla = EntidadPreregistro.TablaDocumentosRegistrados

        CBPresidente.DataSource = tabla
        CBPresidente.ValueMember = "IdPersona"
        CBPresidente.DisplayMember = "Nombre"
        CBPresidente.SelectedValue = -1

        Dim tabla2 As New DataTable
        EntidadPreregistro.ConsultaDocumentos = 3
        NegocioPreregistro.Consultar(EntidadPreregistro)
        tabla2 = EntidadPreregistro.TablaDocumentosRegistrados

        CBSecretario.DataSource = tabla2
        CBSecretario.ValueMember = "IdPersona"
        CBSecretario.DisplayMember = "Nombre"
        CBSecretario.SelectedValue = -1

        Dim tabla3 As New DataTable
        EntidadPreregistro.ConsultaDocumentos = 3
        NegocioPreregistro.Consultar(EntidadPreregistro)
        tabla3 = EntidadPreregistro.TablaDocumentosRegistrados
        CBRL.DataSource = tabla3
        CBRL.ValueMember = "IdPersona"
        CBRL.DisplayMember = "Nombre"
        CBRL.SelectedValue = -1

        Dim tabla4 As New DataTable
        EntidadPreregistro.ConsultaDocumentos = 3
        NegocioPreregistro.Consultar(EntidadPreregistro)
        tabla4 = EntidadPreregistro.TablaDocumentosRegistrados
        CBTesorero.DataSource = tabla4
        CBTesorero.ValueMember = "IdPersona"
        CBTesorero.DisplayMember = "Nombre"
        CBTesorero.SelectedValue = -1

        PropiedadesDGSocios()
    End Sub
    Private Sub PropiedadesDGSocios()
        Dim tabla5 As New DataTable
        EntidadPreregistro.ConsultaDocumentos = 3
        NegocioPreregistro.Consultar(EntidadPreregistro)
        tabla5 = EntidadPreregistro.TablaDocumentosRegistrados
        DGSocios.DataSource = tabla5

        Dim checkBoxColumn As New DataGridViewCheckBoxColumn()
        checkBoxColumn.HeaderText = ""
        checkBoxColumn.Name = "ChCol"
        DGSocios.Columns.Insert(3, checkBoxColumn)
        DGSocios.Columns(0).Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CrearCarpetas()
    End Sub

    Private Sub BtAgregar_Click(sender As Object, e As EventArgs) Handles BtAgregar.Click
        DGAgregados.Columns.Clear()
        DGAgregados.DataSource = Nothing
        PropiedadesDGAgregados()
        Dim Contador As Integer
        For Contador = 0 To DGSocios.RowCount - 1
            If DGSocios.Rows(Contador).Cells("ChCol").Value = True Then
                If DGSocios.Rows(Contador).Cells("IdPersona").Value <> CBPresidente.SelectedValue And DGSocios.Rows(Contador).Cells("IdPersona").Value <> CBSecretario.SelectedValue And DGSocios.Rows(Contador).Cells("IdPersona").Value <> CBRL.SelectedValue And DGSocios.Rows(Contador).Cells("IdPersona").Value <> CBTesorero.SelectedValue Then
                    DGAgregados.Rows.Add(DGSocios.Rows(Contador).Cells("IdDatosAdicionales").Value, DGSocios.Rows(Contador).Cells("IdPersona").Value, DGSocios.Rows(Contador).Cells("Nombre").Value.ToString(), "", DGSocios.Rows(Contador).Cells("ChCol").Value)
                End If
            End If
        Next Contador
        DGAgregados.Columns(0).Visible = False
        DGAgregados.Columns(3).Visible = False
    End Sub
    Private Sub PropiedadesDGAgregados()
        Dim ColIdDatosAdicionales As New DataGridViewTextBoxColumn
        ColIdDatosAdicionales.Name = "IdDatosAdicionales"
        ColIdDatosAdicionales.Visible = True
        DGAgregados.Columns.Insert(0, ColIdDatosAdicionales)

        Dim ColIdPersona As New DataGridViewTextBoxColumn
        ColIdPersona.Name = "IdPersona"
        ColIdPersona.Visible = True
        DGAgregados.Columns.Insert(1, ColIdPersona)

        Dim ColNombrePersona As New DataGridViewTextBoxColumn
        ColNombrePersona.Name = "Nombre"
        ColNombrePersona.HeaderText = "Nombre"
        DGAgregados.Columns.Insert(2, ColNombrePersona)

        Dim ColIdCargo As New DataGridViewTextBoxColumn
        ColIdCargo.Name = "IdCargo"
        ColIdCargo.Visible = True
        DGAgregados.Columns.Insert(3, ColIdCargo)

        Dim checkBoxColumn As New DataGridViewCheckBoxColumn()
        checkBoxColumn.HeaderText = ""
        checkBoxColumn.Name = "ChCol"
        DGAgregados.Columns.Insert(4, checkBoxColumn)
    End Sub
    Private Sub CrearCarpetas()
        Dim EntidadUbicacion As New Capa_Entidad.UbicacionDocumentos
        Dim NegocioUbicacion As New Capa_Negocio.UbicacionDocumentos
        Dim tabla As New DataTable
        Dim NombreCarpeta As String
        NombreCarpeta = TBIdCliente.Text + " " + TBNombre.Text
        EntidadUbicacion.ConsultaUbicacion = 2
        NegocioUbicacion.Consultar(EntidadUbicacion)
        tabla = EntidadUbicacion.TablaUbicacionRegistrada

        If Not Directory.Exists(tabla.Rows(0).Item("ruta") & tabla.Rows(0).Item("NombreCarpetaRaiz") & NombreCarpeta) Then
            Directory.CreateDirectory(tabla.Rows(0).Item("ruta") & tabla.Rows(0).Item("NombreCarpetaRaiz") & "\" & NombreCarpeta)
            'Directory.CreateDirectory(tabla.Rows(0).Item("ruta") + tabla.Rows(0).Item("NombreCarpetaRaiz") + TBIdCliente.Text + " " + TBNombre.Text & tabla.Rows(0).Item("NombreCarpetaPersonal"))
            'Directory.CreateDirectory(tabla.Rows(0).Item("ruta") & tabla.Rows(0).Item("NombreCarpetaRaiz") + TBIdCliente.Text + " " + TBNombre.Text & tabla.Rows(0).Item("NombreCarpetaLote"))
        End If
        Process.Start("explorer.exe", (tabla.Rows(0).Item("ruta") & tabla.Rows(0).Item("NombreCarpetaRaiz")) & (TBIdCliente.Text & " " & TBNombre.Text))
    End Sub
End Class