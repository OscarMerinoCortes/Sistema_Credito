Imports System.Data.SqlClient
Public Class Localizacion
    Public Overridable Sub Consultar(ByRef EntidadLocalizacion As Capa_Entidad.Localizacion)
        Dim EntidadLocalizacion1 As New Capa_Entidad.Localizacion()
        EntidadLocalizacion1 = EntidadLocalizacion
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadLocalizacion1.IdConsulta
                Case 1
                    Dim cmd As New SqlCommand("sp_ListaEstados", cnn)
                    cmd.CommandType = CommandType.StoredProcedure
                    'cmd.Parameters.Add(New SqlClient.SqlParameter("@TipoPersona", EntidadLocalizacion1.TipoPersona))
                    Dim da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    EntidadLocalizacion1.TablaConsulta = dt
                Case 2
                    Dim cmd As New SqlCommand("sp_ListaMunicipios", cnn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add(New SqlClient.SqlParameter("@IdEstado", EntidadLocalizacion1.IdEstado))
                    Dim da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    EntidadLocalizacion1.TablaConsulta = dt
                    'Case 3 '---------------------------------------------------------------------LLENAR COMBOBOXS DE CLIENTES---------------------
                    '    Dim cmd As New SqlCommand("sp_LisCliMor", cnn)
                    '    cmd.CommandType = CommandType.StoredProcedure
                    '    Dim da As New SqlDataAdapter(cmd)
                    '    Dim dt As New DataTable
                    '    da.Fill(dt)
                    '    EntidadPreregistro1.TablaDocumentosRegistrados = dt
                    'Case 4 '----------------------------------------------------------------
                    '    Dim cmd As New SqlCommand("sp_LisCliMorDatAdi", cnn)
                    '    cmd.CommandType = CommandType.StoredProcedure
                    '    cmd.Parameters.Add(New SqlClient.SqlParameter("@IdCliente", EntidadPreregistro1.IdCliente))
                    '    Dim da As New SqlDataAdapter(cmd)
                    '    Dim dt As New DataTable
                    '    da.Fill(dt)
                    '    EntidadPreregistro1.TablaDatosAdicionales = dt
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadLocalizacion = EntidadLocalizacion1
        End Try
    End Sub
End Class
