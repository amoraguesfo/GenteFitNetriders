using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenteFitNetriders.Modelo
{
    internal class ReservaViewModel
    {
        public int id { get; set; }
        public int id_usuario { get; set; }
        public string nombre_usuario { get; set; }
        public string email_usuario { get; set; }
        public int id_clase { get; set; }
        public string nombre_clase { get; set; }
        public DateTime fecha_clase { get; set; }
        public TimeSpan hora_clase { get; set; }
        public string estado { get; set; }
    }
}
