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
    
    public partial class CuentasPorCobrarForm : Form
    {
        public List<Cuentas> cuentasMostrables;

        public CuentasPorCobrarForm()
        {
            InitializeComponent();
        }

        public CuentasPorCobrarForm(List<Cuentas> cuentas)
        {
            InitializeComponent();
            cuentasMostrables = cuentas;
        }

        private void CuentasPorCobrarForm_Load(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            for (int i = 0; i < cuentasMostrables.Count; i++)
            {
                if (i+1 < cuentasMostrables.Count)
                {
                    dataGridViewListCuestas.Rows.Add();
                }

                dataGridViewListCuestas.Rows[i].Cells[0].Value = cuentasMostrables[i].Cedula;
                dataGridViewListCuestas.Rows[i].Cells[1].Value = cuentasMostrables[i].Nombre;
                dataGridViewListCuestas.Rows[i].Cells[2].Value = cuentasMostrables[i].Monto;
                dataGridViewListCuestas.Rows[i].Cells[3].Value = cuentasMostrables[i].Telefono;
                dataGridViewListCuestas.Rows[i].Cells[4].Value = cuentasMostrables[i].Direcion;
                
            }
        }

        private void ButtonImprimir_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
