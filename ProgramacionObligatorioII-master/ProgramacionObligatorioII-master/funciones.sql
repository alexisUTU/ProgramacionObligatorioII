use empresa;
DROP PROCEDURE IF EXISTS listarEmpleados;
DROP PROCEDURE IF EXISTS listarArticulos;
DROP PROCEDURE IF EXISTS listarArticulosPorNombreProducto;

DELIMITER //

CREATE PROCEDURE listarEmpleados () BEGIN
	SELECT
		e.cedula AS Cedula,
		foto AS Foto,
		primer_nombre AS 'Primer nombre',
		segundo_nombre AS 'Segundo nombre',
		primer_apellido AS 'Primer apellido',
		segundo_apellido AS 'Segundo apellido',
		direccion AS Direccion,
		sueldoMens AS 'Sueldo mensual',
		telefono AS Telefono
	FROM
		PERSONAS p 
	INNER JOIN EMPLEADOS e ON p.cedula=e.cedula;
END //
CREATE PROCEDURE listarArticulos () BEGIN
	SELECT 
		codigo As 'Codigo',
		foto AS 'Foto',
        nombre AS 'Nombre',
		precio AS 'Precio',
		descripcion AS 'Descripcion',
		fecha_fabricacion AS 'Fecha de fabricacion',
		id_articulo As 'ID'

	FROM articulos;
END //

CREATE PROCEDURE listarArticulosPorNombreProducto (
	IN nombreProducto varchar(20)
) BEGIN
	SELECT 
		codigo As 'Codigo',
		foto AS 'Foto',
        nombre AS 'Nombre',
		precio AS 'Precio',
		descripcion AS 'Descripcion',
		fecha_fabricacion AS 'Fecha de fabricacion',
		id_articulo As 'ID'
	FROM articulos
	WHERE nombre LIKE CONCAT('%',nombreProducto,'%');
END //

DELIMITER ;