using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using disqueriaBussines;


namespace disqueria
{
    public partial class FrmMain : Form
    {
        private List<Disco> listaDiscos;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            DisqueriaBussines negocio = new DisqueriaBussines();
            try
            {
                listaDiscos = negocio.Listar();
                dgvDiscos.DataSource = listaDiscos;
                dgvDiscos.Columns["UrlTapa"].Visible = false;
                dgvDiscos.Columns["FechaLanzamiento"].DefaultCellStyle.Format = "dd/MM/yyyy";
                CargarImagen(listaDiscos[0].UrlTapa);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        public void CargarImagen(string urlImagen)
        {
            try
            {
                imagenTapa.Load(urlImagen);
            }
            catch (Exception)
            {
                imagenTapa.Load("https://www.google.com/url?sa=i&url=https%3A%2F%2Feditorial.unc.edu.ar%2Fplaceholder-png%2F&psig=AOvVaw2ifd52O5oO5F_4keDSw8se&ust=1709125663981000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCNCt17LLy4QDFQAAAAAdAAAAABAE");
            }
        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            Disco discSelect = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
            CargarImagen(discSelect.UrlTapa);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarDisco form2 = new AgregarDisco();
            form2.ShowDialog();
            cargar();
        }

        private void cargar()
        {
            DisqueriaBussines negocio = new DisqueriaBussines();
            try
            {
                listaDiscos = negocio.Listar();
                dgvDiscos.DataSource = listaDiscos;
                dgvDiscos.Columns["UrlTapa"].Visible = false;
                dgvDiscos.Columns["FechaLanzamiento"].DefaultCellStyle.Format = "dd/MM/yyyy";
                CargarImagen(listaDiscos[0].UrlTapa);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
