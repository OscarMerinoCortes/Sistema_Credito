Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel
Class CargaExcel
    Public Overridable Sub CargaExcelMetodo(ByRef EntidadPreregistro As Capa_Entidad.Preregistro)
        Dim EntidadPreregistro1 As New Capa_Entidad.Preregistro()
        EntidadPreregistro1 = EntidadPreregistro
        Try
            Dim xlsApp As Excel.Application
            Dim xlsLibro As Excel.Workbook
            Dim xlsHoja As Excel.Worksheet
            Dim Ruta As String = Replace(My.Computer.FileSystem.CurrentDirectory, "bin\Debug", "")
            Dim Archivo1 As String = Ruta + "SOLICITUD DE  CREDITO.xlsx"
            Dim RutaGuardado As String = "\\192.168.10.29\Scanner\CREDITO SOFOM 2017" + "\" + "6 OSCAR" + "\" + "SOLICITUD DE  CREDITO.xlsx"

            'Dim Archivo2 As String = Ruta + "MiExcel2.xlsx"
            xlsApp = New Excel.Application()
            xlsLibro = xlsApp.Workbooks.Open(Archivo1, True, True, , "")
            xlsHoja = xlsApp.Worksheets("Cuestionario")

            'Pasar valores del excel a variables
            'Dim Campo1 As String = xlsHoja.Cells(4, 5).Text
            'Dim Campo2 As String = xlsHoja.Cells(1, 2).Text
            'Dim Campo3 As String = xlsHoja.Cells(1, 3).Text

            'MessageBox.Show(Campo1 + " " + Campo2 + " " + Campo3)

            'Cambiar valores de las celdas del excel
            'xlsHoja.Cells(2, 2) = 5
            'xlsHoja.Cells(2, 3) = 6
            xlsHoja.Cells(2, 10) = EntidadPreregistro.IdCliente
            'xlsHoja.Cells(4, 5) = EntidadPreregistro.TipoPersona
            'xlsHoja.Cells(4, 5) = EntidadPreregistro.Fecha
            xlsHoja.Cells(6, 3) = EntidadPreregistro.Nombre
            xlsHoja.Cells(6, 4) = EntidadPreregistro.SegundoNombre
            xlsHoja.Cells(6, 7) = EntidadPreregistro.ApellidoPaterno
            xlsHoja.Cells(4, 8) = EntidadPreregistro.ApellidoMaterno
            xlsHoja.Cells(8, 3) = IIf(EntidadPreregistro.IdSexo = 0, "No aplica", IIf(EntidadPreregistro.IdSexo = 1, "Hombre", "Mujer"))
            xlsHoja.Cells(8, 5) = EntidadPreregistro.Edad
            xlsHoja.Cells(8, 8) = IIf(EntidadPreregistro.IdNacionalidadNacimiento = 1, "Mexicano(a) por nacimiento", "Estadounidense por nacimiento")
            xlsHoja.Cells(10, 3) = EntidadPreregistro.RFC
            xlsHoja.Cells(10, 7) = EntidadPreregistro.CURP
            xlsHoja.Cells(22, 3) = EntidadPreregistro.Telefono
            'xlsHoja.Cells(4, 5) = EntidadPreregistro.Correo
            'xlsHoja.Cells(4, 5) = EntidadPreregistro.IdEstatus
            'xlsHoja.Cells(4, 5) = EntidadPreregistro.IdEstadoCivil
            xlsHoja.Cells(24, 7) = EntidadPreregistro.ImporteSolicitado
            xlsHoja.Cells(25, 2) = EntidadPreregistro.ImporteLetra
            'xlsHoja.Cells(4, 5) = EntidadPreregistro.IdTipoCambio
            xlsHoja.Cells(27, 6) = EntidadPreregistro.ActividadHabitual
            xlsHoja.Cells(18, 3) = EntidadPreregistro.Calle
            xlsHoja.Cells(18, 7) = EntidadPreregistro.Colonia
            xlsHoja.Cells(18, 10) = EntidadPreregistro.Numero
            'xlsHoja.Cells(4, 5) = EntidadPreregistro.IdEstado
            'xlsHoja.Cells(4, 5) = EntidadPreregistro.IdMunicipio
            'xlsHoja.Cells(4, 5) = EntidadPreregistro.Poblacion
            xlsHoja.Cells(20, 10) = EntidadPreregistro.CP
            'xlsHoja.Cells(4, 5) = EntidadPreregistro.FechaNacimiento
            'xlsHoja.Cells(4, 5) = EntidadPreregistro.IdEstadoNacimiento
            'xlsHoja.Cells(4, 5) = EntidadPreregistro.IdMunicipioNacimiento
            'xlsHoja.Cells(4, 5) = EntidadPreregistro.CIdConyugue
            'xlsHoja.Cells(4, 5) = EntidadPreregistro.CFechaMatrimonio
            'xlsHoja.Cells(4, 5) = EntidadPreregistro.CIdEstadoMatrimonio
            'xlsHoja.Cells(4, 5) = EntidadPreregistro.CIdMunicipioMatrimonio

            'La siguiente instruccion indica donde guardaremos la informacion y con true confirmamos que queremos guardar
            xlsLibro.Close(SaveChanges:=True, Filename:=RutaGuardado)

            xlsApp.Quit()
            xlsHoja = Nothing
            xlsLibro = Nothing
            xlsApp = Nothing
        Catch ex As Exception
        End Try
    End Sub
End Class
