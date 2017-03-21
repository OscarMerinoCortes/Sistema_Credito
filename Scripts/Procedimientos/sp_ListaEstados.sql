create procedure sp_ListaEstados
as
select IdEstado, Estado
from [dbo].[CATALOGO_ENTIDADES_MEXICO]
group by IdEstado, Estado
order by IdEstado ASC