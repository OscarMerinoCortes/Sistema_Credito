ALTER PROCEDURE Cre_InsPreCliEnc
@IdCliente int output,
@Foto image,
@IdTipoPersona varchar(15),
@Nombre varchar(50),
@SegundoNombre varchar(25),
@ApellidoPaterno varchar(25),
@ApellidoMaterno varchar(25),
@IdSexo int,
@Sexo varchar(10),
@Edad int,
@FechaNacimiento date,
@IdEstadoNacimiento int,
@EstadoNacimiento varchar(30),
@IdMunicipioNacimiento int,
@MunicipioNacimiento varchar(30),
@IdNacionalidad int,
@Nacionalidad varchar(25),
@Telefono varchar(15),
@Correo varchar(50),
@RFC varchar(15),
@CURP varchar(25),
@IdEstatus int,
@IdEstadoCivil int,
@EstadoCivil varchar(30),
@IdRegimen int,
@Regimen varchar(30),
@ImporteSolicitado float,
@ImporteLetra varchar(200),
@IdTipoCambio int,
@ActividadHabitual varchar(200),
@Calle varchar(25),
@Colonia varchar(50),
@Numero int,
@IdEstado int,
@Estado varchar(30),
@IdMunicipio int,
@Municipio varchar(30),
@Poblacion varchar(50),
@CodigoPostal int,
@IdConyugue int,
@FechaMatrimonio date,
@IdEstadoMatrimonio int,
@EstadoMatrimonio varchar(30),
@IdMunicipioMatrimonio int,
@MunicipioMatrimonio varchar(30),
@Fecha datetime
AS
BEGIN
 SET NOCOUNT ON
    MERGE dbo.Cre_Preregistro_Cliente_Encabezado as TARGET
    USING(SELECT @IdCliente,@Foto,@IdTipoPersona,@Nombre,@SegundoNombre,@ApellidoPaterno,@ApellidoMaterno,@IdSexo,@Sexo,@Edad,@FechaNacimiento,
	@IdEstadoNacimiento,@EstadoNacimiento,@IdMunicipioNacimiento,@MunicipioNacimiento,@IdNacionalidad,@Nacionalidad,@Telefono,@Correo,@RFC,@CURP,@IdEstatus,@IdEstadoCivil,@EstadoCivil,@IdRegimen,@Regimen,@ImporteSolicitado,@ImporteLetra,
	@IdTipoCambio,@ActividadHabitual,@Calle,@Colonia,@Numero,@IdEstado,@Estado,@IdMunicipio,@Municipio,@Poblacion,@CodigoPostal,@IdConyugue,@FechaMatrimonio,@IdEstadoMatrimonio,@EstadoMatrimonio,@IdMunicipioMatrimonio,@MunicipioMatrimonio,@Fecha) 
	AS SOURCE(IdCliente,Foto,IdTipoPersona,Nombre,SegundoNombre,ApellidoPaterno,ApellidoMaterno,IdSexo,Sexo,Edad,FechaNacimiento,
	IdEstadoNacimiento,EstadoNacimiento,IdMunicipioNacimiento,MunicipioNacimiento,IdNacionalidad,Nacionalidad,Telefono,Correo,RFC,CURP,IdEstatus,IdEstadoCivil,EstadoCivil,IdRegimen,Regimen,ImporteSolicitado,ImporteLetra,
	IdTipoCambio,ActividadHabitual,Calle,Colonia,Numero,IdEstado,Estado,IdMunicipio,Municipio,Poblacion,CodigoPostal,IdConyugue,FechaMatrimonio,IdEstadoMatrimonio,EstadoMatrimonio,IdMunicipioMatrimonio,MunicipioMatrimonio,Fecha)
    ON (TARGET.IdCliente = SOURCE.IdCliente)
WHEN MATCHED THEN
UPDATE SET 
Foto = source.Foto,
IdTipoPersona = source.IdTipoPersona,
Nombre = source.Nombre,
SegundoNombre = source.SegundoNombre,
ApellidoPaterno = source.ApellidoPaterno,
ApellidoMaterno = source.ApellidoMaterno,
IdSexo = source.IdSexo,
Sexo = source.Sexo,
Edad = source.Edad,
FechaNacimiento = source.FechaNacimiento,
IdEstadoNacimiento = source.IdEstadoNacimiento,
EstadoNacimiento = source.EstadoNacimiento,
IdMunicipioNacimiento = source.IdMunicipioNacimiento,
MunicipioNacimiento = source.MunicipioNacimiento,
IdNacionalidad = source.IdNacionalidad,
Nacionalidad = source.Nacionalidad,
Telefono = source.Telefono,
Correo = source.Correo,
RFC = source.RFC,
CURP = source.CURP,
IdEstatus = source.IdEstatus,
IdEstadoCivil = source.IdEstadoCivil,
EstadoCivil = source.EstadoCivil,
IdRegimen = source.IdRegimen,
Regimen = source.Regimen,
ImporteSolicitado = source.ImporteSolicitado,
ImporteLetra = source.ImporteLetra,
IdTipoCambio = source.IdTIpoCambio,
ActividadHabitual = source.ActividadHabitual,
Calle = source.Calle,
Colonia = source.Colonia,
Numero = source.Numero,
IdEstado = source.IdEstado,
Estado = source.Estado,
IdMunicipio = source.IdMunicipio,
Municipio = source.Municipio,
Poblacion = source.Poblacion,
CodigoPostal = source.CodigoPostal,
IdConyugue = source.IdConyugue,
FechaMatrimonio = source.FechaMatrimonio,
IdEstadoMatrimonio = source.IdEstadoMatrimonio,
EstadoMatrimonio = source.EstadoMatrimonio,
IdMunicipioMatrimonio = source.IdMunicipioMatrimonio,
MunicipioMatrimonio = source.MunicipioMatrimonio,
Fecha = source.Fecha
WHEN NOT MATCHED THEN
        INSERT (
Foto,
IdTipoPersona,
Nombre,
SegundoNombre,
ApellidoPaterno,
ApellidoMaterno,
IdSexo,
Sexo,
Edad,
FechaNacimiento,
IdEstadoNacimiento,
EstadoNacimiento,
IdMunicipioNacimiento,
MunicipioNacimiento,
IdNacionalidad,
Nacionalidad,
Telefono,
Correo,
RFC,
CURP,
IdEstatus,
IdEstadoCivil,
EstadoCivil,
IdRegimen,
Regimen,
ImporteSolicitado,
ImporteLetra,
IdTipoCambio,
ActividadHabitual,
Calle,
Colonia,
Numero,
IdEstado,
Estado,
IdMunicipio,
Municipio,
Poblacion,
CodigoPostal,
IdConyugue,
FechaMatrimonio,
IdEstadoMatrimonio,
EstadoMatrimonio,
IdMunicipioMatrimonio,
MunicipioMatrimonio,
Fecha)
        VALUES (
source.Foto,
source.IdTipoPersona,
source.Nombre,
source.SegundoNombre,
source.ApellidoPaterno,
source.ApellidoMaterno,
source.IdSexo,
source.Sexo,
source.Edad,
source.FechaNacimiento,
source.IdEstadoNacimiento,
source.EstadoNacimiento,
source.IdMunicipioNacimiento,
source.MunicipioNacimiento,
source.IdNacionalidad,
source.Nacionalidad,
source.Telefono,
source.Correo,
source.RFC,
source.CURP,
source.IdEstatus,
source.IdEstadoCivil,
source.EstadoCivil,
source.IdRegimen,
source.Regimen,
source.ImporteSolicitado,
source.ImporteLetra,
source.IdTipoCambio,
source.ActividadHabitual,
source.Calle,
source.Colonia,
source.Numero,
source.IdEstado,
source.Estado,
source.IdMunicipio,
source.Municipio,
source.Poblacion,
source.CodigoPostal,
source.IdConyugue,
source.FechaMatrimonio,
source.IdEstadoMatrimonio,
source.EstadoMatrimonio,
source.IdMunicipioMatrimonio,
source.MunicipioMatrimonio,
source.Fecha);
		SET @IdCliente = SCOPE_IDENTITY()				
END
RETURN @IdCliente		