alter procedure sp_LisCliMor
as
declare @DatosAdicionales int = 0
select
     @DatosAdicionales as IdDatosAdicionales,
     [IdCliente] as IdPersona,
     [Nombre]+' '+SegundoNombre+' '+ApellidoPaterno+' '+ApellidoMaterno as Nombre	
from dbo.Cre_Preregistro_Cliente_Encabezado
where IdEstatus = 1
and   IdTipoPersona = 'FISICA'

