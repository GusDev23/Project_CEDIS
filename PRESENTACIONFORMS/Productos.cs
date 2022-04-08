using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NEGOCIOS;
using Entidades;

namespace PRESENTACIONFORMS
{
    public partial class Productos : Form
    {
        BLLProducto objeto = new BLLProducto();
        public  int idproducto = 0;
        public Productos()
        {
            InitializeComponent();
        }
        private void Productos_Load(object sender, EventArgs e)
        {
            MostarProductos();
        }
        private void Limpiar()
        {
            textNombreproducto.Text = "";
            txtExistencia.Text = "";
            txtPrecio.Text = "";
            txtSabor.Text = "";
            cmbMarca.Text = "";
        }
        private void MostarProductos()
        {
            dgvProducto.DataSource = objeto.Producto_Mostrar();
        }
        private void LimpiarDVG()
        {
            DataTable dt = (DataTable)dgvProducto.DataSource;
            dt.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //INSERTAR//
            Producto pro = new Producto()
            {
                nombre = textNombreproducto.Text,
                marca = cmbMarca.SelectedItem.ToString(),
                sabor = txtSabor.Text,
                existencia = Convert.ToInt32(txtExistencia.Text),
                precio=Convert.ToSingle(txtPrecio.Text)
            };
            try
            {
                objeto.Insertar_producto(pro);
                MessageBox.Show("Registro insertado correctamente");
                LimpiarDVG();
                MostarProductos();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }              
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvProducto.SelectedRows.Count > 0)
            {
                Producto pro = new Producto()
                {
                    id = idproducto,
                    nombre = textNombreproducto.Text,
                    marca = cmbMarca.SelectedItem.ToString(),
                    sabor = txtSabor.Text,
                    existencia = Convert.ToInt32(txtExistencia.Text),
                    precio = Convert.ToSingle(txtPrecio.Text)
                };
                objeto.Modificar_producto(pro);
                LimpiarDVG();
                MostarProductos();
                Limpiar();
            }
            else
                MessageBox.Show("Selecciona la fila a editar");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProducto.SelectedRows.Count > 0)
            {
                idproducto = Convert.ToInt32(dgvProducto.CurrentRow.Cells["idProducto"].Value);
                Producto pro = new Producto()
                {
                    id = idproducto
                };
                objeto.Baja_producto(pro);
                MessageBox.Show("Operacion exitosa");
                LimpiarDVG();
                MostarProductos();
                Limpiar();
            }
            else
                MessageBox.Show("Error en la operacion");
        }

        private void dgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textNombreproducto.Text = dgvProducto.CurrentRow.Cells["nombre"].Value.ToString();
            cmbMarca.Text = dgvProducto.CurrentRow.Cells["marca"].Value.ToString();
            txtSabor.Text = dgvProducto.CurrentRow.Cells["sabor"].Value.ToString();
            txtExistencia.Text = dgvProducto.CurrentRow.Cells["existencia"].Value.ToString();
            txtPrecio.Text = dgvProducto.CurrentRow.Cells["precio"].Value.ToString();
            idproducto = Convert.ToInt32(dgvProducto.CurrentRow.Cells["idProducto"].Value);
        }
    }
}
