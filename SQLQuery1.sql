CREATE TABLE [dbo].[Carrito] (
    [id_carrito]       INT             IDENTITY (1, 1) NOT NULL,
    [Nombre_Bicicleta] VARCHAR (100)   NULL,
    [Nombre_Bateria]   VARCHAR (100)   NULL,
    [Nombre_Motor]     VARCHAR (100)   NULL,
    [Precio_Total]     DECIMAL (10, 2) NULL,
    PRIMARY KEY CLUSTERED ([id_carrito] ASC)
);