using System;

namespace Ejercicio_2
{
    class Program
    {
        class ProbarContacto
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Programa desarrollado por Ramces Batista Peña para introdicir datos de contactos ");
                Contacto Con = new Contacto();
                Contacto Con1 = new Contacto();
                Console.WriteLine("Introdusca los datos del contacto 1");
                Con.SetContacto();
                Console.WriteLine("Introdusca los datos del contacto 2");
                Con1.SetContacto();
                Console.WriteLine("Contacto 1");
                Con.Saludar();
                Console.WriteLine("Presione enter para continuar ");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Contacto 2");
                Con1.Saludar();
                Console.WriteLine("Presione enter para continuar ");
                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}
