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
        //Tomar en cuenta :D
        public AsignacionDocente IdAsignacionDocente { get; set; }
        public char Estatus 

        public Docente(int idDocente, char estatus)
            :base(idpersona, nombre, apellido, fechanacimiento, genero) {
            this.IdDocente = idDocente;
            this.Estatus = estatus;
        }

        public List<Docente> listaDocente = new List<Docente>();
        
        public void AgregarDocente(Docente docente)
        {
            listaDocente.Add(docente);
        }
        
        public void EliminarDocente(Docente docente)
        {
            listaDocente.Remove(docente);
        }
    }
}
