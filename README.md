# ERP / C Sharp

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

### BillMateriales
:link: Id_Producto | :link: Id_Materia | Cantidad
--- | --- | ---
prod1 | mat1 | 2
prod1 | mat2 | 4

# Módulo de compras
- Martín Galván (Jefe) / Programador
- Javier Velazquez / Base de datos
- Juan Carlos Delfín / Diseñador
- Ritian Zhou / IBM

### Locaciones
:key: Id_Locacion | Descripcion | _Campos adicionales_
--- | --- | ---
loc1 | Locación 1 | etc...

### StockPrima
:link: Id_Materia | :link: Id_Locacion | Cantidad
--- | --- | ---
mat1 | loc1 | 420

### StockProducto
:link: Id_Producto | :link: Id_Locacion | Cantidad
--- | --- | ---
prod1 | loc1 | 3


# Módulo de Ventas
- Horacio (Jefe) / IBM
- Oscar Gamez / Programador
- Alejandro Fierro /Base de datos
- David Rios / Diseñador

### Clientes
:key: Id_Cliente | Nombre | Teléfono | _Campos adicionales_
--- | --- | --- | ---
cli1 | Cliente 1 | 123 | etc...

### Pedidos
:key: Id_Pedido | :link: Id_Producto | :link: Id_Cliente | Cantidad | _Campos adicionales_
--- | --- | --- | --- | ---
ped1 | prod1 | cli1 | 4 | etc...

### :construction: Pagos
:key: Id_Pago | :link: Id_Cliente | :link: Id_Pedido | Total | Fecha
--- | --- | --- | --- | ---
pag1 | cli1 | ped| 1483 | 10/10/17

# Módulo de Planeación
- Filiberto Martinez (Jefe) / Base de datos
- Adriana Medina / Diseñador
- Mercedes Villegas / Diseñador
- Hugo Moroyoqui / Programadpr

# Módulo de producción
- Alex Rios (Jefe) / BD
- Ariadna Derbéz / Diseñador
- Iván López / Programador

# Dashboard
- Antonio Miranda / Desarrollador

