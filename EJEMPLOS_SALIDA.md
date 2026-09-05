# Ejemplos de Salida de los Ejercicios

Este documento muestra las salidas esperadas al ejecutar cada uno de los ejercicios.

---

## Ejercicio 1: Abstracción de Datos (CuentaBancaria.cs)

```
=== EJERCICIO 1: ABSTRACCIÓN DE DATOS ===

Saldo inicial: $1000.00

Depósito exitoso. Monto depositado: $500.00
Saldo actual: $1500.00

Retiro exitoso. Monto retirado: $300.00
Saldo actual: $1200.00

Error: Fondos insuficientes. Saldo disponible: $1200.00
Saldo actual: $1200.00

Error: El monto a depositar debe ser positivo.
Saldo final: $1200.00
```

---

## Ejercicio 2: Encapsulación (Empleado.cs)

```
=== EJERCICIO 2: ENCAPSULACIÓN Y CONTROL DE ACCESO ===

Empleado 1:
Nombre: Juan Pérez, Edad: 30 años

Empleado 2:
Nombre: María García, Edad: 25 años

Intentando asignar edad negativa:
Error: La edad debe ser mayor que 0.
Nombre: María García, Edad: 25 años

Intentando asignar edad >= 100:
Error: La edad debe ser menor que 100.
Nombre: María García, Edad: 25 años

Asignando edad válida:
Nombre: María García, Edad: 35 años
```

---

## Ejercicio 3: Herencia Simple (Vehiculo.cs)

```
=== EJERCICIO 3: HERENCIA SIMPLE ===

El vehículo está arrancando...
El coche está siendo conducido en la carretera.
El vehículo se está deteniendo...

¡El coche ha utilizado todos sus métodos exitosamente!
```

---

## Ejercicio 4: Polimorfismo (Animal.cs)

```
=== EJERCICIO 4: POLIMORFISMO ===

Llamadas directas:
El perro dice: ¡Guau guau!
El gato dice: ¡Miau miau!

--- DEMOSTRANDO POLIMORFISMO ---
Usando referencias de tipo Animal:

animal1 (tipo Perro): El perro dice: ¡Guau guau!
animal2 (tipo Gato): El gato dice: ¡Miau miau!
animal3 (tipo Animal): El animal hace un sonido genérico.

--- USO DE ARREGLO POLIMÓRFICO ---
Animal 1: El perro dice: ¡Guau guau!
Animal 2: El gato dice: ¡Miau miau!
Animal 3: El perro dice: ¡Guau guau!
Animal 4: El animal hace un sonido genérico.
```

---

## Ejercicio 5: Herencia Multinivel (Animal.cs)

```
=== EJERCICIO 5: HERENCIA MULTINIVEL ===

--- Demostrando herencia multinivel ---

1. Método sobrescrito en Perro:
El perro dice: ¡Guau guau!

2. Método heredado de Mamifero:
El mamífero está siendo alimentado con leche materna.

3. Método específico de Perro:
El perro está jugando con una pelota.

--- Demostrando polimorfismo en la jerarquía ---

Referencia de tipo Animal apuntando a Perro:
El perro dice: ¡Guau guau!

Referencia de tipo Mamifero apuntando a Perro:
El perro dice: ¡Guau guau!
El mamífero está siendo alimentado con leche materna.

--- Comparando los tres niveles ---

Animal: El animal hace un sonido.
Mamífero: El mamífero hace un sonido característico.
Perro: El perro dice: ¡Guau guau!
```

---

## Notas sobre las Salidas

1. **Ejercicio 1:** Demuestra cómo la abstracción oculta el saldo y valida operaciones
2. **Ejercicio 2:** Muestra el control de acceso mediante propiedades con validación
3. **Ejercicio 3:** Ilustra la herencia simple y el uso de métodos heredados
4. **Ejercicio 4:** Ejemplifica el polimorfismo con referencias de clase base
5. **Ejercicio 5:** Presenta herencia multinivel con tres niveles de jerarquía
