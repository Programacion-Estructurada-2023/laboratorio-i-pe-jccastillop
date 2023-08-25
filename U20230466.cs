using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Laboratorio Practico Juan Carlos Castillo Parada U20230466 
            // PARTE 1 Realizar la declaración y asignación de valores.
            string departamento, municipio, ciudad;
            Console.Write("Ingrese el nombre del departamento: ");
            departamento = Console.ReadLine();

            Console.Write("Ingrese el nombre del municipio: ");
            municipio = Console.ReadLine();

            Console.Write("Ingrese el nombre de la ciudad: ");
            ciudad = Console.ReadLine();

            string colonia = "Colonia Gutierrez";
            string colorCasa = "Bloque";

            int añosEnResidencia, edadActual;
            Console.Write("Ingrese los años viviendo en la residencia actual: ");
            añosEnResidencia = int.Parse(Console.ReadLine());

            Console.Write("Ingrese su edad actual: ");
            edadActual = int.Parse(Console.ReadLine());

            DateTime fechaNacimiento = new DateTime(2002, 08, 13);
            DateTime fechaActual = DateTime.Now;

            // PARTE 2 Realizar el proceso de asignación de funciones.

            bool comparacion = colonia.Equals(ciudad);
            string concatenar = departamento + " - " + municipio;
            string mayuscula = colorCasa.ToUpper();
            string cadenaLimpia = ciudad.Trim();
            int longitudColonia = colonia.Length;
            int longitudCiudad = ciudad.Length;

            string fechaNacimientoFormateada = fechaNacimiento.ToString("dd/MM/yyyy");
            DateTime fechaNacimientoCon2Semanas = fechaNacimiento.AddDays(14);
            DateTime fechaActualCon2Semanas = fechaActual.AddDays(14);
            bool fecha1Mayor = fechaNacimientoCon2Semanas > fechaActualCon2Semanas;
            bool fecha1Menor = fechaNacimientoCon2Semanas < fechaActualCon2Semanas;

            // PARTE 3 Impresión de valores en consola.
            Console.WriteLine("Variables de texto:");
            Console.WriteLine($"Departamento: {departamento}");
            Console.WriteLine($"Municipio: {municipio}");
            Console.WriteLine($"Ciudad: {ciudad}");
            Console.WriteLine($"Colonia: {colonia}");
            Console.WriteLine($"Color de casa: {colorCasa}");

            Console.WriteLine("\nVariables enteras:");
            Console.WriteLine($"Años en residencia: {añosEnResidencia}");
            Console.WriteLine($"Edad actual: {edadActual}");

            Console.WriteLine("\nComparaciones de cadenas:");
            Console.WriteLine($"Comparación de colonia y ciudad: {comparacion}");
            Console.WriteLine($"Concatenación de departamento y municipio: {concatenar}");
            Console.WriteLine($"Mayúscula de color de casa: {mayuscula}");
            Console.WriteLine($"Cadena limpia de ciudad: {cadenaLimpia}");
            Console.WriteLine($"Longitud de colonia: {longitudColonia}");
            Console.WriteLine($"Longitud de ciudad: {longitudCiudad}");

            Console.WriteLine("\nFunciones de fechas:");
            Console.WriteLine($"Fecha de nacimiento formateada: {fechaNacimientoFormateada}");
            Console.WriteLine($"Fecha de nacimiento + 2 semanas: {fechaNacimientoCon2Semanas}");
            Console.WriteLine($"Fecha actual + 2 semanas: {fechaActualCon2Semanas}");
            Console.WriteLine($"¿Fecha de nacimiento + 2 semanas es mayor? {fecha1Mayor}");
            Console.WriteLine($"¿Fecha de nacimiento + 2 semanas es menor? {fecha1Menor}");

            // Autoevaluacion 10
        }
    }
}