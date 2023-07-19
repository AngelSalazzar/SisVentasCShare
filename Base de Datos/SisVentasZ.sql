CREATE DATABASE SISVENTAS
go
USE SISVENTAS 
GO
---------------CREACION DE TABLAS----------------

--Creaci�n de la tabla de Usuarios--
CREATE TABLE USUARIOS(
ID_USUARIO     INT PRIMARY KEY  IDENTITY (1,1),
USUARIO        VARCHAR				     (30),
PASS           binary					 (64),
TIPO_USUARIO   VARCHAR				     (30)
)ON [PRIMARY]
GO
---INSERTAR DATOS DE USUARIOS-
INSERT INTO USUARIOS VALUES ('TORRES',HASHBYTES('SHA2_512','00000'),'ADMINISTRADOR')
GO
INSERT INTO USUARIOS VALUES ('CASAS',HASHBYTES('SHA2_512','00000'),'EMPLEADO')
GO
INSERT INTO USUARIOS VALUES ('Pepito',HASHBYTES('SHA2_512','12345'),'ADMINISTRADOR')
GO
INSERT INTO USUARIOS VALUES ('Salazar',HASHBYTES('SHA2_512','1022'),'ADMINISTRADOR')
GO
--Creaci�n de la tabla Administrador--

CREATE TABLE ADMINISTRADOR(
ID_ADMIN       INT PRIMARY KEY IDENTITY   (1,1),
ID_USUARIO     INT FOREIGN KEY REFERENCES USUARIOS
)
GO
--Creaci�n de la tabla Empleado--

CREATE TABLE EMPLEADO(
ID_EMPLEADO    INT PRIMARY KEY IDENTITY   (1,1),
ID_USUARIO     INT FOREIGN KEY REFERENCES USUARIOS
)
GO
--Creaci�n de la tabla Productos--
CREATE TABLE PRODUCTOS(
ID_PRODUCTOS   INT PRIMARY KEY IDENTITY (1,1),
PRODUCTO       VARCHAR				    (30),
PRECIO         INT ,
CANTIDAD       INT,
CATEGORIA      VARCHAR				    (30),
DESCRIPCION    VARCHAR				    (60),
FORMAPAGO      VARCHAR				    (10)
)
GO
--Creaci�n de la tabla Proveedores--

CREATE TABLE PROVEEDORES(
ID_PROVEEDORES INT PRIMARY KEY IDENTITY (1,1),
NOMBRES		   NVARCHAR					(30),
RUC			   INT,
DIRECCION	   NVARCHAR					(50)
)
GO

-- Creaci�n de la tabla Clientes----

CREATE TABLE CLIENTES(
ID_CLIENTES    INT PRIMARY KEY IDENTITY (1,1),
CLIENTE		   VARCHAR					(30),
DIRECCION      VARCHAR					(60),
DNI			   INT,
NUMCELULAR     INT
)
GO
--Creaci�n de la tabla DaashBoard--

CREATE TABLE DASHBOARD
(
ID_DASH		   int identity(1,1) primary key,
ID_EMPLEADO    INT FOREIGN KEY REFERENCES EMPLEADO,
ID_PRODUCTOS   INT FOREIGN KEY REFERENCES PRODUCTOS,
ID_CLIENTES    INT FOREIGN KEY REFERENCES CLIENTES,
ID_PROVEDORES  INT FOREIGN KEY REFERENCES PROVEEDORES
)
GO
--Creaci�n de la tabla Venta--

CREATE TABLE VENTA(
ID_VENTA	   INT PRIMARY KEY IDENTITY(1,1),
ID_CLIENTE     INT,
ID_PRODUCTO    INT,
NOM_V		   VARCHAR				   (20),
FECHA	   	   date,
CANT_PED	   INT,
TOTAL		   DECIMAL			       (18,2),
foreign key (ID_CLIENTE) REFERENCES CLIENTES (ID_CLIENTES),
foreign key (ID_PRODUCTO) REFERENCES PRODUCTOS (ID_PRODUCTOS)
)
GO


--CREAR PROCEDIMIENTOS ALMACENADOS DE USUARIOS

create procedure  USUARIOLOGIN
	@USUARIO varchar(20),
	@PASS    varchar(64)
AS
BEGIN
	SELECT *FROM Usuarios WHERE Usuario = @USUARIO
			     AND pass = HASHBYTES('SHA2_512',@PASS)
END
GO


---PROCEDIMIENTOS ALMACENADOS DE USUARIOS---

--INSERTAR  PROCEDIMIENTO DE USUARIOS ---

CREATE PROC INSERTAR_USUARIO
@USUARIO      VARCHAR   (20),
@PASS		  VARBINARY (64),
@TIPO_USUARIO VARCHAR   (30)
AS
INSERT INTO USUARIOS VALUES (@USUARIO, HASHBYTES('SHA2_512',@PASS),@TIPO_USUARIO)
GO

---PROCEDIMIENTO ALMACENADO DE MOSTRAR USUARIOS

CREATE PROC MOSTRAR_USU
AS
SELECT ID_USUARIO,USUARIO, TIPO_USUARIO FROM USUARIOS
GO

---PROCEDIMIENTO ALMACENADO DE EDITAR USUARIO--------

CREATE PROCEDURE EDITAR_USUARIO
@ID_USUARIO		INT,
@USUARIO		VARCHAR (30),
@TIPOUSUARIO    VARCHAR(30)
AS
UPDATE USUARIOS SET USUARIO=@USUARIO, TIPO_USUARIO=@TIPOUSUARIO WHERE ID_USUARIO=@ID_USUARIO
GO

---PROCEDIMIENTO DE ELIMINAR USUARIO---

CREATE PROC ELIMINAR_USUARIO
@ID_USUARIO		INT
AS
DELETE FROM USUARIOS WHERE ID_USUARIO=@ID_USUARIO
GO

---- PROCEDIMIENTOS ALMACENADOS DE CLIENTES
---PROCEDIMINETO ALMACENADO DE INSERTAR---
CREATE PROC INSERTAR_CLIENTES
@CLIENTE    VARCHAR (30),
@DIRECCION  VARCHAR (60),
@DNI		INT,
@NUMCELULAR INT
AS
INSERT INTO CLIENTES VALUES (@CLIENTE,@DIRECCION,@DNI,@NUMCELULAR)
GO
-- Procedimiento almacenado para Buscar Clientes---
create proc Buscar_Cliente
(
@ID_CLIENTE		INT
)
as
begin
select * from CLIENTES where ID_CLIENTES = @ID_CLIENTE
end
GO

---PROCEDIMINETOS ALMACENADOS DE MOSTRAR---
CREATE PROC MOSTRAR_CLIENTES
AS
SELECT *FROM CLIENTES
GO

---PROCEDIMIENTO ALMACENADA EDITAR CLIENTES
CREATE PROC EDITAR_CLIENTES
@ID_CLIENTES	INT,
@CLIENTE		VARCHAR (30),
@DIRECCION		VARCHAR (60),
@DNI			INT,
@NUMCELULAR		INT
AS
UPDATE CLIENTES SET CLIENTE=@CLIENTE, DIRECCION=@DIRECCION, DNI=@DNI, 
	   NUMCELULAR=@NUMCELULAR WHERE ID_CLIENTES=@ID_CLIENTES
GO

---PROCEDIMIENTO ALMACENADA DE ELIMINAR CLIENTES
CREATE PROC ELIMINAR_CLIENTE
@ID_CLIENTES INT
AS
DELETE FROM CLIENTES WHERE ID_CLIENTES = @ID_CLIENTES
GO

---FIN DE PROCEDIMIENTOS ALMACENADOS DE CLIENTES---

----PROCEDIMIENTOS ALMACENADOS DE PRODUCTOS---

----PROCEDIMIENTOS ALMACENADOS DE INSERTAR PRODUCTO---
CREATE PROC INSERTAR_PRODUCTOS
@PRODUCTO	  VARCHAR (30),
@PRECIO	   	  INT ,
@CANTIDAD	  INT,
@CATEGORIA	  VARCHAR (30),
@DESCRIPCION  VARCHAR (60),
@FORMAPAGO    VARCHAR (10)
AS
INSERT INTO PRODUCTOS VALUES (@PRODUCTO,@PRECIO,@CANTIDAD,@CATEGORIA,@DESCRIPCION,@FORMAPAGO)
GO

-- Procedimiento almacenado para Mostrar Producto-----

create proc Buscar_Producto
(
@ID_PRODUCTO	INT
)
as
begin
select * from PRODUCTOS where ID_PRODUCTOS = @ID_PRODUCTO
end
go

---PROCEDIMIENTOS ALMACENADOS DE MOSTRAR---

CREATE PROC MOSTRAR_PRODUCTOS
AS
SELECT *FROM PRODUCTOS
GO

---PROCEDIMIENTO ALMACENADO DE EDITAR PRODUCTOS

CREATE PROC EDITAR_PRODUCTOS
@ID_PRODUCTOS  INT,
@PRODUCTO      VARCHAR (20),
@PRECIO		   INT,
@CANTIDAD      INT,
@CATEGORIA     VARCHAR (30),
@DESCRIPCION   VARCHAR (60),
@FORMAPAGO     VARCHAR (10)
AS
UPDATE PRODUCTOS SET PRODUCTO=@PRODUCTO, PRECIO=@PRECIO, 
       CANTIDAD=@CANTIDAD,CATEGORIA=@CATEGORIA, DESCRIPCION=@DESCRIPCION, 
	   FORMAPAGO=@FORMAPAGO WHERE ID_PRODUCTOS=@ID_PRODUCTOS
GO

---PROCEDIMIENTO ALMACENADO DE ELIMINIAR PRODUCTOS

CREATE PROC ELIMINAR_PROD
@ID_PRODUCTOS INT
AS
DELETE FROM PRODUCTOS WHERE ID_PRODUCTOS = @ID_PRODUCTOS
GO

---FIN DE PROCEDIMIENTOS ALMACENADOS DE PRODUCTOS---

---PROCEDIMIENTOS ALMACENADOS DE PROVEEDORES---

---PROCEDIMIENTO ALMACENADO DE INSERTAR PROVEEDORES---

CREATE PROC INSERTAR_PROVEE
@PROVEEDOR  NVARCHAR (30),
@RUC		INT,
@DIRECCION  NVARCHAR (50)
AS
INSERT INTO PROVEEDORES VALUES (@PROVEEDOR,@RUC,@DIRECCION)
GO

---PROCEDIMIENTO ALMACENADO DE MOSTRAR PROVEEDOR---

CREATE PROC MOSTRAR_PROVEE
AS
SELECT *FROM PROVEEDORES
GO


---PROCEDIMIENTO ALMACENADO DE EDITAR PROVEEDOR---
CREATE PROC EDITAR_PROVEEDOR
@ID_PROVEEDORES INT,
@NOMBRES		NVARCHAR (30),
@RUC			INT,
@DIRECCION      NVARCHAR (50)
AS
UPDATE PROVEEDORES SET NOMBRES=@NOMBRES, RUC=@RUC, 
	   DIRECCION=@DIRECCION WHERE ID_PROVEEDORES=@ID_PROVEEDORES
GO

---PROCEDIMIENTO ALMACENADO DE ELIMINAR PROVEEDORES---

CREATE PROC ELIMINAR_PROVEEDOR
@ID_PROVEEDORES INT
AS
DELETE FROM PROVEEDORES WHERE ID_PROVEEDORES = @ID_PROVEEDORES
GO

---FIN DE PROCEDIMIENTOS ALMACENADOS DE PROVEEDORES---

------PROCEDIMIENTOS ALMACENADOS PARA REPORTES
create procedure mostar_fac
as
select 
v.ID_VENTA as cod_factura,
v.Nom_v as vendedor,
v.FECHA as fecha,
c.CLIENTE as nombre_cliente,
prd.PRODUCTO as producto,
prd.PRECIO as precio,
v.CANT_PED as cantidad,
v.TOTAL as total
from VENTA v
inner join CLIENTES c on c.ID_CLIENTES = v.ID_CLIENTE
inner join PRODUCTOS prd on prd.ID_PRODUCTOS = V.ID_PRODUCTO
GO

create procedure Reg_ven
(
@ID_CLIENTE INT,
@ID_PRODUCTO INT,
@NOM_V VARCHAR (20),
@FECHA date,
@CANT_PED INT,
@TOTAL DECIMAL (18,2)
)
AS
insert into VENTA values (@ID_CLIENTE,@ID_PRODUCTO, @NOM_V, @FECHA, @CANT_PED, @TOTAL)
GO