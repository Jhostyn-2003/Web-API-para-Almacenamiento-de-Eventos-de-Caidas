
# 🌐 Web API para Almacenamiento de Eventos de Caídas

Este proyecto es una API web desarrollada en **ASP.NET Core** que recibe los eventos de caídas desde la [App de Monitoreo de Aceleración en Tiempo Real con Detección de Caídas](https://github.com/Jhostyn-2003/App-de-Monitoreo-de-Aceleracion-en-Tiempo-Real-con-Deteccion-de-Caidas.git) y los guarda en una base de datos **SQL Server**.

## 🚀 Características

- **Recepción de Datos**: Recibe eventos de caídas generados por la aplicación móvil y los almacena en una base de datos.
- **API REST**: Proporciona una API RESTful que permite operaciones CRUD sobre los eventos de caídas.
- **SQL Server**: Almacena los eventos de caídas en una base de datos SQL Server para su posterior consulta o análisis.

## 🛠️ Tecnologías Utilizadas

- **ASP.NET Core**: Framework utilizado para construir la API.
- **Entity Framework Core**: ORM para interactuar con la base de datos SQL Server.
- **SQL Server**: Base de datos utilizada para almacenar los eventos de caídas.
- **C#**: Lenguaje de programación utilizado para el backend.

## 📋 Endpoints Principales

- **GET /api/FallEventsG3**: Obtiene la lista de todos los eventos de caídas almacenados.
- **GET /api/FallEventsG3/{id}**: Obtiene un evento de caída específico por su ID.
- **POST /api/FallEventsG3**: Permite crear un nuevo evento de caída.
- **PUT /api/FallEventsG3/{id}**: Actualiza un evento de caída existente.
- **DELETE /api/FallEventsG3/{id}**: Elimina un evento de caída específico.

## ⚙️ Instalación y Configuración

1. **Clona el repositorio**:

   ```bash
   git clone https://github.com/usuario/WebAPI-FallEvents.git
   cd WebAPI-FallEvents
   ```

2. **Configura la base de datos**:

   - Asegúrate de que la cadena de conexión de **SQL Server** esté correctamente configurada en `appsettings.json`:

   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=TU_SERVIDOR_SQL;Database=FallEventsDB;Trusted_Connection=True;"
     }
   }
   ```

3. **Aplica las migraciones a la base de datos**:

   Ejecuta los siguientes comandos para aplicar las migraciones de Entity Framework y crear las tablas necesarias:

   ```bash
   dotnet ef database update
   ```

4. **Compila y ejecuta la aplicación**:

   ```bash
   dotnet run
   ```

   La API estará disponible en `http://localhost:5000`.

## 🧑‍💻 Contribuciones

Las contribuciones son bienvenidas. Si tienes ideas para mejorar el proyecto, no dudes en hacer un fork y abrir un pull request.

1. Haz un fork del proyecto.
2. Crea una nueva rama (`git checkout -b feature/nueva-funcionalidad`).
3. Realiza tus cambios (`git commit -am 'Agregada nueva funcionalidad'`).
4. Haz push a tu rama (`git push origin feature/nueva-funcionalidad`).
5. Abre un pull request.

## 📜 Licencia

Este proyecto está bajo la Licencia MIT - consulta el archivo [LICENSE](LICENSE) para más detalles.
