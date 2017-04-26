Create procedure sp_LisCliPorId
--declare
@IdCliente int-- = 1
as
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
where  a.IdCliente = @IdCliente
and a.IdEstatus = 1
