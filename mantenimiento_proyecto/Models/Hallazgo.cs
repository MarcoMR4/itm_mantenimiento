﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mantenimiento_proyecto.Models
{
    internal class Hallazgo
    {
        public int idHallazgo { get; set; }

        public string descripcion { get; set; }

        public int idEspacio { get; set; }

        public string atendido { get; set; }

        public int anio { get; set; }

        public string periodo { get; set; }

        public string nombreEspacio { get; set; }
    }
}
