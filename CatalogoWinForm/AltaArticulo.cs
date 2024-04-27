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
        public int idArt;
        private List<string> img = new List<string>();
        private Articulo articulo = null;
        int indice = -1;
        public AltaArticulo()
        {
            InitializeComponent();
        }
        public AltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            ImagenNegocio imagenNegocio = new negocio.ImagenNegocio();
            Articulo articulo = new Articulo();
            try
            {
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Precio = decimal.Parse(txtPrecio.Text);

                idArt = articuloNegocio.agregar(articulo);
                imagenNegocio.agregar(img, idArt);
                MessageBox.Show("Agregado correctamente");
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
        private void AltaArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                cboCategoria.DataSource = categoriaNegocio.listar();
                //cboMarca.DataSource = marcaNegocio.listar();

                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";
                //cboMarca.ValueMember = "Id";
                //cboMarca.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtPrecio.Text = articulo.Precio.ToString();
                    txtDescripcion.Text = articulo.Descripcion;
                    cboCategoria.SelectedValue = articulo.Categoria.ID;
                    //cboMarca.SelectedValue = articulo.Marca.ID;
                }
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
                pbImgAgregar.Load(txtUrlImg.Text);
                img.Add(txtUrlImg.Text);
                indice = img.Count() - 1;
                txtUrlImg.Text = "";
            }
            catch (Exception)
            {
                if (indice >= 0)
                {
                    pbImgAgregar.Load(img[indice]);
                }
                else
                {
                    imgDefoult();
                }

                txtUrlImg.Text = "";
                MessageBox.Show("Imagen no encontrada");
            }

        }

        private void btnNextImg_Click(object sender, EventArgs e)
        {
            try
            {

                if (indice < img.Count - 1)
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
                img.Remove(pbImgAgregar.ImageLocation);
                if (indice > 0)
                {
                    indice--;
                }


                if (img.Count > 0)
                {
                    pbImgAgregar.Load(img[indice]);
                }
                else imgDefoult();


            }
            catch (Exception)
            {

                MessageBox.Show("No hay imagenes para eliminar");
            }

        }
        private void imgDefoult()
        {
            try
            {

                pbImgAgregar.Load("https://th.bing.com/th/id/OIP.WeSkkwLXkUXbRcLJuN7I_gHaHa?rs=1&pid=ImgDetMain");

            }
            catch (Exception)
            {

                MessageBox.Show("No funciona la defoult");
            }

        }
    }
}
