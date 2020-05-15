using Common.Cache;
using Domain;
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
    public partial class frmPerfilUsuario : Form
    {
        public frmPerfilUsuario()
        {
            InitializeComponent();
        }

        private void frmPerfilUsuario_Load(object sender, EventArgs e)
        {
            loadUserData();
            initializePassEditControls();
        }


        private void loadUserData()
        {
            //View
            userLabel.Text = CacheLoginUsuario.LoginName;
            nameLabel.Text = CacheLoginUsuario.FirstName;
            lastNameLabel.Text = CacheLoginUsuario.LastName;
            emailLabel.Text = CacheLoginUsuario.Email;
            positionLabel.Text = CacheLoginUsuario.Position;
            //Edit Panel
            userNameTextBox.Text = CacheLoginUsuario.LoginName;
            firtNameTextBox.Text = CacheLoginUsuario.FirstName;
            lastNameTextBox.Text = CacheLoginUsuario.LastName;
            emailTextBox.Text = CacheLoginUsuario.Email;
            passwordTextBox.Text = CacheLoginUsuario.Password;
            confirmPassTextBox.Text = CacheLoginUsuario.Password;
            currentPasswordTextBox.Text = "";
        }
        //inicializar eidcion del passwor en liklabel
        private void initializePassEditControls()
        {
            editPassLinkLabel.Text = "Edit";
            passwordTextBox.UseSystemPasswordChar = true;
            passwordTextBox.Enabled = false;
            confirmPassTextBox.UseSystemPasswordChar = true;
            confirmPassTextBox.Enabled = false;
        }

        //reiniciar y actualizar los datos
        private void reset()
        {
            loadUserData();
            initializePassEditControls();
        }

       

        private void editProfileLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            editarPanel.Visible = true;
            loadUserData();
        }

        private void editPassLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (editPassLinkLabel.Text == "Edit")
            {
                editPassLinkLabel.Text = "Cancel";
                passwordTextBox.Enabled = true;
                passwordTextBox.Text = "";
                confirmPassTextBox.Enabled = true;
                confirmPassTextBox.Text = "";
            }
            else if (editPassLinkLabel.Text == "Cancel")
            {
                initializePassEditControls();
                passwordTextBox.Text = CacheLoginUsuario.Password;
                confirmPassTextBox.Text = CacheLoginUsuario.Password;
            }
        }
       

        private void cancelButton_Click(object sender, EventArgs e)
        {
            editarPanel.Visible=false;
            reset();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
                if (passwordTextBox.Text.Length >= 5)
                {
                    if (passwordTextBox.Text == confirmPassTextBox.Text)
                    {
                        if (currentPasswordTextBox.Text == CacheLoginUsuario.Password)
                        {
                            var userModel = new UserModel(
                                idUser: CacheLoginUsuario.IdUser,
                                loginName: userNameTextBox.Text,
                                password: passwordTextBox.Text,
                                firstName: firtNameTextBox.Text,
                                lastName: lastNameTextBox.Text,
                                position: null,
                                email: emailTextBox.Text);
                            var result = userModel.editUserProfile();
                            MessageBox.Show(result);
                            reset();
                            editarPanel.Visible = false;
                        }
                        else
                            MessageBox.Show("Contraseña actual incorrecta, realice nuevamente");
                    }
                    else
                        MessageBox.Show("The password do not match, try again");
                }
                else
                    MessageBox.Show("The password must have a minimum of 5 characters");
        }
    }
}
