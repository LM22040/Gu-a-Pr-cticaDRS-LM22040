# Instrucciones para subir el proyecto a GitHub

## Paso 1: Inicializar Git en el proyecto

Abre la terminal en la carpeta del proyecto y ejecuta:

```bash
git init
```

## Paso 2: Configurar tu información (si no lo has hecho antes)

```bash
git config --global user.name "Tu Nombre"
git config --global user.email "tu.email@example.com"
```

## Paso 3: Agregar archivos al staging

```bash
git add .
```

## Paso 4: Hacer el primer commit

```bash
git commit -m "Initial commit: Implementación de ejercicios de POO"
```

## Paso 5: Crear un repositorio en GitHub

1. Ve a [GitHub](https://github.com)
2. Inicia sesión en tu cuenta
3. Haz clic en el botón "+" en la esquina superior derecha
4. Selecciona "New repository"
5. Ponle un nombre, por ejemplo: `POO-Ejercicios-LM22040`
6. Marca como público (public)
7. NO marques "Initialize this repository with a README"
8. Haz clic en "Create repository"

## Paso 6: Conectar tu repositorio local con GitHub

Copia el URL de tu repositorio (aparece después de crearlo) y ejecuta:

```bash
git remote add origin https://github.com/TU_USUARIO/POO-Ejercicios-LM22040.git
```

## Paso 7: Subir los archivos a GitHub

```bash
git branch -M main
git push -u origin main
```

## Comandos útiles para futuras actualizaciones

### Para agregar cambios:
```bash
git add .
git commit -m "Descripción de los cambios"
git push
```

### Para ver el estado:
```bash
git status
```

### Para ver el historial:
```bash
git log --oneline
```

## Estructura que se subirá a GitHub

```
POO-Ejercicios-LM22040/
│
├── .gitignore
├── README.md
├── INSTRUCCIONES_GIT.md
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
│   └── Animal.cs
│
└── Ejercicio5_HerenciaMultinivel/
    └── Animal.cs
```

## Verificación

Después de hacer push, ve a tu repositorio en GitHub y verifica que todos los archivos se hayan subido correctamente.

## Notas importantes

- El archivo `.gitignore` evitará que archivos innecesarios (binarios, temporales) se suban al repositorio
- Asegúrate de que el repositorio sea público para que tu tutor pueda acceder
- Guarda el enlace del repositorio para entregarlo en tu tarea

## Enlace del repositorio

Una vez creado, tu repositorio estará disponible en:
```
https://github.com/TU_USUARIO/POO-Ejercicios-LM22040
```

¡Comparte este enlace con tu tutor!
