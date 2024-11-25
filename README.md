# FP-S1-Ordinario
Examen ordinario de "fundamentos de programación" [Primer Semestre]

# Ventana de login:
- El gerente puede iniciar sesión con nombre de usuario y contraseña (proporcionados por el sistema y validados con un JSON).
- Cualquier empleado puede iniciar sesión con nombre de usuario y contraseña (registrados por el gerente en una ventana específica y validados con un JSON).

# Ventana de gerente:
- Opción de agregar nuevos empleados (crea un JSON "EMPLEADOS" para agregar nuevos usuarios con: id, clave y nombre).
- Eliminar empleados (elimina empleados del JSON dependiendo de la clave del empleado).
- Cambiar precios de productos.
- Mostrar en una tabla todas las compras que se realizan (con un JSON "COMPRAS").

# Ventana de empleado (caja):
- Ventana para mostrar productos (con imágenes y precios).
- Crear una tabla donde se muestren los productos que el cliente quiere y en una etiqueta ir cambiando su texto dependiendo de la cantidad a pagar (puede añadir productos y eliminarlos también).
- Tener un botón para pagar.

# Ventana de empleado (cobrar):
- Permitir añadir y calcular el 10%, 15% o 20% de propina y añadirlo al costo total.
- Pagar con efectivo (se notifica que se ha pagado con efectivo).
- Crear un JSON de tarjetas (2 tarjetas: una de débito y otra de crédito, que guardan los datos de tipo, NIP y dinero).
- Pago con tarjeta de débito (el cliente introduce su NIP; si no tiene saldo, se notifica y se pide otro método de pago).
- Pago con tarjeta de crédito (el cliente introduce su NIP; si no tiene saldo, se notifica y se pide otro método de pago).
- Al terminar el pago, toda la ventana debe estar preparada para atender otro pedido (se reinician los valores para ingresar uno nuevo y se guardan los datos de empleado, clave del empleado y total de la compra en un JSON "COMPRAS").

**Nota:** Agregar manualmente otra tarjeta en el JSON y el programa debe ser capaz de leer esa nueva tarjeta.

## Puntos a considerar:
- Buena presentación (diseño limpio, ordenado y profesional).
- Funcionamiento perfecto.
- Entregado en tiempo y forma (9 de diciembre, horario de clase).