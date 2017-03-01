ALTER PROCEDURE Cre_InsPreCliEnc
@IdCliente int output,
@Nombre varchar(50),
@TipoPersona varchar(15),
@Foto image,
@RFC varchar(15),
@CURP varchar(25),
@Domicilio varchar(50),
@Telefono varchar(15),
@Correo varchar(50),
@Fecha datetime,
@EstadoCivil varchar(30),
@CredencialConyugue varchar(30),
@RFCConyugue varchar(30),
@CURPConyugue varchar(30),
@IdEstado int
AS
BEGIN
 SET NOCOUNT ON
    MERGE dbo.Cre_Preregistro_Cliente_Encabezado as TARGET
    USING(SELECT @IdCliente, @Nombre,@TipoPersona,@Foto,@RFC,@CURP,@Domicilio,@Telefono,@Correo,@Fecha, @EstadoCivil,@CredencialConyugue,@RFCConyugue,@CURPConyugue,@IdEstado) AS SOURCE(IdCliente, Nombre, TipoPersona, Foto, RFC, CURP, Domicilio, Telefono, Correo, Fecha, EstadoCivil, CredencialConyugue, RfcConyugue, CurpConyugue, IdEstado)
    ON (TARGET.IdCliente = SOURCE.IdCliente)
WHEN MATCHED THEN
UPDATE SET Nombre = Source.Nombre, 
           TipoPersona = Source.TipoPersona,
		   Foto = Source.Foto,
		   RFC = Source.RFC,
		   CURP = Source.CURP,
		   Domicilio = source.Domicilio,
		   Telefono = Source.Telefono,
		   Correo = Source.Correo,
		   Fecha = Source.Fecha,
		   EstadoCivil = source.EstadoCivil,
		   CredencialConyugue = source.CredencialConyugue,
		   RfcConyugue = source.RfcConyugue,
		   CurpConyugue = source.CurpConyugue,		   
		   IdEstado = Source.IdEstado
WHEN NOT MATCHED THEN
        INSERT (Nombre, TipoPersona, Foto, RFC, CURP, Domicilio, Telefono, Correo, Fecha, EstadoCivil, CredencialConyugue, RfcConyugue, CurpConyugue, IdEstado)
        VALUES (Source.Nombre, Source.TipoPersona, Source.Foto, Source.RFC, Source.Domicilio, Source.CURP, Source.Telefono, Source.Correo, Source.Fecha, source.EstadoCivil ,source.CredencialConyugue,source.CurpConyugue,source.CurpConyugue, Source.IdEstado);
		SET @IdCliente = SCOPE_IDENTITY()				
END
RETURN @IdCliente		