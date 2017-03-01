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
            cmdGuardar.Parameters.Add(New SqlParameter("@Nombre", EntidadPreregistro1.Nombre))
            cmdGuardar.Parameters.Add(New SqlParameter("@TipoPersona", EntidadPreregistro1.TipoPersona))
            cmdGuardar.Parameters.Add(New SqlParameter("@RFC", EntidadPreregistro1.RFC))
            cmdGuardar.Parameters.Add(New SqlParameter("@Domicilio", EntidadPreregistro1.Domicilio))
            cmdGuardar.Parameters.Add(New SqlParameter("@CURP", EntidadPreregistro1.CURP))
            cmdGuardar.Parameters.Add(New SqlParameter("@Telefono", EntidadPreregistro1.Telefono))
            cmdGuardar.Parameters.Add(New SqlParameter("@Correo", EntidadPreregistro1.Correo))
            cmdGuardar.Parameters.Add(New SqlParameter("@Fecha", EntidadPreregistro1.Fecha))
            cmdGuardar.Parameters.Add(New SqlParameter("@EstadoCivil", EntidadPreregistro1.EstadoCivil))
            cmdGuardar.Parameters.Add(New SqlParameter("@CredencialConyugue", EntidadPreregistro1.CredencialConyugue))
            cmdGuardar.Parameters.Add(New SqlParameter("@RFCConyugue", EntidadPreregistro1.RFCConyugue))
            cmdGuardar.Parameters.Add(New SqlParameter("@CURPConyugue", EntidadPreregistro1.CURPConyugue))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstado", EntidadPreregistro1.IdEstado))
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
