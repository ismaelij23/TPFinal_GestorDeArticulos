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
                btnDetalle.Enabled = true;
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
            }
            else
            {
                btnDetalle.Enabled = false;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
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
            if(dgvArticulos.CurrentRow != null)
            {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                Frm_alta_articulo ventanaModificar = new Frm_alta_articulo(seleccionado);
                ventanaModificar.ShowDialog();
                cargarDatos_hacia_dgv();
            }
            else
            {
                MessageBox.Show("No a elegido ningún artículo para modificar");
            }

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            ArticulosDatos datos_a_eliminar = new ArticulosDatos();

            if (dgvArticulos.CurrentRow == null)
            {
                MessageBox.Show("No a elegido ningún articulo para eliminar");
                return;
            }

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
        private void btnDetalle_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            if(dgvArticulos.CurrentRow != null)
            {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                Frm_Detalle ventanaDetalle = new Frm_Detalle(seleccionado);
                ventanaDetalle.ShowDialog();
            }
            else
            {
                MessageBox.Show("No a elegido ningún artículo para ver sus detalles");
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
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticulosDatos datos_filtrados = new ArticulosDatos();

            try
            {
                if (validarFiltro())
                    return;

                if (txtFiltro2.Visible == true)
                {
                    string filtro1 = txtFiltro.Text;
                    string filtro2 = txtFiltro2.Text;

                    dgvArticulos.DataSource = datos_filtrados.filtrar(filtro1, filtro2);
                }
                else
                {
                    string campo = cboCampo.SelectedItem.ToString();
                    string criterio = cboCriterio.SelectedItem.ToString();
                    string filtro = txtFiltro.Text;

                    dgvArticulos.DataSource = datos_filtrados.filtrar(campo, criterio, filtro);
                }
                txtFiltro.Text = "";
                txtFiltro2.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

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
        private bool validarFiltro()
        {
            if (cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar.");
                txtFiltro.Text = "";
                return true;
            }
            if (cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el criterio para filtrar.");
                txtFiltro.Text = "";
                return true;
            }
            if (cboCampo.SelectedItem.ToString() == "Precio")
            {

                if(cboCriterio.SelectedItem.ToString() == "Entre")
                {
                    if (string.IsNullOrEmpty(txtFiltro.Text) || string.IsNullOrEmpty(txtFiltro2.Text))
                    {
                        MessageBox.Show("Debes cargar los filtros numéricos...");
                        txtFiltro.Text = "";
                        txtFiltro2.Text = "";
                        return true;
                    }
                    
                    try
                    {
                        decimal d = Convert.ToDecimal(txtFiltro.Text);
                        decimal d1 = Convert.ToDecimal(txtFiltro2.Text);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Por favor, ingrese caracteres correctos");
                        txtFiltro.Text = "";
                        txtFiltro2.Text = "";
                        return true;
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(txtFiltro.Text))
                    {
                        MessageBox.Show("Debes cargar el filtro para numéricos...");
                        txtFiltro.Text = "";
                        return true;
                    }

                    try
                    {
                        decimal d = Convert.ToDecimal(txtFiltro.Text);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Por favor, ingrese caracteres correctos");
                        txtFiltro.Text = "";
                        return true;
                    }
                }
            }
            return false;
        }


    }
}
