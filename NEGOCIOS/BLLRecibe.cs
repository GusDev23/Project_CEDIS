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
    public class BLLRecibe
    {
        OperacionesSQL objeto = new OperacionesSQL();
        DataTable tabla = new DataTable();
        public DataTable Recibe_Mostrar()
        {
            tabla = objeto.Recibe_Mostrar();
            return tabla;
        }
        public void insertar_recibe(Recibe re)
        {
            objeto.insertar_recibe(re);
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
        public void Modificar_recibe(Recibe re)
        {
            objeto.Modificar_recibe(re);
        }
        public void Eliminar(Recibe re)
        {
            objeto.Eliminar_recibe(re);
        }
    }
}
