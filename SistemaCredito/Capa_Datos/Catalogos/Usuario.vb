Imports System.Data.SqlClient
Public Class Usuario
    Public Overridable Sub Upsert(ByRef EntidadUsuario As Capa_Entidad.Usuario)
        Dim EntidadUsuario1 As New Capa_Entidad.Usuario
        EntidadUsuario1 = EntidadUsuario
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsUsuDet", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuario", EntidadUsuario1.IdUsuario))
            cmdGuardar.Parameters.Add(New SqlParameter("@Nombre", EntidadUsuario1.Nombre))
            cmdGuardar.Parameters.Add(New SqlParameter("@Usuario", EntidadUsuario1.Usuario))
            cmdGuardar.Parameters.Add(New SqlParameter("@Password", EntidadUsuario1.Password))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdTipoUsuario", EntidadUsuario1.IdTipoUsuario))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadUsuario1.IdEstatus))
            If EntidadUsuario1.IdUsuario = 0 Then
                cmdGuardar.Parameters("@IdUsuario").Direction = ParameterDirection.InputOutput
            End If
            cmdGuardar.ExecuteNonQuery()
            EntidadUsuario1.IdUsuario = cmdGuardar.Parameters("@IdUsuario").Value
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadUsuario = EntidadUsuario1
        End Try
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadUsuario As Capa_Entidad.Usuario)
        Dim EntidadUsuario1 As New Capa_Entidad.Usuario
        EntidadUsuario1 = EntidadUsuario
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadUsuario1.IdTipoConsulta
                Case 1
                    Dim cmd As New SqlCommand("sp_LisUsuDet", cnn)
                    cmd.CommandType = CommandType.StoredProcedure
                    Dim da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    EntidadUsuario1.tabla = dt
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
            EntidadUsuario = EntidadUsuario1
        End Try
    End Sub
End Class
