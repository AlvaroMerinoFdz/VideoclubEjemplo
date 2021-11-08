using System;
using System.Windows.Forms;

namespace VideoclubEjemplo
{
    public partial class frmDatosSocios : Form
    {
        dsBDTableAdapters.alquileresTableAdapter taAlquileres = new dsBDTableAdapters.alquileresTableAdapter();
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
                taAlquileres.FillBySocio(dsBD.alquileres, int.Parse(this.idSocioLabel1.Text));//guardamos los registros en dsBd.alquileres
                if (dsBD.alquileres.Count > 0)
                {
                    //MessageBox.Show("No se puede eliminar al socio, porque tiene alquileres", "Eliminar registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult respuesta = MessageBox.Show("El socio tiene peliculas alquiladas \n ¿Desea borrar los alquileres también?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (respuesta == DialogResult.Yes)
                    {
                        //Se eliminan primero los alquileres y luego el socio
                        taAlquileres.DeleteSocio(int.Parse(this.idSocioLabel1.Text));
                        MessageBox.Show("Alquileres eliminados", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Ahora eliminamos al socio
                        this.sociosTableAdapter.Delete(int.Parse(this.idSocioLabel1.Text));
                        MessageBox.Show("Socio eliminado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        sociosTableAdapter.Fill(dsBD.socios);
                    }
                    else
                    {
                        MessageBox.Show("El socio no se puede eliminar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
