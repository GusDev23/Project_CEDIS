using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Entrega
    {
        public int id { get; set; }
        public int f_proveedor { get; set; }
        public int f_producto { get; set; }
        public int cantidad { get; set; }
        public DateTime fecha { get; set; }
    }
}
