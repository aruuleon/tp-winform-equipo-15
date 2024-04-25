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
    public partial class ListaCategorias : Form
    {
        public ListaCategorias()
        {
            InitializeComponent();
        }

        private void Cargar()
        {
            try
            {
                CategoriaNegocio catategoriaNeg = new CategoriaNegocio();
                dgvListaCategorias.DataSource = catategoriaNeg.listar();
            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error al cargar los datos, comuniquese con el servicio tecnico");
            }
            
        }
        private void ListaCategorias_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnAgregarCategorias_Click(object sender, EventArgs e)
        {
            AltaCategoria altaCategoria = new AltaCategoria();
            altaCategoria.ShowDialog();
            Cargar();
        }

        private void btnVolverCat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModificarCategorias_Click(object sender, EventArgs e)
        {
            Categoria seleccionado;
            seleccionado = (Categoria)dgvListaCategorias.CurrentRow.DataBoundItem;
            AltaCategoria ModCategoria = new AltaCategoria(seleccionado);
            ModCategoria.ShowDialog();
            Cargar();
        }

        private void btnEliminarCategorias_Click(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            Categoria seleccionado;
            
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Estas seguro de eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Categoria)dgvListaCategorias.CurrentRow.DataBoundItem;
                    categoriaNegocio.eliminar(seleccionado.ID);

                    MessageBox.Show("Eliminado correctamente");
                    Cargar();
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error al eliminar los datos, comuniquese con el servicio tecnico");
            }
        }
    }
}
