using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;


namespace Gestor_de_catalogo
{
    public partial class FrmGestor : Form
    {
        private List<Articulo> listaArticulos;
        public FrmGestor()
        {
            InitializeComponent();
        }

        // Eventos
        private void FrmGestor_Load(object sender, EventArgs e)
        {
            cargarDatos_hacia_dgv();
            ocultarColumnas();
            dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "0.00";
            cboCampo.Items.Add("Código");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Categoría");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Precio");
            txtFiltro2.Visible= false;
        }
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImg);
            }
        }
        private void txtFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> lista_articulos_filtrados;
            string filtro = txtFiltroRapido.Text;

            if(filtro.Length >= 3)
            {
                lista_articulos_filtrados = listaArticulos.FindAll(x => x.Codigo.ToUpper().Contains(txtFiltroRapido.Text.ToUpper()) || x.Nombre.ToUpper().Contains(txtFiltroRapido.Text.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(txtFiltroRapido.Text.ToUpper()) || x.Categoria.Descripcion.ToUpper().Contains(txtFiltroRapido.Text.ToUpper()));
            }
            else
            {
                lista_articulos_filtrados = listaArticulos;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = lista_articulos_filtrados;
            ocultarColumnas();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Frm_alta_articulo ventanaAgregar = new Frm_alta_articulo();
            ventanaAgregar.ShowDialog();
            cargarDatos_hacia_dgv();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            Frm_alta_articulo ventanaModificar = new Frm_alta_articulo(seleccionado);
            ventanaModificar.ShowDialog();
            cargarDatos_hacia_dgv();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            ArticulosDatos datos_a_eliminar = new ArticulosDatos();
            try
            {
                DialogResult respuesta = MessageBox.Show("Está seguro de querer eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    datos_a_eliminar.Eliminar(seleccionado.Id);
                    cargarDatos_hacia_dgv();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion_select = cboCampo.SelectedItem.ToString();

            if(opcion_select == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Hasta");
                cboCriterio.Items.Add("Entre");
                cboCriterio.Items.Add("Mas de");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }
        private void cboCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion_select = cboCriterio.SelectedItem.ToString();

            if (opcion_select == "Entre")
                txtFiltro2.Visible = true;
            else
                txtFiltro2.Visible = false;
        }

        // Funciones
        private void cargarDatos_hacia_dgv()
        {
            ArticulosDatos articulos_catalogo = new ArticulosDatos();

            try
            {
                listaArticulos = articulos_catalogo.listar();
                dgvArticulos.DataSource = listaArticulos;
                cargarImagen(listaArticulos[0].UrlImg);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void cargarImagen(string imagen)
        {
            try
            {
               picBoxImg.Load(imagen);
            }
            catch (Exception ex)
            {
                picBoxImg.Load("https://www.jennybeaumont.com/wp-content/uploads/2015/03/placeholder.gif");
            }
        }
        private void ocultarColumnas()
        {
            dgvArticulos.Columns["UrlImg"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticulosDatos datos_filtrados = new ArticulosDatos();

            if(txtFiltro2.Visible == true)
            {
                string filtro1 = txtFiltro.Text;
                string filtro2 = txtFiltro2.Text;

                dgvArticulos.DataSource = datos_filtrados.filtrar(filtro1,filtro2);
            }
            else
            {
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltro.Text;

                dgvArticulos.DataSource = datos_filtrados.filtrar(campo, criterio, filtro);
            }
        }
    }
}
