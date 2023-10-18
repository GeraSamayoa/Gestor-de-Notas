using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Docente:Persona
    {
        public int IdDocente {  get; set; }
        public DateTime HorarioLaboral { get; set; }

        public Docente(int idDocente, DateTime horarioLaboral, int identificacion, string nombre, string apellido, DateTime fechanacimiento)
            :base(identificacion, nombre, apellido, fechanacimiento) {
            this.IdDocente = idDocente;
            this.HorarioLaboral = horarioLaboral;
        }
    }
}
