# Proyecto CRUD en C#
Este proyecto se realizó para aprobar el curso de C# de Coderhouse. Se trata de una API RESTful construida con ASP.NET Core para gestionar productos, usuarios, productos vendidos y ventas. Incluye operaciones CRUD (Crear, Leer, Actualizar, Eliminar) y se integra con una base de datos SQL Server utilizando ADO.NET.

## Índice

- [Descripción](#descripción)
- [Estructura del proyecto](#estructura-del-proyecto)
  - [Capas](#capas)
  - [Endpoints](#endpoints)
- [Tecnologías utilizadas](#tecnologías-utilizadas)
- [Configuración y uso](#configuración-y-uso)
- [Contacto](#contacto)

## Descripción
Este proyecto es una API para gestionar productos, usuarios, productos vendidos y ventas; permitiendo realizar operaciones CRUD. Está estructurado en diferentes capas para mantener una separación clara de responsabilidades.

## Estructura del proyecto
El proyecto está compuesto por las siguientes capas:

Controllers: Maneja las solicitudes HTTP y devuelve respuestas a los clientes.
Business: Contiene la lógica de negocio y las reglas para gestionar los productos, usuarios, productos vendidos y ventas.
Data: Maneja la interacción con la base de datos utilizando ADO.NET.
Entities: Define las entidades que representan los modelos de datos.

Endpoints
Como ejemplo se listan algunos de los endpoints de la API, en este caso los correspondientes a los productos:

GET /api/producto/{id}: Obtener un producto por su ID.
GET /api/producto: Obtener todos los productos.
POST /api/producto: Crear un nuevo producto.
PUT /api/producto/{id}: Actualizar un producto existente.
DELETE /api/producto/{id}: Eliminar un producto por su ID.

## Tecnologías utilizadas

ASP.NET Core: Framework para construir la API.
ADO.NET: Para interactuar con la base de datos.
SQL Server: Sistema de gestión de bases de datos relacional.
Swagger: Herramienta para documentar y probar la API.

## Configuración y uso

Para configurar y ejecutar el proyecto, sigue los siguientes pasos:

Clonar el repositorio:
git clone https://github.com/smatulionis/Proyecto-Final-CSharp-Coderhouse.git

Ejecutar el proyecto y acceder a Swagger:
Ejecuta la solución del proyecto contenida en la carpeta Sistema Gestion. Swagger se abrirá automáticamente en tu navegador para ver la documentación y probar la API.

## Contacto
Si tienes alguna pregunta, sugerencia o comentario sobre este proyecto, puedes contactarme por correo electrónico a [smatulionis@live.com.ar](mailto:smatulionis@live.com.ar) o a través de mi perfil de Linkedin en [Sebastián Ezequiel Matulionis](https://www.linkedin.com/in/smatulionis/).
