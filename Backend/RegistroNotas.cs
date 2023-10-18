using System;
using System.Collections.Generic;

namespace Backend
{
    public class RegistroNotas
    {
        public Docente Docentes { get; set; }
        public List<Docente> docentes { get; set; }
        public Carrera Carreras { get; set; }
        public List<Carrera> carreras { get; set; }
        public Jornada Jornada { get; set; }
        public List<Jornada> jornadas { get; set; }
        public Ciclo Ciclos { get; set; }
        public List<Ciclo> ciclos { get; set; }
        public Seccion Secciones { get; set; }
        public List<Seccion> secciones { get; set; }
        public Curso Cursos { get; set; }
        public List<Curso> cursos { get; set; }
        public Periodo Periodos { get; set; }
        public List<Periodo> periodos { get; set; }
        public Estudiante Estudiantes { get; set; }
        public List<Estudiante> estudiantes { get; set; }
        public Asignacion IdAsignaciones { get; set; }
        public List<Asignacion> asignaciones { get; set; }

        public int IdNota { get; set; }
        public string TipoDeNotas { get; set; }
        public int NotaAlumno { get; set; }
        public int Zona { get; set; }
        public int NotaTotal { get; set; }

        // Tipos de notas constantes
        public static List<string> tipoDeNotas = new List<string>() { "Primer Parcial", "Segundo Parcial", "Actividades", "Examen Final" };

        // Lista global de notas
        public static List<RegistroNotas> ListaRegistroNotas = new List<RegistroNotas>();

        public RegistroNotas(int idNota, int notaAlumno, int zona, int notaTotal)
        {
            docentes = new List<Docente>();
            carreras = new List<Carrera>();
            jornadas = new List<Jornada>();
            ciclos = new List<Ciclo>();
            secciones = new List<Seccion>();
            cursos = new List<Curso>();
            periodos = new List<Periodo>();
            estudiantes = new List<Estudiante>();
            asignaciones = new List<Asignacion>();
            IdNota = idNota;

            // Validar y asignar el tipo de notas
            if (tipoDeNotas.Contains(TipoDeNotas))
            {
                this.TipoDeNotas = TipoDeNotas;
            }
            else
            {
                throw new ArgumentException("Tipo de notas no válido.");
            }

            // Validar las notas
            if (notaAlumno >= 0 && notaAlumno <= 100)
            {
                NotaAlumno = notaAlumno;
            }
            else
            {
                throw new ArgumentException("Nota de alumno no válida.");
            }

            Zona = zona;
            NotaTotal = notaTotal;
        }

        // Método para agregar registro de notas
        public void AgregarRegistroNotas(RegistroNotas registroNotas)
        {
            // Realiza validaciones antes de agregar
            if (registroNotas.NotaAlumno >= 0 && registroNotas.NotaAlumno <= 100 && TipoDeNotas.Contains(registroNotas.TipoDeNotas))
            {
                ListaRegistroNotas.Add(registroNotas);
            }
        }

        // Método para eliminar registro de notas
        public void EliminarRegistroNotas(RegistroNotas registroNotas)
        {
            ListaRegistroNotas.Remove(registroNotas);
        }

        // Método para modificar registro de notas
        public void ModificarRegistroNotas(int indice, RegistroNotas registroNotas)
        {
            ListaRegistroNotas[indice] = registroNotas;
        }

        // Método para mostrar registro de notas
        public List<RegistroNotas> MostrarRegistroNotas()
        {
            return ListaRegistroNotas;
        }

        // Método para buscar registro de notas
        public List<RegistroNotas> BuscarRegistroNotas(string buscar)
        {
            List<RegistroNotas> resultados = new List<RegistroNotas>();
            foreach (RegistroNotas registroNotas in ListaRegistroNotas)
            {
                if (registroNotas.IdNota.ToString().Contains(buscar))
                {
                    resultados.Add(registroNotas);
                }
            }
            return resultados;
        }
    }
}
