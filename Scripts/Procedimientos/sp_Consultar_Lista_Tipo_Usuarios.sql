create procedure sp_LisTipUsu
as
select a.IdTipoUsuario,
	   a.Descripcion,
	   a.IdEstatus
from [dbo].[Cre_Cat_Tipo_Usuario] a
where IdEstatus = 1