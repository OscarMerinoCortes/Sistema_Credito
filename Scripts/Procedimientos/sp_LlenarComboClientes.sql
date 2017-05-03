CREATE procedure sp_LlenarComboClientes
--declare
as
select 
	   IdCliente,
	   Nombre+''+SegundoNombre+' '+ApellidoPaterno+' '+ ApellidoMaterno as Nombre
	   from   [dbo].[Cre_Preregistro_Cliente_Encabezado] a
where  a.IdEstatus = 1
