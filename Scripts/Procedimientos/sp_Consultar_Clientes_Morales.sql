alter procedure sp_LisCliMor
as
declare @DatosAdicionales int = 0
select
     @DatosAdicionales as IdDatosAdicionales,
     [IdCliente] as IdPersona,
     [Nombre] as Nombre	
from dbo.Cre_Preregistro_Cliente_Encabezado
where IdEstado = 1
and   TipoPersona = 'FISICA'
