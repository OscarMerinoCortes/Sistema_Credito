create table Cre_Preregistro_Cliente_Datos_Adicionales(
IdDatosAdicionales int identity(1,1) primary key not null,
IdPersona int not null,
IdSociedad int not null,
IdCargoSociedad int not null,
IdEstatus int not null
)