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

            Cargar();
        }

        private void Cargar()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {
                listaArticulos = articuloNegocio.listar();
                dgvListaArticulos.DataSource = listaArticulos;
                ocultarColumnas();

            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error al cargar los datos, comuniquese con el servicio tecnico");
            }
        }
        private void ocultarColumnas()
        {
            dgvListaArticulos.Columns["Id"].Visible = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            AltaArticulo agregarArticulo = new AltaArticulo();
            agregarArticulo.ShowDialog();
            Cargar();
            
        }
    }
}
