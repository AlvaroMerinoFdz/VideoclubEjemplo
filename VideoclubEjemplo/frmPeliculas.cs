using System;
using System.Windows.Forms;

namespace VideoclubEjemplo
{
    public partial class frmPeliculas : Form
    {

        dsBDTableAdapters.alquileresTableAdapter tbAlquileres = new dsBDTableAdapters.alquileresTableAdapter();
        public frmPeliculas()
        {
            InitializeComponent();
        }

        private void peliculasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.peliculasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBD);

        }

        private void peliculasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.peliculasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBD);

        }

        private void frmPeliculas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsBD.categorias' Puede moverla o quitarla según sea necesario.
            this.categoriasTableAdapter.Fill(this.dsBD.categorias);
            // TODO: esta línea de código carga datos en la tabla 'dsBD.estilos' Puede moverla o quitarla según sea necesario.
            this.estilosTableAdapter.Fill(this.dsBD.estilos);
            // TODO: esta línea de código carga datos en la tabla 'dsBD.peliculas' Puede moverla o quitarla según sea necesario.
            this.peliculasTableAdapter.Fill(this.dsBD.peliculas);

            //Cargamos el combo de estilos del toolStripMenu
            cargarComboEstilos();
        }

        /**
         * Método que vale para cargar el combo de estilos que se encuentra en el ToolStripMenu
         */
        private void cargarComboEstilos()
        {
            dsBDTableAdapters.estilosTableAdapter tbEstilos = new dsBDTableAdapters.estilosTableAdapter();
            tbEstilos.Fill(dsBD.estilos);
            for (int i = 0; i < dsBD.estilos.Count; i++)
            {
                toolStripcmbEstilos.Items.Add(dsBD.estilos[i].estilo);
            }
        }

        /*private void toolStripcmbEstilos_TextChanged(object sender, EventArgs e)
        {
            dsBD.peliculas.Clear();
            peliculasTableAdapter.FillByEstilo(dsBD.peliculas, toolStripcmbEstilos.Text);
        }*/

        private void btnMostrarTodas_Click(object sender, EventArgs e)
        {
            dsBD.peliculas.Clear();
            peliculasTableAdapter.Fill(dsBD.peliculas);
            toolStripcmbEstilos.Text = "";
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult resp = new DialogResult();
            resp = MessageBox.Show("Estás seguro que quieres eliminar la película?", "Eliminar Película", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resp == DialogResult.Yes)
            {
                //Miramos si la película tiene algún alquiler
                tbAlquileres.FillByPelicula(dsBD.alquileres, int.Parse(lblCodPeli.Text));
                if (dsBD.alquileres.Count > 0)
                {
                    MessageBox.Show("La película no se puede borrar porque está alquilada", "Información ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    //Eliminamos el alquiler 
                    tbAlquileres.DeleteAlquiler(int.Parse(lblCodPeli.Text));
                    //Eliminamos la película
                    peliculasTableAdapter.Delete1(int.Parse(lblCodPeli.Text));
                    MessageBox.Show("Película eliminada correctamente", "Película eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Actualizamos la lista de Peliculas
                    dsBD.peliculas.Clear();
                    peliculasTableAdapter.Fill(dsBD.peliculas);
                }
            }
        }

        private void cargarCaratula()
        {
            string fichCarat = "caratulas\\" + caratulaTextBox.Text;
            string rutaCaratula = System.IO.Path.Combine(Application.StartupPath, fichCarat);
            this.picCaratula.ImageLocation = rutaCaratula;
        }

        private void toolStripcmbEstilos_SelectedIndexChanged(object sender, EventArgs e)
        {
            dsBD.peliculas.Clear();
            peliculasTableAdapter.FillByEstilo(dsBD.peliculas, toolStripcmbEstilos.Text);
        }

        private void btnNuevaCaratula_Click(object sender, EventArgs e)
        {
            //Esto para que el OpenFileDialog por defecto se abra por el directorio caratulas de proyecto
            string miCarpetaOrigen = System.IO.Path.Combine(Application.StartupPath, "caratulas\\");
            ofdCaratulas.InitialDirectory = miCarpetaOrigen;


            if (ofdCaratulas.ShowDialog() == DialogResult.OK)
            {
                //Establecemos la nueva caratula
                string rutaFich = ofdCaratulas.FileName;
                caratulaTextBox.Text = rutaFich.Substring(rutaFich.LastIndexOf("\\") + 1);

                //Ahora copiamos el fichero a mi carpeta caratulas
                string carpetaImagen = rutaFich.Substring(0, rutaFich.LastIndexOf("\\") + 1);
                //Solo se copia si había elegido una imagen de otro directorio distinto
                if (!miCarpetaOrigen.Equals(carpetaImagen))
                {
                    string rutaDestinoEntera = miCarpetaOrigen + caratulaTextBox.Text;
                    System.IO.File.Copy(rutaFich, rutaDestinoEntera, true);
                }
            }

        }

        private void caratulaTextBox_TextChanged(object sender, EventArgs e)
        {
            cargarCaratula();
        }
    }
}
