using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Compra
    {
        public int id { get; set; }
        public int f_cliente { get; set; }
        public int f_producto { get; set; }
        public int cantidad { get; set; }
        public DateTime fecha { get; set; }
    }
}
