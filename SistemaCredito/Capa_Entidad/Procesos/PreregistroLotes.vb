Public Class PreregistroLotes
    Public IdPreregistroLote As Integer
    Public Nombre As String
    Public CURP As String
    Public RFC As String
    Public Fecha As Date
    Public Lote As String
    Public Colonia As String
    Public SuperficieTotal As Double
    Public SuperficieSembrar As Double
    Public SuperficieRestante As Double
    Public FolioAserca As String
    Public Predio As String
    Public IdEstado As Integer
    '--------------------------------------------------
    Public TablaDocumentosPropietario As DataTable
    Public TablaDocumentosPropietarioGuardar As DataTable
    Public TablaPreregistroLotes As DataTable
    '----------------------------------------------PARA LOS CASES
    Public ConsultaDocumentosPreregistroLotes As Integer
End Class
