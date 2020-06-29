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

namespace Presentation.Modulos
{
    public partial class frmProveedor : Form
    {
        entProveedor objEntidadPro = new entProveedor();
        modProveedor objModeloPro = new modProveedor();
        //string Operacion = "Insertar";
        int idProveedor;
        public frmProveedor()
        {
            InitializeComponent();
        }
        private void frmProveedor_Load(object sender, EventArgs e)
        {
            ListarProveedores();
        }
        void ListarProveedores()
        {
            DataTable dt = objModeloPro.modListadoProveedor();
            proveedorDataGridView.DataSource = dt;
            PersonalizarGrid();

        }
       
        public void mostrarBuscarProveedor(string buscar)
        {
            modProveedor objNegocio = new modProveedor();
            proveedorDataGridView.DataSource = objNegocio.modBuscarProveedor(buscar);
            
        }

        //--------------------------- Boton Nuevo ---------------------------------
        private void nuevoButton_Click(object sender, EventArgs e)
        {
            frmMantenimientoProveedor frm = new frmMantenimientoProveedor();
            frm.Operacion = "Nuevo";
            frm.ListarTipoDocumento();
            frm.ShowDialog();
            frm.nombreTextBox.Focus();
            ListarProveedores();
        }
        //--------------------------- Boton Editar ---------------------------------
        private void editarButton_Click(object sender, EventArgs e)
        {
            if (proveedorDataGridView.SelectedRows.Count > 0)
            {
                frmMantenimientoProveedor frm = new frmMantenimientoProveedor();
                frm.Operacion = "Editar";
                frm.ListarTipoDocumento();
                //textbox y combobox colocar en modifier = public 
                frm.idProveedor = proveedorDataGridView.CurrentRow.Cells["IDProveedor"].Value.ToString();
                frm.nombreTextBox.Text = proveedorDataGridView.CurrentRow.Cells["Nombre"].Value.ToString();
                frm.iDTipoDocumentoComboBox.Text = proveedorDataGridView.CurrentRow.Cells["IDTipoDocumento"].Value.ToString();
                frm.documentoTextBox.Text = proveedorDataGridView.CurrentRow.Cells["Documento"].Value.ToString();
                frm.nombresContactoTextBox.Text = proveedorDataGridView.CurrentRow.Cells["NombresContacto"].Value.ToString();
                frm.apellidosContactoTextBox.Text = proveedorDataGridView.CurrentRow.Cells["ApellidosContacto"].Value.ToString();
                frm.direccionTextBox.Text = proveedorDataGridView.CurrentRow.Cells["Direccion"].Value.ToString();
                frm.telefonoTextBox.Text = proveedorDataGridView.CurrentRow.Cells["Telefono"].Value.ToString();
                frm.emailTextBox.Text = proveedorDataGridView.CurrentRow.Cells["Email"].Value.ToString();

                frm.ShowDialog();
                ListarProveedores();
                busquedaProveedorTextBox.Text = "";
            }
            else
                MessageBox.Show("Debe seleccionar una fila");
        }
        
        //---------------------------- Boton Eliminar ----------------------------------
        private void eliminarButton_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Esta seguro de borrar el registro actual?",
                     "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                      MessageBoxDefaultButton.Button2);
            if (respuesta == DialogResult.No) return;

            modProveedor objModEntidadPro = new modProveedor();
            if (proveedorDataGridView.SelectedRows.Count > 0)
            {
                idProveedor = Convert.ToInt32(proveedorDataGridView.CurrentRow.Cells[0].Value);
                objModEntidadPro.modEliminarProveedor(idProveedor);
                ListarProveedores();
                MessageBox.Show("Se elimino satisfactoriamente");
                busquedaProveedorTextBox.Text = "";
                //string idprod;
            }
            else
                MessageBox.Show("Seleccione una fila");
        }
        //----------------------- Busqueda Proveedor Editar -------------------------------------
        private void busquedaProveedorTextBox_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarProveedor(busquedaProveedorTextBox.Text);
        }
        //----------------------- Personalizacion del DataGridView -------------------------------
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
    }
}
