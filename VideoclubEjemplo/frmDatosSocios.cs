using System;
using System.Windows.Forms;

namespace VideoclubEjemplo
{
    public partial class frmDatosSocios : Form
    {
        public frmDatosSocios()
        {
            InitializeComponent();
        }

        private void sociosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sociosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBD);

        }

        private void frmDatosSocios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsBD.socios' Puede moverla o quitarla según sea necesario.
            this.sociosTableAdapter.Fill(this.dsBD.socios);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //Vamos a modificar el boton de eliminar item
            int regs;
            DialogResult resp = new DialogResult();
            resp = MessageBox.Show("¿Seguro que quieres eliminar este registro?", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (resp == DialogResult.Yes)
            {
                regs = this.sociosTableAdapter.Delete(int.Parse(this.idSocioLabel1.Text));
                if (regs > 0)
                {
                    MessageBox.Show("Socio eliminado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sociosTableAdapter.Fill(dsBD.socios);
                }
            }
        }
    }
}
