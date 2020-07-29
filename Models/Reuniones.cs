using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TutorialsMeet.Models
{
    public class Reuniones
    {
        public int id { get; set; }
        public string Codigo_registro{ get; set; }
        public bool Estado { get; set; }
        public string Tema { get; set; }
        public DateTime Fecha { get; set; }
        public string Chat { get; set; }
        public DateTime Hora_Inicio { get; set; }
        public DateTime Hora_Finaliza { get; set; }
        public Estudiantes Estudiantes { get; set; } //Se relaciona con la clase estudiantes

    }
}
