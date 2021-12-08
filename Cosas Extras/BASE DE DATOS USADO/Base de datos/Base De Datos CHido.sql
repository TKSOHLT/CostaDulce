
Create database Costa_Dulce;

Use Costa_Dulce
/*
Create Table Producto(
ID_Producto char (4),
Primary key(ID_Producto),
Nombre_Producto Varchar(45),
PrecioCompra float,
PrecioVenta float,
CantidadUnidades int,
Tipo varchar(45),
FotoPro Image
);
Create Table Proveedor(
ID_Proveedor char (4),
Primary key(ID_Proveedor),
Nombre_P Varchar(45),
ApellidoP_P Varchar(45),
ApellidoM_p Varchar(45),
ID_Producto char (4),
Direccion Varchar(45),
Telefono Char(12)
);
Create Table Empleado(
ID_Empleado char (4),
Primary key(ID_Empleado),
Nombre_E Varchar(45),
ApellidoP_E Varchar(45),
ApellidoM_E Varchar(45),
Edad int Check (Edad>0),
Salario float,
Direccion Varchar(45),
Telefono Char(12),
Foto Image
);
Create Table Venta(
ID_Venta char (4),
ID_Empleado char (4),
ID_Producto char (4),
Primary key(ID_Venta),
Cantidad int
);
*/

/*
Create procedure listar_Productos 
as 
select * from Producto order by ID_Producto;

create procedure listar_Empleados 
as 
select * from Empleado order by ID_Empleado

create procedure listar_Proveedor 
as 
select * from Proveedor order by ID_Proveedor
go
*/

/*
Create procedure buscar_Empleado
@Nombre varchar (50)
as
select * from Empleado where Nombre_E like @Nombre + '%'
go

Create procedure buscar_Producto
@Nombre varchar (50)
as
select * from Producto where Nombre_Producto like @Nombre + '%'
go
 
Create procedure buscar_Proveedor
@Nombre varchar (50)
as
select * from Proveedor where Nombre_P like @Nombre + '%'
go
*/

/*
create procedure mantenimiento_Producto
@ID_Producto char (4),
@Nombre_Producto Varchar(45),
@PrecioCompra float,
@PrecioVenta float,
@CantidadUnidades int,
@Tipo varchar(45),
@FotoPro Image,
@accion varchar(50) output
as
if (@accion ='1')
begin 
  declare @ID_Producto_new varchar (4),@ID_Producto_max varchar (4)
  set @ID_Producto_max=(select max(ID_Producto)from Producto)
  set @ID_Producto_max=isnull(@ID_Producto_max,'P000')
  set @ID_Producto_new='P'+RIGHT(RIGHT(@ID_Producto_max,3)+1001,4)
  insert into Producto(ID_Producto,Nombre_Producto,PrecioCompra,PrecioVenta,CantidadUnidades,Tipo,FotoPro)
  values(@ID_Producto_new,@Nombre_Producto,@PrecioCompra,@PrecioVenta,@CantidadUnidades,@Tipo,@FotoPro)
  set @accion='se genero un nuevo codigo: '+@ID_Producto_new
end
else if (@accion='2')
begin 
   update Producto set Nombre_Producto=@Nombre_Producto,PrecioCompra=@PrecioCompra,PrecioVenta=@PrecioVenta,CantidadUnidades=@CantidadUnidades,Tipo=@Tipo,FotoPro=@FotoPro
   set @accion='Se modifico el registro: '+@ID_Producto
   end
else if(@accion='3')
begin
   delete from Producto where ID_Producto=@ID_Producto
   set @accion='Se borro el registro: '+@ID_Producto
   end
*/
/*
create procedure mantenimiento_Empleado
@ID_Empleado char (4),
@Nombre_E Varchar(45),
@ApellidoP_E Varchar(45),
@ApellidoM_E Varchar(45),
@Edad int,
@Salario float,
@Direccion Varchar(45),
@Telefono Char(12),
@Foto Image,
@accion varchar(50) output
as
if (@accion ='1')
begin 
  declare @ID_Empleado_new varchar (4),@ID_Empleado_max varchar (4)
  set @ID_Empleado_max=(select max(ID_Empleado)from Empleado)
  set @ID_Empleado_max=isnull(@ID_Empleado_max,'P000')
  set @ID_Empleado_new='E'+RIGHT(RIGHT(@ID_Empleado_max,3)+1001,4)
  insert into Empleado(ID_Empleado,Nombre_E,ApellidoP_E,ApellidoM_E,Edad,Salario,Direccion,Telefono,Foto)
  values(@ID_Empleado,@Nombre_E,@ApellidoP_E,@ApellidoM_E,@Edad,@Salario,@Direccion,@Telefono,@Foto)
  set @accion='se genero un nuevo codigo: '+@ID_Empleado_new
end
else if (@accion='2')
begin 
   update Empleado set  Nombre_E=@Nombre_E,ApellidoP_E=@ApellidoP_E,ApellidoM_E=@ApellidoM_E,Edad=@Edad,Salario=@Salario,Direccion=@Direccion,Telefono=@Telefono,Foto=@Foto
   set @accion='Se modifico el registro: '+@ID_Empleado
   end
else if(@accion='3')
begin
   delete from Empleado where ID_Empleado=@ID_Empleado
   set @accion='Se borro el registro: '+@ID_Empleado
end
*/
/*
create procedure mantenimiento_Proveedor
@ID_Proveedor char (4),
@Nombre_P Varchar(45),
@ApellidoP_P Varchar(45),
@ApellidoM_p Varchar(45),
@ID_Producto char (4),
@Direccion Varchar(45),
@Telefono Char(12),
@accion varchar(50) output
as
if (@accion ='1')
begin 
  declare @ID_Proveedor_new varchar (4),@ID_Proveedor_max varchar (4)
  set @ID_Proveedor_max=(select max(@ID_Proveedor)from Proveedor)
  set @ID_Proveedor_max=isnull(@ID_Proveedor_max,'P000')
  set @ID_Proveedor_new='E'+RIGHT(RIGHT(@ID_Proveedor_max,3)+1001,4)
  insert into Proveedor(ID_Proveedor,Nombre_P,ApellidoP_P,ApellidoM_p,ID_Producto,Direccion,Telefono)
  values(@ID_Proveedor,@Nombre_P,@ApellidoP_P,@ApellidoM_p,@ID_Producto,@Direccion,@Telefono)
  set @accion='se genero un nuevo codigo: '+@ID_Proveedor_new
end
else if (@accion='2')
begin 
   update Proveedor set  ID_Proveedor=@ID_Proveedor_new,Nombre_P=@Nombre_P,ApellidoP_P=@ApellidoP_P,ApellidoM_p=@ApellidoM_p,ID_Producto=@ID_Producto,Direccion=@Direccion,Telefono=@Telefono
   set @accion='Se modifico el registro: '+@ID_Proveedor
   end
else if(@accion='3')
begin
   delete from Proveedor where @ID_Proveedor=@ID_Proveedor
   set @accion='Se borro el registro: '+@ID_Proveedor
end
*/
