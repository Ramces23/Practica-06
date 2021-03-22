using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_2
{
    public class Contacto
    {

        public string nombre;
        public string apellido;
        public string telefono;
        public string direccion;


        public Contacto()
        {

            nombre = "";
            apellido = "";
            telefono = "";
            direccion = "";
        }
        public void InNombre(String n)
        {
            nombre += n;
        }
        public void InApellido(String a)
        {
            apellido += a;
        }
        public void InTelefono(String t)
        {
            telefono += t;
        }
        public void InDireccion(String d)
        {
           direccion += d;
        }
        public void SetContacto()
        {
            Console.WriteLine("Digite su nombre");
            InNombre(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Digite su apellido");
            InApellido(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Digite su numero de telefono");
            InTelefono(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Digite su direccion");
            InDireccion(Console.ReadLine());
            Console.Clear();


        }
        public void Saludar()
        {
            Console.WriteLine("Hola, soy {0} {1}, mi direccion es: {2} y mi numero de telefono es: {3}", nombre, apellido, direccion, telefono );

        }

    }
}
