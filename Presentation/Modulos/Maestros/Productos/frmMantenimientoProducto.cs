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

namespace Presentation.Modulos.Maestros.Productos
{
    public partial class frmMantenimientoProducto : Form
    {
        entProducto objEntidadProd = new entProducto();
        modProducto objModeloProd = new modProducto();
        public string Operacion = "";
        public string idProducto;
        public frmMantenimientoProducto()
        {
            InitializeComponent();
        }

        private void IzquierdoPanel_Paint(object sender, PaintEventArgs e)
        {
            ListarUnidadManejo();
            ListarAlmacen();
            ListarIVA();
        }

        public void ListarUnidadManejo()
        {
            modUnidadManejo objProd = new modUnidadManejo();
            iDUnidadManejoComboBox.DataSource = objProd.modListadoUnidadManejo();
            iDUnidadManejoComboBox.DisplayMember = "IDUnidadManejo";
            iDUnidadManejoComboBox.ValueMember = "IDUnidadManejo";
        }

        public void ListarAlmacen()
        {
            modAlmacen objProd = new modAlmacen();
            iDAlmacenComboBox.DataSource = objProd.modListadoAlmacen();
            iDAlmacenComboBox.DisplayMember = "Descripcion";
            iDAlmacenComboBox.ValueMember = "IDAlmacen";
        }
        public void ListarIVA()
        {
            modIVA objProd = new modIVA();
            iDIVAComboBox.DataSource = objProd.modListadoIVA();
            iDIVAComboBox.DisplayMember = "Descripcion";
            iDIVAComboBox.ValueMember = "IDIVA";
        }
       

        private void guardarBunifuFlatButton_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            {
                if (Operacion == "Nuevo")
                {
                    objEntidadProd.IDProducto = iDProductoTextBox.Text;
                    objEntidadProd.Descripcion = descripcionTextBox.Text;
                    objEntidadProd.IDUnidadManejo = iDUnidadManejoComboBox.Text;
                    objEntidadProd.IDAlmacen = Convert.ToInt32(iDAlmacenComboBox.SelectedValue);
                    objEntidadProd.IDIVA = Convert.ToInt32(iDIVAComboBox.SelectedValue);
                    objEntidadProd.Precio = Convert.ToInt32(precioTextBox.Text);
                    objEntidadProd.Notas = notasTextBox.Text;
                    objEntidadProd.CantidadKardex = Convert.ToInt32(cantidadKardexTextBox.Text);
                    objEntidadProd.CantidadVigente = Convert.ToInt32(cantidadVigenteTextBox.Text);

                    objModeloProd.modInsertarProducto(objEntidadProd);

                    MessageBox.Show("Se inserto correctamente");
                    this.Close();
                }
                else if (Operacion == "Editar")
                {
                    objEntidadProd.IDProducto = idProducto;
                    objEntidadProd.Descripcion = descripcionTextBox.Text;
                    objEntidadProd.IDUnidadManejo = iDUnidadManejoComboBox.Text;
                    objEntidadProd.IDAlmacen = Convert.ToInt32(iDAlmacenComboBox.SelectedValue);
                    objEntidadProd.IDIVA = Convert.ToInt32(iDIVAComboBox.SelectedValue);
                    objEntidadProd.Precio = Convert.ToDecimal(precioTextBox.Text);
                    objEntidadProd.Notas = notasTextBox.Text;
                    objEntidadProd.CantidadKardex = Convert.ToInt32(cantidadKardexTextBox.Text);
                    objEntidadProd.CantidadVigente = Convert.ToInt32(cantidadVigenteTextBox.Text);

                    objModeloProd.modEditarProducto(objEntidadProd);
                    Operacion = "Insertar";
                    MessageBox.Show("Se edito correctamente");
                    this.Close();
                }
            }
        }
        private bool ValidarCampos()
        {
            //-------valida si el producto es nuevo -------
            if (Operacion == "nuevo")
            {
                if (iDProductoTextBox.Text == "")
                {
                    errorProvider1.SetError(iDProductoTextBox, "Debe Ingresar un codigo de producto");
                    iDProductoTextBox.Focus();
                    return false;
                }
                errorProvider1.Clear();
                modProducto existeProducto = new modProducto();
                if (existeProducto.modExisteProducto(iDProductoTextBox.Text))
                {
                    errorProvider1.SetError(iDProductoTextBox, "El Codigo Existe y esta asignado a otro producto");
                    iDProductoTextBox.Focus();
                    return false;
                }
                errorProvider1.Clear();
            }

            //-------Si no es nuevo Prosigue con las de mas validaciones -------

            if (descripcionTextBox.Text == "")
            {
                errorProvider1.SetError(descripcionTextBox, "Debe Ingresar una descripcion de producto");
                descripcionTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (iDUnidadManejoComboBox.SelectedIndex == -1)  // que no ha seleccion un nombre de combobox
            {
                errorProvider1.SetError(iDUnidadManejoComboBox, "Debe seleccionar una Unidad de Manejo");
                iDUnidadManejoComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (iDAlmacenComboBox.SelectedIndex == -1)  // que no ha seleccion un nombre de combobox
            {
                errorProvider1.SetError(iDAlmacenComboBox, "Debe seleccionar un almacen");
                iDAlmacenComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (precioTextBox.Text == "")
            {
                errorProvider1.SetError(precioTextBox, "Debe Ingresar un precio para el producto");
                precioTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            decimal precio;
            if (!decimal.TryParse(precioTextBox.Text, out precio))  // que no ha seleccion un nombre de combobox
            {
                errorProvider1.SetError(precioTextBox, "Debe ingresar un valor numerico");
                precioTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (precio <= 0)  // que no ha seleccion un nombre de combobox
            {
                errorProvider1.SetError(precioTextBox, "Debe ingresar una precio mayor a cero");
                precioTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (iDIVAComboBox.SelectedIndex == -1)  // que no ha seleccion un nombre de combobox
            {
                errorProvider1.SetError(iDIVAComboBox, "Debe seleccionar IVA");
                iDIVAComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            return true;
        }

       
    }
}
