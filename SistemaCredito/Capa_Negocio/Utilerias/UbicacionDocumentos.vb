Public Class UbicacionDocumentos
    Public Overridable Sub Guardar(ByRef EntidadPreregistro As Capa_Entidad.UbicacionDocumentos)
        Dim EntidadUbicacionDocumentos1 As New Capa_Entidad.UbicacionDocumentos()
        Dim DatosUbicacionDocumentos As New Capa_Datos.UbicacionDocumentos()
        EntidadUbicacionDocumentos1 = EntidadPreregistro
        DatosUbicacionDocumentos.Upsert(EntidadPreregistro)
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadPreregistro As Capa_Entidad.UbicacionDocumentos)
        Dim EntidadUbicacionDocumentos1 As New Capa_Entidad.UbicacionDocumentos()
        Dim DatosUbicacionDocumentos As New Capa_Datos.UbicacionDocumentos()
        EntidadUbicacionDocumentos1 = EntidadPreregistro
        DatosUbicacionDocumentos.Consultar(EntidadPreregistro)
    End Sub
    'Public Overridable Sub ConsultarUbicacion(ByRef EntidadPreregistro As Capa_Entidad.UbicacionDocumentos)
    '    Dim EntidadUbicacionDocumentos1 As New Capa_Entidad.UbicacionDocumentos()
    '    Dim DatosUbicacionDocumentos As New Capa_Datos.UbicacionDocumentos()
    '    EntidadUbicacionDocumentos1 = EntidadPreregistro
    '    DatosUbicacionDocumentos.ConsultarClientes(EntidadPreregistro)
    'End Sub

End Class
