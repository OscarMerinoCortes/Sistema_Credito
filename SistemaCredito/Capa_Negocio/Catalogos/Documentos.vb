Public Class Documentos
    Public Overridable Sub Guardar(ByRef EntidadDocumentos As Capa_Entidad.Documentos)
        Dim EntidadDocumentos1 As New Capa_Entidad.Documentos()
        Dim DatosDocumentos As New Capa_Datos.Documentos()
        EntidadDocumentos1 = EntidadDocumentos
        DatosDocumentos.Upsert(EntidadDocumentos)
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadDocumentos As Capa_Entidad.Documentos)
        Dim EntidadDocumentos1 As New Capa_Entidad.Documentos()
        Dim DatosDocumentos As New Capa_Datos.Documentos()
        EntidadDocumentos1 = EntidadDocumentos
        DatosDocumentos.ConsultarDocumentos(EntidadDocumentos)
    End Sub
    Public Overridable Sub ConsultarClientes(ByRef EntidadDocumentos As Capa_Entidad.Documentos)
        Dim EntidadDocumentos1 As New Capa_Entidad.Documentos()
        Dim DatosDocumentos As New Capa_Datos.Documentos()
        EntidadDocumentos1 = EntidadDocumentos
        DatosDocumentos.Upsert(EntidadDocumentos)
    End Sub
End Class
