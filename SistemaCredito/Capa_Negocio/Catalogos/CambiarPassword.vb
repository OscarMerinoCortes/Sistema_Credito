Public Class CambiarPassword
    Public Overridable Sub Actualizar(ByRef EntidadCambiarPassword As Capa_Entidad.CambiarPassword)
        Dim EntidadCambiarPassword1 As New Capa_Entidad.CambiarPassword
        Dim DatosCambiarPassword As New Capa_Datos.CambiarPassword
        EntidadCambiarPassword1 = EntidadCambiarPassword
        DatosCambiarPassword.Actualizar(EntidadCambiarPassword)
    End Sub
End Class
