Imports System.Data.SqlClient
Public Class Documentos
    Public Overridable Sub Upsert(ByRef EntidadDocumentos As Capa_Entidad.Documentos)
        Dim EntidadDocumentos1 As New Capa_Entidad.Documentos()
        EntidadDocumentos1 = EntidadDocumentos
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("Cre_InsDoc", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdTipoDocumento", EntidadDocumentos1.IdTipoDocumento))
            cmdGuardar.Parameters.Add(New SqlParameter("@Descripcion", EntidadDocumentos1.Descripcion))
            cmdGuardar.Parameters.Add(New SqlParameter("@TipoPersona", EntidadDocumentos1.TipoPersona))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstado", EntidadDocumentos1.IdEstado))
            If EntidadDocumentos1.IdTipoDocumento = 0 Then
                cmdGuardar.Parameters("@IdTipoDocumento").Direction = ParameterDirection.InputOutput
            End If
            cmdGuardar.ExecuteNonQuery()
            EntidadDocumentos1.IdTipoDocumento = cmdGuardar.Parameters("@IdTipoDocumento").Value
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadDocumentos = EntidadDocumentos1
        End Try
    End Sub
    Public Overridable Sub ConsultarDocumentos(ByRef EntidadDocumentos As Capa_Entidad.Documentos)
        Dim EntidadDocumentos1 As New Capa_Entidad.Documentos()
        EntidadDocumentos1 = EntidadDocumentos
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Dim cmd As New SqlCommand("Cre_LlenarCatalogoDocumentos", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            EntidadDocumentos1.TablaDocumentosRegistrados = dt

        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadDocumentos = EntidadDocumentos1
        End Try
    End Sub
    Public Overridable Sub ConsultarClientes(ByRef EntidadPreregistro As Capa_Entidad.Preregistro)
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
    End Sub
End Class
