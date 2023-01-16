using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mantenimiento_proyecto.Models
{
    internal class Servicio
    {
        public int idServicio { get; set; }

        public string descripcion { get; set; }

        public string tipoServicio { get; set; }

        public string periodo { get; set; }

        public int anio { get; set; }

        public int idArea { get; set; }

    }
}
