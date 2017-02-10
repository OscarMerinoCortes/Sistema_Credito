alter procedure sp_LlenarClientes
@Nombre varchar(50)
as
IF @Nombre <> ''
BEGIN
select IdCliente as IdCliente,
	   Nombre as Nombre,
	   TipoPersona as TipoPersona,
	   Foto as Foto,
	   RFC as RFC,
	   CURP as CURP,
	   Telefono as Telefono,
	   Correo as Correo,
	   Fecha as Fecha,
	   IdTipoCultivo as IdTipoCultivo,
	   IdEstado as IdEstado
from   [dbo].[Cre_Preregistro_Cliente_Encabezado]
where  Nombre like '%'+@Nombre+'%'
END  
ELSE
BEGIN 
	   IdCliente as IdCliente,
	   Nombre as Nombre,
	   TipoPersona as TipoPersona,
	   Foto as Foto,
	   RFC as RFC,
	   CURP as CURP,
	   Telefono as Telefono,
	   Correo as Correo,
	   Fecha as Fecha,
	   IdTipoCultivo as IdTipoCultivo,
	   IdEstado as IdEstado
from   [dbo].[Cre_Preregistro_Cliente_Encabezado]
END