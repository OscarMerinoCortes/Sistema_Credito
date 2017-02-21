Public Class AsignacionLotes
    Public Overridable Sub LLenaCombo(ByRef EntidadAsignacionLotes As Capa_Entidad.AsignacionLotes)
        Dim EntidadAsignacionLotes1 As New Capa_Entidad.AsignacionLotes()
        Dim DatosAsignacionLotes As New Capa_Datos.AsignacionLotes()
        EntidadAsignacionLotes1 = EntidadAsignacionLotes
        DatosAsignacionLotes.LlenaComboCultivos(EntidadAsignacionLotes)
    End Sub
End Class
