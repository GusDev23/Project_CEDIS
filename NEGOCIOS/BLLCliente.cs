using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DATOS;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace NEGOCIOS
{
    public class BLLCliente
    {
        OperacionesSQL objOperaciones = new OperacionesSQL();
        public void Insertarcliente(Cliente nuevo)
        {
            objOperaciones.Insertar_cliente(nuevo);
        }
        public DataTable mostrarCliente()
        {
            DataTable tabla = new DataTable();
            tabla = objOperaciones.Cliente_Mostrar();
            return tabla;
        }
        public void Modificarcliente(Cliente update)
        {
            objOperaciones.Modificar_cliente(update);
        }
        public void Bajacliente(Cliente cli)
        {
            objOperaciones.Baja_cliente(cli);
        }
    }
}
