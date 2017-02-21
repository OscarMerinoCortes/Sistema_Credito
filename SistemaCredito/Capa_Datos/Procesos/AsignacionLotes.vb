Imports System.Data.SqlClient
Public Class AsignacionLotes
    Public Overridable Sub LlenaComboCultivos(ByRef EntidadAsignacionLotes As Capa_Entidad.AsignacionLotes)
        Dim EntidadAsignacionLotes1 As New Capa_Entidad.AsignacionLotes
        EntidadAsignacionLotes1 = EntidadAsignacionLotes
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Dim cmd As New SqlCommand("sp_LlenarCultivo", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            EntidadAsignacionLotes1.TablaComboCultivo = dt
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadAsignacionLotes = EntidadAsignacionLotes1
        End Try
    End Sub
End Class
