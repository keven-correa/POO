using System;

namespace Ejercicios_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime nacimiento = new DateTime(2002, 8, 12);
            Persona persona = new Persona("Jose","marti","12345678909876", nacimiento, "Hombre", "Soltero", "809 111 2222", "calle luna");

            persona.MostrarDatos();
            persona.ValidarMayoriaEdad(nacimiento);
        }
  
    }
    
}
