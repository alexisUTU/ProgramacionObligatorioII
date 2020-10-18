use empresa;
DROP PROCEDURE IF EXISTS listarEmpleados;
DROP PROCEDURE IF EXISTS listarArticulos;
DROP PROCEDURE IF EXISTS listarArticulosPorNombreProducto;
DROP PROCEDURE IF EXISTS listarArticulosPorID;
/*
DROP PROCEDURE IF EXISTS agregarAListaDeCompra;
DROP PROCEDURE IF EXISTS comprar;
DROP PROCEDURE IF EXISTS cancelarCompra;
*/
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

	FROM articulos
    WHERE comprado=0;
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
	WHERE nombre LIKE CONCAT('%',nombreProducto,'%') AND comprado=0;
END //

/*
CREATE PROCEDURE agregarAListaDeCompra(
		IN id Integer,
		IN startTransaction Boolean
) BEGIN
    IF startTransaction THEN
		SET autocommit=0;
		START transaction;
    END IF;
    UPDATE ARTICULOS SET comprado=1 WHERE id_articulo=id;
END //

CREATE PROCEDURE comprar() BEGIN
	COMMIT;
	SET autocommit=1;
END //

CREATE PROCEDURE cancelarCompra() BEGIN
	ROLLBACK;
	SET autocommit=1;
END //
*/

CREATE PROCEDURE listarArticulosPorID (
	IN ids varchar(20)
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
	WHERE id_articulo IN (ids);
END //

DELIMITER ;