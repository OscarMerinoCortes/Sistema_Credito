create table Cre_Cat_Usuario(
IdUsuario int not null identity(1,1) primary key,
Nombre varchar(50) not null,
Usuario varchar(15) not null,
Pass varchar(30) not null,
IdTipoUsuario int not null,
IdEstatus int not null
)