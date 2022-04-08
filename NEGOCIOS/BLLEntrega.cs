using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS;
using Entidades;
using System.Data;
namespace NEGOCIOS
{
    public class BLLEntrega
    {
        OperacionesSQL objeto = new OperacionesSQL();
        DataTable tabla = new DataTable();
        public DataTable Entrega_Mostrar()
        {
            tabla = objeto.Entrega_Mostrar();
            return tabla;
        }
        public void insertar_entrega(Entrega ent)
        {
            objeto.insertar_entrega(ent);
        }
        public DataTable idProducto()
        {
            OperacionesSQL objeto = new OperacionesSQL();
            DataTable tabla = new DataTable();
            tabla = objeto.Idproducto();
            return tabla;
        }
        public DataTable idcliente()
        {
            OperacionesSQL objeto = new OperacionesSQL();
            DataTable tabla = new DataTable();
            tabla = objeto.Idcliente();
            return tabla;
        }
        public void Modificar_entrega(Entrega ent)
        {
            objeto.Modificar_entrega(ent);
        }
        public void Eliminar(Entrega ent)
        {
            objeto.Eliminar_entrega(ent);
        }
    }
}
