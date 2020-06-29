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
    public partial class frmMantenimientoProveedor : Form
    {
        entProveedor objEntidadPro = new entProveedor();
        modProveedor objModEntidadPro = new modProveedor();
        public string Operacion = "";
        public string idProveedor;
        public frmMantenimientoProveedor()
        {
            InitializeComponent();
        }
    
        private void frmMantenimientoProducto_Load(object sender, EventArgs e)
        {
        }
        public void ListarTipoDocumento()
        {
                modTipoDocumento objProd = new modTipoDocumento();
                iDTipoDocumentoComboBox.DataSource = objProd.modListadoTipoDocumento();
                iDTipoDocumentoComboBox.DisplayMember = "Descripcion";
                iDTipoDocumentoComboBox.ValueMember = "IDTipoDocumento";
        }
        
        private void guardarButton_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            {
                if (Operacion == "Nuevo")
                {
                    modProveedor existeProveedor = new modProveedor();
                    if (existeProveedor.modExisteProveedor(documentoTextBox.Text))
                    {
                        errorProvider1.SetError(documentoTextBox, "El Codigo Existe y esta asignado a otro producto");
                        documentoTextBox.Focus();
                        return;
                    }
                    errorProvider1.Clear();
                    objEntidadPro.Nombre = nombreTextBox.Text;
                    objEntidadPro.IDTipoDocumento = Convert.ToInt32(iDTipoDocumentoComboBox.SelectedValue);
                    objEntidadPro.Documento = documentoTextBox.Text;
                    objEntidadPro.NombresContacto = nombresContactoTextBox.Text;
                    objEntidadPro.ApellidosContacto = apellidosContactoTextBox.Text;
                    objEntidadPro.Direccion = direccionTextBox.Text;
                    objEntidadPro.Telefono = telefonoTextBox.Text;
                    objEntidadPro.Email = emailTextBox.Text;

                    objModEntidadPro.modInsertarProveedor(objEntidadPro);

                    MessageBox.Show("Se inserto correctamente");
                    this.Close();
                }
                else if (Operacion == "Editar")
                {
                    objEntidadPro.IDProveedor = Convert.ToInt32(idProveedor);
                    objEntidadPro.Nombre = nombreTextBox.Text;
                    objEntidadPro.IDTipoDocumento = Convert.ToInt32(iDTipoDocumentoComboBox.SelectedValue);
                    objEntidadPro.Documento = documentoTextBox.Text;
                    objEntidadPro.NombresContacto = nombresContactoTextBox.Text;
                    objEntidadPro.ApellidosContacto = apellidosContactoTextBox.Text;
                    objEntidadPro.Direccion = direccionTextBox.Text;
                    objEntidadPro.Telefono = telefonoTextBox.Text;
                    objEntidadPro.Email = emailTextBox.Text;

                    objModEntidadPro.modEditarProveedor(objEntidadPro);
                    Operacion = "Insertar";
                    MessageBox.Show("Se edito correctamente");
                    this.Close();
                }
            }

        }
        private bool ValidarCampos()
        {
            if (iDTipoDocumentoComboBox.SelectedIndex == -1)  // que no ha seleccion un nombre de combobox
            {
                errorProvider1.SetError(iDTipoDocumentoComboBox, "Debe seleccionar un tipo de documento");
                iDTipoDocumentoComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();
            if (documentoTextBox.Text == "")
            {
                errorProvider1.SetError(documentoTextBox, "Debe Ingresar un numero de documento");
                documentoTextBox.Focus();
                return false;

            }
            errorProvider1.Clear();

            if (nombresContactoTextBox.Text == "")
            {
                errorProvider1.SetError(nombresContactoTextBox, "Debe Ingresar un nombre de contacto");
                nombresContactoTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (apellidosContactoTextBox.Text == "")
            {
                errorProvider1.SetError(apellidosContactoTextBox, "Debe Ingresar un apellido de contacto");
                apellidosContactoTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (nombreTextBox.Text == "")
            {
                errorProvider1.SetError(nombreTextBox, "Debe Ingresar un nombre de proveedor");
                nombreTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (emailTextBox.Text != "")
            {
                RegexUtilities regexUtilities = new RegexUtilities();       // verifica si el correo introducido es valido
                if (!regexUtilities.IsValidEmail(emailTextBox.Text))
                {
                    errorProvider1.SetError(emailTextBox, "Si ingresa un correo, este debe ser válido");
                    emailTextBox.Focus();
                    return false;
                }
                errorProvider1.Clear();
            }

            return true;
        }
    }
}
