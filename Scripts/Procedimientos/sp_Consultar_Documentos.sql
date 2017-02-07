ALTER PROCEDURE sp_LlenarDocumentos 
@TipoPersona varchar(1)
AS
SELECT 
	 IdTipoDocumento AS IdTipoDocumento,
	 Descripcion AS NombreDocumento
FROM dbo.Cre_Tipo_Documento
WHERE IdEstado = 1
AND   TipoPersona = @TipoPersona
ANd   TipoPersona = 'A'