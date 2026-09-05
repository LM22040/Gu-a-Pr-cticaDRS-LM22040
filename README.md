# Guía Práctica 1 - Desarrollo y Reutilización de Software

Este repositorio contiene los ejercicios prácticos sobre conceptos fundamentales de Programación Orientada a Objetos (POO) desarrollados en C#.

## 📋 Contenido

### Ejercicio 1: Abstracción de Datos
**Objetivo:** Implementar un tipo de datos abstracto que oculta detalles de implementación.

**Descripción:** Clase `CuentaBancaria` que representa una cuenta bancaria utilizando abstracción de datos para ocultar el saldo y permitir acceso solo mediante métodos públicos.

**Características:**
- Atributo privado para el saldo
- Método `Depositar(decimal monto)`: Agrega dinero a la cuenta
- Método `Retirar(decimal monto)`: Retira dinero de la cuenta
- Método `ObtenerSaldo()`: Consulta el saldo actual
- Validaciones: Montos positivos y fondos suficientes

**Archivo:** `Ejercicio1_Abstraccion/CuentaBancaria.cs`

---

### Ejercicio 2: Encapsulación y Control de Acceso
**Objetivo:** Aplicar la encapsulación para proteger los datos y controlar el acceso.

**Descripción:** Clase `Empleado` con atributos privados (nombre y edad) accesibles mediante propiedades que validan los datos.

**Características:**
- Atributos privados: `nombre` y `edad`
- Propiedades con validación
- La edad debe ser mayor que 0 y menor que 100
- El nombre no puede estar vacío

**Archivo:** `Ejercicio2_Encapsulacion/Empleado.cs`

---

### Ejercicio 3: Herencia Simple
**Objetivo:** Implementar herencia simple para extender funcionalidades.

**Descripción:** Clase base `Vehiculo` y clase derivada `Coche` que hereda y extiende funcionalidades.

**Características:**
- Clase base `Vehiculo` con métodos `Arrancar()` y `Detener()`
- Clase derivada `Coche` que hereda de `Vehiculo`
- Método adicional `Conducir()` en `Coche`

**Archivo:** `Ejercicio3_HerenciaSimple/Vehiculo.cs`

---

### Ejercicio 4: Polimorfismo
**Objetivo:** Implementar polimorfismo utilizando métodos sobrescritos.

**Descripción:** Clase base `Animal` con clases derivadas `Perro` y `Gato` que sobrescriben el método `HacerSonido()`.

**Características:**
- Clase base `Animal` con método virtual `HacerSonido()`
- Clases `Perro` y `Gato` sobrescriben `HacerSonido()`
- Demostración de polimorfismo con referencias de tipo `Animal`
- Uso de arreglos polimórficos

**Archivo:** `Ejercicio4_Polimorfismo/Polimorfismo.cs`

---

### Ejercicio 5: Herencia Multinivel y Sobrescritura de Métodos
**Objetivo:** Demostrar herencia multinivel y sobrescritura de métodos.

**Descripción:** Jerarquía de clases con tres niveles: `Animal` → `Mamifero` → `Perro`.

**Características:**
- Clase base `Animal` con método `HacerSonido()`
- Clase intermedia `Mamifero` que hereda de `Animal` y añade `Alimentar()`
- Clase `Perro` que hereda de `Mamifero` y sobrescribe `HacerSonido()`
- Demostración de herencia multinivel y polimorfismo

**Archivo:** `Ejercicio5_HerenciaMultinivel/HerenciaMultinivel.cs`

---

## 🚀 Cómo ejecutar los ejercicios

### Opción 1: Usando Visual Studio
1. Abre Visual Studio
2. Crea un nuevo proyecto de Consola para cada ejercicio
3. Copia el código del archivo `.cs` correspondiente
4. Ejecuta el proyecto (F5)

### Opción 2: Usando .NET CLI
```bash
# Navega a la carpeta del ejercicio
cd "Ejercicio1_Abstraccion"

# Crea un proyecto de consola
dotnet new console -n Ejercicio1

# Reemplaza el archivo Program.cs con CuentaBancaria.cs
# O copia el contenido

# Ejecuta el proyecto
dotnet run
```

### Opción 3: Ejecutar desde las carpetas de proyecto
```bash
# Los ejercicios ya están listos para ejecutarse desde las carpetas EjercicioX
cd "Ejercicio1_Abstraccion\Ejercicio1"
dotnet run
```

---

## 📚 Conceptos de POO demostrados

1. **Abstracción:** Ocultar detalles de implementación y exponer solo lo necesario
2. **Encapsulación:** Proteger datos mediante control de acceso
3. **Herencia:** Reutilización de código mediante relaciones padre-hijo
4. **Polimorfismo:** Múltiples formas de un mismo método según el contexto
5. **Herencia Multinivel:** Jerarquías de clases con múltiples niveles

---

## 📂 Estructura del Proyecto

```
Guia parctica 1 LM22040/
│
├── Ejercicio1_Abstraccion/
│   └── CuentaBancaria.cs
│
├── Ejercicio2_Encapsulacion/
│   └── Empleado.cs
│
├── Ejercicio3_HerenciaSimple/
│   └── Vehiculo.cs
│
├── Ejercicio4_Polimorfismo/
│   └── Polimorfismo.cs
│
├── Ejercicio5_HerenciaMultinivel/
│   └── HerenciaMultinivel.cs
│
└── README.md
```

---

## 👨‍💻 Autor

**Carnet:** LM22040  
**Curso:** Desarrollo y Reutilización de Software  
**Ciclo:** II-2026

---

## 📝 Notas

- Todos los ejercicios incluyen validaciones y manejo de errores
- Cada archivo contiene documentación con comentarios XML
- Los programas de demostración están incluidos en cada archivo
- El código sigue las convenciones de C# y buenas prácticas de POO

---

## 🔗 Requisitos

- .NET Framework 4.7+ o .NET Core 3.1+
- Visual Studio 2019+ (opcional)
- C# Compiler (csc.exe)

---

## 📄 Licencia

Este proyecto es de uso educativo para el curso de Desarrollo y Reutilización de Software.
