using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string marca { get; set; }
        public string sabor { get; set; }
        public int existencia { get; set; }
        public double precio { get; set; }
    }
}
