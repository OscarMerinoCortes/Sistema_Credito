create procedure sp_LlenarCultivo
as
select
     IdTipoCultivo as Id,
	 Descripcion as Cultivo
from [dbo].[Cre_Cat_Tipo_Cultivo]
where IdEstado = 1