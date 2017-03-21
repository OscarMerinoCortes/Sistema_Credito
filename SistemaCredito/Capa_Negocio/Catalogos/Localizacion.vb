Public Class Localizacion
    Public Overridable Sub Consultar(ByRef EntidadLocalizacion As Capa_Entidad.Localizacion)
        Dim EntidadLocalizacion1 As New Capa_Entidad.Localizacion()
        Dim DatosLocalizacion As New Capa_Datos.Localizacion()
        EntidadLocalizacion1 = EntidadLocalizacion
        DatosLocalizacion.Consultar(EntidadLocalizacion)
    End Sub
End Class
