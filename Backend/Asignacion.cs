using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Asignacion
    {
        public int IdAsignacion { get; set; }
        public Estudiante IdNumeroCarne { get; set; } //Estudiante
        public Docente IdDocente { get; set; }
        public Seccion IdSeccion { get; set; }
        public Ciclo IdCiclo { get; set; }
        public Jornada IdJornada { get; set; }
        public string FechaAsignacion { get; set; }
        public Periodo IdPeriodo { get; set; }
       /* public int IdCurso { get; set; }
        public int IdCarrera { get; set; } */

        

         
    }
}
