using Common.Cache;
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
    public partial class frmBienvenida : Form
    {
        public frmBienvenida()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            progressBar1.Value += 1;
            //progressBar1.Value.Text = progressBar1.Value.Value.ToString();
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }
        }

        private void frmBienvenida_Load(object sender, EventArgs e)
        {
            userlLabel.Text = CacheLoginUsuario.Nombres + ", " + CacheLoginUsuario.Apellidos;
            this.Opacity = 0.0;
            //Inicializamos estas propiedades de la barra de progreso, mediante codigo.(Opcional)
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            //Iniciamos el temporizador 1.
            timer1.Start();
        }
    }
    }
