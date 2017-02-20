CREATE procedure Cre_InsPreLotDet
@IdPreregistroLoteDetalle int, 
@IdPreregistroLote int,
@IdTipoDocumento int,
@IdEstatusDocumento bit,
@IdEstado int
AS
BEGIN
SET NOCOUNT ON
MERGE dbo.Cre_Preregistro_Lote_Detalle AS TARGET
USING (SELECT @IdPreregistroLoteDetalle,@IdPreregistroLote,@IdTipoDocumento,@IdEstatusDocumento,@IdEstado) AS SOURCE (IdPreregistroLoteDetalle,IdPreregistroLote,IdTipoDocumento,IdEstatusDocumento,IdEstado)
ON (TARGET.IdPreregistroLoteDetalle = SOURCE.IdPreregistroLoteDetalle)
WHEN MATCHED THEN
UPDATE SET IdEstatusDocumento = Source.IdEstatusDocumento 
WHEN NOT MATCHED THEN
        INSERT (IdPreregistroLote,IdTipoDocumento, IdEstatusDocumento, IdEstado)
        VALUES (Source.IdPreregistroLote,Source.IdTipoDocumento, Source.IdEstatusDocumento, Source.IdEstado);
END 



--truncate table [dbo].[Cre_Preregistro_Lote_Encabezado]

--select*from [dbo].[Cre_Preregistro_Lote_Encabezado]