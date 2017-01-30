using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWSDL
{
    public class Inventario
    {
        public int NumeroInventario { get; set; }
        public string Descripcion { get; set; }
        public string Color { get; set; }
        public decimal Precio { get; set; }
    }
}