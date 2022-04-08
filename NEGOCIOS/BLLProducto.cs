using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using DATOS;
namespace NEGOCIOS
{
    public class BLLProducto
    {
        OperacionesSQL objeto = new OperacionesSQL();
        public DataTable Producto_Mostrar()
        {
            DataTable tabla = new DataTable();
            tabla = objeto.Producto_Mostrar();
            return tabla;
        }

        public void Insertar_producto(Producto prod)
        {

            objeto.Insertar_producto(prod);
        }
        public DataTable Idproveedor()
        {
            OperacionesSQL objeto = new OperacionesSQL();
            DataTable tabla = new DataTable();
            tabla = objeto.Idproveedor();
            return tabla;
        }
        public void Modificar_producto(Producto prod)
        {
            objeto.Modificar_producto(prod);
        }
        public void Baja_producto(Producto prod)
        {
            objeto.Baja_producto(prod);
        }
    }
}
