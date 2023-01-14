using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_catalogo
{
    public partial class Frm_alta_articulo : Form
    {
        Articulo articulo = null;
        public Frm_alta_articulo()
        {
            InitializeComponent();
        }
        public Frm_alta_articulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            lblTitulo.Text = "Modificar Articulo";
            txtPrecio.Text = Math.Round(articulo.Precio, 2).ToString();
        }
        private void Frm_alta_articulo_Load(object sender, EventArgs e)
        {
            CategoriasDatos cboCategoria_datos = new CategoriasDatos();
            MarcasDatos cboMarca_datos = new MarcasDatos();

            try
            {
                cboCategoria.DataSource = cboCategoria_datos.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                cboMarca.DataSource = cboMarca_datos.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtUrl.Text = articulo.UrlImg;
                    cargarImagen(txtUrl.Text);
                    cboCategoria.SelectedValue = articulo.Categoria.Id;
                    cboMarca.SelectedValue = articulo.Marca.Id;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticulosDatos datos_articulo_a_agregar_modificar = new ArticulosDatos();

            try
            {
                if(articulo == null)
                    articulo = new Articulo();

                articulo.Codigo =  txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.UrlImg = txtUrl.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);

                if (articulo.Id != 0)
                {
                    datos_articulo_a_agregar_modificar.Modificar(articulo);
                    MessageBox.Show("Modificado exitosamente!");
                }
                else
                {
                    datos_articulo_a_agregar_modificar.Agregar(articulo);
                    MessageBox.Show("Agregado exitosamente!");
                }
                Close();
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
                pictureBoxImg.Load(imagen);
            }
            catch (Exception ex)
            {
                pictureBoxImg.Load("https://www.jennybeaumont.com/wp-content/uploads/2015/03/placeholder.gif");
            }
        }
        private void txtUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrl.Text);
        }
    }
}
