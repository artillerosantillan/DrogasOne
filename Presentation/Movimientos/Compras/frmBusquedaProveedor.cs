using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Movimientos
{
    public partial class frmBusquedaProveedor : Form
    {
        //dato pulbico que jala desde frmProducto para posicionar 
        private int idProveedor;
        modProveedor objModeloPro = new modProveedor();
        public int IDProveedor
        {
            get { return idProveedor; }
        }
        public frmBusquedaProveedor()
        {
            InitializeComponent();
        }
        void ListarProveedores()
        {
            DataTable dt = objModeloPro.modListadoProveedor();
            proveedorDataGridView.DataSource = dt;
            PersonalizarGrid();

        }

        private void frmBusquedaProveedor_Load(object sender, EventArgs e)
        {
            ListarProveedores();
        }
        private void PersonalizarGrid()
        {
            proveedorDataGridView.Columns["IDProveedor"].HeaderText = "Código";
            proveedorDataGridView.Columns["IDProveedor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            proveedorDataGridView.Columns["IDProveedor"].Width = 50;

            proveedorDataGridView.Columns["Nombre"].HeaderText = "Nombre";
            proveedorDataGridView.Columns["Nombre"].Width = 150;

            proveedorDataGridView.Columns["IDTipoDocumento"].HeaderText = "Tipo Documento";
            proveedorDataGridView.Columns["IDTipoDocumento"].Width = 100;

            proveedorDataGridView.Columns["Documento"].HeaderText = "Documento";
            proveedorDataGridView.Columns["Documento"].Width = 100;

            proveedorDataGridView.Columns["NombresContacto"].HeaderText = "Nombres Contacto";
            proveedorDataGridView.Columns["NombresContacto"].Width = 110;

            proveedorDataGridView.Columns["ApellidosContacto"].HeaderText = "Apellidos Contacto";
            proveedorDataGridView.Columns["ApellidosContacto"].Width = 110;

            proveedorDataGridView.Columns["Direccion"].HeaderText = "Dirección";
            proveedorDataGridView.Columns["Direccion"].Width = 100;

            proveedorDataGridView.Columns["Telefono"].HeaderText = "Teléfono";
            proveedorDataGridView.Columns["Telefono"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            proveedorDataGridView.Columns["Telefono"].Width = 50;

            proveedorDataGridView.Columns["Email"].HeaderText = "Email";
            proveedorDataGridView.Columns["Email"].Width = 150;
        }

        private void busquedaTextBox_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarProveedor(busquedaProveedorTextBox.Text);
        }

        public void mostrarBuscarProveedor(string buscar)
        {
            modProveedor objNegocio = new modProveedor();
            proveedorDataGridView.DataSource = objNegocio.modBuscarProveedor(buscar);

        }

        private void seleccionarBunifuFlatButton_Click(object sender, EventArgs e)
        {
            if (proveedorDataGridView.RowCount == 0)
            {
                idProveedor = 0;
            }
            else if (proveedorDataGridView.SelectedRows.Count != 0)
            {
                idProveedor = (int)(proveedorDataGridView.SelectedRows[0].Cells[0].Value);
            }
            else
            {
                idProveedor = (int)(proveedorDataGridView.Rows[0].Cells[0].Value);
            }
            this.Close();
        }

    }
}
