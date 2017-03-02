Public Class UbicacionDocumentos
    Public Overridable Sub Guardar(ByRef EntidadUbicacionDocumentos As Capa_Entidad.UbicacionDocumentos)
        Dim EntidadUbicacionDocumentos1 As New Capa_Entidad.UbicacionDocumentos()
        Dim DatosUbicacionDocumentos As New Capa_Datos.UbicacionDocumentos()
        EntidadUbicacionDocumentos1 = EntidadUbicacionDocumentos
        DatosUbicacionDocumentos.Upsert(EntidadUbicacionDocumentos)
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadUbicacionDocumentos As Capa_Entidad.UbicacionDocumentos)
        Dim EntidadUbicacionDocumentos1 As New Capa_Entidad.UbicacionDocumentos()
        Dim DatosUbicacionDocumentos As New Capa_Datos.UbicacionDocumentos()
        EntidadUbicacionDocumentos1 = EntidadUbicacionDocumentos
        DatosUbicacionDocumentos.Consultar(EntidadUbicacionDocumentos)
    End Sub
End Class
