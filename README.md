# Sistema Restaurantes Senator
Este proyecto consiste en un sistema de gestión de reservaciones cuyo objetivo es administrar las reservas de los restaurantes privados del complejo turístico Senator.


# Estructura del Proyecto
El proyecto está organizado en diferentes carpetas para separar la lógica del programa:

### -models 
Contiene las estructuras de datos utilizadas por el sistema, como los restaurantes disponibles y la información de las reservaciones.
### -services
Contiene las funciones que manejan la lógica del sistema, como crear reservaciones, eliminar registros y verificar cupos disponibles.
### -UI
Maneja la interacción con el usuario, mostrando el menú y permitiendo seleccionar las diferentes opciones del sistema.


## Funcionalidades del Sistema
El sistema funciona mediante un menú interactivo en consola, donde el empleado puede realizar las siguientes acciones:

-Realizar reservaciones registrando el nombre del cliente, cantidad de personas, restaurante y horario.

-Eliminar reservaciones existentes buscándolas por el nombre del cliente.

-Ver disponibilidad de cupos en cada restaurante según el horario seleccionado.

-Imprimir listados de las reservaciones realizadas para un restaurante y turno específico.
