using System;
using System.Windows.Forms;

namespace VideoclubEjemplo
{
    public partial class FrmLogin : Form
    {
        public int IDSocio;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Creamos las variables necesarias para gestionar los datos:
            //Nuestro conjunto de datos
            dsBD ds = new dsBD();

            //La consultas de la tabla socios
            dsBDTableAdapters.sociosTableAdapter tbSocios = new dsBDTableAdapters.sociosTableAdapter();

            //Ejecutamos la consulta para ver si los datos introducidos son correctos
            tbSocios.FillByLoginPwd(ds.socios, txtLogin.Text, txtContraseña.Text);

            //Si tenemos algun socio con el login y la contraseña introducida...
            if (ds.socios.Count > 0)
            {
                MessageBox.Show("Buenas " + ds.socios[0].nombre, "Saludo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IDSocio = ds.socios[0].idSocio;
                frmPanelPrincipal ventana = new frmPanelPrincipal();
                ventana.ShowDialog();
            }
            //Si no tenemos ningún socio con ese login y contraseña lo mostramos.
            else
            {
                MessageBox.Show("Login o Contraseña incorrectas", "Login Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
