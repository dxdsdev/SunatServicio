create database Examen_NombreApellido
go
use Examen_NombreApellido;
go
Create table Usuario
(
idUsuario int identity,
Nombre Varchar(150),
Apellido Varchar(150),
Puesto Varchar(50),
Estado int,
PRIMARY KEY (idUsuario)
)
go
create table LoginUsuario
(
idUsuario int ,
Contraseña Varchar(150),
PRIMARY KEY (idUsuario),
CONSTRAINT loginu FOREIGN KEY (idUsuario) REFERENCES Usuario (idUsuario),
)

insert into Usuario values('Daniel','Romero','Administrador',1)
insert into Usuario values('Jose','Luna','Administrador',1)
insert into LoginUsuario values('1','123456')


-- ------------------------------------------------
-- ------------------------------------------------

create procedure Sp_Login
@idUsuario int,@pass varchar(150)
as
Begin
  Select COUNT(1) from LoginUsuario    Where idUsuario=@idUsuario And Contraseña=@pass;

end

-- ------------------------------------------------
-- ------------------------------------------------

create procedure usp_Listarusuario
@idUsuario int
as
begin
select idUsuario,Nombre,Apellido,Puesto,Estado
from Usuario where idUsuario=@idUsuario;
end


-- ------------------------------------------------
-- ------------------------------------------------

create procedure usp_ListarUsuarios
as
begin
select idUsuario,Nombre,Apellido,Puesto,Estado from Usuario 
end

exec  usp_ListarUsuarios


-- ------------------------------------------------
-- ------------------------------------------------

create procedure [Usp_AdministrarUsuario]
@idusuario int, @nombre Varchar(150),@apellido varchar(150),@puesto Varchar(50), @estado int 
as
begin
	If @idusuario=0 -- Inserta
	begin
		insert into Usuario values(@nombre,@apellido,@puesto,@estado);
	end
	else
	begin 
		Update Usuario set Nombre=@nombre,Apellido=@apellido,Puesto=@puesto,Estado=@Estado where idUsuario=@idusuario;		
	end
end