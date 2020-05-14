using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;  // 1 librería  Mover / Arrastrar el Formulario
using Domain; // ferenciamos a la capa de dominio

namespace Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 2 Función de Mover / Arrastrar el Formulario--
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        //Función de Mover / Arrastrar el Formulario-
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void userTextBox_Enter(object sender, EventArgs e)
        {
            if (userTextBox.Text == "Usuario")
            {
                userTextBox.Text = "";
                userTextBox.ForeColor = Color.WhiteSmoke;
            }
        }

        private void userTextBox_Leave(object sender, EventArgs e)
        {
            if (userTextBox.Text == "")
            {
                userTextBox.Text = "Usuario";
                userTextBox.ForeColor = Color.WhiteSmoke;
            }

        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Contraseña")
            {
                passwordTextBox.Text = "";
                passwordTextBox.ForeColor = Color.WhiteSmoke;
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "")
            {
                passwordTextBox.Text = "Contraseña";
                passwordTextBox.ForeColor = Color.WhiteSmoke;
                passwordTextBox.UseSystemPasswordChar = false;

            }
        }

        private void cerrarPictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizarPictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // 3 evento MouseMove Función de Mover / Arrastrar el Formulario--
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (userTextBox.Text != "Usuario" && userTextBox.TextLength > 2)
            {
                if (passwordTextBox.Text != "Contraseña")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(userTextBox.Text, passwordTextBox.Text);
                    if (validLogin == true)
                    {
                        frmMenuPrincipal miMenu = new frmMenuPrincipal();
                        miMenu.Show();
                        //sobrecargamos el evento formcloser del formulario menu principal
                        miMenu.FormClosed += Logout;
                        this.Hide();
                    }
                    else
                    {
                        msgError("El nombre de usuario o contraseña incorrectos.\n Por favor, intente nuevamente");
                        passwordTextBox.Text = "Contraseña";
                        passwordTextBox.UseSystemPasswordChar = false;
                        userTextBox.Focus();

                    }
                }
                else msgError("Por favor, instrodusca su contraseña.");
            }
            else msgError("Por favor, instrodusca su nombre de usuario.");

        }
        private void msgError(string msg)
        {
            errorMensajeLabel.Text = "    " + msg;
            errorMensajeLabel.Visible = true;
        }
        //cerrar secion
        private void Logout(object sender, FormClosedEventArgs e)
        {
            passwordTextBox.Text = "Contraseña";
            passwordTextBox.UseSystemPasswordChar = false;
            userTextBox.Text = "Usuario";
            errorMensajeLabel.Visible = false;
            this.Show();
            //userTextBox.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recoverPassword = new frmRecuperarPassword();
            recoverPassword.ShowDialog();
        }
    }
}
