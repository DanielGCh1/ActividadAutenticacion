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

        public List<Cuentas> cuentas;
        
        public DashboardForm()
        {
            InitializeComponent();
            cuentas = new List<Cuentas>
            {
                new Cuentas(116620380, "Daniel", 16.5, 61282136, "35 mts oeste"),
                new Cuentas(116625680, "Raquel", 36.5, 84245136, "74 mts este"),
                new Cuentas(116646680, "Andy", 6.5, 67845136, "54 mts norte")
            };
            //cuentas.Remove(cuentas[0]);
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

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CuentasPorCobrarForm cuentasPorCobrarForm = new CuentasPorCobrarForm(cuentas);
            cuentasPorCobrarForm.Visible = true;
        }
    }
}
