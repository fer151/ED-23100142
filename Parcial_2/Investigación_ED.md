# **Investigación: Tipos de Estructuras de Datos**

## **1. Estructuras Lineales**
**Concepto:**  
Una estructura de datos es una forma organizada de almacenar y gestionar información dentro de la memoria de una computadora, de manera que pueda utilizarse de forma eficiente.
En otras palabras, define cómo se guardan, relacionan y manipulan los datos para facilitar su acceso y procesamiento.

### **1.1 Arreglos**
**Concepto:**  
Un arreglo es una colección de elementos del mismo tipo almacenados en posiciones contiguas de memoria. Cada elemento se accede mediante un índice.

**Tipos:**
- **Unidimensional:** Contiene una sola fila o columna de datos.
- **Multidimensional:** Puede contener varias filas y columnas, como una matriz.

**Aplicación:**  
Se utilizan para almacenar listas de valores como calificaciones, nombres, precios o coordenadas en programas que requieren acceso rápido a los datos.

**Ventajas:**  
- Acceso directo e inmediato a cualquier elemento.  
- Fácil de implementar.  
- Útil para manejar grandes cantidades de datos homogéneos.

**Desventajas:**  
- Tamaño fijo (no se puede cambiar en ejecución).  
- Ineficiente al insertar o eliminar datos intermedios.  
- Solo almacena datos del mismo tipo.

---

### **1.2 Pilas (Stacks)**
**Concepto:**  
Es una estructura que sigue el principio **LIFO (Last In, First Out)**: el último elemento en entrar es el primero en salir.

**Aplicación:**  
Se usa en control de llamadas de funciones, deshacer acciones (Ctrl + Z), manejo de expresiones matemáticas y almacenamiento temporal de datos.

**Ventajas:**  
- Facilita el control de procesos reversibles.  
- Eficiente para manejar datos con orden específico.  
- Implementación sencilla mediante arreglos o listas.

**Desventajas:**  
- Acceso limitado solo al elemento superior.  
- No permite búsqueda directa de elementos intermedios.  
- Puede causar desbordamiento si no se controla el tamaño.

---

### **1.3 Colas (Queues)**
**Concepto:**  
Estructura de tipo **FIFO (First In, First Out)**: el primer elemento en entrar es el primero en salir.

**Aplicación:**  
Se utiliza en la gestión de tareas por turno, colas de impresión, procesamiento de solicitudes o simulaciones de atención al cliente.

**Ventajas:**  
- Mantiene el orden de procesamiento.  
- Ideal para flujos de datos secuenciales.  
- Facilita el control de procesos en espera.

**Desventajas:**  
- Acceso restringido (solo al frente y al final).  
- Difícil de manipular si el tamaño varía constantemente.  
- Requiere memoria adicional para estructuras dinámicas.

---

### **1.4 Listas Enlazadas**
**Concepto:**  
Colección de nodos conectados entre sí mediante punteros o referencias. Cada nodo contiene un dato y una referencia al siguiente (o al anterior).

**Tipos:**
- **Simplemente Enlazada:** Cada nodo apunta al siguiente.  
- **Doblemente Enlazada:** Cada nodo apunta al siguiente y al anterior.  
- **Circular:** El último nodo apunta al primero.

**Aplicación:**  
Se emplean en sistemas que requieren inserciones y eliminaciones frecuentes, como menús dinámicos, administración de memoria o reproductores multimedia.

**Ventajas:**  
- Tamaño dinámico (crece o disminuye según necesidad).  
- Inserciones y eliminaciones rápidas.  
- Eficiente para recorrer datos secuenciales.

**Desventajas:**  
- Acceso secuencial (no se puede acceder directamente por índice).  
- Consumo extra de memoria por los punteros.  
- Más complejas de implementar que los arreglos.

---

## **2. Estructuras No Lineales**

### **2.1 Grafos**
**Concepto:**  
Un grafo está formado por **nodos (vértices)** y **conexiones (aristas)** que representan relaciones entre elementos.

**Aplicación:**  
Modelan redes sociales, rutas de transporte, mapas, conexiones eléctricas o enlaces web.

**Ventajas:**  
- Representa relaciones complejas.  
- Muy flexible para múltiples tipos de conexiones.  
- Útil para búsqueda de rutas y análisis de redes.

**Desventajas:**  
- Complejo de implementar y recorrer.  
- Alto consumo de memoria si tiene muchos nodos.  
- Difícil de representar gráficamente cuando es grande.

---

### **2.2 Árboles**
**Concepto:**  
Estructura jerárquica donde cada nodo tiene un valor y referencias a sus nodos hijos. El nodo superior se llama **raíz**.

**Aplicación:**  
Se usa en sistemas de archivos, bases de datos, inteligencia artificial, y para optimizar búsquedas (árbol binario, AVL, etc.).

**Ventajas:**  
- Permite búsqueda y clasificación eficientes.  
- Facilita representar jerarquías.  
- Optimiza operaciones de inserción y eliminación.

**Desventajas:**  
- Puede desequilibrarse y perder eficiencia.  
- Difícil de mantener en estructuras grandes.  
- Requiere más memoria por las referencias.

---

## **3. Estructuras Abstractas**

### **3.1 Conjuntos (Set)**
**Concepto:**  
Colección de elementos únicos (sin repetición) donde el orden no importa.

**Aplicación:**  
Gestión de permisos, eliminación de duplicados o comparación de grupos de datos.

**Ventajas:**  
- Evita duplicación de datos.  
- Fácil para operaciones de unión, intersección y diferencia.  
- Ideal para comparación rápida de elementos.

**Desventajas:**  
- No permite elementos repetidos.  
- Acceso no ordenado.  
- Más lento en operaciones de recorrido que una lista.

---

### **3.2 Diccionarios (Map o HashMap)**
**Concepto:**  
Almacenan datos en pares **clave–valor**, donde cada clave es única y se asocia a un valor específico.

**Aplicación:**  
Usado en bases de datos, almacenamiento en caché, configuraciones, o registros de usuarios (clave = ID, valor = nombre).

**Ventajas:**  
- Acceso rápido mediante claves.  
- Organización eficiente de datos no secuenciales.  
- Muy útil para búsquedas instantáneas.

**Desventajas:**  
- Mayor uso de memoria.  
- Puede tener colisiones de claves.  
- Complejo de implementar sin funciones hash adecuadas.





