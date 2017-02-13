--sp_helptext sp_LlenarDocumentos
-------------------------------
ALTER PROCEDURE sp_LlenarDocumentosRegistrados 
--declare
@IdCliente int-- = 1
AS
SELECT
a.IdPreregistroDetalle as IdPreregistroDetalle,
a.IdTipoDocumento  as IdDocumento,
b.Descripcion as Documento,
a.IdEstatusDocumento as Estatus
       
FROM dbo.Cre_Preregistro_Cliente_Detalle a,
     dbo.Cre_Cat_Tipo_Documento b
     
WHERE a.IdEstado = 1
AND   IdCliente = @IdCliente
AND   a.IdTipoDocumento = b.IdTipoDocumento





