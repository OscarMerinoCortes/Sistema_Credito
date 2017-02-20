Imports System.Data.SqlClient
Public Class PreregistroLotes
    Public Overridable Sub Upsert(ByRef EntidadPreregistroLotes As Capa_Entidad.PreregistroLotes)
        Dim EntidadPreregistroLotes1 As New Capa_Entidad.PreregistroLotes()
        EntidadPreregistroLotes1 = EntidadPreregistroLotes
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("Cre_InsPreLotEnc", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdPreregistroLote", EntidadPreregistroLotes1.IdPreregistroLote))
            cmdGuardar.Parameters.Add(New SqlParameter("@NombrePropietario", EntidadPreregistroLotes1.Nombre))
            cmdGuardar.Parameters.Add(New SqlParameter("@RFC", EntidadPreregistroLotes1.RFC))
            cmdGuardar.Parameters.Add(New SqlParameter("@CURP", EntidadPreregistroLotes1.CURP))
            cmdGuardar.Parameters.Add(New SqlParameter("@Lote", EntidadPreregistroLotes1.Lote))
            cmdGuardar.Parameters.Add(New SqlParameter("@Colonia", EntidadPreregistroLotes1.Colonia))
            cmdGuardar.Parameters.Add(New SqlParameter("@SuperficieTotal", EntidadPreregistroLotes1.SuperficieTotal))
            cmdGuardar.Parameters.Add(New SqlParameter("@SuperficieSembrar", EntidadPreregistroLotes1.SuperficieSembrar))
            cmdGuardar.Parameters.Add(New SqlParameter("@SuperficieRestante", EntidadPreregistroLotes1.SuperficieRestante))
            cmdGuardar.Parameters.Add(New SqlParameter("@FolioAserca", EntidadPreregistroLotes1.FolioAserca))
            cmdGuardar.Parameters.Add(New SqlParameter("@Predio", EntidadPreregistroLotes1.Predio))
            cmdGuardar.Parameters.Add(New SqlParameter("@Fecha", EntidadPreregistroLotes1.Fecha))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstado", EntidadPreregistroLotes1.idEstado))
            If EntidadPreregistroLotes1.IdPreregistroLote = 0 Then
                cmdGuardar.Parameters("@IdPreregistroLote").Direction = ParameterDirection.InputOutput
            End If
            cmdGuardar.ExecuteNonQuery()
            EntidadPreregistroLotes1.IdPreregistroLote = cmdGuardar.Parameters("@IdPreregistroLote").Value
            'For Each MiTableRow As DataRow In EntidadPreregistroLotes1.TablaDocumentosPropietario.Rows
            '    cmdGuardar.CommandText = "Cre_InsPreCliDet"
            '    cmdGuardar.CommandType = CommandType.StoredProcedure
            '    cmdGuardar.Parameters.Clear()
            '    cmdGuardar.Parameters.Add(New SqlParameter("@IdPreregistroDetalle", MiTableRow("IdPreregistroDetalle")))
            '    cmdGuardar.Parameters.Add(New SqlParameter("@IdCliente", EntidadPreregistro1.IdCliente))
            '    cmdGuardar.Parameters.Add(New SqlParameter("@IdTipoDocumento", MiTableRow("IdDocumento")))
            '    cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatusDocumento", MiTableRow("IdEstatus")))
            '    cmdGuardar.Parameters.Add(New SqlParameter("@IdEstado", EntidadPreregistro1.IdEstado))
            '    cmdGuardar.ExecuteNonQuery()
            'Next
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadPreregistroLotes = EntidadPreregistroLotes1
        End Try
    End Sub
    Public Overridable Sub ConsultarDocumentosPropietario(ByRef EntidadPreregistroLotes As Capa_Entidad.PreregistroLotes)
        Dim EntidadPreregistroLotes1 As New Capa_Entidad.PreregistroLotes()
        EntidadPreregistroLotes1 = EntidadPreregistroLotes
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadPreregistroLotes1.ConsultaDocumentosPropietario
                Case 1
                    Dim cmd As New SqlCommand("sp_LlenarDocumentosPropietario", cnn)
                    cmd.CommandType = CommandType.StoredProcedure
                    Dim da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    EntidadPreregistroLotes1.TablaDocumentosPropietario = dt
                Case 2
                    'Dim cmd As New SqlCommand("sp_LlenarDocumentosRegistrados", cnn)
                    'cmd.CommandType = CommandType.StoredProcedure
                    'cmd.Parameters.Add(New SqlClient.SqlParameter("@IdCliente", EntidadPreregistro1.IdCliente))
                    'Dim da As New SqlDataAdapter(cmd)
                    'Dim dt As New DataTable
                    'da.Fill(dt)
                    'EntidadPreregistro1.TablaDocumentosRegistrados = dt
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadPreregistroLotes = EntidadPreregistroLotes1
        End Try
    End Sub
    'Public Overridable Sub ConsultarClientes(ByRef EntidadPreregistro As Capa_Entidad.Preregistro)
    '    Dim EntidadPreregistro1 As New Capa_Entidad.Preregistro()
    '    EntidadPreregistro1 = EntidadPreregistro
    '    Dim cnn As New SqlConnection(conexionPrincipal)
    '    Try
    '        cnn.Open()
    '        Dim cmd As New SqlCommand("sp_LlenarClientes", cnn)
    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.Parameters.Add(New SqlClient.SqlParameter("@Nombre", EntidadPreregistro1.Nombre))
    '        Dim da As New SqlDataAdapter(cmd)
    '        Dim dt As New DataTable
    '        da.Fill(dt)
    '        EntidadPreregistro1.TablaDatosDelCliente = dt
    '    Catch ex As Exception
    '    Finally
    '        cnn.Close()
    '        EntidadPreregistro = EntidadPreregistro1
    '    End Try
    'End Sub
End Class
