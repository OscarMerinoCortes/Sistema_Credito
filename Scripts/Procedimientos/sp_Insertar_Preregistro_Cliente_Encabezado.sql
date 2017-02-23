--sp_helptext Cre_InsPreCliEnc
------------------
ALTER PROCEDURE Cre_InsPreCliEnc
--declare
@IdCliente int output,
@Nombre varchar(50),--= 'ab',
@RepresentanteLegal varchar(50),
@TipoPersona varchar(15),--='fisica',
@Foto image,
@RFC varchar(15),--='ab',
@CURP varchar(25),--='ab',
@Domicilio varchar(50),
@Telefono varchar(15),--='ab',
@Correo varchar(50),--='ab',
@Fecha datetime,--=getdate(),
@IdTipoCultivo int,-- int=1,
@IdEstado int--=1
AS
BEGIN
 SET NOCOUNT ON
    MERGE dbo.Cre_Preregistro_Cliente_Encabezado as TARGET
    USING(SELECT @IdCliente, @Nombre,@RepresentanteLegal,@TipoPersona,@Foto,@RFC,@Domicilio,@CURP,@Telefono,@Correo,@Fecha,@IdTipoCultivo,@IdEstado) AS SOURCE(IdCliente, Nombre, RepresentanteLegal, TipoPersona, Foto, RFC, CURP, Domicilio, Telefono, Correo, Fecha, IdTipoCultivo, IdEstado)
    ON (TARGET.IdCliente = SOURCE.IdCliente)
WHEN MATCHED THEN
UPDATE SET Nombre = Source.Nombre, 
		   RepresentanteLegal = source.RepresentanteLegal,
           TipoPersona = Source.TipoPersona,
		   Foto = Source.Foto,
		   RFC = Source.RFC,
		   CURP = Source.CURP,
		   Domicilio = source.Domicilio,
		   Telefono = Source.Telefono,
		   Correo = Source.Correo,
		   Fecha = Source.Fecha,
		   IdTipoCultivo = Source.IdTipoCultivo,
		   IdEstado = Source.IdEstado
WHEN NOT MATCHED THEN
        INSERT (Nombre, RepresentanteLegal, TipoPersona, Foto, RFC, CURP, Domicilio, Telefono, Correo, Fecha, IdTipoCultivo, IdEstado)
        VALUES (Source.Nombre, Source.RepresentanteLegal, Source.TipoPersona, Source.Foto, Source.RFC, Source.Domicilio, Source.CURP, Source.Telefono, Source.Correo, Source.Fecha, Source.IdTipoCultivo, Source.IdEstado);
		SET @IdCliente = SCOPE_IDENTITY()				
END
RETURN @IdCliente		