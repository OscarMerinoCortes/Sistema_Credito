Public Class Preregistro
    '-Datos generales de la persona---------------
    Public IdCliente As Integer
    Public Fecha As Date
    Public TipoPersona As String
    Public Foto() As Byte
    Public Nombre As String
    Public Telefono As String
    Public Correo As String
    Public RFC As String
    Public CURP As String
    Public IdEstatus As Integer
    Public IdEstadoCivil As String
    Public ImporteSolicitado As Double
    Public ImporteLetra As String
    Public IdTipoCambio As Integer
    Public ActividadHabitual As String
    Public Calle As String
    Public Colonia As String
    Public Numero As String
    Public IdEstado As Integer
    Public IdMunicipio As Integer
    Public Poblacion As String
    Public CP As Integer
    Public SegundoNombre As String
    Public ApellidoPaterno As String
    Public ApellidoMaterno As String
    Public IdSexo As Integer
    Public Edad As Integer
    Public FechaNacimiento As Date
    Public IdEstadoNacimiento As Integer
    Public IdMunicipioNacimiento As Integer
    Public IdNacionalidadNacimiento As Integer
    'Datos del conyugue----------   
    Public CIdConyugue As Integer
    Public CFechaMatrimonio As Date
    Public CIdEstadoMatrimonio As Integer
    Public CIdMunicipioMatrimonio As Integer
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
