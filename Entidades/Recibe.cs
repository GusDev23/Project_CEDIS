using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Recibe
    {
        public int id { get; set; }
        public string chofer { get; set; }
        public DateTime fechaEntrega { get; set; }
        public int f_compra { get; set; }
    }
}
