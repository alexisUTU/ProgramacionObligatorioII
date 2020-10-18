CALL agregarAListaDeCompra(2,true);
CALL comprar;
call cancelarCompra;
UPDATE ARTICULOS SET comprado=0 WHERE id_articulo=2;