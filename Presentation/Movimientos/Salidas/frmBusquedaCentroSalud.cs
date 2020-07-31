using Domain.Models.Movimientos.Salidas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Movimientos.Salidas
{
    public partial class frmBusquedaCentroSalud : Form
    {
        //dato pulbico que jala desde frmProducto para posicionar 
        private int idCentroSalud;
        modCentroSalud objeto_Centro_Salud = new modCentroSalud();
        public int IDCentroSalud
        {
            get { return idCentroSalud; }
        }
        public frmBusquedaCentroSalud()
        {
            InitializeComponent();
        }

        private void frmBusquedaCentroSalud_Load(object sender, EventArgs e)
        {
            Listar_Centro_Salud();
        }

        void Listar_Centro_Salud()
        {
            DataTable dt = objeto_Centro_Salud.listar_Centros_De_Salud();
            centroSaludDataGridView.DataSource = dt;
            PersonalizarGrid();
        }
        
        private void PersonalizarGrid()
        {
            centroSaludDataGridView.Columns["IDCentroSalud"].HeaderText = "Código";
            centroSaludDataGridView.Columns["IDCentroSalud"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            centroSaludDataGridView.Columns["IDCentroSalud"].Width = 50;

            centroSaludDataGridView.Columns["IDTipoDocumento"].HeaderText = "Tipo Documento";
            centroSaludDataGridView.Columns["IDTipoDocumento"].Width = 100;

            centroSaludDataGridView.Columns["NombreCentroSalud"].HeaderText = "Centro Salud";
            centroSaludDataGridView.Columns["NombreCentroSalud"].Width = 150;

            centroSaludDataGridView.Columns["NombresAdmin"].HeaderText = "Nombres Admin";
            centroSaludDataGridView.Columns["NombresAdmin"].Width = 110;

            centroSaludDataGridView.Columns["ApellidosAdmin"].HeaderText = "Apellidos Admin";
            centroSaludDataGridView.Columns["ApellidosAdmin"].Width = 110;

            centroSaludDataGridView.Columns["Direccion"].HeaderText = "Dirección";
            centroSaludDataGridView.Columns["Direccion"].Width = 100;

            centroSaludDataGridView.Columns["Telefono"].HeaderText = "Teléfono";
            centroSaludDataGridView.Columns["Telefono"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            centroSaludDataGridView.Columns["Telefono"].Width = 50;

            centroSaludDataGridView.Columns["Correo"].HeaderText = "Email";
            centroSaludDataGridView.Columns["Correo"].Width = 150;

            centroSaludDataGridView.Columns["Aniversario"].HeaderText = "Aniversario";
            centroSaludDataGridView.Columns["Aniversario"].Width = 100;
        }

        private void busquedaCentroSaludTextBox_TextChanged(object sender, EventArgs e)
        {
            mostrar_Buscar_Centro_Salud(busquedaCentroSaludTextBox.Text);
        }

        public void mostrar_Buscar_Centro_Salud(string buscar)
        {
            modCentroSalud objeto_Centro_Salud = new modCentroSalud();
            centroSaludDataGridView.DataSource = objeto_Centro_Salud.buscar_Centro_Centro_Salud(buscar);

        }

        private void seleccionarBunifuFlatButton_Click(object sender, EventArgs e)
        {
            if (centroSaludDataGridView.RowCount == 0)
            {
                idCentroSalud = 0;
            }
            else if (centroSaludDataGridView.SelectedRows.Count != 0)
            {
                idCentroSalud = (int)(centroSaludDataGridView.SelectedRows[0].Cells[0].Value);
            }
            else
            {
                idCentroSalud = (int)(centroSaludDataGridView.Rows[0].Cells[0].Value);
            }
            this.Close();
        }

       
    }
}
