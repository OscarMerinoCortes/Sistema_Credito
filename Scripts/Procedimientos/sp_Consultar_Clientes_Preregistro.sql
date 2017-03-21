ALTER procedure sp_LlenarClientes
--declare
@Nombre varchar(50)-- =  'isela '
as
IF @Nombre <> ''
BEGIN
select IdCliente,
	   Foto,
	   IdTipoPersona,
	   Nombre,
	   SegundoNombre,
	   ApellidoPaterno,
	   ApellidoMaterno,
	   IdSexo,
	   Edad,
	   FechaNacimiento,
	   IdEstadoNacimiento,
	   IdMunicipioNacimiento,
	   IdNacionalidad,
	   Telefono,	  
	   Correo,	   
	   RFC,
	   CURP,
	   IdEstatus,
	   IdEstadoCivil,
	   ImporteSolicitado,
	   ImporteLetra,
	   IdTipoCambio,
	   ActividadHabitual,
	   Calle,
	   Colonia,
	   Numero,
	   IdEstado,
	   IdMunicipio,
	   Poblacion,
	   CodigoPostal,
	   IdConyugue,
	   FechaMatrimonio,
	   IdEstadoMatrimonio,
	   IdMunicipioMatrimonio,
	   Fecha	  
from   dbo.Cre_Preregistro_Cliente_Encabezado a
where  Nombre+' '+SegundoNombre+' '+ApellidoPaterno+' '+ApellidoMaterno  like '%'+@Nombre+'%'
and a.IdEstatus = 1
END  
ELSE
BEGIN select 
	   IdCliente,
	   Foto,
	   IdTipoPersona,
	   Nombre,
	   SegundoNombre,
	   ApellidoPaterno,
	   ApellidoMaterno,
	   IdSexo,
	   Edad,
	   FechaNacimiento,
	   IdEstadoNacimiento,
	   IdMunicipioNacimiento,
	   IdNacionalidad,
	   Telefono,	  
	   Correo,	   
	   RFC,
	   CURP,
	   IdEstatus,
	   IdEstadoCivil,
	   ImporteSolicitado,
	   ImporteLetra,
	   IdTipoCambio,
	   ActividadHabitual,
	   Calle,
	   Colonia,
	   Numero,
	   IdEstado,
	   IdMunicipio,
	   Poblacion,
	   CodigoPostal,
	   IdConyugue,
	   FechaMatrimonio,
	   IdEstadoMatrimonio,
	   IdMunicipioMatrimonio,
	   Fecha	     	   
from   [dbo].[Cre_Preregistro_Cliente_Encabezado] a
where  a.IdEstatus = 1
END