using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Entities;
using Domain.Models;
using Domain.Models.Movimientos;
using Presentation.Modulos.Maestros.Productos;

namespace Presentation.Modulos
{
    public partial class frmProducto : Form
    {
        entProducto entidad_Producto = new entProducto();
        modProducto objeto_Producto = new modProducto();
        modBarraProducto objModBarraProduto = new modBarraProducto();
        modDepositoProducto objModDepositoProducto =new modDepositoProducto();
        string idProducto;
        public frmProducto()
        {
            InitializeComponent();
        }
        void ListarProductos()
        {
            DataTable dt = objeto_Producto.modListadoProducto();
            productosDataGridView.DataSource = dt;
            PersonalizarGrid();

        }
        void ListarBarraProducto()
        {
            idProducto = productosDataGridView.CurrentRow.Cells["IDProducto"].Value.ToString();
            DataTable dt = objModBarraProduto.modListarBarraProducto("A0202");
            barraDataGridView.DataSource = dt;
        }
        void ListarDepositoProducto()
        {
            idProducto = productosDataGridView.CurrentRow.Cells["IDProducto"].Value.ToString();
            DataTable dt = objModDepositoProducto.modListarDepositoProducto("A0202");
            depositoProductoDataGridView.DataSource = dt;
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            ListarProductos();
            ListarBarraProducto();
            ListarDepositoProducto();
        }

        

        private void nuevoBunifuFlatButton_Click(object sender, EventArgs e)
        {
            frmMantenimientoProducto frm = new frmMantenimientoProducto();
            frm.Operacion = "Nuevo";
            //frm.ListarAlmacen();
            //frm.ListarIVA();
            frm.ShowDialog();
            ListarProductos();
        }

        private void editarBunifuFlatButton_Click(object sender, EventArgs e)
        {
            if (productosDataGridView.SelectedRows.Count > 0)
            {
                frmMantenimientoProducto frm = new frmMantenimientoProducto();
                frm.Operacion = "Editar";
                //frm.ListarTipoDocumento();
                //textbox y combobox colocar en modifier = public 
                frm.idProducto = productosDataGridView.CurrentRow.Cells["IDProducto"].Value.ToString();
                frm.iDProductoTextBox.Text = productosDataGridView.CurrentRow.Cells["IDProducto"].Value.ToString();
                frm.descripcionTextBox.Text = productosDataGridView.CurrentRow.Cells["Descripcion"].Value.ToString();
                frm.iDUnidadManejoComboBox.Text = productosDataGridView.CurrentRow.Cells["IDUnidadManejo"].Value.ToString();
                frm.iDAlmacenComboBox.Text = productosDataGridView.CurrentRow.Cells["IDAlmacen"].Value.ToString();
                frm.iDIVAComboBox.Text = productosDataGridView.CurrentRow.Cells["IDIVA"].Value.ToString();
                frm.precioTextBox.Text = productosDataGridView.CurrentRow.Cells["Precio"].Value.ToString();
                frm.notasTextBox.Text = productosDataGridView.CurrentRow.Cells["Notas"].Value.ToString();
                frm.cantidadKardexTextBox.Text = productosDataGridView.CurrentRow.Cells["CantidadKardex"].Value.ToString();
                frm.cantidadVigenteTextBox.Text = productosDataGridView.CurrentRow.Cells["CantidadVigente"].Value.ToString();

                frm.ShowDialog();
                ListarProductos();
                busquedaProductoTextBox.Text = "";
            }
            else
                MessageBox.Show("Debe seleccionar una fila");
        }

        private void eliminarBunifuFlatButton_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Esta seguro de borrar el registro actual?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                     MessageBoxDefaultButton.Button2);
            if (respuesta == DialogResult.No) return;

            modKardex objeto_kardex = new modKardex();
            if (objeto_kardex.kardex_Tiene_Movimientos_IDProducto(Convert.ToString(productosDataGridView.CurrentRow.Cells[0].Value)))
            {
                MessageBox.Show("No se puede Eliminar el proveedor, porque tiene movimientos",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            modCodigoBarra objeto_Codigo_Barra = new modCodigoBarra();
            objeto_Codigo_Barra.modEliminar_Codigo_Barra_Producto(Convert.ToString(productosDataGridView.CurrentRow.Cells[0].Value));
            modDepositoProducto objeto_Deposito_Producto = new modDepositoProducto();
            objeto_Deposito_Producto.modEliminar_Codigo_Deposito_Producto(Convert.ToString(productosDataGridView.CurrentRow.Cells[0].Value));
                                 
            if (productosDataGridView.SelectedRows.Count > 0)
            {
                idProducto = Convert.ToString(productosDataGridView.CurrentRow.Cells[0].Value);
                objeto_Producto.modEliminarProducto(idProducto);
                ListarProductos();
                MessageBox.Show("Se elimino satisfactoriamente");
                busquedaProductoTextBox.Text = "";
                //string idprod;
            }
            else
                MessageBox.Show("Seleccione una fila");
        }

        private void busquedaProductoTextBox_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarProducto(busquedaProductoTextBox.Text);
        }
        public void mostrarBuscarProducto(string buscar)
        {
            modProducto objNegocio = new modProducto();
            productosDataGridView.DataSource = objNegocio.modBuscarProducto(buscar);

        }
        private void PersonalizarGrid()
        {
            productosDataGridView.Columns["IDProducto"].HeaderText = "Codigo";
            productosDataGridView.Columns["IDProducto"].Width = 50;


            productosDataGridView.Columns["Descripcion"].HeaderText = "Descripción";
            productosDataGridView.Columns["Descripcion"].Width = 250;

            productosDataGridView.Columns["IDUnidadManejo"].HeaderText = "U.M.";
            productosDataGridView.Columns["IDUnidadManejo"].Width = 50;

            productosDataGridView.Columns["IDAlmacen"].HeaderText = "Almacen";
            productosDataGridView.Columns["IDAlmacen"].Width = 100;

            productosDataGridView.Columns["IDIVA"].HeaderText = "IVA";
            productosDataGridView.Columns["IDIVA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            productosDataGridView.Columns["IDIVA"].Width = 80;

            productosDataGridView.Columns["Precio"].HeaderText = "Precio";
            productosDataGridView.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            productosDataGridView.Columns["Precio"].Width = 80;

            productosDataGridView.Columns["Notas"].HeaderText = "Detalle";
            productosDataGridView.Columns["Notas"].Width = 110;

            productosDataGridView.Columns["CantidadKardex"].HeaderText = "Cant. Kardex";
            productosDataGridView.Columns["CantidadKardex"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            productosDataGridView.Columns["CantidadKardex"].Width = 80;

            productosDataGridView.Columns["CantidadVigente"].HeaderText = "Cant. Vigente";
            productosDataGridView.Columns["CantidadVigente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            productosDataGridView.Columns["CantidadVigente"].Width = 80;

        }

        
    }
}
