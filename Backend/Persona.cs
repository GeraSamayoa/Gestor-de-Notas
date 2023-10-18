using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Persona
    {
        public int Identificacion {  get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set;}
        public DateTime FechaNacimiento {  get; set; } 

        //Contructor
        public Persona(int identificacion, string nombre, string apellido, DateTime fechanacimiento) { 
            this.Identificacion = identificacion;
            this.Nombre = nombre; 
            this.Apellido = apellido;
            this.FechaNacimiento = fechanacimiento;
        }
    }
}
