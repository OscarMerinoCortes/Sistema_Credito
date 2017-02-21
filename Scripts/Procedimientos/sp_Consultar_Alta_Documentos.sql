alter PROCEDURE sp_LlenarAltaDocumentos
AS
SELECT 
IdTipoDocumento as 'ID',
Descripcion AS 'DESCRIPCION',
CASE TipoPersona 
	WHEN 'M' THEN 'MORAL'
	WHEN 'F' THEN 'FISICA'
	ELSE 'AMBOS'
END AS 'TIPO PERSONA',
CASE IDESTADO
	WHEN 0 THEN 'INACTIVO'
	ELSE 'ACTIVO'
END AS 'ESTATUS'
FROM Cre_Cat_Tipo_Documento