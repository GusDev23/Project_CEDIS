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
    public partial class Form1 : Form
    {
        BLLCliente obj = new BLLCliente();
        public int idCliente = 0;
        public bool Editar = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostarClientes();
        }
        private void MostarClientes()
        {
            dgvCliente.DataSource = obj.mostrarCliente();
        }
        private void LimpiarDGV()
        {
            DataTable dt = (DataTable)dgvCliente.DataSource;
            dt.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //INSERTAR//
            Cliente cliente = new Cliente()
            {
                nombreEmpresa=txtNombre.Text,
                direccion=txtDireccion.Text,
                telefono=txtTelefono.Text
            };
            if (Editar == false)
            {
                try
                {
                    obj.Insertarcliente(cliente);
                    MessageBox.Show("Registro insertado correctamente");
                    Limpiar();
                    LimpiarDGV();
                    MostarClientes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Operacion fallida por: " + ex);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count > 0)
            {
                Editar = true;
                
                Cliente cliente = new Cliente()
                {
                    id = idCliente,
                    nombreEmpresa = txtNombre.Text,
                    direccion = txtDireccion.Text,
                    telefono = txtTelefono.Text
                };
                obj.Modificarcliente(cliente);
                LimpiarDGV();
                MostarClientes();
                Limpiar();
            }
            else
                MessageBox.Show("Selecciona la fila a editar");
        } 
        private void Limpiar()
        {
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count > 0)
            {
                idCliente = Convert.ToInt32(dgvCliente.CurrentRow.Cells["idCliente"].Value);
                Cliente cliente = new Cliente()
                {
                    id = idCliente
                };
                obj.Bajacliente(cliente);
                MessageBox.Show("Operacion exitosa");
                LimpiarDGV();
                MostarClientes();
                Limpiar();
            }
            else
                MessageBox.Show("Error en la operacion");
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dgvCliente.CurrentRow.Cells["nombreEmpresa"].Value.ToString();
            txtDireccion.Text = dgvCliente.CurrentRow.Cells["direccion"].Value.ToString();
            txtTelefono.Text = dgvCliente.CurrentRow.Cells["telefono"].Value.ToString();
            idCliente = Convert.ToInt32(dgvCliente.CurrentRow.Cells["idCliente"].Value);
        }
    }
}
