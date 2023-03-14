create database PROYECTOCS
go

use DBTeam
go

create table Usuario
(
id_empleado varchar(5),
nombre varchar (50),
usuario varchar(5),
contrasena varchar (50)
);
insert into Usuario values ('E0001','KENNY','KRCB','1234')
insert into Usuario values ('E0001','LEANDRO','LWCN','1234')
create proc sp_logueo_ez
@usuario varchar(10),
@clave varchar(10)
as
select id_empleado, nombre, usuario, contrasena from Usuario
where usuario=@usuario and contrasena=@clave
go
create table clientes
(
codigo varchar(5),
nombres varchar(50),
cedula varchar(50),
telefono varchar(50),
cbancaria varchar(5),
fnacimiento varchar(50),
direccion varchar(50),
estado varchar(50),
servicios varchar(50)
);
go

create proc sp_listar_clientes
as
select * from clientes order by codigo
go

create proc sp_buscar_clientes
@cedula varchar(50)
as
select codigo,nombres,cedula,telefono,cbancaria,fnacimiento,direccion,estado,servicios from clientes where cedula like @cedula + '%'
go

create proc sp_mantenimiento_clientes
@codigo varchar(5),
@nombres varchar(50),
@cedula varchar(50),
@telefono varchar(50),
@cbancaria varchar(5),
@fnacimiento varchar(50),
@direccion varchar(50),
@estado varchar(50),
@servicios varchar(50),
@accion varchar(50) output
as
if (@accion='1')
begin
	declare @codnuevo varchar(5), @codmax varchar(5)
	set @codmax = (select max(codigo) from clientes)
	set @codmax = isnull(@codmax,'A0000')
	set @codnuevo = 'A'+RIGHT(RIGHT(@codmax,4)+10001,4)
	insert into clientes(codigo,nombres,cedula,telefono,cbancaria,fnacimiento,direccion,estado,servicios)
	values(@codnuevo,@nombres,@cedula,@telefono,@cbancaria,@fnacimiento,@direccion,@estado,@servicios)
	set @accion='Se genero el código: ' +@codnuevo
end
else if (@accion='2')
begin
	update clientes set nombres=@nombres,cedula=@cedula,telefono=@telefono,cbancaria=@cbancaria,fnacimiento=@fnacimiento,direccion=@direccion,estado=@estado,servicios=@servicios where codigo=@codigo
	set @accion='Se modifico el código: ' +@codigo
end
else if (@accion='3')
begin
	delete from clientes where codigo=@codigo
	set @accion='Se borro el código: ' +@codigo
end
go

create table ambulancia
(
codigo varchar(5),
placa varchar(50),
revision varchar(50),
estado varchar(50),
servicios varchar(50)
);
go


create proc sp_listar_ambulancia
as
select * from ambulancia order by codigo
go

create proc sp_buscar_ambulancia
@placa varchar(50)
as
select codigo,placa,revision,estado,servicios from ambulancia where placa like @placa + '%'
go

create proc sp_mantenimiento_ambulancia
@codigo varchar(5),
@placa varchar(50),
@revision varchar(50),
@estado varchar(50),
@servicios varchar(50),
@accion varchar(50) output
as
if (@accion='1')
begin
	declare @codnuevo varchar(5), @codmax varchar(5)
	set @codmax = (select max(codigo) from ambulancia)
	set @codmax = isnull(@codmax,'A0000')
	set @codnuevo = 'A'+RIGHT(RIGHT(@codmax,4)+10001,4)
	insert into ambulancia(codigo,placa,revision,estado,servicios)
	values(@codnuevo,@placa,@revision,@estado,@servicios)
	set @accion='Se genero el código: ' +@codnuevo
end
else if (@accion='2')
begin
	update ambulancia set placa=@placa,revision=@revision,estado=@estado,servicios=@servicios where codigo=@codigo
	set @accion='Se modifico el código: ' +@codigo
end
else if (@accion='3')
begin
	delete from ambulancia where codigo=@codigo
	set @accion='Se borro el código: ' +@codigo
end
go
select * from Usuario
go
create table conductor
(
codigo varchar(5),
nombres varchar(50),
cedula varchar(50),
telefono varchar(50),
dialibre varchar(5),
fnacimiento varchar(50),
direccion varchar(50),
estado varchar(50),
servicios varchar(50)
);
go

create proc sp_listar_conductor
as
select * from conductor order by codigo
go

create proc sp_buscar_conductor
@cedula varchar(50)
as
select codigo,nombres,cedula,telefono,dialibre,fnacimiento,direccion,estado,servicios from conductor where cedula like @cedula + '%'
go

create proc sp_mantenimiento_conductor
@codigo varchar(5),
@nombres varchar(50),
@cedula varchar(50),
@telefono varchar(50),
@dialibre varchar(50),
@fnacimiento varchar(50),
@direccion varchar(50),
@estado varchar(50),
@servicios varchar(50),
@accion varchar(50) output
as
if (@accion='1')
begin
	declare @codnuevo varchar(5), @codmax varchar(5)
	set @codmax = (select max(codigo) from conductor)
	set @codmax = isnull(@codmax,'A0000')
	set @codnuevo = 'A'+RIGHT(RIGHT(@codmax,4)+10001,4)
	insert into conductor(codigo,nombres,cedula,telefono,dialibre,fnacimiento,direccion,estado,servicios)
	values(@codnuevo,@nombres,@cedula,@telefono,@dialibre,@fnacimiento,@direccion,@estado,@servicios)
	set @accion='Se genero el código: ' +@codnuevo
end
else if (@accion='2')
begin
	update conductor set nombres=@nombres,cedula=@cedula,telefono=@telefono,dialibre=@dialibre,fnacimiento=@fnacimiento,direccion=@direccion,estado=@estado,servicios=@servicios where codigo=@codigo
	set @accion='Se modifico el código: ' +@codigo
end
else if (@accion='3')
begin
	delete from conductor where codigo=@codigo
	set @accion='Se borro el código: ' +@codigo
end
go

create table paramedico
(
codigo varchar(5),
nombres varchar(50),
cedula varchar(50),
telefono varchar(50),
email varchar(5),
fnacimiento varchar(50),
direccion varchar(50),
estado varchar(50),
servicios varchar(50)
);
go

create proc sp_listar_paramedico
as
select * from conductor order by codigo
go

create proc sp_buscar_paramedico
@cedula varchar(50)
as
select codigo,nombres,cedula,telefono,email,fnacimiento,direccion,estado,servicios from paramedico where cedula like @cedula + '%'
go

create proc sp_mantenimiento_paramedico
@codigo varchar(5),
@nombres varchar(50),
@cedula varchar(50),
@telefono varchar(50),
@email varchar(50),
@fnacimiento varchar(50),
@direccion varchar(50),
@estado varchar(50),
@servicios varchar(50),
@accion varchar(50) output
as
if (@accion='1')
begin
	declare @codnuevo varchar(5), @codmax varchar(5)
	set @codmax = (select max(codigo) from paramedico)
	set @codmax = isnull(@codmax,'A0000')
	set @codnuevo = 'A'+RIGHT(RIGHT(@codmax,4)+10001,4)
	insert into paramedico(codigo,nombres,cedula,telefono,email,fnacimiento,direccion,estado,servicios)
	values(@codnuevo,@nombres,@cedula,@telefono,@email,@fnacimiento,@direccion,@estado,@servicios)
	set @accion='Se genero el código: ' +@codnuevo
end
else if (@accion='2')
begin
	update paramedico set nombres=@nombres,cedula=@cedula,telefono=@telefono,email=@email,fnacimiento=@fnacimiento,direccion=@direccion,estado=@estado,servicios=@servicios where codigo=@codigo
	set @accion='Se modifico el código: ' +@codigo
end
else if (@accion='3')
begin
	delete from paramedico where codigo=@codigo
	set @accion='Se borro el código: ' +@codigo
end
go

create table servicio
(
codigo varchar(5),
m_emergnecia varchar(50),
c_ambulancias varchar(50),
c_paramedicos varchar(5),
cod_ambulancia varchar(50),
cod_conductor varchar(50),
cod_paramedico varchar(50),
estado varchar(50),
direccion varchar(50),
telefono varchar(50),
cedula varchar(50),
cod_cliente varchar(50),
fecha varchar(50),
hora varchar(50),
monto varchar(50)
);
go

create proc sp_listar_servicio
as
select * from servicio order by codigo
go

create proc sp_buscar_servicio
@cedula varchar(50)
as
select codigo,m_emergnecia,c_ambulancias,c_paramedicos,cod_ambulancia,cod_conductor,cod_paramedico,estado,direccion,telefono,cedula,cod_cliente,fecha,hora,monto from servicio where cedula like @cedula + '%'
go

create proc sp_mantenimiento_servicio
@codigo varchar(5),
@m_emergnecia varchar(50),
@c_ambulancias varchar(50),
@c_paramedicos varchar(5),
@cod_ambulancia varchar(50),
@cod_conductor varchar(50),
@cod_paramedico varchar(50),
@estado varchar(50),
@direccion varchar(50),
@telefono varchar(50),
@cedula varchar(50),
@cod_cliente varchar(50),
@fecha varchar(50),
@hora varchar(50),
@monto varchar(50),
@accion varchar(50) output
as
if (@accion='1')
begin
	declare @codnuevo varchar(5), @codmax varchar(5)
	set @codmax = (select max(codigo) from servicio)
	set @codmax = isnull(@codmax,'A0000')
	set @codnuevo = 'A'+RIGHT(RIGHT(@codmax,4)+10001,4)
	insert into servicio(codigo,m_emergnecia,c_ambulancias,c_paramedicos,cod_ambulancia,cod_conductor,cod_paramedico,estado,direccion,telefono,cedula,cod_cliente,fecha,hora,monto)
	values(@codnuevo,@m_emergnecia,@c_ambulancias,@c_paramedicos,@cod_ambulancia,@cod_conductor,@cod_paramedico,@estado,@direccion,@telefono,@cedula,@cod_cliente,@fecha,@hora,@monto)
	set @accion='Se genero el código: ' +@codnuevo
end
else if (@accion='2')
begin
	update servicio set m_emergnecia=@m_emergnecia,c_ambulancias=@c_ambulancias,c_paramedicos=@c_paramedicos,cod_ambulancia=@cod_ambulancia,cod_conductor=@cod_conductor,cod_paramedico=@cod_paramedico,estado=@estado,direccion=@direccion,telefono=@telefono,cedula=@cedula,cod_cliente=@cod_cliente,fecha=@fecha,hora=@hora,monto=@monto where codigo=@codigo
	set @accion='Se modifico el código: ' +@codigo
end
else if (@accion='3')
begin
	delete from servicio where codigo=@codigo
	set @accion='Se borro el código: ' +@codigo
end
go

