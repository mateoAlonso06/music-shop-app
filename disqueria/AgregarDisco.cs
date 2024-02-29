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
        private Disco disco = null;
        public AgregarDisco()
        {
            InitializeComponent();
        }
        public AgregarDisco(Disco disco)
        {
            InitializeComponent();
            this.disco = disco;
            Text = "Modificar disco";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DisqueriaBussines negocio1 = new DisqueriaBussines();
            try
            {   
                if(disco == null)
                {
                    disco = new Disco();
                }

                disco.Titulo = addTitulo.Text;
                disco.FechaLanzamiento = addFecha.Value;
                disco.CantidadCanciones = int.Parse(addCantidad.Text);
                disco.UrlTapa = addUrl.Text; 
                disco.Genero = (Estilo)addGenero.SelectedItem;
                disco.Edicion = (TipoEdicion)addTipo.SelectedItem;

                if(disco.Id != 0)
                {
                    negocio1.updateQuery(disco);
                    MessageBox.Show("Disco modificado exitosamente");
                }
                else
                {
                    negocio1.InsertQuery(disco);
                    MessageBox.Show("Agregado exitosamente");
                }
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
                addGenero.ValueMember = "Id";
                addGenero.DisplayMember = "Descripcion";
                addTipo.DataSource = negEdicion.Listar();
                addTipo.ValueMember = "Id";
                addTipo.DisplayMember = "Descripcion";

                if(disco != null)
                {
                    addTitulo.Text = disco.Titulo;
                    addFecha.Value = disco.FechaLanzamiento;
                    addCantidad.Text = disco.CantidadCanciones.ToString();
                    addUrl.Text = disco.UrlTapa;
                    CargarImagen(disco.UrlTapa);
                    addTipo.SelectedValue = disco.Edicion.Id;
                    addGenero.SelectedValue = disco.Genero.Id;
                }
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
                loadPortada.Load("https://editorial.unc.edu.ar/wp-content/uploads/sites/33/2022/09/placeholder.png");
            }
        }
    }
}
