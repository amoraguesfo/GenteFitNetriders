using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenteFitNetriders.Modelo
{
    internal class ClaseViewModel
    {
        public int id { get; set; }
        public string nombre_clase { get; set; }
        public string profesor { get; set; }
        public int plazas { get; set; }

        public int reservas { get; set; }
        public System.DateTime fecha_clase { get; set; }
        public System.TimeSpan hora_clase { get; set; }
        public int duracion { get; set; }
    }
}

    
