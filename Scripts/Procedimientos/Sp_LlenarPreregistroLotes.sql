ALTER procedure sp_LlenarPreregistroLotes
--declare
@Nombre_lote varchar(50) --=  'WALL'
as
IF @Nombre_lote <> ''
BEGIN
select IdPreregistroLote as IdPreregistroLote,
		b.IdCliente as IdPropietario,
		b.RFC as RFC,
		a.Nombre_lote,
		a.Colonia as IdColonia,
		a.Folio_Lote,
		a.SuperficieTotal,
		a.SuperficieSembrar,
		a.SuperficieRestante,
		a.Volumen,
		a.Latitud_Grados,
		a.Latitud_Horas,
		a.Latitud_Minutos,
		a.Longitud_Grados,
		a.Longitud_Horas,
		a.Longitud_Minutos,
		a.Numero_RPP,
		a.Folio_RPP,
		a.Libro_RPP,
		a.Fecha_RPP,
		a.Titulo_Agua,
		a.Regimen_Hidrico,
		a.Fecha_Titulo_Agua,		
	    IIF(a.IdEstado = 1,'ACTIVO','INACTIVO') as Estado
from  dbo.Cre_Preregistro_Lote_Encabezado a inner join dbo.Cre_Preregistro_Cliente_Encabezado b
on a.id_Propietario = b.IdCliente
where  a.nombre_lote like '%'+@Nombre_lote+'%'
and a.IdEstado =1
END 
 
ELSE

BEGIN 
select IdPreregistroLote as IdPreregistroLote,
		b.IdCliente as IdPropietario,
		b.RFC as RFC,
		a.Nombre_Lote,
		a.Colonia as IdColonia,
		a.Folio_Lote,
		a.SuperficieTotal,
		a.SuperficieSembrar,
		a.SuperficieRestante,
		a.Volumen,
		a.Latitud_Grados,
		a.Latitud_Horas,
		a.Latitud_Minutos,
		a.Longitud_Grados,
		a.Longitud_Horas,
		a.Longitud_Minutos,
		a.Numero_RPP,
		a.Folio_RPP,
		a.Libro_RPP,
		a.Fecha_RPP,
		a.Titulo_Agua,
		a.Regimen_Hidrico,
		a.Fecha_Titulo_Agua,		
	    IIF(a.IdEstado = 1,'ACTIVO','INACTIVO') as Estado
from  dbo.Cre_Preregistro_Lote_Encabezado a inner join dbo.Cre_Preregistro_Cliente_Encabezado b
on a.id_Propietario = b.IdCliente
where  a.IdEstado =1
END