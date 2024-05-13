// See https://aka.ms/new-console-template for more informationusing System;
using ConsoleApp6;
using ConsoleApp6;

class Program
{
    static void Main()
    {
        Universidad miUniversidad = new Universidad();

        // se crearon instancias de alumnos y se  agregaron  a la universidad
        Alumno alumno1 = new Alumno("Cristobal", 18, "0517U", Alumno.Carreras.Ingeneria_electronica);
        alumno1.Calificaciones.Add(45);
        alumno1.Calificaciones.Add(90);
        Alumno alumno2 = new Alumno("Daniela S", 20, "0719U", Alumno.Carreras.Ingeneria_de_sistemas);
        alumno2.Calificaciones.Add(24);
        alumno2.Calificaciones.Add(87);
        Alumno alumno3 = new Alumno("Andrea  V", 19, "0512U", Alumno.Carreras.Ingeneria_en_computacion);
        alumno3.Calificaciones.Add(99);
        alumno3.Calificaciones.Add(98);

        miUniversidad.AgregarAlumno(alumno1);
        miUniversidad.AgregarAlumno(alumno2);
        miUniversidad.AgregarAlumno(alumno3);
        List<Alumno> alumnos = miUniversidad.ObtenerListaAlumno();

        // Mostrar detalles de los alumnos
        Console.WriteLine("Lista de Alumnos:");
        Console.WriteLine("┌───────┬───────────┬───────┬───────────┬───────────┐");
        Console.WriteLine("│ Carnet│   Nombre  │  Prom.│ Estado    │ Detalles  │");
        Console.WriteLine("├───────┼───────────┼───────┼───────────┼───────────┤");

        foreach (var alumno in alumnos)
        {
            Console.WriteLine(value: $"│ {alumno.Carnet} │ {alumno.Nombre} │ {alumno.CalcularPromedioCalificaciones()}  │ {alumno.EstadoAprobacion()}  │");
        }

        Console.WriteLine("└───────┴───────────┴───────┴───────────┴───────────┘");
    }
}