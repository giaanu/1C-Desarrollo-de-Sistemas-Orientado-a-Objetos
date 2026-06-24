# 1C - Desarrollo de Sistemas Orientado a Objetos

Ejercicios obligatorios de la materia **Desarrollo de Sistemas Orientado a Objetos**, cursada 2026.

## Contenido

### Encapsulamiento y Clases Abstractas — 02/06/2026

Archivo: `Encapsulamiento.cs`

| Ejercicio | Tema | Descripción |
|-----------|------|-------------|
| 1 | Encapsulamiento | Clase `CuentaBancaria` con saldo privado, método de depósito y retiro con validaciones |
| 2 | Encapsulamiento | Clase `Personaje` con vida privada clampeable entre 0 y 100 |
| 3 | Herencia + Encapsulamiento | Clase padre `Producto` con precio privado y clase hija `ProductoImportado` con cálculo de impuestos |
| 4 | Encapsulamiento | Clase `Usuario` con validación de contraseña mínima de 8 caracteres |
| 5 | Encapsulamiento | Clase `Servidor` con estado de conexión de solo lectura modificable únicamente vía `HacerPing()` |
| 6 | Clases Abstractas + Polimorfismo | Clase abstracta `Animal` con implementaciones `Perro`, `Gato` y `Vaca` |
| 7 | Clases Abstractas + Polimorfismo | Clase abstracta `DispositivoRed` con implementaciones `Router` y `Switch` para monitoreo IT |

## Tecnologías

- C# / .NET
- Aplicación de consola

## Ejecución

```bash
dotnet new console -n EjerciciosEncapsulamiento --use-program-main
# Reemplazar Program.cs con Encapsulamiento.cs
dotnet run
```