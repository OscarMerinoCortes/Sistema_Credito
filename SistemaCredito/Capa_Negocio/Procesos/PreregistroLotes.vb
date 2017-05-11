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
    Public Overridable Sub ConsultarPreregistroLotes(ByRef EntidadPreregistroLotes As Capa_Entidad.PreregistroLotes)
        Dim EntidadPreregistroLotes1 As New Capa_Entidad.PreregistroLotes()
        Dim DatosPreregistroLotes As New Capa_Datos.PreregistroLotes()
        EntidadPreregistroLotes1 = EntidadPreregistroLotes
        DatosPreregistroLotes.ConsultarPreregistroLotes(EntidadPreregistroLotes)
    End Sub
    Public Overridable Sub ConsultarAsignacionesLotes(ByRef EntidadPreregistroLotes As Capa_Entidad.PreregistroLotes)
        Dim EntidadPreregistroLotes1 As New Capa_Entidad.PreregistroLotes()
        Dim DatosPreregistroLotes As New Capa_Datos.PreregistroLotes()
        EntidadPreregistroLotes1 = EntidadPreregistroLotes
        DatosPreregistroLotes.ConsultarAsignacionesLotes(EntidadPreregistroLotes)
    End Sub
End Class
