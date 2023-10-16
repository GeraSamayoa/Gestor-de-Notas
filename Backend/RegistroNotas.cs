using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class RegistroNotas
    {
        public Docente docentes { get; set; }
        public Estudiante estudiantes { get; set; }
        public Carrera carreras { get; set; }
        public Asignacion asignaciones { get; set; }

        public int IdAsignacion { get; set; }
        public int IdNota { get; set; }
        public int NotaAlumno { get; set; }
        public int NotaTotal { get; set; }
        // metodo para obtener nota
        public int ObtenerNota()
        {
            Console.WriteLine("Ingrese la nota del alumno: ");
            NotaAlumno = Convert.ToInt32(Console.ReadLine());
            return NotaAlumno;
        }
        
    }
}
