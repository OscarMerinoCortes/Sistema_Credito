create table Cre_Preregistro_Cliente_Encabezado(
IdCliente int primary key identity(1,1) not null,
Nombre varchar(50) not null,
RepresentanteLegal varchar(50) null,
TipoPersona varchar(15) not null,
Foto image null,
RFC varchar(15),
CURP varchar(25),
Domicilio varchar(50) not null,
Telefono varchar(15),
Correo varchar(50),
Fecha datetime,
IdTipoCultivo int not null,
IdEstado int not null
)


