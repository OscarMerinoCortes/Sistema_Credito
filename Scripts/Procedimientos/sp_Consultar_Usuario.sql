create procedure sp_LisUsuDet
as
select a.IdUsuario,
       a.Nombre,
	   a.Usuario,
	   a.Pass,
	   a.IdTipoUsuario,
	   a.IdEstatus
from [dbo].[Cre_Cat_Usuario] a
where idEstatus = 1