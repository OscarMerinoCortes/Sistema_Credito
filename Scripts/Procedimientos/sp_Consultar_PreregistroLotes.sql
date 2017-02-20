CREATE procedure sp_LlenarPreregistroLotes
--declare
@Nombre varchar(50) --=  'WALL'
as
IF @Nombre <> ''
BEGIN
select IdPreregistroLote as IdPreregistroLote,
	   NombrePropietario as NombrePropietario,
	   RFC as RFC,
	   CURP as CURP,
	   Lote as Lote,
	   Colonia as Colonia,
	   SuperficieTotal as SuperficieTotal,
	   SuperficieSembrar as SuperficieSembrar,
	   SuperficieRestante as SuperficieRestante,
	   FolioAserca as FolioAserca,
	   Predio as Predio,
	   Fecha as Fecha,
	   IIF(IdEstado = 1,'ACTIVO','INACTIVO') as Estado
from   [dbo].[Cre_Preregistro_Lote_Encabezado] a
where  NombrePropietario like '%'+@Nombre+'%'
and a.IdEstado =1
END 
 
ELSE

BEGIN 
	  select IdPreregistroLote as IdPreregistroLote,
	   NombrePropietario as NombrePropietario,
	   RFC as RFC,
	   CURP as CURP,
	   Lote as Lote,
	   Colonia as Colonia,
	   SuperficieTotal as SuperficieTotal,
	   SuperficieSembrar as SuperficieSembrar,
	   SuperficieRestante as SuperficieRestante,
	   FolioAserca as FolioAserca,
	   Predio as Predio,
	   Fecha as Fecha,
	   IIF(IdEstado = 1,'ACTIVO','INACTIVO') as Estado
from   [dbo].[Cre_Preregistro_Lote_Encabezado] a
where  a.IdEstado =1
END