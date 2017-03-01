create table Cre_Preregistro_Cliente_Encabezado(
IdCliente int primary key identity(1,1) not null,
Nombre varchar(50) not null,
TipoPersona varchar(15) not null,
Foto image,
RFC varchar(15) not null,
CURP varchar(25) not null,
Domicilio varchar(50) not null,
Telefono varchar(15) not null,
Correo varchar(50) not null,
Fecha datetime not null,
EstadoCivil varchar(30) null,
CredencialConyugue varchar(30) null,
RfcConyugue varchar(30) null,
CurpConyugue varchar(30) null,
IdEstado int not null
)
