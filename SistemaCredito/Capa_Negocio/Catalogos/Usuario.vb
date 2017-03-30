Public Class Usuario
    Public Overridable Sub Guardar(ByRef EntidadUsuario As Capa_Entidad.Usuario)
        Dim EntidadUsuario1 As New Capa_Entidad.Usuario
        Dim DatosUsuario As New Capa_Datos.Usuario
        EntidadUsuario1 = EntidadUsuario
        DatosUsuario.Upsert(EntidadUsuario)
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadUsuario As Capa_Entidad.Usuario)
        Dim EntidadUsuario1 As New Capa_Entidad.Usuario
        Dim DatosUsuario As New Capa_Datos.Usuario
        EntidadUsuario1 = EntidadUsuario
        DatosUsuario.Consultar(EntidadUsuario)
    End Sub
End Class
