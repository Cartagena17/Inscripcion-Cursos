using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Inscripcion
    {
        private int id_inscripcion;
        private DateTime fecha_inscr;
        private int id_alumno;
        private int id_curso;

        public int Id_inscripcion { get => id_inscripcion; set => id_inscripcion = value; }
        public DateTime Fecha_inscr { get => fecha_inscr; set => fecha_inscr = value; }
        public int Id_alumno { get => id_alumno; set => id_alumno = value; }
        public int Id_curso { get => id_curso; set => id_curso = value; }
    }
}
