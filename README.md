### Mensaje para Alex

- Se vence hasta mayo we, pero sí lo van a seguir pagando. Tienes permiso.

# ERP / C Sharp

### Instalar conector para BD

- https://dev.mysql.com/downloads/connector/net/

### Normas de diseño:

Fuente:
- Fuente normal: Corbel / 12px
- Tabs: Corbel / 14px 
- (No mayúsculas, no negritas)

### Proceso de funcionamiento:

1. (Ingenieria) Se dan de alta los productos a manejar (Gama baja, media y alta) y sus respectivos componentes. Permitirá editar las lineas, sus descripciones y etapas (7).
2. (Ventas) Cliente realiza un pedido
3. (Ventas) El pedido contiene cantidad de ordenadores de cada gama ya existente
   - Ejemplo:
       - 120 Gama baja
       - 50 Gama media
       - 0 Gama alta
4. (Planeación) Se crea una planeación para cada gama (Cada pedido contendrá de 1 a 3 planeaciones).
5. (Planeación) Se comprueba si la cantidad de componentes necesarios para el total de productos está en el almacen.
   - Si no es así:
       - (Planeación / Almacen )Se advierte a el usuario que se necesitan comprar más materiales para poder producir, y se ofrece cantidad de componentes a comprar.
   - Si si se cuenta, se pasa al siguiente paso.
6. (Producción) Una vez que el estado de la planeación es "Listo para producir", se permitirá agregar una producción para esa planeación.
   Cada producción generada contendrá una fecha estimada de finalización basada en la cantidad de productos. 
   Existirán 3 lineas para producir (Linea 1 - Gama baja, Linea 2 - Gama media, Linea 3 - Gama alta).
   Cada producción estará en una linea dependiendo de la gama, y así mismo, cada linea se dividirá en 7 etapas.
   - Etapa 1 - Ensamblado de procesador y disipador en tarjeta madre.
   - Etapa 2 - Ensamblado de fuente de poder en case.
   - Etapa 3 - Ensamblado de memorias RAM y atornillado de tarjeta en case.
   - Etapa 4 - Ensamblado de tarjeta gráfica y conexión de fuente de poder.
   - Etapa 5 - Atornillado de abanicos en case y ensamblado de disco duro.
   - Etapa 6 - Conexión de botones/puertos a la tarjeta y atornillado de la tapa.
   - Etapa 7 - Empaquetado del producto final, cables y manuales.
   - Producto finalizado.
7. (Almacen) Una vez que la producción esté finalizada, se descontará la materia prima utilizada y se agregará un producto final al inventario.
8. (Ventas) Una vez que el estado de la producción cambie a ser "Finalizado", el pedido será editado y entregado a el cliente.
9. (Dashboard) Supervisará el estado de cada producción, con su respectiva linea, etapa, y el cliente al cual pertenecerá el pedido. Será actualizado en tiempo real. Permitirá avanzar las etapas de las producciones actuales.

* Todos los módulos deben contener un CRUD.
* Todos los módulos deben ofrecer la posibilidad de generar un reporte.
* Todos los módulos deben utilizar un diseño uniforme.

### Equipos a manejar:

| | Gama baja | Gama media | Gama Alta |
| --- | --- | --- | --- |
| **Procesador** | Intel Core i3 | Intel Core i5 | Intel Core i7 |
| **Memoria RAM** | 4GB DDR3 | 8GB DDR3 | 8GB DDR4 |
| **Disco duro** | 320GB 5400RPM | 500GB 7200RPM | 1TB 7200RPM + 128GB SSD |
| **Fuente de poder** | 300W | 550W | 800W 80+ |
| **Tarjeta madre** | Mini-ATX | ATX | Full ATX |
| **Case** | Mini-ATX Color negro | ATX * Color | Gamer |
| **Tarjeta gráfica** | N/A | 750Ti | GTX 1080 |
| **Disipador** | N/A | HeatSink + Aluminum | Water Cooling double fan |
| **FAN** | 1 | 2 | 3 |

# Módulo de Ingeniería

- Jose Ángel (Jefe) / Base de datos
- Yohan / Diseñador
- Roberto Migdalel / Programador

### MateriaPrima:
:key: Id_Materia | Descripcion | Proveedor | _Campos adicionales_
--- | --- | --- | ---
mat1 | Materia 1 | Proveedor 1 | etc...
mat2 | Materia 2 | Proveedor 1 | etc...

### Productos:
:key: Id_Producto | Descripción | _Campos adicionales_
--- | --- | ---
prod1 | Producto 1 | etc...
prod2 | Producto 2 | etc...

### BillMateriales:
:link: Id_Producto | :link: Id_Materia | Cantidad
--- | --- | ---
prod1 | mat1 | 2
prod1 | mat2 | 4
prod2 | mat1 | 5

# Módulo de compras
- Martín Galván (Jefe) / Programador
- Javier Velazquez / Base de datos
- Juan Carlos Delfín / Diseñador
- Ritian Zhou / IBM

### Locaciones:
:key: Id_Locacion | Descripcion | _Campos adicionales_
--- | --- | ---
loc1 | Locación 1 | etc...
loc2 | Locación 2 | etc...

### StockPrima:
:link: Id_Materia | :link: Id_Locacion | Cantidad
--- | --- | ---
mat1 | loc1 | 420
mat2 | loc2 | 80

### StockProducto:
:link: Id_Producto | :link: Id_Locacion | Cantidad
--- | --- | ---
prod1 | loc1 | 3
prod2 | loc2 | 1


# Módulo de Ventas:
- Horacio (Jefe) / IBM
- Oscar Gamez / Programador
- Alejandro Fierro /Base de datos
- David Rios / Diseñador

### Clientes:
:key: Id_Cliente | Nombre | Teléfono | _Campos adicionales_
--- | --- | --- | ---
cli1 | Cliente 1 | 123 | etc...
cli2 | Cliente 2 | 456 | etc...

### Pedidos:
:key: Id_Pedido | :link: Id_Producto | :link: Id_Cliente | Cantidad | _Campos adicionales_
--- | --- | --- | --- | ---
ped1 | prod1 | cli1 | 4 | etc...
ped2 | prod2 | cli1 | 2 | etc...

### :construction: Pagos:
:key: Id_Pago | :link: Id_Cliente | :link: Id_Pedido | Total | Fecha
--- | --- | --- | --- | ---
pag1 | cli1 | ped1 | 1483 | 10/10/17
pag2 | cli2 | ped2 | 3256 | 18/10/17

# Módulo de Planeación
- Filiberto Martinez (Jefe) / Base de datos
- Adriana Medina / Diseñador
- Mercedes Villegas / Diseñador
- Hugo Moroyoqui / Programador

### Planeaciones
:key: Id_planeacion | :link: Id_pedido | Fecha_Inicio | Fecha_Estimada | MaterialCompleto | _Campos adicionales_
--- | --- | --- | --- | --- | ---
plan1 | ped1 | 01/02/16 | 15/04/17 | Si | etc...
plan2 | ped2 | 15/02/17 | 23/05/17 | Si | etc...
plan3 | ped3 | 5/02/17 | 16/12/17 | No | etc...

# Módulo de producción
- Alex Rios (Jefe) / BD
- Ariadna Derbéz / Diseñador
- Iván López / Programador

### Producciones
:key: Id_Produccion | :link: Id_Planeacion | Etapa | _Campos adicionales_
--- | --- | --- | ---
prod1 | plan1 | 1 | etc...
prod2 | plan2 | Finalizado | etc...


# Dashboard
- Antonio Miranda / Desarrollador
  * Advertencia de poca materia
  * Pedidos
  * Producciones en proceso
  * Producciones finalizadas
  * Modelos más vendidos
  * Modelos menos vendidos
  * etc...
