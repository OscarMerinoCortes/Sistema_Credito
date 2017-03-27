alter procedure sp_LisCliMor
as
declare @DatosAdicionales int = 0
select
     @DatosAdicionales as IdDatosAdicionales,
     [IdCliente] as IdPersona,
     [Nombre]+' '+SegundoNombre+' '+ApellidoPaterno+' '+ApellidoMaterno as Nombre,
	 Nombre as PrimerNombre,
	 SegundoNombre,
	 ApellidoPaterno,
	 ApellidoMaterno,
	 RFC,
	 CURP,
	 DATEPART(DAY,FechaNacimiento) AS Dia,	
	 DATEPART(MONTH,FechaNacimiento) AS Mes,
	 DATEPART(YEAR,FechaNacimiento) AS Anio,
	 EstadoNacimiento,
	 MunicipioNacimiento,
	 Nacionalidad,
	 EstadoCivil,
	 Regimen,
	 DATEPART(DAY,FechaMatrimonio) AS DiaMatrimonio,	
	 DATEPART(MONTH,FechaNacimiento) AS MesMatrimonio,
	 DATEPART(YEAR,FechaNacimiento) AS AnioMatrimonio,
	 EstadoMatrimonio,
	 MunicipioMatrimonio
from dbo.Cre_Preregistro_Cliente_Encabezado
where IdEstatus = 1
and   IdTipoPersona = 'FISICA'

