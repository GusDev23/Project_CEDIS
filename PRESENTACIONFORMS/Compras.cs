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
    public partial class Compras : Form
    {
        BLLCompra objeto = new BLLCompra();
        int idpro=0;
        int idclie=0;
        int idCompra = 0;
        public Compras()
        {
            
            InitializeComponent();
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            MostrarCompra();
            MostrarProd();
            MostrarClie();            
        }
        private void MostrarProd()
        {
            cmbIdproducto.DataSource = objeto.idProducto();
            cmbIdproducto.DisplayMember = "nombre";
            cmbIdproducto.ValueMember = "idProducto";
        }
        private void MostrarClie()
        {
            cmbIdcliente.DataSource = objeto.idcliente();
            cmbIdcliente.DisplayMember = "nombreEmpresa";
            cmbIdcliente.ValueMember = "idCliente";
        }
        private void MostrarCompra()
        {
            dgvCompra.DataSource = objeto.Compra_Mostrar();
        }
        private void LimpiarDVG()
        {
            DataTable dt = (DataTable)dgvCompra.DataSource;
            dt.Clear();
        }
        private void Limpiar()
        {
            cmbIdcliente.Text = "";
            cmbIdproducto.Text = "";
            txtCantidad.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //INSERTAR//
            Compra com = new Compra()
            {
                f_cliente = Convert.ToInt32(cmbIdcliente.SelectedValue),
                f_producto = Convert.ToInt32(cmbIdproducto.SelectedValue),
                cantidad = Convert.ToInt32(txtCantidad.Text),
                fecha = DateTime.Now
            };
            try
            {
                objeto.insertar_compra(com);
                MessageBox.Show("Registro insertado correctamente");
                Limpiar();
                LimpiarDVG();
                MostrarCompra();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operacion fallida por: " + ex);
            }
        }    
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvCompra.SelectedRows.Count > 0)
            {
                Compra pro = new Compra()
                {
                    id = idCompra,
                    f_cliente = idclie,
                    f_producto = idpro,
                    cantidad = Convert.ToInt32(txtCantidad.Text),
                    fecha = Convert.ToDateTime(dgvCompra.CurrentRow.Cells["fechaCompra"].Value)
                };
                objeto.Modificar_compra(pro);
                Limpiar();
                LimpiarDVG();
                MostrarCompra();
            }
            else
                MessageBox.Show("Selecciona la fila a editar");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCompra.SelectedRows.Count > 0)
            {
                idCompra = Convert.ToInt32(dgvCompra.CurrentRow.Cells["idCompra"].Value);
                Compra com = new Compra()
                {
                    id = idCompra
                };
                objeto.Eliminar(com);
                MessageBox.Show("Operacion exitosa");
                Limpiar();
                LimpiarDVG();
                MostrarCompra();
            }
            else
                MessageBox.Show("Error en la operacion");
        }

        private void dgvCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idCompra = Convert.ToInt32(dgvCompra.CurrentRow.Cells["idCompra"].Value);
            idpro = Convert.ToInt32(dgvCompra.CurrentRow.Cells["f_idProducto"].Value);
            idclie = Convert.ToInt32(dgvCompra.CurrentRow.Cells["f_idCliente"].Value);
            txtCantidad.Text = dgvCompra.CurrentRow.Cells["cantidad"].Value.ToString();
        }
    }
}
