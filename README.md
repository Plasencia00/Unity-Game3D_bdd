# Unity-Game3D_bdd

Este proyecto es un juego en 3D desarrollado con Unity y MySQL. Incluye la integración de una base de datos para almacenar los puntajes de los jugadores en tiempo real.

## Descripción

El juego permite a los jugadores:
- Introducir su nombre.
- Jugar y alcanzar puntajes según sus habilidades.
- Guardar automáticamente su puntaje final en una base de datos MySQL, ya sea al ganar o al perder.

Este proyecto es ideal como ejemplo práctico de la integración entre Unity y una base de datos externa.

## Contenido del Repositorio

- **Carpeta principal del proyecto Unity**: Incluye todos los archivos y scripts necesarios para ejecutar el juego.
- **Archivo de base de datos (`gamebd.sql`)**: Contiene la estructura y datos iniciales para configurar la base de datos MySQL necesaria para el proyecto.

## Configuración

1. **Requisitos previos**:
   - Tener Unity instalado.
   - Instalar MySQL y un gestor como phpMyAdmin o Workbench.

2. **Importar la base de datos**:
   - Importa el archivo `bgamedb.sql` en tu servidor MySQL.

3. **Configuración en Unity**:
   - Configura tu conexión a MySQL en el script `TestConexion` con los datos de tu servidor:
     ```csharp
     private string connectionString = "Server=localhost;Database=gamedb;User=root;Password=tu_contraseña;";
     ```

## Cómo Jugar

1. Introduce tu nombre en el campo correspondiente.
2. Empieza a jugar y recoge puntos.
3. Al terminar, verifica que tu puntaje se haya almacenado correctamente en la base de datos.

## Tecnologías Usadas

- **Unity**: Motor de desarrollo de videojuegos.
- **MySQL**: Sistema de gestión de bases de datos.
- **C#**: Lenguaje de programación para los scripts.

## Autor

- Mayury Plasencia

## Licencia

Este proyecto se distribuye bajo la licencia MIT.
