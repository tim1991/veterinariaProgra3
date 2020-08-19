drop database MundoAnimalia
create database MundoAnimalia
use MundoAnimalia

create table Roles(
    IdRol int primary key Identity(1,1) not null,
    Detalle varchar(100)
);

INSERT INTO	Roles VALUES('Administrador');
INSERT INTO	Roles VALUES('Vendedor');
INSERT INTO	Roles VALUES('Cliente');




create table Usuario
(
    IDUsuario int primary key Identity(1,1) not null,
    Cedula int not null,
	NombrePersona varchar(15) not null,
    Contrasena varchar(20) not null,
    Apellidos varchar(50) not null,
    Email varchar(50) not null,
    Telefono int not null,
    Direccion varchar(200) not null,
    IdRol int foreign key (IdRol) references Roles (IdRol) not null
);




create table Mascota
(
    IdMascota int primary key Identity(1,1) not null,
    NombreMascota varchar(10)  not null,
    Especie varchar(10) not null,
    Raza varchar(10) not null,
    Nacimiento datetime not null,
    Genero varchar(10) not null,
    IDUsuario int foreign key (IDUsuario) references Usuario (IDUsuario) not null
);

create table Cita
(
    IdCita int primary key Identity(1,1) not null,
    Servicio varchar(30)  not null,
    FechaCita datetime not null,
    IDUsuario int foreign key (IDUsuario) references Usuario (IDUsuario) not null
);

create table Productos
(
    IDProducto int primary key not null,
    NombreProducto varchar(70) not null,
    Precio money not null,
    Stock int  not null
);

create table Factura
(
    IDFactura int primary key Identity(1,1)  not null,
	NumeroFactura int  not null,
    FechaFactura datetime not null,
    Total money not null,
    Subtotal money not null,
    MetodoPago varchar(15) not null,
    IDUsuario int foreign key (IDUsuario) references Usuario (IDUsuario) not null,
    IDProducto int foreign key (IDProducto) references Productos (IDProducto) not null
);

create table DetalleFactura
(
    IdDetalle int primary key not null,
    Cantidad int not null,
    SubtotalDetalle money not null,
    IDProducto int foreign key (IDProducto) references Productos (IDProducto) not null,
    IDFactura int foreign key (IDFactura) references Factura (IDFactura) not null
);


--Procedimientos almacenados

CREATE PROCEDURE listarRoles
AS
SELECT * FROM Roles
GO

CREATE PROCEDURE agregarUsuario
	@Cedula int ,
	@NombrePersona varchar(15) ,
	@Contrasena varchar(20) ,
	@Apellidos varchar(50) ,
	@Email varchar(50) ,
	@Telefono int ,
	@Direccion varchar(200),
	@IdRol int
AS
BEGIN
INSERT INTO Usuario (Cedula,NombrePersona,Contrasena,Apellidos,Email,Telefono,Direccion,IdRol) VALUES (@Cedula,@NombrePersona,@Contrasena,@Apellidos,@Email,@Telefono,@Direccion,@IdRol)
END
GO


CREATE PROCEDURE listarUsuarios
AS
SELECT Usuario.*,Roles.Detalle FROM Usuario INNER JOIN Roles ON Roles.IdRol = Usuario.IdRol
GO


CREATE PROCEDURE ingresar
@Email varchar(50),
@Contrasena varchar(20)
AS
BEGIN
SELECT Usuario.*,Roles.Detalle FROM Usuario INNER JOIN Roles ON Roles.IdRol = Usuario.IdRol WHERE Usuario.Email = @Email AND Usuario.Contrasena = @Contrasena
END
GO


CREATE PROCEDURE agregarMascota
    @IdMascota int,
    @NombreMascota varchar(10),
    @Especie varchar(10),
    @Raza varchar(10),
    @Nacimiento datetime,
    @Genero varchar(10),
    @IDUsuario int
AS
BEGIN
INSERT INTO Mascota (IdMascota,NombreMascota,Especie,Raza,Nacimiento,Genero,IDUsuario) VALUES (@IdMascota,@NombreMascota,@Especie,@Raza,@Nacimiento,@Genero,@IDUsuario)
END
GO

CREATE PROCEDURE listarMascotas
AS
SELECT * FROM Mascota
GO

CREATE PROCEDURE agregarCita
    @IdCita int,
    @Servicio varchar(30),
    @FechaCita datetime,
    @IDUsuario int
AS
BEGIN
INSERT INTO Cita (IdCita,Servicio,FechaCita,IDUsuario) VALUES (@IdCita,@Servicio,@FechaCita,@IDUsuari)
END
GO

CREATE PROCEDURE listarCitas
AS
SELECT * FROM Cita
GO