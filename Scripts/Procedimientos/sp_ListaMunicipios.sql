--ALTER procedure sp_ListaMunicipios
declare
@IdEstado int = 1
--as
IF @IdEstado <> 0 
select IdMunicipio,Municipio
from [dbo].[CATALOGO_ENTIDADES_MEXICO]
where IdEstado = @IdEstado
group by IdMunicipio, Municipio
order by IdMunicipio ASC
ELSE
select IdMunicipio,Municipio
from [dbo].[CATALOGO_ENTIDADES_MEXICO]
group by IdMunicipio, Municipio
order by IdMunicipio ASC
