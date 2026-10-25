# Gym

Desarrollar una pequeña aplicación para gestionar las actividades de un gimnasio.

Crear una clase abstracta:

```csharp
Actividad
```

Todas las actividades tendrán:

- Nombre.
- Duración.
- Número máximo de participantes.

Crear al menos:

```text
Actividad
 |
 +-- Spinning
 |
 +-- Yoga
 |
 +-- CrossTraining
```

Cada clase deberá tener alguna propiedad específica.

Definir en `Actividad` al menos un método abstracto que deba ser implementado por las clases hijas.

Crear varias actividades y almacenarlas en:

```csharp
List<Actividad>
```

La aplicación tendrá un menú similar a:

```text
=== GIMNASIO ===

1. Ver actividades
2. Buscar actividad
3. Ver actividades por duración máxima
4. Ver actividades por tipo
0. Salir
```

Requisitos:

- Utilizar herencia.
- Utilizar una clase abstracta.
- Utilizar `override`.
- Utilizar polimorfismo.
- Utilizar `List<Actividad>`.
- Utilizar `is` en alguna operación.
- Utilizar métodos.
- Pasar las colecciones mediante parámetros.
- Utilizar `while` y `switch`.
- Utilizar `TryParse()` cuando sea necesario.
- Controlar las entradas incorrectas.

No utilizar LINQ.
