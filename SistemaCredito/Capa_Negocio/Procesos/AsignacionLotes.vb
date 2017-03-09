Public Class AsignacionLotes
    Public Overridable Sub LLenaCombo(ByRef EntidadAsignacionLotes As Capa_Entidad.AsignacionLotes)
        Dim EntidadAsignacionLotes1 As New Capa_Entidad.AsignacionLotes()
        Dim DatosAsignacionLotes As New Capa_Datos.AsignacionLotes()
        EntidadAsignacionLotes1 = EntidadAsignacionLotes
        DatosAsignacionLotes.ConsultarCultivo(EntidadAsignacionLotes)
    End Sub
    Public Overridable Sub GuardarAsignacion(ByRef EntidadAsignacionLotes As Capa_Entidad.AsignacionLotes)
        Dim EntidadAsignacionLotes1 As New Capa_Entidad.AsignacionLotes()
        Dim DatosAsignacionLotes As New Capa_Datos.AsignacionLotes()
        EntidadAsignacionLotes1 = EntidadAsignacionLotes
        DatosAsignacionLotes.GuardaAsignacion(EntidadAsignacionLotes)
    End Sub
End Class
