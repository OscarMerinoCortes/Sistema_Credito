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
            cmdGuardar.Parameters.Add(New SqlParameter("@idPropietario", EntidadPreregistroLotes1.IdPropietario))
            cmdGuardar.Parameters.Add(New SqlParameter("@Nombre_Lote", EntidadPreregistroLotes1.NombreLote))
            cmdGuardar.Parameters.Add(New SqlParameter("@Colonia", EntidadPreregistroLotes1.IdColonia))
            cmdGuardar.Parameters.Add(New SqlParameter("@Folio_Lote", EntidadPreregistroLotes1.FolioLote))
            cmdGuardar.Parameters.Add(New SqlParameter("@SuperficieTotal", EntidadPreregistroLotes1.SuperficieTotal))
            cmdGuardar.Parameters.Add(New SqlParameter("@SuperficieSembrar", EntidadPreregistroLotes1.SuperficieSembrar))
            cmdGuardar.Parameters.Add(New SqlParameter("@SuperficieRestante", EntidadPreregistroLotes1.SuperficieRestante))
            cmdGuardar.Parameters.Add(New SqlParameter("@volumen", EntidadPreregistroLotes1.volumen))
            cmdGuardar.Parameters.Add(New SqlParameter("@Latitud_Grados", EntidadPreregistroLotes1.LatitudGrados))
            cmdGuardar.Parameters.Add(New SqlParameter("@Latitud_Horas", EntidadPreregistroLotes1.LatitudHoras))
            cmdGuardar.Parameters.Add(New SqlParameter("@Latitud_Minutos", EntidadPreregistroLotes1.LatitudMinutos))
            cmdGuardar.Parameters.Add(New SqlParameter("@Longitud_Grados", EntidadPreregistroLotes1.LongitudGrados))
            cmdGuardar.Parameters.Add(New SqlParameter("@Longitud_Horas", EntidadPreregistroLotes1.LongitudHoras))
            cmdGuardar.Parameters.Add(New SqlParameter("@Longitud_Minutos", EntidadPreregistroLotes1.LongitudMinutos))
            cmdGuardar.Parameters.Add(New SqlParameter("@Numero_RPP", EntidadPreregistroLotes1.NumeroRPP))
            cmdGuardar.Parameters.Add(New SqlParameter("@Folio_RPP", EntidadPreregistroLotes1.FolioRPP))
            cmdGuardar.Parameters.Add(New SqlParameter("@Libro_RPP", EntidadPreregistroLotes1.LibroRPP))
            cmdGuardar.Parameters.Add(New SqlParameter("@Fecha_RPP", EntidadPreregistroLotes1.FechaRPP))
            cmdGuardar.Parameters.Add(New SqlParameter("@Titulo_Agua", EntidadPreregistroLotes1.TituloAgua))
            cmdGuardar.Parameters.Add(New SqlParameter("@Regimen_Hidrico", EntidadPreregistroLotes1.RegimenHidrico))
            cmdGuardar.Parameters.Add(New SqlParameter("@Fecha_Titulo_Agua", EntidadPreregistroLotes1.FechaTituloAgua))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstado", EntidadPreregistroLotes1.IdEstado))
            If EntidadPreregistroLotes1.IdPreregistroLote = 0 Then
                cmdGuardar.Parameters("@IdPreregistroLote").Direction = ParameterDirection.InputOutput
            End If
            cmdGuardar.ExecuteNonQuery()
            EntidadPreregistroLotes1.IdPreregistroLote = cmdGuardar.Parameters("@IdPreregistroLote").Value
            For Each MiTableRow As DataRow In EntidadPreregistroLotes1.TablaDocumentosPropietarioGuardar.Rows
                cmdGuardar.CommandText = "Cre_InsPreLotDet"
                cmdGuardar.CommandType = CommandType.StoredProcedure
                cmdGuardar.Parameters.Clear()
                cmdGuardar.Parameters.Add(New SqlParameter("@IdPreregistroLoteDetalle", MiTableRow("IdPreregistroDetalle")))
                cmdGuardar.Parameters.Add(New SqlParameter("@IdPreregistroLote", EntidadPreregistroLotes1.IdPreregistroLote))
                cmdGuardar.Parameters.Add(New SqlParameter("@IdTipoDocumento", MiTableRow("IdDocumento")))
                cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatusDocumento", MiTableRow("IdEstatus")))
                cmdGuardar.Parameters.Add(New SqlParameter("@IdEstado", EntidadPreregistroLotes1.IdEstado))
                cmdGuardar.ExecuteNonQuery()
            Next
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
            Select Case EntidadPreregistroLotes1.ConsultaDocumentosPreregistroLotes
                Case 1
                    Dim cmd As New SqlCommand("sp_LlenarDocumentosPropietario", cnn)
                    cmd.CommandType = CommandType.StoredProcedure
                    Dim da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    EntidadPreregistroLotes1.TablaDocumentosPropietario = dt
                Case 2
                    Dim cmd As New SqlCommand("sp_LlenarDocumentosRegistradosLotes", cnn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add(New SqlClient.SqlParameter("@IdPreregistroLote", EntidadPreregistroLotes1.IdPreregistroLote))
                    Dim da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    EntidadPreregistroLotes1.TablaDocumentosPropietario = dt
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadPreregistroLotes = EntidadPreregistroLotes1
        End Try
    End Sub
    Public Overridable Sub ConsultarPreregistroLotes(ByRef EntidadPreregistroLotes As Capa_Entidad.PreregistroLotes)
        Dim EntidadPreregistroLotes1 As New Capa_Entidad.PreregistroLotes()
        EntidadPreregistroLotes1 = EntidadPreregistroLotes
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Dim cmd As New SqlCommand("sp_LlenarPreregistroLotes", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlClient.SqlParameter("@Nombre_lote", EntidadPreregistroLotes1.NombreLote))
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            EntidadPreregistroLotes1.TablaPreregistroLotes = dt
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadPreregistroLotes = EntidadPreregistroLotes1
        End Try
    End Sub
End Class
