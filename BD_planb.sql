create database Estero ;
use Estero;
SET SQL_SAFE_UPDATES = 0;  -- esta linea kita el modo restrictivo
create table Pantallas(
Id_Pantalla int primary key auto_increment not null,
Nombre varchar(60),
Stock int 
);
create table Tablillas(
Id_Tablilla int primary key auto_increment not null,
Nombre varchar(60),
Stock int
);
create table Carcasas(
Id_Carcasas int primary key auto_increment not null,
Nombre varchar(60),
Stock int
);
create table Botones(
Id_Botones int primary key auto_increment not null,
Nombre varchar(60),
Stock int
);

CREATE TABLE Pedidos (
    Id_Lote INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
    Nombre_Pedido VARCHAR(60),
    Numero_Unidades int,
    Nombre_Estereo Varchar(100),
    Id_Pantalla INT NOT NULL,
    Id_Tablilla INT NOT NULL,
    Id_Carcasa INT NOT NULL,
    Id_Botones INT NOT NULL,
    CONSTRAINT FK_Estereo_Pantalla FOREIGN KEY (Id_Pantalla) REFERENCES Pantallas(Id_Pantalla),
    CONSTRAINT FK_Estereo_Tablilla FOREIGN KEY (Id_Tablilla) REFERENCES Tablillas(Id_Tablilla),
    CONSTRAINT FK_Estereo_Carcasa FOREIGN KEY (Id_Carcasa) REFERENCES Carcasas(Id_Carcasas),
    CONSTRAINT FK_Estereo_Botones FOREIGN KEY (Id_Botones) REFERENCES Botones(Id_Botones)
);
-- este es el selec que se muestra en el botn mostrar pedido
SELECT 
	Id_Lote AS Lote,
    pe.Nombre_Pedido AS Pedido,
    pe.Numero_Unidades AS Numero_Unidades,
    pe.Nombre_Estereo AS Tipo_Estero,
    p.Nombre AS Pantalla,
    t.Nombre AS Tablilla,
    c.Nombre AS Carcasa,
    b.Nombre AS Botones
FROM 
    Pedidos pe
JOIN 
    Pantallas p ON pe.Id_Pantalla = p.Id_Pantalla
JOIN 
    Tablillas t ON pe.Id_Tablilla = t.Id_Tablilla
JOIN 
    Carcasas c ON pe.Id_Carcasa = c.Id_Carcasas
JOIN 
    Botones b ON pe.Id_Botones = b.Id_Botones;


select Id_Pantalla from Pedidos where Id_Lote = 103;
select* from Tablillas;