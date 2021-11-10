using System;
using System.Windows.Forms;

namespace VideoclubEjemplo
{
    public partial class frmBusqSocios : Form
    {
        //Estos son los valores que vamos a devolver al otro formulario
        public String codSocio;
        public String nombre;
        public String apellido1;
        public String apellido2;


        public frmBusqSocios()
        {
            InitializeComponent();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            this.sociosTableAdapter.FillByBusqSocios(this.dsBD.socios);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdCliente.Text.Trim()))
            {
                sociosTableAdapter.FillByFiltroSinID(dsBD.socios, txtNombre.Text.ToString(), txtApellido1.Text.ToString(), txtApellido2.Text.ToString());
            }
            else
            {
                sociosTableAdapter.FillByFiltroConID(dsBD.socios, txtNombre.Text.ToString(), txtApellido1.Text.ToString(), txtApellido2.Text.ToString(), int.Parse(txtIdCliente.Text.ToString()));
            }
            

        }
        private void comprobarBuscar()
        {
            if (!string.IsNullOrEmpty(txtIdCliente.Text) || !string.IsNullOrEmpty(txtNombre.Text) || !string.IsNullOrEmpty(txtApellido1.Text))
            {
                btnBuscar.Enabled = true;
            }
            else
            {
                btnBuscar.Enabled = false;
            }
        }


        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {
            comprobarBuscar();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            comprobarBuscar();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            comprobarBuscar();
        }

        private void dgvSocios_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.codSocio = dgvSocios.SelectedCells[0].Value.ToString();
                this.nombre = dgvSocios.SelectedCells[1].Value.ToString();
                this.apellido1 = dgvSocios.SelectedCells[2].Value.ToString();
                this.apellido2 = dgvSocios.SelectedCells[3].Value.ToString();
            }
            catch (Exception) { }

            this.Close();
        }
    }
}
