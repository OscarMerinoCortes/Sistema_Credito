CREATE PROCEDURE [dbo].[Cre_InsUbiDoc]
@IdUbicacion int = 1 output ,
@Ruta varchar(max),
@RutaSolicitudCredito varchar(max),
@NombreCarpetaRaiz varchar(30),
@NombreCarpetaPersonal varchar(30),
@NombreCarpetaLote varchar(30)
as
begin
SET NOCOUNT ON 
MERGE [dbo].[Cre_Cat_Ubicacion_Documentos] as target
using (select @IdUbicacion,@Ruta, @RutaSolicitudCredito,@NombreCarpetaRaiz,@NombreCarpetaPersonal,@NombreCarpetaLote) as source (IdUbicacion,ruta,RutaSolicitudCredito,NombreCarpetaRaiz,NombreCarpetaPersonal,NombreCarpetaLote)
on (target.IdUbicacion = source.IdUbicacion)

when matched then
update set ruta = source.ruta,
		   RutaSolicitudCredito = source.RutaSolicitudCredito,
		   NombreCarpetaRaiz = source.NombreCarpetaRaiz,
		   NombreCarpetaPersonal = source.NombreCarpetaPersonal,
		   NombreCarpetaLote = source.NombreCarpetaLote
when not matched then
	insert(ruta,RutaSolicitudCredito,NombreCarpetaRaiz,NombreCarpetaPersonal,NombreCarpetaLote)
	values(source.ruta,source.RutaSolicitudCredito, source.NombreCarpetaRaiz,source.NombreCarpetaPersonal, source.NombreCarpetaLote);
	set @IdUbicacion = SCOPE_IDENTITY()
end
return @IdUbicacion






