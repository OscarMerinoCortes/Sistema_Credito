create table Cre_Preregistro_Lote_Encabezado(
IdPreregistroLote int identity(1,1) primary key not null,
NombrePropietario varchar(50) not null,
RFC varchar(30) not null,
CURP varchar(30) not null,
Lote varchar(10) not null,
Colonia varchar(30) not null,
SuperficieTotal float not null,
SuperficieSembrar float not null,
SuperficieRestante float not null,
FolioAserca varchar(50) not null,
Predio varchar(15) not null,
Fecha datetime not null,
IdEstado int not null
)
