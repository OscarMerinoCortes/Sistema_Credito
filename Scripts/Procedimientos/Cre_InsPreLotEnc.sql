USE CREDITO
GO
/****** Object:  StoredProcedure dbo.Cre_InsPreLotEnc    Script Date: 24/02/2017 12:34:12 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE dbo.Cre_InsPreLotEnc
--declare
@IdPreregistroLote int output,
@idPropietario int,
@Nombre_Lote varchar(20),
@Colonia int,
@Folio_Lote varchar(20),
@SuperficieTotal decimal(10,3),
@SuperficieSembrar decimal(10,3),
@SuperficieRestante decimal(10,3),
@Volumen float,
@Latitud_Grados float,
@Latitud_Horas float,
@Latitud_Minutos float,
@Longitud_Grados float,
@Longitud_Horas float,
@Longitud_Minutos float,
@Numero_RPP int,
@Folio_RPP int,
@Libro_RPP int,
@Fecha_RPP datetime,
@Titulo_Agua varchar(15),
@Regimen_Hidrico varchar(12),
@Fecha_Titulo_Agua datetime,
@IdEstado int
AS
BEGIN
 SET NOCOUNT ON
    MERGE dbo.Cre_Preregistro_Lote_Encabezado as TARGET
    USING(SELECT @IdPreregistroLote
				,@Nombre_Lote
				,@idPropietario
				,@Colonia
				,@Folio_Lote
				,@SuperficieTotal
				,@SuperficieSembrar
				,@SuperficieRestante
				,@Volumen
				,@Latitud_Grados
				,@Latitud_Horas
				,@Latitud_Minutos
				,@Longitud_Grados
				,@Longitud_Horas
				,@Longitud_Minutos
				,@Numero_RPP
				,@Folio_RPP
				,@Libro_RPP
				,@Fecha_RPP
				,@Titulo_Agua
				,@Regimen_Hidrico
				,@Fecha_Titulo_Agua
				,@IdEstado) 
				AS 
		SOURCE(IdPreregistroLote
			 , Nombre_Lote
			 , Id_Propietario
			 , Colonia
			 , Folio_Lote
			 , SuperficieTotal
			 , SuperficieSembrar
			 , SuperficieRestante
			 , Volumen
			 , Latitud_Grados
			 , Latitud_Horas
			 , Latitud_Minutos
			 , Longitud_Grados
			 , Longitud_Horas
			 , Longitud_Minutos
			 , Numero_RPP
			 , Folio_RPP
			 , Libro_RPP
			 , Fecha_RPP
			 , Titulo_Agua
			 , Regimen_Hidrico
			 , Fecha_Titulo_Agua
			 , IdEstado)
    ON (TARGET.IdPreregistroLote = SOURCE.IdPreregistroLote)
WHEN MATCHED THEN
UPDATE SET id_Propietario = Source.id_Propietario, 
		   Nombre_Lote = source.Nombre_Lote,
		   Colonia = Source.Colonia,
		   Folio_Lote = Source.Folio_Lote,
		   SuperficieTotal = Source.SuperficieTotal,
		   SuperficieSembrar = Source.SuperficieSembrar,
		   SuperficieRestante = Source.SuperficieRestante,
		   volumen = source.volumen,
		   Latitud_Grados = source.Latitud_Grados,
		   Latitud_Horas = source.Latitud_Horas,
		   Latitud_Minutos = source.Latitud_Minutos,
		   Longitud_Grados = source.Longitud_Grados,
		   Longitud_Horas = source.Longitud_Horas,
		   Longitud_Minutos = source.Longitud_Minutos,
		   Numero_RPP = source.Numero_RPP,
		   Folio_RPP = source.Folio_RPP,
		   Libro_RPP = source.Libro_RPP,
		   Fecha_RPP = source.Fecha_RPP,
		   Titulo_Agua = source.Titulo_Agua,
		   Regimen_Hidrico = source.Regimen_Hidrico,
		   Fecha_Titulo_Agua = source.Fecha_Titulo_Agua,
		   IdEstado = Source.IdEstado
WHEN NOT MATCHED THEN
        INSERT (Nombre_Lote
			 , Id_Propietario
			 , Colonia
			 , Folio_Lote
			 , SuperficieTotal
			 , SuperficieSembrar
			 , SuperficieRestante
			 , Volumen
			 , Latitud_Grados
			 , Latitud_Horas
			 , Latitud_Minutos
			 , Longitud_Grados
			 , Longitud_Horas
			 , Longitud_Minutos
			 , Numero_RPP
			 , Folio_RPP
			 , Libro_RPP
			 , Fecha_RPP
			 , Titulo_Agua
			 , Regimen_Hidrico
			 , Fecha_Titulo_Agua
			 , IdEstado)
        VALUES (source.Nombre_Lote
			 , source.Id_Propietario
			 , source.Colonia
			 , source.Folio_Lote
			 , source.SuperficieTotal
			 , source.SuperficieSembrar
			 , source.SuperficieRestante
			 , source.Volumen
			 , source.Latitud_Grados
			 , source.Latitud_Horas
			 , source.Latitud_Minutos
			 , source.Longitud_Grados
			 , source.Longitud_Horas
			 , source.Longitud_Minutos
			 , source.Numero_RPP
			 , source.Folio_RPP
			 , source.Libro_RPP
			 , source.Fecha_RPP
			 , source.Titulo_Agua
			 , source.Regimen_Hidrico
			 , source.Fecha_Titulo_Agua
			 , source.IdEstado);
		SET @IdPreregistroLote = SCOPE_IDENTITY()				
END
RETURN @IdPreregistroLote	