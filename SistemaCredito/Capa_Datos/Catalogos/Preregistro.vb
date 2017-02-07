Imports System.Data.SqlClient
Public Class Preregistro
    Public Overridable Sub Upsert(ByRef EntidadPreregistro As Capa_Entidad.Preregistro)
        Dim EntidadPreregistro1 As New Capa_Entidad.Preregistro()
        EntidadPreregistro1 = EntidadPreregistro
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("PV_InsCliDet", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdCliente", EntidadPreregistro1.IdCliente))
            cmdGuardar.Parameters.Add(New SqlParameter("@Foto", SqlDbType.Image)).Value = EntidadPreregistro1.Foto
            cmdGuardar.Parameters.Add(New SqlParameter("@Nombre", EntidadPreregistro1.Nombre))
            cmdGuardar.Parameters.Add(New SqlParameter("@RFC", EntidadPreregistro1.RFC))
            cmdGuardar.Parameters.Add(New SqlParameter("@CURP", EntidadPreregistro1.CURP))
            cmdGuardar.Parameters.Add(New SqlParameter("@Telefono", EntidadPreregistro1.Telefono))
            cmdGuardar.Parameters.Add(New SqlParameter("@Correo", EntidadPreregistro1.Correo))
            cmdGuardar.Parameters.Add(New SqlParameter("@Fecha", EntidadPreregistro1.Fecha))
            cmdGuardar.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadPreregistro = EntidadPreregistro1
        End Try
    End Sub
    Public Overridable Sub ConsultarDocumentos(ByRef EntidadPreregistro As Capa_Entidad.Preregistro)
        Dim EntidadPreregistro1 As New Capa_Entidad.Preregistro()
        EntidadPreregistro1 = EntidadPreregistro
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Dim cmd As New SqlCommand("sp_LlenarDocumentos", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlClient.SqlParameter("@TipoPersona", EntidadPreregistro1.TipoPersona))
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            EntidadPreregistro1.TablaDocumentos = dt
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadPreregistro = EntidadPreregistro1
        End Try
    End Sub
End Class
