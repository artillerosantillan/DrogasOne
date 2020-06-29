using Presentation.Modulos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class frmMenuContenedor : Form
    {
        public frmMenuContenedor()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProducto miForm = new frmProducto();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void frmMenuContenedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedor miForm = new frmProveedor();
            miForm.MdiParent = this;
            miForm.Show();
        }
    }
}
