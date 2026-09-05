# Estructura del Repositorio en GitHub

Esta es la estructura exacta que se subirá al repositorio:

```
Guía-Práctica-DRS-LM22040/
│
├── 📄 .gitignore                          (Configuración de Git)
├── 📄 README.md                           (Documentación principal)
├── 📄 INSTRUCCIONES_GIT.md                (Guía para usar Git)
├── 📄 EJEMPLOS_SALIDA.md                  (Salidas esperadas)
│
├── 📁 Ejercicio1_Abstraccion/
│   └── 📄 CuentaBancaria.cs               (Código fuente)
│
├── 📁 Ejercicio2_Encapsulacion/
│   └── 📄 Empleado.cs                     (Código fuente)
│
├── 📁 Ejercicio3_HerenciaSimple/
│   └── 📄 Vehiculo.cs                     (Código fuente)
│
├── 📁 Ejercicio4_Polimorfismo/
│   └── 📄 Polimorfismo.cs                 (Código fuente)
│
└── 📁 Ejercicio5_HerenciaMultinivel/
    └── 📄 HerenciaMultinivel.cs           (Código fuente)
```

## ❌ Archivos que NO se subirán (gracias al .gitignore):

- Carpetas compiladas: `Ejercicio1/`, `Ejercicio2/`, `Ejercicio3/`, `Ejercicio4/`, `Ejercicio5/`
- Archivos binarios: `.exe`, `.dll`
- Carpetas de build: `bin/`, `obj/`, `Debug/`, `Release/`
- Archivos de proyecto generados: `.csproj`, `.sln`
- Archivos temporales de Visual Studio

## ✅ Total de archivos de código: 5 archivos .cs

Cada archivo `.cs` es autocontenido y se puede ejecutar independientemente siguiendo las instrucciones del README.

## 📊 Contenido por ejercicio:

1. **CuentaBancaria.cs** (~90 líneas) - Abstracción de datos
2. **Empleado.cs** (~85 líneas) - Encapsulación y control de acceso
3. **Vehiculo.cs** (~50 líneas) - Herencia simple
4. **Polimorfismo.cs** (~90 líneas) - Polimorfismo con Animal, Perro y Gato
5. **HerenciaMultinivel.cs** (~120 líneas) - Herencia multinivel con 3 niveles

## 🎯 Objetivo cumplido:

✅ Repositorio bien organizado
✅ Carpetas claramente nombradas
✅ Cada ejercicio en su propia carpeta
✅ Documentación completa
✅ Código limpio y comentado
✅ Ejemplos de ejecución incluidos
