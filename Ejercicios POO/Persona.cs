using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_POO
{
    class Persona
    {
        public Persona()
        {

        }

        public Persona(
            string nombre,
            string apellido,
            string numeroIdentificacion,
            DateTime fechaNacimiento,
            string sexo,
            string estadoCivil,
            string telefono,
            string direccion)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.NumeroIdentificacion = numeroIdentificacion;
            this.FechaNacimiento = fechaNacimiento;
            this.Sexo = sexo;
            this.EstadoCivil = estadoCivil;
            this.Telefono = telefono;
            this.Direccion = direccion;
        }

        public string Nombre { get; set; }

        public string  Apellido { get; set; }

        public string NumeroIdentificacion { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string Sexo { get; set; }

        public string EstadoCivil { get; set; }

        public string Telefono { get; set; }

        public string Direccion { get; set; }

        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Apellido: {Apellido}");
            Console.WriteLine($"Numero de Identificacion: {NumeroIdentificacion}");
            Console.WriteLine($"Fecha de nacimiento {FechaNacimiento.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Sexo: {Sexo}");
            Console.WriteLine($"Estado civil {EstadoCivil}");
            Console.WriteLine($"Telefono: {Telefono}");
            Console.WriteLine($"Direccion: {Direccion}");
        }

        //Este metodo valorara primero que edad tiene la persona y luego de hacer dicha evaluacion mostraria si es mayor de edad o no
        public int ValidarMayoriaEdad(DateTime fechaNacimiento)
        {
            //calcular la diferencia de anios
            int edad = DateTime.Now.Year - fechaNacimiento.Year;

            //Este codigo es para obtener la fecha de "cumpleanos del anio en curso
            DateTime fechaNacimientoActual = fechaNacimiento.AddYears(edad);

            if(DateTime.Now.CompareTo(fechaNacimientoActual) > 0)
            {
                //Si la fecha actual es anterior, se le resta un dia al nacimiento
                edad--;
            }
            if(edad > 18)
            {
                Console.WriteLine($"Edad: {edad} -> Es mayor de edad.");
            }
            else
            {
                Console.WriteLine($"Edad: {edad} -> Es menor de edad.");
            }
            //Console.WriteLine($"La edad es: {edad}");
            return edad;
        }
    }
    
}
