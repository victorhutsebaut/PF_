-- Creación de la tabla Bicicletas si no existe
IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Bicicletas')
BEGIN
    CREATE TABLE Bicicletas (
        ID INT PRIMARY KEY IDENTITY,
        NombreModelo VARCHAR(100),
        Descripcion TEXT,
        Tipo VARCHAR(50),
        Precio DECIMAL(10, 2)
    );
END

-- Creación de la tabla Motores si no existe
IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Motores')
BEGIN
    CREATE TABLE Motores (
        ID INT PRIMARY KEY IDENTITY,
        Nombre VARCHAR(100),
        Descripcion VARCHAR(255),
        Potencia VARCHAR(50),
        Precio DECIMAL(10, 2)
    );
END

-- Creación de la tabla Baterias si no existe
IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Baterias')
BEGIN
    CREATE TABLE Baterias (
        ID INT PRIMARY KEY IDENTITY,
        Nombre VARCHAR(100),
        Descripcion VARCHAR(255),
        Potencia VARCHAR(50),
        Precio DECIMAL(10, 2)
    );
END

-- Insertar datos en la tabla Bicicletas
INSERT INTO Bicicletas (NombreModelo, Descripcion, Tipo, Precio)
SELECT 'Carretera', 'Bicicleta diseñada para velocidad en carretera.', 'Carretera', 1200.00
WHERE NOT EXISTS (SELECT 1 FROM Bicicletas WHERE NombreModelo = 'Carretera');

INSERT INTO Bicicletas (NombreModelo, Descripcion, Tipo, Precio)
SELECT 'Paseo', 'Bicicleta cómoda para paseos casuales.', 'Urbana', 600.00
WHERE NOT EXISTS (SELECT 1 FROM Bicicletas WHERE NombreModelo = 'Paseo');

INSERT INTO Bicicletas (NombreModelo, Descripcion, Tipo, Precio)
SELECT 'Montaña', 'Bicicleta robusta para terrenos montañosos.', 'Montaña', 1000.00
WHERE NOT EXISTS (SELECT 1 FROM Bicicletas WHERE NombreModelo = 'Montaña');

-- Insertar datos en la tabla Motores
INSERT INTO Motores (Nombre, Descripcion, Potencia, Precio)
SELECT 'Motor Básico 250W', 'Motor de 250W', '250W', 250.00
WHERE NOT EXISTS (SELECT 1 FROM Motores WHERE Nombre = 'Motor Básico 250W');

INSERT INTO Motores (Nombre, Descripcion, Potencia, Precio)
SELECT 'Motor Avanzado 500W', 'Motor de 500W', '500W', 350.00
WHERE NOT EXISTS (SELECT 1 FROM Motores WHERE Nombre = 'Motor Avanzado 500W');

-- Insertar datos en la tabla Baterias
INSERT INTO Baterias (Nombre, Descripcion, Potencia, Precio)
SELECT 'Batería Estándar 48V', 'Batería de ion de litio 48V', '48V', 450.00
WHERE NOT EXISTS (SELECT 1 FROM Baterias WHERE Nombre = 'Batería Estándar 48V');

INSERT INTO Baterias (Nombre, Descripcion, Potencia, Precio)
SELECT 'Batería Compacta 36V', 'Batería de ion de litio 36V', '36V', 350.00
WHERE NOT EXISTS (SELECT 1 FROM Baterias WHERE Nombre = 'Batería Compacta 36V');

-- Crear la tabla administradores si no existe
IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'administradores')
BEGIN
    CREATE TABLE administradores (
        usuario VARCHAR(50) PRIMARY KEY,
        contraseña VARCHAR(50)
    );
END

-- Insertar datos en la tabla administradores
INSERT INTO administradores (usuario, contraseña)
SELECT 'admin1', 'contraseña1'
WHERE NOT EXISTS (SELECT 1 FROM administradores WHERE usuario = 'admin1');

-- Crear la tabla usuarios si no existe
IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'usuarios')
BEGIN
    CREATE TABLE usuarios (
        usuario VARCHAR(50) PRIMARY KEY,
        contraseña VARCHAR(50) NOT NULL
    );
END

-- Insertar datos en la tabla usuarios
INSERT INTO usuarios (usuario, contraseña)
SELECT 'usuario1', 'contraseña1'
WHERE NOT EXISTS (SELECT 1 FROM usuarios WHERE usuario = 'usuario1');

-- Crear la tabla ModelosPreestablecidos si no existe
IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'ModelosPreestablecidos')
BEGIN
    CREATE TABLE ModelosPreestablecidos (
        ModeloID INT PRIMARY KEY IDENTITY,
        NombreModelo VARCHAR(100),
        Descripcion TEXT,
        PrecioBase DECIMAL(10, 2),
        BateriaID INT,
        MotorID INT,
        Imagen VARBINARY(MAX), -- Nueva columna para la imagen
        FOREIGN KEY (BateriaID) REFERENCES Baterias(ID),
        FOREIGN KEY (MotorID) REFERENCES Motores(ID)
    );
END

-- Crear la tabla Compras si no existe
IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Compras')
BEGIN
    CREATE TABLE [dbo].[Compras] (
        [id_compra]       INT             IDENTITY (1, 1) NOT NULL,
        [Nombre_Bicicleta] VARCHAR (100)   NULL,
        [Nombre_Bateria]   VARCHAR (100)   NULL,
        [Nombre_Motor]     VARCHAR (100)   NULL,
        [Precio_Total]     DECIMAL (10, 2) NULL,
        PRIMARY KEY CLUSTERED ([id_compra] ASC)
    );
END
