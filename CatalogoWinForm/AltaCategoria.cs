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
    public partial class AltaCategoria : Form
    {
        public AltaCategoria()
        {
            InitializeComponent();
        }

        private void btnCancelarAlta_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            Categoria cate = new Categoria(); 
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                if (tbAltaCategoria.Text.Length > 0)
                {
                    cate.Descripcion = tbAltaCategoria.Text;
                    negocio.agregar(cate);
                    MessageBox.Show("Agregado correctamente");
                    Close();
                } else MessageBox.Show("Escriba una descripcion antes de agregar");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
