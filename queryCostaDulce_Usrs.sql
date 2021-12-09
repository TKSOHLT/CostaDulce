USE costaDulce;
--TABLA DE USUARIOS--
create database costaDulce
go
use costaDulce
go
CREATE TABLE Users(
 UserID int identity (1,1) primary key,
 NombreUsuario nvarchar(50)unique not null,
 Password nvarchar(50) not null,
 Nombre nvarchar (50) not null,
 Apellidos nvarchar (50)not null,
 Correo nvarchar(50) not null
 )
 
 INSERT INTO Users( NombreUsuario,Password,Nombre,Apellidos,Correo)VALUES
 ('administrador','contraseña1','Gustavo','Ramírez N','gustonrix@gmail.com'
 );
 GO
 SELECT*FROM Users

 declare @user nvarchar(100)='admin'
 declare @pass nvarchar(100)='admin'

SELECT *FROM Users where NombreUsuario=@user and Password =@pass;