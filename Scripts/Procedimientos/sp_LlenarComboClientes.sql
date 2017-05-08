alter procedure sp_LlenarComboClientes
--declare
as
select 
	   IdCliente,
	   Nombre+	   CASE SegundoNombre
					 when '' then SegundoNombre
					 else ' '+SegundoNombre+' '
				   end
	   +ApellidoPaterno+' '+ ApellidoMaterno as Nombre
	   from   [dbo].[Cre_Preregistro_Cliente_Encabezado] a
where  a.IdEstatus = 1