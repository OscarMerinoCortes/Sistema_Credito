create procedure sp_LisCliMor
as
select
     [IdCliente] as Id,
     [Nombre] as Nombre
from dbo.Cre_Preregistro_Cliente_Encabezado
where IdEstado = 1