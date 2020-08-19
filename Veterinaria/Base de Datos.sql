drop database MundoAnimalia
create database MundoAnimalia
use MundoAnimalia

create table Roles
(
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

insert into Usuario(Cedula, Contrasena, NombrePersona, Apellidos, Email, Telefono, Direccion, IdRol)
values(300010001, 'admin', 'Administrador', 'Administrador', 'admin', 88888888, 'Cartago', 1)

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
    IDProducto int identity(1, 1) primary key not null,
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
GO

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

CREATE PROCEDURE agregarProducto
    @NombreProducto varchar(70),
    @Precio money,
    @Stock int
AS
BEGIN
INSERT INTO Productos(NombreProducto, Precio, Stock)
VALUES(@NombreProducto, @Precio, @Stock)
END
GO

CREATE PROCEDURE actualizarProducto
    @NombreProducto varchar(70),
    @Precio money,
    @Stock int
AS
BEGIN
UPDATE Productos SET Precio = @Precio, Stock = @Stock WHERE NombreProducto = @NombreProducto
END
GO

CREATE PROCEDURE mostrarProducto
AS
BEGIN
SELECT * FROM Productos
END
GO