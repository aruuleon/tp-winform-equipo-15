using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogoWinForm
{
    public partial class DetalleArticulo : Form
    {
        private Articulo articulo = null;
        public DetalleArticulo()
        {
            InitializeComponent();
        }
        public DetalleArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void DetalleArticulo_Load(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {
                if(articulo != null) {
                    lblCodigo.Text = articulo.Codigo;
                    lblNombre.Text = articulo.Nombre;
                    lblCategoria.Text = articulo.Categoria.Descripcion;
                    //lblMarca.Text = articulo.Marca.Descripcion;
                    lblPrecio.Text = articulo.Precio.ToString();
                    lblDescripcion.Text = articulo.Descripcion;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al cargar los datos, comuniquese con el servicio tecnico");
            }
        }
    }
}
