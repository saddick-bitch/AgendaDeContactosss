-- 1. Crear la base de datos
CREATE DATABASE AgendaDB;
GO

-- 2. Usar la base de datos
USE AgendaDB;
GO

-- 3. Crear tabla de Contactos
CREATE TABLE Contactos (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Apellido NVARCHAR(100) NOT NULL,
    Telefono NVARCHAR(20) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    Direccion NVARCHAR(200),
    FechaNacimiento DATE,
    Notas NVARCHAR(MAX)
);
GO

-- (Opcional) Tabla de Categor�as si planeas agrupar contactos
CREATE TABLE Categorias (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(50) NOT NULL
);
GO

-- (Opcional) Relaci�n entre Contactos y Categor�as
ALTER TABLE Contactos
ADD CategoriaId INT FOREIGN KEY REFERENCES Categorias(Id);
GO

