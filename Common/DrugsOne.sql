CREATE DATABASE Drugs_One

CREATE TABLE UnidadManejo(
	IDUnidadManejo int IDENTITY(1,1) NOT NULL,
	abreviaturaUM nvarchar (10) NOT NULL,
	Descripcion nvarchar(max) NOT NULL,
 CONSTRAINT PK_UnidadManejo PRIMARY KEY (IDUnidadManejo));

	INSERT INTO UnidadManejo(abreviaturaUM,Descripcion)
							   VALUES('SOB', 'Sobre'),	
									 ('CJA', 'Caja'),
									 ('COM', 'Comprimido'),
									 ('FCO', 'Frasco'),
									 ('AMP', 'Ampolla'),
									 ('SUP', 'Supositorio'),
									 ('OVU', 'Ovulo'),
									 ('TUB', 'Tubo'),
									 ('PZA', 'Pieza'),
									 ('JGO', 'Juego'),
									 ('ROL', 'Rollo'),
									 ('EQU', 'Equipo'),
									 ('BOL', 'Bolsa'),
									 ('CCC', 'Centímetros Cúbicos'),
									 ('LTR', 'Litros'),
									 ('GLN', 'Galón'),
									 ('GRM', 'Gramo'),
									 ('JRG', 'Jeringa'),
									 ('BLO', 'Block'),
									 ('HJA', 'Hoja'),
									 ('PAR', 'Par'),
									 ('PQT', 'Paquete'),
									 ('SET', 'Set'),
									 ('MTR', 'Metro');   
									 

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

CREATE TABLE Impuesto(
	IdImpuesto int IDENTITY(1,1) NOT NULL,
	Descripcion nvarchar(max) NOT NULL,
	Tarifa decimal NOT NULL,
CONSTRAINT PK_IdImpuesto PRIMARY KEY (IdImpuesto));
  INSERT INTO Impuesto( Descripcion,Tarifa)
          VALUES('Exluido',0),
		        ('Exento',0),
		        ('IVA 10%',10),
                ('IVA 16%',16);									 
									 
CREATE TABLE  Producto(
	 IDProducto   nvarchar (20) NOT NULL,
	 Descripcion   nvarchar (max) NOT NULL,
	 IDUnidadManejo   int  NOT NULL,
	 IDAlmacen   int  NOT NULL,
	 IdImpuesto int not null,
	 Precio   money  NOT NULL,
	 CantidadKardex numeric (18, 2) NOT NULL,
	 CantidadVigente numeric (18, 2) NOT NULL,
	 StockMinimo numeric (18, 2) NULL,
	 Estado bit not null,
	 UsoRestringido   nvarchar (max) NOT NULL,
	 
 CONSTRAINT  PK_Producto  PRIMARY KEY (IDProducto),
 CONSTRAINT fk_ProductoIDAlmacen FOREIGN KEY (IDAlmacen) REFERENCES Almacen(IDAlmacen),
 CONSTRAINT fk_ProductoIdImpuesto FOREIGN KEY (IdImpuesto) REFERENCES Impuesto(IdImpuesto),
 CONSTRAINT fk_ProductoIDUnidadManejo FOREIGN KEY (IDUnidadManejo) REFERENCES UnidadManejo(IDUnidadManejo));
 
 
$('  # ',' @ ', ? , & ,' = '),


SELECT IDProducto,Producto.Descripcion,UnidadManejo.abreviaturaUM AS UM, Almacen.Descripcion AS IDAlmacen,Impuesto.Descripcion AS Impuesto,Precio,CantidadKardex,CantidadVigente,StockMinimo,Estado,UsoRestringido 
                                            FROM Producto 
                                            INNER JOIN Almacen ON Producto.IDAlmacen = Almacen.IDAlmacen 
                                            INNER JOIN Impuesto ON Producto.IDImpuesto = Impuesto.IDImpuesto 
											INNER JOIN UnidadManejo ON Producto.IDUnidadManejo = UnidadManejo.IDUnidadManejo 
                                            ORDER BY IDProducto asc
											
											CREATE TABLE Barra(
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
	


CREATE TABLE  TipoDocumento(
	 IDTipoDocumento   int  IDENTITY(1,1) NOT NULL,
	 Descripcion   nvarchar (max) NOT NULL,
     CONSTRAINT  PK_TipoDocumento  PRIMARY KEY (IDTipoDocumento));

	 INSERT INTO TipoDocumento (Descripcion) 	 VALUES('NIT'),('CI'),('CargoAbono');
	 GO


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
	
			
	CREATE TABLE Compra(
	IDCompra int IDENTITY(1,1) NOT NULL,
	Fecha datetime NOT NULL,
	IDProveedor int NOT NULL,
	IDDeposito int NOT NULL,
	NumFactura   nvarchar (30) NOT NULL,
	NumConvocatoria  nvarchar (30) NOT NULL,
	NumPedido  nvarchar (30) NOT NULL,
	Liquidacion  nvarchar (30) NOT NULL,
	Nota  nvarchar (max) NOT NULL,
	CostoTotal decimal NOT NULL,
    CONSTRAINT PK_Compra PRIMARY KEY (IDCompra),
    CONSTRAINT fk_CompraProveedor FOREIGN KEY (IDProveedor) REFERENCES Proveedor(IDProveedor),
    CONSTRAINT fk_CompraDeposito FOREIGN KEY (IDDeposito) REFERENCES Deposito(IDDeposito)); 
	select * from Compra
			
			
	CREATE TABLE InventarioDetalle(
	IDLinea int IDENTITY(1,1) NOT NULL,
	IDInventario int NOT NULL,
	IDProducto nvarchar (20) NULL,
	Descripcion nvarchar(max) NOT NULL,
	Costo decimal NOT NULL,
	Cantidad int NOT NULL,
    Lote nvarchar(max) NOT NULL,
    FechaVencimiento datetime NOT NULL,
	PorcentajeIVA decimal NOT NULL,
	Laboratorio  nvarchar (30) NOT NULL,
	Procedencia  nvarchar (30) NOT NULL,
	IDKardex int NULL,
	CONSTRAINT PK_InventarioDetalle PRIMARY KEY (IDLinea),
	CONSTRAINT fk_InventarioDetalle FOREIGN KEY (IDInventario) REFERENCES Inventario(IDInventario),
	CONSTRAINT fk_InventarioDetalleProducto FOREIGN KEY (IDProducto) REFERENCES Producto(IDProducto),
	CONSTRAINT fk_InventarioDetalleKardex FOREIGN KEY (IDKardex) REFERENCES Kardex(IDKardex)); 
	 
	 
	 
	CREATE TABLE Inventario(
	IDIventario int IDENTITY(1,1) NOT NULL,
	Fecha datetime NOT NULL,
	IDDeposito int NOT NULL,
	CONSTRAINT PK_Inventario PRIMARY KEY (IDIventario),
	CONSTRAINT fk_CompraDeposito FOREIGN KEY (IDDeposito) REFERENCES Deposito(IDDeposito));
 
 
    CREATE TABLE InventarioDetalle(
	IDLinea int IDENTITY(1,1) NOT NULL,
	IDInventario int NOT NULL,
	IDProducto int NOT NULL,
	Descripcion nvarchar(max) NOT NULL,
	Costo decimal NOT NULL,
	Cantidad int NOT NULL,
    Lote nvarchar(max) NOT NULL,
    FechaVencimiento datetime NOT NULL,
	PorcentajeIVA decimal NOT NULL,
	Laboratorio  nvarchar (30) NOT NULL,
	Procedencia  nvarchar (30) NOT NULL,
	IDKardex int NULL,
	CONSTRAINT PK_InventarioDetalle PRIMARY KEY (IDLinea),
	CONSTRAINT fk_InventarioDetalle FOREIGN KEY (IDInventario) REFERENCES Inventario(IDInventario),
	CONSTRAINT fk_PK_InventarioDetalleProducto FOREIGN KEY (IDProducto) REFERENCES Producto(IDProducto),
	CONSTRAINT fk_InventarioDetalleKardex FOREIGN KEY (IDKardex) REFERENCES Kardex(IDKardex)); 


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