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
    public partial class AltaArticulo : Form
    {
        private List<string> img = new List<string>();
        int indice = 0;
        public AltaArticulo()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            Articulo articulo = new Articulo();
            try
            {
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Precio = decimal.Parse(txtPrecio.Text);

                articuloNegocio.agregar(articulo);
                MessageBox.Show("Agregado correctamente");
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void AgregarArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                cboCategoria.DataSource = categoriaNegocio.listar();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void btnSubirImgAgregarArt_Click(object sender, EventArgs e)
        {
            try
            {
                img.Add(txtUrlImg.Text);
                indice = img.Count();
                pbImgAgregar.Load(img[indice-1]);
                txtUrlImg.Text = "";
            }
            catch (Exception )
            {

                pbImgAgregar.Load("https://th.bing.com/th/id/OIP.WeSkkwLXkUXbRcLJuN7I_gHaHa?rs=1&pid=ImgDetMain");
            }
            
        }

        private void btnNextImg_Click(object sender, EventArgs e)
        {
            try
            { 
                
                if (indice < img.Count-1)
                {
                    indice++;
                    pbImgAgregar.Load(img[indice]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnBeforeImg_Click(object sender, EventArgs e)
        {
            try
            {

                if (indice > 0)
                {
                    indice--;
                    pbImgAgregar.Load(img[indice]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnEliminarImg_Click(object sender, EventArgs e)
        {
            try
            {
                img.RemoveAt(indice);
                pbImgAgregar.Load(img[indice - 1]);
                indice = img.Count;
            }
            catch (Exception)
            {

                MessageBox.Show("No hay imagenes para eliminar");
            }
            
        }
    }
}
