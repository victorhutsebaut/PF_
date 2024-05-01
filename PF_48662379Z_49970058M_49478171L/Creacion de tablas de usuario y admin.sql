CREATE TABLE administradores (
    usuario VARCHAR(50) PRIMARY KEY,
    contraseña VARCHAR(50)
);
CREATE TABLE usuarios (
    usuario VARCHAR(50) PRIMARY KEY,
    contraseña VARCHAR(50) NOT NULL
);


INSERT INTO administradores (usuario, contraseña) VALUES ('admin1', 'contraseña1');
INSERT INTO [dbo].[usuarios] ([usuario], [contraseña]) VALUES (N'usuario1', N'contraseña1')