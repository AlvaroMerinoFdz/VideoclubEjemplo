using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoclubEjemplo
{
    public partial class frmPanelPrincipal : Form
    {
        public frmPanelPrincipal()
        {
            InitializeComponent();
        }

        private void btnSocios_Click(object sender, EventArgs e)
        {
            frmDatosSocios frmDatosSocios = new frmDatosSocios();
            frmDatosSocios.ShowDialog();
        }
    }
}