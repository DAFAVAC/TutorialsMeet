using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TutorialsMeet.Models
{
    public class Estudiantes
    {
        public int id { get; set; }
        public string PrimerNombre { get; set; }
        public string  SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Correo { get; set; }
        public int Celular { get; set; }
        public bool Estado { get; set; }
    }
}
