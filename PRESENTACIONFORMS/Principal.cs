using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESENTACIONFORMS
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void ptbClientes_Click(object sender, EventArgs e)
        {
            Form1 abrir = new Form1();
            abrir.Show();
        }

        private void ptbProveedores_Click(object sender, EventArgs e)
        {
            Proveedor abrir = new Proveedor();
            abrir.Show();
        }

        private void ptbProductos_Click(object sender, EventArgs e)
        {
            Productos abrir = new Productos();
            abrir. Show();
        }

        private void ptbCompras_Click(object sender, EventArgs e)
        {
            Compras abrir = new Compras();
            abrir.Show();
        }

  

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
