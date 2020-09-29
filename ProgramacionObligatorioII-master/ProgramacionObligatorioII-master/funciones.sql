
DROP PROCEDURE IF EXISTS listarEmpleados;
DROP PROCEDURE IF EXISTS listarArticulos;
DELIMITER //
CREATE PROCEDURE listarEmpleados () BEGIN
	SELECT
		e.cedula AS Cedula,
		sueldoMens AS 'Sueldo mensual',
		foto AS Foto,
		primer_nombre AS 'Primer nombre',
		segundo_nombre AS 'Segundo nombre',
		primer_apellido AS 'Primer apellido',
		segundo_apellido AS 'Segundo apellido',
		telefono AS Telefono,
		direccion AS Direccion
	FROM
		PERSONAS p 
	INNER JOIN EMPLEADOS e ON p.cedula=e.cedula;
END //
CREATE PROCEDURE listarArticulos () BEGIN
	SELECT 
		id_articulo As ID,
		codigo As 'Codigo',
		foto AS Foto,
		descripcion AS 'Descripcion',
		precio AS Precio,
		fecha_fabricacion AS 'Fecha de fabricacion'
	FROM articulos;
END //
/* 
CREATE PROCEDURE agregarArticulo(
	IN codigo int(11),
	IN foto LONGTEXT,
	IN descripcion varchar(200) ,
	IN precio decimal(5,2),
	IN fecha_fabricacion varchar(10)
) BEGIN
	INSERT INTO articulos (codigo, foto, descripcion, precio, fecha_fabricacion) VALUES (codigo,foto,descripcion,precio,fecha_fabricacion);
END //
*/


DELIMITER ;