Public Class TipoUsuario
    Public Overridable Sub Guardar(ByRef EntidadTipoUsuario As Capa_Entidad.TipoUsuario)
        Dim EntidadTipoUsuario1 As New Capa_Entidad.TipoUsuario()
        Dim DatosTipoUsuario As New Capa_Datos.TipoUsuario()
        EntidadTipoUsuario1 = EntidadTipoUsuario
        DatosTipoUsuario.Upsert(EntidadTipoUsuario)
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadTipoUsuario As Capa_Entidad.TipoUsuario)
        Dim EntidadTipoUsuario1 As New Capa_Entidad.TipoUsuario()
        Dim DatosTipoUsuario As New Capa_Datos.TipoUsuario()
        EntidadTipoUsuario1 = EntidadTipoUsuario
        DatosTipoUsuario.Consultar(EntidadTipoUsuario)
    End Sub
End Class
