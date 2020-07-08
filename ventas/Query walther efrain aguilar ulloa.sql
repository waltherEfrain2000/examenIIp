drop database Tienda
go

create database Tienda
go

use Tienda
go

create table cliente (
	idCliente int primary key not null,
	nombre varchar(25),
	apellido varchar(25),
	direccion varchar(50)
)


create table producto(
	idProducto int primary key not null,
	nombreProducto varchar(40),
	descripcion varchar(50)
)

create table Venta(
	idVenta int primary key not null,
	fechaVenta varchar(50),
	precio int,
	cantidad int,
	idCliente int foreign key references cliente(idCliente),
	idProducto int foreign key references producto(idProducto)
)

insert into cliente values(1,'walther','efrain','barrio los cocos')
 insert into producto values(1,'coca cola','botella 3ltrs ')

 insert into Venta values(1,'07/07/2020	',32,2,1,1)

 SELECT concat(cliente.nombre, ' ', cliente.apellido) as Nombre, producto.nombreProducto,Venta.precio, Venta.cantidad, Venta.fechaVenta FROM Venta
INNER JOIN cliente On Venta.idCliente = cliente.idCliente
INNER JOIN producto on Venta.idProducto = producto.idProducto
WHERE Venta.idVenta = 1