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
        public List<Estudiante> estudiantes { get; set; }
        public Docente IdDocente { get; set; }
        public List<Docente> docentes { get; set; }    
        public Seccion IdSeccion { get; set; }
        public List<Seccion> secciones { get; set; }
        public Ciclo IdCiclo { get; set; }
        public List<Ciclo> ciclos { get; set; }
        public Jornada IdJornada { get; set; }
        public List<Jornada> jornadas { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public Periodo IdPeriodo { get; set; }
        public List<Periodo> periodos { get; set; }
        public string Estado { get; set; }
        public Curso IdCurso { get; set; }
        public List<Curso> cursos { get; set; }
        public Carrera IdCarrera { get; set; }
        public List<Carrera> carreras { get; set; }



        //Metodo constructor
        public Asignacion(int idAsignacion, DateTime fechaAsignacion,string estado)
        {
            IdAsignacion = idAsignacion;
            estudiantes = new List<Estudiante>();
            carreras = new List<Carrera>();
            periodos = new List<Periodo>();
            jornadas = new List<Jornada>();
            ciclos = new List<Ciclo>();
            cursos = new List<Curso>();
            secciones = new List<Seccion>();
            docentes = new List<Docente>();
            FechaAsignacion = fechaAsignacion;
            Estado = estado;
        }
        //crear lista de asignaciones
        public List<Asignacion> listaAsignaciones = new List<Asignacion>();
        //metodo para agregar asignaciones
        public void AgregarAsignacion(Asignacion asignacion)
        {
            listaAsignaciones.Add(asignacion);
        }
        //metodo para eliminar asignaciones
        public void EliminarAsignacion(Asignacion asignacion)
        {
            listaAsignaciones.Remove(asignacion);
        }
        //metodo para modificar asignaciones
        public void ModificarAsignacion(int indice, Asignacion asignacion)
        {
            listaAsignaciones[indice] = asignacion;
        }
        //metodo para mostrar asignaciones
        public List<Asignacion> MostrarAsignacion()
        {
            return listaAsignaciones;
        }
        //metodo para buscar asignaciones
        public int BuscarAsignacion(int idAsignacion)
        {
            int indice = 0;
            foreach (Asignacion asignacion in listaAsignaciones)
            {
                if (asignacion.IdAsignacion == idAsignacion)
                {
                    return indice;
                }
                indice++;
            }
            return -1;
        }

    }
}
