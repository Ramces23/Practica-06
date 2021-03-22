using System;

namespace Ejercicio_1
{
    class Program
    {

        static void Main(string[] args)
        {

            int y = 0;
            Persona Per = new Persona();
            Profesor Profe = new Profesor();
            Console.WriteLine("Programa desarrollado por Ramces Batista Peña para introdicir datos de personas y profesores ");
            Console.WriteLine("¿Usted es un profesor? ");
            Console.WriteLine("Presione 1 para Si o 0 para No ");
            y = int.Parse(Console.ReadLine());
            if (y == 0)
            {
                Per.InDatos();
                Per.VerPersona();
            }
            else 
            {
                Profe.InDatos();
                Console.WriteLine("Digite su Sueldo");
                Profe.InSueldo(int.Parse(Console.ReadLine()));
                Profe.VerProfesor();

            }
        }
    }
}
