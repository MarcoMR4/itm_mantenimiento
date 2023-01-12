using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mantenimiento_proyecto.Models
{
    public class Personal
    {
        public int idPersonal { get; set; }

        public string nombres { get; set; }

        public string apellidoPaterno { get; set; }

        public string apellidoMaterno { get; set; }

        public string cargo { get; set; }

        public int idArea { get; set; }

        public string nombreArea { get; set;}
    }
}
