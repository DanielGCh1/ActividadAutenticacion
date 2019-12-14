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
    public partial class DashboardForm : Form
    {
        private Usuario usuario;
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            if( loginForm.ShowDialog() == DialogResult.OK)
            {
                usuario = loginForm.UsuarioAutenticar;
                toolStripStatusLabelNombreUsuario.Text ="Usuario Actual: " + usuario.NombreUsuario;
            }
        }
    }
}
