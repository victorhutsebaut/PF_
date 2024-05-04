INSERT INTO Bicicletas (NombreModelo, Descripcion, Tipo,Precio)
VALUES ('Modelo X', 'Bicicleta eléctrica de alto rendimiento con batería de larga duración', 'Montaña', 1500.00),
       ('Modelo Y', 'Bicicleta eléctrica para la ciudad, ligera y versátil', 'Urbana', 1200.00);

-- Inserción en la tabla Motores con el nuevo campo Nombre
INSERT INTO Motores (Nombre, Descripcion, Potencia,Precio)
VALUES ('Motor Básico 250W', 'Motor de 250W', '250W', 250.00),
       ('Motor Avanzado 500W', 'Motor de 500W', '500W', 350.00);

-- Inserción en la tabla Baterias con el nuevo campo Nombre
INSERT INTO Baterias (Nombre, Descripcion, Potencia,Precio)
VALUES ('Batería Estándar 48V', 'Batería de ion de litio 48V', '48V', 450.00),
       ('Batería Compacta 36V', 'Batería de ion de litio 36V', '36V', 350.00);