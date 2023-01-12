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
        }
        private void cargarDatos_hacia_dgv()
        {
            ArticulosDatos articulos_catalogo = new ArticulosDatos();

            try
            {
                listaArticulos = articulos_catalogo.listar();
                dgvArticulos.DataSource = listaArticulos;
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
    }
}
