alter procedure sp_LisCliMorDatAdi
@IdCliente int 
as
select
       a.IdDatosAdicionales as IdDatosAdicionales,
	   a.IdPersona as IdPersona,
	   b.Nombre as Nombre,
	   a.IdSociedad as IdSociedad,
	   a.IdCargoSociedad as IdCargo,
	   a.IdEstatus as ChCol,	   
	   c.Descripcion as Cargo
from [dbo].[Cre_Preregistro_Cliente_Datos_Adicionales] a,
     [dbo].[Cre_Preregistro_Cliente_Encabezado] b,
     [dbo].[Cre_Cat_Tipo_Persona] c

where a.IdSociedad = @IdCliente
and   a.IdPersona = b.IdCliente
and   a.IdCargoSociedad = c.IdTipoPersona 

     
