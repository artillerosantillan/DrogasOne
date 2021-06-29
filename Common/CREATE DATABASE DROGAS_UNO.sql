CREATE DATABASE DROGAS_UNO

CREATE TABLE  TipoDocumento(
	 IDTipoDocumento   int  IDENTITY(1,1) NOT NULL,
	 Descripcion   nvarchar (max) NOT NULL,
     CONSTRAINT  PK_TipoDocumento  PRIMARY KEY (IDTipoDocumento));

	 INSERT INTO TipoDocumento (Descripcion) 	 VALUES('NIT'),('CI'),('CargoAbono');
	 GO

CREATE TABLE CentroSalud(
	IDCentroSalud int IDENTITY(1,1) NOT NULL,
	IDTipoDocumento int NOT NULL,
	Documento nvarchar(20) NOT NULL,
	NombreCentroSalud nvarchar(max) NOT NULL,
	NombresAdmin nvarchar(max) NOT NULL,
	ApellidosAdmin nvarchar(max) NOT NULL,
	Direccion nvarchar(max) NULL,
	Telefono nvarchar(max) NULL,
	Correo nvarchar(max) NULL,
	Aniversario datetime null,
     CONSTRAINT PK_CentroSalud PRIMARY KEY (IDCentroSalud),
     CONSTRAINT fk_CentroSaludTipoDocumento FOREIGN KEY (IDTipoDocumento) REFERENCES TipoDocumento(IDTipoDocumento));

     INSERT INTO CentroSalud( IDTipoDocumento,Documento,NombreCentroSalud,NombresAdmin,ApellidosAdmin,Direccion,Telefono,Correo,Aniversario)
		VALUES(1,'45-565','Pol. Manco Kapac','Martin','Contreras Ruis','Loa 789','4555655','martian@gmail.com',1914-09-09),
			  (2,'45-564','Pol. 9 de Abril','Juan Carlos','Mamani Morales','Colon 789','4555555','juacarlos@gmail.com',1926-09-09),
			  (1,'45-777','H. Obrero','Edgar','Vidal Ramos','Bustillos 45','2225655','egarito@gmail.com',1925-09-09);


CREATE TABLE  Rol(
	 IDRol   int  IDENTITY(1,1) NOT NULL,
	 Descripcion   nvarchar (max) NOT NULL,
     CONSTRAINT  PK_Rol  PRIMARY KEY (IDRol));
	 INSERT INTO Rol (Descripcion) 	 VALUES('Adminstrador'),('Regente'),('Jefe Almacen'),('Auxiliar Of.'),('Admi.C.Salud');
	 GO

CREATE TABLE Usuario(
     IDUsuario int identity(1,1),
     LoginUsuario   nvarchar (25) NOT NULL,
	 Nombres   nvarchar (max) NOT NULL,
	 Apellidos   nvarchar (max) NOT NULL,
	 Password  nvarchar (15) NOT NULL,
	 FechaModificacionClave   date  NOT NULL,
	 IDRol   int  NOT NULL,
	 Email nvarchar(150)not null
     CONSTRAINT  PK_Usuario  PRIMARY KEY (IDUsuario),
     CONSTRAINT fk_UsuarioRol FOREIGN KEY (IDRol) REFERENCES Rol(IDRol));

      INSERT INTO Usuario (LoginUsuario, Nombres, Apellidos, Password, FechaModificacionClave, IDRol, Email)
                 	 VALUES('manuelsantillan','Manuel','Santillan Morales','123','2014-06-11',1, 'artillerosantillan@hotmail.com'),
							('margaret','Margarita','Murillo Rodriguez ','123','2015-07-11',1,'margarita666@hotmail.com'),
							('LoginUsuario','Martin','Fierros Ortubes','123','2014-08-11',2, 'fierros.martin@gmail.com'),
							('claraluz','Clara Luz','Zambrana Mamani','123','2016-06-11',3, 'clara.luz.z@hotmail.com'),
							('Alfredoo','Alfredo Orlando','Nievez Azul','123','2012-06-04',4, 'alfreditoo@gmail.com'),
							('Omarito','Omar Daniel','Poma Cuti','123','2018-02-11',4,'omarito69@gmail.com.com');    



	CREATE TABLE Proveedor(
     IDProveedor   int  IDENTITY(1,1) NOT NULL,
	 Nombre   nvarchar (max) NOT NULL,
	 IDTipoDocumento   int  NOT NULL,
	 Documento   nvarchar (20) NOT NULL,
	 NombresContacto   nvarchar (max) NOT NULL,
	 ApellidosContacto   nvarchar (max) NOT NULL,
	 Direccion   nvarchar (max) NULL,
	 Telefono   nvarchar (max) NULL,
	 Email   nvarchar (max) NULL,
	 CONSTRAINT  PK_Proveedor PRIMARY KEY (IDProveedor),
     CONSTRAINT fk_TipoDocumento FOREIGN KEY (IDTipoDocumento) REFERENCES TipoDocumento(IDTipoDocumento));

	   	  INSERT INTO Proveedor(Nombre,IDTipoDocumento,Documento,NombresContacto,ApellidosContacto,Direccion,Telefono,Email)
	       VALUES('IMBOLMED',1,'1252456','Jorge Antonio','Marting Valenzuela','Junin123','2245125','Marting.Valenzuela@gamil.com'),
		    ('COSIN LTDA',1,'1252446','Daniel ','Mamani Nieves','Eloy salmon 123','22451111','cosin@gamil.com'),
		    ('BLANCO Y NEGRO',1,'1252456','Jorge Antonio','Martins Varron','calle 2 Obrajes','4525877','crespal@gamil.com'),
			('FARMEDICAL',1,'1252456','Jorge Antonio','Marting Valenzuela','Junin123','2245125','Marting.Valenzuela@gamil.com'),
			('LAB. IFA S.A.',1,'1252457','Juan Manuel','Calderon Megia','AV. Vasquez 458','2145125','ifa@gamil.com'),
			('LAQFAGAL FARMA INDUSTRIA S.R.L.',1,'1252410','Maria ','Silez','P. Salmon 13','221125','fharma.industra@gmail.com');


	CREATE TABLE UnidadManejo(
	IDUnidadManejo nvarchar (10) NOT NULL,
	IDUnidadManejo nvarchar (10) NOT NULL,
	Descripcion nvarchar(max) NOT NULL,
 CONSTRAINT PK_UnidadManejo PRIMARY KEY (IDUnidadManejo));

	INSERT INTO UnidadManejo(IDUnidadManejo,Descripcion)
							   VALUES('Sob', 'Sobre'),	
									 ('Cja', 'Caja'),
									 ('Com', 'Comprimido'),
									 ('Fco', 'Frasco'),
									 ('Amp', 'Ampolla'),
									 ('Sup', 'Supositorio'),
									 ('Ovu', 'Ovulo'),
									 ('Tub', 'Tubo'),
									 ('Pza', 'Pieza'),
									 ('Jgo', 'Juego'),
									 ('Rol', 'Rollo'),
									 ('Equ', 'Equipo'),
									 ('Bol', 'Bolsa'),
									 ('Ccc', 'Centímetros Cúbicos'),
									 ('Ltr', 'Litros'),
									 ('Gln', 'Galón'),
									 ('Grm', 'Gramo'),
									 ('Jrg', 'Jeringa'),
									 ('Blo', 'Block'),
									 ('Hja', 'Hoja'),
									 ('Par', 'Par'),
									 ('Pqt', 'Paquete'),
									 ('Set', 'Set'),
									 ('Mtr', 'Metro');      

	CREATE TABLE  Almacen(
	 IDAlmacen  int  IDENTITY(1,1) NOT NULL,
	 Descripcion   nvarchar (max) NOT NULL,
 CONSTRAINT  PK_IDAlmacen  PRIMARY KEY (IDAlmacen)); 
 	INSERT INTO Almacen(Descripcion)
							   VALUES('Drogas 1'),
							         ('Drogas 2'),
							         ('Quirurgico 1'),
									 ('Quirurgico 2'),
									 ('Material en Gral.'),
									 ('Papeleria'),
									 ('Lubricantes'),
									 ('Equipos en Gral.');	
select * from Almacen


CREATE TABLE IVA(
	IDIVA int IDENTITY(1,1) NOT NULL,
	Descripcion nvarchar(max) NOT NULL,
	Tarifa decimal NOT NULL,
CONSTRAINT PK_IVA PRIMARY KEY (IDIVA));
  INSERT INTO IVA( Descripcion,Tarifa)
          VALUES('Exluido',0),
		        ('Exento',0),
		        ('IVA 10%',10),
                ('IVA 16%',16);


CREATE TABLE Deposito(
	IDDeposito int IDENTITY(1,1) NOT NULL,
	Descripcion nvarchar(max) NOT NULL,
 CONSTRAINT PK_Deposito PRIMARY KEY (IDDeposito ));

     INSERT INTO Deposito(Descripcion)
          VALUES('Santiago II P1'),
                ('Santiago II Zotano'),
                ('Santiago II P2'),
                ('Entre Rios'),
                ('18 Mayo'),
                ('Lara Bich');

CREATE TABLE Barra(
	IDProducto nvarchar (20) NOT NULL,
	Barra bigint NOT NULL);

	INSERT INTO Barra(IDProducto, Barra)
VALUES('A0102 ',12312313213),
      ('A0201 ',44447775),
      ('A0202 ',1110001141),
      ('A0203 ',220000014),
      ('A0204 ',558585555),
	  ('A0205 ',222222225),
      ('A0205 ',255555555),
	  ('A0202 ',1777777011);

	  
	 CREATE TABLE  Producto (
	 IDProducto   nvarchar (20) NOT NULL,
	 Descripcion   nvarchar (max) NOT NULL,
	 IDUnidadManejo   nvarchar (10) NOT NULL,
	 IDAlmacen   int  NOT NULL,
	 IDIVA int not null,
	 Precio   money  NOT NULL,
	 Notas   nvarchar (max) NOT NULL,
	 CantidadKardex int NOT NULL,
	 CantidadVigente int NOT NULL,
 CONSTRAINT  PK_Producto  PRIMARY KEY (IDProducto),
 CONSTRAINT fk_ProductoIDAlmacen FOREIGN KEY (IDAlmacen) REFERENCES Almacen(IDAlmacen),
 CONSTRAINT fk_ProductoIDIVA FOREIGN KEY (IDIVA) REFERENCES IVA(IDIVA),
 CONSTRAINT fk_ProductoIDUnidadManejo FOREIGN KEY (IDUnidadManejo) REFERENCES UnidadManejo(IDUnidadManejo));


 alter table Producto
add Notas   text  NULL,

alter table IVA
Alter Column Tarifa decimal not null

    INSERT INTO Producto(IDProducto, Descripcion,IDUnidadManejo, IDAlmacen, Precio, Notas,IDIVA,CantidadKardex,CantidadVigente)
     VALUES  ('A0102 ',' Fluoruro de sodio','Tub',1,1000,' A  ',1,0,0),   
     ('A0201 ',' Hidróxido de aluminio y magnesio 1:1','Fco',1,1000,' A  ',1,0,0),
     ('A0202 ',' Omeprazol 20 mg','Com',1,2000,' A  ',1,0,0),
     ('A0203 ',' Ranitidina 150 mg','Com',1,6450,' A  ',1,0,0),
     ('A0204 ',' Ranitidina 50 mg','Amp',1,3000,' A  ',2,0,0),
     ('A0205 ',' Omeprazol 40 mg/ml','Amp',1,6450,' A  ',2,0,0),
     ('A0206 ',' Misoprostol 200 mcg','Com',1,1000,' R  ',3,0,0),
     ('A0301 ',' Atropina sulfato 1 mg/ml','Amp',1,2000,' A  ',4,0,0),
     ('A0302 ',' Butilbromuro de Hioscina 10 mg','Com',1,1390,' A  ',4,0,0),
     ('A0303 ',' Butilbromuro de Hioscina 0,1%','Fco',1,1390,' A  ',3,0,0),
     ('A0304 ',' Butilbromuro de Hioscina 20 mg/ml','Amp',1,1000,' A  ',3,0,0),
     ('A0306 ',' Domperidona 10 mg','Com',1,1390,' A  ',2,0,0),
     ('A0307 ',' Metoclopramida 10 mg','Com',1,1000,' A  ',2,0,0),
     ('A0308 ',' Metoclopramida 10mg / 2ml','Amp',1,2500,' A  ',1,0,0),
     ('A0309 ',' Metoclopramida 0,35% o 0,5%','Fco',1,3500,' A  ',3,0,0),
     ('A0310 ',' Propinoxato 10 mg','Com',1,3500,' A  ',2,0,0),
     ('A0311 ',' Propinoxato 5 mg/ml','Amp',1,4500,' A  ',4,0,0),
     ('A0312 ',' Simeticona 3% o 4%','Fco',1,6450,' A  ',1,0,0),
     ('A0313 ',' Simeticona 100 mg','Com',1,1390,' A  ',2,0,0),
     ('A0401 ',' Ondansetrón 8 mg','Amp',1,1390,' A  ',3,0,0),
     ('A0402 ',' Ondansetrón 8 mg','Com',1,3000,' A  ',4,0,0),
     ('A0601 ',' Aceite mineral 40%','Fco',1,3500,' A  ',2,0,0),
     ('A0602 ',' Bisacodilo 5 mg','Com',1,4500,' A  ',2,0,0),
     ('A0604 ',' Fibra natural','Sob',1,5500,' A  ',1,0,0),
     ('A0605 ',' Glicerol 2 g a 4 g (adulto)','Sup',1,2220,' A  ',4,0,0);


CREATE TABLE DepositoProducto(  
	IDDeposito int NOT NULL,
	IDProducto nvarchar (20) NOT NULL,
	Stock decimal NOT NULL,
	Minimo int NOT NULL,
	Maximo int NOT NULL,
	DiasReposicion int NOT NULL,
	CantidadMinima int NOT NULL,
    CONSTRAINT fk_DepositoProductoDeposito FOREIGN KEY (IDDeposito) REFERENCES Deposito(IDDeposito),
    CONSTRAINT fk_DepositoProductoProducto FOREIGN KEY (IDProducto) REFERENCES Producto(IDProducto));

  INSERT INTO DepositoProducto(IDDeposito, IDProducto, Stock, Minimo, Maximo, DiasReposicion, CantidadMinima)
           VALUES(1, 'A0201 ', 0, 100, 1000, 15,20),
				(2, 'A0202 ', 0, 100, 1000, 15,20),
				(1, 'A0203 ', 1, 100, 1000, 15,20),
				(2, 'A0204 ', 2, 100, 1000, 15,20),
				(2, 'A0205 ', 2, 100, 1000, 15,20),
				(1, 'A0206 ', 3, 100, 1000, 15,20),
				(2, 'A0301 ', 3, 100, 1000, 15,20),
				(1, 'A0302 ', 1, 100, 1000, 15,20),
				(1, 'A0303 ', 6, 100, 1000, 15,20),
				(1, 'A0304 ', 5, 100, 1000, 15,20);

 CREATE TABLE Compra(
	IDCompra int IDENTITY(1,1) NOT NULL,
	Fecha datetime NOT NULL,
	IDProveedor int NOT NULL,
	IDDeposito int NOT NULL,
	NumFactura   nvarchar (30) NOT NULL,
	NumConvocatoria  nvarchar (30) NOT NULL,
	Laboratorio  nvarchar (30) NOT NULL,
	NumPedido  nvarchar (30) NOT NULL,
	Liquidacion  nvarchar (30) NOT NULL,
	Procedencia  nvarchar (30) NOT NULL,
	Nota  nvarchar (max) NOT NULL,
	CostoTotal decimal NOT NULL,
    CONSTRAINT PK_Compra PRIMARY KEY (IDCompra),
    CONSTRAINT fk_CompraProveedor FOREIGN KEY (IDProveedor) REFERENCES Proveedor(IDProveedor),
    CONSTRAINT fk_CompraDeposito FOREIGN KEY (IDDeposito) REFERENCES Deposito(IDDeposito)); 
	select * from Compra




	CREATE TABLE Kardex(
	IDKardex int IDENTITY(1,1) NOT NULL,
	IDDeposito int NOT NULL,
	IDProducto   nvarchar (20) NOT NULL,
	Entidad  nvarchar (40) NOT NULL,
	Fecha datetime NOT NULL,
	Documento nvarchar(20) NOT NULL,
	Entrada decimal NOT NULL,
	Salida decimal NOT NULL,
	Saldo decimal NOT NULL,
     CONSTRAINT PK_Kardex PRIMARY KEY (IDKardex),
     CONSTRAINT fk_KardexDeposito FOREIGN KEY (IDDeposito) REFERENCES Deposito(IDDeposito),
     CONSTRAINT fk_KardexProducto FOREIGN KEY (IDProducto) REFERENCES Producto(IDProducto));

	   INSERT INTO Kardex(IDDeposito,IDProducto,Fecha,Documento,Entrada,Salida,Saldo,UltimoCosto,CostoPromedio)
          VALUES(6,'A0605',2014-09-09,'AFI001',10,0,10,1000,1000),
				(6,'A0605',2014-09-10,'AFI002',10,0,20,1000,1000),
				(6,'A0605',2014-09-11,'AFI003',20,0,40,2000,1500);


	CREATE TABLE CompraDetalle(
	IDLinea int IDENTITY(1,1) NOT NULL,
	IDCompra int NOT NULL,
	IDProducto nvarchar (20) NULL,
	Descripcion nvarchar(max) NOT NULL,
	Costo decimal NOT NULL,
	Cantidad int NOT NULL,
    Lote nvarchar(max) NOT NULL,
    FechaVencimiento datetime NOT NULL,
	IDKardex int NOT NULL,
	PorcentajeIVA decimal NOT NULL,
     CONSTRAINT PK_CompraDetalle PRIMARY KEY (IDLinea),
     CONSTRAINT fk_CompraDetalle FOREIGN KEY (IDCompra) REFERENCES Compra(IDCompra),
     CONSTRAINT fk_CopraDetalleProducto FOREIGN KEY (IDProducto) REFERENCES Producto(IDProducto),
     CONSTRAINT fk_CompraDetalleKardex FOREIGN KEY (IDKardex) REFERENCES Kardex(IDKardex)); 



	CREATE TABLE KardexPorVencimientoYLote(
	IDlinea int IDENTITY(1,1) NOT NULL,
	IDDeposito int NOT NULL,
	IDProducto   nvarchar (20) NOT NULL,
	Lote nvarchar(max) NOT NULL,
    FechaVencimiento datetime NOT NULL,
	Entrada decimal NOT NULL,
	Salida decimal NOT NULL,
	Saldo decimal NOT NULL,
	NuevoSaldo decimal NOT NULL,
     CONSTRAINT PK_VencimientoLote PRIMARY KEY (IDlinea),
     CONSTRAINT fk_VencimientoLoteDeposito FOREIGN KEY (IDDeposito) REFERENCES Deposito(IDDeposito),
     CONSTRAINT fk_VencimientoLoteProducto FOREIGN KEY (IDProducto) REFERENCES Producto(IDProducto));

-------------------------------------
INSERT INTO KardexPorVencimientoYLote VALUES(1,'A0201','45A3','02-06-2020',20,0,20,20),
											(1,'A0201','45A1','02-07-2020',40,0,40,40),
											(1,'A0201','45A2','02-07-2020',30,0,30,30)

DELETE FROM KardexPorVencimientoYLote WHERE Salida = 0 --AND NuevoSaldo =0

select * from KardexPorVencimientoYLote
select sum (Entrada) As Ultimo_Saldo from KardexPorVencimientoYLote WHERE IDDeposito=1 AND IDProducto='A0201'

@entradamin int, 


UPDATE KardexPorVencimientoYLote SET Entrada = Entrada - 5
WHERE IDDeposito=1 AND IDProducto='A0201' AND FechaVencimiento=(SELECT Min(FechaVencimiento) from KardexPorVencimientoYLote)

@entradamin entradamin =Select Entrada FROM KardexPorVencimientoYLote WHERE IDDeposito=1 AND IDProducto='A0201' AND FechaVencimiento=(SELECT Min(FechaVencimiento) from KardexPorVencimientoYLote)

DELETE FROM KardexPorVencimientoYLote WHERE entrada <= 0 OR Entrada <0--AND NuevoSaldo =0

UPDATE KardexPorVencimientoYLote SET Entrada = Entrada - entradamin 
WHERE IDDeposito=1 AND IDProducto='A0201' AND FechaVencimiento=(SELECT Min(FechaVencimiento) from KardexPorVencimientoYLote)
select * from KardexPorVencimientoYLote

---------------------------------------------------------



-----crearprocedimiento inicializar tablas	 
	CREATE PROCEDURE InicializarInventario AS
	    delete from Compra
	delete from CompraDetalle
	delete from DepositoProducto
	delete from Kardex
	delete from KardexPorVencimientoYLote
	update DepositoProducto set Stock = 0
	delete from PedidoReposicion
	delete from PedidoReposicionDetalle
	delete from DevolucionCentroSalud
	delete from DevolucionCentroSaludDetalle
	

	
	DBCC CHECKIDENT (Compra, RESEED,0)
	DBCC CHECKIDENT (CompraDetalle, RESEED,0)
	DBCC CHECKIDENT (Kardex, RESEED,0)
	DBCC CHECKIDENT (KardexPorVencimientoYLote, RESEED,0)
	DBCC CHECKIDENT (PedidoReposicionDetalle, RESEED,0)
	DBCC CHECKIDENT (DevolucionCentroSalud, RESEED,0)
	DBCC CHECKIDENT (DevolucionCentroSaludDetalle, RESEED,0)

select * FROM Compra
select * FROM CompraDetalle
select * FROM Kardex 
select * from KardexPorVencimientoYLote 
select * From PedidoReposicion
select * From PedidoReposicionDetalle
select * from DevolucionCentroSalud
select * FROM DevolucionCentroSaludDetalle
select * FROM DepositoProducto 

------------
SELECT * FROM CompraDetalle WHERE DATEDIFF (YEAR, GETDATE(),FechaVencimiento)<=9
---------------------
select Id_Producto1,Codigo ,Descripcion 

,Fecha_de_vencimiento as F_vencimiento ,Stock,empresa.Nombre_Empresa,empresa.Logo,datediff(day,Fecha_de_vencimiento,CONVERT(DATE,GETDATE ()))as [Dias Vencidos] 
FROM Producto1
CROSS JOIN EMPRESA 
where   Descripcion +codigo LIKE  '%' + @letra+'%' and Fecha_de_vencimiento <>'NO APLICA' AND Fecha_de_vencimiento <= CONVERT(DATE,GETDATE ()) 
order by (datediff(day,Fecha_de_vencimiento,CONVERT(DATE,GETDATE ()))) asc

------ ejecutar 
     EXEC InicializarInventario


	DBCC CHECKIDENT (PedidoReposicionDetalle, RESEED,0)
	DBCC CHECKIDENT (PedidoReposicion, RESEED,0)
	DBCC CHECKIDENT (Compra, RESEED,0)
	DBCC CHECKIDENT (CompraDetalle, RESEED,0)
	DBCC CHECKIDENT (Kardex, RESEED,0)



	 CREATE TABLE PedidoReposicion(
	IDPedidoReposicion int IDENTITY(1,1) NOT NULL,
	Fecha datetime NOT NULL,
	IDCentroSalud int NOT NULL,
	IDDeposito int NOT NULL,
     CONSTRAINT PK_PedidoReposicion PRIMARY KEY (IDPedidoReposicion), 
     CONSTRAINT PK_PedidoReposicionCentroSalud FOREIGN KEY (IDCentroSalud) REFERENCES CentroSalud(IDCentroSalud),
     CONSTRAINT fk_VentaPedidoReposicionDeposito FOREIGN KEY (IDDeposito) REFERENCES Deposito(IDDeposito));


	 CREATE TABLE PedidoReposicionDetalle(
	IDLinea int IDENTITY(1,1) NOT NULL,
	IDPedidoReposicion int NOT NULL,
	IDProducto   nvarchar (20) NOT NULL,
	Descripcion nvarchar(max) NOT NULL,
	Cantidad decimal NOT NULL,
	IDKardex int NOT NULL,
 CONSTRAINT PK_VentaDetalle PRIMARY KEY (IDLinea),
 CONSTRAINT PK_PedidoReposicionDetallePedidoReposicion FOREIGN KEY (IDPedidoReposicion) REFERENCES PedidoReposicion(IDPedidoReposicion),
 CONSTRAINT fk_PedidoReposicionDetalleProducto FOREIGN KEY (IDProducto) REFERENCES Producto(IDProducto),
 CONSTRAINT PK_PedidoReposicionDetalleKardex FOREIGN KEY (IDKardex) REFERENCES Kardex(IDKardex));


 ------ devolicion venta get y fill---
 SELECT PedidoReposicion.IDPedidoReposicion, CONVERT(nvarchar,PedidoReposicion.Fecha) +'. Centro Salud:' +
	CONVERT(nvarchar, PedidoReposicion.IDCentroSalud) + ' ' + CentroSalud.NombreCentroSalud as PedidoReposicion
	FROM PedidoReposicion INNER JOIN
	CentroSalud ON PedidoReposicion.IDPedidoReposicion = CentroSalud.IDCentroSalud

	CREATE TABLE DevolucionCentroSalud(
	IDDevolucionCentroSalud int IDENTITY(1,1) NOT NULL,
	Fecha datetime NOT NULL,
	IDPedidoReposicion int NOT NULL,
 CONSTRAINT PK_DevolucionCentroSalud PRIMARY KEY (IDDevolucionCentroSalud),
 CONSTRAINT PK_DevolucionCentroSaludPedidoReposicion FOREIGN KEY (IDPedidoReposicion) REFERENCES PedidoReposicion(IDPedidoReposicion));


CREATE TABLE DevolucionCentroSaludDetalle(
	IDLinea int IDENTITY(1,1) NOT NULL,
	IDDevolucionCentroSalud int NOT NULL,
	IDProducto   nvarchar (20) NOT NULL,
	Descripcion nvarchar(max) NOT NULL,
	Cantidad decimal NOT NULL,
	IDKardex int NOT NULL,
 CONSTRAINT PK_DevolucionClienteDetalle PRIMARY KEY (IDLinea),
 CONSTRAINT PK_DevolucionClienteDetalleDevolucionCentroSalud FOREIGN KEY (IDDevolucionCentroSalud) REFERENCES DevolucionCentroSalud(IDDevolucionCentroSalud),
 CONSTRAINT PK_DevolucionClienteDetalleProducto FOREIGN KEY (IDProducto) REFERENCES Producto(IDProducto),
 CONSTRAINT PK_DevolucionClienteDetalleKardex FOREIGN KEY (IDKardex) REFERENCES Kardex(IDKardex));

 /****** Object:  StoredProcedure [dbo].[GetBodegaInventario]    Script Date: 03/12/2014 3:01:15 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetBodegaInventario]
(
	@IDIventario int
)
AS
	SET NOCOUNT ON;
SELECT IDBodega FROM Inventario WHERE IDIventario = @IDIventario
GO

/****** Object:  StoredProcedure [dbo].[GetFechaInventario]    Script Date: 03/12/2014 3:01:15 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetFechaInventario]
(
	@IDIventario int
)
AS
	SET NOCOUNT ON;
SELECT fecha FROM Inventario WHERE IDIventario = @IDIventario


/****** Object:  StoredProcedure [dbo].[GetInventarioXAjustar]    Script Date: 03/12/2014 3:01:15 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetInventarioXAjustar]
(
	@IDInventario int
)
AS
	SET NOCOUNT ON;
SELECT IDLinea, IDInventario, IDProducto, Descripcion, Stock, Conteo1, Conteo2, Conteo3, Ajuste, IDKardex FROM dbo.InventarioDetalle
WHERE Stock <> Conteo1
AND Stock <> Conteo2
AND Stock <> Conteo3
AND IDInventario = @IDInventario
GO


/****** Object:  StoredProcedure [dbo].[InsertInventario]    Script Date: 03/12/2014 3:01:15 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertInventario]
(
	@Fecha datetime,
	@Paso int,
	@IDBodega int
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[Inventario] ([Fecha], [Paso], [IDBodega]) VALUES (@Fecha, @Paso, @IDBodega);
	
SELECT IDIventario FROM Inventario WHERE (IDIventario = SCOPE_IDENTITY())
GO
/****** Object:  StoredProcedure [dbo].[InsertInventarioDetalle]    Script Date: 03/12/2014 3:01:15 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertInventarioDetalle]
(
	@IDInventario int,
	@IDProducto int,
	@Descripcion nvarchar(MAX),
	@Stock float,
	@Conteo1 float,
	@Conteo2 float,
	@Conteo3 float,
	@Ajuste float
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[InventarioDetalle] ([IDInventario], [IDProducto], [Descripcion], [Stock], [Conteo1], [Conteo2], [Conteo3], [Ajuste]) VALUES (@IDInventario, @IDProducto, @Descripcion, @Stock, @Conteo1, @Conteo2, @Conteo3, @Ajuste)
GO


/****** Object:  StoredProcedure [dbo].[UpdateAjusteInventarioDetalle]    Script Date: 03/12/2014 3:01:15 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateAjusteInventarioDetalle]
(
	@Ajuste float,
	@IDLinea int
)
AS
	SET NOCOUNT OFF;
UPDATE [dbo].[InventarioDetalle] SET 
[Ajuste] = @Ajuste
WHERE [IDLinea] = @IDLinea
GO


/****** Object:  StoredProcedure [dbo].[UpdateKardexInventarioDetalle]    Script Date: 03/12/2014 3:01:15 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateKardexInventarioDetalle]
(
	@IDKardex int,
	@IDLinea int
)
AS
	SET NOCOUNT OFF;
UPDATE [dbo].[InventarioDetalle] SET 
[IDKardex] = @IDKardex 
WHERE [IDLinea] = @IDLinea
GO


/****** Object:  StoredProcedure [dbo].[UpdatePasoInventario]    Script Date: 03/12/2014 3:01:15 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdatePasoInventario]
(
	@IDIventario int
)
AS
	SET NOCOUNT OFF;
UPDATE [dbo].[Inventario] SET 
[Paso] = [Paso] + 1 
WHERE [IDIventario] = @IDIventario
GO


/****** Object:  Table [dbo].[Inventario]    Script Date: 03/12/2014 3:01:15 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventario](
	[IDIventario] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Paso] [int] NOT NULL,
	[IDBodega] [int] NOT NULL,
 CONSTRAINT [PK_Inventario] PRIMARY KEY CLUSTERED 
(
	[IDIventario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


/****** Object:  Table [dbo].[InventarioDetalle]    Script Date: 03/12/2014 3:01:15 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InventarioDetalle](
	[IDLinea] [int] IDENTITY(1,1) NOT NULL,
	[IDInventario] [int] NOT NULL,
	[IDProducto] [int] NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
	[Stock] [float] NOT NULL,
	[Conteo1] [float] NOT NULL,
	[Conteo2] [float] NOT NULL,
	[Conteo3] [float] NOT NULL,
	[Ajuste] [float] NOT NULL,
	[IDKardex] [int] NULL,
 CONSTRAINT [PK_InventarioDetalle] PRIMARY KEY CLUSTERED 
(
	[IDLinea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO