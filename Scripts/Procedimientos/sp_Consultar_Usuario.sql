alter procedure sp_LisUsuDet
as
select a.IdUsuario,
       a.Nombre,
	   a.Usuario,
	   a.Pass,
	   a.IdTipoUsuario,
	   b.Descripcion as TipoUsuario,
	   a.IdEstatus
from [dbo].[Cre_Cat_Usuario] a,
	[dbo].[Cre_Cat_Tipo_Usuario] b
where  a.IdTipoUsuario = b.IdTipoUsuario
and		a.IdEstatus = 1