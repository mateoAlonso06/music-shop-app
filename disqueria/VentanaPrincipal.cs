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
    public partial class VentanaPrincipal : Form
    {
        private List<Disco> listaDiscos;
        private int opcionDelete;
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            cargar();
            addCampo.Items.Add("Titulo");
            addCampo.Items.Add("Genero");
            addCampo.Items.Add("Edicion");
            addCrit.Enabled = false;
            addClave.Enabled = false;
            btnAlta.Enabled = false;
            if (btnAlta.Enabled == false)
            {
                btnAlta.BackColor = Color.White;
                btnAlta.ForeColor = Color.Gray;
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
                imagenTapa.Load("https://editorial.unc.edu.ar/wp-content/uploads/sites/33/2022/09/placeholder.png");
            }
        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvDiscos.CurrentRow != null)
            {
                Disco discSelect = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
                CargarImagen(discSelect.UrlTapa);
            }
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
                if (btnAlta.Enabled == false)
                {
                    btnAlta.BackColor = Color.White;
                    btnAlta.ForeColor = Color.Gray;
                }
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


        private void cargar(bool logico = true)
        {
            DisqueriaBussines negocio = new DisqueriaBussines();
            try
            {
                listaDiscos = negocio.TraerBajas();
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
            dgvDiscos.Columns["Alta"].Visible = false;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            cargar();
            MessageBox.Show("Se han actualizado los registros");
            controlarBotones(true);
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
            eliminar(opcionDelete, true);
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            opcionDelete = 1;
            eliminar(opcionDelete);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Disco> listaFiltrada;
            string filtro = txtFiltroRapido.Text;
            if(filtro.Length >= 1)
                listaFiltrada = listaDiscos.FindAll(x => x.Titulo.ToLower().Contains(filtro.ToLower()));
            else
                listaFiltrada = listaDiscos;

            dgvDiscos.DataSource = null;
            dgvDiscos.DataSource = listaFiltrada;

            foreach (DataGridViewColumn column in dgvDiscos.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            ocultarColumnas();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DisqueriaBussines negocio = new DisqueriaBussines();
                string campo = addCampo.SelectedItem.ToString();
                string criterio = addCrit.SelectedItem.ToString();
                string clave = addClave.Text;

                dgvDiscos.DataSource = negocio.Filtrar(campo, criterio, clave);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void addCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = addCampo.SelectedItem.ToString();
            addCrit.Enabled = true;
            if(opcion == "Titulo" || opcion == "Genero" || opcion == "Edicion")
            {
                addCrit.Items.Clear();
                addCrit.Items.Add("Empieza con");
                addCrit.Items.Add("Termina con");
                addCrit.Items.Add("Contiene");
            }
        }

        private void addCrit_SelectedIndexChanged(object sender, EventArgs e)
        {
            addClave.Enabled = true;
        }

        private void btnInactivos_Click(object sender, EventArgs e)
        {
            cargar(true);
            controlarBotones(false);
            if(btnAlta.Enabled == true)
            {
                btnAlta.BackColor = Color.Black;
                btnAlta.ForeColor = Color.White;
            }
        }

        private void controlarBotones(bool val)
        {
            if (val)
            {
                btnAgregar.Enabled = true;
                btnEliminarFisico.Enabled = true;
                btnEliminarLogico.Enabled = true;
                btnAlta.Enabled = false;
            }
            else
            {
                btnAgregar.Enabled = false;
                btnEliminarFisico.Enabled = false;
                btnEliminarLogico.Enabled = false;
                btnAlta.Enabled = true;
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            DisqueriaBussines negocio = new DisqueriaBussines();
            Disco seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
            if(seleccionado.Alta == false)
            {
                btnAlta.Enabled = true;
                negocio.Alta(seleccionado.Id);
            }
        }
    }
}
