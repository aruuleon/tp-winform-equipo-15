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
using negocio;

namespace CatalogoWinForm
{
    public partial class ListaArticulos : Form
    {
        private List<Articulo> listaArticulos = new List<Articulo>();
        public ListaArticulos() {
            InitializeComponent();
        }
        private void ListaArticulos_Load(object sender, EventArgs e) {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            listaArticulos = articuloNegocio.listar();
            dgvListaArticulos.DataSource = listaArticulos;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
