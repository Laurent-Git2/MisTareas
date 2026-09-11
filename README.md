# MisTareas
# MisTareas

Aplicación web desarrollada con ASP.NET Core MVC para crear y gestionar tareas personales.

> Estado del proyecto: en desarrollo.

## Funcionalidades actuales

* Registro e inicio de sesión mediante ASP.NET Core Identity.
* Acceso a la gestión de tareas reservado a usuarios autenticados.
* Creación, consulta, modificación y eliminación de tareas.
* Gestión de prioridad, título, descripción, estado, fecha límite y enlace.
* Almacenamiento de datos en SQL Server.
* Migraciones mediante Entity Framework Core.
* Interfaz desarrollada con Razor y Bootstrap.

## Tecnologías

* C#
* .NET 9
* ASP.NET Core MVC
* Entity Framework Core
* SQL Server y LocalDB
* ASP.NET Core Identity
* Razor
* Bootstrap

## Ejecución local

### Requisitos

* Visual Studio 2022
* .NET 9 SDK
* SQL Server LocalDB

### Instalación

1. Clonar el repositorio:

```bash
git clone https://github.com/Laurent-Git2/MisTareas.git
```

2. Abrir `MisTareas.sln` en Visual Studio.

3. Aplicar las migraciones:

```powershell
Update-Database
```

4. Ejecutar el proyecto mediante HTTPS desde Visual Studio.

## Próximas mejoras

* Asociar cada tarea al usuario que la crea.
* Mostrar únicamente las tareas del usuario conectado.
* Añadir una interfaz disponible en español y francés.
* Incorporar filtros por prioridad, estado y fecha.
* Mejorar las validaciones y el diseño responsive.
*Integrar una función basada en inteligencia artificial para ayudar al usuario a organizar, priorizar y dividir una tarea en pasos más sencillos.

## Autor

Laurent Sontag
[Perfil GitHub](https://github.com/Laurent-Git2)
