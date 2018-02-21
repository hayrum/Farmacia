CREATE DATABASE Farmacia

USE Farmacia

CREATE TABLE Productos
(IdProducto INT PRIMARY KEY,
Nombre VARCHAR(80),
Tipo VARCHAR(80),
Descripcion TEXT,
Precio FLOAT,
Cantidad INT,
IdFarmacia INT)

CREATE PROC Mostrar

AS

SELECT * FROM Productos

GO

CREATE PROC Agregar
@IdProducto INT,
@Nombre VARCHAR(80),
@Tipo VARCHAR(80),
@Descripcion TEXT,
@Precio FLOAT,
@Cantidad INT,
@IdFarmacia INT

AS

INSERT INTO Productos VALUES(@IdProducto, @Nombre, @Tipo, @Descripcion, @Precio, @Cantidad, @IdFarmacia)

GO

EXEC Agregar 1, 'Jarabe', 'Jarabe', '15 ML', 10.00, 1, 1

CREATE PROC Modificar
@IdProducto INT,
@Nombre VARCHAR(80),
@Tipo VARCHAR(80),
@Descripcion TEXT,
@Precio FLOAT,
@Cantidad INT,
@IdFarmacia INT

AS

UPDATE Productos SET Nombre = @Nombre, Tipo = @Tipo, Descripcion = @Descripcion, Precio = @Precio, Cantidad = @Cantidad, IdFarmacia = @IdFarmacia WHERE IdProducto = @IdProducto

GO