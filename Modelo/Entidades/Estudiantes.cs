using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Estudiantes
    {
        private int id_alumno;
        private string nombre_alum;
        private string apellido_alum;
        private int carnet;

        public int Id_alumno { get => id_alumno; set => id_alumno = value; }
        public string Nombre_alum { get => nombre_alum; set => nombre_alum = value; }
        public string Apellido_alum { get => apellido_alum; set => apellido_alum = value; }
        public int Carnet { get => carnet; set => carnet = value; }
    }
}
