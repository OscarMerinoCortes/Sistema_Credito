Imports System.Data.SqlClient
Public Class Preregistro
    Public Overridable Sub Upsert(ByRef EntidadPreregistro As Capa_Entidad.Preregistro)
        Dim EntidadPreregistro1 As New Capa_Entidad.Preregistro()
        EntidadPreregistro1 = EntidadPreregistro
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("Cre_InsPreCliEnc", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdCliente", EntidadPreregistro1.IdCliente))
            cmdGuardar.Parameters.Add(New SqlParameter("@Foto", SqlDbType.Image)).Value = EntidadPreregistro1.Foto
            cmdGuardar.Parameters.Add(New SqlParameter("@IdTipoPersona", EntidadPreregistro1.TipoPersona))
            cmdGuardar.Parameters.Add(New SqlParameter("@Fecha", EntidadPreregistro1.Fecha))
            cmdGuardar.Parameters.Add(New SqlParameter("@Nombre", EntidadPreregistro1.Nombre))
            cmdGuardar.Parameters.Add(New SqlParameter("@Telefono", EntidadPreregistro1.Telefono))
            cmdGuardar.Parameters.Add(New SqlParameter("@Correo", EntidadPreregistro1.Correo))
            cmdGuardar.Parameters.Add(New SqlParameter("@RFC", EntidadPreregistro1.RFC))
            cmdGuardar.Parameters.Add(New SqlParameter("@CURP", EntidadPreregistro1.CURP))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadPreregistro1.IdEstatus))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstadoCivil", EntidadPreregistro1.IdEstadoCivil))
            cmdGuardar.Parameters.Add(New SqlParameter("@EstadoCivil", EntidadPreregistro1.EstadoCivil))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdRegimen", EntidadPreregistro1.IdRegimen))
            cmdGuardar.Parameters.Add(New SqlParameter("@Regimen", EntidadPreregistro1.Regimen))
            cmdGuardar.Parameters.Add(New SqlParameter("@ImporteSolicitado", EntidadPreregistro1.ImporteSolicitado))
            cmdGuardar.Parameters.Add(New SqlParameter("@ImporteLetra", EntidadPreregistro1.ImporteLetra))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdTipoCambio", EntidadPreregistro1.IdTipoCambio))
            cmdGuardar.Parameters.Add(New SqlParameter("@ActividadHabitual", EntidadPreregistro1.ActividadHabitual))
            cmdGuardar.Parameters.Add(New SqlParameter("@Calle", EntidadPreregistro1.Calle))
            cmdGuardar.Parameters.Add(New SqlParameter("@Colonia", EntidadPreregistro1.Colonia))
            cmdGuardar.Parameters.Add(New SqlParameter("@Numero", EntidadPreregistro1.Numero))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstado", EntidadPreregistro1.IdEstado))
            cmdGuardar.Parameters.Add(New SqlParameter("@Estado", EntidadPreregistro1.Estado))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdMunicipio", EntidadPreregistro1.IdMunicipio))
            cmdGuardar.Parameters.Add(New SqlParameter("@Municipio", EntidadPreregistro1.Municipio))
            cmdGuardar.Parameters.Add(New SqlParameter("@Poblacion", EntidadPreregistro1.Poblacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@CodigoPostal", EntidadPreregistro1.CP))
            cmdGuardar.Parameters.Add(New SqlParameter("@SegundoNombre", EntidadPreregistro1.SegundoNombre))
            cmdGuardar.Parameters.Add(New SqlParameter("@ApellidoPaterno", EntidadPreregistro1.ApellidoPaterno))
            cmdGuardar.Parameters.Add(New SqlParameter("@ApellidoMaterno", EntidadPreregistro1.ApellidoMaterno))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdSexo", EntidadPreregistro1.IdSexo))
            cmdGuardar.Parameters.Add(New SqlParameter("@Sexo", EntidadPreregistro1.Sexo))
            cmdGuardar.Parameters.Add(New SqlParameter("@Edad", EntidadPreregistro1.Edad))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaNacimiento", EntidadPreregistro1.FechaNacimiento))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstadoNacimiento", EntidadPreregistro1.IdEstadoNacimiento))
            cmdGuardar.Parameters.Add(New SqlParameter("@EstadoNacimiento", EntidadPreregistro1.EstadoNacimiento))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdMunicipioNacimiento", EntidadPreregistro1.IdMunicipioNacimiento))
            cmdGuardar.Parameters.Add(New SqlParameter("@MunicipioNacimiento", EntidadPreregistro1.MunicipioNacimiento))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdNacionalidad", EntidadPreregistro1.IdNacionalidadNacimiento))
            cmdGuardar.Parameters.Add(New SqlParameter("@Nacionalidad", EntidadPreregistro1.Nacionalidad))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdConyugue", EntidadPreregistro1.CIdConyugue))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaMatrimonio", EntidadPreregistro1.CFechaMatrimonio))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstadoMatrimonio", EntidadPreregistro1.CIdEstadoMatrimonio))
            cmdGuardar.Parameters.Add(New SqlParameter("@EstadoMatrimonio", EntidadPreregistro1.EstadoMatrimonio))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdMunicipioMatrimonio", EntidadPreregistro1.CIdMunicipioMatrimonio))
            cmdGuardar.Parameters.Add(New SqlParameter("@MunicipioMatrimonio", EntidadPreregistro1.MunicipioMatrimonio))
            If EntidadPreregistro1.IdCliente = 0 Then
                cmdGuardar.Parameters("@IdCliente").Direction = ParameterDirection.InputOutput
            End If
            cmdGuardar.ExecuteNonQuery()
            EntidadPreregistro1.IdCliente = cmdGuardar.Parameters("@IdCliente").Value
            For Each MiTableRow As DataRow In EntidadPreregistro1.TablaDocumentosAgregados.Rows
                cmdGuardar.CommandText = "Cre_InsPreCliDet"
                cmdGuardar.CommandType = CommandType.StoredProcedure
                cmdGuardar.Parameters.Clear()
                cmdGuardar.Parameters.Add(New SqlParameter("@IdPreregistroDetalle", MiTableRow("IdPreregistroDetalle")))
                cmdGuardar.Parameters.Add(New SqlParameter("@IdCliente", EntidadPreregistro1.IdCliente))
                cmdGuardar.Parameters.Add(New SqlParameter("@IdTipoDocumento", MiTableRow("IdDocumento")))
                cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatusDocumento", MiTableRow("IdEstatus")))
                cmdGuardar.Parameters.Add(New SqlParameter("@IdEstado", EntidadPreregistro1.IdEstado))
                cmdGuardar.ExecuteNonQuery()
            Next
            If EntidadPreregistro1.TablaSocios.Rows.Count > 0 Then
                For Each MiTableRow As DataRow In EntidadPreregistro1.TablaSocios.Rows
                    cmdGuardar.CommandText = "Cre_InsPreCliDatAdi"
                    cmdGuardar.CommandType = CommandType.StoredProcedure
                    cmdGuardar.Parameters.Clear()
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdDatosAdicionales", MiTableRow("IdDatosAdicionales")))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdPersona", MiTableRow("IdPersona")))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdSociedad", EntidadPreregistro1.IdCliente))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdCargo", MiTableRow("IdCargo")))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", MiTableRow("IdEstatus")))
                    cmdGuardar.ExecuteNonQuery()
                Next
            End If
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadPreregistro = EntidadPreregistro1
        End Try
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadPreregistro As Capa_Entidad.Preregistro)
        Dim EntidadPreregistro1 As New Capa_Entidad.Preregistro()
        EntidadPreregistro1 = EntidadPreregistro
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadPreregistro1.ConsultaDocumentos
                Case 1
                    Dim cmd As New SqlCommand("sp_LlenarDocumentos", cnn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add(New SqlClient.SqlParameter("@TipoPersona", EntidadPreregistro1.TipoPersona))
                    Dim da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    EntidadPreregistro1.TablaDocumentos = dt
                Case 2
                    Dim cmd As New SqlCommand("sp_LlenarDocumentosRegistrados", cnn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add(New SqlClient.SqlParameter("@IdCliente", EntidadPreregistro1.IdCliente))
                    Dim da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    EntidadPreregistro1.TablaDocumentosRegistrados = dt
                Case 3 '---------------------------------------------------------------------LLENAR COMBOBOXS DE CLIENTES---------------------
                    Dim cmd As New SqlCommand("sp_LisCliMor", cnn)
                    cmd.CommandType = CommandType.StoredProcedure
                    Dim da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    EntidadPreregistro1.TablaDocumentosRegistrados = dt
                Case 4 '----------------------------------------------------------------
                    Dim cmd As New SqlCommand("sp_LisCliMorDatAdi", cnn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add(New SqlClient.SqlParameter("@IdCliente", EntidadPreregistro1.IdCliente))
                    Dim da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    EntidadPreregistro1.TablaDatosAdicionales = dt
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadPreregistro = EntidadPreregistro1
        End Try
    End Sub
    Public Overridable Sub ConsultarClientes(ByRef EntidadPreregistro As Capa_Entidad.Preregistro)
        Dim EntidadPreregistro1 As New Capa_Entidad.Preregistro()
        EntidadPreregistro1 = EntidadPreregistro
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Dim cmd As New SqlCommand("sp_LlenarClientes", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlClient.SqlParameter("@Nombre", IIf(EntidadPreregistro1.Nombre = Nothing, "", EntidadPreregistro1.Nombre)))
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            EntidadPreregistro1.TablaDatosDelCliente = dt
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadPreregistro = EntidadPreregistro1
        End Try
    End Sub

End Class
