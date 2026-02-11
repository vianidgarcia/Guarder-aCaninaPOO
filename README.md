# Sistema de Gestión de Guardería Canina

Proyecto de Programación Orientada a Objetos - Segundo Semestre

---

## Descripción

Sistema para administrar una guardería de mascotas. Permite registrar clientes, sus mascotas, crear reservas y agregar servicios (hospedaje, limpieza y paseos) con cálculo automático de costos.

---

## Funcionalidades

### 1. Gestión de Clientes
- Registrar clientes con ID único
- Agregar mascotas a cada cliente
- Ver información de todos los clientes

### 2. Gestión de Reservas
- Crear reservas para mascotas
- Asociar fecha de ingreso
- Ver todas las reservas activas

### 3. Gestión de Servicios
- Agregar servicios a reservas:
  - **Hospedaje:** Por cantidad de días
  - **Limpieza:** Con opción de corte de pelo
  - **Paseo:** Individual o grupal
- Eliminar servicios de reservas
- Ver servicios por reserva
- Cálculo automático de costos totales

---

## Tecnologías Utilizadas

- **Lenguaje:** C#
- **Framework:** .NET 8.0
- **IDE:** Visual Studio 2022

---

## Cómo Ejecutar el Proyecto

### Desde Visual Studio
1. Abrir el archivo `.csproj` en Visual Studio
2. Presionar `F5` o click en "Ejecutar"

### Desde la Terminal
```bash
dotnet run
```

---

## Servicios y Precios

### 🏠 Hospedaje
- **Cálculo:** Precio por día × Cantidad de días
- **Precio base:** $100 por día
- **Ejemplo:** 3 días = $300

### 🛁 Limpieza
- **Cálculo:** Precio base + Extra tamaño + Corte (opcional)
- **Precio base:** $50
- **Corte de pelo:** +$15
- **Ejemplo:** Base $50 + Extra $10 + Corte $15 = $75

### 🚶 Paseo
- **Cálculo:** Precio por hora × Horas × Tipo
- **Precio base:** $30 por hora
- **Paseo grupal:** +25% del costo
- **Ejemplo:** 2 horas grupal = $30 × 2 × 1.25 = $75

---

## Ejemplo de Uso

1. **Registrar un cliente:**
   - Menú → Registrar Cliente
   - ID: C001
   - Nombre: "Juan Pérez"
   - Teléfono: "1234-5678"

2. **Agregar una mascota:**
   - Menú → Agregar Mascota a Cliente
   - Cliente: C001
   - Nombre: "Max"
   - Raza: "Golden Retriever"
   - Edad: 3 años
   - Peso: 25 kg

3. **Crear una reserva:**
   - Menú → Crear Reserva
   - Cliente: C001
   - Mascota: Max
   - Fecha: (se usa la fecha actual)

4. **Agregar servicios:**
   - Menú → Gestionar Servicios → Agregar servicio
   - Reserva #1
   - Servicio: Hospedaje (3 días) = $300
   - Servicio: Limpieza (con corte) = $65
   - **Costo Total: $365**

---

## Conceptos de POO Aplicados

- ✅ **Herencia:** Los tres servicios heredan de la clase Servicio
- ✅ **Polimorfismo:** Cada servicio calcula su costo de manera diferente
- ✅ **Encapsulamiento:** Propiedades privadas con métodos getter
- ✅ **Abstracción:** Clase abstracta Servicio define estructura común
- ✅ **Composición:** Cliente tiene lista de Mascotas, Reserva tiene lista de Servicios

---

## Características del Sistema

### Validaciones
- No se permiten IDs de cliente duplicados
- Validación de existencia de clientes y mascotas
- Control de datos nulos

### Cálculos Automáticos
- El sistema calcula automáticamente el costo de cada servicio
- El costo total de la reserva se actualiza dinámicamente

### Gestión de Listas
- Clientes con múltiples mascotas
- Reservas con múltiples servicios
- Navegación por índices numéricos

---

## Limitaciones

- Los datos NO se guardan al cerrar el programa (almacenamiento en memoria)
- Solo funciona en consola (no tiene interfaz gráfica)
- No hay sistema de pagos real
- Las fechas de ingreso se registran pero no afectan los cálculos

---

## Autor

**Daniela Garcia**
- Universidad: TecNM
- Carrera: Informática
- Materia: Programación Orientada a Objetos
- Semestre: 2

---

## Fecha de Entrega

Febrero 2026

---

## Notas

Este proyecto fue desarrollado como práctica de los conceptos de Programación Orientada a Objetos vistos en clase, especialmente herencia, polimorfismo y abstracción.
