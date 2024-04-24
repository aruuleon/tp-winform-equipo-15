using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;

namespace CatalogoWinForm
{
    public partial class ListaCategorias : Form
    {
        public ListaCategorias()
        {
            InitializeComponent();
        }

        private void ListaCategorias_Load(object sender, EventArgs e)
        {
            CategoriaNegocio catategoriaNeg = new CategoriaNegocio();
            dgvListaCategorias.DataSource = catategoriaNeg.listar();
        }

        private void btnAgregarCategorias_Click(object sender, EventArgs e)
        {
            AltaCategoria altaCategoria = new AltaCategoria();
            altaCategoria.ShowDialog();
        }

        private void btnVolverCat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
