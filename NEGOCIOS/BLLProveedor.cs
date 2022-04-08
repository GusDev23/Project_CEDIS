using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS;
using System.Data;
using Entidades;
namespace NEGOCIOS
{
    public class BLLProveedor
    {
        OperacionesSQL objeto = new OperacionesSQL();
        public DataTable mostrarProveedor()
        {
            DataTable tabla = new DataTable();
            tabla = objeto.Proveedor_Mostrar();
            return tabla;
        }
        public void Insertarproveedor(Provedor pro)
        {
            objeto.Insertar_proveedor(pro);
        }
        public void Modificar_proveedor(Provedor pro)
        {
            objeto.Modificar_proveedor(pro);
        }

        public void Bajaproveedor(Provedor pro)
        {
            objeto.Baja_proveedor(pro);
        }
    }
}
