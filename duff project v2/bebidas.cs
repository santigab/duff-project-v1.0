﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duff_project_v2
{
    public  class bebidas
    {
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public string Cantidad_min { get; set; }
        public string Descripcion { get; set; }
        public bebidas() { }

        public bebidas(string btipo, string bnombre, string bcantidad_min, string bDescripcion)
        {
            this.Tipo = btipo;
            this.Nombre = bnombre;
            this.Cantidad_min = bcantidad_min;
            this.Descripcion = bDescripcion;
        }






    }
}
