CREATE PROCEDURE Cre_InsPreProEnc
--declare
@IdCliente int output,
@Nombre varchar(50),--= 'ab',
@TipoPersona varchar(15),--='fisica',
@Foto image,
@RFC varchar(15),--='ab',
@CURP varchar(25),--='ab',
@Telefono varchar(15),--='ab',
@Correo varchar(50),--='ab',
@Fecha datetime,--=getdate(),
@IdTipoCultivo int,-- int=1,
@IdEstado int--=1
AS
BEGIN
 SET NOCOUNT ON
    MERGE dbo.Cre_Preregistro_Cliente_Encabezado as TARGET
    USING(SELECT @IdCliente, @Nombre,@TipoPersona,@Foto,@RFC,@CURP,@Telefono,@Correo,@Fecha,@IdTipoCultivo,@IdEstado) AS SOURCE(IdCliente, Nombre, TipoPersona, Foto, RFC, CURP, Telefono, Correo, Fecha, IdTipoCultivo, IdEstado)
    ON (TARGET.IdCliente = SOURCE.IdCliente)
WHEN MATCHED THEN
UPDATE SET Nombre = Source.Nombre, 
           TipoPersona = Source.TipoPersona,
		   Foto = Source.Foto,
		   RFC = Source.RFC,
		   CURP = Source.CURP,
		   Telefono = Source.Telefono,
		   Correo = Source.Correo,
		   Fecha = Source.Fecha,
		   IdTipoCultivo = Source.IdTipoCultivo,
		   IdEstado = Source.IdEstado
WHEN NOT MATCHED THEN
        INSERT (Nombre, TipoPersona, Foto, RFC, CURP, Telefono, Correo, Fecha, IdTipoCultivo, IdEstado)
        VALUES (Source.Nombre, Source.TipoPersona, Source.Foto, Source.RFC, Source.CURP, Source.Telefono, Source.Correo, Source.Fecha, Source.IdTipoCultivo, Source.IdEstado);
		SET @IdCliente = SCOPE_IDENTITY()				
END
RETURN @IdCliente		