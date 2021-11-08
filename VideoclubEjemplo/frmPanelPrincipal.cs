using System;
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

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void tsbtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsbtnSocios_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "frmDatosSocios")
                {
                    DialogResult rs = MessageBox.Show("¿Desea cerrar el formulario actual?", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (rs == DialogResult.OK)
                    {
                        this.MdiChildren[0].Close();
                        frmDatosSocios f = new frmDatosSocios();
                        f.MdiParent = this;
                        f.Dock = DockStyle.Fill;
                        f.Show();
                    }
                }
            }
            else
            {
                frmDatosSocios f = new frmDatosSocios();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }

        private void tsbtnPeliculas_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "frmPeliculas")
                {
                    DialogResult rs = MessageBox.Show("¿Desea cerrar el formulario actual?", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (rs == DialogResult.OK)
                    {
                        this.MdiChildren[0].Close();
                        frmPeliculas f = new frmPeliculas();
                        f.MdiParent = this;
                        f.Dock = DockStyle.Fill;
                        f.Show();
                    }
                }
            }
            else
            {
                frmPeliculas f = new frmPeliculas();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "frmAlquileres")
                {
                    DialogResult rs = MessageBox.Show("¿Desea cerrar el formulario actual?", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (rs == DialogResult.OK)
                    {
                        this.MdiChildren[0].Close();
                        frmAlquileres f = new frmAlquileres();
                        f.MdiParent = this;
                        f.Dock = DockStyle.Fill;
                        f.Show();
                    }
                }
            }
            else
            {
                frmAlquileres f = new frmAlquileres();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }

        private void tsbtnListados_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Formulario en proceso", "Información", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}