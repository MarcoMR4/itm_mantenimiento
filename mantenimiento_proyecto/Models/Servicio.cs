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

        // meses 0, 1 
        public int enero { get; set; }
        public int febrero { get; set; }
        public int marzo { get; set; }
        public int abril { get; set; }
        public int mayo { get; set; }
        public int junio { get; set; }
        public int julio { get; set; }  
        public int agosto { get; set; }
        public int septiembre { get; set; } 
        public int octubre { get; set; }
        public int noviembre { get; set; }  
        public int diciembre { get; set; }




    }
}
