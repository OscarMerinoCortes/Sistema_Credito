create table Cre_Cat_Tipo_Documento(
IdTipoDocumento int identity(1,1) primary key not  null,
Descripcion varchar(30) not null,
TipoPersona varchar(1) not null,
IdEstado int not null
)