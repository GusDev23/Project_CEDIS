




CREATE TABLE Proveedor (
  idProveedor INT NOT NULL IDENTITY(1,1),
  nombre VARCHAR(50) NULL,
  direccion VARCHAR(50) NULL,
  telefono VARCHAR(45) NULL,
  PRIMARY KEY (idProveedor));


---- -----------------------------------------------------
---- Table `mydb`.`Producto`
---- -----------------------------------------------------
CREATE TABLE Producto (
  idProducto INT NOT NULL IDENTITY(1,1),
  nombre VARCHAR(45) NULL,
  marca VARCHAR(45) NULL,
  sabor VARCHAR(45) NULL,
  existencia INT NULL,
  PRIMARY KEY (idProducto));


---- -----------------------------------------------------
---- Table `mydb`.`Entrega`
---- -----------------------------------------------------
CREATE TABLE Entrega (
  idEntrega INT NOT NULL IDENTITY(1,1),
  f_idProveedor INT NOT NULL,
  f_idProducto INT NOT NULL,
  cantidad INT NULL,
  fecha DATE NULL,
  PRIMARY KEY (idEntrega),
  FOREIGN KEY (f_idProveedor) REFERENCES Proveedor(idProveedor),
  FOREIGN KEY (f_idProducto) REFERENCES Producto(idProducto));


---- -----------------------------------------------------
---- Table `mydb`.`Cliente`
---- -----------------------------------------------------
CREATE TABLE Cliente (
  idCliente INT NOT NULL,
  nombreEmpresa VARCHAR(45) NULL,
  direccion VARCHAR(45) NULL,
  telefono VARCHAR(10) NULL,
  PRIMARY KEY (idCliente));



---- -----------------------------------------------------
---- Table `mydb`.`Compra`
---- -----------------------------------------------------
CREATE TABLE Compra (
  idCompra INT NOT NULL,
  f_idCliente INT NOT NULL,
  f_idProducto INT NOT NULL,
  cantidad INT NULL,
  fechaCompra DATETIME NULL
  PRIMARY KEY (idCompra),
  FOREIGN KEY (f_idCliente) REFERENCES Cliente(idCliente),
  FOREIGN KEY (f_idProducto) REFERENCES Producto(idProducto));



---- -----------------------------------------------------
---- Table `mydb`.`Recibe`
---- -----------------------------------------------------
CREATE TABLE Recibe (
  idRecibe INT NOT NULL,
  chofer VARCHAR(45) NULL,
  fechaEntrega DATETIME NULL,
  f_idCompra INT NOT NULL,
  PRIMARY KEY (idRecibe),
  FOREIGN KEY (f_idCompra) REFERENCES Compra(idCompra));
