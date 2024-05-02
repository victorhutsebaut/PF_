-- Creación de la tabla Bicicletas
CREATE TABLE Bicicletas (
    BicicletaID INT PRIMARY KEY IDENTITY,
    NombreModelo VARCHAR(100),
    Descripcion TEXT,
    Tipo VARCHAR(50),
    PrecioBase DECIMAL(10, 2),
);

-- Creación de la tabla Motores
CREATE TABLE Motores (
    MotorID INT PRIMARY KEY IDENTITY,
    Nombre VARCHAR(100);
    Descripcion VARCHAR(255),
    Potencia VARCHAR(50),
    Precio DECIMAL(10, 2)
);

-- Creación de la tabla Baterias
CREATE TABLE Baterias (
    BateriaID INT PRIMARY KEY IDENTITY,
    Nombre VARCHAR(100);
    Descripcion VARCHAR(255),
    Potencia VARCHAR(50),
    Precio DECIMAL(10, 2)
);

-- Creación de la tabla Color
CREATE TABLE Color (
    ColorID INT PRIMARY KEY IDENTITY,
    BicicletaID INT,
    NombreColor VARCHAR(50),
    FOREIGN KEY (BicicletaID) REFERENCES Bicicletas(BicicletaID)
);

INSERT INTO Bicicletas (NombreModelo, Descripcion, Tipo, PrecioBase)
VALUES ('Modelo X', 'Bicicleta eléctrica de alto rendimiento con batería de larga duración', 'Montaña', 1500.00),
       ('Modelo Y', 'Bicicleta eléctrica para la ciudad, ligera y versátil', 'Urbana', 1200.00);

-- Inserción en la tabla Motores con el nuevo campo Nombre
INSERT INTO Motores (Nombre, Descripcion, Potencia, Precio)
VALUES ('Motor Básico 250W', 'Motor de 250W', '250W', 250.00),
       ('Motor Avanzado 500W', 'Motor de 500W', '500W', 350.00);

-- Inserción en la tabla Baterias con el nuevo campo Nombre
INSERT INTO Baterias (Nombre, Descripcion, Potencia, Precio)
VALUES ('Batería Estándar 48V', 'Batería de ion de litio 48V', '48V', 450.00),
       ('Batería Compacta 36V', 'Batería de ion de litio 36V', '36V', 350.00);

