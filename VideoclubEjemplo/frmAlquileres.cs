using System;
using System.Windows.Forms;

namespace VideoclubEjemplo
{
    public partial class frmAlquileres : Form
    {
        public frmAlquileres()
        {
            InitializeComponent();
        }

        private void btnBuscarSocio_Click(object sender, EventArgs e)
        {

            frmBusqSocios ventana = new frmBusqSocios();
            if (ventana.ShowDialog() == DialogResult.Cancel)
            {
                if (!ventana.codSocio.Equals("-1"))
                {
                    txtIdCliente.Text = ventana.codSocio;
                    txtNombre.Text = ventana.nombre;
                    txtApellido1.Text = ventana.apellido1;
                    txtApellido2.Text = ventana.apellido2;
                }
            }
        }


        private void cargarPeliculas()
        {
            dsBDTableAdapters.peliculasTableAdapter tbPeliculas = new dsBDTableAdapters.peliculasTableAdapter();
            tbPeliculas.Fill(dsBD.peliculas);
            for (int i = 0; i < dsBD.peliculas.Count; i++)
            {
                cmbTitulo.Items.Add(dsBD.peliculas[i].titulo);
            }
            cmbTitulo.SelectedIndex = 0;
        }

        private void frmAlquileres_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsBD.AlquilerPorSocio' Puede moverla o quitarla según sea necesario.
            this.alquilerPorSocioTableAdapter.FillByPeliculasAlquiladas(this.dsBD.AlquilerPorSocio);

            //Ahora vamos a cargar los datos de las peliculas
            this.peliculasTableAdapter.Fill(dsBD.peliculas);

            //Cargamos el combo
            cargarPeliculas();

        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.alquilerPorSocioTableAdapter.FillAlquilerPorSocio(this.dsBD.AlquilerPorSocio, int.Parse(txtIdCliente.Text));

            }
            catch (Exception)
            {

            }

        }
        private void cargarCaratula()
        {
            string fichCarat = "caratulas\\" + txtCaratula.Text;
            string rutaCaratula = System.IO.Path.Combine(Application.StartupPath, fichCarat);
            this.pcbCaratula.ImageLocation = rutaCaratula;
        }

        private void cmbTitulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cargamos los datos de las películas.
            dsBDTableAdapters.peliculasTableAdapter tbPeliculas = new dsBDTableAdapters.peliculasTableAdapter();
            tbPeliculas.Fill(dsBD.peliculas);
            lblCodPeli.Text = dsBD.peliculas[cmbTitulo.SelectedIndex].codpeli.ToString();
            txtDirector.Text = dsBD.peliculas[cmbTitulo.SelectedIndex].director.ToString();
            txtProtagonista.Text = dsBD.peliculas[cmbTitulo.SelectedIndex].protagonista.ToString();
            txtEstilo.Text = dsBD.peliculas[cmbTitulo.SelectedIndex].estilo.ToString();
            txtCategoria.Text = dsBD.peliculas[cmbTitulo.SelectedIndex].categoria.ToString();
            txtArgumento.Text = dsBD.peliculas[cmbTitulo.SelectedIndex].argumento.ToString();
            txtAño.Text = dsBD.peliculas[cmbTitulo.SelectedIndex].anio.ToString();
            nudStock.Value = dsBD.peliculas[cmbTitulo.SelectedIndex].stock;
            txtCaratula.Text = dsBD.peliculas[cmbTitulo.SelectedIndex].caratula.ToString();
            cargarCaratula();


            if (nudStock.Value < 1)
            {
                btnCogerPrestada.Enabled = false;
            }
            else
            {
                btnCogerPrestada.Enabled = true;
            }
        }

        private void dgvAlquileres_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCodigoAlquiler.Text = dgvAlquileres.SelectedCells[0].Value.ToString();
                txtTituloAlquiler.Text = dgvAlquileres.SelectedCells[1].Value.ToString();

                if (string.IsNullOrEmpty(txtTituloAlquiler.Text))
                {
                    btnDevolverPelicula.Enabled = false;
                }
                else
                {
                    btnDevolverPelicula.Enabled = true;
                }

                /*this.codSocio = dgvSocios.SelectedCells[0].Value.ToString();
                this.nombre = dgvSocios.SelectedCells[1].Value.ToString();
                this.apellido1 = dgvSocios.SelectedCells[2].Value.ToString();
                this.apellido2 = dgvSocios.SelectedCells[3].Value.ToString();*/
            }
            catch (Exception) { }
        }

        private void btnDevolverPelicula_Click(object sender, EventArgs e)
        {
            //Tendremos que calcular el valor del precio.
            decimal precio = calcularPrecio();
            //Acutalizamos el valor de la fecha de devolución
            //alquileresTableAdapter.UpdateFechayPrecio(System.DateTime.Today.ToString(), precio, int.Parse(txtCodigoAlquiler.Text));
            alquileresTableAdapter.UpdateFechayPrecio(DateTime.Today.ToString(), precio, int.Parse(txtCodigoAlquiler.Text));
            nudStock.Value += 1;
            peliculasTableAdapter.UpdateStock(int.Parse(nudStock.Value.ToString()), int.Parse(lblCodPeli.Text.ToString()));


            //Ahora tenemos que actualizar los datos del data grid view
            this.alquilerPorSocioTableAdapter.FillAlquilerPorSocio(this.dsBD.AlquilerPorSocio, int.Parse(txtIdCliente.Text));
        }

        private decimal calcularPrecio()
        {
            decimal precio = 0;
            try
            {
                //tenemos que calcular el precio según la categoria de la película
                //primero tenemos que sacar la categoria de la película
                //string categoria = peliculasTableAdapter.FillByCategoria(dsBD.peliculas, txtTituloAlquiler.Text.ToString()).ToString();
                //ahora que sabemos la categoria calculamos el precio
                //precio = categoriasTableAdapter1.FillByPrecioporCategoria(this.dsBD.categorias, txtCategoria.Text.ToString());
            }
            catch (Exception) { }
            return precio;
        }

        private void btnCogerPrestada_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIdCliente.Text.Trim()) && nudStock.Value > 0)
            {
                //Tendremos que insertar en la tabla de alquileres un alquiler con estos datos.
                alquileresTableAdapter.InsertAlquiler(System.DateTime.Today.ToString(), int.Parse(txtIdCliente.Text), int.Parse(lblCodPeli.Text));
                nudStock.Value -= 1;
                peliculasTableAdapter.UpdateStock(int.Parse(nudStock.Value.ToString()), int.Parse(lblCodPeli.Text.ToString()));

                //Actualizamos el valor del data grid
                this.alquilerPorSocioTableAdapter.FillAlquilerPorSocio(this.dsBD.AlquilerPorSocio, int.Parse(txtIdCliente.Text));
               
            }
            else
            {
                MessageBox.Show("LA PELÍCULA NO SE PUEDE ALQUILAR", "ERROR AL ALQUILAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
