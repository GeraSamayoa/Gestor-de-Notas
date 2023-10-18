using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Estudiante:Persona
    {
       public int NumeroCarne {  get; set; }
       public char Estatus {  get; set; }
       public DateTime FehcaIngreso { get; set; }

       public DateTime FechaEgreso { get; set; }

       public string NombreCarrera { get; set; }

       public Estudiante(int numerocarne, char estatus, DateTime fechaingreso, DateTime fechaegreso, string nombrecarrera, int identificacion, string nombre, string apellido, DateTime fechanacimiento)
            :base(identificacion, nombre, apellido, fechanacimiento) { 
            this.NombreCarrera = nombrecarrera;
            this.Estatus = estatus;
            this.FehcaIngreso = fechaingreso;
            this.FechaEgreso = fechaegreso;
            this.NombreCarrera = nombrecarrera;

        }
 
    }
}
