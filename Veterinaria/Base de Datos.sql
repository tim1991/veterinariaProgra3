drop database MundoAnimalia
create database MundoAnimalia
use MundoAnimalia

--Tablas

create table Roles
(
    IdRol int primary key Identity(1,1) not null,
    Detalle varchar(100)
)

INSERT INTO	Roles VALUES('Administrador')
INSERT INTO	Roles VALUES('Vendedor')
INSERT INTO	Roles VALUES('Cliente')

create table Usuario
(
    IDUsuario int primary key Identity(1, 1) not null,
    Cedula int not null,
	NombrePersona varchar(15) not null,
    Contrasena varchar(20) not null,
    Apellidos varchar(50) not null,
    Email varchar(50) not null,
    Telefono int not null,
    Direccion varchar(200) not null,
    IdRol int foreign key (IdRol) references Roles (IdRol) not null
)

insert into Usuario(Cedula, Contrasena, NombrePersona, Apellidos, Email, Telefono, Direccion, IdRol)
values(300010001, 'admin', 'Administrador', 'Administrador', 'admin', 88888888, 'Cartago', 1)

create table Mascota
(
    IdMascota int primary key Identity(1, 1) not null,
    NombreMascota varchar(10)  not null,
    Especie varchar(10) not null,
    Raza varchar(10) not null,
    Nacimiento datetime not null,
    Genero varchar(10) not null,
    IDUsuario int foreign key (IDUsuario) references Usuario (IDUsuario) not null
)

create table Cita
(
    IdCita int primary key Identity(1, 1) not null,
    Servicio varchar(30)  not null,
    FechaCita datetime not null,
    IDUsuario int foreign key (IDUsuario) references Usuario (IDUsuario) not null
)

create table Productos
(
    IDProducto int identity(1, 1) primary key not null,
    NombreProducto varchar(70) not null,
    Precio money not null,
    Stock int  not null
)

create table Factura
(
    IDFactura int primary key not null,
    FechaFactura datetime not null,
    Subtotal money not null,
	Impuestos money not null,
    Total money not null,
    MetodoPago varchar(15) not null,
    IDUsuario int foreign key (IDUsuario) references Usuario (IDUsuario) not null
) 

create table DetalleFactura
(
    IdDetalle int primary key identity(1,1) not null,
    Cantidad int not null,
    SubtotalDetalle money not null,
	ImpuestosDetalle money not null,
	TotalDetalle money not null,
    IDProducto int foreign key (IDProducto) references Productos (IDProducto) not null,
    IDFactura int foreign key (IDFactura) references Factura (IDFactura) not null
)
go

--Procedimientos almacenados listar

CREATE PROCEDURE listarRoles
AS
SELECT * FROM Roles
GO

CREATE PROCEDURE listarUsuarios
AS
SELECT Usuario.*,Roles.Detalle FROM Usuario INNER JOIN Roles ON Roles.IdRol = Usuario.IdRol
GO

--Procedimiento almacenado ingresar

CREATE PROCEDURE ingresar
    @Email varchar(50),
    @Contrasena varchar(20)
AS
BEGIN
SELECT Usuario.*,Roles.Detalle FROM Usuario INNER JOIN Roles ON Roles.IdRol = Usuario.IdRol WHERE Usuario.Email = @Email AND Usuario.Contrasena = @Contrasena
END
GO

--Procedimientos almacenados para Usuario

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

create procedure buscarUsuario
@Cedula int
as
select * from Usuario where Cedula = @Cedula
go

--Procedimientos almacenados para Producto

create procedure agregarProducto
@NombreProducto varchar(70),
@Precio money,
@Stock int
as
insert into Productos(NombreProducto, Precio, Stock)
values(@NombreProducto, @Precio, @Stock)
go

create procedure actualizarProducto
@NombreProducto varchar(70),
@Precio money,
@Stock int
as
UPDATE Productos set Precio = @Precio, Stock = @Stock where NombreProducto = @NombreProducto
go

create procedure mostrarProducto
as
select * from Productos
go

create procedure deleteProducto
@NombreProducto varchar(70)
as
delete from Productos where NombreProducto = @NombreProducto
go

--Procedimientos almacenados para Factura y Detalles


create procedure insertarFactura
@IDFactura int,
@FechaFactura datetime,
@Subtotal money,
@Impuestos money,
@Total money,
@MetodoPago varchar(15),
@IDUsuario int
as
insert into Factura(IDFactura,FechaFactura, Subtotal, Impuestos, Total, MetodoPago, IDUsuario)
values(@IDFactura,@FechaFactura, @Subtotal, @Impuestos, @Total, @MetodoPago, @IDUsuario)
go

create procedure insertDetalle
@Cantidad int,
@SubtotalDetalle money,
@ImpuestosDetalle money,
@TotalDetalle money,
@IDProducto int,
@IDFactura int
as
insert into DetalleFactura(Cantidad, SubtotalDetalle, ImpuestosDetalle, TotalDetalle, IDProducto, IDFactura)
values(@Cantidad, @SubtotalDetalle, @ImpuestosDetalle, @TotalDetalle, @IDProducto, @IDFactura)
go

create procedure selectFacturas
as
select * from Factura
go

create procedure selectIdFactura
@IDFactura int
as
select Factura.IDFactura,Usuario.NombrePersona,Usuario.Apellidos, Usuario.Cedula,Usuario.Direccion,Factura.FechaFactura,Factura.MetodoPago,Factura.Subtotal,Factura.Impuestos,Factura.Total 
from Factura 
inner join Usuario on Usuario.IDUsuario = Factura.IDUsuario
where Factura.IDFactura = @IDFactura
go

create procedure selectNumFactura
as
select IDFactura from Factura order by IDFactura desc
go

create procedure selectBuscarUsuario
@Cedula int
as
select * from Usuario where Cedula = @Cedula
go

create procedure selectBuscarProducto
@IDProducto int
as
select * from Productos where IDProducto = @IDProducto
go

create procedure selectDetalles
@IDFactura int
as
select  d.IdDetalle,d.Cantidad,d.SubtotalDetalle,d.ImpuestosDetalle,d.TotalDetalle, p.NombreProducto  from DetalleFactura as d
inner join Factura as f on f.IDFactura = d.IDFactura
inner join Productos as p on p.IDProducto = d.IDProducto 
where f.IDFactura = @IDFactura
go

create procedure obtenerUsuarioCedula  
@Cedula int  
AS  
BEGIN  
 select * from Usuario where Cedula = @Cedula  
END  
GO

create PROCEDURE actualizarUsuario  
 @IDUsuario int,  
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
Update  Usuario set Cedula = @Cedula, NombrePersona = @NombrePersona, Contrasena = @Contrasena, Apellidos = @Apellidos, Email = @Email, Telefono = @Telefono, Direccion = @Direccion, IdRol = @IdRol Where IDUsuario = @IDUsuario  
END
GO

create procedure selectDetallesVenta
@IDFactura int
as
select a.IDFactura, d.NombrePersona, d.Apellidos, d.Telefono, d.Direccion, b.FechaFactura, c.IDProducto, c.NombreProducto, c.Precio, a.Cantidad,
a.SubtotalDetalle, a.ImpuestosDetalle, a.TotalDetalle, b.MetodoPago from DetalleFactura a
inner join Factura b on a.IDFactura = b.IDFactura
inner join Productos c on a.IDProducto = c.IDProducto and b.IDProducto = c.IDProducto
inner join Usuario d on b.IDUsuario = d.IDUsuario
where a.IDFactura = @IDFactura
go