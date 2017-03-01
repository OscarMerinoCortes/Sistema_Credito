ALTER procedure sp_LlenarClientes
--declare
@Nombre varchar(50)-- =  'WALL'
as
IF @Nombre <> ''
BEGIN
select IdCliente as IdCliente,
	   Nombre as Nombre,	  
	   TipoPersona as TipoPersona,
	   Foto as Foto,
	   RFC as RFC,
	   CURP as CURP,
	   Domicilio as Domicilio,
	   Telefono as Telefono,
	   Correo as Correo,
	   Fecha as Fecha,
	   EstadoCivil as EstadoCivil,
	   CredencialConyugue as CredencialConyugue,
	   RfcConyugue as RfcConyugue,
	   CurpConyugue as CurpConyugue, 	  
	   IdEstado  as Estado
from   dbo.Cre_Preregistro_Cliente_Encabezado a
where  Nombre like '%'+@Nombre+'%'
and a.IdEstado =1
END  
ELSE
BEGIN 
	  select IdCliente as IdCliente,
	   Nombre as Nombre,	  
	   TipoPersona as TipoPersona,
	   Foto as Foto,
	   RFC as RFC,
	   CURP as CURP,
	   Domicilio as Domicilio,
	   Telefono as Telefono,
	   Correo as Correo,
	   Fecha as Fecha,	 
	   EstadoCivil as EstadoCivil,
	   CredencialConyugue as CredencialConyugue,
	   RfcConyugue as RfcConyugue,
	   CurpConyugue as CurpConyugue,  
	   IdEstado as Estado
from   [dbo].[Cre_Preregistro_Cliente_Encabezado] a
where  a.IdEstado =1
END