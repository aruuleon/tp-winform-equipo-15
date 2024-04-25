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
        private List<Categoria> listaCategoria;
        public ListaCategorias()
        {
            InitializeComponent();
        }

        private void Cargar()
        {
            CategoriaNegocio catategoriaNeg = new CategoriaNegocio();
            try
            {          
                listaCategoria = catategoriaNeg.listar();
                dgvListaCategorias.DataSource = listaCategoria;
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
                    if (!(ComprobarEliminacion(seleccionado.ID)))
                    {
                        categoriaNegocio.eliminar(seleccionado.ID);
                        MessageBox.Show("Eliminado correctamente");
                        Cargar();
                    }
                    else MessageBox.Show("La categoria que intenta eliminar esta en uso");



                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error al eliminar los datos, comuniquese con el servicio tecnico");
            }
        }

        private bool ComprobarEliminacion(int id)
        {
            List<int> listaUsados = new List<int>();
            AccesoDatos accesoDatos = new AccesoDatos();
            bool Usando = false;
            try
            {
                accesoDatos.setearConsulta("SELECT IdCategoria FROM ARTICULOS");
                accesoDatos.ejecutarLectura();
                while (accesoDatos.Lector.Read())
                {
                    listaUsados.Add((int)accesoDatos.Lector["IdCategoria"]);
                }
                foreach (int item in listaUsados)
                {
                    if(id == item)
                    {
                        Usando = true; 
                    }
                }
                return Usando;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }


        private void btnBuscarCategorias_Click(object sender, EventArgs e)
        {
            List<Categoria> listafiltrada;
            string filtro = tbBuscarCategorias.Text;
            if (filtro != "")
            {
                listafiltrada = listaCategoria.FindAll(x => x.Descripcion.ToLower().Contains(filtro.ToLower()) || x.ID == Int32.Parse(filtro)); ;
                
            }
            else
            {
                listafiltrada = listaCategoria;
            }

            dgvListaCategorias.DataSource = null;
            dgvListaCategorias.DataSource = listafiltrada;
        }
    }
}
