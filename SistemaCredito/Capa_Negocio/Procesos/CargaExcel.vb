Public Class CargaExcel
    Public Overridable Sub llenarExcel(ByRef EntidadPreregistro As Capa_Entidad.Preregistro)
        Dim EntidadPreregistro1 As New Capa_Entidad.Preregistro()
        Dim DatosPreregistro As New Capa_Datos.Preregistro()
        EntidadPreregistro1 = EntidadPreregistro
        DatosPreregistro.CargaExcelMetodo(EntidadPreregistro)
    End Sub
End Class
