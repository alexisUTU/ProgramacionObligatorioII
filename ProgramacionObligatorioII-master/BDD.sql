DROP DATABASE IF EXISTS empresa;
CREATE DATABASE IF NOT EXISTS empresa DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE empresa;

CREATE TABLE personas (
  cedula int(11) NOT NULL PRIMARY KEY,
  foto LONGTEXT,
  primer_nombre varchar(20) NOT NULL,
  segundo_nombre varchar(20) DEFAULT NULL,
  primer_apellido varchar(20) NOT NULL,
  segundo_apellido varchar(20) DEFAULT NULL,
  telefono int(15) not null,
  direccion varchar(25) not null
);

CREATE TABLE empleados (
  cedula int(11) NOT NULL PRIMARY KEY,
  sueldoMens int(10) NOT NULL
);

 
 CREATE TABLE gerente (
	cedula int(11) NOT NULL PRIMARY KEY,
	nivel tinyint not null
 );
 
 CREATE TABLE operario (
 	cedula int(11) NOT NULL PRIMARY KEY,
	cantHoras tinyint not null,
	precioHora int not null
);
 
ALTER TABLE empleados ADD CONSTRAINT FK_empleados_personas FOREIGN KEY (cedula) REFERENCES personas (cedula);
ALTER TABLE gerente ADD CONSTRAINT FK_gerente_empleados FOREIGN KEY (cedula) REFERENCES empleados (cedula);
ALTER TABLE operario ADD CONSTRAINT fk_Operario_empleados FOREIGN KEY (cedula) REFERENCES empleados (cedula);
    
INSERT INTO personas (cedula, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido, telefono, direccion) VALUES
(5422312, 'Pedro', 'Jose', 'Pedrosa', 'Joseosa', 094232121,'Av Bolivia 2122'),
(4212312, 'Maria', 'Jose', 'Gonzales', 'Pedrosa',092311231,'Av Rivera 4421'),
(1233421, 'Mario', 'Alvaro', 'Lopes', 'Martinez',099231112,'Av Italia 4111'),
(1123223, 'Hector', 'Matep', 'Gonzalez', NULL,098343656,'Cno Carrasco 6643'),
(1124567, 'Richard', NULL, 'pias', NULL,097655342,'Av Rivera 4331'),
(2342345, 'Ricardo', NULL, 'Fort', NULL,098784787,'Av Bolivia 4321');

INSERT INTO	empleados (cedula, sueldoMens) VALUES (5422312,23500);
INSERT INTO	empleados (cedula, sueldoMens) VALUES (4212312,23500);
INSERT INTO	empleados (cedula, sueldoMens) VALUES (1233421,33500);
INSERT INTO	empleados (cedula, sueldoMens) VALUES (1123223,33500);
INSERT INTO	empleados (cedula, sueldoMens) VALUES (1124567,55500);
INSERT INTO	empleados (cedula, sueldoMens) VALUES (2342345,55500);

CREATE TABLE articulos (
  id_articulo int(11) NOT NULL AUTO_INCREMENT primary key,
  nombre varchar(20) NOT NULL,
  codigo int(11) NOT NULL,
  foto LONGTEXT,
  descripcion varchar(200) NOT NULL,
  precio decimal(5,2) NOT NULL DEFAULT 0,
  fecha_fabricacion varchar(10) NOT NULL DEFAULT '',
  comprado boolean not null default FALSE
)ENGINE  = INNODB;

CREATE TABLE personaCompra(
	id_articulo int(11) NOT NULL,
	cedula int(11) NOT NULL,
    fecha Date not null,
--    primary key (id_articulo, cedula,fecha),
	primary key (id_articulo, cedula),
	foreign key (id_articulo) references articulos(id_articulo),
    foreign key (cedula) references personas(cedula)
);
INSERT INTO articulos (nombre, codigo, foto, descripcion, precio, fecha_fabricacion) VALUES
('BOLSA',5422312, '', 'Bolsa para Lavar Ropa de 50x60cm con Cierre', 80, '31/01/2020'),
('ESCURRE PLATOS',5422313, '', 'Escurre Platos Metálico de 2 Niveles', 600, '12/03/2020'),
('FUNDA',5422314, '', 'Funda Protectora de Lavarropas Impermeable 58x62x85cm', 380, '11/02/2020'),
('TOALLITA',5422315, '', 'Toallitas Quita Esmalte de Uñas Ideal para Cartera', 70, '15/02/2020'),
('BOLSA',5422316, '', 'Bolsa para Lavar Ropa de 50x60cm con Cierre', 80, '31/01/2020');
