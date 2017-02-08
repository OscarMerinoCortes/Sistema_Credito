create table Cre_Preregistro_Cliente_Detalle(
IdPreregistroDetalle int primary key identity(1,1) not null,
IdCliente int not null,
IdTipoDocumento int not null,
IdEstatusDocumento bit not null,
IdEstado int not null
)


