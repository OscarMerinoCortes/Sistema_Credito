Imports System.Data.SqlClient
Public Class TipoUsuario
    Public Overridable Sub Upsert(ByRef EntidadTipoUsuario As Capa_Entidad.TipoUsuario)
        Dim EntidadTipoUsuario1 As New Capa_Entidad.TipoUsuario()
        EntidadTipoUsuario1 = EntidadTipoUsuario
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsTipUsu", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdTipoUsuario", EntidadTipoUsuario1.IdTipoUsuario))
            cmdGuardar.Parameters.Add(New SqlParameter("@Descripcion", EntidadTipoUsuario1.Descripcion))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadTipoUsuario1.IdEstatus))
            If EntidadTipoUsuario1.IdTipoUsuario = 0 Then
                cmdGuardar.Parameters("@IdTipoUsuario").Direction = ParameterDirection.InputOutput
            End If
            cmdGuardar.ExecuteNonQuery()
            EntidadTipoUsuario1.IdTipoUsuario = cmdGuardar.Parameters("@IdTipoUsuario").Value
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadTipoUsuario = EntidadTipoUsuario1
        End Try
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadTipoUsuario As Capa_Entidad.TipoUsuario)
        Dim EntidadTipoUsuario1 As New Capa_Entidad.TipoUsuario
        EntidadTipoUsuario1 = EntidadTipoUsuario
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadTipoUsuario1.IdTipoConsulta
                Case 1
                    Dim cmd As New SqlCommand("sp_LisTipUsu", cnn)
                    cmd.CommandType = CommandType.StoredProcedure
                    Dim da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    EntidadTipoUsuario1.tabla = dt
                    'Case 2
                    '    Dim cmd As New SqlCommand("sp_LlenarDocumentosRegistrados", cnn)
                    '    cmd.CommandType = CommandType.StoredProcedure
                    '    cmd.Parameters.Add(New SqlClient.SqlParameter("@IdCliente", EntidadPreregistro1.IdCliente))
                    '    Dim da As New SqlDataAdapter(cmd)
                    '    Dim dt As New DataTable
                    '    da.Fill(dt)
                    '    EntidadPreregistro1.TablaDocumentosRegistrados = dt
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
            EntidadTipoUsuario = EntidadTipoUsuario1
        End Try
    End Sub
End Class
