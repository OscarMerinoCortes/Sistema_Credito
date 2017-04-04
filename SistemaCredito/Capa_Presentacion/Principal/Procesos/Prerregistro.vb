Imports System.IO
Imports Microsoft.Office.Interop
Public Class Prerregistro
    Public TipoPersona As String
    Public TablaDocumentosObtenidos As New DataTable()
    Public TablaConsulta As New DataTable()
    Public EntidadPreregistro As New Capa_Entidad.Preregistro
    Public NegocioPreregistro As New Capa_Negocio.Preregistro
    '--------------------------------------------------------Persona Morales
    Public TablaSocios As New DataTable
    Public VPresidente, VSecretario, VRL, VTesorero As Integer
    Dim tabla5 As New DataTable
    Dim EntidadUbicacion As New Capa_Entidad.UbicacionDocumentos
    Dim NegocioUbicacion As New Capa_Negocio.UbicacionDocumentos
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
        '---Datos del cliente
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
        EntidadPreregistro.TipoPersona = CBTipoPersona.Text
        EntidadPreregistro.Fecha = TBFecha.Text
        EntidadPreregistro.Nombre = TBNombre.Text
        EntidadPreregistro.Telefono = TBTelefono.Text
        EntidadPreregistro.Correo = TBCorreo.Text
        EntidadPreregistro.RFC = TBRFC.Text
        EntidadPreregistro.CURP = TBCURP.Text
        EntidadPreregistro.IdEstatus = CBIdEstatus.SelectedValue
        EntidadPreregistro.IdEstadoCivil = IIf(CBEstadoCivil.SelectedValue = Nothing, 0, CBEstadoCivil.SelectedValue)
        EntidadPreregistro.EstadoCivil = CBEstadoCivil.Text
        EntidadPreregistro.IdRegimen = CBRegimen.SelectedValue
        EntidadPreregistro.Regimen = CBRegimen.Text
        EntidadPreregistro.ImporteSolicitado = IIf(TBImporte.Text = Nothing, 0, TBImporte.Text)
        EntidadPreregistro.ImporteLetra = TBImporteLetra.Text
        EntidadPreregistro.IdTipoCambio = CBTipoCambio.SelectedValue
        EntidadPreregistro.ActividadHabitual = TBActividad.Text
        EntidadPreregistro.Calle = TBCalle.Text
        EntidadPreregistro.Colonia = TBColonia.Text
        EntidadPreregistro.Numero = TBNumero.Text
        EntidadPreregistro.IdEstado = CBEstado.SelectedValue
        EntidadPreregistro.Estado = CBEstado.Text
        EntidadPreregistro.IdMunicipio = CBMunicipio.SelectedValue
        EntidadPreregistro.Municipio = CBMunicipio.Text
        EntidadPreregistro.Poblacion = TBPoblacion.Text
        EntidadPreregistro.CP = IIf(TBCP.Text = Nothing, 0, TBCP.Text)
        EntidadPreregistro.SegundoNombre = TBSegNombre.Text
        EntidadPreregistro.ApellidoPaterno = TBApePaterno.Text
        EntidadPreregistro.ApellidoMaterno = TBApeMaterno.Text
        EntidadPreregistro.IdSexo = CBSexo.SelectedValue
        EntidadPreregistro.Sexo = CBSexo.Text
        EntidadPreregistro.Edad = TBEdad.Text
        EntidadPreregistro.IdNacionalidadNacimiento = CBNacionalidadNac.SelectedValue
        EntidadPreregistro.Nacionalidad = CBNacionalidadNac.Text
        EntidadPreregistro.FechaNacimiento = DTPFechaNacimiento.Text
        EntidadPreregistro.IdEstadoNacimiento = CBEstadoNac.SelectedValue
        EntidadPreregistro.EstadoNacimiento = CBEstadoNac.Text
        EntidadPreregistro.IdMunicipioNacimiento = CBMunicipioNac.SelectedValue
        EntidadPreregistro.MunicipioNacimiento = CBMunicipioNac.Text
        EntidadPreregistro.CIdConyugue = CBConyugue.SelectedValue
        EntidadPreregistro.CFechaMatrimonio = DTPFechaMatrimonioCony.Text
        EntidadPreregistro.CIdEstadoMatrimonio = CBEstadoMatrimonioCony.SelectedValue
        EntidadPreregistro.EstadoMatrimonio = CBEstadoMatrimonioCony.Text
        EntidadPreregistro.CIdMunicipioMatrimonio = CBMunicipioMatrimonioCony.SelectedValue
        EntidadPreregistro.MunicipioMatrimonio = CBMunicipioMatrimonioCony.Text
        EntidadPreregistro.TablaDocumentosAgregados = TablaDocumentosObtenidos
        EntidadPreregistro.TablaSocios = TablaSocios
        '---------------------------------------------------------------------------------
        NegocioPreregistro.Guardar(EntidadPreregistro)


        TBIdCliente.Text = EntidadPreregistro.IdCliente
        CrearCarpetas()
        LlenarExcel()
        Limpiar()
        ActualizarPersonaFisica()
        ConsultarDocumentos()
        CargaConyugue()
        MsgBox("Registro guardado o editado con éxito")
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
        foto = CType(TablaConsulta.Rows(index).Item("Foto"), Byte())
        Dim MSFoto As New MemoryStream(foto)
        PBFoto.Image = Image.FromStream(MSFoto)
        CBTipoPersona.Text = TablaConsulta.Rows(index).Item("IdTipoPersona")
        TBNombre.Text = TablaConsulta.Rows(index).Item("Nombre")
        TBSegNombre.Text = TablaConsulta.Rows(index).Item("SegundoNombre")
        TBApePaterno.Text = TablaConsulta.Rows(index).Item("ApellidoPaterno")
        TBApeMaterno.Text = TablaConsulta.Rows(index).Item("ApellidoMaterno")
        CBSexo.SelectedValue = TablaConsulta.Rows(index).Item("IdSexo")
        TBEdad.Text = TablaConsulta.Rows(index).Item("Edad")
        DTPFechaNacimiento.Text = TablaConsulta.Rows(index).Item("FechaNacimiento")
        CBEstadoNac.SelectedValue = TablaConsulta.Rows(index).Item("IdEstadoNacimiento")
        MunicipioNacimiento()
        CBMunicipioNac.SelectedValue = TablaConsulta.Rows(index).Item("IdMunicipioNacimiento")
        CBNacionalidadNac.SelectedValue = TablaConsulta.Rows(index).Item("IdNacionalidad")
        TBTelefono.Text = TablaConsulta.Rows(index).Item("Telefono")
        TBCorreo.Text = TablaConsulta.Rows(index).Item("Correo")
        TBRFC.Text = TablaConsulta.Rows(index).Item("RFC")
        TBCURP.Text = TablaConsulta.Rows(index).Item("CURP")
        CBIdEstatus.SelectedValue = TablaConsulta.Rows(index).Item("IdEstatus")
        CBEstadoCivil.SelectedValue = TablaConsulta.Rows(index).Item("IdEstadoCivil")
        TBImporte.Text = TablaConsulta.Rows(index).Item("ImporteSolicitado")
        TBImporteLetra.Text = TablaConsulta.Rows(index).Item("ImporteLetra")
        CBTipoCambio.SelectedValue = TablaConsulta.Rows(index).Item("IdTipoCambio")
        TBActividad.Text = TablaConsulta.Rows(index).Item("ActividadHabitual")
        TBCalle.Text = TablaConsulta.Rows(index).Item("Calle")
        TBColonia.Text = TablaConsulta.Rows(index).Item("Colonia")
        TBNumero.Text = TablaConsulta.Rows(index).Item("Numero")
        CBEstado.SelectedValue = TablaConsulta.Rows(index).Item("IdEstado")
        Municipio()
        CBMunicipio.SelectedValue = TablaConsulta.Rows(index).Item("IdMunicipio")
        TBPoblacion.Text = TablaConsulta.Rows(index).Item("Poblacion")
        TBCP.Text = TablaConsulta.Rows(index).Item("CodigoPostal")
        CBConyugue.SelectedValue = TablaConsulta.Rows(index).Item("IdConyugue")
        DTPFechaMatrimonioCony.Text = TablaConsulta.Rows(index).Item("FechaMatrimonio")
        CBEstadoMatrimonioCony.SelectedValue = TablaConsulta.Rows(index).Item("IdEstadoMatrimonio")
        MunicipioMatrimonio()
        CBMunicipioMatrimonioCony.SelectedValue = TablaConsulta.Rows(index).Item("IdMunicipioMatrimonio")
        TBFecha.Text = TablaConsulta.Rows(index).Item("Fecha")
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
                    VTesorero = CInt(row("IdDatosAdicionales"))
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
        BtnCarpetas.Visible = True
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
        Else
            TipoPersona = "M"
            HabilitarCamposAdicionales()
        End If
        EntidadPreregistro.TipoPersona = TipoPersona
        EntidadPreregistro.ConsultaDocumentos = 1
        NegocioPreregistro.Consultar(EntidadPreregistro)
        TablaDocumentos2 = EntidadPreregistro.TablaDocumentos
        DGDocumentos.DataSource = TablaDocumentos2
        DGDocumentos.Columns(0).Visible = False
        DGDocumentos.Columns(2).Width = 150
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
        'Datos generales de la persona
        PBFoto.Image = Nothing
        TBIdCliente.Text = ""
        CBTipoPersona.Enabled = True
        CBTipoPersona.SelectedValue = 1
        TBNombre.Text = ""
        TBTelefono.Text = ""
        TBCorreo.Text = ""
        TBRFC.Text = ""
        TBCURP.Text = ""
        CBIdEstatus.SelectedValue = 1
        CBEstadoCivil.SelectedValue = 1
        TBImporte.Text = ""
        TBImporteLetra.Text = ""
        TBActividad.Text = ""
        TBCalle.Text = ""
        TBColonia.Text = ""
        TBNumero.Text = ""
        CBEstado.SelectedValue = 1
        CBMunicipio.SelectedValue = 1
        TBPoblacion.Text = ""
        TBCP.Text = ""
        CBEstadoNac.SelectedValue = 1
        CBMunicipioNac.SelectedValue = 1
        CBNacionalidadNac.SelectedValue = 1
        TBSegNombre.Text = ""
        TBApePaterno.Text = ""
        TBApeMaterno.Text = ""
        CBSexo.SelectedValue = 1
        TBEdad.Text = ""
        'Datos del conyugue
        CBConyugue.SelectedValue = -1
        CBEstadoMatrimonioCony.SelectedValue = 1
        CBMunicipioMatrimonioCony.SelectedValue = 1
        'Adicionales
        CBPresidente.SelectedValue = 1
        CBSecretario.SelectedValue = 1
        CBRL.SelectedValue = 1
        CBTesorero.SelectedValue = 1
        DGAgregados.Columns.Clear()
        BtnCarpetas.Visible = False
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
        CBIdEstatus.DataSource = dt1
        CBIdEstatus.ValueMember = "IdDocumento"
        CBIdEstatus.DisplayMember = "Descripcion"
        CBIdEstatus.SelectedValue = 1
        '----------------------------------------------------
        Dim tabla As New DataTable
        Dim EntidadPreregistro As New Capa_Entidad.Preregistro
        Dim NegocioPreregistro As New Capa_Negocio.Preregistro
        EntidadPreregistro.ConsultaDocumentos = 3
        NegocioPreregistro.Consultar(EntidadPreregistro)
        tabla = EntidadPreregistro.TablaDocumentosRegistrados
        CBPresidente.DataSource = tabla
        CBPresidente.ValueMember = "IdPersona"
        CBPresidente.DisplayMember = "Nombre"
        CBPresidente.SelectedValue = 1

        Dim tabla2 As New DataTable
        EntidadPreregistro.ConsultaDocumentos = 3
        NegocioPreregistro.Consultar(EntidadPreregistro)
        tabla2 = EntidadPreregistro.TablaDocumentosRegistrados
        CBSecretario.DataSource = tabla2
        CBSecretario.ValueMember = "IdPersona"
        CBSecretario.DisplayMember = "Nombre"
        CBSecretario.SelectedValue = 1

        Dim tabla3 As New DataTable
        EntidadPreregistro.ConsultaDocumentos = 3
        NegocioPreregistro.Consultar(EntidadPreregistro)
        tabla3 = EntidadPreregistro.TablaDocumentosRegistrados
        CBRL.DataSource = tabla3
        CBRL.ValueMember = "IdPersona"
        CBRL.DisplayMember = "Nombre"
        CBRL.SelectedValue = 1

        Dim tabla4 As New DataTable
        EntidadPreregistro.ConsultaDocumentos = 3
        NegocioPreregistro.Consultar(EntidadPreregistro)
        tabla4 = EntidadPreregistro.TablaDocumentosRegistrados
        CBTesorero.DataSource = tabla4
        CBTesorero.ValueMember = "IdPersona"
        CBTesorero.DisplayMember = "Nombre"
        CBTesorero.SelectedValue = 1
        PropiedadesDGSocios()
        '..Conyugue-------------------------------------        
        EntidadPreregistro.ConsultaDocumentos = 3
        NegocioPreregistro.Consultar(EntidadPreregistro)
        tabla5 = EntidadPreregistro.TablaDocumentosRegistrados
        CBConyugue.DataSource = tabla5
        CBConyugue.ValueMember = "IdPersona"
        CBConyugue.DisplayMember = "Nombre"
        CBConyugue.SelectedValue = -1
        '--ESTADO CIVIL---------------
        Dim dt2 As DataTable = New DataTable("Tabla")
        dt2.Columns.Add("IdEstadoCivil")
        dt2.Columns.Add("Descripcion")
        Dim dr2 As DataRow
        dr2 = dt2.NewRow()
        dr2("IdEstadoCivil") = 1
        dr2("Descripcion") = "SOLTERO(A)"
        dt2.Rows.Add(dr2)
        dr2 = dt2.NewRow()
        dr2("IdEstadoCivil") = 2
        dr2("Descripcion") = "CASADO(A)"
        dt2.Rows.Add(dr2)
        dr2 = dt2.NewRow()
        dr2("IdEstadoCivil") = 3
        dr2("Descripcion") = "VIUDO(A)"
        dt2.Rows.Add(dr2)
        dr2 = dt2.NewRow()
        dr2("IdEstadoCivil") = 4
        dr2("Descripcion") = "DIVORCIADO(A)"
        dt2.Rows.Add(dr2)
        dr2 = dt2.NewRow()
        dr2("IdEstadoCivil") = 5
        dr2("Descripcion") = "UNION LIBRE"
        dt2.Rows.Add(dr2)
        dr2 = dt2.NewRow()
        dr2("IdEstadoCivil") = 6
        dr2("Descripcion") = "NO APLICA"
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
        '---------------------------------------Regimen
        Dim dt4 As DataTable = New DataTable("Tabla")
        dt4.Columns.Add("IdRegimen")
        dt4.Columns.Add("Descripcion")
        Dim dr4 As DataRow
        dr4 = dt4.NewRow()
        dr4("IdRegimen") = 1
        dr4("Descripcion") = "SOCIEDAD CONYUGAL"
        dt4.Rows.Add(dr4)
        dr4 = dt4.NewRow()
        dr4("IdRegimen") = 2
        dr4("Descripcion") = "SEPARACION DE BIENES"
        dt4.Rows.Add(dr4)
        dr4 = dt4.NewRow()
        dr4("IdRegimen") = 3
        dr4("Descripcion") = "NO APLICA"
        dt4.Rows.Add(dr4)
        CBRegimen.DataSource = dt4
        CBRegimen.ValueMember = "IdRegimen"
        CBRegimen.DisplayMember = "Descripcion"
        CBRegimen.SelectedValue = -1
        '---------------------------------------Estados
        Dim TablaEstados As New DataTable
        Dim EntidadLocalizacion As New Capa_Entidad.Localizacion
        Dim NegocioLocalizacion As New Capa_Negocio.Localizacion
        EntidadLocalizacion.IdConsulta = 1
        NegocioLocalizacion.Consultar(EntidadLocalizacion)
        TablaEstados = EntidadLocalizacion.TablaConsulta
        CBEstado.DataSource = TablaEstados
        CBEstado.ValueMember = "IdEstado"
        CBEstado.DisplayMember = "Estado"
        CBEstado.SelectedValue = 1
        '--Municipio---       
        Municipio()
        '---------------------------------------Estados de la Republica para el combo de Lugar de Nacimiento              
        EntidadLocalizacion.IdConsulta = 1
        NegocioLocalizacion.Consultar(EntidadLocalizacion)
        TablaEstados = EntidadLocalizacion.TablaConsulta
        CBEstadoNac.DataSource = TablaEstados
        CBEstadoNac.ValueMember = "IdEstado"
        CBEstadoNac.DisplayMember = "Estado"
        CBEstadoNac.SelectedValue = 1
        '---Municipios        
        MunicipioNacimiento()
        '---------------------------------------Estados de la Republica para el combo de Lugar de Matrimonio       
        EntidadLocalizacion.IdConsulta = 1
        NegocioLocalizacion.Consultar(EntidadLocalizacion)
        TablaEstados = EntidadLocalizacion.TablaConsulta
        CBEstadoMatrimonioCony.DataSource = TablaEstados
        CBEstadoMatrimonioCony.ValueMember = "IdEstado"
        CBEstadoMatrimonioCony.DisplayMember = "Estado"
        CBEstadoMatrimonioCony.SelectedValue = 1
        '---Municipios        
        MunicipioMatrimonio()
        '------------------------------------------------Nacionalidad
        Dim TablaNacionalidad As DataTable = New DataTable("Tabla")
        TablaNacionalidad.Columns.Add("IdNacionalidad")
        TablaNacionalidad.Columns.Add("Nacionalidad")
        Dim row As DataRow
        row = TablaNacionalidad.NewRow()
        row("IdNacionalidad") = 1
        row("Nacionalidad") = "MEXICANA"
        TablaNacionalidad.Rows.Add(row)
        row = TablaNacionalidad.NewRow()
        row("IdNacionalidad") = 2
        row("Nacionalidad") = "ESTADOUNIDENSE"
        TablaNacionalidad.Rows.Add(row)
        CBNacionalidadNac.DataSource = TablaNacionalidad
        CBNacionalidadNac.ValueMember = "IdNacionalidad"
        CBNacionalidadNac.DisplayMember = "Nacionalidad"
        CBNacionalidadNac.SelectedValue = 1
        '------------------------------------------------Sexo
        Dim TablaSexo As DataTable = New DataTable("Tabla")
        TablaSexo.Columns.Add("IdSexo")
        TablaSexo.Columns.Add("Sexo")
        Dim rowS As DataRow
        rowS = TablaSexo.NewRow()
        rowS("IdSexo") = 1
        rowS("Sexo") = "MASCULINO"
        TablaSexo.Rows.Add(rowS)
        rowS = TablaSexo.NewRow()
        rowS("IdSexo") = 2
        rowS("Sexo") = "FEMENINO"
        TablaSexo.Rows.Add(rowS)

        CBSexo.DataSource = TablaSexo
        CBSexo.ValueMember = "IdSexo"
        CBSexo.DisplayMember = "Sexo"
        CBSexo.SelectedValue = 1
        ''''''''---------------------------Tipo de Cambio
        Dim TipoCambio As DataTable = New DataTable("Tabla")
        TipoCambio.Columns.Add("IdTipoCambio")
        TipoCambio.Columns.Add("Cambio")
        Dim RowTC As DataRow
        RowTC = TipoCambio.NewRow()
        RowTC("IdTipoCambio") = 1
        RowTC("Cambio") = "MXN"
        TipoCambio.Rows.Add(RowTC)
        RowTC = TipoCambio.NewRow()
        RowTC("IdTipoCambio") = 2
        RowTC("Cambio") = "DLLS"
        TipoCambio.Rows.Add(RowTC)
        CBTipoCambio.DataSource = TipoCambio
        CBTipoCambio.ValueMember = "IdTipoCambio"
        CBTipoCambio.DisplayMember = "Cambio"
        CBTipoCambio.SelectedValue = 1
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
        LbEstadoCivil.Visible = False
        CBEstadoCivil.Visible = False
        GBFecMatConyugue.Enabled = False
        GBFechaNacimiento.Enabled = False
        GBDatosGenerales.Enabled = False
    End Sub
    Private Sub DesHabilitarCamposAdicionales()
        CBPresidente.Enabled = False
        CBSecretario.Enabled = False
        CBRL.Enabled = False
        CBTesorero.Enabled = False
        GBSocios.Enabled = False
        BtAgregar.Enabled = False
        LbEstadoCivil.Visible = True
        CBEstadoCivil.Visible = True
        GBFecMatConyugue.Enabled = True
        GBFechaNacimiento.Enabled = True
        GBDatosGenerales.Enabled = True
        CBEstadoCivil.SelectedValue = -1
    End Sub
    Private Sub HabilitarCamposMatrimonio()
        GBFecMatConyugue.Enabled = True
        CBConyugue.SelectedIndex = 1
        CBEstadoMatrimonioCony.SelectedIndex = 1
        CBMunicipioMatrimonioCony.SelectedIndex = 1
    End Sub
    Private Sub DesHabilitarCamposMatrimonio()
        GBFecMatConyugue.Enabled = False
        CBConyugue.SelectedIndex = -1
        CBEstadoMatrimonioCony.SelectedIndex = -1
        CBMunicipioMatrimonioCony.SelectedIndex = -1
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
        If CBEstadoCivil.Text = "CASADO(A)" Then
            LbRegimen.Visible = True
            CBRegimen.Visible = True
            HabilitarCamposMatrimonio()
        ElseIf CBEstadoCivil.Text = "SOLTERO(A)" Or CBEstadoCivil.Text = "NO APLICA" Then
            LbRegimen.Visible = False
            CBRegimen.Visible = False
            DesHabilitarCamposMatrimonio()
        ElseIf CBEstadoCivil.Text <> "CASADO(A)" Then
            LbRegimen.Visible = False
            CBRegimen.Visible = False
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCarpetas.Click
        CrearCarpetas()
    End Sub
    Private Sub CBEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBEstado.SelectionChangeCommitted
        '---------------------------------------Estados y municipios
        Dim TablaEstados As New DataTable
        Dim EntidadLocalizacion As New Capa_Entidad.Localizacion
        Dim NegocioLocalizacion As New Capa_Negocio.Localizacion
        EntidadLocalizacion.IdConsulta = 2
        EntidadLocalizacion.IdEstado = CBEstado.SelectedValue
        NegocioLocalizacion.Consultar(EntidadLocalizacion)
        TablaEstados = EntidadLocalizacion.TablaConsulta
        CBMunicipio.DataSource = TablaEstados
        CBMunicipio.ValueMember = "IdMunicipio"
        CBMunicipio.DisplayMember = "Municipio"
        CBMunicipio.SelectedValue = -1
    End Sub
    Private Sub CBEstadoNac_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBEstadoNac.SelectionChangeCommitted
        '---------------------------------------Estados y municipios
        Dim TablaEstados As New DataTable
        Dim EntidadLocalizacion As New Capa_Entidad.Localizacion
        Dim NegocioLocalizacion As New Capa_Negocio.Localizacion
        EntidadLocalizacion.IdConsulta = 2
        EntidadLocalizacion.IdEstado = CBEstadoNac.SelectedValue
        NegocioLocalizacion.Consultar(EntidadLocalizacion)
        TablaEstados = EntidadLocalizacion.TablaConsulta
        CBMunicipioNac.DataSource = TablaEstados
        CBMunicipioNac.ValueMember = "IdMunicipio"
        CBMunicipioNac.DisplayMember = "Municipio"
        CBMunicipioNac.SelectedValue = -1
    End Sub

    'Private Sub CBEstadoNacCony_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    '---------------------------------------Estados y municipios
    '    Dim TablaEstados As New DataTable
    '    Dim EntidadLocalizacion As New Capa_Entidad.Localizacion
    '    Dim NegocioLocalizacion As New Capa_Negocio.Localizacion
    '    EntidadLocalizacion.IdConsulta = 2
    '    EntidadLocalizacion.IdEstado = CBEstadoNacCony.SelectedValue
    '    NegocioLocalizacion.Consultar(EntidadLocalizacion)
    '    TablaEstados = EntidadLocalizacion.TablaConsulta
    '    CBMunicipioNacCony.DataSource = TablaEstados
    '    CBMunicipioNacCony.ValueMember = "IdMunicipio"
    '    CBMunicipioNacCony.DisplayMember = "Municipio"
    '    CBMunicipioNacCony.SelectedValue = -1
    'End Sub
    Private Sub CBEstadoMatrimonioCony_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBEstadoMatrimonioCony.SelectionChangeCommitted
        '---------------------------------------Estados y municipios
        Dim TablaEstados As New DataTable
        Dim EntidadLocalizacion As New Capa_Entidad.Localizacion
        Dim NegocioLocalizacion As New Capa_Negocio.Localizacion
        EntidadLocalizacion.IdConsulta = 2
        EntidadLocalizacion.IdEstado = CBEstadoMatrimonioCony.SelectedValue
        NegocioLocalizacion.Consultar(EntidadLocalizacion)
        TablaEstados = EntidadLocalizacion.TablaConsulta
        CBMunicipioMatrimonioCony.DataSource = TablaEstados
        CBMunicipioMatrimonioCony.ValueMember = "IdMunicipio"
        CBMunicipioMatrimonioCony.DisplayMember = "Municipio"
        CBMunicipioMatrimonioCony.SelectedValue = -1
    End Sub
    Private Sub TBImporte_TextChanged(sender As Object, e As PreviewKeyDownEventArgs) Handles TBImporte.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            TBImporteLetra.Text = Letras(TBImporte.Text)
        End If
        TBImporteLetra.Text = TBImporteLetra.Text.ToUpper()
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
        Dim tabla As New DataTable
        Dim NombreCarpeta As String
        NombreCarpeta = TBIdCliente.Text + " " + TBNombre.Text + " " + TBSegNombre.Text + " " + TBApePaterno.Text + " " + TBApeMaterno.Text
        EntidadUbicacion.ConsultaUbicacion = 2
        NegocioUbicacion.Consultar(EntidadUbicacion)
        tabla = EntidadUbicacion.TablaUbicacionRegistrada
        If Not Directory.Exists(tabla.Rows(0).Item("ruta") & tabla.Rows(0).Item("NombreCarpetaRaiz") & "\" & NombreCarpeta) Then
            Directory.CreateDirectory(tabla.Rows(0).Item("ruta") & tabla.Rows(0).Item("NombreCarpetaRaiz") & "\" & NombreCarpeta & "\" & tabla.Rows(0).Item("NombreCarpetaPersonal"))
            Directory.CreateDirectory(tabla.Rows(0).Item("ruta") & tabla.Rows(0).Item("NombreCarpetaRaiz") & "\" & NombreCarpeta & "\" & tabla.Rows(0).Item("NombreCarpetaLote"))
        End If
        Process.Start("explorer.exe", (tabla.Rows(0).Item("ruta") & tabla.Rows(0).Item("NombreCarpetaRaiz") & "\" & NombreCarpeta))
    End Sub
    Private Sub Municipio()
        Dim TablaEstados As New DataTable
        Dim EntidadLocalizacion As New Capa_Entidad.Localizacion
        Dim NegocioLocalizacion As New Capa_Negocio.Localizacion
        EntidadLocalizacion.IdConsulta = 2
        EntidadLocalizacion.IdEstado = CBEstado.SelectedValue
        NegocioLocalizacion.Consultar(EntidadLocalizacion)
        TablaEstados = EntidadLocalizacion.TablaConsulta
        CBMunicipio.DataSource = TablaEstados
        CBMunicipio.ValueMember = "IdMunicipio"
        CBMunicipio.DisplayMember = "Municipio"
        CBMunicipio.SelectedValue = 1
    End Sub
    Private Sub MunicipioNacimiento()
        Dim TablaEstados As New DataTable
        Dim EntidadLocalizacion As New Capa_Entidad.Localizacion
        Dim NegocioLocalizacion As New Capa_Negocio.Localizacion
        EntidadLocalizacion.IdConsulta = 2
        EntidadLocalizacion.IdEstado = CBEstadoNac.SelectedValue
        NegocioLocalizacion.Consultar(EntidadLocalizacion)
        TablaEstados = EntidadLocalizacion.TablaConsulta
        CBMunicipioNac.DataSource = TablaEstados
        CBMunicipioNac.ValueMember = "IdMunicipio"
        CBMunicipioNac.DisplayMember = "Municipio"
        CBMunicipioNac.SelectedValue = 1
    End Sub
    Private Sub MunicipioMatrimonio()
        Dim TablaEstados As New DataTable
        Dim EntidadLocalizacion As New Capa_Entidad.Localizacion
        Dim NegocioLocalizacion As New Capa_Negocio.Localizacion
        EntidadLocalizacion.IdConsulta = 2
        EntidadLocalizacion.IdEstado = CBEstadoMatrimonioCony.SelectedValue
        NegocioLocalizacion.Consultar(EntidadLocalizacion)
        TablaEstados = EntidadLocalizacion.TablaConsulta
        CBMunicipioMatrimonioCony.DataSource = TablaEstados
        CBMunicipioMatrimonioCony.ValueMember = "IdMunicipio"
        CBMunicipioMatrimonioCony.DisplayMember = "Municipio"
        CBMunicipioMatrimonioCony.SelectedValue = 1
    End Sub
    Private Sub LlenarExcel()
        Dim tabla As New DataTable
        EntidadUbicacion.ConsultaUbicacion = 2
        NegocioUbicacion.Consultar(EntidadUbicacion)
        tabla = EntidadUbicacion.TablaUbicacionRegistrada
        Dim NombreCompleto As String
        Dim xlsApp As Excel.Application
        Dim xlsLibro As Excel.Workbook
        Dim xlsHoja As Excel.Worksheet
        NombreCompleto = TBIdCliente.Text + " " + TBNombre.Text + " " + TBSegNombre.Text + " " + TBApePaterno.Text + " " + TBApeMaterno.Text
        Dim Ruta As String = Replace(My.Computer.FileSystem.CurrentDirectory, tabla.Rows(0).Item("RutaSolicitudCredito"), "")
        'Dim Archivo1 As String = Ruta + "SOLICITUD DE  CREDITO.xlsx"
        Dim RutaGuardado As String = tabla.Rows(0).Item("Ruta") + tabla.Rows(0).Item("NombreCarpetaRaiz") + "\" + NombreCompleto + "\" + "SOLICITUD DE  CREDITO.xlsx"
        xlsApp = New Excel.Application()
        xlsLibro = xlsApp.Workbooks.Open(Ruta, True, True, , "")
        xlsHoja = xlsApp.Worksheets("Cuestionario")
        xlsHoja.Range("E4").Value = Now.Date.Day
        xlsHoja.Range("G4").Value = MesEnLetra(Now.ToString("MM"))
        xlsHoja.Range("J4").Value = Now.Date.Year
        xlsHoja.Range("J2").Value = TBIdCliente.Text
        xlsHoja.Range("C6").Value = TBNombre.Text
        xlsHoja.Range("D6").Value = TBSegNombre.Text
        xlsHoja.Range("G6").Value = TBApePaterno.Text
        xlsHoja.Range("H6").Value = TBApeMaterno.Text
        xlsHoja.Range("C8").Value = CBSexo.Text
        xlsHoja.Range("E8").Value = TBEdad.Text
        xlsHoja.Range("H8").Value = CBNacionalidadNac.Text
        xlsHoja.Range("C10").Value = TBRFC.Text
        xlsHoja.Range("G10").Value = TBCURP.Text
        xlsHoja.Range("E12").Value = Format(DTPFechaNacimiento.Value.Day)
        xlsHoja.Range("G12").Value = MesEnLetra(Format(DTPFechaNacimiento.Value.Month))
        xlsHoja.Range("J12").Value = Format(DTPFechaNacimiento.Value.Year)
        xlsHoja.Range("F22").Value = TBTelefono.Text
        xlsHoja.Range("G24").Value = TBImporte.Text + " " + CBTipoCambio.Text
        xlsHoja.Range("B25").Value = TBImporteLetra.Text + " " + CBTipoCambio.Text
        xlsHoja.Range("F27").Value = UCase(TBActividad.Text)
        xlsHoja.Range("C18").Value = TBCalle.Text
        xlsHoja.Range("G18").Value = TBColonia.Text
        xlsHoja.Range("J18").Value = TBNumero.Text
        xlsHoja.Range("B20").Value = UCase(TBPoblacion.Text)
        xlsHoja.Range("D20").Value = UCase(CBMunicipio.Text)
        xlsHoja.Range("G20").Value = CBEstado.Text
        xlsHoja.Range("E14").Value = UCase(CBMunicipioNac.Text + ", " + CBEstadoNac.Text)
        xlsHoja.Range("J20").Value = TBCP.Text
        xlsHoja.Range("C16").Value = CBEstadoCivil.Text
        xlsHoja.Range("G16").Value = CBRegimen.Text
        xlsHoja.Range("B91").Value = TBNombre.Text + " " + TBSegNombre.Text + " " + TBApePaterno.Text + " " + TBApeMaterno.Text
        'Datos del Conyugue------------------------------------------------------------------
        Dim index As Integer
        index = CBConyugue.SelectedIndex
        If CBConyugue.SelectedIndex <> -1 Then
            xlsHoja.Range("C29").Value = tabla5.Rows(index).Item("PrimerNombre")
            xlsHoja.Range("D29").Value = tabla5.Rows(index).Item("SegundoNombre")
            xlsHoja.Range("G29").Value = tabla5.Rows(index).Item("ApellidoPaterno")
            xlsHoja.Range("H29").Value = tabla5.Rows(index).Item("ApellidoMaterno")
            xlsHoja.Range("C31").Value = tabla5.Rows(index).Item("RFC")
            xlsHoja.Range("G31").Value = tabla5.Rows(index).Item("CURP")
            xlsHoja.Range("E33").Value = tabla5.Rows(index).Item("Dia")
            xlsHoja.Range("G33").Value = MesEnLetra(Format(tabla5.Rows(index).Item("Mes")))
            xlsHoja.Range("J33").Value = tabla5.Rows(index).Item("Anio")
            xlsHoja.Range("C35").Value = tabla5.Rows(index).Item("EstadoNacimiento") + " " + tabla5.Rows(index).Item("MunicipioNacimiento")
            xlsHoja.Range("H35").Value = tabla5.Rows(index).Item("Nacionalidad")
            xlsHoja.Range("E37").Value = tabla5.Rows(index).Item("DiaMatrimonio")
            xlsHoja.Range("G37").Value = tabla5.Rows(index).Item("MesMatrimonio")
            xlsHoja.Range("J37").Value = tabla5.Rows(index).Item("AnioMatrimonio")
            xlsHoja.Range("C39").Value = tabla5.Rows(index).Item("MunicipioMatrimonio") + " " + tabla5.Rows(index).Item("EstadoMatrimonio")
        End If
        'La siguiente instruccion indica donde guardaremos la informacion y con true confirmamos que queremos guardar
        xlsLibro.Close(SaveChanges:=True, Filename:=RutaGuardado)
        xlsApp.Quit()
        xlsHoja = Nothing
        xlsLibro = Nothing
        xlsApp = Nothing
    End Sub
    Public Function MesEnLetra(ByVal Mes As Integer) As String
        Dim MesLetra As String = ""
        If Mes = 1 Then
            MesLetra = "ENERO"
        End If
        If Mes = 2 Then
            MesLetra = "FEBRERO"
        End If
        If Mes = 3 Then
            MesLetra = "MARZO"
        End If
        If Mes = 4 Then
            MesLetra = "ABRIL"
        End If
        If Mes = 5 Then
            MesLetra = "MAYO"
        End If
        If Mes = 6 Then
            MesLetra = "JUNIO"
        End If
        If Mes = 7 Then
            MesLetra = "JULIO"
        End If
        If Mes = 8 Then
            MesLetra = "AGOSTO"
        End If
        If Mes = 9 Then
            MesLetra = "SEPTIEMBRE"
        End If
        If Mes = 10 Then
            MesLetra = "OCTUBRE"
        End If
        If Mes = 11 Then
            MesLetra = "NOVIEMBRE"
        End If
        If Mes = 12 Then
            MesLetra = "DICIEMBRE"
        End If
        Return MesLetra
    End Function
    Private Sub CargaConyugue()
        '..Conyugue-------------------------------------        
        EntidadPreregistro.ConsultaDocumentos = 3
        NegocioPreregistro.Consultar(EntidadPreregistro)
        tabla5 = EntidadPreregistro.TablaDocumentosRegistrados
        CBConyugue.DataSource = tabla5
        CBConyugue.ValueMember = "IdPersona"
        CBConyugue.DisplayMember = "Nombre"
        CBConyugue.SelectedValue = -1
    End Sub
End Class