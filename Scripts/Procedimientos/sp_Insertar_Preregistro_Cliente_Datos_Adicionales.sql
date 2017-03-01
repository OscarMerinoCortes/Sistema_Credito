ALTER procedure Cre_InsPreCliDatAdi
@IdDatosAdicionales int, 
@IdPersona int,
@IdSociedad int,
@IdCargo int,
@IdEstatus bit
AS
BEGIN
SET NOCOUNT ON
MERGE dbo.Cre_Preregistro_Cliente_Datos_Adicionales AS TARGET
USING (SELECT @IdDatosAdicionales,@IdPersona,@IdSociedad,@IdCargo,@IdEstatus) AS SOURCE (IdDatosAdicionales,IdPersona,IdSociedad,IdCargoSociedad,IdEstatus)
ON (TARGET.IdDatosAdicionales = SOURCE.IdDatosAdicionales)
WHEN MATCHED THEN
UPDATE SET IdEstatus = Source.IdEstatus 
WHEN NOT MATCHED THEN
        INSERT (IdPersona,IdSociedad, IdCargoSociedad, IdEstatus)
        VALUES (Source.IdPersona,Source.IdSociedad, Source.IdCargoSociedad, Source.IdEstatus);
END