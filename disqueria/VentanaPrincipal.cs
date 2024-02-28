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
        private int opcionDelete;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            cargar();
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
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Disco actual;
            actual = (Disco)dgvDiscos.CurrentRow.DataBoundItem;

            AgregarDisco form2 = new AgregarDisco(actual);
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
                ocultarColumnas();
                CargarImagen(listaDiscos[0].UrlTapa);

                foreach (DataGridViewColumn column in dgvDiscos.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
        private void ocultarColumnas()
        {
            dgvDiscos.Columns["UrlTapa"].Visible = false;
            dgvDiscos.Columns["FechaLanzamiento"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvDiscos.Columns["Id"].Visible = false;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            cargar();
            MessageBox.Show("Se han actualizado los registros");
        }

        private void eliminar(int n, bool logico = false)
        {
            DisqueriaBussines negocio = new DisqueriaBussines();
            Disco seleccionado;
            string textoAlerta;
            try
            {
                if (n == 1)
                    textoAlerta = "¿Desea eliminar el disco del registro?";
                else
                    textoAlerta = "¿Desea dar de baja el disco del registro?";

                DialogResult alerta = MessageBox.Show(textoAlerta, "Eliminando...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(alerta == DialogResult.Yes)
                {
                    seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
                    if(logico)
                    {
                        negocio.EliminarLogico(seleccionado.Id);
                        MessageBox.Show("Eliminado. Permancera en la base de datos");
                    }
                    else
                    {
                        negocio.Eliminar(seleccionado.Id);
                        MessageBox.Show("Eliminado correctamente");
                    }
                    cargar();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            opcionDelete = 2;
            eliminar(2, true);
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            opcionDelete = 1;
            eliminar(1);
        }
    }
}
