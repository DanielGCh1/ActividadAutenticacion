using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.UNA.Dashboard.Formularios
{
    public partial class LoginForm : Form
    {



        public Usuario UsuarioAutenticar;

        public LoginForm()
        {
            InitializeComponent();
            UsuarioAutenticar = new Usuario();
            UsuarioAutenticar.NombreUsuario = "Daniel";
            UsuarioAutenticar.ContraseñaUsuario = "1234";
        }

        private void LinkLabelRecuperacionContraseña_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            
            
        }


        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            if (textBoxUsuario.TextLength == 0 || !UsuarioAutenticar.ComprobarUsuario(textBoxUsuario.Text))
            {
                errorProviderLogin.SetError(textBoxUsuario, "Ingrese o corrija el nombre del usuario");
                if (textBoxContraseña.TextLength == 0 || !UsuarioAutenticar.ComprobarContraseña(textBoxContraseña.Text))
                {
                    errorProviderLoginContraseña.SetError(textBoxContraseña, "Ingrese o corrija la contraseña del usuario");
                }
            }
            else
            {
                if (textBoxContraseña.TextLength == 0 || !UsuarioAutenticar.ComprobarContraseña(textBoxContraseña.Text))
                {
                    errorProviderLoginContraseña.SetError(textBoxContraseña, "Ingrese o corrija la contraseña del usuario");
                }
                else
                {
                    DialogResult = DialogResult.OK;
                    this.Hide();
                }
            }
        }

        private void TextBoxUsuario_Leave(object sender, EventArgs e)
        {

        }

        private void TextBoxContraseña_Leave(object sender, EventArgs e)
        {

        }
    }
}
