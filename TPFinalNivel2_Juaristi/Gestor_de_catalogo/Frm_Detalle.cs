using Dominio;
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
    public partial class Frm_Detalle : Form
    {
        Articulo art;
        public Frm_Detalle()
        {
            InitializeComponent();
        }
        public Frm_Detalle(Articulo articulo)
        {
            InitializeComponent();
            art = articulo;
        }
        private void Frm_Detalle_Load(object sender, EventArgs e)
        {
            lblCodigoHijo.Text = art.Codigo;
            lblDescripcionHijo.Text = art.Descripcion;
            lblNombreHijo.Text = art.Nombre;
            lblCategoriaHijo.Text = art.Categoria.Descripcion;
            lblMarcaHijo.Text = art.Marca.Descripcion;
            lblPrecioHijo.Text = "$" + art.Precio.ToString();
            cargarImagen(art.UrlImg);
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
    }
}
