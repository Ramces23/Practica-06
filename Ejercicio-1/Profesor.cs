using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_1
{
    class Profesor : Persona
    {
        public int sueldo;
        public Profesor() {
            sueldo = 0;
        
        }
        public void InSueldo(int s)
        {
            sueldo += s;
           
        }
        public void VerProfesor()
        {
            Console.WriteLine("Bienvenido {0} {1}, Su cedula es: {2} y su edad es {3} y su sueldo es: RD${4}", nombre, apellido, cedula, edad,sueldo);

        }


    }


}
