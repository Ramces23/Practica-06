using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_1
{
    public class Persona
    {
        public string cedula;
        public string nombre;
        public string apellido;
        public int edad;

        public Persona() {
            cedula = "";
            nombre = "";
            apellido = "";
            edad = 0;
        }
        public void InCedula(String c)
        {
            cedula +=  c;
        }
        public void InNombre(String n)
        {
            nombre += n;
        }
        public void InApellido(String a)
        {
            apellido += a;
        }
        public void InEdad(int e)
        {
            edad += e;
        }
        public void VerPersona() 
        {
            Console.WriteLine("Bienvenido {0} {1}, Su cedula es: {2} y su edad es {3}",nombre,apellido,cedula,edad );
        
        }
        public void InDatos()
        {
            Console.WriteLine("Digite su nombre");
            InNombre(Console.ReadLine());
            Console.WriteLine("Digite su apellido");
            InApellido(Console.ReadLine());
            Console.WriteLine("Digite su cedula");
            InCedula(Console.ReadLine());
            Console.WriteLine("Digite su edad");
            InEdad(int.Parse(Console.ReadLine()));


        }

    }
}
