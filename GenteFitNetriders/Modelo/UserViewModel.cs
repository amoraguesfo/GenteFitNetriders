using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenteFitNetriders.Modelo
{
    internal class UserViewModel
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string email { get; set; }
        public string sexo { get; set; }
        public int edad { get; set; }
        public string num_telefono { get; set; }
        public string tipo { get; set; }
    }
}
