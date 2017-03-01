Public Class Preregistro
    Public IdCliente As Integer
    Public TipoPersona As String
    Public Foto() As Byte
    Public Nombre As String
    Public RepresentanteLegal As String
    Public RFC As String
    Public CURP As String
    Public Domicilio As String
    Public Telefono As String
    Public Correo As String
    Public Fecha As Date
    Public IdEstado As Integer
    Public EstadoCivil As String
    Public CredencialConyugue As String
    Public RFCConyugue As String
    Public CURPConyugue As String
    '----------------------------------------------SOCIOS PARA PERSONAS MORALES
    Public IdPresidente As Integer
    Public IdSecretario As Integer
    Public IdRepresentantreLegal As Integer
    Public IdTesorero As Integer
    Public TablaSocios As DataTable
    '------------------------------------------------------------
    Public TablaDocumentos As DataTable
    Public TablaDocumentosAgregados As DataTable
    Public TablaDocumentosRegistrados As DataTable
    Public TablaDatosDelCliente As DataTable
    Public TablaDatosAdicionales As DataTable
    '----------------------------------------------PARA LOS CASES
    Public ConsultaDocumentos As Integer
End Class
