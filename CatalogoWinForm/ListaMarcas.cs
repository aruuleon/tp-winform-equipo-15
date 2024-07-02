using dominio;
using negocio;
using System;
using System.Collections;
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
    public partial class ListaMarcas : Form
    {
        private List<Marca> listaMarca;
        public ListaMarcas()
        {
            InitializeComponent();

        }

        private void Cargar()
        {

            MarcaNegocio marcaNegocio = new MarcaNegocio();


            try
            {
                listaMarca = marcaNegocio.listar();

                dgvListaMarcas.DataSource = listaMarca;
                ocultarColumnas();
            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error al cargar los datos, comuniquese con el servicio tecnico");

            }
        }
        private void btnVolverCat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListaMarcas_Load(object sender, EventArgs e)
        {
            Cargar();
        }
        private void ocultarColumnas()
        {
            dgvListaMarcas.Columns["Id"].Visible = false;
        }

        private void btnAgregarMarcas_Click(object sender, EventArgs e)
        {
            frmAgregarMarca agregarMarca = new frmAgregarMarca();
            agregarMarca.ShowDialog();
            Cargar();
        }

        private void btnModificarMarcas_Click(object sender, EventArgs e)
        {
            try
            {
                Marca seleccionado;

                seleccionado = (Marca)dgvListaMarcas.CurrentRow.DataBoundItem;

                frmAgregarMarca marca = new frmAgregarMarca(seleccionado);
                marca.ShowDialog();
                Cargar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private bool ComprobarEliminacion(int id)
        {
            List<int> listaUsados = new List<int>();
            AccesoDatos accesoDatos = new AccesoDatos();
            bool Usando = false;
            try
            {
                accesoDatos.setearConsulta("SELECT IdMarca FROM ARTICULOS");
                accesoDatos.ejecutarLectura();
                while (accesoDatos.Lector.Read())
                {
                    listaUsados.Add((int)accesoDatos.Lector["IdMarca"]);
                }
                foreach (int item in listaUsados)
                {
                    if (id == item)
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

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            Marca seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Estas seguro de eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Marca)dgvListaMarcas.CurrentRow.DataBoundItem;
                    if (!(ComprobarEliminacion(seleccionado.Id)))
                    {
                        marcaNegocio.eliminar(seleccionado.Id);
                        MessageBox.Show("Eliminado correctamente");
                        Cargar();
                    }
                    else MessageBox.Show("La Marca que intenta eliminar esta en uso");



                }

            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error al eliminar los datos, comuniquese con el servicio tecnico");
            }
        }

        private void btnBuscarMarcas_Click(object sender, EventArgs e)
        {
            string descripcion = tbBuscarMarcas.Text;
            List<Marca> listaAux = new List<Marca>(); ;
            try
            {
                if (!(descripcion == ""))
                {
                    foreach (Marca marca in listaMarca)
                    {

                        if (descripcion == marca.Descripcion)
                        {

                            listaAux.Add(marca);

                        }

                    }
                    dgvListaMarcas.DataSource = listaAux;
                    btnModificarMarcas.Enabled = true;
                    btnEliminarMarca.Enabled = true;
                    if (listaAux.Count <= 0)
                    {
                        btnModificarMarcas.Enabled = false;
                        btnEliminarMarca.Enabled = false;
                    }
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void tbBuscarMarcas_TextChanged(object sender, EventArgs e)
        {
            string texto = tbBuscarMarcas.Text;

            if (texto == "")
            {
                dgvListaMarcas.DataSource = listaMarca;
                btnModificarMarcas.Enabled = true;
                btnEliminarMarca.Enabled = true;
            }

        }
    }
}