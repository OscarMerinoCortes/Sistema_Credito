Public Class PreregistroLotes
    Public Overridable Sub Guardar(ByRef EntidadPreregistroLotes As Capa_Entidad.PreregistroLotes)
        Dim EntidadPreregistroLotes1 As New Capa_Entidad.PreregistroLotes()
        Dim DatosPreregistroLotes As New Capa_Datos.PreregistroLotes()
        EntidadPreregistroLotes1 = EntidadPreregistroLotes
        DatosPreregistroLotes.Upsert(EntidadPreregistroLotes)
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadPreregistroLotes As Capa_Entidad.PreregistroLotes)
        Dim EntidadPreregistroLotes1 As New Capa_Entidad.PreregistroLotes()
        Dim DatosPreregistroLotes As New Capa_Datos.PreregistroLotes()
        EntidadPreregistroLotes1 = EntidadPreregistroLotes
        DatosPreregistroLotes.ConsultarDocumentosPropietario(EntidadPreregistroLotes)
    End Sub
    'Public Overridable Sub ConsultarClientes(ByRef EntidadPreregistro As Capa_Entidad.Preregistro)
    '    Dim EntidadPreregistro1 As New Capa_Entidad.Preregistro()
    '    Dim DatosPreregistro As New Capa_Datos.Preregistro()
    '    EntidadPreregistro1 = EntidadPreregistro
    '    DatosPreregistro.ConsultarClientes(EntidadPreregistro)
    'End Sub
End Class
