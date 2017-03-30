create table Cre_Cat_Tipo_Usuario(
IdTipoUsuario int not null identity(1,1) primary key,
Descripcion varchar(30) not null,
IdEstatus int not null
)