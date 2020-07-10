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
    public partial class frmBusquedaProducto : Form
    {
        modProducto objModProducto = new modProducto();
        private string idProducto;

        public string IDProducto
        {
            get { return idProducto; }
        }

        public frmBusquedaProducto()
        {
            InitializeComponent();
        }

        private void frmBusquedaProducto_Load(object sender, EventArgs e)
        {
            ListarProductos();
        }
        void ListarProductos()
        {
            DataTable dt = objModProducto.modListadoProducto();
            busquedaProductoDataGridView.DataSource = dt;
            PersonalizarGrid();

        }

        private void seleccionarBunifuFlatButton_Click(object sender, EventArgs e)
        {
            if (busquedaProductoDataGridView.RowCount == 0)
            {
                idProducto = null;
            }
            else if (busquedaProductoDataGridView.SelectedRows.Count != 0)
            {
                idProducto = Convert.ToString(busquedaProductoDataGridView.SelectedRows[0].Cells[0].Value);
            }
            else
            {
                idProducto = Convert.ToString(busquedaProductoDataGridView.Rows[0].Cells[0].Value);
            }
            this.Close();
        }
        private void PersonalizarGrid()
        {
            busquedaProductoDataGridView.Columns["IDProducto"].HeaderText = "Codigo";
            busquedaProductoDataGridView.Columns["IDProducto"].Width = 50;


            busquedaProductoDataGridView.Columns["Descripcion"].HeaderText = "Descripción";
            busquedaProductoDataGridView.Columns["Descripcion"].Width = 250;

            busquedaProductoDataGridView.Columns["IDUnidadManejo"].HeaderText = "U.M.";
            busquedaProductoDataGridView.Columns["IDUnidadManejo"].Width = 50;

            busquedaProductoDataGridView.Columns["IDAlmacen"].HeaderText = "Almacen";
            busquedaProductoDataGridView.Columns["IDAlmacen"].Width = 100;

            busquedaProductoDataGridView.Columns["IDIVA"].HeaderText = "IVA";
            busquedaProductoDataGridView.Columns["IDIVA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            busquedaProductoDataGridView.Columns["IDIVA"].Width = 80;

            busquedaProductoDataGridView.Columns["Precio"].HeaderText = "Precio";
            busquedaProductoDataGridView.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            busquedaProductoDataGridView.Columns["Precio"].Width = 80;

            busquedaProductoDataGridView.Columns["Notas"].HeaderText = "Detalle";
            busquedaProductoDataGridView.Columns["Notas"].Width = 110;

            busquedaProductoDataGridView.Columns["CantidadKardex"].HeaderText = "Cant. Kardex";
            busquedaProductoDataGridView.Columns["CantidadKardex"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            busquedaProductoDataGridView.Columns["CantidadKardex"].Width = 80;

            busquedaProductoDataGridView.Columns["CantidadVigente"].HeaderText = "Cant. Vigente";
            busquedaProductoDataGridView.Columns["CantidadVigente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            busquedaProductoDataGridView.Columns["CantidadVigente"].Width = 80;
        }

        private void busquedaProductoTextBox_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarProducto(busquedaProductoTextBox.Text);
        }
        public void mostrarBuscarProducto(string buscar)
        {
            modProducto objNegocio = new modProducto();
            busquedaProductoDataGridView.DataSource = objNegocio.modBuscarProducto(buscar);

        }
    }
}
