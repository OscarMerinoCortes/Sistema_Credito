Imports System.Data.SqlClient
Public Class UbicacionDocumentos
    Public Overridable Sub Upsert(ByRef EntidadUbicacionDocumentos As Capa_Entidad.UbicacionDocumentos)
        Dim EntidadUbicacionDocumentos1 As New Capa_Entidad.UbicacionDocumentos()
        EntidadUbicacionDocumentos1 = EntidadUbicacionDocumentos
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("Cre_InsUbiDoc", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUbicacion", EntidadUbicacionDocumentos1.IdUbicacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@Ruta", EntidadUbicacionDocumentos1.Ruta))
            cmdGuardar.Parameters.Add(New SqlParameter("@NombreCarpetaRaiz", EntidadUbicacionDocumentos1.NombreCarpetaRaiz))
            cmdGuardar.Parameters.Add(New SqlParameter("@NombreCarpetaPersonal", EntidadUbicacionDocumentos1.NombreCarpetaPersonal))
            cmdGuardar.Parameters.Add(New SqlParameter("@NombreCarpetaLote", EntidadUbicacionDocumentos1.NombreCarpetaLotes))

            If EntidadUbicacionDocumentos1.IdUbicacion = 0 Then
                cmdGuardar.Parameters("@IdUbicacion").Direction = ParameterDirection.InputOutput
            End If
            cmdGuardar.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadUbicacionDocumentos = EntidadUbicacionDocumentos1
        End Try
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadUbicacionDocumentos As Capa_Entidad.UbicacionDocumentos)
        Dim EntidadUbicacionDocumentos1 As New Capa_Entidad.UbicacionDocumentos()
        EntidadUbicacionDocumentos1 = EntidadUbicacionDocumentos
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadUbicacionDocumentos1.ConsultaUbicacion
                Case 1
                    Dim cmd As New SqlCommand("sp_LlenarUbicacion", cnn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add(New SqlClient.SqlParameter("@IdUbicacion", EntidadUbicacionDocumentos1.IdUbicacion))
                    Dim da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    EntidadUbicacionDocumentos1.TablaUbicacionRegistrada = dt
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadUbicacionDocumentos = EntidadUbicacionDocumentos1
        End Try
    End Sub
End Class
