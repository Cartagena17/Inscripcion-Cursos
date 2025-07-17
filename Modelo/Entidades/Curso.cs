using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Curso
    {
        private int id_curso;
        private string nombre_cur;

        public int Id_curso { get => id_curso; set => id_curso = value; }
        public string Nombre_cur { get => nombre_cur; set => nombre_cur = value; }
    }
}
