alter procedure Cre_InsPreCliDet
@IdPreregistroDetalle int, 
@IdCliente int,
@IdTipoDocumento int,
@IdEstatusDocumento bit,
@IdEstado int
AS
BEGIN
SET NOCOUNT ON
MERGE [dbo].[Cre_Preregistro_Cliente_Detalle] AS TARGET
USING (SELECT @IdPreregistroDetalle,@IdCliente,@IdTipoDocumento,@IdEstatusDocumento,@IdEstado) AS SOURCE (IdPreregistroDetalle,IdCliente,IdTipoDocumento,IdEstatusDocumento,IdEstado)
ON (TARGET.IdPreregistroDetalle = SOURCE.IdPreregistroDetalle)
WHEN MATCHED THEN
UPDATE SET IdEstatusDocumento = Source.IdEstatusDocumento 
WHEN NOT MATCHED THEN
        INSERT (IdCliente,IdTipoDocumento, IdEstatusDocumento, IdEstado)
        VALUES (Source.IdCliente,Source.IdTipoDocumento, Source.IdEstatusDocumento, Source.IdEstado);
END 



--select*from [dbo].[Cre_Preregistro_Cliente_Encabezado]
--select*from [dbo].[Cre_Preregistro_Cliente_Detalle]