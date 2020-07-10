using DataAccess.Clases;
using DataAccess.Entities;
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
    public partial class frmCompras : Form
    {
        modProveedor objModeloPro = new modProveedor();
        public frmCompras()
        {
            InitializeComponent();
        }
        private void frmCompras_Load(object sender, EventArgs e)
        {
            ListarProveedor();
            ListarDeposito();

        }
        //-----------------------Listar Deposito en ComboBox -----------------------
        public void ListarDeposito()
        {
            modDeposito objProd = new modDeposito();
            depositoComboBox.DataSource = objProd.modListaDeposito();
            depositoComboBox.DisplayMember = "Descripcion";
            depositoComboBox.ValueMember = "IDDeposito";
        }
        //-----------------------Listar Proveedor en ComboBox ----------------------
        public void ListarProveedor()
        {
            modProveedor objProd = new modProveedor();
            proveedorComboBox.DataSource = objProd.modListadoProveedor();
            proveedorComboBox.DisplayMember = "Descripcion";
            proveedorComboBox.ValueMember = "IDProveedor";
        }
        //-----------------------Busqueda Proveedor -----------------------------------
        private void busquedaProveedorButton_Click(object sender, EventArgs e)
        {
            frmBusquedaProveedor miBusqueda = new frmBusquedaProveedor();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDProveedor == 0) return;
            proveedorComboBox.SelectedValue = miBusqueda.IDProveedor;
        }
        //-----------------------Busqueda Producto ----------------------------------
        private void busquedaProductoButton_Click(object sender, EventArgs e)
        {
            frmBusquedaProducto miBusqueda = new frmBusquedaProducto();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDProducto == null) return;
            productoTextBox.Text = miBusqueda.IDProducto;
            productoTextBox_Validating(sender, new CancelEventArgs());
        }
        
        private void productoTextBox_Validating(object sender, CancelEventArgs e)
        {
            
            if (productoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(productoTextBox, "Debe ingresar un Código de producto");
                return;
            }
            errorProvider1.Clear();

            entProducto meProducto = new entProducto();// se crea un entidad producto
            modProducto miProducto = new modProducto();//creamos el modelo producto
            meProducto = miProducto.getProducto(productoTextBox.Text); //llamamos a la clase getProdicto con el codigo de producto
            if (meProducto == null)
            {
                errorProvider1.SetError(productoTextBox, "El Producto no Existe");
                productoLabel.Text = string.Empty;
                //ultimoProducto = null;
            }
            else
            {
                
                productoLabel.Text = meProducto.Descripcion + " " + meProducto.IDUnidadManejo+".";
                //si el producto existe producto es igual mi producto
               // ultimoProducto = miProducto;


            }
        }
    }
}
