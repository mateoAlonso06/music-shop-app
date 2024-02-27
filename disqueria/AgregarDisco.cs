using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using disqueriaBussines;
using dominio;


namespace disqueria
{
    public partial class AgregarDisco : Form
    {
        public AgregarDisco()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Disco disco = new Disco();
            DisqueriaBussines negocio1 = new DisqueriaBussines();
            try
            {
                disco.Titulo = addTitulo.Text;
                disco.FechaLanzamiento = addFecha.Value;
                disco.CantidadCanciones = int.Parse(addCantidad.Text);
                disco.UrlTapa = addUrl.Text; 
                disco.Genero = (Estilo)addGenero.SelectedItem;
                disco.Edicion = (TipoEdicion)addTipo.SelectedItem;

                negocio1.InsertQuery(disco);
                MessageBox.Show("Agregado exitosamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void AgregarDisco_Load(object sender, EventArgs e)
        {
            EstiloBussines negGenero = new EstiloBussines();
            EdicionBussines negEdicion = new EdicionBussines();
            try
            {
                addGenero.DataSource = negGenero.Listar();
                addTipo.DataSource = negEdicion.Listar();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void addUrl_Leave(object sender, EventArgs e)
        {
            CargarImagen(addUrl.Text);
        }

        public void CargarImagen(string urlImagen)
        {
            try
            {
                loadPortada.Load(urlImagen);
            }
            catch (Exception)
            {
                loadPortada.Load("https://www.google.com/url?sa=i&url=https%3A%2F%2Feditorial.unc.edu.ar%2Fplaceholder-png%2F&psig=AOvVaw2ifd52O5oO5F_4keDSw8se&ust=1709125663981000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCNCt17LLy4QDFQAAAAAdAAAAABAE");
            }
        }
    }
}
