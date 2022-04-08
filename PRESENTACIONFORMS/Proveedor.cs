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
    public partial class Proveedor : Form
    {
        BLLProveedor objeto = new BLLProveedor();
        public int idProveedor = 0;
        public bool Editar = false;
        public Proveedor()
        {
            InitializeComponent();
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {
            MostarProveedor();
        }
        private void MostarProveedor()
        {
            dgvProveedor.DataSource = objeto.mostrarProveedor();
        }
        private void LimpiarDGV()
        {
            DataTable dt = (DataTable)dgvProveedor.DataSource;
            dt.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //INSERTAR//
            if (Editar == false)
            {
                try
                {
                    Provedor pro = new Provedor()
                    {
                        nombre = txtNombre.Text,
                        direccion = txtDireccion.Text,
                        telefono = txtTelefono.Text
                    };
                    objeto.Insertarproveedor(pro);
                    MessageBox.Show("Registro insertado correctamente");
                    LimpiarDGV();
                    
                    MostarProveedor();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Operacion fallida por: " + ex);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProveedor.SelectedRows.Count > 0)
            {
                idProveedor= Convert.ToInt32(dgvProveedor.CurrentRow.Cells["idProveedor"].Value);
                Provedor pro = new Provedor()
                {
                    id = idProveedor
                };
                objeto.Bajaproveedor(pro);
                MessageBox.Show("Operacion exitosa");
                LimpiarDGV();
                MostarProveedor();
            }
            else
                MessageBox.Show("Error en la operacion");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvProveedor.SelectedRows.Count > 0)
            {

                Provedor pro = new Provedor()
                {
                    id = idProveedor,
                    nombre = txtNombre.Text,
                    direccion = txtDireccion.Text,
                    telefono = txtTelefono.Text
                };
                objeto.Modificar_proveedor(pro);
                LimpiarDGV();
                MostarProveedor();
            }
            else
                MessageBox.Show("Selecciona la fila a editar");
        }

        private void dgvProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dgvProveedor.CurrentRow.Cells["nombre"].Value.ToString();
            txtDireccion.Text = dgvProveedor.CurrentRow.Cells["direccion"].Value.ToString();
            txtTelefono.Text = dgvProveedor.CurrentRow.Cells["telefono"].Value.ToString();
            idProveedor = Convert.ToInt32(dgvProveedor.CurrentRow.Cells["idProveedor"].Value);
        }
    }
}
