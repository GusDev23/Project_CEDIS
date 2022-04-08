using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DATOS;
using Entidades;
namespace NEGOCIOS
{
    public class BLLCompra
    {
        OperacionesSQL objeto = new OperacionesSQL();
        DataTable tabla = new DataTable();
        public DataTable Compra_Mostrar()
        {
            tabla = objeto.Compra_Mostrar();
            return tabla;
        }
        public void insertar_compra(Compra com)
        {
            objeto.insertar_compra(com);
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
        public void Modificar_compra(Compra com)
        {
            objeto.Modificar_compra(com);
        }
        public void Eliminar(Compra com)
        {
            objeto.Eliminar_compra(com);
        }
    }
}
