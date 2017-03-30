Alter procedure sp_InsUsuDet
@IdUsuario int output,
@Nombre varchar(50),
@Usuario varchar(15),
@Password varchar(30),
@IdTipoUsuario int,
@IdEstatus int
as
begin
set nocount on
merge [dbo].[Cre_Cat_Usuario] as target
using (select @IdUsuario,@Nombre,@Usuario,@Password,@IdTipoUsuario,@IdEstatus) AS SOURCE (IdUsuario,Nombre,Usuario,Pass,IdTipoUsuario,IdEstatus)
ON (target.IdUsuario = SOURCE.IdUsuario)
WHEN MATCHED THEN
UPDATE SET Nombre = Source.Nombre,
           Usuario = source.Usuario,
		   Pass = source.Pass,
		   IdTipoUsuario = source.IdTipoUsuario,
		   IdEstatus = source.IdEstatus 
WHEN NOT MATCHED THEN
        INSERT (Nombre, Usuario, Pass, IdTipoUsuario,IdEstatus)
        VALUES (Source.Nombre, Source.Usuario, Source.Pass, Source.IdTipoUsuario,Source.IdEstatus);
END 