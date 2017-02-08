ALTER PROCEDURE sp_LlenarDocumentos 
--declare
@TipoPersona varchar(1),--= 'M',
@IdEstatusDocumento bit = 0,
@IdPreregistroDetalle int = 0
AS
SELECT 
	@IdPreregistroDetalle as IdPreregistroDetalle,
	 IdTipoDocumento AS IdDocumento,
	 Descripcion AS Documento,
	 @IdEstatusDocumento as Estatus
	 --TipoPersona as TipoPersona
FROM dbo.Cre_Cat_Tipo_Documento
WHERE IdEstado = 1
AND   TipoPersona = @TipoPersona





