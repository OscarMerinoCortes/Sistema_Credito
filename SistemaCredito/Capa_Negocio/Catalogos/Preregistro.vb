Public Class Preregistro
    Public Overridable Sub Guardar(ByRef EntidadPreregistro As Capa_Entidad.Preregistro)
        Dim EntidadPreregistro1 As New Capa_Entidad.Preregistro()
        Dim DatosPreregistro As New Capa_Datos.Preregistro()
        EntidadPreregistro1 = EntidadPreregistro
        DatosPreregistro.Upsert(EntidadPreregistro)
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadPreregistro As Capa_Entidad.Preregistro)
        Dim EntidadPreregistro1 As New Capa_Entidad.Preregistro()
        Dim DatosPreregistro As New Capa_Datos.Preregistro()
        EntidadPreregistro1 = EntidadPreregistro
        DatosPreregistro.ConsultarDocumentos(EntidadPreregistro)
    End Sub
End Class
