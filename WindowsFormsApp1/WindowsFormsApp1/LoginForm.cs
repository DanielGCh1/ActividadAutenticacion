using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Autenticacion : Form
    {
        public Autenticacion()
        {
            InitializeComponent();
        }

        private void ButtonAceptar_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxUsuario.TextLength == 0)
            {
                errorProviderLogin.SetError(textBoxUsuario, "Debe ingresar el nombre del usuario");
            }
            if (textBoxContraseña.TextLength == 0)
            {
                errorProviderLoginContraseña.SetError(textBoxContraseña, "Debe ingresar la contraseña");
            }
        }

        private void ButtonCancelar_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void LinkLabelRecuperacionContraseña_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void TextBoxUsuario_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void TextBoxContraseña_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void ButtonAceptar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (textBoxUsuario.TextLength == 0)
                {
                    errorProviderLogin.SetError(textBoxUsuario, "Debe ingresar el nombre del usuario");
                }
                if (textBoxContraseña.TextLength == 0)
                {
                    errorProviderLoginContraseña.SetError(textBoxContraseña, "Debe ingresar la contraseña");
                }
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (textBoxUsuario.TextLength == 0)
            {
                errorProviderLogin.SetError(textBoxUsuario, "Debe ingresar el nombre del usuario");
            }
            if (textBoxContraseña.TextLength == 0)
            {
                errorProviderLoginContraseña.SetError(textBoxContraseña, "Debe ingresar la contraseña");
            }
        }

        private void textBoxContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
