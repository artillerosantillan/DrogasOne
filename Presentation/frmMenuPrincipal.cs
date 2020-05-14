using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class frmMenuPrincipal : Form
    {
        //Campos
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;


        //Constructor
        public frmMenuPrincipal()
        {
            InitializeComponent();
            random = new Random();
            cerrarFormHijoButton.Visible = false;
            //quitamos la barra superior de ventana windows
            this.Text = string.Empty;
            this.ControlBox = false;
            //indicamos los limites del maximizado (igual al area de trabajo del escritorio)
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        //Metodos
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemaColor.ColorList.Count);
            while (tempIndex == index)
            {   //Si el color ya ha cido seleccionado, selecionamos nuevamente para elegir uno diferente
                index = random.Next(ThemaColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemaColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        //resaltamos los botones que se han hecho clic

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    //campbia de color los paneles superiores
                    tituloBarraPanel.BackColor = color;
                    logoPanel.BackColor = ThemaColor.ChangeColorBrightness(color, -0.3);
                    ThemaColor.ColorPrincipal = color;
                    ThemaColor.ColorSecundario = ThemaColor.ChangeColorBrightness(color, -0.3);
                    cerrarFormHijoButton.Visible = true;
                }
            }
        }
        //desactivamos el resaldo del boton valores prdeterinados
        private void DisableButton()
        {
            foreach (Control previousBtn in  menuPanel.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(132, 198, 134);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelEscritorioPanel.Controls.Add(childForm);
            this.panelEscritorioPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            tituloLabel.Text = childForm.Text;
        }


        private void productoButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Borrarme(),sender);
        }

        private void salidasButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void centroSaludButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void proveedoresButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void comprasButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void kardexButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void usuariosButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void reportesButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void cerrarFormHijoButton_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            tituloLabel.Text = "INICIO";
            tituloBarraPanel.BackColor = Color.FromArgb(229, 213, 139);
            logoPanel.BackColor = Color.FromArgb(105, 183, 107);
            currentButton = null;
            cerrarFormHijoButton.Visible = false;   

        }

        private void tituloBarraPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cerrarButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de cerrar la aplicasión?", "Alerta",
           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
               Application.Exit();
        }

        private void maximizarButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void minimizarButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cerrarSesionButton_Click(object sender, EventArgs e)
        {
            //solo cerramos el formulario menu principal y mostraremos form login
            if (MessageBox.Show("Esta seguro de cerrar sesión?", "Alerta",
           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();

        }
    }
}
