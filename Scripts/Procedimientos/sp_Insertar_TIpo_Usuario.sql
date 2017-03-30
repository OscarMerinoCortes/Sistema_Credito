Alter procedure sp_InsTipUsu
@IdTipoUsuario int output,
@Descripcion varchar(30),
@IdEstatus int
as
begin
set nocount on
merge [dbo].[Cre_Cat_Tipo_Usuario] as target
using (select @IdTipoUsuario,@Descripcion,@IdEstatus) AS SOURCE (IdTipoUsuario,Descripcion,IdEstatus)
ON (target.IdTipoUsuario = SOURCE.IdTipoUsuario)
WHEN MATCHED THEN
UPDATE SET Descripcion = Source.Descripcion,
           IdEstatus = source.IdEstatus 
WHEN NOT MATCHED THEN
        INSERT (Descripcion, IdEstatus)
        VALUES (Source.Descripcion, Source.IdEstatus);
END 

