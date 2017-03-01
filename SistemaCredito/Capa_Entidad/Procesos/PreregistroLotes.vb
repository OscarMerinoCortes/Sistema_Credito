Public Class PreregistroLotes
    Public IdPreregistroLote As Integer
    Public NombreLote As String
    Public IdColonia As Integer
    Public IdPropietario As Integer
    Public FolioLote As String
    Public SuperficieTotal As Double
    Public SuperficieSembrar As Double
    Public SuperficieRestante As Double
    Public volumen As Double
    Public LatitudGrados As Double
    Public LatitudHoras As Double
    Public LatitudMinutos As Double
    Public LongitudHoras As Double
    Public LongitudGrados As Double
    Public LongitudMinutos As Double
    Public FolioRPP As Integer
    Public LibroRPP As Integer
    Public NumeroRPP As Integer
    Public FechaRPP As Date
    Public TituloAgua As String
    Public RegimenHidrico As String
    Public FechaTituloAgua As Date
    Public IdEstado As Integer
    '--------------------------------------------------
    Public TablaDocumentosPropietario As DataTable
    Public TablaDocumentosPropietarioGuardar As DataTable
    Public TablaPreregistroLotes As DataTable
    '----------------------------------------------PARA LOS CASES
    Public ConsultaDocumentosPreregistroLotes As Integer
End Class
