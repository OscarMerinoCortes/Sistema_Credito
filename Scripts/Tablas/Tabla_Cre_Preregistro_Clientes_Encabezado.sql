create table Cre_Preregistro_Cliente_Encabezado(
IdCliente int primary key identity(1,1) not null,
Foto image,
IdTipoPersona varchar(20),
Nombre varchar(150),
SegundoNombre varchar(150),
ApellidoPaterno varchar(150),
ApellidoMaterno varchar(150),
IdSexo int,
Sexo varchar(20),
Edad int,
FechaNacimiento date,
IdEstadoNacimiento int,
EstadoNacimiento varchar(50),
IdMunicipioNacimiento int,
MunicipioNacimiento varchar(50),
IdNacionalidad int,
Nacionalidad varchar(50),
Telefono varchar(15),
Correo varchar(50),
RFC varchar(30),
CURP varchar(30),
IdEstatus int,
IdEstadoCivil int,
EstadoCivil varchar(30),
IdRegimen int,
Regimen varchar(30),
ImporteSolicitado float,
ImporteLetra varchar(200),
IdTipoCambio int,
ActividadHabitual varchar(200),
Calle varchar (50),
Colonia varchar(50),
Numero varchar(20),
IdEstado int,
Estado varchar(50),
IdMunicipio int,
Municipio varchar(50),
Poblacion varchar(50),
CodigoPostal int,
IdConyugue int,
FechaMatrimonio date,
IdEstadoMatrimonio int,
EstadoMatrimonio varchar(50),
IdMunicipioMatrimonio int,
MunicipioMatrimonio varchar(50),
Fecha datetime
)
