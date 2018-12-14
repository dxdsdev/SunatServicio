create database BD_Ferreteria
go

use BD_Ferreteria
go

create table Llave(
	id varchar(10)
)

create table Producto(
	id int identity,
	Descripcion varchar(100),
	TipoProducto int,
	Estado int
)


create table Auditoria(
	IdModificacion varchar(20),
	IdTabla varchar(50),
	Accion varchar(1),
	Usuario varchar(20),
	Fecha datetime,
	DatoAnterior varchar(500),
	DatoNuevo varchar(500)
)