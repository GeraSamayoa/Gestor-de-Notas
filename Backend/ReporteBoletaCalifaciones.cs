using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class ReporteBoletaCalifaciones
    {
        public int IdBoletaCalificaciones {  get; set; }
        public DateTime FechaBoleta { get; set; }
        public Estudiante estudiante { get; set; }
        public List<Estudiante> estudiantes { get; set; }
        public Asignacion asignacion { get; set; }
        public List<Asignacion> asignaciones { get; set; }
        public Ciclo ciclo { get; set; }
        public List<Ciclo> ciclos { get; set; }
        public Curso curso { get; set; }
        public List<Curso> cursos { get; set; }
        public RegistroNotas registroNotas { get; set; }
        public List<string> tipoDeNotas { get; set; }
        public List<RegistroNotas> notas { get; set; }
        
        public ReporteBoletaCalifaciones(int idBoletaCalificaciones, DateTime fechaBoleta)
        {
            IdBoletaCalificaciones = idBoletaCalificaciones;
            FechaBoleta = fechaBoleta;
            estudiantes = new List<Estudiante>();
            asignaciones = new List<Asignacion>();
            ciclos = new List<Ciclo>();
            cursos = new List<Curso>();
            tipoDeNotas = new List<string>();
            notas = new List<RegistroNotas>();
        }

        public List<ReporteBoletaCalifaciones> listaReporteBoletaCalifaciones = new List<ReporteBoletaCalifaciones>();

        public void AgregarReporteBoletaCalifaciones(ReporteBoletaCalifaciones reporteBoletaCalifaciones)
        {
            listaReporteBoletaCalifaciones.Add(reporteBoletaCalifaciones);
        }
        public void EliminarReporteBoletaCalifaciones(ReporteBoletaCalifaciones reporteBoletaCalifaciones)
        {
            listaReporteBoletaCalifaciones.Remove(reporteBoletaCalifaciones);
        }
        public void ModificarReporteBoletaCalifaciones(int indice, ReporteBoletaCalifaciones reporteBoletaCalifaciones)
        {
            listaReporteBoletaCalifaciones[indice] = reporteBoletaCalifaciones;
        }
        public List<ReporteBoletaCalifaciones> MostrarReporteBoletaCalifaciones()
        {
            return listaReporteBoletaCalifaciones;
        }
        public List<ReporteBoletaCalifaciones> BuscarReporteBoletaCalifaciones(string buscar)
        {
            List<ReporteBoletaCalifaciones> listaReporteBoletaCalifaciones = new List<ReporteBoletaCalifaciones>();
            foreach (ReporteBoletaCalifaciones reporteBoletaCalifaciones in listaReporteBoletaCalifaciones)
            {
                if (reporteBoletaCalifaciones.IdBoletaCalificaciones.ToString().Contains(buscar))
                {
                    listaReporteBoletaCalifaciones.Add(reporteBoletaCalifaciones);
                }
            }
            return listaReporteBoletaCalifaciones;
        }
    }
}
