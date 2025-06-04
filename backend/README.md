# 🧾 ConsultaSaldoHex

Este proyecto es una solución técnica para la integración de un servicio SOAP que permite **consultar el saldo de un cliente** y exponer los datos a través de una API REST.

Está desarrollado con **.NET 9 (versión 9.0.300)** utilizando el enfoque de **Arquitectura Hexagonal (Ports and Adapters)** para garantizar una alta escalabilidad, mantenibilidad y separación de responsabilidades.

---

## 🔧 Tecnologías y herramientas

- **.NET SDK**: 9.0.300
- **C#**: Lenguaje principal
- **SOAP**: Servicio externo de consulta de saldo
- **REST API**: Exposición de datos
- **Arquitectura**: Hexagonal
- **Proyecto web**: ASP.NET Core Web API

---

## 🧱 Estructura del proyecto
backend/
├── Domain/ # Entidades y lógica del negocio
│ └── Entities/Client.cs
│ └── ValueObjects/Balance.cs
│
├── Application/ # Interfaces y casos de uso
│ └── Interfaces/IClientService.cs
│
├── Adapters/ # Adaptadores de entrada/salida
│ └── Services/ClientService.cs
│
├── Infrastructure/ # Comunicación con sistemas externos (SOAP)
│ └── SoapClient/SoapClientSimulator.cs
│
├── WebHost/ # API REST (punto de entrada)
│ └── Controllers/ClientController.cs
│ └── Program.cs
│
├── InquiryBalance.sln
└── README.md

---

## ✅ ¿Qué hace este proyecto?

- Consulta datos de un cliente (nombre, saldo y estado).
- Consume un servicio SOAP (simulado) que entrega XML con los datos.
- Expone los datos a través de una API REST en formato JSON.
- Valida que el saldo no supere los 15 dígitos significativos (limitación de la solución de canales).
- Usa buenas prácticas y separación por capas.

---

## 🚀 Cómo ejecutar el proyecto

### Estar ubicado dentro de la carpeta backend

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
- Respuesta en JSON: http://localhost:5175/api/client/balance.
- Respuesta XML: Service.svc?wsdl

