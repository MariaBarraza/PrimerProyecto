using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            //crear instancia
            Persona persona1 = new Persona(25,"José"); //se le pueden poner directamente los valores
            Console.WriteLine(persona1.Nombre + " tiene " + persona1.Edad + " años.");
            persona1.cumplirAnio();
            Console.WriteLine("Ahora " + persona1.Nombre + " tiene " + persona1.Edad + " años. ");
            Console.ReadLine();
        }
    }
}
