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

        private void FrmGestor_Load(object sender, EventArgs e)
        {
            cargarDatos_hacia_dgv();
            dgvArticulos.Columns["UrlImg"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "0.00";
        }
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

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImg);
            }
        }


    }
}
