using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Entidades;

namespace DATOS
{
    public class OperacionesSQL
    {
        private ConexionDB conexion = new ConexionDB();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        //--------CLIENTE----------------------------------------------//
        public DataTable Cliente_Mostrar()
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandText = "select * from Cliente";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.cerrarConexion();
            return tabla;
        }
        public void Insertar_cliente(Cliente nuevo)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandText = "Cliente_Create";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nuevo.nombreEmpresa);
            comando.Parameters.AddWithValue("direccion", nuevo.direccion);
            comando.Parameters.AddWithValue("@telefono", nuevo.telefono);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }
        public void Modificar_cliente(Cliente modificar)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandText = "Cliente_Update";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", modificar.id);
            comando.Parameters.AddWithValue("@nombre", modificar.nombreEmpresa);
            comando.Parameters.AddWithValue("direccion", modificar.direccion);
            comando.Parameters.AddWithValue("@telefono", modificar.telefono);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();

        }
        public void Baja_cliente(Cliente cliente)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandText = "Cliente_Delete";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", cliente.id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        
            
        
        //--------PROVEEDOR----------------------------------------------//
        public DataTable Proveedor_Mostrar()
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandText = "select * from Proveedor";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.cerrarConexion();
            return tabla;
        }
        public void Insertar_proveedor(Provedor prove)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandText = "Proveedor_Create";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", prove.nombre);
            comando.Parameters.AddWithValue("@direccion", prove.direccion);
            comando.Parameters.AddWithValue("@telefono", prove.telefono);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            comando.Connection = conexion.cerrarConexion();

        }
        public void Modificar_proveedor(Provedor prove)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandText = "Proveedor_Update";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", prove.id);
            comando.Parameters.AddWithValue("@nombre", prove.nombre);
            comando.Parameters.AddWithValue("@direccion", prove.direccion);
            comando.Parameters.AddWithValue("@telefono", prove.telefono);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            comando.Connection = conexion.cerrarConexion();
        }
        public void Baja_proveedor(Provedor prove)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandText = "Proveedor_Delete";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", prove.id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            comando.Connection = conexion.cerrarConexion();
        }
        //--------PRODUCTO----------------------------------------------//
        public DataTable Producto_Mostrar()
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandText = "select * from Producto";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.cerrarConexion();
            return tabla;
        }
        public void Insertar_producto(Producto pro)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandText = "Producto_Create";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", pro.nombre);
            comando.Parameters.AddWithValue("@marca", pro.marca);
            comando.Parameters.AddWithValue("@sabor", pro.sabor);
            comando.Parameters.AddWithValue("@existencia", pro.existencia);
            comando.Parameters.AddWithValue("@precio", pro.precio);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.cerrarConexion();
        }
        public DataTable Idproveedor()
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandText = "select idProveedor from Proveedor";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.cerrarConexion();
            return tabla;
        }
        public void Modificar_producto(Producto pro)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandText = "Producto_Update";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", pro.id);
            comando.Parameters.AddWithValue("@nombre", pro.nombre);
            comando.Parameters.AddWithValue("@marca", pro.marca);
            comando.Parameters.AddWithValue("@sabor", pro.sabor);
            comando.Parameters.AddWithValue("@existencia", pro.existencia);
            comando.Parameters.AddWithValue("@precio", pro.precio);


            comando.ExecuteNonQuery();

            comando.Parameters.Clear();

        }
        public void Baja_producto(Producto pro)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandText = "Producto_Delete";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", pro.id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            comando.Connection = conexion.cerrarConexion();
        }
        //--------COMPRA----------------------------------------------//
        public DataTable Compra_Mostrar()
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandText = "select * from Compra";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.cerrarConexion();
            return tabla;
        }
        public void insertar_compra(Compra com)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandText = "Compra_Create";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@f_cliente", com.f_cliente);
            comando.Parameters.AddWithValue("@f_producto", com.f_producto);
            comando.Parameters.AddWithValue("@cantidad", com.cantidad);
            comando.Parameters.AddWithValue("@fecha", com.fecha);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.cerrarConexion();
        }
        public DataTable Idproducto()
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandText = "select idProducto, nombre from Producto";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.cerrarConexion();
            return tabla;
        }
        public DataTable Idcliente()
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandText = "select idCliente,nombreEmpresa from Cliente";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.cerrarConexion();
            return tabla;
        }
        
        public void Modificar_compra(Compra com)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandText = "Compra_Update";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", com.id);
            comando.Parameters.AddWithValue("@f_cliente", com.f_cliente);
            comando.Parameters.AddWithValue("@f_producto", com.f_producto);
            comando.Parameters.AddWithValue("@cantidad", com.cantidad);
            comando.Parameters.AddWithValue("@fecha", com.fecha);
            comando.ExecuteNonQuery();
            conexion.cerrarConexion();
            comando.Parameters.Clear();

        }
        public void Eliminar_compra(Compra com)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandText = "Compra_Delete";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", com.id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            comando.Connection = conexion.cerrarConexion();
        }
        ////----------------ENTREGA------------------------////

        public DataTable Entrega_Mostrar()
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandText = "select * from Entrega";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.cerrarConexion();
            return tabla;
        }
        public void insertar_entrega(Entrega ent)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandText = "Entrega_Create";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@f_proveedor", ent.f_proveedor);
            comando.Parameters.AddWithValue("@f_producto", ent.f_producto);
            comando.Parameters.AddWithValue("@cantidad", ent.cantidad);
            comando.Parameters.AddWithValue("@fecha", ent.fecha);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.cerrarConexion();
        }
        public void Modificar_entrega(Entrega ent)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandText = "Entrega_Update";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", ent.id);
            comando.Parameters.AddWithValue("@f_proveedor", ent.f_proveedor);
            comando.Parameters.AddWithValue("@f_producto", ent.f_producto);
            comando.Parameters.AddWithValue("@cantidad", ent.cantidad);
            comando.Parameters.AddWithValue("@fecha", ent.fecha);
            comando.ExecuteNonQuery();
            conexion.cerrarConexion();
            comando.Parameters.Clear();

        }
        public void Eliminar_entrega(Entrega ent)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandText = "Entrega_Delete";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", ent.id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            comando.Connection = conexion.cerrarConexion();
        }

        ////------------------RECIBE------------------////

        public DataTable Recibe_Mostrar()
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandText = "select * from Recibe";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.cerrarConexion();
            return tabla;
        }
        public void insertar_recibe(Recibe re)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandText = "Recibe_Create";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@chofer", re.chofer);
            comando.Parameters.AddWithValue("@fecha", re.fechaEntrega);
            comando.Parameters.AddWithValue("@f_compra", re.f_compra);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.cerrarConexion();
        }
        public void Modificar_recibe(Recibe re)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandText = "Entrega_Update";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", re.id);
            comando.Parameters.AddWithValue("@chofer", re.chofer);
            comando.Parameters.AddWithValue("@fecha", re.fechaEntrega);
            comando.Parameters.AddWithValue("@f_compra", re.f_compra);
            comando.ExecuteNonQuery();
            conexion.cerrarConexion();
            comando.Parameters.Clear();

        }
        public void Eliminar_recibe(Recibe re)
        {
            comando.Connection = conexion.abrirConexion();
            comando.CommandText = "Recibe_Delete";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", re.id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            comando.Connection = conexion.cerrarConexion();
        }
    }
}
