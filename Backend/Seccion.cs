using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Seccion
    {
        public int IdSeccion {  get; set; }
        public char Estatus {  get; set; }

        public Seccion(int IdSeccion, char Estatus) { 
            this.IdSeccion = IdSeccion;
            this.Estatus = Estatus;
        }
    }
}
