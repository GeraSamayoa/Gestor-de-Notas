using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Curso
    {
        public int IdCurso {  get; set; }

        public string NombreCurso { get; set; }

        public Curso(int idcurso, string nombrecurso) 
        { 
            this.IdCurso = idcurso;
            this.NombreCurso = nombrecurso;
        }

        public List<Curso> CursoList;

        public void RepositorioCurso()
        {
            CursoList = new List<Curso>();
        }

        public void AgregarCurso(Curso curso) 
        {
            CursoList.Add(curso);
        }

        public void EliminarCurso (Curso curso)
        {
            CursoList.Remove(curso);
        }
    }
}
