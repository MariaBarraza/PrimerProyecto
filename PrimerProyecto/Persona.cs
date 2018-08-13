using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto
{
    public class Persona
    {
        public int Edad { get; set; }
        public string Nombre { get; set; }

        //constructor con parametros
        public Persona(int edad,string nombre)
        {
            Edad = edad; // se iguala el parametro a la variable global
            Nombre = nombre;
        }

        //constructor sin parametro/vacio
        public Persona()
        {
            Edad = 0; //inicializa la edad en 0
            Nombre = ""; //inicializa el nombre vacio
        }

        //crear funcion para que no regrese nada,que solo modifique un atributo

        public void cumplirAnio()
        {
            Edad++; //para sumar 1 a la variable global
        }
    }
}
