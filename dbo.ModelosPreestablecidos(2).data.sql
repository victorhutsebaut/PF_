SET IDENTITY_INSERT [dbo].[ModelosPreestablecidos] ON
INSERT INTO [dbo].[ModelosPreestablecidos] ([ModeloID], [NombreModelo], [Descripcion], [PrecioBase], [BateriaID], [MotorID], [Imagen]) 
SELECT 6, N'Modelo de Alejandro', N'Bicicleta sencilla, pero funcional. Monoplato con 8 piñones en el casete', CAST(300.00 AS Decimal(10, 2)), 1, 2, BulkColumn
FROM OPENROWSET(BULK 'C:\Users\aleja\Downloads\Captura de pantalla 2024-05-05 162704.png', SINGLE_BLOB) as Imagen;

INSERT INTO [dbo].[ModelosPreestablecidos] ([ModeloID], [NombreModelo], [Descripcion], [PrecioBase], [BateriaID], [MotorID], [Imagen]) 
SELECT 7, N'Modelo de Edu', N'Bicicleta todoterreno con 3 platos, 8 piñones y amortiguadores en ambas ruedas', CAST(750.00 AS Decimal(10, 2)), 1, 1, BulkColumn
FROM OPENROWSET(BULK 'C:\Users\aleja\Downloads\Captura de pantalla 2024-05-05 162704.png', SINGLE_BLOB) as Imagen;

INSERT INTO [dbo].[ModelosPreestablecidos] ([ModeloID], [NombreModelo], [Descripcion], [PrecioBase], [BateriaID], [MotorID], [Imagen]) 
SELECT 8, N'Modelo de Victor', N'Bicicleta para llegar a la máxima velocidad posible. Incluye ciclocomputador Garmin', CAST(999.99 AS Decimal(10, 2)), 2, 1, BulkColumn
FROM OPENROWSET(BULK 'C:\Users\aleja\Downloads\Captura de pantalla 2024-05-05 162704.png', SINGLE_BLOB) as Imagen;
SET IDENTITY_INSERT [dbo].[ModelosPreestablecidos] OFF
