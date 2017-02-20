CREATE PROCEDURE sp_LlenarDocumentosRegistradosLotes 
--declare
@IdPreregistroLote int = 1
AS
SELECT
a.IdPreregistroLoteDetalle as IdPreregistroDetalle,
a.IdTipoDocumento  as IdDocumento,
b.Descripcion as Documento,
a.IdEstatusDocumento as Estatus
       
FROM [dbo].[Cre_Preregistro_Lote_Detalle] a,
     [dbo].[Cre_Cat_Tipo_Documento_Propietario] b     
WHERE a.IdEstado = 1
AND   IdPreregistroLote = @IdPreregistroLote
AND   a.IdTipoDocumento = b.IdTipoDocumentoPropietario





