using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain; 

namespace Presentation
{
    public partial class frmRecuperarPassword : Form
    {
        public frmRecuperarPassword()
        {
            InitializeComponent();
        }

        private void enviarButton_Click(object sender, EventArgs e)
        {
            var user = new UserModel();
            var result = user.recuperarPassword(recuperarUsuarioTextBox.Text);
            resultadoLabel.Text = result;

        }
    }
}
