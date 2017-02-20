create table Cre_Preregistro_Lote_Detalle(
IdPreregistroLoteDetalle int identity(1,1) primary key not null,
IdPreregistroLote int not null,
IdTipoDocumento int not null,
IdEstatusDocumento int not null,
IdEstado int not null
)

