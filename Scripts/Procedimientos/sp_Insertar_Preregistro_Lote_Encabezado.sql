ALTER PROCEDURE Cre_InsPreLotEnc
--declare
@IdPreregistroLote int output,
@NombrePropietario varchar(50),
@RFC varchar(30),
@CURP varchar(30),
@Lote varchar(10),
@Colonia varchar(30),
@SuperficieTotal float,
@SuperficieSembrar float,
@SuperficieRestante float,
@FolioAserca varchar(50),
@Predio varchar(15),
@Fecha datetime,
@IdEstado int
AS
BEGIN
 SET NOCOUNT ON
    MERGE dbo.Cre_Preregistro_Lote_Encabezado as TARGET
    USING(SELECT @IdPreregistroLote,@NombrePropietario,@RFC,@CURP,@Lote,@Colonia,@SuperficieTotal,@SuperficieSembrar,@SuperficieRestante,@FolioAserca,@Predio,@Fecha,@IdEstado) AS SOURCE(IdPreregistroLote,NombrePropietario,RFC,CURP,Lote,Colonia,SuperficieTotal,SuperficieSembrar,SuperficieRestante,FolioAserca,Predio,Fecha,IdEstado)
    ON (TARGET.IdPreregistroLote = SOURCE.IdPreregistroLote)
WHEN MATCHED THEN
UPDATE SET NombrePropietario = Source.NombrePropietario, 
           RFC = Source.RFC,
		   CURP = Source.CURP,
		   Lote = Source.Lote,
		   Colonia = Source.Colonia,
		   SuperficieTotal = Source.SuperficieTotal,
		   SuperficieSembrar = Source.SuperficieSembrar,
		   SuperficieRestante = Source.SuperficieRestante,
		   FolioAserca = Source.FolioAserca,
		   Predio = Source.IdEstado,
		   Fecha = Source.Fecha,
		   IdEstado = Source.IdEstado
WHEN NOT MATCHED THEN
        INSERT (NombrePropietario, RFC, CURP, Lote, Colonia, SuperficieTotal, SuperficieSembrar, SuperficieRestante, FolioAserca, Predio, Fecha, IdEstado)
        VALUES (Source.NombrePropietario, Source.RFC, Source.CURP, Source.Lote, Source.Colonia, Source.SuperficieTotal, Source.SuperficieSembrar, Source.SuperficieRestante, Source.FolioAserca, Source.Predio, Source.Fecha, Source.IdEstado);
		SET @IdPreregistroLote = SCOPE_IDENTITY()				
END
RETURN @IdPreregistroLote	