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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try {
                listaArticulos = articuloNegocio.listar();
                dgvListaArticulos.DataSource = listaArticulos;
                ocultarColumnas();
            } catch (Exception exception) {
                MessageBox.Show(exception.ToString());
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

        private void btnDetalle_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvListaArticulos.CurrentRow != null)
            {
                Articulo articulo = (Articulo)dgvListaArticulos.CurrentRow.DataBoundItem;

                DetalleArticulo detalleArticulo = new DetalleArticulo(articulo);
                detalleArticulo.ShowDialog();
            }
            else MessageBox.Show("Seleccione una columna");
        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            if (dgvListaArticulos.CurrentRow != null)
            {
                Articulo articulo = (Articulo)dgvListaArticulos.CurrentRow.DataBoundItem;
                AltaArticulo modificarArticulo = new AltaArticulo(articulo);
                modificarArticulo.ShowDialog();
                Cargar();
            }
            else MessageBox.Show("Seleccione una columna");
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try {
                DialogResult dialogResult = MessageBox.Show("¿Está seguro que quiere eliminar el artículo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes) {
                    Articulo articulo = (Articulo)dgvListaArticulos.CurrentRow.DataBoundItem;
                    articuloNegocio.eliminar(articulo.Codigo);
                    Cargar();
                }
            } catch (Exception exception) {
                MessageBox.Show(exception.ToString());
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            List<Articulo> listaFiltrada;
            string textoFiltrado = txtBuscar.Text.ToUpper();

            if (textoFiltrado != "") {
                listaFiltrada = listaArticulos.FindAll(articulo => articulo.Codigo.ToUpper().Contains(textoFiltrado) ||
                                articulo.Nombre.ToUpper().Contains(textoFiltrado) ||
                                articulo.Descripcion.ToUpper().Contains(textoFiltrado) ||
                                articulo.Categoria.Descripcion.ToUpper().Contains(textoFiltrado) ||
                                articulo.Marca.Descripcion.ToUpper().Contains(textoFiltrado));
            } else {
                listaFiltrada = listaArticulos;
            }
            dgvListaArticulos.DataSource = null;
            dgvListaArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }
    }
}
