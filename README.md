# Proyecto Fullstack

Este proyecto contiene dos directorios principales:

- `backend`: Código fuente del backend de la aplicación.
- `frontend`: Código fuente del frontend de la aplicación.

## Requisitos previos

Asegúrese de tener instalado lo siguiente:

- [Angular CLI v18](https://angular.io/cli)
- [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)

## Ejecución del backend

1. Ingrese al directorio del backend:

   ```bash
   cd backend
    dotnet restore
    
# Instrucciones para ejecutar el Frontend

Este directorio contiene el código fuente del frontend de la aplicación, desarrollado con Angular 18.

## Requisitos

- Tener instalado [Angular CLI v18](https://angular.io/cli)

## Pasos para ejecutar

1. Ingrese al directorio del frontend:

   ### Restaura los paquetes
```bash
dotnet restore
```

### Compila la solución
```bash
dotnet build
```

### Ejecuta el proyecto web
```bash
dotnet run --project WebHost/WebHost.csproj
```

# Instrucciones para ejecutar el Frontend

Este directorio contiene el código fuente del frontend de la aplicación, desarrollado con Angular 18.

## Requisitos

- Tener instalado [Angular CLI v18](https://angular.io/cli)

## Pasos para ejecutar

1. Ingrese al directorio del frontend:

   ```bash
   cd frontend
    ```
    
2. Ejecute el siguiente comando para iniciar el servidor de desarrollo:

    ```bash
    ng serve
    ```

3. Asegúrese de que el backend esté corriendo correctamente.

3. Acceda a la aplicación desde su navegador en:
    http://localhost:4200