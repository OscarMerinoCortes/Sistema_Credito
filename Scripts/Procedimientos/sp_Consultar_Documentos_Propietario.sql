CREATE PROCEDURE sp_LlenarDocumentosPropietario 
--declare
@IdEstatusDocumento bit = 0,
@IdPreregistroDetalle int = 0
AS
SELECT 
	 @IdPreregistroDetalle as IdPreregistroDetalle,
	 IdTipoDocumentoPropietario AS IdDocumento,
	 Descripcion AS Documento,
	 @IdEstatusDocumento as Estatus	
FROM dbo.Cre_Cat_Tipo_Documento_Propietario
WHERE IdEstado = 1





