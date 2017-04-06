Imports System.Data.SqlClient
Public Class CambiarPassword
    Public Overridable Sub Actualizar(ByRef EntidadCambiarPassword As Capa_Entidad.CambiarPassword)
        Dim EntidadCambiarPassword1 As New Capa_Entidad.CambiarPassword
        EntidadCambiarPassword1 = EntidadCambiarPassword
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_UpdPass", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@Usuario", EntidadCambiarPassword1.Usuario))
            cmdGuardar.Parameters.Add(New SqlParameter("@Password", EntidadCambiarPassword1.Password))
            cmdGuardar.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadCambiarPassword = EntidadCambiarPassword1
        End Try
    End Sub
End Class
